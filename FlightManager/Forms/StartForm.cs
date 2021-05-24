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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button_Airports_Click(object sender, EventArgs e)
        {
            FormOpener.ShowForm<AirportsForm>();
        }

        private void button_Clients_Click(object sender, EventArgs e)
        {
            FormOpener.ShowForm<ClientsForm>();
        }

        private void button_Flights_Click(object sender, EventArgs e)
        {
            FormOpener.ShowForm<FlightsFormAlternative>();
        }

        private void button_Planes_Click(object sender, EventArgs e)
        {
            FormOpener.ShowForm<PlanesForm>();
        }

        private void button_SalesMagazine_Click(object sender, EventArgs e)
        {
            FormOpener.ShowForm<SalesMagazineFormAlternative>();
        }
    }
}
