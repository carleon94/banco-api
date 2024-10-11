using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banco.Aplicaciones.Interfaces;
using Banco.Domain.Models;
using Banco.Domain.Interfaces.Repositorios;

namespace Prueba.Aplicaciones.Servicios
{
    public class ProductoServicio : IServicioProducto<Producto, Guid>
    {
        private readonly IRepositorioProducto<Producto, Guid> repoProducto;

        public ProductoServicio(IRepositorioProducto<Producto,Guid> _repoProducto )
        {
            repoProducto = _repoProducto;
        }


        public void Editar( Guid entidadId , Producto entidad)
        {
            if (entidadId != entidad.Id)
                throw new ArgumentNullException("El 'Producto' no es el mismo para editar");

            if (entidad == null)
                throw new ArgumentNullException("El 'Producto' es requerido para editar");

            repoProducto.Editar(entidad.Id , entidad);
            repoProducto.guardarTodosLosCambios();
        }

        public List<Producto> Listar()
        {
            return repoProducto.Listar();
        }

        public List<Producto> ListarFavoritos()
        {
            return repoProducto.ListarFavoritos();
        }

        public Producto SeleccionarPorID(Guid entidadID)
        {
            return repoProducto.SeleccionarPorID(entidadID);
        }
    }
}
