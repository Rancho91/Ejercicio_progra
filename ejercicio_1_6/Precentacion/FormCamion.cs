using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejercicio_1_6.Conection;
using ejercicio_1_6.Entidades;

namespace ejercicio_1_6.Precentacion
{
    public partial class FrmCamiones : Form
    {
        Services services;
        public FrmCamiones()
        {
            InitializeComponent();


        }

        private void FormCargas_Load(object sender, EventArgs e)
        {
            services = new Services();

        }






        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatente.Text) || string.IsNullOrEmpty(txtPesoMax.Text))
            {
                MessageBox.Show("Todos los campos deben llenarse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string patente = txtPatente.Text;
            int pesoMax = Convert.ToInt32(txtPesoMax.Text);
            services.CreateCamion(patente, pesoMax);
            MessageBox.Show("Se creo el camion de forma correcta", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cbTipoCarga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPeso_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvListCamiones.Rows.Clear();
            List<Param> list = new List<Param>();
            if(!string.IsNullOrEmpty(txtPatenteBusqueda.Text))
                list.Add(new Param("@patente", txtPatenteBusqueda.Text));
            if(!string.IsNullOrEmpty(txtCargaMaxima.Text))
                 list.Add(new Param("@cargaMax", Convert.ToInt32(txtCargaMaxima.Text)));

            if (cbListo.Checked)
            {
                list.Add(new Param("@estado", 1));

            } else list.Add(new Param("@estado", 0));
            if (!string.IsNullOrEmpty(txtCargaMaxima.Text))
                list.Add(new Param("@porcentaje",Convert.ToDouble(txtPorcentaje.Text)));
            DataTable tb = services.ParamTable("SP_BUSCAR_CAMIONES", list);
            foreach(DataRow row in tb.Rows)
            {
                dgvListCamiones.Rows.Add(row["patente"].ToString(), row["cargaMax"].ToString(), row["Porcentaje Carga"].ToString()) ;
            }
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvListCamiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvListCamiones.Rows[e.RowIndex];
            string patente = row.Cells["colPatente"].Value.ToString();
            Form formDetalle = new FrmDetalleCamion(patente);
            formDetalle.ShowDialog();
        }
    }
}
