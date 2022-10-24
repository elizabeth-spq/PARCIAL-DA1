
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; // Para los objetos DataTable, DataRow y DataView
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar...
using ProyConsultora_BL;

namespace ProyConsultora_GUI
{
    public partial class ColaboradorMan01 : Form
    {
        // Instancias
        ColaboradorBL objColaboradorBL = new ColaboradorBL();
        DataView dtv;

        public ColaboradorMan01()
        {
            InitializeComponent();
        }

        private void ColaboradorMan01_Load(object sender, EventArgs e)
        {
         
            CargarDatos("");

        }

        private void CargarDatos(String strFiltro)
        {

            dtv = new DataView(objColaboradorBL.ListarColaborador());
            dtv.RowFilter = "Ape_Col like '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();
            
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ColaboradorMan02 objColaMan2 = new ColaboradorMan02();
                objColaMan2.ShowDialog();

                //Se carga la vista
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ColaboradorMan03 objColaMan3 = new ColaboradorMan03();
                objColaMan3.ShowDialog();

                //Se carga la vista
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
