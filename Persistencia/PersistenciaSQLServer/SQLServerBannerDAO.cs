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

        public List<BannerDTO> Buscar(string pNombre)
        {
            try
            {
                SqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = "Select * from Banner where Nombre =" + pNombre + "and Estado = true";
                SqlDataReader registros = comando.ExecuteReader();
                List<BannerDTO> listaB = new List<BannerDTO>();
                BannerDTO banner = null;
                while (registros.Read())
                {
                    //Tengo los id de la fuente y Rango fecha. Tengo que buscarlos
                    //por id en las tablas para pasarlo en el banner
                    //registros["Fuente"] esto es el id (int) de la Fuente
                    banner = new BannerDTO(Convert.ToInt32(registros["IdBanner"]), registros["Nombre"].ToString(), registros["RangoFecha"], registros["Fuente"], Convert.ToBoolean(registros["Estado"]));
                    listaB.Add(banner)
                }


                String nombre = registro["Nombre"].ToString();
                int id = Convert.ToInt32(registro["IdBanner"]);
                //List<RangoFechaDTO> rFechas = 
                //BannerDTO banner = new BannerDTO(id, nombre, );
                //return banner;
            }
            catch (SqlException)
            {

            }
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
