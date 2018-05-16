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
        private bool iEstado;

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

        public bool Estado
        {
            get { return this.iEstado; }
            set { this.iEstado = value; }
        }

        public ImagenDTO(int pIdImagen, string pNombre, byte pHash, bool pEstado)
        {
            this.iIdImagen = pIdImagen;
            this.iNombre = pNombre;
            this.iHash = pHash;
            this.iEstado = pEstado;
        }
    }
}
