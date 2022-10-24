using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregamos
using ProyConsultora_BE;
using ProyConsultora_BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ProyConsultora_GUI
{
    public partial class ProyectoMan03 : Form
    {
        ProyectoBL objProyectoBL = new ProyectoBL();
        ProyectoBE objProyectoBE = new ProyectoBE();

        AreaBL objAreaBL = new AreaBL();

        public ProyectoMan03()
        {
            InitializeComponent();
        }
        public String Codigo { get; set; }

        private void ProyectoMan03_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargamos los combos...

                DataTable dt = objAreaBL.ListarArea();
                DataRow dr;

                dr = dt.NewRow();
                dr["Cod_Area"] = 0;
                dr["Nom_Area"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboArea.DataSource = dt;
                cboArea.DisplayMember = "Nom_Area";
                cboArea.ValueMember = "Cod_Area";


                // Mostramos los datos del cliente que se va a actualizar
                objProyectoBE = objProyectoBL.ConsultarProyecto(this.Codigo);

                lblCodigo.Text = objProyectoBE.Cod_Proy;
                txtNombre.Text = objProyectoBE.Nom_Proy;
                cboArea.SelectedValue = objProyectoBE.Cod_Area;

                //tipo de proyecto
                Boolean tip1, tip2, tip3, tip4;
                if (objProyectoBE.Tip_Proy.ToString() == "1")
                {
                    tip1 = true;
                }
                else
                {
                    tip1 = false;
                }
                if (objProyectoBE.Tip_Proy.ToString() == "2")
                {
                    tip2 = true;
                }
                else
                {
                    tip2 = false;
                }
                if (objProyectoBE.Tip_Proy.ToString() == "3")
                {
                    tip3 = true;
                }
                else
                {
                    tip3 = false;
                }
                if (objProyectoBE.Tip_Proy.ToString() == "4")
                {
                    tip4 = true;
                }
                else
                {
                    tip4 = false;
                }

                rdbFacRe.Checked = tip1;
                rdbFacNoRe.Checked = tip2;
                rdbHorasTra.Checked = tip3;
                rdbNoFac.Checked = tip4;
                txtPresupuesto.Text = objProyectoBE.Imp_Imp_Estm.ToString();
                chkEstado.Checked = Convert.ToBoolean(objProyectoBE.Estado);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CargarArea(String bArea)
        {
            cboArea.DataSource = objAreaBL.ListarArea();
            cboArea.DisplayMember = "Nom_Area";
            cboArea.ValueMember = "Cod_Area";
            cboArea.SelectedValue = bArea;
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            String tip = "";
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

                //RADIOBUTTON CHECKED

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
                }
                else
                if (rdbNoFac.Checked == true)
                {
                    tip = "4";
                }
                else
                    tip = "";


                //Si todo está ok...

                objProyectoBE.Cod_Proy = lblCodigo.Text;
                objProyectoBE.Cod_Area = cboArea.SelectedValue.ToString();
                objProyectoBE.Nom_Proy = txtNombre.Text.Trim();
                objProyectoBE.Tip_Proy = tip;
                objProyectoBE.Usu_Ult_Mod = clsCredenciales.Usuario;
                objProyectoBE.Imp_Imp_Estm = Convert.ToDouble(txtPresupuesto.Text.Trim());
                objProyectoBE.Estado = Convert.ToInt16(chkEstado.Checked);
               

                //invocamos al metodo insertar

                if (objProyectoBL.ActualizarProyecto(objProyectoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se actualizó el registro, contate con TI");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void cboArea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Refrescamos 
            CargarArea(cboArea.SelectedValue.ToString());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
