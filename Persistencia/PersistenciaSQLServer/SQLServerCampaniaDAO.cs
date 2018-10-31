using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Persistencia.PersistenciaSQLServer
{
    class SQLServerCampaniaDAO : ICampaniaDAO
    {
        private SqlTransaction iTransaccion = null;
        private SqlConnection iConexion;

        public SQLServerCampaniaDAO (SqlConnection pConexion, SqlTransaction pTransaccion)
        {
            this.iTransaccion = pTransaccion;
            this.iConexion = pConexion;
        }

        public void Agregar(CampaniaDTO pCampania)
        {
            try
            {
                SqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = @"Insert into Campania(Nombre, Estado) values (@pNombre, @pEstado)";
                comando.Parameters.AddWithValue("@Nombre", pCampania.Nombre);
                comando.Parameters.AddWithValue("@Estado", pCampania.Estado);
                comando.Transaction = this.iTransaccion;
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                //MessageBox.Show("No se ha podido agregar la campaña.")
            }
        }

        public CampaniaDTO Buscar(int pIdCampania)
        {
            try
            {

                SqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = @"Select * from Campania where IdCampania = '" + pIdCampania + "'";
                comando.Transaction = this.iTransaccion;
                CampaniaDTO campania = null;
                DataTable tabla = new DataTable();
                SqlDataAdapter operacion = new SqlDataAdapter(comando);
                operacion.Fill(tabla);
                foreach (DataRow fila in tabla.Rows)
                {
                    campania = new CampaniaDTO(Convert.ToInt32(fila["idcuenta"]), Convert.ToString(fila["nombre"]), Convert.ToString(fila["direccion"]), Convert.ToString(fila["servicio"]), Convert.ToString(fila["contrasenia"]), Convert.ToBoolean(fila["activo"]), Convert.ToInt32(fila["cantidadcorreos"]));
                }
                return campania;

            }
            catch (DAOException)
            {
                DAOException dao = new DAOException("Ha ocurrido un error. Contacte a su administrador.");
            }

            

        }

        public void Modificar(CampaniaDTO pCampania) {}

        public void Eliminar(int pIdCampania) {}
        
    }
}
