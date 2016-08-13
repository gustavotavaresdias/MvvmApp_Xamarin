using System;

using Xamarin.Forms;

namespace MvvmApp
{
	public class App : Application
	{
		public App ()
		{
			DependencyService.Register<ViewModels.Service.IMessageService,View.Service.MessageService> ();
			DependencyService.Register<ViewModels.Service.INavegationService,View.Service.NavegationService> ();

			// The root page of your application
			MainPage = new NavigationPage(new View.LoginView());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

