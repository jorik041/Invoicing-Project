using facturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Facturacion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           InitializeComponent();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            facturacion.Login login = new facturacion.Login();
            login.ShowDialog();

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Compras Compras = new Compras();
            Compras.Show();
            Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Articulo Articulo = new Articulo();
            Articulo.Show();
            Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Departamento Departamento = new Departamento();
            Departamento.Show();
            Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Proveedor Proveedor = new Proveedor();
            Proveedor.Show();
            Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Unidades UNIDAD = new Unidades();
            UNIDAD.Show();
            Close();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            IntegralWS IntegralWS = new IntegralWS();
            IntegralWS.Show();
            Close();
        }
    }
}
