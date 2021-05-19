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
    public partial class ModifierAuteurForm : Form
    {
        public ModifierAuteurForm()
        {
            InitializeComponent();
        }

        private void ModifierAuteurForm_Load(object sender, EventArgs e)
        {
            string a = "";
            foreach (var x in MenuForm.ouvrage.Auteurs)
            {
                comboBox1.Items.Add(x);
                a = "" + x;
            }
            comboBox1.SelectedText = a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MenuForm.ouvrage.ModifyAuteur(comboBox1.GetItemText(this.comboBox1.SelectedItem), textBox1.Text);
                label3.Text = "";
                textBox1.Text = "";
                MessageBox.Show("Modification avec succés");
                this.Close();
                
            }
            catch (Exception)
            {

                label3.Text = "Select code";
            }
        }
    }
}
