using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace Persistencia.PersistenciaSQLServer
{
    class SQLServerCampaniaDAO : ICampaniaDAO
    {
        private SqlCommand iTransaccion = null;
        private SqlConnection iConexion;

        public SQLServerCampaniaDAO (SqlConnection pConexion, SqlCommand pTransaccion)
        {
            this.iTransaccion = pTransaccion;
            this.iConexion = pConexion;
        }

        public void Insertar(CampaniaDTO pCampania)
        {
            try
            {
            //    string pNombre = pCampania.Nombre;
            //  int pEstado = 1;
            //    string cmd = "insert into Campania (nombre, estado) values ";
            //    SqlCommand comando = new SqlCommand();
            }
            catch
            {

            }
        }

        public CampaniaDTO Buscar(int pIdCampania) {}

        public void Modificar(int pIdCampania, CampaniaDTO pCampania) {}

        public void Eliminar(int pIdCampania) {}
        
    }
}
