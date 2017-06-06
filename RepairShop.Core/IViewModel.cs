using System;
using System.Windows.Input;

namespace RepairShop.Core
{
	public interface IViewModel : IDisposable
	{
		string Title { get; set; }
		ICommand LoadCommand { get; set; }
		ICommand UnloadCommand { get; set; }
	}
}