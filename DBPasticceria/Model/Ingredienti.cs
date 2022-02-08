using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBPasticceria.Model
{
    public partial class Ingredienti
    {
        public Ingredienti()
        {
            Ricette = new HashSet<Ricette>();
        }

        public int CodI { get; set; }
        public string Nome { get; set; }
        public string Um { get; set; }

        public virtual ICollection<Ricette> Ricette { get; set; }
    }
}
