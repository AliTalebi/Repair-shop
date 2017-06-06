using System;

namespace RepairShop.Core
{
	public interface IHost
	{
		IController CurrentController { get; }
		void RunController(Type controllerType);
		void StopController(Type controllerType);
		void PublishMessage(object subject, object content);
	}
}