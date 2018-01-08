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
    /// Interaction logic for ModificarUnidad.xaml
    /// </summary>
    public partial class ModificarUnidad : Window
    {
        public ModificarUnidad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ClassEntidades.Unidades_DeMedida UNIDAD = new ClassEntidades.Unidades_DeMedida();
            UNIDAD.id_unidad =Convert.ToInt32(TxtId.Text);
            UNIDAD.nombre_unidad = TxtNombre.Text;
            UNIDAD.descripcion = TxtDescripcion.Text;
            UNIDAD.estado = TxtEstado.Text;
            ClassNegocio.EditarUnidades (UNIDAD);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Unidades Unidades = new Unidades();
            Unidades.Show();
            Close();
        }

        private void button1_Click_12(object sender, RoutedEventArgs e)
        {

            DGVDatos.ItemsSource = null;
            DataTable dt = new DataTable();
            DGVDatos.ItemsSource = ClassNegocio.MostrarUnidades().DefaultView;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ClassEntidades.Unidades_DeMedida UNIDAD = new ClassEntidades.Unidades_DeMedida();
            UNIDAD.id_unidad = Convert.ToInt32(TxtId.Text);
            ClassNegocio.DeleteUnidades(UNIDAD);
        }
    }
}
