using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using Project.Footer.Interfaces;
using Project.Footer.ViewModels;
using Project.Footer.Views;

namespace Project.Footer
{
	public class FooterModule : IModule
	{
		#region Fields/Types...
		IUnityContainer _container;
		IRegionManager _regionManager;
		#endregion

		public FooterModule(IUnityContainer container, IRegionManager regionManager)
		{
			this._container = container;
			this._regionManager = regionManager;
		}

		public void Initialize()
		{
			_container.RegisterType<object, FooterView>(typeof(FooterView).Name, new ContainerControlledLifetimeManager());

			_container.RegisterType<IFooterViewModel, FooterViewModel>(new ContainerControlledLifetimeManager());

			this._regionManager.RegisterViewWithRegion("FooterView", typeof(FooterView));
		}
	}
}
