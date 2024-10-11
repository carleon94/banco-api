using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Domain.Interfaces.Repositorios;
using Banco.Domain.Models;
using Banco.Infrastruture.Contexto;
using Microsoft.EntityFrameworkCore;

namespace Banco.Infrastructure.Repositorios
{
    public class ProductoRepositorio : IRepositorioProducto<Producto, Guid>
    {
        private BancoContexto db;

        public ProductoRepositorio(BancoContexto _db)
        {
            db = _db;
        }

        public void Editar( Guid entidadID , Producto entidad )
        {
            var productoSeleccionado = db.Productos.Where(c => c.Id == entidadID).FirstOrDefault();
            if (productoSeleccionado != null)
            {
                productoSeleccionado.Favorito = entidad.Favorito;
                db.Entry(productoSeleccionado).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public List<Producto> Listar()
        {
            return db.Productos.Include(p => p.Categoria).ToList();
        }

        public List<Producto> ListarFavoritos()
        {
            return db.Productos.Where( p => p.Favorito == true ).Include(p => p.Categoria).ToList();
        }

        public Producto SeleccionarPorID(Guid entidadID)
        {
            var productoSeleccionado = db.Productos.Where(c => c.Id == entidadID).Include(p => p.Categoria).FirstOrDefault();
            return productoSeleccionado;
        }

        public void guardarTodosLosCambios()
        {
            db.SaveChanges();
        }

    }
}
