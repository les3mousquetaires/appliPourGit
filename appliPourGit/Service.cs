using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appliPourGit
{
    class Service
    {
        //attributs
        private int idService;
        private string libelleService;

        //retourne id du service
        public int GetIdService()
        {
            return this.idService;
        }

        public void SetIdService(int id)
        {
            this.idService = id;
        }


        //accesseur libelle du service
        public string GetLibelleService()
        {
            return this.libelleService;
        }

        public void SetLibelleService(string libelle)
        {
            this.libelleService = libelle;
        }
    }
}
