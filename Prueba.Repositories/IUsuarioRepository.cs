using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        //IEnumerable<Usuario> UsuarioPagedList(int page, int rows);
    }
}
