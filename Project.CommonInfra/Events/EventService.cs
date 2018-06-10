using Prism.Events;

namespace Project.CommonInfra.Events
{
	public class EventService
	{
		public EventService()
		{

		}

		private static readonly EventService _instance = new EventService();

		public static EventService Instance { get { return _instance; } }

		private IEventAggregator _eventAggregator;
		public IEventAggregator EventAggregator
		{
			get
			{
				if (_eventAggregator == null)
					_eventAggregator = new EventAggregator();
				return _eventAggregator;
			}
		}
	}
}
