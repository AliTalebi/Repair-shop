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
			
		}

		public static void RegisterType<TService, TImplementation>(TImplementation implementation) where TImplementation : class, TService
		{
		}
		public static void RegisterInstane(Type serviceType, object value)
		{
		}

		public static void RegisterInstance<TService>(TService value) where TService : class
		{
		}
		public static object Resolve(Type serviceType)
		{
			return null;
		}
		public static TService Resolve<TService>() where TService : class
		{
			return null;
		}
	}
}
