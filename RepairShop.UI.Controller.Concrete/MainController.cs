using RepairShop.Core;
using RepairShop.UI.View;
using RepairShop.UI.ViewModel;

namespace RepairShop.UI.Controller.Concrete
{
	public sealed class MainController : UIController, IMainController
	{
		public MainController(IView viewCore, IViewModel viewModelCore)
			: base(viewCore, viewModelCore)
		{
			ViewCore = base.ViewCore as IMainView;
			ViewModelCore = base.ViewModelCore as IMainViewModel;
		}

		public new IMainView ViewCore { get; private set; }
		public new IMainViewModel ViewModelCore { get; private set; }

		protected override void Destroy()
		{
			base.Destroy();

			ViewModelCore = null;
			ViewCore = null;
		}
	}
}
