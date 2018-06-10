using Prism.Commands;
using Project.Header.Interfaces;
using System;
using System.Windows.Input;

namespace Project.Header.ViewModels
{
	public class HeaderViewModel:IHeaderViewModel
	{
		#region Commands
		public ICommand OpenCommand { get; set; }
		public ICommand ExitCommand { get; set; }
		public ICommand CopyCommand { get; set; }
		public ICommand PasteCommand { get; set; }
		public ICommand AboutCommand { get; set; }
		public ICommand FeedbacksCommand { get; set; }
		#endregion

		#region Constructor
		public HeaderViewModel()
		{
			OpenCommand = new DelegateCommand<object>(OpenCommandHandler, CanExecuteOpenCommand);
			ExitCommand = new DelegateCommand<object>(ExitCommandHandler, CanExecuteExitCommand);
			CopyCommand = new DelegateCommand<object>(CopyCommandHandler, CanExecuteCopyCommand);
			PasteCommand = new DelegateCommand<object>(PasteCommandHandler, CanExecutePasteCommand);
			AboutCommand = new DelegateCommand<object>(AboutCommandHandler, CanExecuteAboutCommand);
			FeedbacksCommand = new DelegateCommand<object>(FeedbacksCommandHandler, CanExecuteFeedbacksCommand);
		}
		#endregion

		#region OpenCommand Handler
		private void OpenCommandHandler(object obj)
		{
			
		}

		private bool CanExecuteOpenCommand(object arg)
		{
			return true;
		}
		#endregion

		#region ExitCommandHandler
		private void ExitCommandHandler(object obj)
		{
			
		}

		private bool CanExecuteExitCommand(object arg)
		{
			return true;
		}
		#endregion

		#region CopyCommand Handler
		private void CopyCommandHandler(object obj)
		{

		}

		private bool CanExecuteCopyCommand(object arg)
		{
			return true;
		}
		#endregion

		#region PasteCommand Handler
		private void PasteCommandHandler(object obj)
		{

		}

		private bool CanExecutePasteCommand(object arg)
		{
			return true;
		}
		#endregion

		#region AboutCommand Handler
		private void AboutCommandHandler(object obj)
		{

		}

		private bool CanExecuteAboutCommand(object arg)
		{
			return true;
		}
		#endregion

		#region FeedbacksCommand Handler
		private void FeedbacksCommandHandler(object obj)
		{
			
		}

		private bool CanExecuteFeedbacksCommand(object arg)
		{
			return true;
		}
		#endregion

	}
}
