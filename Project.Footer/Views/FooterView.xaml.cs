using Microsoft.Practices.ServiceLocation;
using Project.Footer.Interfaces;
using System.Windows.Controls;

namespace Project.Footer.Views
{
	/// <summary>
	/// Interaction logic for FooterView.xaml
	/// </summary>
	public partial class FooterView : UserControl
	{
		public FooterView()
		{
			InitializeComponent();
			this.DataContext = ServiceLocator.Current.GetInstance<IFooterViewModel>();
		}
	}
}
