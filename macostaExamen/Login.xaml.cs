using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace macostaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Inicio_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2023";
            string contrasena = "uisrael2023";

            if (txtUsuario.Text == usuario && txtContraseña.Text == contrasena)
            {
                Navigation.PushAsync(new Registro(usuario));

            }
            else
            {
                DisplayAlert("Error ", "incorrecto usuario o contraseña", "cerrar");
            }



        }
    }
}