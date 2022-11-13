using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusData
{
    public partial class frAddDriver : Form
    {
        public frAddDriver()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon = new SqlConnection();
        private void limpiarCampos()
        {
           txtNombre.Text = "";
           txtApellido.Text = "";
           txtDireccion.Text = "";
           dtpDOB.Text = "";
           txtCedula.Text = "";
           cbSexo.Text = "";
           cbSangre.Text = "";
        }

        private void validarTexto(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten letras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void btnSaveDriver_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string dob = dtpDOB.Text;
            string cedula = txtCedula.Text;
            string sexo = cbSexo.Text;
            string sangre = cbSangre.Text;
            string asignado = "no";
            string bus = "NULL";
            string ruta = "NULL";


           try
            {
                if (nombre == "" || apellido == "" || direccion == "" || dob == "" || cedula == "" || sexo == "" || sangre == "")
                {
                    MessageBox.Show("Debe llenar todos los datos necesarios.");
                }
                else if(pbProfilePhoto.Tag == "No")
                {
                    MessageBox.Show("Debe seleccionar una foto 2x2");
                }
                else
                {
                    string insertQuery = "INSERT INTO tblConductores (Nombre, Apellido, Direccion, DOB, Cedula, Sexo, Sangre, Image, Asignado, Bus, Ruta) values ('" + nombre + "',  '" + apellido + "',  '" + direccion + "', '" + dob + "', '" + cedula + "', '" + sexo + "', '" + sangre + "', @image, @asignado, @bus, @ruta)"; //, Asignado = 'No', Bus = 'NULL', Ruta = 'NULL   '

                    sqlCon = conexionDB.getInstancia().CrearConexion();
                    SqlCommand query = new SqlCommand(insertQuery, sqlCon);


                    byte[] image = File.ReadAllBytes(pbProfilePhoto.ImageLocation);

                    query.Parameters.AddWithValue("@image", image);
                    query.Parameters.AddWithValue("@asignado", asignado);
                    query.Parameters.AddWithValue("@bus", bus);
                    query.Parameters.AddWithValue("@ruta", ruta);
                    query.ExecuteNonQuery();

                    lblCedula.Text = cedula;
                    lblNombre.Text = nombre;
                    lblApellido.Text = apellido;
                    lblDireccion.Text = direccion;
                    lblSexo.Text = sexo;
                    lblSangre.Text = sangre;
                    pbIdPhoto.ImageLocation = pbProfilePhoto.ImageLocation;
                    pbIdPhoto.SizeMode = PictureBoxSizeMode.StretchImage;

                    MessageBox.Show("Conductor agregado correctamente.");
                    pbProfilePhoto.ImageLocation = "";
                    limpiarCampos();
                    pbProfilePhoto.Tag = "No";
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog searchIMG = new OpenFileDialog();
            searchIMG.Filter = "Images(.jpg,.png)|*.png;*.jpg";

            if (searchIMG.ShowDialog() == DialogResult.OK)
            {
                pbProfilePhoto.ImageLocation = searchIMG.FileName;
                pbProfilePhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                pbProfilePhoto.Tag = "Si";
            }
        }

        private void btnShowID_Click(object sender, EventArgs e)
        {
            if (pnCarnet.Visible == false)
            {
                pnCarnet.Visible = true;
            }
        }

        private void btnHideId_Click(object sender, EventArgs e)
        {
            if (pnCarnet.Visible == true)
            {
                pnCarnet.Visible = false;
            }
        }

        private void btnPrintId_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTexto(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTexto(e);
        }
    }
}
