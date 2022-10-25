namespace ProyConsultora_GUI
{
    partial class ColaboradorMan01
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
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.Cod_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ape_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fec_Nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_Doc_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cel_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ema_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sue_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Colaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Antiguedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fot_Col = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.Cod_Col,
            this.Ape_Col,
            this.Nom_Col,
            this.Nom_Area,
            this.Nom_Cat,
            this.Fec_Nac,
            this.Tipo_Documento,
            this.Num_Doc_Col,
            this.Cel_Col,
            this.Ema_Col,
            this.Dir_Col,
            this.Sue_Col,
            this.Estado_Colaborador,
            this.Antiguedad,
            this.Fot_Col});
            this.dtgDatos.Location = new System.Drawing.Point(14, 92);
            this.dtgDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.ReadOnly = true;
            this.dtgDatos.RowHeadersVisible = false;
            this.dtgDatos.RowHeadersWidth = 51;
            this.dtgDatos.RowTemplate.Height = 25;
            this.dtgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDatos.Size = new System.Drawing.Size(1110, 453);
            this.dtgDatos.TabIndex = 0;
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
            this.btnActualizar.TabIndex = 1;
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
            this.btnEliminar.TabIndex = 1;
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
            this.btnCerrar.TabIndex = 1;
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
            this.txtFiltro.TabIndex = 3;
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
            // Cod_Col
            // 
            this.Cod_Col.DataPropertyName = "Cod_Col";
            this.Cod_Col.HeaderText = "Código";
            this.Cod_Col.MinimumWidth = 6;
            this.Cod_Col.Name = "Cod_Col";
            this.Cod_Col.ReadOnly = true;
            // 
            // Ape_Col
            // 
            this.Ape_Col.DataPropertyName = "Ape_Col";
            this.Ape_Col.HeaderText = "Apellidos";
            this.Ape_Col.MinimumWidth = 6;
            this.Ape_Col.Name = "Ape_Col";
            this.Ape_Col.ReadOnly = true;
            // 
            // Nom_Col
            // 
            this.Nom_Col.DataPropertyName = "Nom_Col";
            this.Nom_Col.HeaderText = "Nombres";
            this.Nom_Col.MinimumWidth = 6;
            this.Nom_Col.Name = "Nom_Col";
            this.Nom_Col.ReadOnly = true;
            // 
            // Nom_Area
            // 
            this.Nom_Area.DataPropertyName = "Nom_Area";
            this.Nom_Area.HeaderText = "Area";
            this.Nom_Area.MinimumWidth = 6;
            this.Nom_Area.Name = "Nom_Area";
            this.Nom_Area.ReadOnly = true;
            // 
            // Nom_Cat
            // 
            this.Nom_Cat.DataPropertyName = "Nom_Cat";
            this.Nom_Cat.HeaderText = "Categoría";
            this.Nom_Cat.MinimumWidth = 6;
            this.Nom_Cat.Name = "Nom_Cat";
            this.Nom_Cat.ReadOnly = true;
            // 
            // Fec_Nac
            // 
            this.Fec_Nac.DataPropertyName = "Fec_Nac";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Fec_Nac.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fec_Nac.HeaderText = "Fec. Nacimiento";
            this.Fec_Nac.MinimumWidth = 6;
            this.Fec_Nac.Name = "Fec_Nac";
            this.Fec_Nac.ReadOnly = true;
            // 
            // Tipo_Documento
            // 
            this.Tipo_Documento.DataPropertyName = "Tipo_Documento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.Tipo_Documento.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tipo_Documento.HeaderText = "Tipo Doc";
            this.Tipo_Documento.MinimumWidth = 6;
            this.Tipo_Documento.Name = "Tipo_Documento";
            this.Tipo_Documento.ReadOnly = true;
            // 
            // Num_Doc_Col
            // 
            this.Num_Doc_Col.DataPropertyName = "Num_Doc_Col";
            this.Num_Doc_Col.HeaderText = "Nº Doc";
            this.Num_Doc_Col.MinimumWidth = 6;
            this.Num_Doc_Col.Name = "Num_Doc_Col";
            this.Num_Doc_Col.ReadOnly = true;
            // 
            // Cel_Col
            // 
            this.Cel_Col.DataPropertyName = "Cel_Col";
            this.Cel_Col.HeaderText = "Contacto";
            this.Cel_Col.MinimumWidth = 6;
            this.Cel_Col.Name = "Cel_Col";
            this.Cel_Col.ReadOnly = true;
            // 
            // Ema_Col
            // 
            this.Ema_Col.DataPropertyName = "Ema_Col";
            this.Ema_Col.HeaderText = "E-mail";
            this.Ema_Col.MinimumWidth = 6;
            this.Ema_Col.Name = "Ema_Col";
            this.Ema_Col.ReadOnly = true;
            // 
            // Dir_Col
            // 
            this.Dir_Col.DataPropertyName = "Dir_Col";
            this.Dir_Col.HeaderText = "Dirección";
            this.Dir_Col.MinimumWidth = 6;
            this.Dir_Col.Name = "Dir_Col";
            this.Dir_Col.ReadOnly = true;
            // 
            // Sue_Col
            // 
            this.Sue_Col.DataPropertyName = "Sue_Col";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Sue_Col.DefaultCellStyle = dataGridViewCellStyle3;
            this.Sue_Col.HeaderText = "Sueldo";
            this.Sue_Col.MinimumWidth = 6;
            this.Sue_Col.Name = "Sue_Col";
            this.Sue_Col.ReadOnly = true;
            // 
            // Estado_Colaborador
            // 
            this.Estado_Colaborador.DataPropertyName = "Estado_Colaborador";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Estado_Colaborador.DefaultCellStyle = dataGridViewCellStyle4;
            this.Estado_Colaborador.HeaderText = "Estado";
            this.Estado_Colaborador.MinimumWidth = 6;
            this.Estado_Colaborador.Name = "Estado_Colaborador";
            this.Estado_Colaborador.ReadOnly = true;
            // 
            // Antiguedad
            // 
            this.Antiguedad.DataPropertyName = "Antiguedad";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Antiguedad.DefaultCellStyle = dataGridViewCellStyle5;
            this.Antiguedad.HeaderText = "Antiguedad";
            this.Antiguedad.MinimumWidth = 6;
            this.Antiguedad.Name = "Antiguedad";
            this.Antiguedad.ReadOnly = true;
            // 
            // Fot_Col
            // 
            this.Fot_Col.DataPropertyName = "Fot_Col";
            this.Fot_Col.HeaderText = "Foto";
            this.Fot_Col.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Fot_Col.MinimumWidth = 6;
            this.Fot_Col.Name = "Fot_Col";
            this.Fot_Col.ReadOnly = true;
            this.Fot_Col.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Fot_Col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColaboradorMan01
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
            this.Name = "ColaboradorMan01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Colaborador";
            this.Load += new System.EventHandler(this.ColaboradorMan01_Load);
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
        private DataGridViewTextBoxColumn Cod_Col;
        private DataGridViewTextBoxColumn Ape_Col;
        private DataGridViewTextBoxColumn Nom_Col;
        private DataGridViewTextBoxColumn Nom_Area;
        private DataGridViewTextBoxColumn Nom_Cat;
        private DataGridViewTextBoxColumn Fec_Nac;
        private DataGridViewTextBoxColumn Tipo_Documento;
        private DataGridViewTextBoxColumn Num_Doc_Col;
        private DataGridViewTextBoxColumn Cel_Col;
        private DataGridViewTextBoxColumn Ema_Col;
        private DataGridViewTextBoxColumn Dir_Col;
        private DataGridViewTextBoxColumn Sue_Col;
        private DataGridViewTextBoxColumn Estado_Colaborador;
        private DataGridViewTextBoxColumn Antiguedad;
        private DataGridViewImageColumn Fot_Col;
    }
}