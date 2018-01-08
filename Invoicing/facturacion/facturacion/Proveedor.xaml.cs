using Entidades;
using Facturacion;
using Negocio;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for Proveedor.xaml
    /// </summary>
    public partial class Proveedor : Window
    {
        public Proveedor()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Menu = new MainWindow();
            Menu.Show();
            Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ModificarProveedor Menu = new ModificarProveedor();
            Menu.Show();
            Close();
        }
    }
}
