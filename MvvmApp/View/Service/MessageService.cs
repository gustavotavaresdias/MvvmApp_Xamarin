using System;

namespace View.Service
{
	public class MessageService: ViewModels.Service.IMessageService
	{
		#region IMessageService implementation

		public async System.Threading.Tasks.Task ShowAsync (string message)
		{
			await MvvmApp.App.Current.MainPage.DisplayAlert ("Alert", message, "ok");
		}

		#endregion

		public MessageService ()
		{
		}
	}
}

