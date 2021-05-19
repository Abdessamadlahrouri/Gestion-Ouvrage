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
    public partial class ModifierOuvrageForm : Form
    {
        public ModifierOuvrageForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void ModifierOuvrageForm_Load(object sender, EventArgs e)
        {
            
            string a = "";
            foreach (Ouvrage x in MenuForm.listOuvrages.Liste)
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
                listBox1.Items.Clear();
                int code = int.Parse(comboBox1.GetItemText(this.comboBox1.SelectedItem));
                Ouvrage ouv = MenuForm.listOuvrages.Recherche(code);
                textBox1.Text = ouv.Titre;
                textBox2.Text = ouv.Edition.Year.ToString();
                textBox3.Text = ouv.Edition.Month.ToString();
                textBox4.Text = ouv.Edition.Day.ToString();
                foreach (string x in ouv.Auteurs)
                {
                    listBox1.Items.Add(x);
                }
                label4.Text = "";
            }
            catch (Exception)
            {

                label4.Text = "Select code";
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (!(listBox1.Items.Contains(textBox5.Text)))
            {
                listBox1.Items.Add(textBox5.Text);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox1.Focus();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int year, month, day;
            try
            {
                year = int.Parse(textBox2.Text);
                month = int.Parse(textBox3.Text);
                day = int.Parse(textBox4.Text);
            }
            catch (Exception)
            {
                month = 0;
                day = 0;
                year = 0;

            }


            if (month > 0 && month < 13 && day > 0 && day < 32 && year < 3000)
            {
                 int code = int.Parse(comboBox1.GetItemText(this.comboBox1.SelectedItem));
                 MenuForm.listOuvrages.ModifyOuvrage(code, textBox1.Text, new DateTime(year, month, day));
                Ouvrage ouvrage = MenuForm.listOuvrages.Recherche(code);
                ouvrage.Auteurs.Clear();
                foreach (string x in listBox1.Items)
                {

                    ouvrage.AddAuteur(x);
                    MenuForm.ouvrage.AddAuteur(x);
                }
                
                label7.Text = "";
                MessageBox.Show("Modification avec succés");
                this.Close();
            }
            else
            {
                textBox2.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
                label7.Text = "verifié la date ";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
