namespace BusData
{
    partial class frAddBus
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnImagen = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.MaskedTextBox();
            this.txtModelo = new System.Windows.Forms.MaskedTextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.MaskedTextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.btnSaveBus = new System.Windows.Forms.Button();
            this.pbBus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(139, 22);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Añadir autobus";
            // 
            // btnImagen
            // 
            this.btnImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnImagen.FlatAppearance.BorderSize = 0;
            this.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagen.Font = new System.Drawing.Font("Eras Medium ITC", 12F);
            this.btnImagen.ForeColor = System.Drawing.Color.White;
            this.btnImagen.Location = new System.Drawing.Point(27, 227);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(184, 30);
            this.btnImagen.TabIndex = 13;
            this.btnImagen.Text = "Buscar....";
            this.btnImagen.UseVisualStyleBackColor = false;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(223, 72);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(66, 22);
            this.lblMarca.TabIndex = 14;
            this.lblMarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarca.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F);
            this.txtMarca.Location = new System.Drawing.Point(302, 69);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(288, 29);
            this.txtMarca.TabIndex = 15;
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModelo.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F);
            this.txtModelo.Location = new System.Drawing.Point(302, 104);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(288, 29);
            this.txtModelo.TabIndex = 17;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(223, 107);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(77, 22);
            this.lblModelo.TabIndex = 16;
            this.lblModelo.Text = "Modelo:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlaca.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F);
            this.txtPlaca.Location = new System.Drawing.Point(302, 139);
            this.txtPlaca.Mask = "I00000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(288, 29);
            this.txtPlaca.TabIndex = 19;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.Color.White;
            this.lblPlaca.Location = new System.Drawing.Point(223, 142);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(57, 22);
            this.lblPlaca.TabIndex = 18;
            this.lblPlaca.Text = "Placa:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(223, 180);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(59, 22);
            this.lblColor.TabIndex = 20;
            this.lblColor.Text = "Color:";
            // 
            // txtAño
            // 
            this.txtAño.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F);
            this.txtAño.Location = new System.Drawing.Point(498, 174);
            this.txtAño.Mask = "0000";
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(92, 29);
            this.txtAño.TabIndex = 23;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.ForeColor = System.Drawing.Color.White;
            this.lblAño.Location = new System.Drawing.Point(443, 180);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(49, 22);
            this.lblAño.TabIndex = 22;
            this.lblAño.Text = "Año:";
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F);
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Blanco",
            "Gris",
            "Negro",
            "Plata",
            "Azul",
            "Rojo",
            "Marrón/Beige",
            "Verde",
            "Amarillo"});
            this.cbColor.Location = new System.Drawing.Point(302, 174);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(121, 30);
            this.cbColor.TabIndex = 24;
            // 
            // btnSaveBus
            // 
            this.btnSaveBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnSaveBus.FlatAppearance.BorderSize = 0;
            this.btnSaveBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBus.Image = global::BusData.Properties.Resources.icons8_save_25px;
            this.btnSaveBus.Location = new System.Drawing.Point(226, 214);
            this.btnSaveBus.Name = "btnSaveBus";
            this.btnSaveBus.Size = new System.Drawing.Size(74, 43);
            this.btnSaveBus.TabIndex = 25;
            this.btnSaveBus.UseVisualStyleBackColor = false;
            this.btnSaveBus.Click += new System.EventHandler(this.btnSaveBus_Click);
            // 
            // pbBus
            // 
            this.pbBus.Image = global::BusData.Properties.Resources.busExample;
            this.pbBus.Location = new System.Drawing.Point(27, 46);
            this.pbBus.Name = "pbBus";
            this.pbBus.Size = new System.Drawing.Size(184, 175);
            this.pbBus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBus.TabIndex = 0;
            this.pbBus.TabStop = false;
            this.pbBus.Tag = "No";
            // 
            // frAddBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(680, 415);
            this.Controls.Add(this.btnSaveBus);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbBus);
            this.MinimumSize = new System.Drawing.Size(696, 454);
            this.Name = "frAddBus";
            this.Text = "frAddBus";
            ((System.ComponentModel.ISupportInitialize)(this.pbBus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBus;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.MaskedTextBox txtMarca;
        private System.Windows.Forms.MaskedTextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.MaskedTextBox txtAño;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Button btnSaveBus;
    }
}