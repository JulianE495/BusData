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
    public partial class frEditarRutas : Form
    {
        public frEditarRutas()
        {
            InitializeComponent();
            mostrarRutasAsig();
        }
        SqlConnection sqlCon = new SqlConnection();
        private void mostrarRutasAsig()
        {
            try
            {
                sqlCon = conexionDB.getInstancia().CrearConexion();
                string selectQuery = "SELECT tblConductores.id, tblConductores.nombre, tblBus.id, tblBus.placa, tblRutas.id, tblRutas.ruta FROM tblConductores \r\nINNER JOIN tblBus ON (tblConductores.nombre = tblBus.chofer)\r\nINNER JOIN tblRutas ON (tblBus.Ruta = tblRutas.ruta)\r\nWHERE tblConductores.Asignado = 'Si'";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, sqlCon);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "tblEditarTab");
                dvgEditarTrab.DataSource = ds;
                dvgEditarTrab.DataMember = "tblEditarTab";
                dvgEditarTrab.DefaultCellStyle.SelectionBackColor = Color.FromArgb(55, 53, 58);
                dvgEditarTrab.BackgroundColor = Color.FromArgb(35, 33, 38);
                dvgEditarTrab.BorderStyle = BorderStyle.None;
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
            txtChofer.Text = "";
            txtAutobus.Text = "";
            txtRuta.Text = "";

            txtChoferId.Text = "";
            txtBusId.Text = "";
            txtRutaId.Text = "";
        }

        private void btnDesAsignar_Click(object sender, EventArgs e)
        {
            string chofer = "NULL";
            string bus = "NULL";
            string ruta = "NULL";
            string asignado = "No";
            string choferId = txtChoferId.Text;
            string busId = txtBusId.Text;
            string rutaId = txtRutaId.Text;

            if (choferId == "" || busId == "" || rutaId == "")
            {
                MessageBox.Show("Debe seleccionar una opcion de la tabla para desasignar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = dvgEditarTrab.CurrentRow.Cells[0].Value.ToString();
                    DialogResult result = MessageBox.Show("¿Seguro que desea desasignar el conductor a la ruta y al bus?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
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

                        MessageBox.Show("Desasignado correctamente.");
                        limpiarCampos();
                        mostrarRutasAsig();
                    }
                    else
                    {
                        limpiarCampos();
                        mostrarRutasAsig();
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

        private void dvgEditarTrab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgEditarTrab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = txtChofer.Text;

            try
            {
                sqlCon = conexionDB.getInstancia().CrearConexion();
                string selectQuery = "SELECT tblConductores.id, tblConductores.nombre, tblBus.id, tblBus.placa, tblRutas.id, tblRutas.ruta FROM tblConductores \r\nINNER JOIN tblBus ON (tblConductores.nombre = tblBus.chofer)\r\nINNER JOIN tblRutas ON (tblBus.Ruta = tblRutas.ruta)\r\nWHERE tblConductores.Asignado = 'Si'";

                SqlCommand query = new SqlCommand(selectQuery, sqlCon);
                SqlDataReader reader = query.ExecuteReader();

                if (reader.Read())
                {
                    txtChoferId.Text = Convert.ToString(reader.GetInt32(0));
                    txtChofer.Text = reader.GetString(1);
                    txtBusId.Text = Convert.ToString(reader.GetInt32(2));
                    txtAutobus.Text = reader.GetString(3);
                    txtRutaId.Text = Convert.ToString(reader.GetInt32(4));
                    txtRuta.Text = reader.GetString(5);

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
