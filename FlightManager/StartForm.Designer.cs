
namespace FlightManager
{
    partial class StartForm
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
            this.button_Airports = new System.Windows.Forms.Button();
            this.button_Clients = new System.Windows.Forms.Button();
            this.button_Flights = new System.Windows.Forms.Button();
            this.button_Planes = new System.Windows.Forms.Button();
            this.button_SalesMagazine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Airports
            // 
            this.button_Airports.Location = new System.Drawing.Point(150, 50);
            this.button_Airports.Name = "button_Airports";
            this.button_Airports.Size = new System.Drawing.Size(150, 50);
            this.button_Airports.TabIndex = 0;
            this.button_Airports.Text = "Airports";
            this.button_Airports.UseVisualStyleBackColor = true;
            this.button_Airports.Click += new System.EventHandler(this.button_Airports_Click);
            // 
            // button_Clients
            // 
            this.button_Clients.Location = new System.Drawing.Point(150, 106);
            this.button_Clients.Name = "button_Clients";
            this.button_Clients.Size = new System.Drawing.Size(150, 50);
            this.button_Clients.TabIndex = 1;
            this.button_Clients.Text = "Clients";
            this.button_Clients.UseVisualStyleBackColor = true;
            this.button_Clients.Click += new System.EventHandler(this.button_Clients_Click);
            // 
            // button_Flights
            // 
            this.button_Flights.Location = new System.Drawing.Point(150, 162);
            this.button_Flights.Name = "button_Flights";
            this.button_Flights.Size = new System.Drawing.Size(150, 50);
            this.button_Flights.TabIndex = 2;
            this.button_Flights.Text = "Flights";
            this.button_Flights.UseVisualStyleBackColor = true;
            this.button_Flights.Click += new System.EventHandler(this.button_Flights_Click);
            // 
            // button_Planes
            // 
            this.button_Planes.Location = new System.Drawing.Point(150, 218);
            this.button_Planes.Name = "button_Planes";
            this.button_Planes.Size = new System.Drawing.Size(150, 50);
            this.button_Planes.TabIndex = 3;
            this.button_Planes.Text = "Planes";
            this.button_Planes.UseVisualStyleBackColor = true;
            this.button_Planes.Click += new System.EventHandler(this.button_Planes_Click);
            // 
            // button_SalesMagazine
            // 
            this.button_SalesMagazine.Location = new System.Drawing.Point(150, 274);
            this.button_SalesMagazine.Name = "button_SalesMagazine";
            this.button_SalesMagazine.Size = new System.Drawing.Size(150, 50);
            this.button_SalesMagazine.TabIndex = 4;
            this.button_SalesMagazine.Text = "Sales Magazine";
            this.button_SalesMagazine.UseVisualStyleBackColor = true;
            this.button_SalesMagazine.Click += new System.EventHandler(this.button_SalesMagazine_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.button_SalesMagazine);
            this.Controls.Add(this.button_Planes);
            this.Controls.Add(this.button_Flights);
            this.Controls.Add(this.button_Clients);
            this.Controls.Add(this.button_Airports);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Airports;
        private System.Windows.Forms.Button button_Clients;
        private System.Windows.Forms.Button button_Flights;
        private System.Windows.Forms.Button button_Planes;
        private System.Windows.Forms.Button button_SalesMagazine;
    }
}