using Microsoft.Practices.ServiceLocation;
using Project.Header.Interfaces;
using System.Windows.Controls;

namespace Project.Header.Views
{
	/// <summary>
	/// Interaction logic for HeaderView.xaml
	/// </summary>
	public partial class HeaderView : UserControl
	{
		public HeaderView()
		{
			InitializeComponent();
			this.DataContext = ServiceLocator.Current.GetInstance<IHeaderViewModel>();
		}
	}
}
