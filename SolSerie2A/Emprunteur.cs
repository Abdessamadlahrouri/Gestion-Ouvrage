using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_OUVRAGES
{
    class Emprunteur
    {
        static int CODE = 0;
        int code;
        public int Code
        {
            get { return code; }
        }
        string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        string prenom;
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public Emprunteur()
        {
            CODE++;
            code = CODE;
            
        }
        public Emprunteur(string nom, string prenom)
        {
            CODE++;
            code = CODE;
            this.nom = nom;
            this.Prenom = prenom;
        }
        public override string ToString()
        {
            return Code+" "+Nom+ " "+Prenom;
        }
    }
}
