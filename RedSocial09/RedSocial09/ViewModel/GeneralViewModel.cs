﻿using MVVMLibrary.Factoria;
using MVVMLibrary.ViewModel.Base;
using RedSocial09.Service;

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
