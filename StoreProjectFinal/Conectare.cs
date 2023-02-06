using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreProjectFinal
{
    public partial class Conectare : Form
    {
        public Conectare()
        {
            InitializeComponent();
        }

        private void btnConectare_Click(object sender, EventArgs e)
        {
            //cautare in baza de date utilizator si parola 
            //se verifica daca sunt corecte
            string user = txtUsername.Text;
            string parola = txtParola.Text;
            using (StoreDbContext udb = new StoreDbContext())
            {
                if (txtUsername.Text == "" || txtParola.Text == "")
                {
                    MessageBox.Show("Completeaza campurile afisate.");
                    return;
                }
                else
                {
                    var res = from u in udb.Utilizator
                             select new
                             {
                                 u.Username,
                                 u.Parola
                             };
                    Console.WriteLine(res.ToString());
                    MessageBox.Show("Logare reusita!");
                }
              
            }

            /*if (txtUsername.Text == "" || txtParola.Text == "")
            {
                MessageBox.Show("Completeaza campurile afisate.");
                return;
            } 
            else
            {
                MessageBox.Show("Logare reusita!");
            }*/
        }

        private void txtParola_Enter(object sender, EventArgs e)
        {
            txtParola.Text = "";
            txtParola.ForeColor = Color.Black;
            txtParola.UseSystemPasswordChar = true;
        }
    }
}
