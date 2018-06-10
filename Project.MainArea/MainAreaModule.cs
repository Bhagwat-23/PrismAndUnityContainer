using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using Project.MainArea.Interfaces;
using Project.MainArea.ViewModels;
using Project.MainArea.Views;

namespace Project.MainArea
{
	public class MainAreaModule:IModule
	{
		#region Fields/Types...
		IUnityContainer _container;
		IRegionManager _regionManager;
		#endregion

		public MainAreaModule(IUnityContainer container, IRegionManager regionManager)
		{
			this._container = container;
			this._regionManager = regionManager;
		}

		public void Initialize()
		{
			this._container.RegisterType<object, TestView1>(typeof(TestView1).Name, new ContainerControlledLifetimeManager());
			this._container.RegisterType<object, TestView2>(typeof(TestView2).Name, new ContainerControlledLifetimeManager());
			this._container.RegisterType<object, TestView3>(typeof(TestView3).Name, new ContainerControlledLifetimeManager());

			this._container.RegisterType<ITestViewModel1, TestViewModel1>(new ContainerControlledLifetimeManager());
			this._container.RegisterType<ITestViewModel2, TestViewModel2>(new ContainerControlledLifetimeManager());
			this._container.RegisterType<ITestViewModel3, TestViewModel3>(new ContainerControlledLifetimeManager());

			this._regionManager.RegisterViewWithRegion("TestView1", typeof(TestView1));
			this._regionManager.RegisterViewWithRegion("TestView2", typeof(TestView2));
			this._regionManager.RegisterViewWithRegion("TestView3", typeof(TestView3));
		}
	}
}
