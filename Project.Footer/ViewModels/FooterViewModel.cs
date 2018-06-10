using System;
using Prism.Events;
using Project.CommonInfra.BaseClass;
using Project.CommonInfra.Events;
using Project.Footer.Interfaces;

namespace Project.Footer.ViewModels
{
	public class FooterViewModel:BindableBase, IFooterViewModel
	{
		#region Variable/Types/Fields
		public IEventAggregator _eventAgg;
		#endregion

		#region Properties
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
		public FooterViewModel()
		{
			ReceivedData = "No Data received...";
			_eventAgg = EventService.Instance.EventAggregator;

			_eventAgg.GetEvent<SendDataToOtherModule>().Subscribe(ReceiveDataHandler);
		}


		#endregion

		#region Received Data handler...
		private void ReceiveDataHandler(string obj)
		{
			ReceivedData = obj;
		}
		#endregion
	}
}
