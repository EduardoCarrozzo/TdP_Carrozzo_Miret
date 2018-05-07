using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ImagenDTO
    {
        private int iIdImagen;
        private string iNombre;
        private byte iHash;

        public int IdImagen
        {
            get { return this.iIdImagen; }
            set { this.iIdImagen = value; }
        }

        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        public byte Hash
        {
            get { return this.iHash; }
            set { this.iHash = value; }
        }
    }
}
