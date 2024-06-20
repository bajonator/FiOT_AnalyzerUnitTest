using FiOT_AnalyzerUnitTest.Extensions;
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
        private PrepareDataFor _prepareDataFor;

        public ShowSavedData()
        {
            InitializeComponent();
            _prepareDataFor = new PrepareDataFor();
        }

        /// <summary>
        /// Obsluha události pro import dat ze souboru xml do dataGridView2.
        /// </summary>
        private void LoadData()
        {
            dataGridView2.CellValueChanged -= dataGridView2_CellValueChanged;
            
            _prepareDataFor.LoadAndPopulateDataGridView(dataGridView2);
            dataGridView2.ClearSelection();
            dataGridView2.CurrentCell = null;

            dataGridView2.CellValueChanged += dataGridView2_CellValueChanged;
        }      

        /// <summary>
        /// Obsluha události pro změny hodnoty buňky v dataGridView2. Aktualizuje barvu řádku na základě nové hodnoty buňky.
        /// </summary>
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var colVal = dataGridView2.SelectedRows[0].Cells[e.ColumnIndex].Value as string;
            _prepareDataFor.SetRowColor(colVal, e.RowIndex, dataGridView2);
        }

        /// <summary>
        /// Obsluha události pro import dat ze souboru xml do dataGridView.
        /// </summary>
        private void btnExportXml_Click(object sender, EventArgs e)
        {
            _prepareDataFor.ExportDataToXML(dataGridView2);
        }


        private void btnImportXml_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ShowSavedData_Load(object sender, EventArgs e)
        {
            LoadData();
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
