using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Windows.Forms;

namespace StoreProjectFinal
{
    public partial class CreareCont : Form
    {
        private Utilizator utilizator = null;
        public CreareCont(Utilizator utilizator)
        {
            InitializeComponent();
            this.utilizator = utilizator;
        }

        private void btnCreareCont_Click(object sender, EventArgs e)
        {
            utilizator.Id = int.Parse(txtId.Text);
            utilizator.Nume = txtNume.Text;
            utilizator.Prenume = txtPrenume.Text;
            utilizator.Username = txtUsername.Text;
            utilizator.Parola = txtParola.Text;

            this.Close();
        }
        //proprietate de ascundere a parolei
        private void txtParola_Enter(object sender, EventArgs e)
        {
            txtParola.Text = "";
            txtParola.ForeColor = Color.Black;
            txtParola.UseSystemPasswordChar = true;
        }
    }
}
