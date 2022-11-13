using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusData
{
    public partial class frEditDriver : Form
    {
        public frEditDriver()
        {
            InitializeComponent();
            mostrarDatos();
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
        private void mostrarDatos()
        {
            try
            {
                sqlCon = conexionDB.getInstancia().CrearConexion();
                string selectQuery = "SELECT id, nombre, apellido, cedula FROM tblConductores";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, sqlCon);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "tblConductor");
                dgvConductores.DataSource = ds;
                dgvConductores.DataMember = "tblConductor";
                dgvConductores.DefaultCellStyle.SelectionBackColor = Color.FromArgb(55, 53, 58);
                dgvConductores.BackgroundColor = Color.FromArgb(35, 33, 38);
                dgvConductores.BorderStyle = BorderStyle.None;

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

        private void dgvConductores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string dob = dtpDOB.Text;
            string cedula = txtCedula.Text;
            string sexo = cbSexo.Text;
            string sangre = cbSangre.Text;

            try
            {
                sqlCon = conexionDB.getInstancia().CrearConexion();
                string id = dgvConductores.CurrentRow.Cells[0].Value.ToString();
                string selectQuery = "SELECT * FROM tblConductores WHERE id = @id";

                SqlCommand query = new SqlCommand(selectQuery, sqlCon);
                query.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = query.ExecuteReader();
                if (reader.Read())
                {
                    txtNombre.Text = reader.GetString(1);
                    txtApellido.Text = reader.GetString(2);
                    txtDireccion.Text = reader.GetString(3);
                    dtpDOB.Text = reader.GetString(4);
                    txtCedula.Text = reader.GetString(5);
                    cbSexo.Text = reader.GetString(6);
                    cbSangre.Text = reader.GetString(7);
                }
            }
            catch(Exception ex)
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

        private void btnEditarConductor_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string dob = dtpDOB.Text;
            string cedula = txtCedula.Text;
            string sexo = cbSexo.Text;
            string sangre = cbSangre.Text;

            if (nombre == "" || apellido == "" || direccion == "" || dob == "" || cedula == "" || sexo == "" || sangre == "")
            {
                MessageBox.Show("Debe seleccionar un condutor.");
            }
            else
            {
                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
                txtDireccion.Enabled = true;
                dtpDOB.Enabled = true;
                txtCedula.Enabled = true;
                cbSexo.Enabled = true;
                cbSangre.Enabled = true;

                btnGuardarEdit.Visible = true;
                btnCancelEdit.Visible = true;
            }
        }

        private void btnGuardarEdit_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string dob = dtpDOB.Text;
            string cedula = txtCedula.Text;
            string sexo = cbSexo.Text;
            string sangre = cbSangre.Text;

            try
            {
                string id = dgvConductores.CurrentRow.Cells[0].Value.ToString();
                if (nombre == "" || apellido == "" || direccion == "" || dob == "" || cedula == "" || sexo == "" || sangre == "")
                {
                    MessageBox.Show("Debe llenar todos los datos necesarios.");
                }
                else
                {
                    string updateQuery = "UPDATE tblConductores SET Nombre = '" + nombre + "', Apellido = '" + apellido + "', Direccion = '" + direccion + "', DOB = '" + dob + "', Cedula = '" + cedula + "', Sexo = '" + sexo + "', Sangre = '" + sangre + "' WHERE id = @id";

                    sqlCon = conexionDB.getInstancia().CrearConexion();
                    SqlCommand query = new SqlCommand(updateQuery, sqlCon);

                    query.Parameters.AddWithValue("@id", id);
                    query.ExecuteNonQuery();

                    MessageBox.Show("Conductor editado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                    mostrarDatos();
                    txtNombre.Enabled = false;
                    txtApellido.Enabled = false;
                    txtDireccion.Enabled = false;
                    dtpDOB.Enabled = false;
                    txtCedula.Enabled = false;
                    cbSexo.Enabled = false;
                    cbSangre.Enabled = false;

                    btnGuardarEdit.Enabled = false;
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

        private void btnEliminarConductor_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dgvConductores.CurrentRow.Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el conductor?", "titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string updateQuery = "DELETE FROM tblConductores WHERE id = @id";

                    sqlCon = conexionDB.getInstancia().CrearConexion();
                    SqlCommand query = new SqlCommand(updateQuery, sqlCon);

                    query.Parameters.AddWithValue("@id", id);
                    query.ExecuteNonQuery();

                    MessageBox.Show("Conductor eliminado correctamente.");
                    limpiarCampos();
                    mostrarDatos();
                }
                else
                {
                    limpiarCampos();
                    mostrarDatos();
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTexto(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarTexto(e);
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            btnGuardarEdit.Visible = false;
            btnCancelEdit.Visible = false;
            limpiarCampos();
            mostrarDatos();
        }
    }
}
