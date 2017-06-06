using RepairShop.Core;
using RepairShop.UI.View;
using RepairShop.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairShop.UI.Controller
{
	public interface IMainController : IUIController
	{
		new IMainView ViewCore { get; }
		new IMainViewModel ViewModelCore { get; }
	}
}
