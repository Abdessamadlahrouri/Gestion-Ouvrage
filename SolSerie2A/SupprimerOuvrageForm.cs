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
    public partial class SupprimerOuvrageForm : Form
    {
        public SupprimerOuvrageForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void SupprimerOuvrageForm_Load(object sender, EventArgs e)
        {
            string a = "";
            foreach (Ouvrage x in MenuForm.listOuvrages.Liste)
            {
                comboBox1.Items.Add(x.Code);
                a = "" + x.Code;
            }
            comboBox1.SelectedText = a;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int code = int.Parse(comboBox1.GetItemText(this.comboBox1.SelectedItem));
            Ouvrage ouv=   MenuForm.listOuvrages.Recherche(code);
            textBox1.Text = ouv.Titre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int code = int.Parse(comboBox1.GetItemText(this.comboBox1.SelectedItem));
            MenuForm.listOuvrages.DelOuvrage(code);
           
            
        }
    }
}
