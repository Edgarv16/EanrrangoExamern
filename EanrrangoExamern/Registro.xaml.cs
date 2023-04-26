using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace EanrrangoExamern
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        string vusuario;
        public Registro(string usuario)
        {
            InitializeComponent();
            vusuario = usuario;
            lblUsuario.Text = usuario;
            
        }

        double pagoMensual;
        double vinicial;
        private void btnCalcPagoMensual_Clicked(object sender, EventArgs e)
        {
            vinicial = Convert.ToDouble(txtMontoInicial.Text);
            double valorcurso = 3000;
            double porcent = 0.05;

            if (!string.IsNullOrEmpty(txtMontoInicial.Text) && !string.IsNullOrEmpty(txtNombre.Text))
           {

          
                if (vinicial > 0 && vinicial <= 2999)
            {
                //Navigation.PushAsync(new Resumen(usuario));

                 pagoMensual =(((valorcurso- vinicial)/3)+(porcent*3000)/100);


                txtPagoMensual.Text = pagoMensual.ToString();


            }

            else if (vinicial < 0)
                {
                   DisplayAlert("ERROR..", "No ingresar valores negativos ....!", "cerrar");
                }

            else
                    {
                DisplayAlert("ERROR..", "El valor no debe ser igual o mayor a 3000 ....!", "cerrar");
                // txtNombre.Text = "";
                // txtMontoInicial.Text = "";
                //txtPagoMensual.Text = "";

            }
            }
            else
            {
                DisplayAlert("Alerta", "Los campos se encuentran vacios ", "cerrar");
            }
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            double pagTotal = (pagoMensual * 3) + vinicial;

            Navigation.PushAsync(new Resumen (nombre,pagTotal, vusuario));

        }
    }
}