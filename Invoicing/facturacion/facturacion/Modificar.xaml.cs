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
    /// Interaction logic for Modificar.xaml
    /// </summary>
    public partial class Modificar : Window
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ClassEntidades.Departamentos Modi = new ClassEntidades.Departamentos();
            Modi.nombre = TxtNombre.Text;
            Modi.estado = TxtEstado.Text;
            Modi.id_departamento = Convert.ToInt16(TxtId.Text);
            ClassNegocio.EditarDepartamento(Modi);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
           Departamento Modidepartamento = new Departamento();
           Modidepartamento.Show();
            Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ClassEntidades.Departamentos Departamento = new ClassEntidades.Departamentos();
            Departamento.id_departamento = Convert.ToInt16(TxtId.Text);
            ClassNegocio.DeleteDepartamento(Departamento);
        }

        private void button1_Click_12(object sender, RoutedEventArgs e)
        {
            DGVDatos.ItemsSource = null;
            DataTable dt = new DataTable();
            DGVDatos.ItemsSource = ClassNegocio.MostrarDepartamento().DefaultView;
        }
    }
}
