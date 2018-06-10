using System.Windows;

namespace Project.LaunchApplication
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{

		private void Application_Startup(object sender, StartupEventArgs e)
		{
			Bootstrapper bs = new Bootstrapper();
			bs.Run();
		}
	}
}
