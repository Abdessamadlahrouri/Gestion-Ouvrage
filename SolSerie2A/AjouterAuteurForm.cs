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
    public partial class AjouterAuteurForm : Form
    {
        public AjouterAuteurForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm.ouvrage.AddAuteur(textBox1.Text);
            MessageBox.Show("Ajouter avec succés");
            this.Close();
        }
    }
}
