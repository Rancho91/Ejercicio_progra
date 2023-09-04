using ejercicio_1_6.Conection;
using ejercicio_1_6.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ejercicio_1_6.Precentacion
{
    public partial class FormCargarCamion : Form
    {
        Services services;
        Camion oCamion;
        
        public FormCargarCamion()
        {
            InitializeComponent();
            services = new Services();
            this.CargarComboTipoDatos();
            this.CargarComboCamion();
            btnCambiarCamion.Enabled = false;
            txtPesoCargado.Enabled = false;
            txtPesoRestante.Enabled = false;
            gbCarga.Enabled = false;
            dgvCamion.Enabled = false;
            btnCargaCamion.Enabled = false;

        } 

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTipoCarga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCamion_Load(object sender, EventArgs e)
        {

        }

        private void AgregarCarga_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtPeso.Text) || cbTipoCarga.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos de carga deben llenarse", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!double.TryParse(txtPeso.Text, out double peso))
            {
                MessageBox.Show("El peso tiene que ser un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            };
            Cargas oCarga = new Cargas();
            TiposCargas oTipoCarga = new TiposCargas();
            oCarga.Peso = double.Parse(txtPeso.Text);
            oTipoCarga.Codigo = Convert.ToInt32(cbTipoCarga.SelectedValue);
            oTipoCarga.Nombre = cbTipoCarga.Text;
            oCarga.Tipo = oTipoCarga;
            oCarga.Descripcion = txtDescripcion.Text;
            agregarCargaGrid(oCarga);
            calcularPeso();
            txtDescripcion.Text = "";
            txtPeso.Text = "";
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSeleccionarCamion_Click(object sender, EventArgs e)
        {
            oCamion = new Camion();
            string patente = cbCamiones.SelectedValue.ToString();
            DataTable dt =  services.BuscarCamion(patente);
            List<Param> listParam = new List<Param>();
            listParam.Add(new Param("@patente", patente));
            DataTable cargasCamion = services.ParamTable("SP_BUSCAR_CARGAS_DEL_CAMION", listParam);
            DataRow camion = dt.Rows[0];

                oCamion.Patente = camion["patente"].ToString();
                oCamion.PesoMax = Convert.ToInt32(camion["cargaMax"].ToString());
                oCamion.Listo = Convert.ToBoolean(camion["Estado"].ToString());
                foreach (DataRow row in cargasCamion.Rows)
                {
                    Cargas carga = new Cargas();
                    carga.id = Convert.ToInt32(row["id_carga"]);
                    carga.Descripcion = row["descripcion"].ToString();
                    carga.Peso = Convert.ToDouble(row["peso"].ToString());
                    TiposCargas tc = new TiposCargas();
                    tc.Codigo = Convert.ToInt32(row["id_tipo_carga"].ToString());
                    tc.Nombre = row["nombre"].ToString();
                    carga.Tipo = tc;
                    agregarCargaGrid(carga);
                }


                txtPesoMax.Text = oCamion.PesoMax.ToString();
                calcularPeso();
                SelectDeshabilited();
            
            
        }

        private void btnCambiarCamion_Click(object sender, EventArgs e)
        {
            SelectDeshabilited();
            txtPesoMax.Text = "";
            txtPesoCargado.Text = "";
            txtPesoRestante.Text = "";
            dgvCamion.Rows.Clear();
            }

        //Funciones
        #region


        private void CargarComboTipoDatos()
        {
            DataTable dt = services.SelectComboBoxTable("SP_ListTipoCargas");
            cbTipoCarga.DataSource = dt;
            cbTipoCarga.ValueMember = dt.Columns[0].ToString();
            cbTipoCarga.DisplayMember = dt.Columns[1].ToString();


        }

        private void CargarComboCamion()
        {
            DataTable dt = services.SelectComboBoxTable("SP_SELECT_CAMIONES");
            cbCamiones.DataSource = dt;
            cbCamiones.ValueMember = dt.Columns[0].ToString();
            cbCamiones.DisplayMember = dt.Columns[0].ToString();

        }

        private void SelectDeshabilited()
        {
            btnSeleccionarCamion.Enabled = !btnSeleccionarCamion.Enabled;
            cbCamiones.Enabled = !cbCamiones.Enabled;
            btnCambiarCamion.Enabled = !btnCambiarCamion.Enabled;
            gbCarga.Enabled = !gbCarga.Enabled;
            dgvCamion.Enabled= !dgvCamion.Enabled;
            btnCargaCamion.Enabled = !btnCargaCamion.Enabled;

        }

        private void agregarCargaGrid(Cargas carga)
        {
             oCamion.AddCargas(carga);

            if (carga.id != 0)
            {
                dgvCamion.Rows.Add(carga.id,carga.Descripcion, carga.Tipo.Nombre, carga.Peso, "");

            } else
            if (carga.id==0)
            {
                dgvCamion.Rows.Add(carga.id,carga.Descripcion, carga.Tipo.Nombre, carga.Peso, "Quitar");

            }

            calcularPeso();
        }


        #endregion
        private double calcularPeso()
        {           

            double pesoCargado = oCamion.CargaActual();
            double pesoRestante = oCamion.PesoMax - pesoCargado;

            txtPesoRestante.Text = pesoRestante.ToString();
            txtPesoCargado.Text = pesoCargado.ToString();
            return pesoCargado;
        }

        private void dgvCamion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCamion.Columns[e.ColumnIndex].Name == "btQuitar")
            {
                if (Convert.ToInt32(dgvCamion.Rows[e.RowIndex].Cells[0].Value) != 0 || dgvCamion.Rows[e.RowIndex].Cells[0].Value==null)
                {
                    MessageBox.Show("la carga ya esta registrada dentro del camion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                dgvCamion.Rows.RemoveAt(e.RowIndex);
                oCamion.RemoveCargas(e.RowIndex);
                 }
            this.calcularPeso();
        }

        private void btnCargaCamion_Click(object sender, EventArgs e)
        {
            services.RegistrarCargaCamion(oCamion);
            MessageBox.Show("Camion Registrado", "Cargado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

