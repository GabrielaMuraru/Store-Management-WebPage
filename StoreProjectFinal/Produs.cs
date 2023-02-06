using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace StoreProjectFinal
{
    public class Produs
    {
        public int Id { get; set; }
        [MaxLength(30, ErrorMessage = "Denumirea trebuie sa fie mai mica de 30 caractere.")]
        public string Denumire { get; set; }
        public string Descriere { get; set; }
        public DateTime DataIntrare { get; set; }
        public DateTime DataValabilitate { get; set; }
        public int Cantitate { get; set; }
    }
    public class StoreDbContext : DbContext
    {
        public DbSet<Produs> Produse { get; set; }
        public DbSet<Utilizator> Utilizator { get; set; }
        public DbSet<IstoricVanzare> Istoric { get; set; }
    }
}
