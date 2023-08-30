using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformBDD_2
{
    internal class User
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DtNaiss { get; set; }
        public string IdDept { get; set; }

        public User()
        {

        }
        public User(string nom, string prenom, DateTime dtNaiss)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DtNaiss = dtNaiss;
        }
    }
}

