using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio_1_6.Conection;
using System.Data.SqlClient;
using System.Data;
using ejercicio_1_6.Entidades;
using System.Windows.Forms;

namespace ejercicio_1_6.Conection
{
    internal class Services
    {
        private SqlConnection conn;
        private SqlCommand cmd;

        public Services()
        {
            conn = new Conect().GetConnection();
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        public DataTable SelectComboBoxTable(string sp)
        {
            cmd.CommandText = sp;
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());
            conn.Close();
            return table;
        }
        public void CreateCamion(string patente, int pesoMax)
        {
            cmd.CommandText = "SP_CREAR_CAMION";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@patente", patente);
            cmd.Parameters.AddWithValue("@cargaMax", pesoMax);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public DataTable BuscarCamion(string patente)
        {
            cmd.CommandText = "SP_CAMION";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@patente", patente);
            conn.Open();
            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());
            conn.Close();
            return table;
        }

        public DataTable ParamTable(string sp, List<Param> list)
        {
            DataTable table = new DataTable();

            cmd.CommandText = sp;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            foreach(Param l in list){
                cmd.Parameters.AddWithValue(l.Parameter, l.Value);
            }
            
            conn.Open();
            table.Load(cmd.ExecuteReader());
            conn.Close();


            return table;
        
            
        }

        public void RegistrarCargaCamion(Camion camion)
        {
            conn.Open();

            SqlTransaction transaction = conn.BeginTransaction();

            try
            {
                foreach (Cargas c in camion.CargasCamion)
                {
                    if(c.id == 0)
                    {
                      RegistrarCarga(camion.Patente, c.Descripcion, c.Peso, c.Tipo.Codigo, transaction);

                    }
                }
                double MinimoCarga = camion.PesoMax * 0.75;
                if (camion.CargaActual() > MinimoCarga)
                {
                    CambiarEstadoCamion(camion.Patente, transaction);
                }
                transaction.Commit();
            }
            catch(Exception e)
            {
                MessageBox.Show("Hubo un error al cargar el camion" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                transaction.Rollback();
            }
            finally
            {
                conn.Close();
            }
            
        }


        private int RegistrarCarga(string patente, string descripcion, double peso, int tipoCarga, SqlTransaction transaction)
        {
            cmd.Transaction = transaction;
            cmd.CommandText = "SP_CREAR_CARGA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@descripcion", descripcion);
            cmd.Parameters.AddWithValue("@peso", peso);
            cmd.Parameters.AddWithValue("@id_tipo_carga", tipoCarga);
            cmd.Parameters.AddWithValue("@patente", patente);

            int id = Convert.ToInt32(cmd.ExecuteScalar().ToString());
      
            return id;
        }

        private void CambiarEstadoCamion(string patente, SqlTransaction transaction) {
            cmd.Transaction = transaction;
            cmd.CommandText = "SP_CAMBIAR_ESTADO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@patente", patente);
            cmd.ExecuteNonQuery();
        }

    }
}
