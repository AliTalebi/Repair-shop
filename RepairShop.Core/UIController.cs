using RepairShop.Core.Commanding;

namespace RepairShop.Core
{
	public abstract class UIController : ControllerBase, IUIController
	{
		protected UIController(IView viewCore, IViewModel viewModelCore)
		{
			ViewCore = viewCore;
			ViewModelCore = viewModelCore;
		}

		public IView ViewCore { get; private set; }
		public IViewModel ViewModelCore { get; private set; }

		protected override void Initialize()
		{
			ViewCore.BindingContext = ViewModelCore;

			ViewModelCore.LoadCommand = new RelayCommand(action => Load());
			ViewModelCore.UnloadCommand = new RelayCommand(action => Destroy());
		}

		protected virtual void Load() { }

		protected override void Destroy()
		{
			ViewModelCore = null;
			ViewCore = null;
		}
	}
}