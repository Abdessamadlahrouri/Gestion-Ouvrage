using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_OUVRAGES
{
    public partial class ListEmpruntsForm : Form
    {
        public ListEmpruntsForm()
        {
            InitializeComponent();
        }

        private void ListEmpruntsForm_Load(object sender, EventArgs e)
        {
            foreach (int x in MenuForm.gestionEmprunts.Emprunts.Table.Keys)
            {
                Emprunteur emp = MenuForm.gestionEmprunts.Emprunteurs.Recherche(x);
                ListeOuvrages ouv = MenuForm.gestionEmprunts.Emprunts.Recherche(x);
                    string s="";
                    foreach (Ouvrage o in ouv.Liste)
                    {
        
                            s = s  +o.Titre+",";

                    }
               
                dataGridView1.Rows.Add(emp.Nom+" "+emp.Prenom,s);
                s = "";
            }
        }
    }
}
