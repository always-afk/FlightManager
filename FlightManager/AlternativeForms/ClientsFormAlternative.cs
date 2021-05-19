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
    public partial class ClientsFormAlternative : Form
    {
        public ClientsFormAlternative()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fM_DataDataSet);

        }

        private void ClientsFormAlternative_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fM_DataDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.fM_DataDataSet.Clients);
        }

        private void button_Previous_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MovePrevious();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveNext();
        }

        private void button_First_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveFirst();
        }

        private void button_Last_Click(object sender, EventArgs e)
        {
            clientsBindingSource.MoveLast();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            clientsBindingSource.AddNew();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            clientsBindingSource.RemoveCurrent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            clientsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(fM_DataDataSet);
        }

        private void ClientsFormAlternative_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
