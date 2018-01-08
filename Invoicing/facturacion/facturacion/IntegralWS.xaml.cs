using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
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
    /// Interaction logic for IntegralWS.xaml
    /// </summary>
    public partial class IntegralWS : Window
    {



        public IntegralWS()
        {
            InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            ClassEntidades.Asiento Asiento = new ClassEntidades.Asiento();
            Asiento.Descripcion = txtdescripcion.Text;
            Asiento.TipoInventarioId = Convert.ToInt32(txttipoinventario.Text);
            Asiento.CuentaContableId = Convert.ToInt32(txtcuentacontable.Text);
            Asiento.TipoMovimiento = txttipodemovimiento.Text;
            Asiento.FechaAsiento = Convert.ToDateTime(fecha.Text);
            Asiento.MontoAsiento = Convert.ToDouble(txtmontoasiento.Text);
            Asiento.Estado = Convert.ToInt32(txtestado.Text);

            HttpClient client = new HttpClient();
            //esa linea de codigo es la que define el endpoint(ruta)
            client.BaseAddress = new Uri("http://localhost:54190/");
            client.DefaultRequestHeaders.Accept.Clear();
            //esta linea es la que te dice que el webservices te va a consumir en formato json el objeto .
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //llamar al webservices con el metodo post
            var result = client.PostAsync("/api/Asiento", new
            {
                //Donde se arma el json ,es la definion del objeto.
                Descripcion = Asiento.Descripcion,
                TipoInventarioId = Asiento.TipoInventarioId,
                CuentaContableId = Asiento.CuentaContableId,
                TipoMovimiento = Asiento.TipoMovimiento,
                FechaAsiento = Asiento.FechaAsiento,
                MontoAsiento = Asiento.MontoAsiento,
                Estado = Asiento.Estado
            }, new JsonMediaTypeFormatter()).Result;



        }
    }
}
