using Microsoft.Practices.ServiceLocation;
using Project.MainArea.Interfaces;
using System.Windows.Controls;

namespace Project.MainArea.Views
{
	/// <summary>
	/// Interaction logic for TestView2.xaml
	/// </summary>
	public partial class TestView2 : UserControl
	{
		public TestView2()
		{
			InitializeComponent();
			this.DataContext = ServiceLocator.Current.GetInstance<ITestViewModel2>();
		}
	}
}
