using FiOT_AnalyzerUnitTest.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiOT_AnalyzerUnitTest
{
    public partial class ShowSavedData : Form
    {
        private SettingsDataHelper<List<DataModel>> _fileHelper = new SettingsDataHelper<List<DataModel>>(Program.FilePath);

        public ShowSavedData()
        {
            InitializeComponent();
            dataGridView2.ClearSelection();
            dataGridView2.CurrentCell = null;
        }


        /// <summary>
        /// Obsluha události pro import dat ze souboru xml do dataGridView2.
        /// </summary>
        private void LoadData()
        {
            dataGridView2.CellValueChanged -= dataGridView2_CellValueChanged;

            dataGridView2.Rows.Clear();
            var data = _fileHelper.DeserializeFromFile();

            foreach (var item in data)
            {
                var rowIndex = dataGridView2.Rows.Add(item.ReadyForRequest, item.ResponseDefined, item.RequestDefined, item.ReadyForResponse, item.ReadyForData, item.DataDefined, item.TimeStamp, item.DifferenceTime, item.State);

                var row = dataGridView2.Rows[rowIndex];

                SetRowColor(item.State, rowIndex);

                if (item.ReadyForRequest == "1" && item.ResponseDefined == "0" && item.RequestDefined == "0" && item.ReadyForResponse == "0" && item.ReadyForData == "1" && item.DataDefined == "0")
                {
                    dataGridView2.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.DarkGreen;
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

            dataGridView2.CellValueChanged += dataGridView2_CellValueChanged;

        }


        /// <summary>
        /// Obsluha události pro změny hodnoty buňky v dataGridView2. Aktualizuje barvu řádku na základě nové hodnoty buňky.
        /// </summary>
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var colVal = dataGridView2.SelectedRows[0].Cells[e.ColumnIndex].Value as string;
            SetRowColor(colVal, e.RowIndex);
        }


        /// <summary>
        /// Nastaví barvu řádku v dataGridView2 na základě hodnoty v buňce.
        /// </summary>
        /// <param name="colVal">Hodnota buňky určující barvu řádku</param>
        /// <param name="rowIndex">Index řádku, jehož barva se má změnit</param>
        private void SetRowColor(string colVal, int rowIndex)
        {
            switch (colVal)
            {
                case "OK":
                    dataGridView2.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Green;
                    break;
                case "NG":
                    dataGridView2.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                    break;
                case "UNKNOW":
                    dataGridView2.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Orange;
                    break;
            }
        }


        /// <summary>
        /// Obsluha události pro import dat ze souboru xml do dataGridView2.
        /// </summary>
        private void btnExportXml_Click(object sender, EventArgs e)
        {
            var dataList = new List<DataModel>();
            if (dataGridView2.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    var model = new DataModel
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
                    };

                    dataList.Add(model);
                }
            }
            _fileHelper.SerializeToFile(dataList);
        }



        private void btnImportXml_Click(object sender, EventArgs e)
        {
            LoadData();
            dataGridView2.ClearSelection();
            dataGridView2.CurrentCell = null;
        }

        private void ShowSavedData_Load(object sender, EventArgs e)
        {
            LoadData();

            dataGridView2.ClearSelection();
            dataGridView2.CurrentCell = null;
        }

        private void dataGridView2_MouseDown(object sender, MouseEventArgs e)
        {
            ClearDatagridViewSelection(e);
        }

        private void ShowSavedData_MouseDown(object sender, MouseEventArgs e)
        {
            ClearDatagridViewSelection(e);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ClearDatagridViewSelection(e);
        }

        private void ClearDatagridViewSelection(MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dataGridView2.HitTest(e.X, e.Y);

            if (hit.Type != DataGridViewHitTestType.Cell)
            {
                dataGridView2.ClearSelection();
            }
        }
    }
}
