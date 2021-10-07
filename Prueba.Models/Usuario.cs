using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Models
{
    public partial class Usuario
    {
        [ExplicitKey]
        public decimal UsuId { get; set; }
        
        public string Nombre { get; set; }
     
        public string Apellido { get; set; }
    }
}
