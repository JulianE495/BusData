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
    public partial class frEditBus : Form
    {
        public frEditBus()
        {
            InitializeComponent();
            mostrarDatos();
        }
        SqlConnection sqlCon = new SqlConnection();
        private void limpiarCampos()
        {
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPlaca.Text = "";
            cbColor.Text = "";
            txtAño.Text = "";
        }

        private void validarTexto(KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
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
                string selectQuery = "SELECT id, marca, modelo, placa, año FROM tblBus";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, sqlCon);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "tblConductor");
                dgvBus.DataSource = ds;
                dgvBus.DataMember = "tblConductor";
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

        private void dgvBus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string placa = txtPlaca.Text;
            string color = cbColor.Text;
            string año = txtAño.Text;

            try
            {
                sqlCon = conexionDB.getInstancia().CrearConexion();
                string id = dgvBus.CurrentRow.Cells[0].Value.ToString();
                string selectQuery = "SELECT id, marca, modelo, placa, color, año, image FROM tblBus WHERE id = @id";

                SqlCommand query = new SqlCommand(selectQuery, sqlCon);
                query.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = query.ExecuteReader();
                if (reader.Read())
                {
                    Byte[] data = new Byte[0];
                    txtMarca.Text = reader.GetString(1);
                    txtModelo.Text = reader.GetString(2);
                    txtPlaca.Text = reader.GetString(3);
                    cbColor.Text = reader.GetString(4);
                    txtAño.Text = reader.GetString(5);

                    byte[] imgData = (byte[])reader.GetValue(6);

                    Image newImage = null;
                    using (MemoryStream ms = new MemoryStream(imgData, 0, imgData.Length))
                    {
                        ms.Write(imgData, 0, imgData.Length);
                        newImage = Image.FromStream(ms, true);
                    }

                    pbBus.Image = newImage;
                    pbBus.SizeMode = PictureBoxSizeMode.StretchImage;
                    newImage = null;

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

        private void btnEditBus_Click(object sender, EventArgs e)
        {
            txtMarca.Enabled = true;
            txtModelo.Enabled = true;
            txtPlaca.Enabled = true;
            cbColor.Enabled = true;
            txtAño.Enabled = true;

            btnImagen.Enabled = true;
            btnGuardarEdit.Visible = true;
            btnCancelEdit.Visible = true;
        }

        private void btnGuardarEdit_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string placa = txtPlaca.Text;
            string color = cbColor.Text;
            string año = txtAño.Text;

            try
            {
                string id = dgvBus.CurrentRow.Cells[0].Value.ToString();
                if (marca == "" || modelo == "" || placa == "" || color == "" || año == "")
                {
                    MessageBox.Show("Debe llenar todos los datos necesarios.");
                }
                else
                {
                    string updateQuery = "UPDATE tblBus SET marca = '" + marca + "', modelo = '" + modelo + "', placa = '" + placa + "', color = '" + color + "', año = '" + año + "', image = @image WHERE id = @id";

                    sqlCon = conexionDB.getInstancia().CrearConexion();
                    SqlCommand query = new SqlCommand(updateQuery, sqlCon);

                    byte[] image = File.ReadAllBytes(pbBus.ImageLocation);
                    query.Parameters.AddWithValue("@image", image);
                    query.Parameters.AddWithValue("@id", id);
                    query.ExecuteNonQuery();

                    MessageBox.Show("Autobus editado correctamente.");
                    limpiarCampos();
                    mostrarDatos();
                    txtMarca.Enabled = false;
                    txtModelo.Enabled = false;
                    txtPlaca.Enabled = false;
                    cbColor.Enabled = false;
                    txtAño.Enabled = false;

                    btnImagen.Enabled = false;
                    btnGuardarEdit.Visible = false;
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

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog searchIMG = new OpenFileDialog();
            searchIMG.Filter = "Images(.jpg,.png)|*.png;*.jpg";

            if (searchIMG.ShowDialog() == DialogResult.OK)
            {
                pbBus.ImageLocation = searchIMG.FileName;
                pbBus.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            btnImagen.Enabled = false;
            btnGuardarEdit.Visible = false;
            limpiarCampos();
            mostrarDatos();
        }

        private void btnDeleteBus_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string placa = txtPlaca.Text;
            string color = cbColor.Text;
            string año = txtAño.Text;

            if (marca == "" || modelo == "" || placa == "" || color == "" || año == "")
            {
                MessageBox.Show("Debe seleccionar un bus para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = dgvBus.CurrentRow.Cells[0].Value.ToString();
                    DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el Bus?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string updateQuery = "DELETE FROM tblBus WHERE id = @id";

                        sqlCon = conexionDB.getInstancia().CrearConexion();
                        SqlCommand query = new SqlCommand(updateQuery, sqlCon);

                        query.Parameters.AddWithValue("@id", id);
                        query.ExecuteNonQuery();

                        MessageBox.Show("Bus eliminado correctamente.");
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
        }
    }
}
