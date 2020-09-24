using SQLite;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;

namespace DrugApp
{
    public class Medicament
    {
        [PrimaryKey,AutoIncrement]
        public Guid Id { get; set; }
        public int Numero { get; set; }
        public string Nom { get; set; }
        public string Molecule { get; set; }

        public string Posologie { get; set; }
        public string Contre_Indication { get; set; }
    }
}
