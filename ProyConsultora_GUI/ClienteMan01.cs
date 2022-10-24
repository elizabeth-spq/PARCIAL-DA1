
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
    public partial class ClienteMan01 : Form
    {
        // Instancias
        ClienteBL objClienteBL = new ClienteBL();
        DataView dtv;

        public ClienteMan01()
        {
            InitializeComponent();
        }

        private void ClienteMan01_Load(object sender, EventArgs e)
        {
         
            CargarDatos("");

        }

        private void CargarDatos(String strFiltro)
        {

           //Filtro por nombre de cliente
            dtv = new DataView(objClienteBL.ListarCliente());
            dtv.RowFilter = "Nom_Cli like '%" + strFiltro + "%'";
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
                ClienteeMan02 objMan2 = new ClienteeMan02();
                objMan2.ShowDialog();

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
               
                ClienteMan03 objMan03 = new ClienteMan03();
                //Asignamos el codigo del producto seleccionado en el datagrid...
                objMan03.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString(); 
                    
                    //dtgDatos.CurrentRow.Cells[0].Value.ToString();

                objMan03.ShowDialog();

                //Refrescamos el dataGrid...
                dtv = new DataView(objClienteBL.ListarCliente());
                CargarDatos(txtFiltro.Text);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult vrpta;
            vrpta = MessageBox.Show("¿Seguro de eliminar el registro?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.Yes)
            {
                if (objClienteBL.EliminarCliente(dtgDatos.CurrentRow.Cells[0].Value.ToString(),
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
