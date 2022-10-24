using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyConsultora_GUI
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void MDIPrincipal_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteMan01 man01 = new ClienteMan01();
            man01.MdiParent = this;
            man01.Show();
        }

        private void proyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProyectoMan01 man01 = new ProyectoMan01();
            man01.MdiParent = this;
            man01.Show();
        }

        private void colaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //codear
        }
        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("Seguro de salir del aplicativo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void salirDelAplicativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //salimos
            Application.Exit();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            this.lblUsuario.Text = clsCredenciales.Usuario;
        }
    }
}
