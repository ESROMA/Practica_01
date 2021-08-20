using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            string validacionNombre = nombreEntry.Text;
            string validacionContraseña = contraseñaEntry.Text;

            if (string.IsNullOrEmpty(validacionNombre) && string.IsNullOrEmpty(validacionContraseña))
            {
                DisplayAlert("Advertencia!!", "Dejó ambos campos vacios.", "Aceptar");
            }
            else if (string.IsNullOrEmpty(validacionNombre))
            {
                DisplayAlert("Advertencia!!", "Dejó el Nombre vacio.", "Aceptar");
            }
            else if (string.IsNullOrEmpty(validacionContraseña))
            {
                DisplayAlert("Advertencia!!", "Dejó la contraseña vacia.", "Aceptar");
            }
            else
            {
                DisplayAlert("Bienvenido", validacionNombre, "Aceptar");
            }
        }
    }
}