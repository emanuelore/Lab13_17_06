using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAEA_LAB13_WebAPI.Models.Request
{
    public class ProductoRequest
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        //Detalle Producto
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public int precioVenta { get; set; }

    }
}