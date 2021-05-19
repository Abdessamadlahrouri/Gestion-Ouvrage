using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace GESTION_OUVRAGES
{
    public partial class MenuForm : Form
    {
       
        internal static ListeEmprunteurs listEmprunteur = new ListeEmprunteurs();
        internal static Ouvrage ouvrage = new Ouvrage();
        internal static GestionEmprunts gestionEmprunts = new GestionEmprunts();
        internal static ListeOuvrages listOuvrages = new ListeOuvrages();
        internal static ListeOuvrages tempListOuvrages = new ListeOuvrages();
        public MenuForm()
        {
            InitializeComponent();
            this.FormClosing += MenuForm_FormClosing;
        }

        void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
                
        }

        private void ajouterEmprToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void listEmprunteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListEmprunteurForm listform = new ListEmprunteurForm();
            listform.ShowDialog();
        }

        private void supprimerEmprunteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerEmprunteurForm suppForm = new SupprimerEmprunteurForm();
            suppForm.ShowDialog();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyEmrunteurForm modify = new ModifyEmrunteurForm();
            modify.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chercherEmprunteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RechercherEmprunteurForm r = new RechercherEmprunteurForm();
            r.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ajouterEmprunteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterEmprunteur ajouterEm = new AjouterEmprunteur();
            ajouterEm.ShowDialog();
        }

        private void listEmprunteurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListEmprunteurForm listform = new ListEmprunteurForm();
            listform.ShowDialog();
        }

        private void supprimerEmprunteurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SupprimerEmprunteurForm suppForm = new SupprimerEmprunteurForm();
            suppForm.ShowDialog();
        }

        private void modifierEmprunteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyEmrunteurForm modify = new ModifyEmrunteurForm();
            modify.ShowDialog();
        }

        private void chercherEmrpunteyrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RechercherEmprunteurForm r = new RechercherEmprunteurForm();
            r.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ajouterOuvrageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterAuteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterAuteurForm addAut = new AjouterAuteurForm();
            addAut.ShowDialog();
        }

        private void listAuteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListAuteur listAut = new ListAuteur();
            listAut.ShowDialog();
        }

        private void modifierAuteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierAuteurForm modifierAuteur = new ModifierAuteurForm();
            modifierAuteur.ShowDialog();
        }

        private void ajouterOuvrageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AjouterOuvrageForm aof = new AjouterOuvrageForm();
            aof.ShowDialog();
        }

        private void listOuvrageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOuvrageForm lf = new ListOuvrageForm();
            lf.ShowDialog();
        }

        private void supprimerOuvrageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerOuvrageForm sof = new SupprimerOuvrageForm();
            sof.ShowDialog();
        }

        private void modifierOuvrageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierOuvrageForm modifyFormOuvarge = new ModifierOuvrageForm();
            modifyFormOuvarge.ShowDialog();
        }

        private void empruntsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterEmprunt addemprunt = new AjouterEmprunt();
            addemprunt.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listEmpruntsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListEmpruntsForm listEmpruntsForm = new ListEmpruntsForm();
            listEmpruntsForm.ShowDialog();
        }

        private void recupererOuvrageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        

        }

        private void sauvegarderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*StreamWriter f3 = new StreamWriter("ListEmprunts.txt");

           
            foreach (int x in MenuForm.gestionEmprunts.Emprunts.Table.Keys)
            {
                Emprunteur emp = MenuForm.gestionEmprunts.Emprunteurs.Recherche(x);
                ListeOuvrages ouv = MenuForm.gestionEmprunts.Emprunts.Recherche(x);
                string s2 = "";
                foreach (Ouvrage o in ouv.Liste)
                {

                    s2 = s2 + o.Titre + ",";

                }

                f3.WriteLine(emp.Nom + " " + emp.Prenom, s2);
                s2 = "";
            }

            listOuvrages.Liste = tempListOuvrages.Liste;
            f3.Close();*/
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MenuForm.listOuvrages.Liste = MenuForm.tempListOuvrages.Liste;
        }

        private void quitterToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void emprunteurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
