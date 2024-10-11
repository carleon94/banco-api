using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Domain.Interfaces;

namespace Banco.Application.Interfaces
{
    public interface IServicioCategoria<TEntidad, TEntidadID>
        : IListar<TEntidad, TEntidadID>
    {
    }
}
