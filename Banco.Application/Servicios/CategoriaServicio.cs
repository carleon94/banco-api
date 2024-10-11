using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Application.Interfaces;
using Banco.Domain.Interfaces;
using Banco.Domain.Interfaces.Repositorios;
using Banco.Domain.Models;

namespace Banco.Application.Servicios
{
    public class CategoriaServicio : IServicioCategoria<Categoria, Guid>
    {
        private readonly IRepositorioCategoria<Categoria, Guid> repoCategoria;

        public CategoriaServicio(IRepositorioCategoria<Categoria, Guid> _repoCategoria)
        {
            repoCategoria = _repoCategoria;
        }

        List<Categoria> IListar<Categoria, Guid>. Listar()
        {
            return repoCategoria.Listar();
        }

        Categoria IListar<Categoria, Guid>.SeleccionarPorID(Guid entidadID)
        {
            return repoCategoria.SeleccionarPorID(entidadID);
        }
    }
}
