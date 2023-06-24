using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace macostaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string fecha,string pais, string monto,  string pago,  string nombre, string apellido, string edad)
            
        {
            InitializeComponent();

          

            lblFecha.Text = fecha;
            lblPais.Text = pais;    
            lblCiudad.Text = monto;
            lblMonto.Text = monto;      
            lblPago.Text = pago;    
            lblNombre.Text = nombre;
            lblApellido.Text = apellido;
            lblEdad.Text = edad;
        }

        private void btnCerra_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }
    }
}