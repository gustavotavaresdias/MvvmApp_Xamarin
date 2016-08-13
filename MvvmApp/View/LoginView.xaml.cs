using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace View
{
	public partial class LoginView : ContentPage
	{
		public LoginView ()
		{
			InitializeComponent();
			this.BindingContext = new ViewModels.LoginViewModel();
		}
	}
}

