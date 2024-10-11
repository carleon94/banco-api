using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Domain.Interfaces
{
    public interface IEditar<TEntidadID,TEntidad>
    {
        void Editar(TEntidadID entidadID , TEntidad entidad);
    }
}
