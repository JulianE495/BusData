namespace BusData
{
    partial class frEditDriver
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
            this.dgvConductores = new System.Windows.Forms.DataGridView();
            this.pnData = new System.Windows.Forms.Panel();
            this.btnGuardarEdit = new System.Windows.Forms.Button();
            this.btnEditarConductor = new System.Windows.Forms.Button();
            this.btnEliminarConductor = new System.Windows.Forms.Button();
            this.cbSangre = new System.Windows.Forms.ComboBox();
            this.lbSangre = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lbFechaDeNacimiento = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.lbCedula = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.MaskedTextBox();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.MaskedTextBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConductores)).BeginInit();
            this.pnData.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConductores
            // 
            this.dgvConductores.AllowUserToAddRows = false;
            this.dgvConductores.AllowUserToDeleteRows = false;
            this.dgvConductores.AllowUserToResizeColumns = false;
            this.dgvConductores.AllowUserToResizeRows = false;
            this.dgvConductores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConductores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConductores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConductores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConductores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConductores.Location = new System.Drawing.Point(12, 12);
            this.dgvConductores.Name = "dgvConductores";
            this.dgvConductores.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConductores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConductores.RowHeadersVisible = false;
            this.dgvConductores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvConductores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvConductores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConductores.ShowCellToolTips = false;
            this.dgvConductores.Size = new System.Drawing.Size(656, 163);
            this.dgvConductores.TabIndex = 0;
            this.dgvConductores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConductores_CellClick);
            // 
            // pnData
            // 
            this.pnData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnData.Controls.Add(this.btnCancelEdit);
            this.pnData.Controls.Add(this.btnGuardarEdit);
            this.pnData.Controls.Add(this.btnEditarConductor);
            this.pnData.Controls.Add(this.btnEliminarConductor);
            this.pnData.Controls.Add(this.cbSangre);
            this.pnData.Controls.Add(this.lbSangre);
            this.pnData.Controls.Add(this.lbSexo);
            this.pnData.Controls.Add(this.cbSexo);
            this.pnData.Controls.Add(this.dtpDOB);
            this.pnData.Controls.Add(this.lbFechaDeNacimiento);
            this.pnData.Controls.Add(this.txtCedula);
            this.pnData.Controls.Add(this.lbCedula);
            this.pnData.Controls.Add(this.txtDireccion);
            this.pnData.Controls.Add(this.lbDireccion);
            this.pnData.Controls.Add(this.txtApellido);
            this.pnData.Controls.Add(this.lbApellido);
            this.pnData.Controls.Add(this.txtNombre);
            this.pnData.Controls.Add(this.lbNombre);
            this.pnData.Location = new System.Drawing.Point(12, 199);
            this.pnData.Name = "pnData";
            this.pnData.Size = new System.Drawing.Size(656, 204);
            this.pnData.TabIndex = 1;
            // 
            // btnGuardarEdit
            // 
            this.btnGuardarEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGuardarEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnGuardarEdit.FlatAppearance.BorderSize = 0;
            this.btnGuardarEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEdit.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEdit.ForeColor = System.Drawing.Color.White;
            this.btnGuardarEdit.Image = global::BusData.Properties.Resources.icons8_save_30px_2;
            this.btnGuardarEdit.Location = new System.Drawing.Point(530, 100);
            this.btnGuardarEdit.Name = "btnGuardarEdit";
            this.btnGuardarEdit.Size = new System.Drawing.Size(123, 40);
            this.btnGuardarEdit.TabIndex = 48;
            this.btnGuardarEdit.UseVisualStyleBackColor = false;
            this.btnGuardarEdit.Visible = false;
            this.btnGuardarEdit.Click += new System.EventHandler(this.btnGuardarEdit_Click);
            // 
            // btnEditarConductor
            // 
            this.btnEditarConductor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEditarConductor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnEditarConductor.FlatAppearance.BorderSize = 0;
            this.btnEditarConductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarConductor.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarConductor.ForeColor = System.Drawing.Color.White;
            this.btnEditarConductor.Image = global::BusData.Properties.Resources.icons8_design_30px;
            this.btnEditarConductor.Location = new System.Drawing.Point(530, 10);
            this.btnEditarConductor.Name = "btnEditarConductor";
            this.btnEditarConductor.Size = new System.Drawing.Size(123, 40);
            this.btnEditarConductor.TabIndex = 47;
            this.btnEditarConductor.UseVisualStyleBackColor = false;
            this.btnEditarConductor.Click += new System.EventHandler(this.btnEditarConductor_Click);
            // 
            // btnEliminarConductor
            // 
            this.btnEliminarConductor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminarConductor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnEliminarConductor.FlatAppearance.BorderSize = 0;
            this.btnEliminarConductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarConductor.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarConductor.ForeColor = System.Drawing.Color.White;
            this.btnEliminarConductor.Image = global::BusData.Properties.Resources.icons8_unfriend_30px;
            this.btnEliminarConductor.Location = new System.Drawing.Point(530, 55);
            this.btnEliminarConductor.Name = "btnEliminarConductor";
            this.btnEliminarConductor.Size = new System.Drawing.Size(123, 40);
            this.btnEliminarConductor.TabIndex = 46;
            this.btnEliminarConductor.UseVisualStyleBackColor = false;
            this.btnEliminarConductor.Click += new System.EventHandler(this.btnEliminarConductor_Click);
            // 
            // cbSangre
            // 
            this.cbSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSangre.Enabled = false;
            this.cbSangre.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.cbSangre.FormattingEnabled = true;
            this.cbSangre.Items.AddRange(new object[] {
            "A+",
            "O+",
            "B+",
            "AB+",
            "A-",
            "O-",
            "B-",
            "AB-"});
            this.cbSangre.Location = new System.Drawing.Point(371, 145);
            this.cbSangre.Name = "cbSangre";
            this.cbSangre.Size = new System.Drawing.Size(52, 27);
            this.cbSangre.TabIndex = 39;
            // 
            // lbSangre
            // 
            this.lbSangre.AutoSize = true;
            this.lbSangre.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSangre.ForeColor = System.Drawing.Color.White;
            this.lbSangre.Location = new System.Drawing.Point(305, 148);
            this.lbSangre.Name = "lbSangre";
            this.lbSangre.Size = new System.Drawing.Size(65, 19);
            this.lbSangre.TabIndex = 38;
            this.lbSangre.Text = "Sangre:";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexo.ForeColor = System.Drawing.Color.White;
            this.lbSexo.Location = new System.Drawing.Point(200, 148);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(47, 19);
            this.lbSexo.TabIndex = 37;
            this.lbSexo.Text = "Sexo:";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Enabled = false;
            this.cbSexo.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSexo.Location = new System.Drawing.Point(247, 145);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(52, 27);
            this.cbSexo.TabIndex = 36;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDOB.Enabled = false;
            this.dtpDOB.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Location = new System.Drawing.Point(183, 111);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(341, 22);
            this.dtpDOB.TabIndex = 35;
            // 
            // lbFechaDeNacimiento
            // 
            this.lbFechaDeNacimiento.AutoSize = true;
            this.lbFechaDeNacimiento.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaDeNacimiento.ForeColor = System.Drawing.Color.White;
            this.lbFechaDeNacimiento.Location = new System.Drawing.Point(8, 114);
            this.lbFechaDeNacimiento.Name = "lbFechaDeNacimiento";
            this.lbFechaDeNacimiento.Size = new System.Drawing.Size(169, 19);
            this.lbFechaDeNacimiento.TabIndex = 34;
            this.lbFechaDeNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // txtCedula
            // 
            this.txtCedula.Enabled = false;
            this.txtCedula.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.txtCedula.Location = new System.Drawing.Point(73, 145);
            this.txtCedula.Mask = "000-0000000-0";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(122, 26);
            this.txtCedula.TabIndex = 33;
            // 
            // lbCedula
            // 
            this.lbCedula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCedula.AutoSize = true;
            this.lbCedula.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCedula.ForeColor = System.Drawing.Color.White;
            this.lbCedula.Location = new System.Drawing.Point(8, 148);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(65, 19);
            this.lbCedula.TabIndex = 32;
            this.lbCedula.Text = "Cedula:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.txtDireccion.Location = new System.Drawing.Point(91, 75);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(433, 26);
            this.txtDireccion.TabIndex = 31;
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.ForeColor = System.Drawing.Color.White;
            this.lbDireccion.Location = new System.Drawing.Point(8, 78);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(83, 19);
            this.lbDireccion.TabIndex = 30;
            this.lbDireccion.Text = "Direccion:";
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.txtApellido.Location = new System.Drawing.Point(91, 41);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(433, 26);
            this.txtApellido.TabIndex = 29;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.ForeColor = System.Drawing.Color.White;
            this.lbApellido.Location = new System.Drawing.Point(8, 46);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(73, 19);
            this.lbApellido.TabIndex = 28;
            this.lbApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.txtNombre.Location = new System.Drawing.Point(91, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(433, 26);
            this.txtNombre.TabIndex = 27;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.White;
            this.lbNombre.Location = new System.Drawing.Point(8, 12);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(72, 19);
            this.lbNombre.TabIndex = 26;
            this.lbNombre.Text = "Nombre:";
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
            this.btnCancelEdit.Location = new System.Drawing.Point(530, 145);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(123, 40);
            this.btnCancelEdit.TabIndex = 49;
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Visible = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // frEditDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(680, 415);
            this.Controls.Add(this.pnData);
            this.Controls.Add(this.dgvConductores);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MinimumSize = new System.Drawing.Size(696, 454);
            this.Name = "frEditDriver";
            this.Text = "frEditDriver";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConductores)).EndInit();
            this.pnData.ResumeLayout(false);
            this.pnData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConductores;
        private System.Windows.Forms.Panel pnData;
        private System.Windows.Forms.ComboBox cbSangre;
        private System.Windows.Forms.Label lbSangre;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lbFechaDeNacimiento;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private System.Windows.Forms.Label lbCedula;
        private System.Windows.Forms.MaskedTextBox txtDireccion;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.MaskedTextBox txtApellido;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button btnEditarConductor;
        private System.Windows.Forms.Button btnEliminarConductor;
        private System.Windows.Forms.Button btnGuardarEdit;
        private System.Windows.Forms.Button btnCancelEdit;
    }
}