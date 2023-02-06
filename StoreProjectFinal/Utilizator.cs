using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace StoreProjectFinal
{
    public class Utilizator
    {
        public int Id { get; set; }
        [MaxLength(30, ErrorMessage = "Denumirea trebuie sa fie mai mica de 30 caractere.")]
        public string Nume { get; set; }
        [MaxLength(30)]
        public string Prenume { get; set; }
        [MaxLength(30)]
        public string Username { get; set; }
        public string Parola { get; set; }
    }
}
