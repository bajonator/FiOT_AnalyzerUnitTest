using FiOT_AnalyzerUnitTest.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiOT_AnalyzerUnitTest.Extensions
{
    public class PrepareDataFor
    {
        private SettingsDataHelper<List<DataModel>> _fileHelper = new SettingsDataHelper<List<DataModel>>(Program.FilePath);

        public void ExportDataToXML(DataGridView dataGridView)
        {
            var dataList = dataGridView.Rows.Cast<DataGridViewRow>()
                           .Select(row => new DataModel
                           {
                               ReadyForRequest = row.Cells[0].Value?.ToString(),
                               ResponseDefined = row.Cells[1].Value?.ToString(),
                               RequestDefined = row.Cells[2].Value?.ToString(),
                               ReadyForResponse = row.Cells[3].Value?.ToString(),
                               ReadyForData = row.Cells[4].Value?.ToString(),
                               DataDefined = row.Cells[5].Value?.ToString(),
                               TimeStamp = row.Cells[6].Value?.ToString(),
                               DifferenceTime = row.Cells[7].Value?.ToString(),
                               State = row.Cells[8].Value?.ToString(),
                               CellBackColors = row.Cells.Cast<DataGridViewCell>().Select(c => c.Style.BackColor.ToArgb().ToString()).ToList(),
                               CellForeColors = row.Cells.Cast<DataGridViewCell>().Select(c => c.Style.ForeColor.ToArgb().ToString()).ToList(),
                               CellFonts = row.Cells.Cast<DataGridViewCell>().Select(c => c.Style.Font?.FontFamily.Name).ToList()
                           }).ToList();

            _fileHelper.SerializeToFile(dataList);
        }

        public void LoadAndPopulateDataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            var data = _fileHelper.DeserializeFromFile();

            foreach (var item in data)
            {
                var rowIndex = dataGridView.Rows.Add(item.ReadyForRequest, item.ResponseDefined, item.RequestDefined, item.ReadyForResponse, item.ReadyForData, item.DataDefined, item.TimeStamp, item.DifferenceTime, item.State);

                var row = dataGridView.Rows[rowIndex];

                SetRowColor(item.State, rowIndex, dataGridView);

                if (item.ReadyForRequest == "1" && item.ResponseDefined == "0" && item.RequestDefined == "0" && item.ReadyForResponse == "0" && item.ReadyForData == "1" && item.DataDefined == "0")
                {
                    dataGridView.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.DarkViolet;
                }
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (int.TryParse(item.CellBackColors[i], out int backColorArgb) && backColorArgb != 0)
                    {
                        row.Cells[i].Style.BackColor = Color.FromArgb(backColorArgb);
                    }

                    if (int.TryParse(item.CellForeColors[i], out int foreColorArgb) && foreColorArgb != 0)
                    {
                        row.Cells[i].Style.ForeColor = Color.FromArgb(foreColorArgb);
                    }

                    if (!string.IsNullOrEmpty(item.CellFonts[i]))
                    {
                        row.Cells[i].Style.Font = new Font(item.CellFonts[i], row.Cells[i].Style.Font.Size);
                    }
                }
            }
        }

        /// <summary>
        /// Nastaví barvu řádku v dataGridView2 na základě hodnoty v buňce.
        /// </summary>
        /// <param name="colVal">Hodnota buňky určující barvu řádku</param>
        /// <param name="rowIndex">Index řádku, jehož barva se má změnit</param>
        public void SetRowColor(string colVal, int rowIndex, DataGridView dataGridView)
        {
            switch (colVal)
            {
                case "OK":
                    dataGridView.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    break;
                case "NG":
                    dataGridView.Rows[rowIndex].DefaultCellStyle.BackColor = Color.OrangeRed;
                    break;
                case "UNKNOW":
                    dataGridView.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Orange;
                    break;
            }
            dataGridView.ClearSelection();
        }
    }
}
