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
    public partial class SupprimerEmprunteurForm : Form
    {
        public SupprimerEmprunteurForm()
        {
            InitializeComponent();
        }

        private void SupprimerEmprunteurForm_Load(object sender, EventArgs e)
        {
            string a="";
            foreach (Emprunteur x in MenuForm.listEmprunteur.Liste)
            {
                comboBox1.Items.Add(x.Code);
                 a = ""+x.Code;
            }
            comboBox1.SelectedText = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                int code = int.Parse(comboBox1.GetItemText(this.comboBox1.SelectedItem));
                MenuForm.listEmprunteur.DelEmprunteur(code);
                MenuForm.gestionEmprunts.Emprunteurs.Liste = MenuForm.listEmprunteur.Liste;
                MessageBox.Show("Suppression avec succés");
                this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
