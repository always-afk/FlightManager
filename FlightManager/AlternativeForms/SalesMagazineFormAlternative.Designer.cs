
namespace FlightManager
{
    partial class SalesMagazineFormAlternative
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
            System.Windows.Forms.Label idClientLabel;
            System.Windows.Forms.Label idFlightLabel;
            System.Windows.Forms.Label dateSaleLabel;
            System.Windows.Forms.Label dateFlightLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesMagazineFormAlternative));
            this.button_First = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Last = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Previous = new System.Windows.Forms.Button();
            this.fM_DataDataSet = new FlightManager.FM_DataDataSet();
            this.salesMagazineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesMagazineTableAdapter = new FlightManager.FM_DataDataSetTableAdapters.SalesMagazineTableAdapter();
            this.tableAdapterManager = new FlightManager.FM_DataDataSetTableAdapters.TableAdapterManager();
            this.clientsTableAdapter = new FlightManager.FM_DataDataSetTableAdapters.ClientsTableAdapter();
            this.flightsTableAdapter = new FlightManager.FM_DataDataSetTableAdapters.FlightsTableAdapter();
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
            this.dateSaleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateFlightDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_Report = new System.Windows.Forms.Button();
            this.button_Flights = new System.Windows.Forms.Button();
            this.button_Clients = new System.Windows.Forms.Button();
            idClientLabel = new System.Windows.Forms.Label();
            idFlightLabel = new System.Windows.Forms.Label();
            dateSaleLabel = new System.Windows.Forms.Label();
            dateFlightLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fM_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesMagazineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesMagazineBindingNavigator)).BeginInit();
            this.salesMagazineBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idClientLabel
            // 
            idClientLabel.AutoSize = true;
            idClientLabel.Location = new System.Drawing.Point(22, 39);
            idClientLabel.Name = "idClientLabel";
            idClientLabel.Size = new System.Drawing.Size(48, 13);
            idClientLabel.TabIndex = 44;
            idClientLabel.Text = "Id Client:";
            // 
            // idFlightLabel
            // 
            idFlightLabel.AutoSize = true;
            idFlightLabel.Location = new System.Drawing.Point(22, 65);
            idFlightLabel.Name = "idFlightLabel";
            idFlightLabel.Size = new System.Drawing.Size(47, 13);
            idFlightLabel.TabIndex = 46;
            idFlightLabel.Text = "Id Flight:";
            // 
            // dateSaleLabel
            // 
            dateSaleLabel.AutoSize = true;
            dateSaleLabel.Location = new System.Drawing.Point(22, 92);
            dateSaleLabel.Name = "dateSaleLabel";
            dateSaleLabel.Size = new System.Drawing.Size(57, 13);
            dateSaleLabel.TabIndex = 48;
            dateSaleLabel.Text = "Date Sale:";
            // 
            // dateFlightLabel
            // 
            dateFlightLabel.AutoSize = true;
            dateFlightLabel.Location = new System.Drawing.Point(22, 118);
            dateFlightLabel.Name = "dateFlightLabel";
            dateFlightLabel.Size = new System.Drawing.Size(61, 13);
            dateFlightLabel.TabIndex = 50;
            dateFlightLabel.Text = "Date Flight:";
            // 
            // button_First
            // 
            this.button_First.Location = new System.Drawing.Point(182, 157);
            this.button_First.Name = "button_First";
            this.button_First.Size = new System.Drawing.Size(75, 22);
            this.button_First.TabIndex = 41;
            this.button_First.Text = "First";
            this.button_First.UseVisualStyleBackColor = true;
            this.button_First.Click += new System.EventHandler(this.button_First_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(182, 186);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 22);
            this.button_Save.TabIndex = 40;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(101, 186);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 22);
            this.button_Delete.TabIndex = 39;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(20, 186);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 22);
            this.button_Add.TabIndex = 38;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Last
            // 
            this.button_Last.Location = new System.Drawing.Point(263, 157);
            this.button_Last.Name = "button_Last";
            this.button_Last.Size = new System.Drawing.Size(75, 22);
            this.button_Last.TabIndex = 37;
            this.button_Last.Text = "Last";
            this.button_Last.UseVisualStyleBackColor = true;
            this.button_Last.Click += new System.EventHandler(this.button_Last_Click);
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(101, 157);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(75, 22);
            this.button_Next.TabIndex = 36;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Previous
            // 
            this.button_Previous.Location = new System.Drawing.Point(20, 157);
            this.button_Previous.Name = "button_Previous";
            this.button_Previous.Size = new System.Drawing.Size(75, 22);
            this.button_Previous.TabIndex = 35;
            this.button_Previous.Text = "Previous";
            this.button_Previous.UseVisualStyleBackColor = true;
            this.button_Previous.Click += new System.EventHandler(this.button_Previous_Click);
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
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.FlightsTableAdapter = this.flightsTableAdapter;
            this.tableAdapterManager.PlanesTableAdapter = null;
            this.tableAdapterManager.SalesMagazineTableAdapter = this.salesMagazineTableAdapter;
            this.tableAdapterManager.UpdateOrder = FlightManager.FM_DataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // flightsTableAdapter
            // 
            this.flightsTableAdapter.ClearBeforeFill = true;
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
            this.salesMagazineBindingNavigator.Size = new System.Drawing.Size(381, 25);
            this.salesMagazineBindingNavigator.TabIndex = 42;
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
            this.salesMagazineBindingNavigatorSaveItem.Click += new System.EventHandler(this.salesMagazineBindingNavigatorSaveItem_Click_1);
            // 
            // dateSaleDateTimePicker
            // 
            this.dateSaleDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.salesMagazineBindingSource, "DateSale", true));
            this.dateSaleDateTimePicker.Location = new System.Drawing.Point(89, 88);
            this.dateSaleDateTimePicker.Name = "dateSaleDateTimePicker";
            this.dateSaleDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateSaleDateTimePicker.TabIndex = 49;
            // 
            // dateFlightDateTimePicker
            // 
            this.dateFlightDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.salesMagazineBindingSource, "DateFlight", true));
            this.dateFlightDateTimePicker.Location = new System.Drawing.Point(89, 114);
            this.dateFlightDateTimePicker.Name = "dateFlightDateTimePicker";
            this.dateFlightDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateFlightDateTimePicker.TabIndex = 51;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesMagazineBindingSource, "IdClient", true));
            this.comboBox1.DataSource = this.clientsBindingSource;
            this.comboBox1.DisplayMember = "PassportId";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 52;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.fM_DataDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.salesMagazineBindingSource, "IdFlight", true));
            this.comboBox2.DataSource = this.flightsBindingSource;
            this.comboBox2.DisplayMember = "Id";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(89, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 53;
            this.comboBox2.ValueMember = "Id";
            // 
            // flightsBindingSource
            // 
            this.flightsBindingSource.DataMember = "Flights";
            this.flightsBindingSource.DataSource = this.fM_DataDataSet;
            // 
            // button_Report
            // 
            this.button_Report.Location = new System.Drawing.Point(295, 97);
            this.button_Report.Name = "button_Report";
            this.button_Report.Size = new System.Drawing.Size(75, 23);
            this.button_Report.TabIndex = 56;
            this.button_Report.Text = "Report";
            this.button_Report.UseVisualStyleBackColor = true;
            this.button_Report.Click += new System.EventHandler(this.button_Report_Click);
            // 
            // button_Flights
            // 
            this.button_Flights.Location = new System.Drawing.Point(295, 68);
            this.button_Flights.Name = "button_Flights";
            this.button_Flights.Size = new System.Drawing.Size(75, 23);
            this.button_Flights.TabIndex = 55;
            this.button_Flights.Text = "Flights";
            this.button_Flights.UseVisualStyleBackColor = true;
            this.button_Flights.Click += new System.EventHandler(this.button_Flights_Click);
            // 
            // button_Clients
            // 
            this.button_Clients.Location = new System.Drawing.Point(295, 39);
            this.button_Clients.Name = "button_Clients";
            this.button_Clients.Size = new System.Drawing.Size(75, 23);
            this.button_Clients.TabIndex = 54;
            this.button_Clients.Text = "Clients";
            this.button_Clients.UseVisualStyleBackColor = true;
            this.button_Clients.Click += new System.EventHandler(this.button_Clients_Click);
            // 
            // SalesMagazineFormAlternative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 231);
            this.Controls.Add(this.button_Report);
            this.Controls.Add(this.button_Flights);
            this.Controls.Add(this.button_Clients);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(idClientLabel);
            this.Controls.Add(idFlightLabel);
            this.Controls.Add(dateSaleLabel);
            this.Controls.Add(this.dateSaleDateTimePicker);
            this.Controls.Add(dateFlightLabel);
            this.Controls.Add(this.dateFlightDateTimePicker);
            this.Controls.Add(this.salesMagazineBindingNavigator);
            this.Controls.Add(this.button_First);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Last);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Previous);
            this.Name = "SalesMagazineFormAlternative";
            this.Text = "SalesMagazineFormAlternative";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalesMagazineFormAlternative_FormClosed);
            this.Load += new System.EventHandler(this.SalesMagazineFormAlternative_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fM_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesMagazineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesMagazineBindingNavigator)).EndInit();
            this.salesMagazineBindingNavigator.ResumeLayout(false);
            this.salesMagazineBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_First;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Last;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Previous;
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
        private FM_DataDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DateTimePicker dateSaleDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateFlightDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private FM_DataDataSetTableAdapters.FlightsTableAdapter flightsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource flightsBindingSource;
        private System.Windows.Forms.Button button_Report;
        private System.Windows.Forms.Button button_Flights;
        private System.Windows.Forms.Button button_Clients;
    }
}