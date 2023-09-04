namespace ejercicio_1_6.Precentacion
{
    partial class FrmCamiones
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
            this.lblPesoMax = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.txtPesoMax = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvListCamiones = new System.Windows.Forms.DataGridView();
            this.colPatente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCargaMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grogpCamionNuevo = new System.Windows.Forms.GroupBox();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.cbListo = new System.Windows.Forms.CheckBox();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCargaMaxima = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatenteBusqueda = new System.Windows.Forms.TextBox();
            this.lblCargaMax = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCamiones)).BeginInit();
            this.grogpCamionNuevo.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPesoMax
            // 
            this.lblPesoMax.AutoSize = true;
            this.lblPesoMax.Location = new System.Drawing.Point(5, 63);
            this.lblPesoMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesoMax.Name = "lblPesoMax";
            this.lblPesoMax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPesoMax.Size = new System.Drawing.Size(69, 13);
            this.lblPesoMax.TabIndex = 3;
            this.lblPesoMax.Text = "Peso maximo";
            this.lblPesoMax.Click += new System.EventHandler(this.lblPeso_Click);
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(5, 27);
            this.lblPatente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPatente.Size = new System.Drawing.Size(44, 13);
            this.lblPatente.TabIndex = 4;
            this.lblPatente.Text = "Patente";
            this.lblPatente.Click += new System.EventHandler(this.lblDescripcion_Click);
            // 
            // txtPesoMax
            // 
            this.txtPesoMax.Location = new System.Drawing.Point(82, 60);
            this.txtPesoMax.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesoMax.Name = "txtPesoMax";
            this.txtPesoMax.Size = new System.Drawing.Size(170, 20);
            this.txtPesoMax.TabIndex = 2;
            this.txtPesoMax.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(82, 24);
            this.txtPatente.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(170, 20);
            this.txtPatente.TabIndex = 1;
            this.txtPatente.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(594, 338);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 19);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(269, 60);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 20);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvListCamiones
            // 
            this.dgvListCamiones.AllowUserToAddRows = false;
            this.dgvListCamiones.AllowUserToDeleteRows = false;
            this.dgvListCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCamiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPatente,
            this.colCargaMax,
            this.colCarga,
            this.colPorcentaje,
            this.colEstado});
            this.dgvListCamiones.Location = new System.Drawing.Point(12, 188);
            this.dgvListCamiones.Name = "dgvListCamiones";
            this.dgvListCamiones.ReadOnly = true;
            this.dgvListCamiones.Size = new System.Drawing.Size(541, 169);
            this.dgvListCamiones.TabIndex = 5;
            this.dgvListCamiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCamiones_CellContentClick);
            // 
            // colPatente
            // 
            this.colPatente.HeaderText = "Patente";
            this.colPatente.Name = "colPatente";
            this.colPatente.ReadOnly = true;
            // 
            // colCargaMax
            // 
            this.colCargaMax.HeaderText = "Carga Maxima";
            this.colCargaMax.Name = "colCargaMax";
            this.colCargaMax.ReadOnly = true;
            // 
            // colCarga
            // 
            this.colCarga.HeaderText = "peso Cargado";
            this.colCarga.Name = "colCarga";
            this.colCarga.ReadOnly = true;
            // 
            // colPorcentaje
            // 
            this.colPorcentaje.HeaderText = "Porcentaje";
            this.colPorcentaje.Name = "colPorcentaje";
            this.colPorcentaje.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // grogpCamionNuevo
            // 
            this.grogpCamionNuevo.Controls.Add(this.btnAgregar);
            this.grogpCamionNuevo.Controls.Add(this.txtPesoMax);
            this.grogpCamionNuevo.Controls.Add(this.txtPatente);
            this.grogpCamionNuevo.Controls.Add(this.lblPatente);
            this.grogpCamionNuevo.Controls.Add(this.lblPesoMax);
            this.grogpCamionNuevo.Location = new System.Drawing.Point(12, 12);
            this.grogpCamionNuevo.Name = "grogpCamionNuevo";
            this.grogpCamionNuevo.Size = new System.Drawing.Size(354, 106);
            this.grogpCamionNuevo.TabIndex = 6;
            this.grogpCamionNuevo.TabStop = false;
            this.grogpCamionNuevo.Text = "Camion nuevo";
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.cbListo);
            this.gbFiltros.Controls.Add(this.txtPorcentaje);
            this.gbFiltros.Controls.Add(this.label4);
            this.gbFiltros.Controls.Add(this.txtCargaMaxima);
            this.gbFiltros.Controls.Add(this.label3);
            this.gbFiltros.Controls.Add(this.txtPatenteBusqueda);
            this.gbFiltros.Controls.Add(this.lblCargaMax);
            this.gbFiltros.Controls.Add(this.btnBuscar);
            this.gbFiltros.Location = new System.Drawing.Point(385, 12);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(309, 145);
            this.gbFiltros.TabIndex = 7;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // cbListo
            // 
            this.cbListo.AutoSize = true;
            this.cbListo.Location = new System.Drawing.Point(49, 114);
            this.cbListo.Name = "cbListo";
            this.cbListo.Size = new System.Drawing.Size(98, 17);
            this.cbListo.TabIndex = 13;
            this.cbListo.Text = "Listo para partir";
            this.cbListo.UseVisualStyleBackColor = true;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(154, 76);
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(2);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(146, 20);
            this.txtPorcentaje.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Porcentaje Cargado mayor a";
            // 
            // txtCargaMaxima
            // 
            this.txtCargaMaxima.Location = new System.Drawing.Point(154, 47);
            this.txtCargaMaxima.Margin = new System.Windows.Forms.Padding(2);
            this.txtCargaMaxima.Name = "txtCargaMaxima";
            this.txtCargaMaxima.Size = new System.Drawing.Size(146, 20);
            this.txtCargaMaxima.TabIndex = 9;
            this.txtCargaMaxima.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Patente";
            // 
            // txtPatenteBusqueda
            // 
            this.txtPatenteBusqueda.Location = new System.Drawing.Point(154, 18);
            this.txtPatenteBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatenteBusqueda.Name = "txtPatenteBusqueda";
            this.txtPatenteBusqueda.Size = new System.Drawing.Size(146, 20);
            this.txtPatenteBusqueda.TabIndex = 5;
            // 
            // lblCargaMax
            // 
            this.lblCargaMax.AutoSize = true;
            this.lblCargaMax.Location = new System.Drawing.Point(37, 47);
            this.lblCargaMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargaMax.Name = "lblCargaMax";
            this.lblCargaMax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCargaMax.Size = new System.Drawing.Size(113, 13);
            this.lblCargaMax.TabIndex = 6;
            this.lblCargaMax.Text = "Carga maxima mayor a";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(209, 114);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 20);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmCamiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 381);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.grogpCamionNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvListCamiones);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCamiones";
            this.Text = "Camiones";
            this.Load += new System.EventHandler(this.FormCargas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCamiones)).EndInit();
            this.grogpCamionNuevo.ResumeLayout(false);
            this.grogpCamionNuevo.PerformLayout();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblPesoMax;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.TextBox txtPesoMax;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvListCamiones;
        private System.Windows.Forms.GroupBox grogpCamionNuevo;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCargaMaxima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatenteBusqueda;
        private System.Windows.Forms.Label lblCargaMax;
        private System.Windows.Forms.CheckBox cbListo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCargaMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPorcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}