using Prism.Commands;
using Prism.Events;
using Project.CommonInfra.BaseClass;
using Project.CommonInfra.Events;
using Project.MainArea.Interfaces;
using System;
using System.Windows.Input;

namespace Project.MainArea.ViewModels
{
	public class TestViewModel2:BindableBase, ITestViewModel2
	{
		#region Variable/Types/Fields
		public IEventAggregator _eventAgg;
		#endregion

		#region Private Properties
		private string inputData;
		public string InputData
		{
			get { return inputData; }
			set { inputData = value;
				Notify("InputData");
			}
		}

		#endregion

		#region Commands
		public ICommand SendDataCommand { get; set; }
		#endregion

		#region Constructor
		public TestViewModel2()
		{
			_eventAgg = EventService.Instance.EventAggregator;
			SendDataCommand = new DelegateCommand<object>(SendDataCommandHandler, CanExecuteSendDataCommand);
		}


		#endregion

		#region Send Data Command Handler
		private void SendDataCommandHandler(object obj)
		{
			if (!string.IsNullOrEmpty(InputData))
			{
				_eventAgg.GetEvent<SendDataToOtherModule>().Publish(InputData);
			}
		}

		private bool CanExecuteSendDataCommand(object arg)
		{
			return true;
		}
		#endregion
	}
}
