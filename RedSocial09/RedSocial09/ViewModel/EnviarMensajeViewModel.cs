using MVVMLibrary.Factoria;
using RedSocial09.Service;

namespace RedSocial09.ViewModel
{
    public class EnviarMensajeViewModel : GeneralViewModel
    {
        public EnviarMensajeViewModel(INavigator navigator, IServicioDatos servicio) : base(navigator, servicio)
        {
        }
    }
}
