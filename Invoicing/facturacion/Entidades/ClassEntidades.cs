using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ClassEntidades
    {
        public class Usuario
        {
            
            public string nombre { get; set; }
            public string clave { get; set; }
            public string nuevaclave { get; set; }
        }

        public class Departamentos
        {
            public int id_departamento { get; set; }
            public string nombre { get; set; }
            public string estado { get; set; }
        }
        public class Articulos
        {
            public int id_articulo { get; set; }
            public string nombre { get; set; }
            public string descripcion { get; set; }
            public string marca { get; set; }
            public int unidad_Demedida { get; set; }
            public int existencia { get; set; }
            public int precio { get; set; }
           

        }

        public class Unidades_DeMedida
        {
            public int id_unidad { get; set; }
            public string nombre_unidad { get; set; }
            public string descripcion { get; set; }
            public string estado { get; set; }

        }
        public class Provedores
        {
           
            public string id_cedula { get; set; }
            public string nombre { get; set; }
            public string apellido { get; set; }
            public string empresa { get; set; }
            public string rnc { get; set; }
            public string estado { get; set; }

        }
        public class Ordenes_Decompra
        {
            public int id_Orden { get; set; }
            public string fecha { get; set; }
            public string hora { get; set; }
            public string estado { get; set; }
            public string articulo { get; set; }
            public int cantidad { get; set; }
            public int unidad_demedida { get; set; }
            public int costo { get; set; }
            

        }
        public class Asiento
        {
            public int Id { get; set; }
            public string Descripcion { get; set; }
            public int TipoInventarioId { get; set; }
            public int CuentaContableId { get; set; }
            public string TipoMovimiento { get; set; }
            public DateTime FechaAsiento { get; set; }
            public double MontoAsiento { get; set; }
            public int Estado { get; set; }
        }
    }
}
