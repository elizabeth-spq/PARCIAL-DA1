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
using ProyConsultora_BL;
using ProyConsultora_BE;
using System.Linq.Expressions;

namespace ProyConsultora_GUI
{

    public partial class ClienteeMan02 : Form
    {

        ClienteBL objClienteBL = new ClienteBL();
        ClienteBE objClienteBE = new ClienteBE();

        UbigeoBL objUbigeoBL = new UbigeoBL();
        GrupoEconomicoBL objGrupoEconomicoBL = new GrupoEconomicoBL();

        public ClienteeMan02()
        {
            InitializeComponent();
        }
        private void ClienteeMan02_Load(object sender, EventArgs e)
        {
            try
            {

                // Cargamos los combos de Ubigeo
                // Por defecto elegiremos Lima, Lima , Lima (14,01,01)
               CargarUbigeo("14", "01", "01");
               CargarGE("GE13");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }
        private void CargarGE(String grpEco)
        {
            cboGE.DataSource = objGrupoEconomicoBL.ListarGE();
            cboGE.DisplayMember = "Nom_Gru_Eco";
            cboGE.ValueMember = "Cod_Gru_Eco";
            cboGE.SelectedValue = grpEco;
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

        private void cboGE_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Refrescamos 
            CargarGE(cboGE.SelectedValue.ToString());
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
     
        private void btnGrabar_Click_1(object sender, EventArgs e)
        {
            String tip = "";
            String tipCli = "";
            String est = "";
   
            try
            {
                //Validamos...
                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre es obligatorio");
                }
                if (txtDireccion.Text.Trim()==String.Empty)
                {
                    throw new Exception("La dirección es obligatoria");
                }
                
                if (mskDoc.Text== String.Empty)
                {
                    throw new Exception("El Nº de Documento es obligatorio");
                }
                
                if (rdbCarne.Checked == true && mskDoc.Text.Trim().Length < 8 )
                {
                    
                    throw new Exception("El carné de extrajería debe tener entre 8 y 12 caracteres");
                }
                if (rdbDni.Checked == true && mskDoc.Text.Trim().Length != 8)
                {
                    throw new Exception("El DNI debe tener 8 caracteres");
                }
                if (rdbRuc.Checked == true && mskDoc.Text.Trim().Length != 11)
                {
                    throw new Exception("El Ruc debe tener 11 caracteres");
                }

                MessageBox.Show(mskDoc.Text.Trim() + "-" + mskDoc.Text.Trim().Length);
                //RADIOBUTTON CHECKED

                if (rdbDni.Checked == true)
                {
                    tip = "2";
                }
                else
                 if (rdbRuc.Checked == true)
                {
                    tip = "1";
                }
                else
                 if (rdbCarne.Checked == true)
                {
                    tip = "3";
                }
                else
                    tip = "";

                //CHKTIPO DE CLIENTE
                if(chkTipoCli.Checked == true)
                {
                    tipCli = "1";
                }
                else
                {
                    tipCli="2";
                }

                //CHK ESTADO
                if (chkEstado.Checked == true)
                {
                    est = "1";
                }
                else
                {
                    est = "2";
                }

                //Si todo está ok...
                objClienteBE.Nom_Cli = txtNombre.Text.Trim();
                objClienteBE.Cod_Gru_Eco = cboGE.SelectedValue.ToString();
                objClienteBE.Num_Doc_Cli = mskDoc.Text;
                objClienteBE.Tip_Doc_Cli = tip;       
                objClienteBE.Dir_Cli = txtDireccion.Text.Trim();
                objClienteBE.Tip_Cli = tipCli;
                objClienteBE.Est_cli = est;
                objClienteBE.Email_Cli = txtEmail.Text.Trim();
                objClienteBE.Tel_Cli = txtTel.Text.Trim();
                objClienteBE.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() +
                                         cboProvincia.SelectedValue.ToString() +
                                         cboDistrito.SelectedValue.ToString();
                objClienteBE.Usu_Registro = clsCredenciales.Usuario;

                //invocamos al metodo insertar

                if (objClienteBL.InsertarCliente(objClienteBE)==true)
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbDni_CheckedChanged(object sender, EventArgs e)
        {
            mskDoc.Clear();
            mskDoc.Mask = "99999999";
        }

        private void rdbRuc_CheckedChanged(object sender, EventArgs e)
        {
            mskDoc.Clear();
            mskDoc.Mask = "99999999999";
        }

        private void rdbCarne_CheckedChanged(object sender, EventArgs e)
        {
            mskDoc.Clear();
            mskDoc.Mask = "999999999999";
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar !=8) //Si no es BackSpace
            {
                if(char.IsDigit(e.KeyChar)==false)//Ni tampoco es un digito
                {
                    e.Handled = true;
                }
            }
        }
    }
}
