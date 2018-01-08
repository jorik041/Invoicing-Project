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
    /// Interaction logic for Departamento.xaml
    /// </summary>
    public partial class Departamento : Window
    {
        public Departamento()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ClassEntidades.Departamentos Departamento = new ClassEntidades.Departamentos();
            Departamento.nombre = TxtNombre.Text;
            Departamento.estado = TxtEstado.Text;
            ClassNegocio.InsertarDepartamento(Departamento);

            DGVDatos.ItemsSource = null;
            DataTable dt = new DataTable();
            DGVDatos.ItemsSource = ClassNegocio.MostrarDepartamento().DefaultView;

            //DGVDatos.ItemsSource = null;
            //DataTable dt = new DataTable();
            //dt.Columns.Add("NOMBRE");
            //dt.Columns.Add("ESTADO");
            //dt.Rows.Add(TxtNombre.Text, TxtEstado.Text);
            //DGVDatos.ItemsSource = dt.DefaultView;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Menu = new MainWindow();
            Menu.Show();
            Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Modificar Modidepartamento = new Modificar();
            Modidepartamento.Show();
            Close();
        }

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow Menu = new MainWindow();
            Menu.Show();
            Close();
        }
    }
}
