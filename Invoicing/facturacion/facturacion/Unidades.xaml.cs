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
    /// Interaction logic for Unidades.xaml
    /// </summary>
    public partial class Unidades : Window
    {
        public Unidades()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ClassEntidades.Unidades_DeMedida UNIDAD = new ClassEntidades.Unidades_DeMedida();
            UNIDAD.nombre_unidad = TxtNombre.Text;
            UNIDAD.descripcion = TxtDescripcion.Text;
            UNIDAD.estado = TxtEstado.Text;
            ClassNegocio.InsertarUnidades(UNIDAD);

            MessageBox.Show("Haz Agregado Una Unidad De Medida");



            DGVDatos.ItemsSource = null;
            DataTable dt = new DataTable();
            DGVDatos.ItemsSource = ClassNegocio.MostrarUnidades().DefaultView;

            //DataTable dt = new DataTable();
            //dt.Columns.Add("NOMBRE DE UNIDAD");
            //dt.Columns.Add("DESCRIPCION");
            //dt.Columns.Add("ESTADO");
            //dt.Rows.Add(TxtNombre.Text, TxtDescripcion.Text, TxtEstado.Text);
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
            ModificarUnidad ModificarUnidad = new ModificarUnidad();
            ModificarUnidad.Show();
            Close();
        }
    }
}
