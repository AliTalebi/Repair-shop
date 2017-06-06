
namespace RepairShop
{
	public partial class App : Core.Host
	{
		public App()
		{
			InitializeComponent();

			base.MainPage = new Views.MainPage();
		}
	}
}
