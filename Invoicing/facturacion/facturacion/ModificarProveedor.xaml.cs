using Entidades;
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
    /// Interaction logic for ModificarProveedor.xaml
    /// </summary>
    public partial class ModificarProveedor : Window
    {
        public ModificarProveedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ClassEntidades.Provedores Proveedor = new ClassEntidades.Provedores();
            Proveedor.id_cedula = TxtCedula.Text;
            Proveedor.nombre = TxtNombre.Text;
            Proveedor.apellido = TxtApellido.Text;
            Proveedor.empresa = TxtEmpresa.Text;
            Proveedor.rnc = TxtRnc.Text;
            Proveedor.estado = TxtEstado.Text;
            ClassNegocio.EditarProveedores(Proveedor);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Proveedor Proveedor = new Proveedor();
            Proveedor.Show();
            Close();
        }
    }
}
