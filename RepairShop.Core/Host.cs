using System;
using Xamarin.Forms;

namespace RepairShop.Core
{
	public abstract class Host : Application, IHost
	{
		protected override void OnStart()
		{
			base.OnStart();
		}
		protected override void OnSleep()
		{
			base.OnSleep();
		}

		protected override void OnResume()
		{
			base.OnResume();
		}

		public void RunController(Type controllerType)
		{
			throw new NotImplementedException();
		}

		protected abstract void OnControllerStopped();
		protected abstract void OnControllerExecuted();
		protected abstract void OnCurrentControllerChanged();

		public void StopController(Type controllerType)
		{
			throw new NotImplementedException();
		}

		public void PublishMessage(object subject, object content)
		{
			throw new NotImplementedException();
		}

		public IController CurrentController => throw new NotImplementedException();
	}
}
