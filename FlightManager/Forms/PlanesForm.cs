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
    public partial class PlanesForm : Form
    {
        public PlanesForm()
        {
            InitializeComponent();
        }

        private void planesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.planesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fM_DataDataSet);

        }

        private void PlanesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fM_DataDataSet.Planes". При необходимости она может быть перемещена или удалена.
            this.planesTableAdapter.Fill(this.fM_DataDataSet.Planes);

        }

        private void button_Alternative_Click(object sender, EventArgs e)
        {
            FormOpener.ShowForm<PlanesForm>();
        }
    }
}
