using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TextoFijoDTO : FuenteDTO
    {
        private string iValor;
        private int iCodigo;

        public TextoFijoDTO()
        {

        }

        override public string Valor
        {
            get { return this.iValor; }
            set { this.iValor = value; }
        }

        public string Texto()
        {
            return this.iValor;
        }


        public bool Actualizable()
        {
            return false;
        }

        public void Actualizar()
        {

        }

        public bool Equals(FuenteDTO other)
        {
            return (other.GetType() == this.GetType()) && (this.Codigo == other.Codigo);
        }
    }
}
