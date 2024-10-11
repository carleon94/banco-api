using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Domain.Interfaces.Repositorios;
using Banco.Domain.Models;
using Banco.Infrastruture.Contexto;

namespace Banco.Infrastructure.Repositorios
{
    public class CategoriaRepositorio : IRepositorioCategoria<Categoria, Guid>
    {
        private BancoContexto db;

        public CategoriaRepositorio(BancoContexto _db)
        {
            db = _db;
        }

        public List<Categoria> Listar()
        {
            return db.Categorias.ToList();
        }

        public Categoria SeleccionarPorID(Guid entidadID)
        {
            var categoriaSeleccionada = db.Categorias.Where(c => c.Id == entidadID).FirstOrDefault();
            return categoriaSeleccionada;
        }
    }
}
