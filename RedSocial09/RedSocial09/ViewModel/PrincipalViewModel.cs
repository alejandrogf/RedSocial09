using System.Windows.Input;
using MVVMLibrary.Factoria;
using RedSocial09.Service;
using Xamarin.Forms;

namespace RedSocial09.ViewModel
{
    public class PrincipalViewModel : GeneralViewModel
    {
        //Los eventos se capturan con el command
        public ICommand cmdContactos { get; set; }
        public ICommand cmdMensajes { get; set; }

        public PrincipalViewModel(INavigator navigator, IServicioDatos servicio) : base(navigator, servicio)
        {
            cmdContactos = new Command(BuscarContacto);
            cmdMensajes = new Command(EnviarMensaje);
        }

        public string BuscarContactos
        {
            get { return "Buscar Amigos"; }
        }

        public string EnviarMensajes
        {
            get { return "Enviar Mensaje"; }
        }

        private async void BuscarContacto()
        {
            await _navigator.PopToRootAsync();
            await _navigator.PushModalAsync<BuscarContactoViewModel>(viewModel => { Titulo = "Buscar nuevos amigos"; });
        }

        private async void EnviarMensaje()
        {
            await _navigator.PopToRootAsync();
            await _navigator.PushModalAsync<EnviarMensajeViewModel>(viewModel => { Titulo = "Mensajes"; });
        }
    }
}
