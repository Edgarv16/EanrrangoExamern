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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, double pagTotal, string vusuario)
        {
            InitializeComponent();
            lblNombreR.Text = nombre;
            lblpagoTotalR.Text = pagTotal.ToString();
            lblusuarioC.Text= vusuario;
        }
    }
}