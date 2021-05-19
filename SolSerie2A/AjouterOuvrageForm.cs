using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_OUVRAGES
{
    public partial class AjouterOuvrageForm : Form
    {
        public AjouterOuvrageForm()
        {
            InitializeComponent();
        }

        private void AjouterOuvrageForm_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(!(listBox1.Items.Contains(textBox3.Text)))
            {
                listBox1.Items.Add(textBox3.Text);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year, month, day;
            try
            {
                 year = int.Parse(textBox2.Text);
                 month = int.Parse(textBox4.Text);
                 day = int.Parse(textBox5.Text);
            }
            catch (Exception)
            {
                month = 0;
                day = 0;
                year = 0;
               
            }
            
   
            if(month>0 && month <13 && day>0 && day<32  &&year<3000)
            {
                Ouvrage ouvrage = new Ouvrage(textBox1.Text, new DateTime(year, month, day));
                foreach (string x in listBox1.Items)
                {
                    ouvrage.AddAuteur(x);
                    MenuForm.ouvrage.AddAuteur(x);

                }
                MenuForm.listOuvrages.Liste.Add(ouvrage);
                MessageBox.Show("Ajouter avec succés");
                this.Close();
                label7.Text = "";
                
            }
            else
            {
                textBox2.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
                label7.Text = "verifié la date ";
            }
                

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
