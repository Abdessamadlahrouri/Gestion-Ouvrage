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
    public partial class AjouterEmprunt : Form
    {
        public AjouterEmprunt()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int code = int.Parse(comboBox1.GetItemText(this.comboBox1.SelectedItem));
            Emprunteur emp = MenuForm.gestionEmprunts.Emprunteurs.Recherche(code);
            textBox1.Text = emp.Nom + emp.Prenom;
        }

        private void AjouterEmprunt_Load(object sender, EventArgs e)
        {
            string a = "";
            foreach (Emprunteur x in MenuForm.gestionEmprunts.Emprunteurs.Liste)
            {
                comboBox1.Items.Add(x.Code);
                a = "" + x.Code;
            }
            comboBox1.SelectedText = a;

            string s="";
            foreach (Ouvrage x in MenuForm.listOuvrages.Liste)
            {

                checkedListBox1.Items.Add(x.Titre);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
                ListeOuvrages listOuvrage = new ListeOuvrages();
                try
                {
                    foreach (string x in checkedListBox1.CheckedItems)
                    {

                        Ouvrage ouv = MenuForm.listOuvrages.Recherche(x);
                        listOuvrage.AddOuvrage(ouv);
                        MenuForm.listOuvrages.DelOuvrage(ouv);
                        MenuForm.tempListOuvrages.AddOuvrage(ouv);

                    }

                    int code = int.Parse(comboBox1.GetItemText(this.comboBox1.SelectedItem));
                    Emprunteur emp = MenuForm.gestionEmprunts.Emprunteurs.Recherche(code);
                    MenuForm.gestionEmprunts.Add(emp, listOuvrage);

                    


                }
                catch (Exception)
                {
                    
                    
                }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
