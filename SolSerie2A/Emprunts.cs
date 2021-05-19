using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTION_OUVRAGES
{
    class Emprunts
    {
        Hashtable table;
        public System.Collections.Hashtable Table
        {
            get { return table; }
            set { table = value; }
        }
        public Emprunts()
        {
            table = new Hashtable();
        }

        public void AddEmprunt(int codeEmprunteur, ListeOuvrages listeOuvrages)
        {

            foreach(int x in table.Keys)
            {   
                if(x==codeEmprunteur)
                {
                    
                    foreach (Ouvrage ouv in listeOuvrages.Liste)
                    {
                        ((ListeOuvrages)table[x]).AddOuvrage(ouv);
                    }
                    
                }
            }

            table.Add(codeEmprunteur, listeOuvrages);
            
        }
        public ListeOuvrages Recherche(int codeEmprunteur)
        {
            return table[codeEmprunteur] as ListeOuvrages;
        }

        public bool DelEmpruntAll(int codeEmprunteur)
        {
            if (table.ContainsKey(codeEmprunteur))
            {
                table.Remove(codeEmprunteur);
                return true;
            }
            return false;
        }
        public bool DelEmprunt(int codeEmprunteur, int codeOuvrage)
        {
            if (table.ContainsKey(codeEmprunteur))
            {
                ((ListeOuvrages)table[codeEmprunteur]).DelOuvrage(codeOuvrage);
                return true;
            }
            return false;
        }


        public bool existEmprunteur(int code)
         {
             foreach (int x in table.Keys)
             {
                 if(x==code)
                 {
                     return true;
                 }
             }
                return false;
         }
    }
}
