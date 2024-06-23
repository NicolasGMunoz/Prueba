using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Inc.Entities
{
    public partial class Compra
    {
        public int CompraId { get; set; }

        public DateOnly? Fecha { get; set; }

        public int? ProductoId { get; set; }

        public int? Cantidad { get; set; }

        public int? UsuarioId { get; set; }

        public virtual Producto? Producto { get; set; }
    }
}
