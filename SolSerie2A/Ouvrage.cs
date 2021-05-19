using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_OUVRAGES
{
    class Ouvrage
    {
        static int CODE = 1;
        int code;
        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        string titre;
        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }
        DateTime edition;
        public System.DateTime Edition
        {
            get { return edition; }
            set { edition = value; }
        }
        ArrayList auteurs;
        public System.Collections.ArrayList Auteurs
        {
            get { return auteurs; }
            set { auteurs = value; }
        }
        public Ouvrage()
        {
            code = CODE;
            CODE++;
            auteurs = new ArrayList();
        }
        public Ouvrage(String titre, DateTime edition,params String[] t)
        {
            code = CODE;
            CODE++;
            Titre = titre;
            Edition = edition;
            auteurs = new ArrayList();
            foreach (var x in t)
                auteurs.Add(x);
        }
        public override string ToString()
        {
            String s = code + " " + titre + " " + edition.ToShortDateString();
            foreach(var x in auteurs)
                s += "\t" + x;
            return s;
        }
        public void AddAuteur(string auteur)
        {
            auteurs.Add(auteur);
        }
        public bool Exist(string auteur)
        {
           return auteurs.Contains(auteur);
        }
        public bool DelAuteur(string auteur)
        {
            if (Exist(auteur))
            {
                auteurs.Remove(auteur);
                return true;
            }
            return false;
        }
        public bool ModifyAuteur(string auteur1, string auteur2)
        {
            if (Exist(auteur1))
            {
                auteurs.Remove(auteur1);
                auteurs.Add(auteur2);
                return true;
            }
            return false;
        }

    }
}
