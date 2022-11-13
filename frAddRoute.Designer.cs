namespace BusData
{
    partial class frAddRoute
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
            this.txtFinR = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInicioR = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAñadirRuta = new System.Windows.Forms.Button();
            this.txtNombreR = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFinR
            // 
            this.txtFinR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFinR.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F);
            this.txtFinR.Location = new System.Drawing.Point(150, 107);
            this.txtFinR.Name = "txtFinR";
            this.txtFinR.Size = new System.Drawing.Size(504, 29);
            this.txtFinR.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Final de Ruta:";
            // 
            // txtInicioR
            // 
            this.txtInicioR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInicioR.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F);
            this.txtInicioR.Location = new System.Drawing.Point(150, 72);
            this.txtInicioR.Name = "txtInicioR";
            this.txtInicioR.Size = new System.Drawing.Size(504, 29);
            this.txtInicioR.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Inicio de Ruta:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(105, 22);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Añadir ruta";
            // 
            // btnAñadirRuta
            // 
            this.btnAñadirRuta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAñadirRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.btnAñadirRuta.FlatAppearance.BorderSize = 0;
            this.btnAñadirRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirRuta.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirRuta.ForeColor = System.Drawing.Color.White;
            this.btnAñadirRuta.Image = global::BusData.Properties.Resources.icons8_save_30px_2;
            this.btnAñadirRuta.Location = new System.Drawing.Point(25, 144);
            this.btnAñadirRuta.Name = "btnAñadirRuta";
            this.btnAñadirRuta.Size = new System.Drawing.Size(629, 40);
            this.btnAñadirRuta.TabIndex = 49;
            this.btnAñadirRuta.UseVisualStyleBackColor = false;
            this.btnAñadirRuta.Click += new System.EventHandler(this.btnAñadirRuta_Click);
            // 
            // txtNombreR
            // 
            this.txtNombreR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreR.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F);
            this.txtNombreR.Location = new System.Drawing.Point(150, 37);
            this.txtNombreR.Name = "txtNombreR";
            this.txtNombreR.Size = new System.Drawing.Size(504, 29);
            this.txtNombreR.TabIndex = 51;
            this.txtNombreR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreR_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 50;
            this.label3.Text = "Ruta:";
            // 
            // frAddRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(680, 415);
            this.Controls.Add(this.txtNombreR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAñadirRuta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtFinR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInicioR);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(696, 454);
            this.Name = "frAddRoute";
            this.Text = "frAddRoute";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtFinR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtInicioR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAñadirRuta;
        private System.Windows.Forms.MaskedTextBox txtNombreR;
        private System.Windows.Forms.Label label3;
    }
}