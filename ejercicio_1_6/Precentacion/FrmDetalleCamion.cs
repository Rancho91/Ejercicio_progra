using ejercicio_1_6.Conection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_1_6.Precentacion
{
    public partial class FrmDetalleCamion : Form
    {
        public FrmDetalleCamion(string patente)
        {
            InitializeComponent();
            cargarGrid(patente);
        }

        private void frmDetalleCamion_Load(object sender, EventArgs e)
        {

        }

        private void cargarGrid(string patente)
        {
            Param param = new Param("@patente", patente);
            List<Param> list = new List<Param>();
            list.Add(param);
            Services service = new Services();
           DataTable dt= service.ParamTable("SP_CARGA_DETALLE_CAMION", list);
            foreach (DataRow dr in dt.Rows) {
                dgvDetalleCarga.Rows.Add(dr[0], dr[1].ToString(), dr[2], dr[3]);
            }


        }

    }
}
