using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PruebaSd.Models
{
    public partial class Usuario
    {
        public decimal UsuId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
