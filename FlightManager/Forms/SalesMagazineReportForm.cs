using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManager.Forms
{
    public partial class SalesMagazineReportForm : Form
    {
        public SalesMagazineReportForm()
        {
            InitializeComponent();
        }

        private void SalesMagazineReportForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fM_DataDataSet.SalesMagazineReport". При необходимости она может быть перемещена или удалена.
            this.salesMagazineReportTableAdapter.Fill(this.fM_DataDataSet.SalesMagazineReport);

            this.reportViewer1.RefreshReport();
        }

        private void button_RemoveFilter_Click(object sender, EventArgs e)
        {
            salesMagazineReportBindingSource.RemoveFilter();
            reportViewer1.RefreshReport();
        }

        private void button_FilterPassport_Click(object sender, EventArgs e)
        {
            salesMagazineReportBindingSource.Filter = "PassportId = " + comboBox1.SelectedValue;
            reportViewer1.RefreshReport();
        }

        private void button_FilterData_Click(object sender, EventArgs e)
        {
            string DateFrom = dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss");
            string DateTo = dateTimePicker2.Value.ToString("yyyy-MM-dd hh:mm:ss");
            salesMagazineReportBindingSource.Filter = $"DateSale >= '{DateFrom}' AND DateSale <= '{DateTo}'";
            reportViewer1.RefreshReport();
        }
    }
}
