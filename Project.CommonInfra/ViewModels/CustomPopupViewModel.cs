using System;
using System.Windows.Input;
using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Project.CommonInfra.BaseClass;
using Project.CommonInfra.Models;

namespace Project.CommonInfra.ViewModels
{
	public class CustomPopupViewModel : BindableBase, IInteractionRequestAware
	{
		#region Commands..
		public ICommand OkCommand { get; set; }
		public ICommand NoCommand { get; set; }
		public ICommand CancelCommand { get; set; }
		#endregion

		#region Properties..
		private string message;
		public string Message
		{
			get { return message; }
			set
			{
				message = value;
				Notify("Message");
			}
		}

		private PopupNotification notification;
		public INotification Notification
		{
			get
			{
				return this.notification;
			}
			set
			{
				if (value is PopupNotification)
				{
					this.notification = value as PopupNotification;
					Message = this.notification.Message;
					Notify("Notification");
				}
			}
		}

		public Action FinishInteraction { get; set; }
		#endregion

		#region Constructor
		public CustomPopupViewModel()
		{
			OkCommand = new DelegateCommand(OkCommandHandler);
			NoCommand = new DelegateCommand(NoCommandHandler);
			CancelCommand = new DelegateCommand(CancelCommandHandler);
		}

		#endregion

		#region Command Handler..
		private void CancelCommandHandler()
		{
			if (this.notification != null)
			{
				this.notification.Confirmed = true;
			}
			this.FinishInteraction();
		}

		private void NoCommandHandler()
		{
			if (this.notification != null)
			{
				this.notification.Confirmed = true;
			}
			this.FinishInteraction();
		}

		private void OkCommandHandler()
		{
			if (this.notification != null)
			{
				this.notification.Confirmed = true;
			}
			this.FinishInteraction();
		}
		#endregion

		
	}
}
