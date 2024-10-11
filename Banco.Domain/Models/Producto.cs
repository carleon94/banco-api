using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Domain.Models
{
    public class Producto
    {
        public Guid Id { get; set; }

        public Guid CategoriaId { get; set; }

        public string Nombre { get; set; }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string ImageUrl { get; set; }

        public Boolean Favorito { get; set; }
        
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Tienda { get; set; }

        public virtual Categoria Categoria { get; set; } = null!;
    }
}
