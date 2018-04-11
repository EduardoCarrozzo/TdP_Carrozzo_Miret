using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RangoHorarioDTO
    {
        private int iIdRangoHorario;
        private TimeSpan iHoraInicio;
        private TimeSpan iHoraFin;
        private int iFKRangoFecha;

        public RangoHorarioDTO(int pIdRangoHorario, TimeSpan pHoraInicio, TimeSpan pHoraFin, int pFKRangoFecha)
        {
            this.iIdRangoHorario = pIdRangoHorario;
            this.iHoraInicio = pHoraInicio;
            this.iHoraFin = pHoraFin;
            this.iFKRangoFecha = pFKRangoFecha;
        }

        public int IdRangoHorario
        {
            get { return this.iIdRangoHorario; }
            set { this.iIdRangoHorario = value; }
        }

        public TimeSpan HoraInicio
        {
            get { return this.iHoraInicio; }
            set { this.iHoraInicio = value; }
        }
        public TimeSpan HoraFin
        {
            get { return this.iHoraFin; }
            set { this.iHoraFin = value; }
        }
        public int FKRangoFecha
        {
            get { return this.iFKRangoFecha; }
            set { this.iFKRangoFecha = value; }
        }
        
    }
}
