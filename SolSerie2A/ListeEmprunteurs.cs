using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_OUVRAGES
{

    class ListeEmprunteurs
    {
       
        ArrayList liste;
        
        public System.Collections.ArrayList Liste
        {
            get { return liste; }
            set { liste = value; }
        }

        public ListeEmprunteurs()
        {
            liste = new ArrayList();
        }
        public void AddEmprunteur(Emprunteur e)
        {
            if(liste.Contains(e)==false)
                liste.Add(e);
        }
        public Emprunteur Recherche(int code)
        {
            foreach (var x in liste)
            {
                Emprunteur e = x as Emprunteur;
                if (e.Code == code)
                    return e;
            }
            return null;
        }
        public Emprunteur Recherche(String nom, String prenom)
        {
            foreach (var x in liste)
            {
                Emprunteur e = x as Emprunteur;
                if (e.Nom == nom && e.Prenom==prenom)
                    return e;
            }
            return null;
        }
        public bool DelEmprunteur(int code)
        {
            foreach (var x in Liste)
            {
                Emprunteur e = x as Emprunteur;
                if (e.Code == code)
                {
                    liste.Remove(e);
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            string s = "";
            foreach (Emprunteur x in Liste)
            {
                s+=x+"\n";
            }
            return s;       
        }
        public Emprunteur this[int code]
        {
            get
            {
                return Recherche(code);
            }
        }
        public bool ModifyEmprunteur(int code, String newNom, string newPrenom)
        {
            foreach(Emprunteur x in liste)
            {
                if(x.Code==code)
                {
                    x.Nom = newNom;
                    x.Prenom = newPrenom;
                    return true;
                }
            }
            return false;
        }
    }
}
