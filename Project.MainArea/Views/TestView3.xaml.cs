using Microsoft.Practices.ServiceLocation;
using Project.MainArea.Interfaces;
using System.Windows.Controls;

namespace Project.MainArea.Views
{
	/// <summary>
	/// Interaction logic for TestView3.xaml
	/// </summary>
	public partial class TestView3 : UserControl
	{
		public TestView3()
		{
			InitializeComponent();
			this.DataContext = ServiceLocator.Current.GetInstance<ITestViewModel3>();
		}
	}
}
