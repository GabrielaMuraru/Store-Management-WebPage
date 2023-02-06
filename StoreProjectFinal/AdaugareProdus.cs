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
    public partial class AdaugareProdus : Form
    {
        private Produs produs = null;
        public AdaugareProdus(Produs produs)
        {
            InitializeComponent();
            this.produs = produs;
        }

        private void btnAdaugProd_Click(object sender, EventArgs e)
        {
            produs.Denumire = txtDenum.Text;
            produs.Descriere = richTxtDescriere.Text;
            produs.DataIntrare = dateTimeIntrare.Value;
            produs.DataValabilitate = dateTimeExpirare.Value;
            produs.Cantitate = (int)numericUpDownCant.Value;
            this.Close();
        }
    }
}
