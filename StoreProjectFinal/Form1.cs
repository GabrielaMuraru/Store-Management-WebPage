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
    public partial class Form1 : Form
    {
        private bool autentif = false;
        public Form1()
        {
            InitializeComponent();
        }
        //incarcarea datelor in DataGrigView
        private void IncarcareDate()
        {
            using (StoreDbContext mdb = new StoreDbContext())
            {
                var res = from p in mdb.Produse
                          select new
                          {
                              p.Id,
                              p.Denumire,
                              p.Cantitate
                          };
                dataGridView1.DataSource = res.ToList();
            }
        }
        private async Task AsyncAdaugaUtilizator(Utilizator util)
        {
            using (StoreDbContext sdb = new StoreDbContext())
            {
                sdb.Utilizator.Add(util);

                await sdb.SaveChangesAsync();
            }
        }
        //inregistrare cont nou utilizator
        private void inregistrareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilizator util = new Utilizator();
            CreareCont cont = new CreareCont(util);
            cont.ShowDialog();
            var res = Task.Run(() => AsyncAdaugaUtilizator(util));
            res.Wait();
            //IncarcareDate();
        }

        private void conectareToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Conectare utilizator = new Conectare();
            utilizator.ShowDialog();
            IncarcareDate();
        }

        private void stergereContToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StergeCont utilizator = new StergeCont();
            utilizator.ShowDialog();
        }
        private async Task AsyncAdaugareProduct(Produs p)
        {
            using (StoreDbContext sdb = new StoreDbContext())
            {
                sdb.Produse.Add(p);

                await sdb.SaveChangesAsync();
            }
        }
        private void adaugareProdusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produs produs = new Produs();
            AdaugareProdus add = new AdaugareProdus(produs);

            add.ShowDialog();
            var res = Task.Run(() => AsyncAdaugareProduct(produs));
            res.Wait();
            IncarcareDate();
        }

        private void cosDeCumparaturiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*if (!autentif)
            {
                Conectare conect = new Conectare();
                conect.ShowDialog();
            }*/
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Apăsați butonul Reîmprospătare mai întâi.");
                return;
            }
  

        }

        private void istoricCumparaturiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (autentif)
            {
                return;
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            IncarcareDate();
        }

        private async Task AsyncVanzare(IstoricVanzare istoric, Produs produs)
        {
            using (StoreDbContext sdb = new StoreDbContext())
            {
                produs.Cantitate -= istoric.Cantitate;
               // sdb.Produse.Modificare(produs);
                sdb.Istoric.Add(istoric);
                await sdb.SaveChangesAsync();
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            Produs produs = new Produs();
     
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            var x = (int)dataGridView1.Rows[rowIndex].Cells[0].Value;

            using (StoreDbContext mdb = new StoreDbContext())
            {
                produs = mdb.Produse.FirstOrDefault(a => a.Id == x);
                IstoricVanzare istoric = new IstoricVanzare();
                Vanzare vanzare = new Vanzare();

                if (vanzare.produs=="")
                {
                    var res = Task.Run(() => AsyncVanzare(istoric, produs));
                    res.Wait();
                }
                if (produs.Cantitate == 0)
                {
                    mdb.Produse.Remove(produs);
                    mdb.SaveChangesAsync();
                }
                IncarcareDate();
            }

        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            using (StoreDbContext mdb = new StoreDbContext())
            {
                var res = from s in mdb.Produse
                          where s.Denumire.Contains(txtCauta.Text)
                          select new
                          {
                              s.Id,
                              s.Denumire,
                              s.Cantitate
                          };
                dataGridView1.DataSource = res.ToList();
            }
        }
    }
}
