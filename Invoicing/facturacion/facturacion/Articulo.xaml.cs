using Entidades;
using Facturacion;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace facturacion
{
    /// <summary>
    /// Interaction logic for Articulo.xaml
    /// </summary>
    public partial class Articulo : Window
    {
        public Articulo()
        {
            InitializeComponent();
        }

     

        private void button_Click(object sender, RoutedEventArgs e)
        {
             
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            ClassEntidades.Articulos Articulo = new ClassEntidades.Articulos();
            Articulo.nombre = TxtNombre.Text;
            Articulo.descripcion = TxtDescripcion.Text;
            Articulo.marca = TxtMarca.Text;
            Articulo.unidad_Demedida =Convert.ToInt32(TxtUnidad.Text);
            Articulo.existencia =Convert.ToInt32(TxtExistencia.Text);
            Articulo.precio = Convert.ToInt32(TxtPrecio.Text);
            ClassNegocio.InsertarArticulo(Articulo);

            DGVDatos.ItemsSource = null;
            DataTable dt = new DataTable();
            DGVDatos.ItemsSource = ClassNegocio.MostrarArticulos().DefaultView;

            //DGVDatos.ItemsSource = null;
            //DataTable dt = new DataTable();
            //dt.Columns.Add("NOMBRE");
            //dt.Columns.Add("DESCRIPCION");
            //dt.Columns.Add("MARCA");
            //dt.Columns.Add("UNIDAD DE MEDIDA");
            //dt.Columns.Add("EXISTENCIA");
            //dt.Columns.Add("PRECIO");
            //dt.Rows.Add(TxtNombre.Text, TxtDescripcion.Text, TxtMarca.Text, TxtUnidad.Text, TxtExistencia.Text, TxtPrecio.Text);
            //DGVDatos.ItemsSource = dt.DefaultView;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Menu = new MainWindow();
            Menu.Show();
            Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ModificarArticulo ModiArticulo = new ModificarArticulo();
            ModiArticulo.Show();
            Close();
        }
    }
}
