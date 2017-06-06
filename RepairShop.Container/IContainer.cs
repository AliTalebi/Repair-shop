using System;

namespace RepairShop.Container
{
	public interface IContainer
	{
		void RegisterType(Type servicetype, Type implementationType);
		void RegisterType<TService, TImplementation>(TImplementation implementation) where TImplementation : class, TService;
		void RegisterInstane(Type serviceType, object value);
		void RegisterInstance<TService>(TService value) where TService : class;
		object Resolve(Type serviceType);
		TService Resolve<TService>() where TService : class;
	}
}