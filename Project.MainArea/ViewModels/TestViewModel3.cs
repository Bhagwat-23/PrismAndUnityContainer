using Microsoft.Practices.ServiceLocation;
using Prism.Commands;
using Project.CommonInfra.BaseClass;
using Project.MainArea.Interfaces;
using System.Windows.Input;

namespace Project.MainArea.ViewModels
{
	public class TestViewModel3:BindableBase, ITestViewModel3
	{
		#region Private Properties
		private string inputData;
		public string InputData
		{
			get { return inputData; }
			set
			{
				inputData = value;
				Notify("InputData");
			}
		}

		#endregion

		#region Commands
		public ICommand SendDataCommand { get; set; }
		#endregion

		#region Constructor
		public TestViewModel3()
		{
			SendDataCommand = new DelegateCommand<object>(SendDataCommandHandler, CanExecuteSendDataCommand);
		}
		#endregion

		#region Send Data Command Handler
		private void SendDataCommandHandler(object obj)
		{
			if (!string.IsNullOrEmpty(InputData))
			{
				var testVM1 = ServiceLocator.Current.GetInstance<TestViewModel1>();
				testVM1.ReceivedData = InputData;
			}
		}

		private bool CanExecuteSendDataCommand(object arg)
		{
			return true;
		}
		#endregion
	}
}
