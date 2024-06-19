using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiOT_AnalyzerUnitTest.Helpers
{
    public class FileHelper
    {
        public string GetFileName()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.InitialDirectory = @"A:\003 PRODUCTS\A021 MES OPC\Tool pro analýzu logu komunikace\OPCDataLogger";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return null;
        }
    }
}
