using Prueba.Models;
using Prueba.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.DataAccess
{
    internal class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(string connectionString) : base(connectionString)
        {
        }
    }
}
