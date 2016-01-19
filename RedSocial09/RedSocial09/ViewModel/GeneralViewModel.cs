using RedSocial09.Factoria;
using RedSocial09.Service;
using RedSocial09.ViewModel.Base;

namespace RedSocial09.ViewModel
{
    public class GeneralViewModel:ViewModelBase
    {
        //Todos los servicios que se quieren que estén en todas las pantallas es mejor
        //ponerlas aquí para no tener que repetirlas por todas partes

        protected INavigator _navigator;
        protected IServicioDatos _servicio;

        public GeneralViewModel(INavigator navigator, IServicioDatos servicio)
        {
            _navigator = navigator;
            _servicio = servicio;
        }
    }
}
