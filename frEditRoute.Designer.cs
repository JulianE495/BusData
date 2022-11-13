namespace BusData
{
    partial class frEditRoute
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNombreR = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditarRuta = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtFinR = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInicioR = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgRuta = new System.Windows.Forms.DataGridView();
            this.btnGuardarEdicion = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnElimanarRuta = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRuta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreR
            // 
            this.txtNombreR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreR.Enabled = false;
            this.txtNombreR.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F);
            this.txtNombreR.Location = new System.Drawing.Point(153, 222);
            this.txtNombreR.Name = "txtNombreR";
            this.txtNombreR.Size = new System.Drawing.Size(504, 29);
            this.txtNombreR.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 58;
            this.label3.Text = "Ruta:";
            // 
            // btnEditarRuta
            // 
            this.btnEditarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnEditarRuta.FlatAppearance.BorderSize = 0;
            this.btnEditarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarRuta.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarRuta.ForeColor = System.Drawing.Color.White;
            this.btnEditarRuta.Image = global::BusData.Properties.Resources.icons8_edit_30px;
            this.btnEditarRuta.Location = new System.Drawing.Point(11, 327);
            this.btnEditarRuta.Name = "btnEditarRuta";
            this.btnEditarRuta.Size = new System.Drawing.Size(152, 40);
            this.btnEditarRuta.TabIndex = 57;
            this.btnEditarRuta.UseVisualStyleBackColor = false;
            this.btnEditarRuta.Click += new System.EventHandler(this.btnEditarRuta_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(102, 22);
            this.lblTitulo.TabIndex = 56;
            this.lblTitulo.Text = "Editar Ruta";
            // 
            // txtFinR
            // 
            this.txtFinR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFinR.Enabled = false;
            this.txtFinR.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F);
            this.txtFinR.Location = new System.Drawing.Point(153, 292);
            this.txtFinR.Name = "txtFinR";
            this.txtFinR.Size = new System.Drawing.Size(504, 29);
            this.txtFinR.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 54;
            this.label2.Text = "Final de Ruta:";
            // 
            // txtInicioR
            // 
            this.txtInicioR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInicioR.Enabled = false;
            this.txtInicioR.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F);
            this.txtInicioR.Location = new System.Drawing.Point(153, 257);
            this.txtInicioR.Name = "txtInicioR";
            this.txtInicioR.Size = new System.Drawing.Size(504, 29);
            this.txtInicioR.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 52;
            this.label1.Text = "Inicio de Ruta:";
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
            this.dvgRuta.Location = new System.Drawing.Point(12, 36);
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
            this.dvgRuta.Size = new System.Drawing.Size(656, 132);
            this.dvgRuta.TabIndex = 60;
            this.dvgRuta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgRuta_CellClick);
            // 
            // btnGuardarEdicion
            // 
            this.btnGuardarEdicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnGuardarEdicion.Enabled = false;
            this.btnGuardarEdicion.FlatAppearance.BorderSize = 0;
            this.btnGuardarEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEdicion.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEdicion.ForeColor = System.Drawing.Color.White;
            this.btnGuardarEdicion.Image = global::BusData.Properties.Resources.icons8_save_30px_2;
            this.btnGuardarEdicion.Location = new System.Drawing.Point(180, 327);
            this.btnGuardarEdicion.Name = "btnGuardarEdicion";
            this.btnGuardarEdicion.Size = new System.Drawing.Size(152, 40);
            this.btnGuardarEdicion.TabIndex = 61;
            this.btnGuardarEdicion.UseVisualStyleBackColor = false;
            this.btnGuardarEdicion.Click += new System.EventHandler(this.btnGuardarEdicion_Click);
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F);
            this.txtId.Location = new System.Drawing.Point(153, 187);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(504, 29);
            this.txtId.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 22);
            this.label4.TabIndex = 62;
            this.label4.Text = "Id:";
            // 
            // btnElimanarRuta
            // 
            this.btnElimanarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnElimanarRuta.FlatAppearance.BorderSize = 0;
            this.btnElimanarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimanarRuta.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimanarRuta.ForeColor = System.Drawing.Color.White;
            this.btnElimanarRuta.Image = global::BusData.Properties.Resources.icons8_delete_30px_1;
            this.btnElimanarRuta.Location = new System.Drawing.Point(349, 327);
            this.btnElimanarRuta.Name = "btnElimanarRuta";
            this.btnElimanarRuta.Size = new System.Drawing.Size(152, 40);
            this.btnElimanarRuta.TabIndex = 64;
            this.btnElimanarRuta.UseVisualStyleBackColor = false;
            this.btnElimanarRuta.Click += new System.EventHandler(this.btnElimanarRuta_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnCancelEdit.FlatAppearance.BorderSize = 0;
            this.btnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelEdit.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.ForeColor = System.Drawing.Color.White;
            this.btnCancelEdit.Image = global::BusData.Properties.Resources.icons8_cancel_30px;
            this.btnCancelEdit.Location = new System.Drawing.Point(518, 327);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(152, 40);
            this.btnCancelEdit.TabIndex = 65;
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Visible = false;
            // 
            // frEditRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(680, 415);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btnElimanarRuta);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardarEdicion);
            this.Controls.Add(this.dvgRuta);
            this.Controls.Add(this.txtNombreR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEditarRuta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtFinR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInicioR);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(696, 454);
            this.Name = "frEditRoute";
            this.Text = "frEditRoute";
            ((System.ComponentModel.ISupportInitialize)(this.dvgRuta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtNombreR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditarRuta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.MaskedTextBox txtFinR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtInicioR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgRuta;
        private System.Windows.Forms.Button btnGuardarEdicion;
        private System.Windows.Forms.MaskedTextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnElimanarRuta;
        private System.Windows.Forms.Button btnCancelEdit;
    }
}