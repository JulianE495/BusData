namespace BusData
{
    partial class frRoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frRoute));
            this.pnTopMenu = new System.Windows.Forms.Panel();
            this.btnEditRoute = new System.Windows.Forms.Button();
            this.btnAddRoute = new System.Windows.Forms.Button();
            this.pnRouteMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnTopMenu.SuspendLayout();
            this.pnRouteMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTopMenu
            // 
            this.pnTopMenu.Controls.Add(this.btnEditRoute);
            this.pnTopMenu.Controls.Add(this.btnAddRoute);
            this.pnTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopMenu.Location = new System.Drawing.Point(0, 0);
            this.pnTopMenu.Name = "pnTopMenu";
            this.pnTopMenu.Size = new System.Drawing.Size(696, 50);
            this.pnTopMenu.TabIndex = 3;
            // 
            // btnEditRoute
            // 
            this.btnEditRoute.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEditRoute.FlatAppearance.BorderSize = 0;
            this.btnEditRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRoute.Image = global::BusData.Properties.Resources.icons8_edit_30px;
            this.btnEditRoute.Location = new System.Drawing.Point(71, 0);
            this.btnEditRoute.Name = "btnEditRoute";
            this.btnEditRoute.Size = new System.Drawing.Size(71, 50);
            this.btnEditRoute.TabIndex = 1;
            this.btnEditRoute.UseVisualStyleBackColor = true;
            this.btnEditRoute.Click += new System.EventHandler(this.btnEditRoute_Click);
            // 
            // btnAddRoute
            // 
            this.btnAddRoute.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddRoute.FlatAppearance.BorderSize = 0;
            this.btnAddRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoute.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoute.Image")));
            this.btnAddRoute.Location = new System.Drawing.Point(0, 0);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(71, 50);
            this.btnAddRoute.TabIndex = 0;
            this.btnAddRoute.UseVisualStyleBackColor = true;
            this.btnAddRoute.Click += new System.EventHandler(this.btnAddRoute_Click);
            // 
            // pnRouteMain
            // 
            this.pnRouteMain.Controls.Add(this.pictureBox1);
            this.pnRouteMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRouteMain.Location = new System.Drawing.Point(0, 50);
            this.pnRouteMain.Name = "pnRouteMain";
            this.pnRouteMain.Size = new System.Drawing.Size(696, 454);
            this.pnRouteMain.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BusData.Properties.Resources.route;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(696, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(696, 504);
            this.Controls.Add(this.pnRouteMain);
            this.Controls.Add(this.pnTopMenu);
            this.MinimumSize = new System.Drawing.Size(712, 543);
            this.Name = "frRoute";
            this.Text = "frRoute";
            this.pnTopMenu.ResumeLayout(false);
            this.pnRouteMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTopMenu;
        private System.Windows.Forms.Button btnEditRoute;
        private System.Windows.Forms.Button btnAddRoute;
        private System.Windows.Forms.Panel pnRouteMain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}