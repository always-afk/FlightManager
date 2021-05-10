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
        Form f;
        public AirportsForm(Form f)
        {
            InitializeComponent();

            this.f = f;
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
    }
}
