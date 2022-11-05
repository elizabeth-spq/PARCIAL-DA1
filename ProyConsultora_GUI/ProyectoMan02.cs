using ProyConsultora_BE;
using ProyConsultora_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ProyConsultora_GUI
{
    public partial class ProyectoMan02 : Form
    {
        ProyectoBL objProyectoBL = new ProyectoBL();
        ProyectoBE objProyectoBE = new ProyectoBE();

        AreaBL objAreaBL = new AreaBL();
        

        public ProyectoMan02()
        {
            InitializeComponent();
        }

        private void ProyectoMan02_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargamos los combos Area
                CargarArea("");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }
        private void CargarArea(String bArea)
        {
            cboArea.DataSource = objAreaBL.ListarArea();
            cboArea.DisplayMember = "Nom_Area";
            cboArea.ValueMember = "Cod_Area";
            cboArea.SelectedValue = bArea;
        }

        private void cboArea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Refrescamos 
            CargarArea(cboArea.SelectedValue.ToString());
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            String tip = "";
            int estado;

            try
            {
                //Validamos...
                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre es obligatorio");
                }
                if (cboArea.Text.Trim() == String.Empty)
                {
                    throw new Exception("El área es obligatoria");
                }

                if (txtPresupuesto.Text.Trim() == String.Empty)
                {
                    throw new Exception("El presupuesto es obligatorio");
                }
                //RADIOBUTTON TIPO DE PROYECTO CHECKED

                if (rdbFacRe.Checked == true)
                {
                    tip = "1";
                }
                else
                if (rdbFacNoRe.Checked == true)
                {
                    tip = "2";
                }
                else
                if (rdbHorasTra.Checked == true)
                {
                    tip = "3";
                }else
                if (rdbNoFac.Checked == true)
                {
                    tip = "4";
                }
                else
                    tip = "";

                //RADIOBUTTON ESTADO

                if (rdbProgramado.Checked == true)
                {
                    estado = 0;
                }
                else
                if (rdbEjecucion.Checked == true)
                {
                    estado = 1;
                }
                else
                if (rdbDetenido.Checked == true)
                {
                    estado = 2;
                }
                else
                if (rdbCancelado.Checked == true)
                {
                    estado = 3;
                }
                else
                if (rdbFinalizado.Checked == true)
                {
                    estado = 4;
                }
                else
                    estado = 0;


                //Si todo está ok...
                objProyectoBE.Cod_Area = cboArea.SelectedValue.ToString();
                objProyectoBE.Nom_Proy = txtNombre.Text.Trim();
                objProyectoBE.Tip_Proy = tip;
                objProyectoBE.Usu_Registro = clsCredenciales.Usuario;
                objProyectoBE.Imp_Imp_Estm = Convert.ToDouble(txtPresupuesto.Text.Trim());
                objProyectoBE.Estado = Convert.ToInt16(estado);


                //invocamos al metodo insertar

                if (objProyectoBL.InsertarProyecto(objProyectoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se insertó registro, contate con TI");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPresupuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back
                    || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator);
        }
    }
}
