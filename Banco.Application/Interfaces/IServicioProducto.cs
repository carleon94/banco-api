using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Banco.Domain.Interfaces;

namespace Banco.Aplicaciones.Interfaces
{
    public interface IServicioProducto<TEntidad, TEntidadID>
        : IEditar<TEntidadID, TEntidad>, IListar<TEntidad, TEntidadID> {
    }
}
