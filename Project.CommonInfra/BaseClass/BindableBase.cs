using System.ComponentModel;

namespace Project.CommonInfra.BaseClass
{
	public class BindableBase: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public virtual void Notify(string propertyName)
		{
			PropertyChangedEventHandler Handler = this.PropertyChanged;
			if (Handler != null)
			{
				Handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
