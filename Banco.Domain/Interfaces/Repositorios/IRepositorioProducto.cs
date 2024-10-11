using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Domain.Interfaces;

namespace Banco.Domain.Interfaces.Repositorios
{
    public interface IRepositorioProducto<TEntidad, TEntidadID>
        : IEditar<TEntidadID,TEntidad>, IListar<TEntidad, TEntidadID>, ITransaccion
    {
        List<TEntidad> ListarFavoritos();
    }
}
