using RepairShop.Core;
using Xamarin.Forms;

namespace RepairShop.UI
{
	public class BasePage : ContentPage, IView
	{
		public new IViewModel BindingContext
		{
			get { return base.BindingContext as IViewModel; }
			set { base.BindingContext = value; }
		}

		public void Dispose()
		{
			
		}
	}
}