namespace RepairShop.Core
{
	public interface IUIController : IController
	{
		IView ViewCore { get; }
		IViewModel ViewModelCore { get; }
	}
}