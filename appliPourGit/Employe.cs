using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appliPourGit
{
    class Employe
    {
        private string id;
        private string nom;
        private string prenom;
        private string adresseRue;
        private string cp;
        private string tel;

        //accesseurs ID
        public string GetId()
        {
            return this.id;
        }
        public void SetId(string value)
        {
            this.id = value;
        }
        
        //accesseurs NOM
        public string GetNom()
        {
            return this.nom;
        }
        public void SetNom(string value)
        {
            this.nom = value;
        }

        //accesseurs PRENOM
        public string GetPrenom()
        {
            return this.prenom;
        }
        public void SetPrenom(string value)
        {
            this.prenom = value;
        }

        //accesseurs ADRESSE RUE
        public string GetAdresse()
        {
            return this.adresseRue;
        }
        public void SetAdresse(string value)
        {
            this.adresseRue = value;
        }

        //accesseurs CP
        public string GetCp()
        {
            return this.cp;
        }
        public void SetCp(string value)
        {
            this.cp = value;
        }

        //accesseurs CP
        public string GetTel()
        {
            return this.tel;
        }
        public void SetTel(string value)
        {
            this.tel = value;
        }
    }
}
