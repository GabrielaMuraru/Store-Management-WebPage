using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreProjectFinal
{
    public partial class StergeCont : Form
    {

        public StergeCont()
        {
            InitializeComponent();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            string user = txtUserDelete.Text;
            string parola = txtParolaDelete.Text;

            using (StoreDbContext sdb = new StoreDbContext())
            {
                Utilizator utilizator = new Utilizator();
                utilizator = sdb.Utilizator.FirstOrDefault();
                if (string.IsNullOrEmpty(txtUserDelete.Text) || string.IsNullOrEmpty(txtParolaDelete.Text))
                {
                    MessageBox.Show("Va rugam completati toate cadrele.");
                    return;
                }

                using (StoreDbContext mdb = new StoreDbContext())
                {
                    utilizator = mdb.Utilizator.FirstOrDefault(a => a.Username == user);
                    if (utilizator == null)
                    {
                        MessageBox.Show("User-ul nu exista.");
                        return;
                    }
                    if (utilizator.Parola.Equals(parola))
                    {
                        mdb.Utilizator.Remove(utilizator);
                        mdb.SaveChanges();
                        MessageBox.Show("Cont sters cu succes!");
                        return;
                    }
                    MessageBox.Show("Parola incorecta! Introduceti parola din nou.");
                    return;
                }
            }
        }
    }
}
