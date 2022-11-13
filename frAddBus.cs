using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusData
{
    public partial class frAddBus : Form
    {
        public frAddBus()
        {
            InitializeComponent();
        }
        private void limpiarCampos()
        {
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPlaca.Text = "";
            cbColor.ResetText();
            txtAño.Text = "";
        }
        SqlConnection sqlCon = new SqlConnection();
        private void btnSaveBus_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string placa = txtPlaca.Text;
            string color = cbColor.Text;
            string año = txtAño.Text;
            string asignado = "No";
            string chofer = "NULL";
            string ruta = "NULL";

            try
            {
                if (marca == "" || modelo == "" || placa == "" || color == "" || año == "")
                {
                    MessageBox.Show("Debe llenar todos los datos necesarios.");
                }
                else if (pbBus.Tag == "No")
                {
                    MessageBox.Show("Debe seleccionar una foto 2x2");
                }
                else
                {
                    string insertQuery = "INSERT INTO tblBus (Marca, Modelo, Placa, Color, Año, Image, Asignado, Chofer, Ruta) values ('" + marca + "',  '" + modelo + "',  '" + placa + "', '" + color + "', '" + año + "', @image, @asignado, @chofer, @ruta)";

                    sqlCon = conexionDB.getInstancia().CrearConexion();
                    SqlCommand query = new SqlCommand(insertQuery, sqlCon);


                    byte[] image = File.ReadAllBytes(pbBus.ImageLocation);

                    query.Parameters.AddWithValue("@image", image);
                    query.Parameters.AddWithValue("@asignado", asignado);
                    query.Parameters.AddWithValue("@chofer", chofer);
                    query.Parameters.AddWithValue("@ruta", ruta);
                    query.ExecuteNonQuery();

                    MessageBox.Show("Autobus agregado correctamente.");
                    pbBus.ImageLocation = "";
                    limpiarCampos();
                    pbBus.Tag = "No";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog searchIMG = new OpenFileDialog();
            searchIMG.Filter = "Images(.jpg,.png)|*.png;*.jpg";

            if (searchIMG.ShowDialog() == DialogResult.OK)
            {
                pbBus.ImageLocation = searchIMG.FileName;
                pbBus.SizeMode = PictureBoxSizeMode.StretchImage;
                pbBus.Tag = "Si";
            }
        }
    }
}
