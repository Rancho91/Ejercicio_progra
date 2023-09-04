namespace ejercicio_1_6.Precentacion
{
    partial class FrmDetalleCamion
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
            this.dgvDetalleCarga = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalleCarga
            // 
            this.dgvDetalleCarga.AllowUserToAddRows = false;
            this.dgvDetalleCarga.AllowUserToDeleteRows = false;
            this.dgvDetalleCarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleCarga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.colDescripcion,
            this.colPeso,
            this.colTipoCarga});
            this.dgvDetalleCarga.Location = new System.Drawing.Point(12, 21);
            this.dgvDetalleCarga.Name = "dgvDetalleCarga";
            this.dgvDetalleCarga.ReadOnly = true;
            this.dgvDetalleCarga.Size = new System.Drawing.Size(366, 158);
            this.dgvDetalleCarga.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colPeso
            // 
            this.colPeso.HeaderText = "Peso";
            this.colPeso.Name = "colPeso";
            this.colPeso.ReadOnly = true;
            // 
            // colTipoCarga
            // 
            this.colTipoCarga.HeaderText = "Tipo de Carga";
            this.colTipoCarga.Name = "colTipoCarga";
            this.colTipoCarga.ReadOnly = true;
            // 
            // FrmDetalleCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDetalleCarga);
            this.Name = "FrmDetalleCamion";
            this.Text = "frmDetalleCamion";
            this.Load += new System.EventHandler(this.frmDetalleCamion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleCarga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalleCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoCarga;
    }
}