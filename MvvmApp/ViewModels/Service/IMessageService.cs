using System;
using System.Threading.Tasks;

namespace ViewModels.Service
{
	public interface IMessageService
	{
		Task ShowAsync(string message);
	}

}

