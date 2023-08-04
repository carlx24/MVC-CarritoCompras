using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int IdVenta { get; set; }

        public int IdCliente { get; set; }

        public int TotalProducto { get; set; }

        public int MontoTotal { get; set; }

        public string Contacto { get; set; }

        public string IdCiudad { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public string IdTransaccion { get; set; }

        public List<Venta_Detalle> oVenta_Detalle { get; set; }


    }
}


