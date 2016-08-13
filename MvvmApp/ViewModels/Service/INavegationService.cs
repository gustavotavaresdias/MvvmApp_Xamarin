using System;
using System.Threading.Tasks;

namespace ViewModels.Service
{
	public interface INavegationService
	{
		Task NavegateToLogin();
		Task NavegateToRegister();
		Task NavegateToMain();

	}
}

