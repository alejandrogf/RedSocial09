using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RedSocial09.Factoria;
using RedSocial09.Model;
using RedSocial09.Service;
using Xamarin.Forms;

namespace RedSocial09.ViewModel
{
    public class RegistroViewModel : GeneralViewModel
    {
        //Para que el usuario ejecute la acción
        public ICommand cmdAlta { get; set; }

        public Usuario Usuario
        {
            get { return _usuario; }
            set { SetProperty(ref _usuario, value); }
        }
        //Como es un objeto primitivo por defecto es null y por eso lo inicializamos
        private Usuario _usuario = new Usuario();
        public RegistroViewModel(INavigator navigator, IServicioDatos servicio) : base(navigator, servicio)
        {
            cmdAlta = new Command(GuardarUsuario);
        }

        private async void GuardarUsuario()
        {
            try
            {
                IsBusy = true;
                var r = await _servicio.AddUsuario(_usuario);
                if (r != null)
                {
                    await _navigator.PushModalAsync<PrincipalViewModel>();
                }
                else
                {
                    var a = "";//para controlar si va bien, en teoria aqui va un dialogo
                }
            }
            finally
            {
                IsBusy = false;
            }
        }

    }
}
