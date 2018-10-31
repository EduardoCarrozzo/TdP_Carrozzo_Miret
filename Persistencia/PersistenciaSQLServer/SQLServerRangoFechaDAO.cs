using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia.PersistenciaSQLServer
{
	class SQLServerRangoFechaDAO : IRangoFechaDAO
    {
        private SqlConnection iConexion;
        private SqlTransaction iTransaccion = null;

        public SQLServerRangoFechaDAO(SqlConnection pConexion, SqlTransaction pTransaccion)
        {
            this.iConexion = pConexion;
            this.iTransaccion = pTransaccion;
        }

        void Agregar(RangoFechaDTO pRangoFecha)
        {

        }

        void Eliminar(int pIdRangoFecha)
        {

        }

        RangoFechaDTO Buscar(int pIdRangoFecha)
        {

        }

        List<RangoFechaDTO> Buscar(List<int> pListaIdRangos)
        {

        }

    }
}
