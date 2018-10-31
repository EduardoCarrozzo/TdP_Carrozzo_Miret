using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace Persistencia.PersistenciaSQLServer
{
    class SQLServerFuenteDAO : IFuenteDAO
    {
        private SqlConnection iConexion;
        private SqlTransaction iTransaccion = null;

        public SQLServerFuenteDAO(SqlConnection pConexion, SqlTransaction pTransaccion)
        {
            this.iConexion = pConexion;
            this.iTransaccion = pTransaccion;
        }

        public void Agregar(FuenteDTO pFuente) {}
          
        public FuenteDTO Buscar(int pIdFuente) {}
          
        public void Modificar(FuenteDTO pFuente) {}
          
        public void Eliminar(int pIdFuente) {}
        
    }
}
