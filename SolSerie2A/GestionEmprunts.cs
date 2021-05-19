using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_OUVRAGES
{
    class GestionEmprunts
    {
        ListeEmprunteurs emprunteurs;
        public GESTION_OUVRAGES.ListeEmprunteurs Emprunteurs
        {
            get { return emprunteurs; }
            set { emprunteurs = value; }
        }
        Emprunts emprunts;
        public GESTION_OUVRAGES.Emprunts Emprunts
        {
            get { return emprunts; }
            set { emprunts = value; }
        }
        public GestionEmprunts()
        {
            emprunteurs = new ListeEmprunteurs();
            emprunts = new Emprunts();
        }
        public void Add(Emprunteur empr, ListeOuvrages ouvs)
        {
            emprunts.AddEmprunt(empr.Code, ouvs);
        }

        public void ReturnerOuvrage(int codeEmprunteur, int codeOuvrage)
        {
            emprunts.DelEmprunt(codeEmprunteur, codeOuvrage);
        }
        public ListeOuvrages Recherche(int codeEmprunteur)
        {
            if (emprunts.Recherche(codeEmprunteur) == null)
            {
                return null;
            }
            return emprunts.Recherche(codeEmprunteur);
        }


    }
}
