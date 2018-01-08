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
    /// Interaction logic for Compras.xaml
    /// </summary>
    public partial class Compras : Window
    {
        

        public Compras()
        {
            InitializeComponent();
            
        }


        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            ClassEntidades.Ordenes_Decompra Compra = new ClassEntidades.Ordenes_Decompra();
            Compra.fecha = TxtFecha.Text;
            Compra.hora = TxtHora.Text;
            Compra.estado = TxtEstado.Text;
            Compra.articulo = TxtArticulo.Text;
            Compra.cantidad = Convert.ToInt32(TxtCantidad.Text);
            Compra.unidad_demedida = Convert.ToInt32(TxtMedida.Text);
            Compra.costo = Convert.ToInt32(TxtCosto.Text);
            ClassNegocio.InsertarCompra(Compra);
            MessageBox.Show("Haz Agregado la Orden de Compra");



            DGVDatos.ItemsSource = null;
            DataTable dt = new DataTable();
            DGVDatos.ItemsSource = ClassNegocio.MostrarCompras().DefaultView;


            //DGVDatos.ItemsSource = null;
            //DataTable dt = new DataTable();
            //dt.Columns.Add("FECHA");
            //dt.Columns.Add("HORA");
            //dt.Columns.Add("ESTADO");
            //dt.Columns.Add("ARTICULO");
            //dt.Columns.Add("CANTIDAD");
            //dt.Columns.Add("UNIDAD DE MEDIDA");
            //dt.Columns.Add("COSTO");
            ////dt.Rows.Add(TxtFecha.Text,TxtHora.Text,TxtEstado.Text,TxtArticulo.Text,TxtCantidad.Text,TxtMedida.Text,TxtCosto.Text);
            //dt.Rows.Add(ClassNegocio.MostrarCompras());
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
            ModificarCompra ModificarCompra = new ModificarCompra();
            ModificarCompra.Show();
            Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

            //DGVDatos.ItemsSource = null;
            //DataTable dt = new DataTable();
            //DataRow fila;

            //fila = ClassNegocio.MostrarCompras().Rows[0];
            ////MessageBox.Show(fila[0].ToString());
            //DGVDatos.ItemsSource = ClassNegocio.MostrarCompras().DefaultView;
            //TxtFecha.Text = fila["FECHA"].ToString();
        }

        private void DGVDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Unidades Unidades = new Unidades();
            Unidades.Show();
            Close();    
        }

        private void button1_Click_12(object sender, RoutedEventArgs e)
        {
            DGVDatos.ItemsSource = null;
            DataTable dt = new DataTable();
            DGVDatos.ItemsSource = ClassNegocio.MostrarCompras().DefaultView;
        }
    }
}
