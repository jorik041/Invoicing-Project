using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Entidades;
using Negocio;
using System.Windows.Controls;
using Facturacion;

namespace facturacion
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        ClassEntidades.Usuario usuario = new ClassEntidades.Usuario();
        // string sin_foto = @"C:\Users\Albert\Documents\Visual Studio 2012\Projects\Datos\Presentacion\Fotos\NoFoto.jpg";
        public Login()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            usuario.nombre = TxtUsuario.Text;
            usuario.clave = passwordBox.Password;


            if (ClassNegocio.IniciarSesion(usuario).Rows.Count == 1)
            {
                MainWindow menu = new MainWindow();
                menu.ShowDialog();
                Close();


            }
            else
            {

                MessageBox.Show("contraseña o/y usuario incorrecta");

            }
                
        }

        private void TxtUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        /* private void TxtUsuario_TextChanged(object sender, TextChangedEventArgs e)
         {
             usuario.nombre = TxtUsuario.Text;
             DataRow fila;

             if (ClassNegocio.CargarFoto(usuario).Rows.Count == 1)
             {
                 fila = ClassNegocio.CargarFoto(usuario).Rows[0];
                 //ImgEmpleado.Load(fila["Foto"].ToString());
             }
             else
             {
                 //ImgEmpleado.Load(sin_foto);
             }

         }*/


    }
}