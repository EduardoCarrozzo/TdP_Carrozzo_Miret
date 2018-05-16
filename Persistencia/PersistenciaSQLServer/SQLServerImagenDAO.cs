using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Drawing;


namespace Persistencia.PersistenciaSQLServer
{
    class SQLServerImagenDAO : IImagenDAO
    {
        SqlConnection iConexion;
        SqlTransaction iTransaccion = null;
        SQLServerImagenDAO (SqlConnection pConexion, SqlTransaction pTransaccion)
        {
            this.iConexion = pConexion;
            this.iTransaccion = pTransaccion;
        }

        //bool Agregar(string nombre, PictureBox pb)// hay que mandar un ImagenDTO como parametro, el pasaje se hace en la vista
        //{
            
        //    SqlCommand cmd = new SqlCommand("insert into imagen values (@nombre, @imagen)", con);
        //    cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar);
        //    cmd.Parameters.Add("@imagen", SqlDbType.Image);
        //    cmd.Parameters["@Nombre"].Value = nombre;

        //                                    ..---         ESTO LO HAGO EN LA VISTA!!!
        //    MemoryStream ms = new MemoryStream();
        //    pb.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);  
        //    cmd.Parameters["@imagen"].Value = ms.GetBuffer();




        //    int resultado = cmd.ExecuteNonQuery();
        //    con.Close();
        //    if (resultado > 0) return true;
        //    else return false;
        //}

        public void Agregar(ImagenDTO pImagen)
        {
           try
            {
                SqlCommand comando = this.iConexion.CreateCommand();        //creamos un nuevo comando en la conexion a la BD
                comando.CommandText = @"insert into imagen values (@nombre, @imagen)";       //creamos la sentencia SQL
                comando.Parameters.Add("@Hash", SqlDbType.Image);        //agregamos el parametro del tipo compatible con SQL Image
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar);      //agregamos el parametro del tipo compatible con SQL NVarChar
                comando.Parameters["@Nombre"].Value = pImagen.Nombre;       //agregamos el valor del objeto al parametro
                comando.Parameters["@Hash"].Value = pImagen.Hash;       //agregamos el valor del objeto al parametro
                comando.Transaction = this.iTransaccion;       // agregamos la transaccion
                comando.ExecuteNonQuery();      //ejecutamos la sentencia

            }
            catch (SqlException)
            {
                throw new DAOException("No se pudo agregar la imagen a la base de datos"); //Tomamos la excepcion y devolvemos el texto
            }
               
        }

        public void Modificar(ImagenDTO pImagen)
        {
            try
            {
                SqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = @"update imagen set nombre=@nombre, imagen=@imagen where id=" + pImagen.IdImagen; //sentencia de actualizacion
                comando.Parameters.Add("@Hash", SqlDbType.Image);        //agregamos el parametro del tipo compatible con SQL Image
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar);      //agregamos el parametro del tipo compatible con SQL NVarChar
                comando.Parameters["@Nombre"].Value = pImagen.Nombre;       //agregamos el valor del objeto al parametro
                comando.Parameters["@Hash"].Value = pImagen.Hash;       //agregamos el valor del objeto al parametro
                comando.Transaction = this.iTransaccion;       // agregamos la transaccion
                comando.ExecuteNonQuery();      //ejecutamos la sentencia
            }
            catch (SqlException)
            {
                throw new DAOException("No se pudo actualizar la imagen");
            }
        }

        public ImagenDTO Buscar(int pIdImagen)
        {

            ImagenDTO imagen = new ImagenDTO();
            return imagen;
        }

        public void ListarTodas()
        {

        }
    }
}
