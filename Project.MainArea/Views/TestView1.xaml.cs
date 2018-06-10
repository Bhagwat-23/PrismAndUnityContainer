using Microsoft.Practices.ServiceLocation;
using Project.MainArea.Interfaces;
using System.Windows.Controls;

namespace Project.MainArea.Views
{
	/// <summary>
	/// Interaction logic for TestView1.xaml
	/// </summary>
	public partial class TestView1 : UserControl
	{
		public TestView1()
		{
			InitializeComponent();
			this.DataContext = ServiceLocator.Current.GetInstance<ITestViewModel1>();
		}
	}
}
