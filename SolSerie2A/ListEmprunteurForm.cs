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
    public partial class ListEmprunteurForm : Form
    {
        public ListEmprunteurForm()
        {
            InitializeComponent();
        }

        private void ListEmprunteurForm_Load(object sender, EventArgs e)
        {
            foreach (Emprunteur x in MenuForm.listEmprunteur.Liste)
            {
                dataGridView1.Rows.Add(x.Code, x.Nom, x.Prenom);
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int code= int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                MenuForm.listEmprunteur.DelEmprunteur(code);
                MenuForm.gestionEmprunts.Emprunteurs.Liste = MenuForm.listEmprunteur.Liste;
               
            }
            catch (Exception)
            {
                
                
            }
            
        }
    }
}
