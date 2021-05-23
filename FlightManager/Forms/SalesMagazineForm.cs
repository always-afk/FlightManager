using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightManager.Forms;

namespace FlightManager
{
    public partial class SalesMagazineForm : Form
    {
        public SalesMagazineForm()
        {
            InitializeComponent();
        }

        private void salesMagazineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesMagazineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fM_DataDataSet);

        }

        private void SalesMagazineForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fM_DataDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.fM_DataDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fM_DataDataSet.SalesMagazine". При необходимости она может быть перемещена или удалена.
            this.salesMagazineTableAdapter.Fill(this.fM_DataDataSet.SalesMagazine);

        }

        private void button_Alternative_Click(object sender, EventArgs e)
        {
            FormOpener.ShowForm<SalesMagazineFormAlternative>();
        }

        private void button_Filter_Click(object sender, EventArgs e)
        {
            salesMagazineBindingSource.Filter = $"IdClient = {comboBox1.SelectedValue}";
            
        }

        private void button_RemoveFilter_Click(object sender, EventArgs e)
        {
            salesMagazineBindingSource.RemoveFilter();
        }

        private void button_Clients_Click(object sender, EventArgs e)
        {
            FormOpener.ShowForm<ClientsForm>();
        }

        private void button_Flights_Click(object sender, EventArgs e)
        {
            FormOpener.ShowForm<FlightsForm>();
        }

        private void button_Report_Click(object sender, EventArgs e)
        {
            FormOpener.ShowForm<SalesMagazineReportForm>();
        }

        private void SalesMagazineForm_Activated(object sender, EventArgs e)
        {
            this.salesMagazineTableAdapter.Fill(this.fM_DataDataSet.SalesMagazine);
        }
    }
}
