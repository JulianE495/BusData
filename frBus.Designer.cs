namespace BusData
{
    partial class frBus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frBus));
            this.pnTopMenu = new System.Windows.Forms.Panel();
            this.btnEditBus = new System.Windows.Forms.Button();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.pnBusMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnTopMenu.SuspendLayout();
            this.pnBusMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTopMenu
            // 
            this.pnTopMenu.Controls.Add(this.btnEditBus);
            this.pnTopMenu.Controls.Add(this.btnAddDriver);
            this.pnTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopMenu.Location = new System.Drawing.Point(0, 0);
            this.pnTopMenu.Name = "pnTopMenu";
            this.pnTopMenu.Size = new System.Drawing.Size(696, 50);
            this.pnTopMenu.TabIndex = 2;
            // 
            // btnEditBus
            // 
            this.btnEditBus.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEditBus.FlatAppearance.BorderSize = 0;
            this.btnEditBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBus.Image = global::BusData.Properties.Resources.icons8_edit_30px;
            this.btnEditBus.Location = new System.Drawing.Point(71, 0);
            this.btnEditBus.Name = "btnEditBus";
            this.btnEditBus.Size = new System.Drawing.Size(71, 50);
            this.btnEditBus.TabIndex = 1;
            this.btnEditBus.UseVisualStyleBackColor = true;
            this.btnEditBus.Click += new System.EventHandler(this.btnEditBus_Click);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddDriver.FlatAppearance.BorderSize = 0;
            this.btnAddDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDriver.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDriver.Image")));
            this.btnAddDriver.Location = new System.Drawing.Point(0, 0);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(71, 50);
            this.btnAddDriver.TabIndex = 0;
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddBus_Click);
            // 
            // pnBusMain
            // 
            this.pnBusMain.Controls.Add(this.pictureBox1);
            this.pnBusMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBusMain.Location = new System.Drawing.Point(0, 50);
            this.pnBusMain.Name = "pnBusMain";
            this.pnBusMain.Size = new System.Drawing.Size(696, 454);
            this.pnBusMain.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BusData.Properties.Resources.escuela_de_autobuses;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(696, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(696, 504);
            this.Controls.Add(this.pnBusMain);
            this.Controls.Add(this.pnTopMenu);
            this.MinimumSize = new System.Drawing.Size(712, 543);
            this.Name = "frBus";
            this.Text = "Form3";
            this.pnTopMenu.ResumeLayout(false);
            this.pnBusMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTopMenu;
        private System.Windows.Forms.Button btnEditBus;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.Panel pnBusMain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}