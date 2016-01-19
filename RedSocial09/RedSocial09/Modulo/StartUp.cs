using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using RedSocial09.Factoria;
using RedSocial09.View;
using RedSocial09.ViewModel;
using Xamarin.Forms;

namespace RedSocial09.Modulo
{
    public class Startup : AutofacBootstraper
    {
        private readonly App _application;

        public Startup(App application)
        {
            _application = application;
        }

        public override void ConfigureContainer(ContainerBuilder builder)
        {
            base.ConfigureContainer(builder);
            builder.RegisterModule<BlockModulo>();
        }

        protected override void RegisterViews(IViewFactory viewFactory)
        {
            //Aquí registras los viewmodel y los view, relcionandolos
            //Esta parte de código dentro de la arquitectura, que es toda igual, difiere según el proyecto.
            viewFactory.Register<LoginViewModel, Login>();
            viewFactory.Register<RegistroViewModel, Registro>();
            viewFactory.Register<PrincipalViewModel, Principal>();
        }

        protected override void ConfigureApplication(IContainer container)
        {
            var viewFactory = container.Resolve<IViewFactory>();
            //Indicas la página principal de la aplicación.
            var main = viewFactory.Resolve<LoginViewModel>();
            var navpage = new NavigationPage(main);
            _application.MainPage = navpage;
        }
    }
}
