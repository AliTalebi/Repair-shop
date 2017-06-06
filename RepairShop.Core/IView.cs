using System;

namespace RepairShop.Core
{
	public interface IView : IDisposable
	{
		IViewModel BindingContext { get; set; }
	}
}