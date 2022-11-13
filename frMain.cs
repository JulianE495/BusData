using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusData
{
    public partial class frBusData : Form
    {
        public frBusData()
        {
            InitializeComponent();
        }
        private Form formularioActivo = null;
        private void abrirFomularioHijo(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnMain.Controls.Add(formularioHijo);
            pnMain.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            else { }
        }
        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            abrirFomularioHijo(new frDriver());
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            abrirFomularioHijo(new frBus());
        }

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            abrirFomularioHijo(new frRoute());
        }

        private void btnAsignarRutaBus_Click(object sender, EventArgs e)
        {
            abrirFomularioHijo(new frAsignarBusRuta());
        }

        private void btnAdminRutas_Click(object sender, EventArgs e)
        {
            abrirFomularioHijo(new frEditarRutas());
        }
    }
}
