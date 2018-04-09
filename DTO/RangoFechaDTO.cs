using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class RangoFechaDTO
    {
        private int iIdRangoFecha;
        private DateTime iFechaInicio;
        private DateTime iFechaFin;
        private int iFKCampania;
        private List<RangoHorarioDTO> iRangoHorario;

        public RangoFechaDTO(int pIdRangoFecha, DateTime pFechaInicio, DateTime pFechaFin,int pFKCampania ,List<RangoHorarioDTO> pRangoHorario)
        {
            this.iIdRangoFecha = pIdRangoFecha;
            this.iFechaInicio = pFechaInicio;
            this.iFechaFin = pFechaFin;
            this.iFKCampania = pFKCampania;
            this.iRangoHorario = pRangoHorario;
        }

        public int IdRangoFecha
        {
            get {return this.iIdRangoFecha; }
            set {this.iIdRangoFecha = value; }
        }

        public int FKCampania
        {
            get { return this.iFKCampania; }
            set { this.iFKCampania = value; }
        }

        public DateTime FechaInicio
        {
            get { return this.iFechaInicio; }
            set { this.iFechaInicio = value; }
        }

        public DateTime FechaFin
        {
            get { return this.iFechaFin; }
            set { this.iFechaFin = value; }
        }

        public List<RangoHorarioDTO> RangoHorario
        {
            get {return this.iRangoHorario; }
            set {this.iRangoHorario = value; } 
        }        
    }
}
