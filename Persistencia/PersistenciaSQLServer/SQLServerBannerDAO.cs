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
    class SQLServerBannerDAO : IBannerDAO
    {
        private SqlConnection iConexion;
        private SqlTransaction iTransaccion = null;

        public SQLServerBannerDAO(SqlConnection pConexion, SqlTransaction pTransaccion)
        {
            this.iConexion = pConexion;
            this.iTransaccion = pTransaccion;
        }


        //La PK se autoincrementa en la base de datos, no es necesario pasarla
        public void Agregar(BannerDTO pBanner)
        {
            try
            {
                SqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = "Insert into Banner(Nombre, Estado, Fuente) values(@pNombre, @pEstado, @pFuente)";
                comando.Parameters.AddWithValue("@pNombre", pBanner.Nombre);
                comando.Parameters.AddWithValue("@Estado", pBanner.Estado);
                comando.Parameters.AddWithValue("@Fuente", pBanner.Fuente);
                comando.Transaction = iTransaccion;
                comando.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw new DAOException("No se pudo insertar el Banner en la base de datos");
            }
        }

        //el banner que retorna tiene lista de fecha y fuente nulas
        public List<BannerDTO> Buscar(string pNombre)
        {
            try
            {
                SqlCommand comando = this.iConexion.CreateCommand();
                comando.Transaction = iTransaccion;
                comando.CommandText = "Select * from Banner where Nombre = '" + pNombre + "' and Estado = true";
                SqlDataReader registros = comando.ExecuteReader();
                List<BannerDTO> listaB = new List<BannerDTO>();
                BannerDTO banner = null;
                FuenteDTO fuente = null;
                List<RangoFechaDTO> rangoFecha = null;
                while (registros.Read())
                {
                    banner = new BannerDTO(Convert.ToInt32(registros["IdBanner"]), registros["Nombre"].ToString(), rangoFecha, fuente, Convert.ToBoolean(registros["Estado"]));
                    listaB.Add(banner);
                }
                return listaB;
            }
            catch (SqlException)
            {
                throw new DAOException("No se ha podido realizar la búsqueda");
            }
        }

        public BannerDTO Buscar(int pIdBanner)
        {
            try
            {
                SqlCommand comando = this.iConexion.CreateCommand();
                comando.Transaction = iTransaccion;
                comando.CommandText = "Select * from Banner where Id =" + pIdBanner + "and Estado = true";
                BannerDTO banner = comando.ExecuteNonQuery();
                FuenteDTO fuente = null;
                List<RangoFechaDTO> rangoFecha = null;
            }
            catch (SqlException)
            {
                throw new DAOException("No se ha podido realizar la búsqueda");
            }
        }

        public void Modificar(BannerDTO pBanner)
        {
            try
            {
                SqlCommand comando = this.iConexion.CreateCommand();
                comando.Transaction = iTransaccion;
                comando.CommandText = "Update Banner set Nombre = '"+pBanner.Nombre+"' where IdBanner ="+pBanner.IdBanner;
                comando.ExecuteNonQuery();
            }
            catch(SqlException)
            {
                throw new DAOException("No se pudo realizar la modificación");
            }
        }
          
        public void Eliminar(int pIdBanner)
        {
            try
            {
                SqlCommand comando = this.iConexion.CreateCommand();
                comando.Transaction = iTransaccion;
                comando.CommandText = "Update Banner set Estado = 'false' where IdBanner = "+pIdBanner;
                comando.ExecuteNonQuery();
            }
            catch(SqlException)
            {
                throw new DAOException("No se ha podido eliminar el Banner");
            }

        }
         
    }
}
