
namespace FlightManager
{
    partial class AirportsFormAlternative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirportsFormAlternative));
            System.Windows.Forms.Label iATALabel;
            System.Windows.Forms.Label nameLabel;
            this.fM_DataDataSet = new FlightManager.FM_DataDataSet();
            this.airportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportsTableAdapter = new FlightManager.FM_DataDataSetTableAdapters.AirportsTableAdapter();
            this.tableAdapterManager = new FlightManager.FM_DataDataSetTableAdapters.TableAdapterManager();
            this.airportsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.airportsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iATATextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.button_Previous = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Last = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_First = new System.Windows.Forms.Button();
            iATALabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fM_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingNavigator)).BeginInit();
            this.airportsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // fM_DataDataSet
            // 
            this.fM_DataDataSet.DataSetName = "FM_DataDataSet";
            this.fM_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airportsBindingSource
            // 
            this.airportsBindingSource.DataMember = "Airports";
            this.airportsBindingSource.DataSource = this.fM_DataDataSet;
            // 
            // airportsTableAdapter
            // 
            this.airportsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AirportsTableAdapter = this.airportsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.FlightsTableAdapter = null;
            this.tableAdapterManager.PlanesTableAdapter = null;
            this.tableAdapterManager.SalesMagazineTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FlightManager.FM_DataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // airportsBindingNavigator
            // 
            this.airportsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.airportsBindingNavigator.BindingSource = this.airportsBindingSource;
            this.airportsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.airportsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.airportsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.airportsBindingNavigatorSaveItem});
            this.airportsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.airportsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.airportsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.airportsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.airportsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.airportsBindingNavigator.Name = "airportsBindingNavigator";
            this.airportsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.airportsBindingNavigator.Size = new System.Drawing.Size(416, 25);
            this.airportsBindingNavigator.TabIndex = 0;
            this.airportsBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // airportsBindingNavigatorSaveItem
            // 
            this.airportsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.airportsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("airportsBindingNavigatorSaveItem.Image")));
            this.airportsBindingNavigatorSaveItem.Name = "airportsBindingNavigatorSaveItem";
            this.airportsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.airportsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.airportsBindingNavigatorSaveItem.Click += new System.EventHandler(this.airportsBindingNavigatorSaveItem_Click);
            // 
            // iATALabel
            // 
            iATALabel.AutoSize = true;
            iATALabel.Location = new System.Drawing.Point(28, 53);
            iATALabel.Name = "iATALabel";
            iATALabel.Size = new System.Drawing.Size(34, 13);
            iATALabel.TabIndex = 3;
            iATALabel.Text = "IATA:";
            // 
            // iATATextBox
            // 
            this.iATATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airportsBindingSource, "IATA", true));
            this.iATATextBox.Location = new System.Drawing.Point(92, 50);
            this.iATATextBox.Name = "iATATextBox";
            this.iATATextBox.Size = new System.Drawing.Size(104, 20);
            this.iATATextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(28, 79);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.airportsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(92, 76);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(246, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // button_Previous
            // 
            this.button_Previous.Location = new System.Drawing.Point(20, 143);
            this.button_Previous.Name = "button_Previous";
            this.button_Previous.Size = new System.Drawing.Size(75, 23);
            this.button_Previous.TabIndex = 7;
            this.button_Previous.Text = "Previous";
            this.button_Previous.UseVisualStyleBackColor = true;
            this.button_Previous.Click += new System.EventHandler(this.button_Previous_Click);
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(101, 143);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(75, 23);
            this.button_Next.TabIndex = 8;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Last
            // 
            this.button_Last.Location = new System.Drawing.Point(263, 143);
            this.button_Last.Name = "button_Last";
            this.button_Last.Size = new System.Drawing.Size(75, 23);
            this.button_Last.TabIndex = 9;
            this.button_Last.Text = "Last";
            this.button_Last.UseVisualStyleBackColor = true;
            this.button_Last.Click += new System.EventHandler(this.button_Last_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(20, 172);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 10;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(101, 172);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 11;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(182, 172);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 12;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_First
            // 
            this.button_First.Location = new System.Drawing.Point(182, 143);
            this.button_First.Name = "button_First";
            this.button_First.Size = new System.Drawing.Size(75, 23);
            this.button_First.TabIndex = 13;
            this.button_First.Text = "First";
            this.button_First.UseVisualStyleBackColor = true;
            this.button_First.Click += new System.EventHandler(this.button_First_Click);
            // 
            // AirportsForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 223);
            this.Controls.Add(this.button_First);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Last);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Previous);
            this.Controls.Add(iATALabel);
            this.Controls.Add(this.iATATextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.airportsBindingNavigator);
            this.Name = "AirportsForm2";
            this.Text = "AirportsForm2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AirportsForm2_FormClosed);
            this.Load += new System.EventHandler(this.AirportsForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fM_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingNavigator)).EndInit();
            this.airportsBindingNavigator.ResumeLayout(false);
            this.airportsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FM_DataDataSet fM_DataDataSet;
        private System.Windows.Forms.BindingSource airportsBindingSource;
        private FM_DataDataSetTableAdapters.AirportsTableAdapter airportsTableAdapter;
        private FM_DataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator airportsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton airportsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iATATextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button button_Previous;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Last;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_First;
    }
}