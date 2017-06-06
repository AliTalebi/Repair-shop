using RepairShop.Core;
using Xamarin.Forms.Xaml;

namespace RepairShop.UI.View.Concrete
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StartupPage : BasePage, IMainView
	{
		public StartupPage()
		{
			InitializeComponent();
		}
	}
}