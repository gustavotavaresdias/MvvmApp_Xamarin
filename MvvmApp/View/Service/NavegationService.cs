using System;

namespace View.Service
{
	public class NavegationService  : ViewModels.Service.INavegationService
	{
		#region INavegationService implementation

		public async System.Threading.Tasks.Task NavegateToLogin()
		{
			await MvvmApp.App.Current.MainPage.Navigation.PushAsync (new View.LoginView());
		}

		public async System.Threading.Tasks.Task NavegateToRegister()
		{
			await MvvmApp.App.Current.MainPage.Navigation.PushAsync (new View.RegisterView());
		}

		public async System.Threading.Tasks.Task NavegateToMain()
		{
			await MvvmApp.App.Current.MainPage.Navigation.PushAsync (new View.MainView());
		}

		#endregion

		public NavegationService ()
		{
		}
	}
}

