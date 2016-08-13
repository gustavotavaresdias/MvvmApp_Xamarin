using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ViewModels
{
	public class MainViewModel : ViewModelBase
	{
		public ICommand RegisterCommand {
			get;
			set;
		}

		private readonly Service.IMessageService _messageService;
		private readonly Service.INavegationService _navegationService;

		public MainViewModel ()
		{
			this.RegisterCommand = new Command (this.Register);

			this._messageService = DependencyService.Get<Service.IMessageService> ();
			this._navegationService = DependencyService.Get<Service.INavegationService> ();

		}

		private async void Register ()
		{
			await this._messageService.ShowAsync ("Going to Register View...");
			await this._navegationService.NavegateToRegister ();	
		}
	}
}
	