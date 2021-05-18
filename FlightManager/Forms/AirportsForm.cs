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
    public partial class AirportsForm : Form
    {
        public AirportsForm()
        {
            InitializeComponent();
        }

        private void airportsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.airportsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fM_DataDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fM_DataDataSet.Airports". При необходимости она может быть перемещена или удалена.
            this.airportsTableAdapter.Fill(this.fM_DataDataSet.Airports);

        }

        private void button_Alternative_Click(object sender, EventArgs e)
        {
            AirportsFormAlternative form2 = new AirportsFormAlternative(this);
            form2.Show();
        }
    }
}