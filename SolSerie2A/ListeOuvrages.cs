using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_OUVRAGES
{
    class ListeOuvrages
    {
        ArrayList liste;
        public System.Collections.ArrayList Liste
        {
            get { return liste; }
            set { liste = value; }
        }
        public ListeOuvrages()
        {
            liste = new ArrayList();
        }
        public void AddOuvrage(Ouvrage e)
        {
            if(liste.Contains(e)==false)
                liste.Add(e);
        }
        public Ouvrage Recherche(int code)
        {
            foreach (var x in liste)
            {
                Ouvrage e = x as Ouvrage;
                if (e.Code == code)
                    return e;
            }
            return null;
        }
        public Ouvrage Recherche(String titre)
        {
            foreach (var x in liste)
            {
                Ouvrage e = x as Ouvrage;
                if (e.Titre==titre)
                    return e;
            }
            return null;
        }
        public bool DelOuvrage(Ouvrage e)
        {
            if (liste.Contains(e) == true)
            {
                liste.Remove(e);
                return true;
            }
            return false;
        }
        public bool DelOuvrage(int codeOuvrage)
        {
            foreach (Ouvrage x in liste)
            {
                if (x.Code == codeOuvrage)
                {
                    liste.Remove(x);
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            string s = "";
            foreach (Ouvrage x in Liste)
            {
                s+=x+"\n";
            }
            return s;       
        }
        public Ouvrage this[int code]
        {
            get
            {
                return Recherche(code);
            }
        }
        public bool ModifyOuvrage(int code, String titre, DateTime edition)
        {
            foreach (Ouvrage x in liste)
            {
                if (x.Code == code)
                {
                    x.Titre = titre;
                    x.Edition = edition;
                    return true;
                }
            }
            return false;
        }
        public bool ModifyOuvrage(int code, String titre, DateTime edition,ArrayList auteurs)
        {
            foreach (Ouvrage x in liste)
            {
                if (x.Code == code)
                {
                    x.Titre = titre;
                    x.Edition = edition;
                    x.Auteurs = auteurs;
                    return true;
                }
            }
            return false;
        }

    }
}
