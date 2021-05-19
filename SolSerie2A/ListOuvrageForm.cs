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
    public partial class ListOuvrageForm : Form
    {
        public ListOuvrageForm()
        {
            InitializeComponent();
        }

        private void ListOuvrageForm_Load(object sender, EventArgs e)
        {
            string s="";
            foreach (Ouvrage x in MenuForm.listOuvrages.Liste)
            {

                foreach (string t in x.Auteurs)
                {
                    
                    s = s  +t+",";
                }
                      
               
                dataGridView1.Rows.Add(x.Titre, x.Edition,s);
                s = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string titre = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                Ouvrage ouvrage = MenuForm.listOuvrages.Recherche(titre);
                MenuForm.listOuvrages.DelOuvrage(ouvrage.Code);
            }
            catch (Exception)
            {


            }
        }
    }
}
