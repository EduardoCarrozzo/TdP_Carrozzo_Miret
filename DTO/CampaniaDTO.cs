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
        private List<RangoFechaDTO> iRangoFecha;
        //private List<Image> iImagen;

        public CampaniaDTO(int pIdCampania, string pNombre, List<RangoFechaDTO> pRangoFecha, bool pEstado) //, imagen) 
        {
            this.iIdCampania = pIdCampania;
            this.iNombre = pNombre;
            this.iRangoFecha = pRangoFecha;
            //this.iImagen = pImagen;
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

        public List<RangoFechaDTO> RangoFecha
        {
            get { return this.iRangoFecha; }
            set { this.iRangoFecha = value; }
        }

        /* public Imagen
         * {
         *      
         * }

        */
        public bool Estado
        {
            get { return this.iEstado; }
            set { this.iEstado = value; }
        }
            
    }
}
