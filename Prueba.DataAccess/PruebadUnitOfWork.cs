using Prueba.Repositories;
using Prueba.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.DataAccess
{
    public class PruebadUnitOfWork : IUnitOfWork
    {
        public PruebadUnitOfWork(string connectionString)
        {
            Usuario = new UsuarioRepository(connectionString);
        }

        public IUsuarioRepository Usuario { get; private set; }
    }
}
