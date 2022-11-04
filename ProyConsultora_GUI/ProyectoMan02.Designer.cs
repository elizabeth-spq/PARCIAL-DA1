namespace ProyConsultora_GUI
{
    partial class ProyectoMan02
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNoFac = new System.Windows.Forms.RadioButton();
            this.rdbHorasTra = new System.Windows.Forms.RadioButton();
            this.rdbFacNoRe = new System.Windows.Forms.RadioButton();
            this.rdbFacRe = new System.Windows.Forms.RadioButton();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPresupuesto = new System.Windows.Forms.TextBox();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 36);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(372, 27);
            this.txtNombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Area";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNoFac);
            this.groupBox1.Controls.Add(this.rdbHorasTra);
            this.groupBox1.Controls.Add(this.rdbFacNoRe);
            this.groupBox1.Controls.Add(this.rdbFacRe);
            this.groupBox1.Location = new System.Drawing.Point(19, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Proyecto:";
            // 
            // rdbNoFac
            // 
            this.rdbNoFac.AutoSize = true;
            this.rdbNoFac.Location = new System.Drawing.Point(274, 75);
            this.rdbNoFac.Name = "rdbNoFac";
            this.rdbNoFac.Size = new System.Drawing.Size(122, 24);
            this.rdbNoFac.TabIndex = 3;
            this.rdbNoFac.TabStop = true;
            this.rdbNoFac.Text = "No Facturable";
            this.rdbNoFac.UseVisualStyleBackColor = true;
            // 
            // rdbHorasTra
            // 
            this.rdbHorasTra.AutoSize = true;
            this.rdbHorasTra.Location = new System.Drawing.Point(48, 75);
            this.rdbHorasTra.Name = "rdbHorasTra";
            this.rdbHorasTra.Size = new System.Drawing.Size(165, 24);
            this.rdbHorasTra.TabIndex = 2;
            this.rdbHorasTra.TabStop = true;
            this.rdbHorasTra.Text = "Por horas trabajadas";
            this.rdbHorasTra.UseVisualStyleBackColor = true;
            // 
            // rdbFacNoRe
            // 
            this.rdbFacNoRe.AutoSize = true;
            this.rdbFacNoRe.Location = new System.Drawing.Point(274, 38);
            this.rdbFacNoRe.Name = "rdbFacNoRe";
            this.rdbFacNoRe.Size = new System.Drawing.Size(190, 24);
            this.rdbFacNoRe.TabIndex = 1;
            this.rdbFacNoRe.TabStop = true;
            this.rdbFacNoRe.Text = "Facturable no recurrente";
            this.rdbFacNoRe.UseVisualStyleBackColor = true;
            // 
            // rdbFacRe
            // 
            this.rdbFacRe.AutoSize = true;
            this.rdbFacRe.Location = new System.Drawing.Point(48, 38);
            this.rdbFacRe.Name = "rdbFacRe";
            this.rdbFacRe.Size = new System.Drawing.Size(169, 24);
            this.rdbFacRe.TabIndex = 0;
            this.rdbFacRe.TabStop = true;
            this.rdbFacRe.Text = "Facturable recurrente";
            this.rdbFacRe.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(365, 280);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(142, 42);
            this.btnGrabar.TabIndex = 5;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(365, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(142, 42);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboArea
            // 
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(135, 87);
            this.cboArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(372, 28);
            this.cboArea.TabIndex = 1;
            this.cboArea.SelectionChangeCommitted += new System.EventHandler(this.cboArea_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(232, 303);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 28);
            this.label11.TabIndex = 18;
            this.label11.Text = "Estado";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(233, 338);
            this.chkEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(106, 24);
            this.chkEstado.TabIndex = 4;
            this.chkEstado.Text = "Finalizado?";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Presupuesto:";
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.Location = new System.Drawing.Point(21, 335);
            this.txtPresupuesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Size = new System.Drawing.Size(142, 27);
            this.txtPresupuesto.TabIndex = 3;
            this.txtPresupuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPresupuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPresupuesto_KeyPress);
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtPresupuesto);
            this.grpDatos.Controls.Add(this.label12);
            this.grpDatos.Controls.Add(this.chkEstado);
            this.grpDatos.Controls.Add(this.label11);
            this.grpDatos.Controls.Add(this.cboArea);
            this.grpDatos.Controls.Add(this.btnCancelar);
            this.grpDatos.Controls.Add(this.btnGrabar);
            this.grpDatos.Controls.Add(this.groupBox1);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Location = new System.Drawing.Point(13, 14);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDatos.Size = new System.Drawing.Size(544, 393);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // ProyectoMan02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 418);
            this.Controls.Add(this.grpDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProyectoMan02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo proyecto";
            this.Load += new System.EventHandler(this.ProyectoMan02_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        internal TextBox txtNombre;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton rdbHorasTra;
        private RadioButton rdbFacNoRe;
        private RadioButton rdbFacRe;
        private Button btnGrabar;
        private Button btnCancelar;
        private ComboBox cboArea;
        internal Label label11;
        private CheckBox chkEstado;
        private Label label12;
        private TextBox txtPresupuesto;
        internal GroupBox grpDatos;
        private RadioButton rdbNoFac;
    }
}