﻿using Xamarin.Forms;

namespace MVVMLibrary.Factoria
{//Define el comportamiento de una determinada página
    public interface IPage
    {
        //El objeto INavigation es una interface que está definido en xamarin, 
        //se encarga de controlar lo que hay en la pila de navegación
        INavigation Navigation { get; }
    }
}