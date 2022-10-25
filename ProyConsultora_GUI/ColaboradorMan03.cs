﻿using ProyConsultora_BE;
using ProyConsultora_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ProyConsultora_GUI
{
    public partial class ColaboradorMan03 : Form
    {
        ColaboradorBL objColaboradorBL = new ColaboradorBL();
        ColaboradorBE objColaboradorBE = new ColaboradorBE();
        Byte[] FotoOriginal;

        AreaBL objAreaBL = new AreaBL();
        UbigeoBL objUbigeoBL = new UbigeoBL();
        CategoriaBL objCategoriaBL = new CategoriaBL();
        public ColaboradorMan03()
        {
            InitializeComponent();
        }
        public String Codigo { get; set; }
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

        private void ColaboradorMan03_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Codigo);
            try
            {

                // Cargamos los combos...

                //DataTable dt = objGrupoEconomicoBL.ListarGE();
                //DataRow dr;

                //dr = dt.NewRow();
                //dr["Cod_Gru_Eco"] = 0;
                //dr["Nom_Gru_Eco"] = "--Seleccione--";
                //dt.Rows.InsertAt(dr, 0);
                //cboGE.DataSource = dt;
                //cboGE.DisplayMember = "Nom_Gru_Eco";
                //cboGE.ValueMember = "Cod_Gru_Eco";


                // Mostramos los datos del cliente que se va a actualizar
                objColaboradorBE = objColaboradorBL.ConsultarColaborador(this.Codigo);

                lblCodigo.Text = objColaboradorBE.Cod_Col;
                cboCategoria.SelectedValue = objColaboradorBE.Cod_Cat_Col;

                txtNombre.Text = objColaboradorBE.Nom_Col;
                txtApellido.Text = objColaboradorBE.Ape_Col;

                dtpFecNac.Value= objColaboradorBE.Fec_Nac;
                //tipo de documento
                Boolean tip1, tip2, tip3;
                if (objColaboradorBE.Doc_Col.ToString() == "1")
                {
                    tip1 = true;
                }
                else
                {
                    tip1 = false;
                }
                if (objColaboradorBE.Doc_Col.ToString() == "2")
                {
                    tip2 = true;
                }
                else
                {
                    tip2 = false;
                }
                if (objColaboradorBE.Doc_Col.ToString() == "3")
                {
                    tip3 = true;
                }
                else
                {
                    tip3 = false;
                }

                rdbPasa.Checked = tip1;
                rdbDni.Checked = tip2;
                rdbCarne.Checked = tip3;
                mskDoc.Text = objColaboradorBE.Num_Doc_Col;
                txtTel.Text = objColaboradorBE.Tel_Col;
                txtCelular.Text = objColaboradorBE.Cel_Col;
                txtEmail.Text = objColaboradorBE.Ema_Col;
                txtDireccion.Text = objColaboradorBE.Dir_Col;
                cboArea.SelectedValue = objColaboradorBE.Cod_Area;
                String Id_ubigeo = objColaboradorBE.Id_Ubigeo;
                CargarUbigeo(Id_ubigeo.Substring(0, 2), Id_ubigeo.Substring(2, 2), Id_ubigeo.Substring(4, 2));
                txtSueldo.Text = objColaboradorBE.Sue_Col.ToString();
                chkEstado.Checked = Convert.ToBoolean(objColaboradorBE.Est_Col);

                // Si no tiene foto....
                if (objColaboradorBE.Fot_Col.Length == 0)
                {
                    pcbFoto.Image = null;

                }
                else // Pero si tiene foto
                {
                    MemoryStream fotoStream = new MemoryStream(objColaboradorBE.Fot_Col);
                    pcbFoto.Image = Image.FromStream(fotoStream);
                    // Guardamos la foto original , por si no se hace cambios...
                    FotoOriginal = objColaboradorBE.Fot_Col;
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(),
                                cboProvincia.SelectedValue.ToString(), "01");
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            /*
            String tip = "";
            String tipCli = "";
            String est = "";
            try
            {
                //Validamos...
                if (txtDireccion.Text.Trim() == String.Empty)
                {
                    throw new Exception("La razon social es obligatoria");
                }
                if (mskDoc.Text == String.Empty)
                {
                    throw new Exception("El Nº de Documento es obligatorio");
                }

                //RADIOBUTTON CHECKED

                if (rdbDni.Checked == true)
                {
                    tip = "2";
                }
                else
              if (rdbPasa.Checked == true)
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
            */
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}