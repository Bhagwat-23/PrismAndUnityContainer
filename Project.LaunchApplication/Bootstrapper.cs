using Prism.Modularity;
using Prism.Unity;
using Project.Footer;
using Project.Header;
using Project.MainArea;
using Project.PrismShell;
using System.Windows;

namespace Project.LaunchApplication
{
	public class Bootstrapper: UnityBootstrapper
	{
		protected override DependencyObject CreateShell()
		{
			return Container.TryResolve<ProjectPrismShell>();
		}

		protected override void InitializeShell()
		{
			base.InitializeShell();
			Window window = Shell as Window;
			if (window != default(Window))
			{
				window.Show();
			}
		}

		protected override IModuleCatalog CreateModuleCatalog()
		{
			return base.CreateModuleCatalog();
		}

		protected override void ConfigureModuleCatalog()
		{
			base.ConfigureModuleCatalog();
			ModuleCatalog modules = (ModuleCatalog)this.ModuleCatalog;
			modules.AddModule(typeof(MainAreaModule));
			modules.AddModule(typeof(HeaderModule));
			modules.AddModule(typeof(FooterModule));
			//modules.AddModule(typeof(LoginUtilsModule));
		}

		protected override void ConfigureContainer()
		{
			base.ConfigureContainer();
		}
	}
}
