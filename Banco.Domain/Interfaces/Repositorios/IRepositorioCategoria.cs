using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Domain.Interfaces;

namespace Banco.Domain.Interfaces.Repositorios
{
    public interface IRepositorioCategoria<TEntidad, TEntidadID>
        : IListar<TEntidad, TEntidadID>
    {
    }
}
