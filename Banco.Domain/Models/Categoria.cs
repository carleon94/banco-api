using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Domain.Models
{
    public class Categoria
    {
        public Guid Id { get; set; }

        public string Nombre { get; set; }

        public string Codigo { get; set; }
    }
}
