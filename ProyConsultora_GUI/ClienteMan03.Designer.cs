namespace ProyConsultora_GUI
{
    partial class ClienteMan03
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.chkTipoCli = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskDoc = new System.Windows.Forms.MaskedTextBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboGE = new System.Windows.Forms.ComboBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCarne = new System.Windows.Forms.RadioButton();
            this.rdbRuc = new System.Windows.Forms.RadioButton();
            this.rdbDni = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(216, 655);
            this.chkEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(80, 24);
            this.chkEstado.TabIndex = 11;
            this.chkEstado.Text = "Activo?";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // chkTipoCli
            // 
            this.chkTipoCli.AutoSize = true;
            this.chkTipoCli.Location = new System.Drawing.Point(21, 655);
            this.chkTipoCli.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkTipoCli.Name = "chkTipoCli";
            this.chkTipoCli.Size = new System.Drawing.Size(149, 24);
            this.chkTipoCli.TabIndex = 10;
            this.chkTipoCli.Text = "Opción a crédito?";
            this.chkTipoCli.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(215, 620);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 28);
            this.label11.TabIndex = 18;
            this.label11.Text = "Estado";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 620);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tipo de Cliente:";
            // 
            // mskDoc
            // 
            this.mskDoc.Location = new System.Drawing.Point(330, 242);
            this.mskDoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskDoc.Name = "mskDoc";
            this.mskDoc.Size = new System.Drawing.Size(177, 27);
            this.mskDoc.TabIndex = 3;
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(135, 506);
            this.cboProvincia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(372, 28);
            this.cboProvincia.TabIndex = 8;
            this.cboProvincia.SelectionChangeCommitted += new System.EventHandler(this.cboProvincia_SelectionChangeCommitted);
            // 
            // cboDistrito
            // 
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(135, 555);
            this.cboDistrito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(372, 28);
            this.cboDistrito.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(330, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Número de Doc.";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(21, 503);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Provincia:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(21, 553);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Distrito:";
            // 
            // cboGE
            // 
            this.cboGE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGE.FormattingEnabled = true;
            this.cboGE.Location = new System.Drawing.Point(135, 120);
            this.cboGE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboGE.Name = "cboGE";
            this.cboGE.Size = new System.Drawing.Size(372, 28);
            this.cboGE.TabIndex = 1;
            this.cboGE.SelectionChangeCommitted += new System.EventHandler(this.cboGE_SelectionChangeCommitted);
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(135, 457);
            this.cboDepartamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(372, 28);
            this.cboDepartamento.TabIndex = 7;
            this.cboDepartamento.SelectionChangeCommitted += new System.EventHandler(this.cboDepartamento_SelectionChangeCommitted);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(21, 460);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 28);
            this.label10.TabIndex = 10;
            this.label10.Text = "Departamento:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(361, 660);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 42);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(361, 606);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(146, 42);
            this.btnGrabar.TabIndex = 12;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(21, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 27);
            this.label6.TabIndex = 3;
            this.label6.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(21, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCarne);
            this.groupBox1.Controls.Add(this.rdbRuc);
            this.groupBox1.Controls.Add(this.rdbDni);
            this.groupBox1.Location = new System.Drawing.Point(19, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 119);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Doc.";
            // 
            // rdbCarne
            // 
            this.rdbCarne.AutoSize = true;
            this.rdbCarne.Location = new System.Drawing.Point(16, 75);
            this.rdbCarne.Name = "rdbCarne";
            this.rdbCarne.Size = new System.Drawing.Size(134, 24);
            this.rdbCarne.TabIndex = 2;
            this.rdbCarne.TabStop = true;
            this.rdbCarne.Text = "Carné Extrajería";
            this.rdbCarne.UseVisualStyleBackColor = true;
            this.rdbCarne.CheckedChanged += new System.EventHandler(this.rdbCarne_CheckedChanged);
            // 
            // rdbRuc
            // 
            this.rdbRuc.AutoSize = true;
            this.rdbRuc.Location = new System.Drawing.Point(175, 38);
            this.rdbRuc.Name = "rdbRuc";
            this.rdbRuc.Size = new System.Drawing.Size(58, 24);
            this.rdbRuc.TabIndex = 1;
            this.rdbRuc.TabStop = true;
            this.rdbRuc.Text = "RUC";
            this.rdbRuc.UseVisualStyleBackColor = true;
            this.rdbRuc.CheckedChanged += new System.EventHandler(this.rdbRuc_CheckedChanged);
            // 
            // rdbDni
            // 
            this.rdbDni.AutoSize = true;
            this.rdbDni.Location = new System.Drawing.Point(16, 38);
            this.rdbDni.Name = "rdbDni";
            this.rdbDni.Size = new System.Drawing.Size(56, 24);
            this.rdbDni.TabIndex = 0;
            this.rdbDni.TabStop = true;
            this.rdbDni.Text = "DNI";
            this.rdbDni.UseVisualStyleBackColor = true;
            this.rdbDni.CheckedChanged += new System.EventHandler(this.rdbDni_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grp. Económico";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblCodigo);
            this.grpDatos.Controls.Add(this.label12);
            this.grpDatos.Controls.Add(this.chkEstado);
            this.grpDatos.Controls.Add(this.chkTipoCli);
            this.grpDatos.Controls.Add(this.label11);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.mskDoc);
            this.grpDatos.Controls.Add(this.cboProvincia);
            this.grpDatos.Controls.Add(this.cboDistrito);
            this.grpDatos.Controls.Add(this.label7);
            this.grpDatos.Controls.Add(this.label8);
            this.grpDatos.Controls.Add(this.label9);
            this.grpDatos.Controls.Add(this.cboGE);
            this.grpDatos.Controls.Add(this.cboDepartamento);
            this.grpDatos.Controls.Add(this.label10);
            this.grpDatos.Controls.Add(this.btnCancelar);
            this.grpDatos.Controls.Add(this.btnGrabar);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.groupBox1);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.txtTel);
            this.grpDatos.Controls.Add(this.txtEmail);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.txtDireccion);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Location = new System.Drawing.Point(12, 14);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDatos.Size = new System.Drawing.Size(544, 721);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // lblCodigo
            // 
            this.lblCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigo.Location = new System.Drawing.Point(135, 31);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(80, 30);
            this.lblCodigo.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Código:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(133, 409);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(372, 27);
            this.txtTel.TabIndex = 6;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(133, 361);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(372, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 77);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(372, 27);
            this.txtNombre.TabIndex = 0;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(133, 313);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(372, 27);
            this.txtDireccion.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // ClienteMan03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 749);
            this.Controls.Add(this.grpDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClienteMan03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Cliente";
            this.Load += new System.EventHandler(this.ClienteMan03_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CheckBox chkEstado;
        private CheckBox chkTipoCli;
        internal Label label11;
        internal Label label3;
        private MaskedTextBox mskDoc;
        private ComboBox cboProvincia;
        private ComboBox cboDistrito;
        internal Label label7;
        internal Label label8;
        internal Label label9;
        private ComboBox cboGE;
        private ComboBox cboDepartamento;
        internal Label label10;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton rdbCarne;
        private RadioButton rdbRuc;
        private RadioButton rdbDni;
        private Label label2;
        internal GroupBox grpDatos;
        private Label lblCodigo;
        private Label label12;
        internal TextBox txtTel;
        internal TextBox txtEmail;
        internal TextBox txtNombre;
        internal TextBox txtDireccion;
        private Label label1;
    }
}