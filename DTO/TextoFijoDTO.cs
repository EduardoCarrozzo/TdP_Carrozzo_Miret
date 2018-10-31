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
        private int iIdTextoFijo;


        override public string Valor
        {
            get { return this.iValor; }
            set { this.iValor = value; }
        }

        public int IIdTextoFijo
        {
            get { return this.iIdTextoFijo; }
            set { this.iIdTextoFijo = value; }
        }


        public override bool Actualizable()
        {
            return false;
        }

        public bool Equals(FuenteDTO other)
        {
            return (other.GetType() == this.GetType()) && (this.iIdFuente == other.iIdFuente);
        }
    }
}
