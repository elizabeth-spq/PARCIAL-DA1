using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar...
using System.IO;// para la clase File
using ProyConsultora_BL;
using ProyConsultora_BE;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ProyConsultora_GUI
{
    public partial class ColaboradorMan02 : Form
    {

        ColaboradorBL objColaboradorBL = new ColaboradorBL();
        ColaboradorBE objColaboradorBE = new ColaboradorBE();

        AreaBL objAreaBL = new AreaBL();
        UbigeoBL objUbigeoBL = new UbigeoBL();
        CategoriaBL objCategoriaBL = new CategoriaBL();

        public ColaboradorMan02()
        {
            InitializeComponent();
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                
                openFileDialog1.FileName = String.Empty;
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();

                // Si se escogio una foto se carga en el picture Box
                if (openFileDialog1.FileName != String.Empty)
                {
                    pcbFoto.Image = Image.FromFile(openFileDialog1.FileName);
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ColaboradorMan02_Load(object sender, EventArgs e)
        {
            try
            {

                // Cargamos los combos de Ubigeo
                // Por defecto elegiremos Lima, Lima , Lima (14,01,01)
                CargarUbigeo("14", "01", "01");
                CargarArea("0");
                CargarCategoria("0");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }
        private void CargarArea(String bArea)
        {
            DataTable dt = objAreaBL.ListarArea();
            DataRow dr;
            cboArea.DataSource = dt;
            dr = dt.NewRow();
            dr["Cod_Area"] = 0;
            dr["Nom_Area"] = "--Seleccione--";
            dt.Rows.InsertAt(dr, 0);
            cboArea.DisplayMember = "Nom_Area";
            cboArea.ValueMember = "Cod_Area";
            cboArea.SelectedValue = bArea;
        }
        private void CargarCategoria(String bCat)
        {
            DataTable dt = objCategoriaBL.ListarCategoria();
            DataRow dr;
            cboCategoria.DataSource = dt;
            dr = dt.NewRow();
            dr["Cod_Cat_Col"] = 0;
            dr["Nom_Cat"] = "--Seleccione--";
            dt.Rows.InsertAt(dr, 0);
            cboCategoria.DisplayMember = "Nom_Cat";
            cboCategoria.ValueMember = "Cod_Cat_Col";
            cboCategoria.SelectedValue = bCat;
        }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {

            //Llenamos combos...
            cboDepartamento.DataSource = objUbigeoBL.Ubigeo_Departamentos();
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.ValueMember = "IdDepa";
            cboDepartamento.SelectedValue = IdDepa;

            cboProvincia.DataSource = objUbigeoBL.Ubigeo_ProvinciasDepartamento(IdDepa);
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.ValueMember = "IdProv";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objUbigeoBL.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.ValueMember = "IdDist";
            cboDistrito.SelectedValue = IdDist;

        }

        private void cboArea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Refrescamos 
            CargarArea(cboArea.SelectedValue.ToString());
        }
        private void cboCategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Refrescamos 
            CargarCategoria(cboCategoria.SelectedValue.ToString());
        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Refrescamos 
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");

        }
        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Refrescamos 
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            String tip = "";
            String tipCli = "";
            String est = "";

            try
            {
                //Validamos...
                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("Campo obligatorio");
                }
                if (txtApellido.Text.Trim() == String.Empty)
                {
                    throw new Exception("Campo obligatorio");
                }
                if (cboArea.Text.Trim() == String.Empty)
                {
                    throw new Exception("Campo obligatorio");
                }
                if (cboCategoria.Text.Trim() == String.Empty)
                {
                    throw new Exception("Campo obligatorio");
                }
                if (mskDoc.Text == String.Empty)
                {
                    throw new Exception("El Nº de Documento es obligatorio");
                }

                //RADIOBUTTON CHECKED

                if (rdbDni.Checked == true)
                {
                    tip = "1";
                }
                else
              if (rdbPasa.Checked == true)
                {
                    tip = "3";
                }
                else
              if (rdbCarne.Checked == true)
                {
                    tip = "2";
                }
                else
                    tip = "";


                MessageBox.Show(tip);
                MessageBox.Show(cboCategoria.SelectedValue.ToString());
                //Si todo está ok...
                objColaboradorBE.Cod_Cat_Col = cboCategoria.SelectedValue.ToString();
                objColaboradorBE.Nom_Col = txtDireccion.Text.Trim();
                objColaboradorBE.Ape_Col = txtDireccion.Text.Trim();
                objColaboradorBE.Fec_Nac = dtpFecNac.Value.Date;
                objColaboradorBE.Doc_Col = tip;
                objColaboradorBE.Num_Doc_Col = mskDoc.Text;
                objColaboradorBE.Tel_Col = txtTel.Text.Trim();
                objColaboradorBE.Cel_Col = txtCelular.Text.Trim();
                objColaboradorBE.Ema_Col = txtEmail.Text.Trim();
                objColaboradorBE.Dir_Col = txtDireccion.Text.Trim();
                objColaboradorBE.Cod_Area = cboArea.SelectedValue.ToString();
                objColaboradorBE.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() +
                                         cboProvincia.SelectedValue.ToString() +
                                         cboDistrito.SelectedValue.ToString();
                objColaboradorBE.Sue_Col = Convert.ToDouble(txtSueldo.Text.Trim());
                objColaboradorBE.Est_Col = Convert.ToInt16(chkEstado.Checked);
                objColaboradorBE.Usu_Registro = clsCredenciales.Usuario;
                objColaboradorBE.Fot_Col = File.ReadAllBytes(openFileDialog1.FileName);

                //invocamos al metodo insertar

                if (objColaboradorBL.InsertarColaborador(objColaboradorBE) == true)
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
    }
}
