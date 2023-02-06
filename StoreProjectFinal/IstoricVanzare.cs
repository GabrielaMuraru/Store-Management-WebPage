using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StoreProjectFinal
{
    public class IstoricVanzare
    {
        public int Id { get; set; }
        public int Id_user { get; set; }
        public string Denumire { get; set; }
        public int Cantitate { get; set; }
    }
}
