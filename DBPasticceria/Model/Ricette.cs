using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBPasticceria.Model
{
    public partial class Ricette
    {
        public int CodR { get; set; }
        public int QtaIngredienti { get; set; }
        public int CodD { get; set; }
        public int CodI { get; set; }

        public virtual Dolci CodDNavigation { get; set; }
        public virtual Ingredienti CodINavigation { get; set; }
    }
}
