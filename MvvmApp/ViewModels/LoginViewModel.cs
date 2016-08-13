using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace ViewModels
{
	public class LoginViewModel: ViewModels.ViewModelBase
	{
		string email;
		string password;

		public string Email {
			get {
				return email;
			}
			set {
				email = value;
				this.Notify("Email");
			}
		}

		public string Password {
			get {
				return password;
			}
			set {
				password = value;
				this.Notify("Password");
			}
		}

		public ICommand LoginCommand {
			get;
			set;
		}

		public ICommand RegisterCommand {
			get;
			set;
		}

		private readonly Service.IMessageService _messageService;
		private readonly Service.INavegationService _navegationService;


		public LoginViewModel()
		{
			this.LoginCommand = new Command(this.Login);
			this.RegisterCommand = new Command(this.Register);

			this._messageService = DependencyService.Get<Service.IMessageService> ();
			this._navegationService = DependencyService.Get<Service.INavegationService> ();

		}

		private async void Login()
		{
			if (this.Email == "adm" && this.Password == "123") {
				//Display main view
				await this._navegationService.NavegateToMain();

			} else {
				await this._messageService.ShowAsync("Email and/or Password invalid...");
			}

		}

		private async void Register()
		{
			await this._navegationService.NavegateToRegister();	
		}
	}
}

