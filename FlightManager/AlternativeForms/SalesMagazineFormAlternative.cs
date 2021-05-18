﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightManager.AlternativeForms
{
    public partial class SalesMagazineFormAlternative : Form
    {
        Form Form;
        public SalesMagazineFormAlternative(Form form)
        {
            InitializeComponent();
            Form = form;
        }

        private void salesMagazineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesMagazineBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fM_DataDataSet);

        }

        private void SalesMagazineFormAlternative_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fM_DataDataSet.SalesMagazine". При необходимости она может быть перемещена или удалена.
            this.salesMagazineTableAdapter.Fill(this.fM_DataDataSet.SalesMagazine);

            Form.Visible = false;
        }

        private void button_Previous_Click(object sender, EventArgs e)
        {
            salesMagazineBindingSource.MovePrevious();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            salesMagazineBindingSource.MoveNext();
        }

        private void button_First_Click(object sender, EventArgs e)
        {
            salesMagazineBindingSource.MoveFirst();
        }

        private void button_Last_Click(object sender, EventArgs e)
        {
            salesMagazineBindingSource.MoveLast();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            salesMagazineBindingSource.AddNew();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            salesMagazineBindingSource.RemoveCurrent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            salesMagazineBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(fM_DataDataSet);
        }

        private void SalesMagazineFormAlternative_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form.Visible = true;
        }
    }
}