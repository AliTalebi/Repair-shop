using System;

namespace RepairShop.Core
{
	public abstract class ControllerBase : IController
	{
		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public void Run()
		{
			Initialize();
		}

		public void Stop()
		{
			Destroy();
		}

		protected abstract void Destroy();
		protected abstract void Initialize();
	}
}