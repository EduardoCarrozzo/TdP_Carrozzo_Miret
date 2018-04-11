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

        public SQLServerCampaniaDAO (SqlCommand pTransaccion, SqlConnection pConexion)
        {
            this.iTransaccion = pTransaccion;
            this.iConexion = pConexion;
        }

        public void Insertar(CampaniaDTO pCampania)
        {
            try
            {

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
