namespace BusData
{
    partial class frEditarRutas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgEditarTrab = new System.Windows.Forms.DataGridView();
            this.lblChofer = new System.Windows.Forms.Label();
            this.btnDesAsignar = new System.Windows.Forms.Button();
            this.txtRutaId = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusId = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChoferId = new System.Windows.Forms.MaskedTextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.lblAutobus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChofer = new System.Windows.Forms.MaskedTextBox();
            this.txtAutobus = new System.Windows.Forms.MaskedTextBox();
            this.txtRuta = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEditarTrab)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgEditarTrab
            // 
            this.dvgEditarTrab.AllowUserToAddRows = false;
            this.dvgEditarTrab.AllowUserToDeleteRows = false;
            this.dvgEditarTrab.AllowUserToResizeColumns = false;
            this.dvgEditarTrab.AllowUserToResizeRows = false;
            this.dvgEditarTrab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgEditarTrab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgEditarTrab.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgEditarTrab.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgEditarTrab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgEditarTrab.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgEditarTrab.Location = new System.Drawing.Point(12, 46);
            this.dvgEditarTrab.Name = "dvgEditarTrab";
            this.dvgEditarTrab.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgEditarTrab.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgEditarTrab.RowHeadersVisible = false;
            this.dvgEditarTrab.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvgEditarTrab.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dvgEditarTrab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgEditarTrab.ShowCellToolTips = false;
            this.dvgEditarTrab.Size = new System.Drawing.Size(672, 233);
            this.dvgEditarTrab.TabIndex = 52;
            this.dvgEditarTrab.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgEditarTrab_CellClick);
            this.dvgEditarTrab.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgEditarTrab_CellContentClick);
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Font = new System.Drawing.Font("Eras Medium ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChofer.ForeColor = System.Drawing.Color.White;
            this.lblChofer.Location = new System.Drawing.Point(12, 9);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(281, 24);
            this.lblChofer.TabIndex = 53;
            this.lblChofer.Text = "Editar trabajadores asignados";
            // 
            // btnDesAsignar
            // 
            this.btnDesAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnDesAsignar.FlatAppearance.BorderSize = 0;
            this.btnDesAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesAsignar.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesAsignar.ForeColor = System.Drawing.Color.White;
            this.btnDesAsignar.Location = new System.Drawing.Point(12, 421);
            this.btnDesAsignar.Name = "btnDesAsignar";
            this.btnDesAsignar.Size = new System.Drawing.Size(672, 32);
            this.btnDesAsignar.TabIndex = 54;
            this.btnDesAsignar.Text = "Desasignar";
            this.btnDesAsignar.UseVisualStyleBackColor = false;
            this.btnDesAsignar.Click += new System.EventHandler(this.btnDesAsignar_Click);
            // 
            // txtRutaId
            // 
            this.txtRutaId.Enabled = false;
            this.txtRutaId.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.txtRutaId.Location = new System.Drawing.Point(102, 372);
            this.txtRutaId.Name = "txtRutaId";
            this.txtRutaId.Size = new System.Drawing.Size(223, 26);
            this.txtRutaId.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 69;
            this.label2.Text = "Id:";
            // 
            // txtBusId
            // 
            this.txtBusId.Enabled = false;
            this.txtBusId.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.txtBusId.Location = new System.Drawing.Point(102, 337);
            this.txtBusId.Name = "txtBusId";
            this.txtBusId.Size = new System.Drawing.Size(223, 26);
            this.txtBusId.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 67;
            this.label1.Text = "Id:";
            // 
            // txtChoferId
            // 
            this.txtChoferId.Enabled = false;
            this.txtChoferId.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.txtChoferId.Location = new System.Drawing.Point(102, 304);
            this.txtChoferId.Name = "txtChoferId";
            this.txtChoferId.Size = new System.Drawing.Size(223, 26);
            this.txtChoferId.TabIndex = 66;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(69, 308);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 19);
            this.lblId.TabIndex = 65;
            this.lblId.Text = "Id:";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.lblRuta.ForeColor = System.Drawing.Color.White;
            this.lblRuta.Location = new System.Drawing.Point(331, 376);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(46, 19);
            this.lblRuta.TabIndex = 64;
            this.lblRuta.Text = "Ruta:";
            // 
            // lblAutobus
            // 
            this.lblAutobus.AutoSize = true;
            this.lblAutobus.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.lblAutobus.ForeColor = System.Drawing.Color.White;
            this.lblAutobus.Location = new System.Drawing.Point(331, 341);
            this.lblAutobus.Name = "lblAutobus";
            this.lblAutobus.Size = new System.Drawing.Size(73, 19);
            this.lblAutobus.TabIndex = 62;
            this.lblAutobus.Text = "Autobus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(331, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 60;
            this.label3.Text = "Chofer:";
            // 
            // txtChofer
            // 
            this.txtChofer.Enabled = false;
            this.txtChofer.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.txtChofer.Location = new System.Drawing.Point(410, 304);
            this.txtChofer.Name = "txtChofer";
            this.txtChofer.Size = new System.Drawing.Size(223, 26);
            this.txtChofer.TabIndex = 71;
            // 
            // txtAutobus
            // 
            this.txtAutobus.Enabled = false;
            this.txtAutobus.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.txtAutobus.Location = new System.Drawing.Point(410, 337);
            this.txtAutobus.Name = "txtAutobus";
            this.txtAutobus.Size = new System.Drawing.Size(223, 26);
            this.txtAutobus.TabIndex = 72;
            // 
            // txtRuta
            // 
            this.txtRuta.Enabled = false;
            this.txtRuta.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.txtRuta.Location = new System.Drawing.Point(410, 369);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(223, 26);
            this.txtRuta.TabIndex = 73;
            // 
            // frEditarRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(696, 504);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.txtAutobus);
            this.Controls.Add(this.txtChofer);
            this.Controls.Add(this.txtRutaId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBusId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChoferId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.lblAutobus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDesAsignar);
            this.Controls.Add(this.lblChofer);
            this.Controls.Add(this.dvgEditarTrab);
            this.MinimumSize = new System.Drawing.Size(712, 543);
            this.Name = "frEditarRutas";
            this.Text = "frEditarRutas";
            ((System.ComponentModel.ISupportInitialize)(this.dvgEditarTrab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgEditarTrab;
        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.Button btnDesAsignar;
        private System.Windows.Forms.MaskedTextBox txtRutaId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtBusId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtChoferId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label lblAutobus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtChofer;
        private System.Windows.Forms.MaskedTextBox txtAutobus;
        private System.Windows.Forms.MaskedTextBox txtRuta;
    }
}