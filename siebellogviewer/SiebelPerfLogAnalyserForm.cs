using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using BrightIdeasSoftware;
namespace SiebelPerfLogAnalyser
{
    /// <summary>
    /// Main Siebel log analyser application
    /// </summary>
    public partial class SiebLogForm : Form
    {
        private List<PerListItem> listOfPerfItems;
        private Boolean isServer;
        private int currLine;
        // private String[] logLines;
        private ScintillaNET.LineCollection logLines;
        private int numLines;

        public SiebLogForm()
        {
            InitializeComponent();
            InitiScintilla();
            listOfPerfItems = new List<PerListItem>();
        }

        /// <summary>
        /// Opens the 'Open Log File' dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFile_Click(object sender, EventArgs e)
        {
            openLog();
        }

        private void InitiScintilla()
        {
            logFileContent.Margins[0].Width = 32;
        }

        /// <summary>
        /// Main function to open and process the log file
        /// </summary>
        private void openLog()
        {
            // Show the dialog and continue if a file is picked
            if (openLogFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                // Determine size of file. Due to memory contraints, limit file size to 50MB
                FileInfo fInfo = new FileInfo(openLogFile.FileName);
                DialogResult result = DialogResult.Yes;

                if (fInfo.Length > 52428800)
                {
                    result = MessageBox.Show("Log files of 50MB and less are supported by the application. The log file you have selected is too large. Try anyway?", "Attempt to open large file", MessageBoxButtons.YesNo);
                }

                if (result == DialogResult.Yes)
                {

                    // Populate the Log File name
                    logFileName.Text = Path.GetFileName(openLogFile.FileName);

                    StreamReader sr2 = null;

                    // Try to open the log file is a StreamReader. Respond appropriately if this fails
                    try
                    {
                        sr2 = new System.IO.StreamReader(openLogFile.FileName, Encoding.Default);
                    }
                    catch (Exception errFile)
                    {
                        MessageBox.Show("An error has occurred opening the file." +
                        Environment.NewLine + errFile.Message);
                    }

                    // If we have a valid file handle, open the file and populate the control with the text contents
                    if (sr2 != null)
                    {
                        try
                        {
                            // Set up 'working' controls and initialise
                            toolStripStatusLabel.Text = "Processing... Log";
                            // TODO - Progress init
                            Application.DoEvents();
                            logFileContent.Text = "";
                            this.Cursor = Cursors.WaitCursor;

                            // Refresh controls
                            Application.DoEvents();

                            // Use StringBuilder as this could be a massive Replace process, depending on the file size
                            StringBuilder sb = new StringBuilder(sr2.ReadToEnd());

                            // Siebel uses a mixture of UNIX and Windows line terminators which confuse the 'Lines' control property
                            // Strip these out and replace with Environment specific NewLine
                            sb.Replace("\r", "").Replace("\n", Environment.NewLine);
                            logFileContent.Text = sb.ToString();

                            // Set up 'complete' controls
                            Application.DoEvents();
                            // TODO - progress complete
                        }
                        catch (OutOfMemoryException errMem)
                        {
                            // Handle out of memory exception
                            MessageBox.Show("An error has occurred reading the file. The log file is too large to be handled by the application." +
                                Environment.NewLine + errMem.Message);
                        }
                        catch (Exception errFile)
                        {
                            // Handle any other exception as a file error
                            MessageBox.Show("An error has occurred reading the file" +
                                Environment.NewLine + errFile.Message);
                        }
                        finally
                        {
                            // Close the file and dispose of it, whether the process succeeds or fails
                            sr2.Close();
                            Application.DoEvents();
                            sr2.Dispose();
                            this.Cursor = Cursors.Default;
                            toolStripStatusLabel.Text = "Ready";
                        }

                    }
                }
            }
        }

        /// <summary>
        /// Processes the Server log
        /// </summary>
        /// <param name="line"></param>
        /// <param name="lineNum"></param>
        /// <param name="arrLen"></param>
        private void processServer()
        {

            // Set up some variables
            String sqlId;
            String sqlPhase;
            String sqlTime;

            int colonPos;
            int idPos;
            int timePos;
            String strLine;

            // Clear the results
            listOfPerfItems = new List<PerListItem>();
            objectListViewPerfItems.ClearObjects();

            foreach (ScintillaNET.Line logLine in logLines)
            {

                strLine = logLine.Text;
                // Parse for SQL details
                if (strLine.IndexOf("SQL Statement") != -1)
                {
                    // Get phase
                    sqlPhase = strLine.Substring(strLine.IndexOf("***** SQL Statement") + 20, 13).Trim();

                    // Depending on the phase, the SQL time will appear in a slightly different place on the String
                    if (sqlPhase == "Prepare Time" || sqlPhase == "Execute Time" || sqlPhase == "Initial Fetch")
                    {

                        // Get position of colon
                        colonPos = strLine.IndexOf(":");
                        idPos = strLine.IndexOf("ID");
                        timePos = colonPos + 1;

                        // Get the SQL ID
                        sqlId = strLine.Substring(idPos + 3, colonPos - idPos - 3);

                        // Get time
                        sqlTime = strLine.Substring(timePos + 1, 5);

                        // Add to the ListView
                        listOfPerfItems.Add(new PerListItem(currLine, sqlId, sqlPhase, sqlTime));
                    }
                }
                // Advance the process indicator
                progressBar.Value = Convert.ToInt32((currLine * 100) / numLines);
                currLine++;
            }
        }

