namespace BusData
{
    partial class frAddDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frAddDriver));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.MaskedTextBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblSangre = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.pnCarnet = new System.Windows.Forms.Panel();
            this.pbIdPhoto = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbSangre = new System.Windows.Forms.ComboBox();
            this.btnSaveDriver = new System.Windows.Forms.Button();
            this.btnPrintId = new System.Windows.Forms.Button();
            this.btnHideId = new System.Windows.Forms.Button();
            this.btnShowID = new System.Windows.Forms.Button();
            this.pbProfilePhoto = new System.Windows.Forms.PictureBox();
            this.pnCarnet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIdPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(288, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Añadir informacion de conductor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.txtNombre.Location = new System.Drawing.Point(234, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(412, 26);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(151, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.txtApellido.Location = new System.Drawing.Point(234, 77);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(412, 26);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(151, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cedula:";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.txtCedula.Location = new System.Drawing.Point(216, 172);
            this.txtCedula.Mask = "000-0000000-0";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(122, 26);
            this.txtCedula.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(151, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDOB.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Location = new System.Drawing.Point(326, 141);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(320, 22);
            this.dtpDOB.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(151, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.txtDireccion.Location = new System.Drawing.Point(234, 109);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(412, 26);
            this.txtDireccion.TabIndex = 10;
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnImage.FlatAppearance.BorderSize = 0;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.btnImage.ForeColor = System.Drawing.Color.White;
            this.btnImage.Location = new System.Drawing.Point(25, 169);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(120, 30);
            this.btnImage.TabIndex = 12;
            this.btnImage.Text = "Buscar....";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSexo.Location = new System.Drawing.Point(390, 172);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(52, 27);
            this.cbSexo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(343, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sexo:";
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(181, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(134, 23);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre.....";
            // 
            // lblApellido
            // 
            this.lblApellido.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.Black;
            this.lblApellido.Location = new System.Drawing.Point(321, 51);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(126, 23);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido.....";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.Black;
            this.lblDireccion.Location = new System.Drawing.Point(181, 89);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(266, 23);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Direccion.....";
            // 
            // lblCedula
            // 
            this.lblCedula.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.Color.Black;
            this.lblCedula.Location = new System.Drawing.Point(181, 17);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(266, 23);
            this.lblCedula.TabIndex = 4;
            this.lblCedula.Text = "Cedula.......";
            // 
            // lblSangre
            // 
            this.lblSangre.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSangre.ForeColor = System.Drawing.Color.Black;
            this.lblSangre.Location = new System.Drawing.Point(325, 126);
            this.lblSangre.Name = "lblSangre";
            this.lblSangre.Size = new System.Drawing.Size(122, 23);
            this.lblSangre.TabIndex = 5;
            this.lblSangre.Text = "Sangre.....";
            // 
            // lblSexo
            // 
            this.lblSexo.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.Black;
            this.lblSexo.Location = new System.Drawing.Point(181, 127);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(122, 23);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo.....";
            // 
            // pnCarnet
            // 
            this.pnCarnet.BackColor = System.Drawing.Color.White;
            this.pnCarnet.Controls.Add(this.lblSexo);
            this.pnCarnet.Controls.Add(this.lblSangre);
            this.pnCarnet.Controls.Add(this.lblCedula);
            this.pnCarnet.Controls.Add(this.lblDireccion);
            this.pnCarnet.Controls.Add(this.lblApellido);
            this.pnCarnet.Controls.Add(this.lblNombre);
            this.pnCarnet.Controls.Add(this.pbIdPhoto);
            this.pnCarnet.Location = new System.Drawing.Point(105, 221);
            this.pnCarnet.Name = "pnCarnet";
            this.pnCarnet.Size = new System.Drawing.Size(461, 177);
            this.pnCarnet.TabIndex = 15;
            this.pnCarnet.Visible = false;
            // 
            // pbIdPhoto
            // 
            this.pbIdPhoto.Location = new System.Drawing.Point(23, 17);
            this.pbIdPhoto.Name = "pbIdPhoto";
            this.pbIdPhoto.Size = new System.Drawing.Size(143, 133);
            this.pbIdPhoto.TabIndex = 0;
            this.pbIdPhoto.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(448, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "Sangre:";
            // 
            // cbSangre
            // 
            this.cbSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbSangre.Location = new System.Drawing.Point(514, 172);
            this.cbSangre.Name = "cbSangre";
            this.cbSangre.Size = new System.Drawing.Size(52, 27);
            this.cbSangre.TabIndex = 17;
            // 
            // btnSaveDriver
            // 
            this.btnSaveDriver.FlatAppearance.BorderSize = 0;
            this.btnSaveDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDriver.Image = global::BusData.Properties.Resources.icons8_save_25px;
            this.btnSaveDriver.Location = new System.Drawing.Point(572, 172);
            this.btnSaveDriver.Name = "btnSaveDriver";
            this.btnSaveDriver.Size = new System.Drawing.Size(74, 27);
            this.btnSaveDriver.TabIndex = 21;
            this.btnSaveDriver.UseVisualStyleBackColor = true;
            this.btnSaveDriver.Click += new System.EventHandler(this.btnSaveDriver_Click);
            // 
            // btnPrintId
            // 
            this.btnPrintId.FlatAppearance.BorderSize = 0;
            this.btnPrintId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintId.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintId.Image")));
            this.btnPrintId.Location = new System.Drawing.Point(25, 347);
            this.btnPrintId.Name = "btnPrintId";
            this.btnPrintId.Size = new System.Drawing.Size(55, 51);
            this.btnPrintId.TabIndex = 20;
            this.btnPrintId.UseVisualStyleBackColor = true;
            this.btnPrintId.Click += new System.EventHandler(this.btnPrintId_Click);
            // 
            // btnHideId
            // 
            this.btnHideId.FlatAppearance.BorderSize = 0;
            this.btnHideId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideId.Image = ((System.Drawing.Image)(resources.GetObject("btnHideId.Image")));
            this.btnHideId.Location = new System.Drawing.Point(25, 282);
            this.btnHideId.Name = "btnHideId";
            this.btnHideId.Size = new System.Drawing.Size(55, 51);
            this.btnHideId.TabIndex = 19;
            this.btnHideId.UseVisualStyleBackColor = true;
            this.btnHideId.Click += new System.EventHandler(this.btnHideId_Click);
            // 
            // btnShowID
            // 
            this.btnShowID.FlatAppearance.BorderSize = 0;
            this.btnShowID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowID.Image = ((System.Drawing.Image)(resources.GetObject("btnShowID.Image")));
            this.btnShowID.Location = new System.Drawing.Point(25, 221);
            this.btnShowID.Name = "btnShowID";
            this.btnShowID.Size = new System.Drawing.Size(55, 51);
            this.btnShowID.TabIndex = 18;
            this.btnShowID.UseVisualStyleBackColor = true;
            this.btnShowID.Click += new System.EventHandler(this.btnShowID_Click);
            // 
            // pbProfilePhoto
            // 
            this.pbProfilePhoto.ErrorImage = global::BusData.Properties.Resources.driverExample;
            this.pbProfilePhoto.Image = global::BusData.Properties.Resources.perfil__1_;
            this.pbProfilePhoto.ImageLocation = "";
            this.pbProfilePhoto.InitialImage = global::BusData.Properties.Resources.driverExample;
            this.pbProfilePhoto.Location = new System.Drawing.Point(25, 43);
            this.pbProfilePhoto.Name = "pbProfilePhoto";
            this.pbProfilePhoto.Size = new System.Drawing.Size(120, 120);
            this.pbProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePhoto.TabIndex = 11;
            this.pbProfilePhoto.TabStop = false;
            this.pbProfilePhoto.Tag = "No";
            // 
            // frAddDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(680, 415);
            this.Controls.Add(this.btnSaveDriver);
            this.Controls.Add(this.btnPrintId);
            this.Controls.Add(this.btnHideId);
            this.Controls.Add(this.btnShowID);
            this.Controls.Add(this.cbSangre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pnCarnet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.pbProfilePhoto);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.MinimumSize = new System.Drawing.Size(696, 454);
            this.Name = "frAddDriver";
            this.Text = "Añadir Conductor";
            this.pnCarnet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIdPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtDireccion;
        private System.Windows.Forms.PictureBox pbProfilePhoto;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbIdPhoto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblSangre;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Panel pnCarnet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbSangre;
        private System.Windows.Forms.Button btnShowID;
        private System.Windows.Forms.Button btnHideId;
        private System.Windows.Forms.Button btnPrintId;
        private System.Windows.Forms.Button btnSaveDriver;
    }
}