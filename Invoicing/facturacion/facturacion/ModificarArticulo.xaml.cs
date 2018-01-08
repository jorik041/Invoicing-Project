using Entidades;
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
    /// Interaction logic for ModificarArticulo.xaml
    /// </summary>
    public partial class ModificarArticulo : Window
    {
        public ModificarArticulo()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Articulo ModiArticulo = new Articulo();
            ModiArticulo.Show();
            Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ClassEntidades.Articulos Articulo = new ClassEntidades.Articulos();
            Articulo.id_articulo = Convert.ToInt32(TxtId.Text);
            Articulo.nombre = TxtNombre.Text;
            Articulo.descripcion = TxtDescripcion.Text;
            Articulo.marca = TxtMarca.Text;
            Articulo.unidad_Demedida = Convert.ToInt32(TxtUnidad.Text);
            Articulo.existencia = Convert.ToInt32(TxtExistencia.Text);
            Articulo.precio = Convert.ToInt32(TxtPrecio.Text);
            MessageBox.Show("Haz Modificado Un Articulo");
            ClassNegocio.EditarArticulos(Articulo);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ClassEntidades.Articulos Articulo = new ClassEntidades.Articulos();
            Articulo.id_articulo = Convert.ToInt32(TxtId.Text);
            ClassNegocio.DeleteArticulo(Articulo);

            MessageBox.Show("Haz Eliminado Un Articulo #" + Articulo.id_articulo);

            DGVDatos.ItemsSource = null;
            DataTable dt = new DataTable();
            DGVDatos.ItemsSource = ClassNegocio.MostrarArticulos().DefaultView;
        }

        private void button1_Click_12(object sender, RoutedEventArgs e)
        {
            DGVDatos.ItemsSource = null;
            DataTable dt = new DataTable();
            DGVDatos.ItemsSource = ClassNegocio.MostrarArticulos().DefaultView;
        }
    }
}
