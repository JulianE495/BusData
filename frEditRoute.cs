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
    public partial class frEditRoute : Form
    {
        public frEditRoute()
        {
            InitializeComponent();
            mostrarDatosRutas();
        }
        SqlConnection sqlCon = new SqlConnection();
        private void mostrarDatosRutas()
        {
            try
            {
                sqlCon = conexionDB.getInstancia().CrearConexion();
                string selectQuery = "SELECT id, ruta, inicioR, finR FROM tblRutas";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, sqlCon);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "tblRutas");
                dvgRuta.DataSource = ds;
                dvgRuta.DataMember = "tblRutas";
                dvgRuta.DefaultCellStyle.SelectionBackColor = Color.FromArgb(55, 53, 58);
                dvgRuta.BackgroundColor = Color.FromArgb(35, 33, 38);
                dvgRuta.BorderStyle = BorderStyle.None;

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

        private void limpiarCampos()
        {
            txtId.Text = "";
            txtNombreR.Text = "";
            txtInicioR.Text = "";
            txtFinR.Text = "";
        }

        private void btnEditarRuta_Click(object sender, EventArgs e)
        {
            string nombreR = txtInicioR.Text;
            string inicioR = txtInicioR.Text;
            string finalR = txtFinR.Text;

            if (nombreR == "" || inicioR == "" || finalR == "")
            {
                MessageBox.Show("Debe seleccionar una ruta para poder editarla.");
            }
            else
            {
                txtNombreR.Enabled = true;
                txtInicioR.Enabled = true;
                txtFinR.Enabled = true;
                btnGuardarEdicion.Enabled = true;
                btnCancelEdit.Visible = true;
            }
            
        }

        private void btnGuardarEdicion_Click(object sender, EventArgs e)
        {
            string nombreR = txtNombreR.Text;
            string inicioR = txtInicioR.Text;
            string finalR = txtFinR.Text;

            try
            {
                string id = dvgRuta.CurrentRow.Cells[0].Value.ToString();
                if (nombreR == "" || inicioR == "" || finalR == "")
                {
                    MessageBox.Show("Debe llenar todos los datos necesarios.");
                }
                else
                {
                    string updateQuery = "UPDATE tblRutas SET ruta = '" + nombreR + "', inicioR = '" + inicioR + "', finR = '" + finalR + "' WHERE id = @id";

                    sqlCon = conexionDB.getInstancia().CrearConexion();
                    SqlCommand query = new SqlCommand(updateQuery, sqlCon);

                    query.Parameters.AddWithValue("@id", id);
                    query.ExecuteNonQuery();

                    MessageBox.Show("Autobus editado correctamente.");
                    limpiarCampos();
                    mostrarDatosRutas();
                    txtNombreR.Enabled = false;
                    txtInicioR.Enabled = false;
                    txtFinR.Enabled = false;
                    btnGuardarEdicion.Enabled = false;
                    btnCancelEdit.Visible = false;

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

        private void dvgRuta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombreR = txtNombreR.Text;
            string inicioR = txtInicioR.Text;
            string finalR = txtFinR.Text;

            try
            {
                sqlCon = conexionDB.getInstancia().CrearConexion();
                string id = dvgRuta.CurrentRow.Cells[0].Value.ToString();
                string selectQuery = "SELECT id, ruta, InicioR, FinR FROM tblRutas WHERE id = @id";

                SqlCommand query = new SqlCommand(selectQuery, sqlCon);
                query.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = query.ExecuteReader();
                if (reader.Read())
                {
                    txtId.Text = Convert.ToString(reader.GetInt32(0));
                    txtNombreR.Text = reader.GetString(1);
                    txtInicioR.Text = reader.GetString(2);
                    txtFinR.Text = reader.GetString(3);
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

        private void btnElimanarRuta_Click(object sender, EventArgs e)
        {
            string idR = txtId.Text;
            string nombreR = txtNombreR.Text;
            string inicioR = txtInicioR.Text;
            string finalR = txtFinR.Text;

            if (idR == "" || nombreR == "" || inicioR == "" || finalR == "")
            {
                MessageBox.Show("Debe seleccionar una ruta para eliminarla", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                try
                {
                    string id = dvgRuta.CurrentRow.Cells[0].Value.ToString();
                    DialogResult result = MessageBox.Show("¿Seguro que desea eliminar la Ruta?", "titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string updateQuery = "DELETE FROM tblRutas WHERE id = @id";

                        sqlCon = conexionDB.getInstancia().CrearConexion();
                        SqlCommand query = new SqlCommand(updateQuery, sqlCon);

                        query.Parameters.AddWithValue("@id", id);
                        query.ExecuteNonQuery();

                        MessageBox.Show("Ruta eliminada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos();
                        mostrarDatosRutas();
                    }
                    else
                    {
                        limpiarCampos();
                        mostrarDatosRutas();
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



        }
    }
}
