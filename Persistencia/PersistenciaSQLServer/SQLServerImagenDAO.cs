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
        bool Agregar(string nombre, PictureBox pb)
        {
            
            SqlCommand cmd = new SqlCommand("insert into imagen values (@nombre, @imagen)", con);
            cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar);
            cmd.Parameters.Add("@imagen", SqlDbType.Image);

            cmd.Parameters["@Nombre"].Value = nombre;
            MemoryStream ms = new MemoryStream();

            pb.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmd.Parameters["@imagen"].Value = ms.GetBuffer();

            int resultado = cmd.ExecuteNonQuery();
            con.Close();

            if (resultado > 0) return true;
            else return false;
        }
        ImagenDTO Buscar() { }
        void Modificar(BannerDTO pBanner) { }
        void Eliminar(int pIdBanner) { }
    }
}
