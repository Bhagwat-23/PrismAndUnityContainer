using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using Project.Header.Interfaces;
using Project.Header.ViewModels;
using Project.Header.Views;

namespace Project.Header
{
	public class HeaderModule : IModule
	{
		#region Fields/Types...
		IUnityContainer _container;
		IRegionManager _regionManager;
		#endregion

		public HeaderModule(IUnityContainer container, IRegionManager regionManager)
		{
			this._container = container;
			this._regionManager = regionManager;
		}

		public void Initialize()
		{
			this._container.RegisterType<object, HeaderView>(typeof(HeaderView).Name, new ContainerControlledLifetimeManager());

			this._container.RegisterType<IHeaderViewModel, HeaderViewModel>(new ContainerControlledLifetimeManager());

			this._regionManager.RegisterViewWithRegion("HeaderView", typeof(HeaderView));
		}
	}
}
