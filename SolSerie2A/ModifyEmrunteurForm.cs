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
    public partial class ModifyEmrunteurForm : Form
    {
        public ModifyEmrunteurForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ModifyEmrunteurForm_Load(object sender, EventArgs e)
        {
            string a = "";
            foreach (Emprunteur x in MenuForm.listEmprunteur.Liste)
            {
                comboBox1.Items.Add(x.Code);
                a = "" + x.Code;
            }
            comboBox1.SelectedText = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int code = int.Parse(comboBox1.GetItemText(this.comboBox1.SelectedItem));
                Emprunteur em = MenuForm.listEmprunteur.Recherche(code);
                textBox1.Text = em.Nom;
                textBox2.Text = em.Prenom;
                label4.Text = "";
            }
            catch (Exception)
            {

                label4.Text = "Select code";
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int code = int.Parse(comboBox1.GetItemText(this.comboBox1.SelectedItem));
                MenuForm.listEmprunteur.ModifyEmprunteur(code, textBox1.Text, textBox2.Text);
                MenuForm.gestionEmprunts.Emprunteurs.Liste = MenuForm.listEmprunteur.Liste;
                label4.Text = "";
                MessageBox.Show("Modification avec succés");
                this.Close();
            }
            catch (Exception)
            {

                label4.Text = "Select code";
            }
          
            
        }
    }
}
