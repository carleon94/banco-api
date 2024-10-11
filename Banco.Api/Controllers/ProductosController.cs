using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Banco.Domain.Models;
using Banco.Infrastruture.Contexto;
using Banco.Infrastructure.Repositorios;
using Prueba.Aplicaciones.Servicios;

namespace Banco.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private ProductoServicio _servicio;

        ProductoServicio CrearServicio()
        {
            BancoContexto db = new BancoContexto();
            ProductoRepositorio repo = new ProductoRepositorio(db);
            ProductoServicio servicio = new ProductoServicio(repo);
            return servicio;
        }

        public ProductosController()
        {
            _servicio = CrearServicio();
        }

        // GET: api/Productos
        [HttpGet]
        public ActionResult<List<Producto>> GetProductos()
        {
            return Ok(_servicio.Listar());
        }

        // GET: api/Productos/Favoritos
        [HttpGet("Favoritos")]
        public ActionResult<List<Producto>> GetProductosFavoritos()
        {
            return Ok(_servicio.ListarFavoritos());
        }

        // GET: api/Productos/5
        [HttpGet("{id}")]
        public ActionResult<Producto> GetProducto(Guid id)
        {
            var producto = _servicio.SeleccionarPorID(id);

            if (producto == null)
            {
                return NotFound();
            }

            return Ok(producto);
        }

        // PUT: api/Productos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProducto(Guid id, Producto producto)
        {
            if (id != producto.Id)
            {
                return BadRequest();
            }
            _servicio.Editar(id, producto);

            return Ok(_servicio.SeleccionarPorID(id));
        }
    }
}
