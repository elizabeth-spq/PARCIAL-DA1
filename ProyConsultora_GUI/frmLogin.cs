using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//agregar
using ProyConsultora_BL;
using ProyConsultora_BE;

namespace ProyConsultora_GUI
{
    public partial class frmLogin : Form
    {
        int intentos = 0;
        int tiempo = 60;
        UsuarioBE objUsuarioBE = new UsuarioBE();
        UsuarioBL objUsuarioBL = new UsuarioBL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() != "" & txtPassword.Text.Trim() != "")
            {
                //Obtenemos los datos del usuario dado como login...
                objUsuarioBE = objUsuarioBL.ConsultarUsuario(txtLogin.Text.Trim());

                //Si el login usuario no existe...
                if (objUsuarioBE.Nom_Usu == null)
                {
                    MessageBox.Show("Usuario no existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;

                }

                else if (objUsuarioBE.Nom_Usu == txtLogin.Text.Trim() && objUsuarioBE.Con_Usu == txtPassword.Text.Trim())
                {
                    //si las credenciales son correctas...
                    this.Hide();
                    timer1.Enabled = false;
                    clsCredenciales.Usuario = txtLogin.Text.Trim();
                    clsCredenciales.Password = txtPassword.Text.Trim();
                    clsCredenciales.Nivel = objUsuarioBE.Tip_Usu;

                    ///MOSTRANDO EL MENU PRINCIPAL
                    MDIPrincipal objMDI = new MDIPrincipal();
                    objMDI.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                }

            }
            else
            {
                MessageBox.Show("Usuario o Password obligatorios",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
            }
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos,  sobrepaso el numero de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            tiempo -= 1;
            this.Text = "Ingrese su login y contraseña. Le quedan...." + tiempo;
            if (tiempo == 0)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
