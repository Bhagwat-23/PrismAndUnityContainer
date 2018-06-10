using Prism.Interactivity.InteractionRequest;

namespace Project.CommonInfra.Models
{
	public class PopupNotification: Confirmation
	{
		public PopupNotification()
		{
			Message = string.Empty;
		}

		public string Message { get; set; }
	}
}
