using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using Datos;
namespace Negocio
{
    public class ClassNegocio
    {


        public static DataTable IniciarSesion(ClassEntidades.Usuario usuario)
        {
            return ClassDatos.InisiarSesion(usuario);
        }

       /* public static DataTable CargarFoto(ClassEntidades.Usuario usuario)
        {
            return ClassDatos.CargarFoto(usuario);
        }*/

        public static DataTable ActualizarUsuario(ClassEntidades.Usuario usuario)
        {
            return ClassDatos.ActualizarUsuario(usuario);
        }

        ////////////////////////////////////////////////////////////////////////////

        public static DataTable InsertarArticulo(ClassEntidades.Articulos Articulo)
        {
            return ClassDatos.InsertarArticulos(Articulo);
        }

        public static DataTable InsertarCompra(ClassEntidades.Ordenes_Decompra Compra)
        {
            return ClassDatos.InsertarCompra(Compra);
        }

        public static DataTable InsertarProveedor(ClassEntidades.Provedores Proveedor)
        {
            return ClassDatos.InsertarProveedor(Proveedor);
        }

        public static DataTable InsertarUnidades(ClassEntidades.Unidades_DeMedida UNIDAD)
        {
            return ClassDatos.InsertarUnidades(UNIDAD);

        }

        public static DataTable InsertarDepartamento(ClassEntidades.Departamentos Departamento)
        {
            return ClassDatos.InsertarDepartamento(Departamento);

        }

        ////////////////////////////////////////////////////////////////////////////////////
        public static DataTable EditarCompra(ClassEntidades.Ordenes_Decompra Compra)
        {
            return ClassDatos.EditarCompra(Compra);
        }
        public static DataTable EditarArticulos(ClassEntidades.Articulos articulo)
        {
            return ClassDatos.EditarArticulos(articulo);
        }

        public static DataTable EditarDepartamento(ClassEntidades.Departamentos departamento)
        {
            return ClassDatos.EditarDepartamento(departamento);
        }

        public static DataTable EditarProveedores(ClassEntidades.Provedores Proveedor)
        {
            return ClassDatos.EditarProveedor(Proveedor);
        }

        public static DataTable EditarUnidades(ClassEntidades.Unidades_DeMedida unidad)
        {
            return ClassDatos.EditarUnidades(unidad);
        }

        ////////////////////////////////////////////////////////////////////////////////////

        public static DataTable MostrarArticulos()
        {
            return ClassDatos.MostrarArticulos();
        }

        public static DataTable MostrarDepartamento()
        {
            return ClassDatos.MostrarDepartamentos();
        }

        public static DataTable MostrarProvedores()
        {
            return ClassDatos.MostrarProvedores();
        }

        public static DataTable MostrarUnidades()
        {
            return ClassDatos.MostrarUnidades();
        }
        public static DataTable MostrarCompras()
        {
            return ClassDatos.MostrarCompras();
           
        }

        ////////////////////////////////////////////////////////////////////////////////////
        public static DataTable DeleteCompra(ClassEntidades.Ordenes_Decompra Compra)
        {
            return ClassDatos.DeleteCompra(Compra);

        }
        public static DataTable DeleteUnidades(ClassEntidades.Unidades_DeMedida UNIDAD)
        {
            return ClassDatos.DeleteUnidades(UNIDAD);

        }
        public static DataTable DeleteArticulo(ClassEntidades.Articulos Articulo)
        {
            return ClassDatos.DeleteArticulo(Articulo);

        }
        public static DataTable DeleteDepartamento(ClassEntidades.Departamentos Departamento)
        {
            return ClassDatos.DeleteDepartamento(Departamento);

        }
    }

}
