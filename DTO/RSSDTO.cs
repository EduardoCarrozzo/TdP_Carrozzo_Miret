using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RSSDTO : FuenteDTO
    {
        private string iUrl;
        private string iDescripcion;
        private string iValor;

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
            return true;
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
