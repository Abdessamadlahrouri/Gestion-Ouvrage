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
    public partial class ListAuteur : Form
    {
        public ListAuteur()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListAuteur_Load(object sender, EventArgs e)
        {
            foreach (var x in MenuForm.ouvrage.Auteurs)
            {
                listBox1.Items.Add(x);
                
            }
        }
    }
}
