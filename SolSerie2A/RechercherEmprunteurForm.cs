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
    public partial class RechercherEmprunteurForm : Form
    {
        public RechercherEmprunteurForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RechercherEmprunteurForm_Load(object sender, EventArgs e)
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
                dataGridView1.Rows.Clear();
                int code = int.Parse(comboBox1.GetItemText(this.comboBox1.SelectedItem));
                Emprunteur em = MenuForm.listEmprunteur.Recherche(code);
                dataGridView1.Rows.Add(em.Code, em.Nom, em.Prenom);
                label4.Text = "";
            }
            catch (Exception)
            {

                label4.Text = "Select code ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                foreach (Emprunteur x in MenuForm.listEmprunteur.Liste)
                {
                    if((x.Nom == textBox1.Text) || (x.Prenom==textBox2.Text))
                    {
                        dataGridView1.Rows.Add(x.Code, x.Nom, x.Prenom);
                    }
                }
               
                label5.Text = "";
            }
            catch (Exception)
            {

                label5.Text = "Select nom + prenom";
            }
        }
    }
}
