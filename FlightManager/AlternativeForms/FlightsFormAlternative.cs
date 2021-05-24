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
    public partial class FlightsFormAlternative : Form
    {
        public FlightsFormAlternative()
        {
            InitializeComponent();
        }

        private void FlightsFormAlternative_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fM_DataDataSet.Planes". При необходимости она может быть перемещена или удалена.
            this.planesTableAdapter.Fill(this.fM_DataDataSet.Planes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fM_DataDataSet.Airports". При необходимости она может быть перемещена или удалена.
            this.airportsTableAdapter.Fill(this.fM_DataDataSet.Airports);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fM_DataDataSet.Planes". При необходимости она может быть перемещена или удалена.
            this.planesTableAdapter.Fill(this.fM_DataDataSet.Planes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fM_DataDataSet.Airports". При необходимости она может быть перемещена или удалена.
            this.airportsTableAdapter.Fill(this.fM_DataDataSet.Airports);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fM_DataDataSet.Flights". При необходимости она может быть перемещена или удалена.
            this.flightsTableAdapter.Fill(this.fM_DataDataSet.Flights);
        }

        private void FlightsFormAlternative_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void flightsBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.flightsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fM_DataDataSet);

        }

        private void button_Previous_Click(object sender, EventArgs e)
        {
            flightsBindingSource.MovePrevious();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            flightsBindingSource.MoveNext();
        }

        private void button_First_Click(object sender, EventArgs e)
        {
            flightsBindingSource.MoveFirst();
        }

        private void button_Last_Click(object sender, EventArgs e)
        {
            flightsBindingSource.MoveLast();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            flightsBindingSource.AddNew();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            flightsBindingSource.RemoveCurrent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            flightsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(fM_DataDataSet);
        }

        private void button_Airports_Click(object sender, EventArgs e)
        {
            FormOpener.ShowForm<AirportsForm>();
        }

        private void button_Planes_Click(object sender, EventArgs e)
        {
            FormOpener.ShowForm<PlanesForm>();
        }
    }
}
