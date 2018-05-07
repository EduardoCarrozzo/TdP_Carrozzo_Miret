using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RSSDTO : IFuenteDTO
    {
        private string iUrl;
        private string iDescripcion;
        private string iValor;
        private int iCodigo;

        public RSSDTO()
        {

        }

        public string Url
        {
            get { return this.iUrl; }
            set { this.iUrl = value; }
        }

        public string Descripcion
        {
            get { return this.iDescripcion; }
            set { this.iDescripcion = value; }
        }

        public string Valor
        {
            get { return this.iValor; }
            set { this.iValor = value; }
        }

        public int Codigo
        {
            get { return this.iCodigo; }
            set { this.iCodigo = value; }
        }


        public string Texto()
        {
            return this.iValor;
        }

        public bool Actualizable()
        {
            return true;
        }

        public void Actualizar()
        {

        }

        public bool Equals(IFuenteDTO other)
        {
            return (other.GetType() == this.GetType()) && (this.Codigo == other.Codigo);
        }
    }
}
