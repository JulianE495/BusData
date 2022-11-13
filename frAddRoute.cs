using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusData
{
    public partial class frAddRoute : Form
    {
        public frAddRoute()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon = new SqlConnection();

        private void limpiarCampos()
        {
            txtInicioR.Text = "";
            txtFinR.Text = "";
            txtNombreR.Text = "";
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

        private void btnAñadirRuta_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreR.Text;
            string inicioR = txtInicioR.Text;
            string finR = txtFinR.Text;

            try
            {
                if (nombre == "" || inicioR == "" || finR == "")
                {
                    MessageBox.Show("Debe llenar todos los datos necesarios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string insertQuery = "INSERT INTO tblRutas (ruta, InicioR, FinR, Asignado, Chofer, Bus) values ('" + nombre + "','" + inicioR + "',  '" + finR + "','No', 'NULL', 'NULL')";

                    sqlCon = conexionDB.getInstancia().CrearConexion();
                    SqlCommand query = new SqlCommand(insertQuery, sqlCon);
                    query.ExecuteNonQuery();

                    MessageBox.Show("Ruta añadida correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
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

        private void txtNombreR_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTexto(e);
        }
    }
}
