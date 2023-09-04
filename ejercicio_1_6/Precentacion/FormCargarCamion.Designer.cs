namespace ejercicio_1_6.Precentacion
{
    partial class FormCargarCamion
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
            this.dgvCamion = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTipoCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btQuitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblPesoMax = new System.Windows.Forms.Label();
            this.txtPesoMax = new System.Windows.Forms.TextBox();
            this.btnSeleccionarCamion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.AgregarCarga = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoCarga = new System.Windows.Forms.ComboBox();
            this.gbCarga = new System.Windows.Forms.GroupBox();
            this.cbCamiones = new System.Windows.Forms.ComboBox();
            this.btnCambiarCamion = new System.Windows.Forms.Button();
            this.lblPesoRestante = new System.Windows.Forms.Label();
            this.lblPesoCargado = new System.Windows.Forms.Label();
            this.txtPesoCargado = new System.Windows.Forms.TextBox();
            this.txtPesoRestante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCargaCamion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamion)).BeginInit();
            this.gbCarga.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCamion
            // 
            this.dgvCamion.AllowUserToAddRows = false;
            this.dgvCamion.AllowUserToDeleteRows = false;
            this.dgvCamion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.clDescripcion,
            this.clTipoCarga,
            this.clPeso,
            this.btQuitar});
            this.dgvCamion.Location = new System.Drawing.Point(19, 176);
            this.dgvCamion.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCamion.Name = "dgvCamion";
            this.dgvCamion.ReadOnly = true;
            this.dgvCamion.RowHeadersWidth = 51;
            this.dgvCamion.RowTemplate.Height = 24;
            this.dgvCamion.Size = new System.Drawing.Size(548, 128);
            this.dgvCamion.TabIndex = 0;
            this.dgvCamion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCamion_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // clDescripcion
            // 
            this.clDescripcion.HeaderText = "Carga";
            this.clDescripcion.MinimumWidth = 6;
            this.clDescripcion.Name = "clDescripcion";
            this.clDescripcion.ReadOnly = true;
            this.clDescripcion.Width = 300;
            // 
            // clTipoCarga
            // 
            this.clTipoCarga.HeaderText = "Tipo";
            this.clTipoCarga.MinimumWidth = 6;
            this.clTipoCarga.Name = "clTipoCarga";
            this.clTipoCarga.ReadOnly = true;
            this.clTipoCarga.Width = 125;
            // 
            // clPeso
            // 
            this.clPeso.HeaderText = "Peso";
            this.clPeso.MinimumWidth = 6;
            this.clPeso.Name = "clPeso";
            this.clPeso.ReadOnly = true;
            this.clPeso.Width = 125;
            // 
            // btQuitar
            // 
            this.btQuitar.HeaderText = "Accion";
            this.btQuitar.MinimumWidth = 6;
            this.btQuitar.Name = "btQuitar";
            this.btQuitar.ReadOnly = true;
            this.btQuitar.Width = 125;
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(16, 17);
            this.lblPatente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(44, 13);
            this.lblPatente.TabIndex = 2;
            this.lblPatente.Text = "Patente";
            // 
            // lblPesoMax
            // 
            this.lblPesoMax.AutoSize = true;
            this.lblPesoMax.Location = new System.Drawing.Point(220, 17);
            this.lblPesoMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesoMax.Name = "lblPesoMax";
            this.lblPesoMax.Size = new System.Drawing.Size(70, 13);
            this.lblPesoMax.TabIndex = 3;
            this.lblPesoMax.Text = "Peso Maximo";
            // 
            // txtPesoMax
            // 
            this.txtPesoMax.Location = new System.Drawing.Point(292, 15);
            this.txtPesoMax.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesoMax.Name = "txtPesoMax";
            this.txtPesoMax.ReadOnly = true;
            this.txtPesoMax.Size = new System.Drawing.Size(55, 20);
            this.txtPesoMax.TabIndex = 4;
            this.txtPesoMax.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnSeleccionarCamion
            // 
            this.btnSeleccionarCamion.Location = new System.Drawing.Point(372, 11);
            this.btnSeleccionarCamion.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionarCamion.Name = "btnSeleccionarCamion";
            this.btnSeleccionarCamion.Size = new System.Drawing.Size(69, 23);
            this.btnSeleccionarCamion.TabIndex = 5;
            this.btnSeleccionarCamion.Text = "Seleccionar";
            this.btnSeleccionarCamion.UseVisualStyleBackColor = true;
            this.btnSeleccionarCamion.Click += new System.EventHandler(this.btnSeleccionarCamion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(490, 321);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(76, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // AgregarCarga
            // 
            this.AgregarCarga.Location = new System.Drawing.Point(287, 71);
            this.AgregarCarga.Margin = new System.Windows.Forms.Padding(2);
            this.AgregarCarga.Name = "AgregarCarga";
            this.AgregarCarga.Size = new System.Drawing.Size(74, 27);
            this.AgregarCarga.TabIndex = 15;
            this.AgregarCarga.Text = "Agregar";
            this.AgregarCarga.UseVisualStyleBackColor = true;
            this.AgregarCarga.Click += new System.EventHandler(this.AgregarCarga_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(88, 24);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(170, 20);
            this.txtDescripcion.TabIndex = 14;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(88, 49);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(2);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(170, 20);
            this.txtPeso.TabIndex = 13;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 24);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDescripcion.Size = new System.Drawing.Size(69, 13);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descriopcion";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(51, 49);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 11;
            this.lblPeso.Text = "Peso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tipo de Carga";
            // 
            // cbTipoCarga
            // 
            this.cbTipoCarga.FormattingEnabled = true;
            this.cbTipoCarga.Location = new System.Drawing.Point(88, 75);
            this.cbTipoCarga.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoCarga.Name = "cbTipoCarga";
            this.cbTipoCarga.Size = new System.Drawing.Size(170, 21);
            this.cbTipoCarga.TabIndex = 9;
            this.cbTipoCarga.SelectedIndexChanged += new System.EventHandler(this.cbTipoCarga_SelectedIndexChanged);
            // 
            // gbCarga
            // 
            this.gbCarga.Controls.Add(this.label1);
            this.gbCarga.Controls.Add(this.AgregarCarga);
            this.gbCarga.Controls.Add(this.cbTipoCarga);
            this.gbCarga.Controls.Add(this.txtDescripcion);
            this.gbCarga.Controls.Add(this.txtPeso);
            this.gbCarga.Controls.Add(this.lblDescripcion);
            this.gbCarga.Controls.Add(this.lblPeso);
            this.gbCarga.Location = new System.Drawing.Point(19, 42);
            this.gbCarga.Margin = new System.Windows.Forms.Padding(2);
            this.gbCarga.Name = "gbCarga";
            this.gbCarga.Padding = new System.Windows.Forms.Padding(2);
            this.gbCarga.Size = new System.Drawing.Size(380, 119);
            this.gbCarga.TabIndex = 16;
            this.gbCarga.TabStop = false;
            this.gbCarga.Text = "Cargas";
            // 
            // cbCamiones
            // 
            this.cbCamiones.FormattingEnabled = true;
            this.cbCamiones.Location = new System.Drawing.Point(61, 15);
            this.cbCamiones.Margin = new System.Windows.Forms.Padding(2);
            this.cbCamiones.Name = "cbCamiones";
            this.cbCamiones.Size = new System.Drawing.Size(156, 21);
            this.cbCamiones.TabIndex = 16;
            // 
            // btnCambiarCamion
            // 
            this.btnCambiarCamion.Location = new System.Drawing.Point(446, 12);
            this.btnCambiarCamion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarCamion.Name = "btnCambiarCamion";
            this.btnCambiarCamion.Size = new System.Drawing.Size(69, 23);
            this.btnCambiarCamion.TabIndex = 17;
            this.btnCambiarCamion.Text = "Cambiar";
            this.btnCambiarCamion.UseVisualStyleBackColor = true;
            this.btnCambiarCamion.Click += new System.EventHandler(this.btnCambiarCamion_Click);
            // 
            // lblPesoRestante
            // 
            this.lblPesoRestante.AutoSize = true;
            this.lblPesoRestante.Location = new System.Drawing.Point(403, 149);
            this.lblPesoRestante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesoRestante.Name = "lblPesoRestante";
            this.lblPesoRestante.Size = new System.Drawing.Size(72, 13);
            this.lblPesoRestante.TabIndex = 18;
            this.lblPesoRestante.Text = "Peso restante";
            // 
            // lblPesoCargado
            // 
            this.lblPesoCargado.AutoSize = true;
            this.lblPesoCargado.Location = new System.Drawing.Point(403, 124);
            this.lblPesoCargado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesoCargado.Name = "lblPesoCargado";
            this.lblPesoCargado.Size = new System.Drawing.Size(74, 13);
            this.lblPesoCargado.TabIndex = 19;
            this.lblPesoCargado.Text = "Peso Cargado";
            // 
            // txtPesoCargado
            // 
            this.txtPesoCargado.Location = new System.Drawing.Point(479, 124);
            this.txtPesoCargado.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesoCargado.Name = "txtPesoCargado";
            this.txtPesoCargado.Size = new System.Drawing.Size(65, 20);
            this.txtPesoCargado.TabIndex = 20;
            // 
            // txtPesoRestante
            // 
            this.txtPesoRestante.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPesoRestante.Location = new System.Drawing.Point(479, 149);
            this.txtPesoRestante.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesoRestante.Name = "txtPesoRestante";
            this.txtPesoRestante.Size = new System.Drawing.Size(65, 20);
            this.txtPesoRestante.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Kg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Kg";
            // 
            // btnCargaCamion
            // 
            this.btnCargaCamion.Location = new System.Drawing.Point(385, 321);
            this.btnCargaCamion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargaCamion.Name = "btnCargaCamion";
            this.btnCargaCamion.Size = new System.Drawing.Size(89, 23);
            this.btnCargaCamion.TabIndex = 25;
            this.btnCargaCamion.Text = "Registrar carga";
            this.btnCargaCamion.UseVisualStyleBackColor = true;
            this.btnCargaCamion.Click += new System.EventHandler(this.btnCargaCamion_Click);
            // 
            // FormCargarCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 355);
            this.Controls.Add(this.btnCargaCamion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesoRestante);
            this.Controls.Add(this.txtPesoCargado);
            this.Controls.Add(this.lblPesoCargado);
            this.Controls.Add(this.lblPesoRestante);
            this.Controls.Add(this.btnCambiarCamion);
            this.Controls.Add(this.cbCamiones);
            this.Controls.Add(this.gbCarga);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSeleccionarCamion);
            this.Controls.Add(this.txtPesoMax);
            this.Controls.Add(this.lblPesoMax);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.dgvCamion);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(594, 394);
            this.MinimumSize = new System.Drawing.Size(594, 394);
            this.Name = "FormCargarCamion";
            this.Text = "Camiones";
            this.Load += new System.EventHandler(this.FormCamion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamion)).EndInit();
            this.gbCarga.ResumeLayout(false);
            this.gbCarga.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCamion;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblPesoMax;
        private System.Windows.Forms.TextBox txtPesoMax;
        private System.Windows.Forms.Button btnSeleccionarCamion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button AgregarCarga;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoCarga;
        private System.Windows.Forms.GroupBox gbCarga;
        private System.Windows.Forms.ComboBox cbCamiones;
        private System.Windows.Forms.Button btnCambiarCamion;
        private System.Windows.Forms.Label lblPesoRestante;
        private System.Windows.Forms.Label lblPesoCargado;
        private System.Windows.Forms.TextBox txtPesoCargado;
        private System.Windows.Forms.TextBox txtPesoRestante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCargaCamion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTipoCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPeso;
        private System.Windows.Forms.DataGridViewButtonColumn btQuitar;
    }
}