
namespace FlightManager
{
    partial class SalesMagazineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesMagazineForm));
            this.fM_DataDataSet = new FlightManager.FM_DataDataSet();
            this.salesMagazineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesMagazineTableAdapter = new FlightManager.FM_DataDataSetTableAdapters.SalesMagazineTableAdapter();
            this.tableAdapterManager = new FlightManager.FM_DataDataSetTableAdapters.TableAdapterManager();
            this.salesMagazineBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salesMagazineBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.salesMagazineDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Alternative = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Filter = new System.Windows.Forms.Button();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new FlightManager.FM_DataDataSetTableAdapters.ClientsTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_RemoveFilter = new System.Windows.Forms.Button();
            this.button_Clients = new System.Windows.Forms.Button();
            this.button_Flights = new System.Windows.Forms.Button();
            this.button_Report = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fM_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesMagazineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesMagazineBindingNavigator)).BeginInit();
            this.salesMagazineBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesMagazineDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fM_DataDataSet
            // 
            this.fM_DataDataSet.DataSetName = "FM_DataDataSet";
            this.fM_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesMagazineBindingSource
            // 
            this.salesMagazineBindingSource.DataMember = "SalesMagazine";
            this.salesMagazineBindingSource.DataSource = this.fM_DataDataSet;
            // 
            // salesMagazineTableAdapter
            // 
            this.salesMagazineTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirportsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.FlightsTableAdapter = null;
            this.tableAdapterManager.PlanesTableAdapter = null;
            this.tableAdapterManager.SalesMagazineTableAdapter = this.salesMagazineTableAdapter;
            this.tableAdapterManager.UpdateOrder = FlightManager.FM_DataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // salesMagazineBindingNavigator
            // 
            this.salesMagazineBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.salesMagazineBindingNavigator.BindingSource = this.salesMagazineBindingSource;
            this.salesMagazineBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.salesMagazineBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.salesMagazineBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.salesMagazineBindingNavigatorSaveItem});
            this.salesMagazineBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.salesMagazineBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.salesMagazineBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.salesMagazineBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.salesMagazineBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.salesMagazineBindingNavigator.Name = "salesMagazineBindingNavigator";
            this.salesMagazineBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.salesMagazineBindingNavigator.Size = new System.Drawing.Size(563, 25);
            this.salesMagazineBindingNavigator.TabIndex = 0;
            this.salesMagazineBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // salesMagazineBindingNavigatorSaveItem
            // 
            this.salesMagazineBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salesMagazineBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("salesMagazineBindingNavigatorSaveItem.Image")));
            this.salesMagazineBindingNavigatorSaveItem.Name = "salesMagazineBindingNavigatorSaveItem";
            this.salesMagazineBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.salesMagazineBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.salesMagazineBindingNavigatorSaveItem.Click += new System.EventHandler(this.salesMagazineBindingNavigatorSaveItem_Click);
            // 
            // salesMagazineDataGridView
            // 
            this.salesMagazineDataGridView.AutoGenerateColumns = false;
            this.salesMagazineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesMagazineDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.salesMagazineDataGridView.DataSource = this.salesMagazineBindingSource;
            this.salesMagazineDataGridView.Location = new System.Drawing.Point(12, 66);
            this.salesMagazineDataGridView.Name = "salesMagazineDataGridView";
            this.salesMagazineDataGridView.Size = new System.Drawing.Size(458, 372);
            this.salesMagazineDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdClient";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdClient";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdFlight";
            this.dataGridViewTextBoxColumn3.HeaderText = "IdFlight";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateSale";
            this.dataGridViewTextBoxColumn4.HeaderText = "DateSale";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateFlight";
            this.dataGridViewTextBoxColumn5.HeaderText = "DateFlight";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button_Alternative
            // 
            this.button_Alternative.Location = new System.Drawing.Point(318, 1);
            this.button_Alternative.Name = "button_Alternative";
            this.button_Alternative.Size = new System.Drawing.Size(75, 23);
            this.button_Alternative.TabIndex = 2;
            this.button_Alternative.Text = "Alternative";
            this.button_Alternative.UseVisualStyleBackColor = true;
            this.button_Alternative.Click += new System.EventHandler(this.button_Alternative_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            // 
            // button_Filter
            // 
            this.button_Filter.Location = new System.Drawing.Point(476, 66);
            this.button_Filter.Name = "button_Filter";
            this.button_Filter.Size = new System.Drawing.Size(75, 23);
            this.button_Filter.TabIndex = 7;
            this.button_Filter.Text = "Filter";
            this.button_Filter.UseVisualStyleBackColor = true;
            this.button_Filter.Click += new System.EventHandler(this.button_Filter_Click);
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.fM_DataDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clientsBindingSource;
            this.comboBox1.DisplayMember = "PassportId";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "Id";
            // 
            // button_RemoveFilter
            // 
            this.button_RemoveFilter.Location = new System.Drawing.Point(476, 95);
            this.button_RemoveFilter.Name = "button_RemoveFilter";
            this.button_RemoveFilter.Size = new System.Drawing.Size(75, 40);
            this.button_RemoveFilter.TabIndex = 9;
            this.button_RemoveFilter.Text = "Remove Filter";
            this.button_RemoveFilter.UseVisualStyleBackColor = true;
            this.button_RemoveFilter.Click += new System.EventHandler(this.button_RemoveFilter_Click);
            // 
            // button_Clients
            // 
            this.button_Clients.Location = new System.Drawing.Point(476, 142);
            this.button_Clients.Name = "button_Clients";
            this.button_Clients.Size = new System.Drawing.Size(75, 23);
            this.button_Clients.TabIndex = 10;
            this.button_Clients.Text = "Clients";
            this.button_Clients.UseVisualStyleBackColor = true;
            this.button_Clients.Click += new System.EventHandler(this.button_Clients_Click);
            // 
            // button_Flights
            // 
            this.button_Flights.Location = new System.Drawing.Point(476, 171);
            this.button_Flights.Name = "button_Flights";
            this.button_Flights.Size = new System.Drawing.Size(75, 23);
            this.button_Flights.TabIndex = 11;
            this.button_Flights.Text = "Flights";
            this.button_Flights.UseVisualStyleBackColor = true;
            this.button_Flights.Click += new System.EventHandler(this.button_Flights_Click);
            // 
            // button_Report
            // 
            this.button_Report.Location = new System.Drawing.Point(476, 200);
            this.button_Report.Name = "button_Report";
            this.button_Report.Size = new System.Drawing.Size(75, 23);
            this.button_Report.TabIndex = 12;
            this.button_Report.Text = "Report";
            this.button_Report.UseVisualStyleBackColor = true;
            this.button_Report.Click += new System.EventHandler(this.button_Report_Click);
            // 
            // SalesMagazineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.button_Report);
            this.Controls.Add(this.button_Flights);
            this.Controls.Add(this.button_Clients);
            this.Controls.Add(this.button_RemoveFilter);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_Filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Alternative);
            this.Controls.Add(this.salesMagazineDataGridView);
            this.Controls.Add(this.salesMagazineBindingNavigator);
            this.Name = "SalesMagazineForm";
            this.Text = "SalesMagazineForm";
            this.Activated += new System.EventHandler(this.SalesMagazineForm_Activated);
            this.Load += new System.EventHandler(this.SalesMagazineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fM_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesMagazineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesMagazineBindingNavigator)).EndInit();
            this.salesMagazineBindingNavigator.ResumeLayout(false);
            this.salesMagazineBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesMagazineDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FM_DataDataSet fM_DataDataSet;
        private System.Windows.Forms.BindingSource salesMagazineBindingSource;
        private FM_DataDataSetTableAdapters.SalesMagazineTableAdapter salesMagazineTableAdapter;
        private FM_DataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator salesMagazineBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton salesMagazineBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView salesMagazineDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button_Alternative;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Filter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private FM_DataDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_RemoveFilter;
        private System.Windows.Forms.Button button_Clients;
        private System.Windows.Forms.Button button_Flights;
        private System.Windows.Forms.Button button_Report;
    }
}