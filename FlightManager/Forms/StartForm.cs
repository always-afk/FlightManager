﻿using System;
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
        bool airports, clients, flights, planes, sales;
        public StartForm()
        {
            InitializeComponent();

            airports = false;
            clients = false;
            flights = false;
            planes = false;
            sales = false;
        }

        private void button_Airports_Click(object sender, EventArgs e)
        {
            if (airports)
            {
                AirportsForm f = new AirportsForm();
                f.Show();
            }           
        }

        private void button_Clients_Click(object sender, EventArgs e)
        {
            ClientsForm f = new ClientsForm();
            f.Show();
        }

        private void button_Flights_Click(object sender, EventArgs e)
        {
            FlightsForm f = new FlightsForm();
            f.Show();
        }

        private void button_Planes_Click(object sender, EventArgs e)
        {
            PlanesForm f = new PlanesForm();
            f.Show();
        }

        private void button_SalesMagazine_Click(object sender, EventArgs e)
        {
            SalesMagazineForm f = new SalesMagazineForm();
            f.Show();
        }
    }
}