using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class CampaniaDTO
    {
        private int iIdCampania;
        private string iNombre;
        private bool iEstado;

        public CampaniaDTO(int pIdCampania, string pNombre, bool pEstado)
        {
            this.iIdCampania = pIdCampania;
            this.iNombre = pNombre;
            this.iEstado = pEstado;
        }

        public int IdCampania
        {
            get { return this.iIdCampania; }
            set { this.IdCampania = value}
        }

        public string Nombre
        {
            get { return this.iNombre; }
            set { this.iNombre = value; }
        }

        public bool Estado
        {
            get { return this.iEstado; }
            set { this.iEstado = value; }
        }
            
    }
}
