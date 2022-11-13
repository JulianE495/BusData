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
    public partial class frRoute : Form
    {
        public frRoute()
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
            pnRouteMain.Controls.Add(formularioHijo);
            pnRouteMain.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }
        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            abrirFomularioHijo(new frAddRoute());
        }

        private void btnEditRoute_Click(object sender, EventArgs e)
        {
            abrirFomularioHijo(new frEditRoute());
        }
    }
}
