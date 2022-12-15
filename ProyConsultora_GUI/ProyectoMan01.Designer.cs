namespace ProyConsultora_GUI
{
    partial class ProyectoMan01
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.Cod_Proy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Proy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imp_Imp_Estm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDatos
            // 
            this.dtgDatos.AllowUserToAddRows = false;
            this.dtgDatos.AllowUserToDeleteRows = false;
            this.dtgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Proy,
            this.Nom_Proy,
            this.Nom_Area,
            this.Tipo_Proyecto,
            this.Imp_Imp_Estm,
            this.Estado_Proyecto});
            this.dtgDatos.Location = new System.Drawing.Point(14, 92);
            this.dtgDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.ReadOnly = true;
            this.dtgDatos.RowHeadersVisible = false;
            this.dtgDatos.RowHeadersWidth = 51;
            this.dtgDatos.RowTemplate.Height = 25;
            this.dtgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDatos.Size = new System.Drawing.Size(1110, 453);
            this.dtgDatos.TabIndex = 1;
            // 
            // Cod_Proy
            // 
            this.Cod_Proy.DataPropertyName = "Cod_Proy";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Cod_Proy.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cod_Proy.HeaderText = "Código";
            this.Cod_Proy.MinimumWidth = 6;
            this.Cod_Proy.Name = "Cod_Proy";
            this.Cod_Proy.ReadOnly = true;
            // 
            // Nom_Proy
            // 
            this.Nom_Proy.DataPropertyName = "Nom_Proy";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Nom_Proy.DefaultCellStyle = dataGridViewCellStyle2;
            this.Nom_Proy.HeaderText = "Proyecto";
            this.Nom_Proy.MinimumWidth = 6;
            this.Nom_Proy.Name = "Nom_Proy";
            this.Nom_Proy.ReadOnly = true;
            // 
            // Nom_Area
            // 
            this.Nom_Area.DataPropertyName = "Nom_Area";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Nom_Area.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nom_Area.HeaderText = "Área";
            this.Nom_Area.MinimumWidth = 6;
            this.Nom_Area.Name = "Nom_Area";
            this.Nom_Area.ReadOnly = true;
            // 
            // Tipo_Proyecto
            // 
            this.Tipo_Proyecto.DataPropertyName = "Tipo_Proyecto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Tipo_Proyecto.DefaultCellStyle = dataGridViewCellStyle4;
            this.Tipo_Proyecto.HeaderText = "Tipo";
            this.Tipo_Proyecto.MinimumWidth = 6;
            this.Tipo_Proyecto.Name = "Tipo_Proyecto";
            this.Tipo_Proyecto.ReadOnly = true;
            // 
            // Imp_Imp_Estm
            // 
            this.Imp_Imp_Estm.DataPropertyName = "Imp_Imp_Estm";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Imp_Imp_Estm.DefaultCellStyle = dataGridViewCellStyle5;
            this.Imp_Imp_Estm.HeaderText = "Presupuesto Inicial";
            this.Imp_Imp_Estm.MinimumWidth = 6;
            this.Imp_Imp_Estm.Name = "Imp_Imp_Estm";
            this.Imp_Imp_Estm.ReadOnly = true;
            // 
            // Estado_Proyecto
            // 
            this.Estado_Proyecto.DataPropertyName = "Estado_Proyecto";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Estado_Proyecto.DefaultCellStyle = dataGridViewCellStyle6;
            this.Estado_Proyecto.HeaderText = "Estado";
            this.Estado_Proyecto.MinimumWidth = 6;
            this.Estado_Proyecto.Name = "Estado_Proyecto";
            this.Estado_Proyecto.ReadOnly = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(582, 621);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(111, 43);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(714, 621);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(111, 43);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(846, 621);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 43);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1013, 621);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(111, 43);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese filtro por descripcion:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(246, 32);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(358, 27);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(937, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(1027, 561);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(96, 29);
            this.lblRegistros.TabIndex = 2;
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProyectoMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 680);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProyectoMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Proyectos";
            this.Load += new System.EventHandler(this.ProductoMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgDatos;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnCerrar;
        private Label label1;
        private TextBox txtFiltro;
        private Label label2;
        private Label lblRegistros;
        private DataGridViewTextBoxColumn Cod_Proy;
        private DataGridViewTextBoxColumn Nom_Proy;
        private DataGridViewTextBoxColumn Nom_Area;
        private DataGridViewTextBoxColumn Tipo_Proyecto;
        private DataGridViewTextBoxColumn Imp_Imp_Estm;
        private DataGridViewTextBoxColumn Estado_Proyecto;
    }
}