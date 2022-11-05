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
// Agregamos
using ProyConsultora_BE;
using ProyConsultora_BL;

namespace ProyConsultora_GUI
{
    public partial class ClienteMan03 : Form
    {
        // instancias...
        ClienteBL objClienteBL = new ClienteBL();
        ClienteBE objClienteBE = new ClienteBE();

        UbigeoBL objUbigeoBL = new UbigeoBL();
        GrupoEconomicoBL objGrupoEconomicoBL = new GrupoEconomicoBL();

        public ClienteMan03()
        {
            InitializeComponent();
        }

        public String Codigo { get; set; }

        private void ClienteMan03_Load(object sender, EventArgs e)
        {
            try
            {
               
                // Cargamos los combos...
                
                DataTable dt = objGrupoEconomicoBL.ListarGE();
                DataRow dr;
                
                dr = dt.NewRow();
                dr["Cod_Gru_Eco"] = 0;
                dr["Nom_Gru_Eco"] = "--Seleccione--";
                dt.Rows.InsertAt(dr, 0);
                cboGE.DataSource = dt;
                cboGE.DisplayMember = "Nom_Gru_Eco";
                cboGE.ValueMember = "Cod_Gru_Eco";

                
                // Mostramos los datos del cliente que se va a actualizar
                objClienteBE = objClienteBL.ConsultarCliente(this.Codigo);
                
                lblCodigo.Text = objClienteBE.Cod_Cli;
                txtNombre.Text = objClienteBE.Nom_Cli;
                mskDoc.Text = objClienteBE.Num_Doc_Cli;
                txtDireccion.Text = objClienteBE.Dir_Cli;
                txtEmail.Text = objClienteBE.Email_Cli;
                txtTel.Text = objClienteBE.Tel_Cli;


                String Id_ubigeo = objClienteBE.Id_Ubigeo;
                CargarUbigeo(Id_ubigeo.Substring(0, 2), Id_ubigeo.Substring(2, 2), Id_ubigeo.Substring(4, 2));

                cboGE.SelectedValue=objClienteBE.Cod_Gru_Eco;

                //cboGE.Text = objClienteBE.Cod_Gru_Eco;
                ;
                ///tipo de cliente
                Boolean tipCl;
                if (objClienteBE.Tip_Cli.ToString() == "1")
                {
                    tipCl = true;
                }
                else
                {
                    tipCl = false;
                }
                //estado
                Boolean est;
                if (objClienteBE.Est_cli.ToString() == "1")
                {
                    est = true;
                }
                else
                {
                    est = false;
                }


                chkTipoCli.Checked = tipCl;
                chkEstado.Checked = est;

                //tipo de documento
                Boolean tip1, tip2, tip3;
                if (objClienteBE.Tip_Doc_Cli.ToString() == "1")
                {
                    tip1 = true;
                }
                else
                {
                    tip1 = false;
                }
                if (objClienteBE.Tip_Doc_Cli.ToString() == "2")
                {
                    tip2 = true;
                }
                else
                {
                    tip2 = false;
                }
                if (objClienteBE.Tip_Doc_Cli.ToString() == "3")
                {
                    tip3 = true;
                }
                else
                {
                    tip3 = false;
                }

                rdbRuc.Checked = tip1;
                rdbDni.Checked = tip2;
                rdbCarne.Checked = tip3;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                    throw new Exception("El nombre es obligatorio");
                }
                if (txtDireccion.Text.Trim() == String.Empty)
                {
                    throw new Exception("La dirección es obligatoria");
                }
                if (mskDoc.Text == String.Empty)
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
                if (chkTipoCli.Checked == true)
                {
                    tipCli = "1";
                }
                else
                {
                    tipCli = "2";
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

                objClienteBE.Cod_Cli = lblCodigo.Text;

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
                objClienteBE.Usu_Ult_Mod = clsCredenciales.Usuario;

                //invocamos al metodo insertar

                if (objClienteBL.ActualizarCliente(objClienteBE) == true)
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
        private void cboGE_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Refrescamos 
            CargarGE(cboGE.SelectedValue.ToString());
        }
        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");
        }
        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(),
                                cboProvincia.SelectedValue.ToString(), "01");
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbDni_CheckedChanged(object sender, EventArgs e)
        {
           
            mskDoc.Mask = "99999999";
        }

        private void rdbRuc_CheckedChanged(object sender, EventArgs e)
        {
         
            mskDoc.Mask = "99999999999";
        }

        private void rdbCarne_CheckedChanged(object sender, EventArgs e)
        {
        
            mskDoc.Mask = "99999999999";
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8) //Si no es BackSpace
            {
                if (char.IsDigit(e.KeyChar) == false)//Ni tampoco es un digito
                {
                    e.Handled = true;
                }
            }
        }
    }
}
