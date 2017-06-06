using RepairShop.Resource;
using System;

namespace RepairShop.Container
{
	public static class IocContainer
	{
		static IocContainer()
		{
			_currentContainer = ResourceManager.FindResource<IContainer>("container");
		}

		private static IContainer _currentContainer;

		public static void RegisterType(Type servicetype, Type implementationType)
		{
			_currentContainer.RegisterType(servicetype, implementationType);
		}

		public static void RegisterType<TService, TImplementation>(TImplementation implementation) where TImplementation : class, TService
		{
			_currentContainer.RegisterType<TService, TImplementation>(implementation);
		}
		public static void RegisterInstane(Type serviceType, object value)
		{
			_currentContainer.RegisterInstane(serviceType, value);
		}

		public static void RegisterInstance<TService>(TService value) where TService : class
		{
			_currentContainer.RegisterInstance(value);
		}
		public static object Resolve(Type serviceType)
		{
			return _currentContainer.Resolve(serviceType);
		}
		public static TService Resolve<TService>() where TService : class
		{
			return _currentContainer.Resolve<TService>();
		}
	}
}
