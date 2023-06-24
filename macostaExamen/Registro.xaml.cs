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
    public partial class Registro : ContentPage
    {

        string cuotas1;
        public Registro(string usuario)
        {
            InitializeComponent();

            lblUsuario.Text = "Usuario conectado  "+usuario;
        }

      

        private void btn_Calculo_Clicked(object sender, EventArgs e)
        {
                double dato = Convert.ToDouble(txtMonto.Text);

                double pago1 = 1500;
            double dev = 4;

                if (dato > 1500) {

                    DisplayAlert("Error", "el dpago debe ser menor de 1500", "cerrar");
                    
                }else
                {
                try
                {
                    double parcial = Convert.ToDouble(txtMonto);

                    double cuot = (Convert.ToDouble(txtMonto.Text));

                    double cuotas = ((pago1 - cuot) / (dev)) + (0.4 * (pago1));
                    cuotas1 = Convert.ToString(cuotas);

                }
                catch (Exception)
                {

                    throw;
                }


              
                }

         }

        private void txtPago_TextChanged(object sender, TextChangedEventArgs e)
        {
            string cuotas1 = txtPago.Text.Trim();

        }

        private void btn_Resumen_Clicked_1(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string pais = txtPais.Text;
            string monto = txtMonto.Text;
            string pago = cuotas1;
            string nombre = txtNombre1.Text;
            string apellido = txtApellido.Text;
            string edad = txtEdad.Text;

            Navigation.PushAsync(new Resumen(fecha, pais,monto, pago, nombre, apellido, edad));
        }
    }
}