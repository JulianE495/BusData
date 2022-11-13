namespace BusData
{
    partial class frDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frDriver));
            this.pnTopMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.pnMainDriver = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnTopMenu.SuspendLayout();
            this.pnMainDriver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTopMenu
            // 
            this.pnTopMenu.Controls.Add(this.button2);
            this.pnTopMenu.Controls.Add(this.btnAddDriver);
            this.pnTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopMenu.Location = new System.Drawing.Point(0, 0);
            this.pnTopMenu.Name = "pnTopMenu";
            this.pnTopMenu.Size = new System.Drawing.Size(696, 50);
            this.pnTopMenu.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(71, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 50);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // pnMainDriver
            // 
            this.pnMainDriver.Controls.Add(this.pictureBox1);
            this.pnMainDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMainDriver.Location = new System.Drawing.Point(0, 50);
            this.pnMainDriver.Name = "pnMainDriver";
            this.pnMainDriver.Size = new System.Drawing.Size(696, 454);
            this.pnMainDriver.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BusData.Properties.Resources.driver__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(696, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(696, 504);
            this.Controls.Add(this.pnMainDriver);
            this.Controls.Add(this.pnTopMenu);
            this.MinimumSize = new System.Drawing.Size(712, 543);
            this.Name = "frDriver";
            this.Text = "frDriver";
            this.pnTopMenu.ResumeLayout(false);
            this.pnMainDriver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTopMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.Panel pnMainDriver;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}