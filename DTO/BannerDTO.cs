using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BannerDTO
    {
        private int iIdBanner;
        private string iNombre;
        private bool iEstado;
        private FuenteDTO iFuente;
        private List<RangoFechaDTO> iRangoFecha;

        public BannerDTO(int pIdBanner, string pNombre, List<RangoFechaDTO> pRangoFecha,FuenteDTO pFuente , bool pEstado)
        {
            this.iIdBanner = pIdBanner;
            this.iNombre = pNombre;
            this.iRangoFecha = pRangoFecha;
            this.iFuente = pFuente;
            this.iEstado = pEstado;

        }

        public int IdBanner
        {
            get { return this.iIdBanner; }
            set { this.iIdBanner = value; }
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

        public FuenteDTO Fuente
        {
            get { return this.iFuente; }
            set { this.iFuente = value; }
        }
        public List<RangoFechaDTO> RangoFecha
        {
            get { return this.iRangoFecha; }
            set { this.iRangoFecha = value; }
        }


    }
}
