using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Inc.Entities
{
    public partial class Usuario
    {
        public int UsuarioId { get; set; }

        public string? Nombre { get; set; }

        public byte[]? Salt { get; set; }

        public byte[]? Hash { get; set; }

        public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();

        public override string ToString()
        {
            return $"{Nombre} ({UsuarioId})";
        }
    }
}
