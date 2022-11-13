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
    public partial class frAsignarBusRuta : Form
    {
        public frAsignarBusRuta()
        {
            InitializeComponent();

            mostrarDatosChofer();
            mostrarDatosBus();
            mostrarDatosRutas();

            llenarCBChofer();
            llenarCBBus();
            llenarCBRuta();
        }

        SqlConnection sqlCon = new SqlConnection();

        private void limpiarCampos()
        {
            txtChofer.DataSource = null;
            txtAutobus.DataSource = null;
            txtRuta.DataSource = null;

            txtChofer.Items.Clear();
            txtAutobus.Items.Clear();
            txtRuta.Items.Clear();

            txtChoferId.Text = "";
            txtBusId.Text = "";
            txtRutaId.Text = "";
        }
        private void mostrarDatosChofer()
        {
            try
            {
                sqlCon = conexionDB.getInstancia().CrearConexion();
                string selectQuery = "SELECT id, nombre, apellido, cedula FROM tblConductores";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, sqlCon);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "tblConductor");
                dvgChofer.DataSource = ds;
                dvgChofer.DataMember = "tblConductor";
                dvgChofer.DefaultCellStyle.SelectionBackColor = Color.FromArgb(55, 53, 58);
                dvgChofer.BackgroundColor = Color.FromArgb(35, 33, 38);
                dvgChofer.BorderStyle = BorderStyle.None;
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

        private void mostrarDatosBus()
        {
            try
            {
                sqlCon = conexionDB.getInstancia().CrearConexion();
                string selectQuery = "SELECT id, marca, modelo, placa, año FROM tblBus";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, sqlCon);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "tblBus");
                dgvBus.DataSource = ds;
                dgvBus.DataMember = "tblBus";
                dgvBus.DefaultCellStyle.SelectionBackColor = Color.FromArgb(55, 53, 58);
                dgvBus.BackgroundColor = Color.FromArgb(35, 33, 38);
                dgvBus.BorderStyle = BorderStyle.None;

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

        private void llenarCBChofer()
        {
            string selectQuery = "SELECT * FROM tblConductores WHERE Asignado = 'No'";
            sqlCon = conexionDB.getInstancia().CrearConexion();
            SqlCommand query = new SqlCommand(selectQuery, sqlCon);
            SqlDataReader reader = query.ExecuteReader();
            while (reader.Read()) 
            {
                txtChofer.Items.Add(reader["Nombre"].ToString());
            }
        }

        private void llenarCBBus()
        {
            string selectQuery = "SELECT * FROM tblBus WHERE Asignado = 'No'";
            sqlCon = conexionDB.getInstancia().CrearConexion();
            SqlCommand query = new SqlCommand(selectQuery, sqlCon);
            SqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                txtAutobus.Items.Add(reader["Placa"].ToString());
            }
        }

        private void llenarCBRuta()
        {
            string selectQuery = "SELECT * FROM tblRutas WHERE Asignado = 'No'";
            sqlCon = conexionDB.getInstancia().CrearConexion();
            SqlCommand query = new SqlCommand(selectQuery, sqlCon);
            SqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                txtRuta.Items.Add(reader["Ruta"].ToString());
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            string chofer = txtChofer.Text;
            string bus = txtAutobus.Text;
            string ruta = txtRuta.Text;
            string asignado = "";
            string choferId = txtChoferId.Text;
            string busId = txtBusId.Text;
            string rutaId = txtRutaId.Text;
            asignado = "Si";
            try
            {
                sqlCon = conexionDB.getInstancia().CrearConexion();
                string updateQuery01 = "UPDATE tblConductores SET Asignado = '" + asignado + "', bus = '" + bus + "', ruta = '" + ruta + "' WHERE id = @id";
                string updateQuery02 = "UPDATE tblBus SET Asignado = '" + asignado + "', Chofer = '" + chofer + "', ruta = '" + ruta + "' WHERE id = @id";
                string updateQuery03 = "UPDATE tblRutas SET Asignado = '" + asignado + "', Chofer = '" + chofer + "', bus = '" + bus + "' WHERE id = @id";
                SqlCommand query = new SqlCommand(updateQuery01, sqlCon);
                SqlCommand query02 = new SqlCommand(updateQuery02, sqlCon);
                SqlCommand query03 = new SqlCommand(updateQuery03, sqlCon);



                query.Parameters.AddWithValue("@id", choferId);
                query02.Parameters.AddWithValue("@id", busId);
                query03.Parameters.AddWithValue("@id", rutaId);
                query.ExecuteNonQuery();
                query02.ExecuteNonQuery();
                query03.ExecuteNonQuery();

                MessageBox.Show("Asignado correctamente.");
                limpiarCampos();
                llenarCBChofer();
                llenarCBBus();
                llenarCBRuta();

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

        private void txtChofer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = txtChofer.Text;

            try
            {
                sqlCon = conexionDB.getInstancia().CrearConexion();
                string selectQuery = "SELECT id FROM tblConductores WHERE nombre = '" + nombre + "'";

                SqlCommand query = new SqlCommand(selectQuery, sqlCon);
                SqlDataReader reader = query.ExecuteReader();

                if (reader.Read())
                {

                    txtChoferId.Text = Convert.ToString(reader.GetInt32(0));

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

        private void txtAutobus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string placa = txtAutobus.Text;

            try
            {
                sqlCon = conexionDB.getInstancia().CrearConexion();
                string selectQuery = "SELECT id FROM tblBus WHERE placa = '" + placa + "'";

                SqlCommand query = new SqlCommand(selectQuery, sqlCon);
                SqlDataReader reader = query.ExecuteReader();

                if (reader.Read())
                {

                    txtBusId.Text = Convert.ToString(reader.GetInt32(0));

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

        private void txtRuta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ruta = txtRuta.Text;

            try
            {
                sqlCon = conexionDB.getInstancia().CrearConexion();
                string selectQuery = "SELECT id FROM tblRutas WHERE ruta = '" + ruta + "'";

                SqlCommand query = new SqlCommand(selectQuery, sqlCon);
                SqlDataReader reader = query.ExecuteReader();

                if (reader.Read())
                {

                    txtRutaId.Text = Convert.ToString(reader.GetInt32(0));

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
