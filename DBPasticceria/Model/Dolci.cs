using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBPasticceria.Model
{
    public partial class Dolci
    {
        public Dolci()
        {
            Ricette = new HashSet<Ricette>();
            Vetrina = new HashSet<Vetrina>();
        }

        public int CodD { get; set; }
        public string Nome { get; set; }
        public double Costo { get; set; }

        public virtual ICollection<Ricette> Ricette { get; set; }
        public virtual ICollection<Vetrina> Vetrina { get; set; }
    }
}
