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
    public partial class frDriver : Form
    {
        public frDriver()
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
            pnMainDriver.Controls.Add(formularioHijo);
            pnMainDriver.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }
        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            abrirFomularioHijo(new frAddDriver());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFomularioHijo(new frEditDriver());
        }
    }
}
