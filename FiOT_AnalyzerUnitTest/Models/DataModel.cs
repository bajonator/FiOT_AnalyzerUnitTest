using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiOT_AnalyzerUnitTest
{
    public class DataModel
    {
        public string ReadyForRequest { get; set; }
        public string ResponseDefined { get; set; }
        public string RequestDefined { get; set; }
        public string ReadyForResponse { get; set; }
        public string ReadyForData { get; set; }
        public string DataDefined { get; set; }
        public string TimeStamp {  get; set; }
        public string DifferenceTime { get; set; }
        public string ColorCell { get; set; }
        public string State {  get; set; }

        public List<string> CellBackColors { get; set; } = new List<string>();
        public List<string> CellForeColors { get; set; } = new List<string>();
        public List<string> CellFonts { get; set; } = new List<string>();
    }
}