        /// <summary>
        /// Processes the Client spool log
        /// </summary>
        /// <param name="line"></param>
        /// <param name="lineNum"></param>
        /// <param name="arrLen"></param>
        private void processClient()
        {

            // Set up some variables
            String sqlId="";
            // String sqlPhase;
            String sqlTime;

            int colonPos;
            int timePos;
            int sqlLine=0;
            String strLine;

            foreach (ScintillaNET.Line line in logLines)
            {
                strLine = line.Text;
                if (strLine.IndexOf("SELECT statement with ID") != -1)
                {
                    sqlId = strLine.Substring(26);
                    sqlLine = currLine;
                }

                // Parse for SQL details
                if (strLine.IndexOf("***** SQL Statement Execute Time") != -1)
                {

                    // Get position of colon
                    colonPos = strLine.IndexOf(":");
                    timePos = colonPos + 1;

                    // Get time
                    sqlTime = strLine.Substring(timePos + 1, 5);

                    // Add to the ListView
                    // String[] row = { sqlId, sqlPhase, sqlTime };
                    // this.sqlListView.Items.Add(lineNum.ToString()).SubItems.AddRange(row);

                    listOfPerfItems.Add(new PerListItem(sqlLine, sqlId, "Execute", sqlTime));

                    // This would be used if we implemented Parallelism. Not used for now
                    // this.addRow(row, lineNum, arrLen);
                }
                // Advance the process indicator
                progressBar.Value = Convert.ToInt32((currLine * 100) / numLines);
                currLine++;
            }
        }

        /// <summary>
        /// Handle form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SiebLogForm_Load(object sender, EventArgs e)
        {
            // Set the tool strip status
            toolStripStatusLabel.Text = "Ready";
        }

        /// <summary>
        /// Handle the 'Exit' file option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        /// <summary>
        ///  Handle the 'About' file option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display 'About' box
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        /// <summary>
        /// Handle the 'Open' file option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openLogFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Call the openLog function to open and process the file
            openLog();
        }

        /// <summary>
        /// Handle the right click 'Copy' option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Copy selected text into the clipboard as plain text
            Clipboard.SetData(DataFormats.Text, logFileContent.SelectedText);
         }

        private void toolStripMenuItemHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.lifeaftersiebel.co.uk/#contact-us");
        }

        private void objectListViewPerfItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Determine line number from the selected list element
            ObjectListView olv = (ObjectListView)sender;
            PerListItem selectedItem = (PerListItem)olv.SelectedObject;
            if (selectedItem != null)
            {
                int lineNum = selectedItem.LineNum;
                GotoLine(lineNum);
                logFileContent.Focus();
            }
        }

        private void GotoLine(int lineNumber)
        {
            if (lineNumber > logFileContent.Lines.Count)
                return;

            logFileContent.Lines[lineNumber - 1].Goto();
        }

        private void buttonAnalyse_Click(object sender, EventArgs e)
        {
            isServer = radioButtonServer.Checked;

            // Start processing entries
            toolStripStatusLabel.Text = "Processing... SQL statements";
            Application.DoEvents();

            // Parse the log
            try
            {
                // Set up 'processing' controls

                // TODO: Progress control
                progressBar.Value = 0;

                logLines = logFileContent.Lines;
                numLines = logLines.Count;
                currLine = 1;

                if (isServer)
                {
                    processServer();
                }
                else
                {
                    processClient();
                }
            }
            catch (Exception er)
            {
                // Catch all exception handler
                toolStripStatusLabel.Text = "The process failed: " + er.ToString();
            }
            finally
            {
                // Set up 'complete' controls
                this.Cursor = Cursors.Default;
                toolStripStatusLabel.Text = "Ready";

                // TODO - Progress complete
                progressBar.Value = 100;
            }

            // Populate the Object List View
            objectListViewPerfItems.Items.Clear();
            objectListViewPerfItems.SetObjects(listOfPerfItems);
            // Sort by time descending
            objectListViewPerfItems.Sort(olvColumnTime, SortOrder.Descending);
        }

        private void objectListViewPerfItems_MouseUp(object sender, MouseEventArgs e)
        {
            logFileContent.Focus();
        }
    }
}
