using Prueba.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.UnitOfWork
{
    public interface IUnitOfWork
    {
        IUsuarioRepository Usuario { get; }
    }
}
