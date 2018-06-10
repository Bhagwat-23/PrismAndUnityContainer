using Project.CommonInfra.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace Project.CommonInfra.Views
{
	/// <summary>
	/// Interaction logic for CustomPopupView.xaml
	/// </summary>
	public partial class CustomPopupView : UserControl
	{
		public CustomPopupView()
		{
			InitializeComponent();
			this.DataContext = new CustomPopupViewModel();
			Loaded += CustomPopupView_Loaded;
		}

		private void CustomPopupView_Loaded(object sender, System.Windows.RoutedEventArgs e)
		{
			var parentWindow = this.Parent as Window;
			if (parentWindow != null)
			{
				//parentWindow.Measure(parentWindow.n);
				parentWindow.ResizeMode = ResizeMode.NoResize;

			}
		}
	}
}
