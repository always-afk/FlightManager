using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManager
{
    public partial class AirportsFormAlternative : Form
    {
        public AirportsFormAlternative()
        {
            InitializeComponent();
        }

        private void airportsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.airportsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fM_DataDataSet);

        }

        private void AirportsForm2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fM_DataDataSet.Airports". При необходимости она может быть перемещена или удалена.
            this.airportsTableAdapter.Fill(this.fM_DataDataSet.Airports);
        }

        private void button_Previous_Click(object sender, EventArgs e)
        {
            airportsBindingNavigator.BindingSource.MovePrevious();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            airportsBindingNavigator.BindingSource.MoveNext();
        }

        private void button_First_Click(object sender, EventArgs e)
        {
            airportsBindingNavigator.BindingSource.MoveFirst();
        }

        private void button_Last_Click(object sender, EventArgs e)
        {
            airportsBindingNavigator.BindingSource.MoveLast();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            airportsBindingNavigator.BindingSource.AddNew();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            airportsBindingNavigator.BindingSource.RemoveCurrent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            airportsBindingNavigator.BindingSource.EndEdit();
            tableAdapterManager.UpdateAll(fM_DataDataSet);
        }

        private void AirportsForm2_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
