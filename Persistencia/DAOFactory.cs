using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.PersistenciaSQLServer;
using DTO;

namespace Persistencia
{
    public abstract class DAOFactory
    {
        private static DAOFactory iInstanciaDAO = null;


        //Verifica si hay una instancia ya creada y en caso de que no lo esté
        //crea una nueva. Para que solo haya una
        public static DAOFactory Instancia()
        {
            if (iInstanciaDAO == null)
            {
                iInstanciaDAO = new SQLServerDAOFactory();
            }
            return iInstanciaDAO;
        }

        public abstract IBannerDAO BannerDAO();

        public abstract ICampaniaDAO CampaniaDAO();

        public abstract void IniciarConexion();

        public abstract void ComenzarTransaccion();

        public abstract void Commit();

        public abstract void RollBack();

        public abstract void FinalizarConexion();
    }

}
