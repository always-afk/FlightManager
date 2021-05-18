using System;
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
    public partial class PlanesFormAlternative : Form
    {
        public PlanesFormAlternative()
        {
            InitializeComponent();
        }

        private void planesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.planesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fM_DataDataSet);

        }

        private void PlanesFormAlternative_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fM_DataDataSet.Planes". При необходимости она может быть перемещена или удалена.
            this.planesTableAdapter.Fill(this.fM_DataDataSet.Planes);

        }

        private void button_Previous_Click(object sender, EventArgs e)
        {
            planesBindingSource.MovePrevious();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            planesBindingSource.MoveNext();
        }

        private void button_First_Click(object sender, EventArgs e)
        {
            planesBindingSource.MoveFirst();
        }

        private void button_Last_Click(object sender, EventArgs e)
        {
            planesBindingSource.MoveLast();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            planesBindingSource.AddNew();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            planesBindingSource.RemoveCurrent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            planesBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(fM_DataDataSet);
        }
    }
}
