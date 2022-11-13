namespace BusData
{
    partial class frAsignarBusRuta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtChofer = new System.Windows.Forms.ComboBox();
            this.lblChofer = new System.Windows.Forms.Label();
            this.lblAutobus = new System.Windows.Forms.Label();
            this.txtAutobus = new System.Windows.Forms.ComboBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.ComboBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.dgvBus = new System.Windows.Forms.DataGridView();
            this.dvgChofer = new System.Windows.Forms.DataGridView();
            this.dvgRuta = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.txtChoferId = new System.Windows.Forms.MaskedTextBox();
            this.txtBusId = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRutaId = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgChofer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRuta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtChofer
            // 
            this.txtChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtChofer.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.txtChofer.FormattingEnabled = true;
            this.txtChofer.Location = new System.Drawing.Point(387, 360);
            this.txtChofer.Name = "txtChofer";
            this.txtChofer.Size = new System.Drawing.Size(238, 27);
            this.txtChofer.TabIndex = 13;
            this.txtChofer.SelectedIndexChanged += new System.EventHandler(this.txtChofer_SelectedIndexChanged);
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.lblChofer.ForeColor = System.Drawing.Color.White;
            this.lblChofer.Location = new System.Drawing.Point(323, 364);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(62, 19);
            this.lblChofer.TabIndex = 14;
            this.lblChofer.Text = "Chofer:";
            // 
            // lblAutobus
            // 
            this.lblAutobus.AutoSize = true;
            this.lblAutobus.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.lblAutobus.ForeColor = System.Drawing.Color.White;
            this.lblAutobus.Location = new System.Drawing.Point(323, 397);
            this.lblAutobus.Name = "lblAutobus";
            this.lblAutobus.Size = new System.Drawing.Size(73, 19);
            this.lblAutobus.TabIndex = 16;
            this.lblAutobus.Text = "Autobus:";
            // 
            // txtAutobus
            // 
            this.txtAutobus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtAutobus.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.txtAutobus.FormattingEnabled = true;
            this.txtAutobus.Location = new System.Drawing.Point(402, 393);
            this.txtAutobus.Name = "txtAutobus";
            this.txtAutobus.Size = new System.Drawing.Size(223, 27);
            this.txtAutobus.TabIndex = 15;
            this.txtAutobus.SelectedIndexChanged += new System.EventHandler(this.txtAutobus_SelectedIndexChanged);
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.lblRuta.ForeColor = System.Drawing.Color.White;
            this.lblRuta.Location = new System.Drawing.Point(323, 432);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(46, 19);
            this.lblRuta.TabIndex = 18;
            this.lblRuta.Text = "Ruta:";
            // 
            // txtRuta
            // 
            this.txtRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRuta.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.txtRuta.FormattingEnabled = true;
            this.txtRuta.Location = new System.Drawing.Point(387, 428);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(238, 27);
            this.txtRuta.TabIndex = 17;
            this.txtRuta.SelectedIndexChanged += new System.EventHandler(this.txtRuta_SelectedIndexChanged);
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnAsignar.FlatAppearance.BorderSize = 0;
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.ForeColor = System.Drawing.Color.White;
            this.btnAsignar.Location = new System.Drawing.Point(65, 461);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(560, 32);
            this.btnAsignar.TabIndex = 49;
            this.btnAsignar.Text = "Asignar......";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // dgvBus
            // 
            this.dgvBus.AllowUserToAddRows = false;
            this.dgvBus.AllowUserToDeleteRows = false;
            this.dgvBus.AllowUserToResizeColumns = false;
            this.dgvBus.AllowUserToResizeRows = false;
            this.dgvBus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBus.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBus.Location = new System.Drawing.Point(12, 119);
            this.dgvBus.Name = "dgvBus";
            this.dgvBus.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBus.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBus.RowHeadersVisible = false;
            this.dgvBus.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvBus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBus.ShowCellToolTips = false;
            this.dgvBus.Size = new System.Drawing.Size(672, 101);
            this.dgvBus.TabIndex = 50;
            // 
            // dvgChofer
            // 
            this.dvgChofer.AllowUserToAddRows = false;
            this.dvgChofer.AllowUserToDeleteRows = false;
            this.dvgChofer.AllowUserToResizeColumns = false;
            this.dvgChofer.AllowUserToResizeRows = false;
            this.dvgChofer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgChofer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgChofer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgChofer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgChofer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgChofer.DefaultCellStyle = dataGridViewCellStyle5;
            this.dvgChofer.Location = new System.Drawing.Point(12, 12);
            this.dvgChofer.Name = "dvgChofer";
            this.dvgChofer.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgChofer.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dvgChofer.RowHeadersVisible = false;
            this.dvgChofer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvgChofer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dvgChofer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgChofer.ShowCellToolTips = false;
            this.dvgChofer.Size = new System.Drawing.Size(672, 101);
            this.dvgChofer.TabIndex = 51;
            // 
            // dvgRuta
            // 
            this.dvgRuta.AllowUserToAddRows = false;
            this.dvgRuta.AllowUserToDeleteRows = false;
            this.dvgRuta.AllowUserToResizeColumns = false;
            this.dvgRuta.AllowUserToResizeRows = false;
            this.dvgRuta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgRuta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgRuta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgRuta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dvgRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgRuta.DefaultCellStyle = dataGridViewCellStyle8;
            this.dvgRuta.Location = new System.Drawing.Point(12, 226);
            this.dvgRuta.Name = "dvgRuta";
            this.dvgRuta.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgRuta.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dvgRuta.RowHeadersVisible = false;
            this.dvgRuta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dvgRuta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dvgRuta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgRuta.ShowCellToolTips = false;
            this.dvgRuta.Size = new System.Drawing.Size(672, 101);
            this.dvgRuta.TabIndex = 52;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(61, 364);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 19);
            this.lblId.TabIndex = 53;
            this.lblId.Text = "Id:";
            // 
            // txtChoferId
            // 
            this.txtChoferId.Enabled = false;
            this.txtChoferId.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.txtChoferId.Location = new System.Drawing.Point(94, 360);
            this.txtChoferId.Name = "txtChoferId";
            this.txtChoferId.Size = new System.Drawing.Size(223, 26);
            this.txtChoferId.TabIndex = 54;
            // 
            // txtBusId
            // 
            this.txtBusId.Enabled = false;
            this.txtBusId.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.txtBusId.Location = new System.Drawing.Point(94, 393);
            this.txtBusId.Name = "txtBusId";
            this.txtBusId.Size = new System.Drawing.Size(223, 26);
            this.txtBusId.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 19);
            this.label1.TabIndex = 55;
            this.label1.Text = "Id:";
            // 
            // txtRutaId
            // 
            this.txtRutaId.Enabled = false;
            this.txtRutaId.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.txtRutaId.Location = new System.Drawing.Point(94, 428);
            this.txtRutaId.Name = "txtRutaId";
            this.txtRutaId.Size = new System.Drawing.Size(223, 26);
            this.txtRutaId.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 19);
            this.label2.TabIndex = 57;
            this.label2.Text = "Id:";
            // 
            // frAsignarBusRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(696, 504);
            this.Controls.Add(this.txtRutaId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBusId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChoferId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dvgRuta);
            this.Controls.Add(this.dvgChofer);
            this.Controls.Add(this.dgvBus);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.lblAutobus);
            this.Controls.Add(this.txtAutobus);
            this.Controls.Add(this.lblChofer);
            this.Controls.Add(this.txtChofer);
            this.MinimumSize = new System.Drawing.Size(712, 543);
            this.Name = "frAsignarBusRuta";
            this.Text = "frAsignarBusRuta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgChofer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRuta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox txtChofer;
        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.Label lblAutobus;
        private System.Windows.Forms.ComboBox txtAutobus;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.ComboBox txtRuta;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.DataGridView dgvBus;
        private System.Windows.Forms.DataGridView dvgChofer;
        private System.Windows.Forms.DataGridView dvgRuta;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.MaskedTextBox txtChoferId;
        private System.Windows.Forms.MaskedTextBox txtBusId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtRutaId;
        private System.Windows.Forms.Label label2;
    }
}