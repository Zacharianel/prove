using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DBPasticceria.Model
{
    public partial class Vetrina
    {
        public int CodV { get; set; }
        public int CodD { get; set; }
        public DateTime Data { get; set; }

        public virtual Dolci CodDNavigation { get; set; }
    }
}
