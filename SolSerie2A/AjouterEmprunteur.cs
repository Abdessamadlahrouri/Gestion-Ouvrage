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
    public partial class AjouterEmprunteur : Form
    {
        public AjouterEmprunteur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm.listEmprunteur.AddEmprunteur(new Emprunteur(textBox1.Text, textBox2.Text));
            MenuForm.gestionEmprunts.Emprunteurs.Liste = MenuForm.listEmprunteur.Liste;
            textBox1.Text = "";
            textBox2.Text = "";
            MessageBox.Show("Ajouter avec succés");
            this.Close();
            
        }

        private void AjouterEmprunteur_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
