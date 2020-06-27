namespace GraphAssignment
{
    partial class frmTravel
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
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSeek = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtDeparture = new System.Windows.Forms.TextBox();
            this.txtArrival = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.gbxFlight = new System.Windows.Forms.GroupBox();
            this.lbxFlightS = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbxFlightI = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbxFlight.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeparture.Location = new System.Drawing.Point(13, 16);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(127, 16);
            this.lblDeparture.TabIndex = 0;
            this.lblDeparture.Text = "Departure Airport";
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrival.Location = new System.Drawing.Point(13, 42);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(103, 16);
            this.lblArrival.TabIndex = 1;
            this.lblArrival.Text = "Arrival Airport";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.Location = new System.Drawing.Point(13, 68);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(69, 16);
            this.lblDistance.TabIndex = 2;
            this.lblDistance.Text = "Distance";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(51, 422);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add New Flight";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSeek
            // 
            this.btnSeek.Location = new System.Drawing.Point(176, 422);
            this.btnSeek.Name = "btnSeek";
            this.btnSeek.Size = new System.Drawing.Size(136, 23);
            this.btnSeek.TabIndex = 4;
            this.btnSeek.Text = "Seek Flight";
            this.btnSeek.UseVisualStyleBackColor = true;
            this.btnSeek.Click += new System.EventHandler(this.btnSeek_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(318, 422);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Flight";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(462, 422);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtDeparture
            // 
            this.txtDeparture.Location = new System.Drawing.Point(283, 12);
            this.txtDeparture.Multiline = true;
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(362, 20);
            this.txtDeparture.TabIndex = 7;
            // 
            // txtArrival
            // 
            this.txtArrival.Location = new System.Drawing.Point(283, 38);
            this.txtArrival.Multiline = true;
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.Size = new System.Drawing.Size(362, 20);
            this.txtArrival.TabIndex = 8;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(283, 64);
            this.txtDistance.Multiline = true;
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(362, 20);
            this.txtDistance.TabIndex = 9;
            // 
            // gbxFlight
            // 
            this.gbxFlight.Controls.Add(this.lbxFlightS);
            this.gbxFlight.Location = new System.Drawing.Point(12, 121);
            this.gbxFlight.Name = "gbxFlight";
            this.gbxFlight.Size = new System.Drawing.Size(300, 295);
            this.gbxFlight.TabIndex = 10;
            this.gbxFlight.TabStop = false;
            this.gbxFlight.Text = "Flight Schedule ";
            // 
            // lbxFlightS
            // 
            this.lbxFlightS.BackColor = System.Drawing.SystemColors.Control;
            this.lbxFlightS.FormattingEnabled = true;
            this.lbxFlightS.Location = new System.Drawing.Point(8, 19);
            this.lbxFlightS.Name = "lbxFlightS";
            this.lbxFlightS.Size = new System.Drawing.Size(286, 264);
            this.lbxFlightS.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.lbxFlightI);
            this.groupBox2.Location = new System.Drawing.Point(318, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 295);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flight Information";
            // 
            // lbxFlightI
            // 
            this.lbxFlightI.FormattingEnabled = true;
            this.lbxFlightI.Location = new System.Drawing.Point(7, 20);
            this.lbxFlightI.Name = "lbxFlightI";
            this.lbxFlightI.Size = new System.Drawing.Size(314, 264);
            this.lbxFlightI.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(526, 90);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear All Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmTravel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 457);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxFlight);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.txtArrival);
            this.Controls.Add(this.txtDeparture);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSeek);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblArrival);
            this.Controls.Add(this.lblDeparture);
            this.Name = "frmTravel";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.frmTravel_Load);
            this.gbxFlight.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSeek;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtDeparture;
        private System.Windows.Forms.TextBox txtArrival;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.GroupBox gbxFlight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lbxFlightS;
        private System.Windows.Forms.ListBox lbxFlightI;
    }
}

