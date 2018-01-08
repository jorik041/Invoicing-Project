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
    /// Interaction logic for ModificarCompra.xaml
    /// </summary>
    public partial class ModificarCompra : Window
    {
        public ModificarCompra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            
        
    }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Compras Compras = new Compras();
            Compras.Show();
            Close();
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            ClassEntidades.Ordenes_Decompra Compra = new ClassEntidades.Ordenes_Decompra();
            Compra.id_Orden = Convert.ToInt32(TxtId.Text);
            Compra.fecha = TxtFecha.Text;
            Compra.hora = TxtHora.Text;
            Compra.estado = TxtEstado.Text;
            Compra.articulo = TxtArticulo.Text;
            Compra.cantidad = Convert.ToInt32(TxtCantidad.Text);
            Compra.unidad_demedida = Convert.ToInt32(TxtMedida.Text);
            Compra.costo = Convert.ToInt32(TxtCosto.Text);
            ClassNegocio.EditarCompra(Compra);
            MessageBox.Show("Haz Modificado la Orden de Compra #" + Compra.id_Orden);

        }

        private void button1_Click_12(object sender, RoutedEventArgs e)
        {

            DGVDatos.ItemsSource = null;
            DataTable dt = new DataTable();
            DGVDatos.ItemsSource = ClassNegocio.MostrarCompras().DefaultView;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ClassEntidades.Ordenes_Decompra Compra = new ClassEntidades.Ordenes_Decompra();
            Compra.id_Orden = Convert.ToInt32(TxtId.Text);
            ClassNegocio.DeleteCompra(Compra);
            MessageBox.Show("Haz Eliminado la Orden de Compra #" + Compra.id_Orden);

            DGVDatos.ItemsSource = null;
            DataTable dt = new DataTable();
            DGVDatos.ItemsSource = ClassNegocio.MostrarCompras().DefaultView;
        }
    }
}
