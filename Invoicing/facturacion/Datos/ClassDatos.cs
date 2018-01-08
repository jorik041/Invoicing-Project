using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Entidades;
namespace Datos
{
    public static class ClassDatos
    {
        public static SqlConnection sqlConnection = new SqlConnection(connectionString());

        public static string connectionString()
        {
            return @"Data Source=.\SQLEXPRESS;Initial Catalog=Compras;Integrated Security=True";

        }

        public static DataTable InisiarSesion(ClassEntidades.Usuario usuario)
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = new SqlCommand("Iniciar_Sesion", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@nombre", usuario.nombre);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@clave", usuario.clave);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }

    /*    public static DataTable CargarFoto(ClassEntidades.Usuario usuario)
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = new SqlCommand("Cargar_Foto", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@nombre", usuario.nombre);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }*/

        public static DataTable ActualizarUsuario(ClassEntidades.Usuario usuario)
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = new SqlCommand("Actualizar_Usuario", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@nombre", usuario.nombre);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@clave", usuario.clave);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@nueva_clave", usuario.nuevaclave);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }

        ////////////////////////////////////////////////////////////////////////////////

        public static DataTable InsertarArticulos(ClassEntidades.Articulos Articulo)
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            
            sqlDataAdapter.SelectCommand = new SqlCommand("Insertar_Articulo", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@nombre", Articulo.nombre);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@descripcion", Articulo.descripcion);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@marca", Articulo.marca);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@unidad_demedida", Articulo.unidad_Demedida);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@existencia", Articulo.existencia);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@precio", Articulo.precio);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }

        public static DataTable InsertarCompra(ClassEntidades.Ordenes_Decompra Compra)
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = new SqlCommand("Insertar_Compra", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@fecha", Compra.fecha);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@hora", Compra.hora);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@estado", Compra.estado);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@articulo", Compra.articulo);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@cantidad", Compra.cantidad);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@id_unidad_demedida", Compra.unidad_demedida);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@costo", Compra.costo);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;



        }
        public static DataTable EditarCompra(ClassEntidades.Ordenes_Decompra Compra)
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = new SqlCommand("Editar_Compra", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@idorden", Compra.id_Orden);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@fecha", Compra.fecha);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@hora", Compra.hora);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@estado", Compra.estado);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@articulo", Compra.articulo);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@cantidad", Compra.cantidad);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@id_unidad_demedida", Compra.unidad_demedida);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@costo", Compra.costo);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;



        }
        public static DataTable DeleteCompra(ClassEntidades.Ordenes_Decompra Compra)
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = new SqlCommand("Delete_Compra", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@id_orden", Compra.id_Orden);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;



        }

        public static DataTable InsertarDepartamento(ClassEntidades.Departamentos Departamento)
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = new SqlCommand("Insertar_Departamento", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@nombre", Departamento.nombre);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@estado", Departamento.estado);

            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }

        public static DataTable InsertarProveedor(ClassEntidades.Provedores Proveedor)
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = new SqlCommand("Insertar_Provedor", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Cedula", Proveedor.id_cedula);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@nombre", Proveedor.nombre);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@apellido", Proveedor.apellido);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@empresa", Proveedor.empresa);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@rnc", Proveedor.rnc);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@estado", Proveedor.estado);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }

        public static DataTable InsertarUnidades(ClassEntidades.Unidades_DeMedida UNIDAD)
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = new SqlCommand("Insertar_Unidades", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@descripcion", UNIDAD.descripcion);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@estado", UNIDAD.estado);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@nombre", UNIDAD.nombre_unidad);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }

        public static DataTable DeleteUnidades(ClassEntidades.Unidades_DeMedida UNIDAD)
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = new SqlCommand("Delete_Unidades", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@id_orden", UNIDAD.id_unidad);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;



        }

        ////////////////////////////////////////////////////////////////////////////////

        public static DataTable EditarArticulos(ClassEntidades.Articulos Articulo)
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = new SqlCommand("Editar_Articulos", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@id_articulo", Articulo.id_articulo);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@nombre", Articulo.nombre);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@descripcion", Articulo.descripcion);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@marca", Articulo.marca);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@unidad_demedida", Articulo.unidad_Demedida);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@existencia", Articulo.existencia);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@precio", Articulo.precio);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }


        public static DataTable DeleteArticulo(ClassEntidades.Articulos Articulo)
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = new SqlCommand("Delete_Articulo", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@idArticulo", Articulo.id_articulo);
            return dataTable;
        }


        public static DataTable EditarDepartamento(ClassEntidades.Departamentos Departamento)
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = new SqlCommand("Editar_Departamento", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@id_departamento", Departamento.id_departamento);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@nombre", Departamento.nombre);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@estado", Departamento.estado);

            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }

        public static DataTable DeleteDepartamento(ClassEntidades.Departamentos Departamento)
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = new SqlCommand("Delete_Departamento", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@iddepartamento", Departamento.id_departamento);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }

        public static DataTable EditarProveedor(ClassEntidades.Provedores Proveedor)
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = new SqlCommand("Editar_Provedor", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Cedula", Proveedor.id_cedula);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@nombre", Proveedor.nombre);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@apellido", Proveedor.apellido);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@empresa", Proveedor.empresa);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@rnc", Proveedor.rnc);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@estado", Proveedor.estado);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }

        public static DataTable EditarUnidades(ClassEntidades.Unidades_DeMedida unidad)
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = new SqlCommand("Editar_Unidades", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@id", unidad.id_unidad);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@nombre",unidad.nombre_unidad);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@descripcion", unidad.descripcion);
            sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@estado", unidad.estado);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }

        ////////////////////////////////////////////////////////////////////////////////

        public static DataTable MostrarArticulos()
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = new SqlCommand("Mostrar_Articulos", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }

        public static DataTable MostrarCompras()
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = new SqlCommand("Mostrar_Compras", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }

      
        public static DataTable MostrarDepartamentos()
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = new SqlCommand("Mostrar_Departamentos", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }

        public static DataTable MostrarProvedores()
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = new SqlCommand("Mostrar_Provedores", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }

        public static DataTable MostrarUnidades()
        {

            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            sqlDataAdapter.SelectCommand = new SqlCommand("Mostrar_unidades", sqlConnection);
            sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }




    }
}