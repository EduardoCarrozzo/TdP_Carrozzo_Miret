using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Persistencia
{
    interface IImagenDAO
    {
        void Agregar(ImagenDTO pIdImagen);
        ImagenDTO Buscar(int pImagen);
        void Modificar(ImagenDTO pImagen);
        void Eliminar(int pIdImagen);
    }
}
