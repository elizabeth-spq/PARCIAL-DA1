﻿namespace ProyConsultora_GUI
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
            this.label12 = new System.Windows.Forms.Label();
            this.txtPresupuesto = new System.Windows.Forms.TextBox();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.grpEstados = new System.Windows.Forms.GroupBox();
            this.rdbProgramado = new System.Windows.Forms.RadioButton();
            this.rdbEjecucion = new System.Windows.Forms.RadioButton();
            this.rdbDetenido = new System.Windows.Forms.RadioButton();
            this.rdbCancelado = new System.Windows.Forms.RadioButton();
            this.rdbFinalizado = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.grpEstados.SuspendLayout();
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
            this.txtNombre.Size = new System.Drawing.Size(383, 27);
            this.txtNombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 84);
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
            this.groupBox1.Location = new System.Drawing.Point(21, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 115);
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
            this.rdbNoFac.Text = "No Facturable";
            this.rdbNoFac.UseVisualStyleBackColor = true;
            // 
            // rdbHorasTra
            // 
            this.rdbHorasTra.AutoSize = true;
            this.rdbHorasTra.Checked = true;
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
            this.rdbFacRe.Text = "Facturable recurrente";
            this.rdbFacRe.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(228, 370);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(142, 42);
            this.btnGrabar.TabIndex = 5;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(376, 370);
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
            this.cboArea.Location = new System.Drawing.Point(135, 81);
            this.cboArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(383, 28);
            this.cboArea.TabIndex = 1;
            this.cboArea.SelectionChangeCommitted += new System.EventHandler(this.cboArea_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Presupuesto:";
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.Location = new System.Drawing.Point(21, 385);
            this.txtPresupuesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Size = new System.Drawing.Size(142, 27);
            this.txtPresupuesto.TabIndex = 3;
            this.txtPresupuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPresupuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPresupuesto_KeyPress);
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.grpEstados);
            this.grpDatos.Controls.Add(this.txtPresupuesto);
            this.grpDatos.Controls.Add(this.label12);
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
            this.grpDatos.Size = new System.Drawing.Size(544, 420);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // grpEstados
            // 
            this.grpEstados.Controls.Add(this.rdbDetenido);
            this.grpEstados.Controls.Add(this.rdbFinalizado);
            this.grpEstados.Controls.Add(this.rdbEjecucion);
            this.grpEstados.Controls.Add(this.rdbCancelado);
            this.grpEstados.Controls.Add(this.rdbProgramado);
            this.grpEstados.Location = new System.Drawing.Point(21, 254);
            this.grpEstados.Name = "grpEstados";
            this.grpEstados.Size = new System.Drawing.Size(495, 91);
            this.grpEstados.TabIndex = 21;
            this.grpEstados.TabStop = false;
            this.grpEstados.Text = "Estado:";
            // 
            // rdbProgramado
            // 
            this.rdbProgramado.AutoSize = true;
            this.rdbProgramado.Checked = true;
            this.rdbProgramado.Location = new System.Drawing.Point(11, 29);
            this.rdbProgramado.Name = "rdbProgramado";
            this.rdbProgramado.Size = new System.Drawing.Size(113, 24);
            this.rdbProgramado.TabIndex = 0;
            this.rdbProgramado.TabStop = true;
            this.rdbProgramado.Text = "Programado";
            this.rdbProgramado.UseVisualStyleBackColor = true;
            // 
            // rdbEjecucion
            // 
            this.rdbEjecucion.AutoSize = true;
            this.rdbEjecucion.Location = new System.Drawing.Point(194, 26);
            this.rdbEjecucion.Name = "rdbEjecucion";
            this.rdbEjecucion.Size = new System.Drawing.Size(113, 24);
            this.rdbEjecucion.TabIndex = 1;
            this.rdbEjecucion.TabStop = true;
            this.rdbEjecucion.Text = "En ejecución";
            this.rdbEjecucion.UseVisualStyleBackColor = true;
            // 
            // rdbDetenido
            // 
            this.rdbDetenido.AutoSize = true;
            this.rdbDetenido.Location = new System.Drawing.Point(372, 29);
            this.rdbDetenido.Name = "rdbDetenido";
            this.rdbDetenido.Size = new System.Drawing.Size(92, 24);
            this.rdbDetenido.TabIndex = 2;
            this.rdbDetenido.TabStop = true;
            this.rdbDetenido.Text = "Detenido";
            this.rdbDetenido.UseVisualStyleBackColor = true;
            // 
            // rdbCancelado
            // 
            this.rdbCancelado.AutoSize = true;
            this.rdbCancelado.Location = new System.Drawing.Point(11, 59);
            this.rdbCancelado.Name = "rdbCancelado";
            this.rdbCancelado.Size = new System.Drawing.Size(100, 24);
            this.rdbCancelado.TabIndex = 0;
            this.rdbCancelado.TabStop = true;
            this.rdbCancelado.Text = "Cancelado";
            this.rdbCancelado.UseVisualStyleBackColor = true;
            // 
            // rdbFinalizado
            // 
            this.rdbFinalizado.AutoSize = true;
            this.rdbFinalizado.Location = new System.Drawing.Point(194, 56);
            this.rdbFinalizado.Name = "rdbFinalizado";
            this.rdbFinalizado.Size = new System.Drawing.Size(98, 24);
            this.rdbFinalizado.TabIndex = 1;
            this.rdbFinalizado.TabStop = true;
            this.rdbFinalizado.Text = "Finalizado";
            this.rdbFinalizado.UseVisualStyleBackColor = true;
            // 
            // ProyectoMan02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 448);
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
            this.grpEstados.ResumeLayout(false);
            this.grpEstados.PerformLayout();
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
        private Label label12;
        private TextBox txtPresupuesto;
        internal GroupBox grpDatos;
        private RadioButton rdbNoFac;
        private GroupBox grpEstados;
        private RadioButton rdbDetenido;
        private RadioButton rdbFinalizado;
        private RadioButton rdbEjecucion;
        private RadioButton rdbCancelado;
        private RadioButton rdbProgramado;
    }
}