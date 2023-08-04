using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta_Detalle
    {
        public int IdVentaDetalle { get; set; }

        public int IdVenta { get; set; }

        public Producto oProducto { get; set; }

        public int Cantidad { get; set; }

        public decimal Total { get; set; }


    }
}

