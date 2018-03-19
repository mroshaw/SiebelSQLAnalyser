using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiebelPerfLogAnalyser
{
    class PerListItem
    {
        public int LineNum {get; set;}
        public String SqlId { get; set; }
        public String Phase { get; set; }
        public String Time { get; set; }

        public PerListItem (int lineNum, String sqlId, String phase, String time)
        {
            LineNum = lineNum;
            SqlId = sqlId;
            Phase = phase;
            Time = time;
        }
    }
}
