using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EanrrangoExamern
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

     

        private void btnAbrirRegistro_Clicked(object sender, EventArgs e)
        {

        }
        string usuario;
        string clave; 
        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text;
            clave= txtPassword.Text;

            if (usuario == "estudiante2023" && clave == "uisrael2023")
            {
                Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                DisplayAlert("ERROR..", "Usuario o contraseña incorrectos....!", "cerrar");
                txtUsuario.Text = "";
                txtPassword.Text = "";

            }

        }
    }
}