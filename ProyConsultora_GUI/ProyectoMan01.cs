
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
    public partial class ProyectoMan01 : Form
    {
        // Instancias
        ProyectoBL objProyectoBL = new ProyectoBL();
        DataView dtv;

        public ProyectoMan01()
        {
            InitializeComponent();  
        }

        private void ProductoMan01_Load(object sender, EventArgs e)
        {
         
            CargarDatos("");

        }

        private void CargarDatos(String strFiltro)
        {

           

            dtv = new DataView(objProyectoBL.ListarProyecto());
            dtv.RowFilter = "Nom_Proy like '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Pasaremos al metodo CargarDatos el texto que se va escribiendo
                // en la caja de texto 
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
                ProyectoMan02 objProyMan2 = new ProyectoMan02();
                objProyMan2.ShowDialog();

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
                ProyectoMan03 objProyMan03 = new ProyectoMan03();
                //Asignamos el codigo del producto seleccionado en el datagrid...
                objProyMan03.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();

                //dtgDatos.CurrentRow.Cells[0].Value.ToString();
              
                objProyMan03.ShowDialog();

                //Refrescamos el dataGrid...
                dtv = new DataView(objProyectoBL.ListarProyecto());
                CargarDatos(txtFiltro.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                 DialogResult vrpta;
            vrpta = MessageBox.Show("¿Seguro de eliminar el registro?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.Yes)
            {
                if (objProyectoBL.EliminarProyecto(dtgDatos.CurrentRow.Cells[0].Value.ToString(),
                                                   clsCredenciales.Usuario) == true)
                {
                    //Refrescamos el datagrid
                    CargarDatos(txtFiltro.Text.Trim());
                }
                else
                {
                    throw new Exception("No se puede elimar el registro porque está vinculado a otra tabla");
               }
            }
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
