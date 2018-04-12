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
        public void Insertar(BannerDTO pBanner)
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
         
        public BannerDTO Buscar(int pIdBanner)
        {
            //try
            //{
            //    SqlCommand comando = this.iConexion.CreateCommand();
            //    comando.CommandText = "Select * from Banner where IdBanner ="+ pIdBanner;
            //    SqlDataReader registro = comando.ExecuteReader();
            //    String pNombre = registro["Nombre"].ToString();
            //    int pId = Convert.ToInt32(registro["IdBanner"]);
            //    BannerDTO banner = new BannerDTO();
            //    return banner;
            //}
            //catch(SqlException)
            //{
                                    
            //}
        }
          
        public void Modificar(BannerDTO pBanner)
        {
            try
            {
                SqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = "Update Banner set Nombre = '"+pBanner.Nombre+"' where IdBanner ="+pBanner.IdBanner;
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
                comando.CommandText = "Update Banner set Estado = 'false' where IdBanner = "+pIdBanner;
            }
            catch(SqlException)
            {
                throw new DAOException("No se ha podido eliminar el Banner");
            }

        }
         
    }
}
