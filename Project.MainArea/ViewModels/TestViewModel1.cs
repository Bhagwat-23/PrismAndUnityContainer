using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Project.CommonInfra.BaseClass;
using Project.CommonInfra.Models;
using Project.MainArea.Interfaces;
using System;
using System.Windows;
using System.Windows.Input;

namespace Project.MainArea.ViewModels
{
	public class TestViewModel1:BindableBase, ITestViewModel1
	{
		#region Variables/Types
		public PopupNotification popupNotification;
		#endregion

		#region Commands
		public ICommand ClickHereCommand { get; set; }
		#endregion

		#region Properties...
		public InteractionRequest<PopupNotification> PopupNotificationRequest { get; set; }

		private string receivedData;
		public string ReceivedData
		{
			get { return receivedData; }
			set { receivedData = value;
				Notify("ReceivedData");
			}
		}

		#endregion

		#region Constructor
		public TestViewModel1()
		{
			ClickHereCommand = new DelegateCommand<object>(ClickHereCommandHandler, CanExecuteClickHereCommand);
			PopupNotificationRequest = new InteractionRequest<PopupNotification>();
		}

		private void ClickHereCommandHandler(object obj)
		{
			popupNotification = new PopupNotification();
			popupNotification.Message = "You Clicked Test View 1 Button. Thankyou!!!";
			Application.Current.Dispatcher.Invoke(() =>
			{
				this.PopupNotificationRequest.Raise(popupNotification, returned =>
				{
					if (returned.Confirmed)
					{
						//Perform some action..
					}
				});
			});
		}

		private bool CanExecuteClickHereCommand(object arg)
		{
			return true;
		}
		#endregion


	}
}
