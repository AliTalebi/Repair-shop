using Xamarin.Forms;

namespace RepairShop.Resource
{
	public static class ResourceManager
	{
		private static IResourceDictionary _currentResourceDictionary = null;
		static ResourceManager()
		{
			if (Application.Current.Resources.ContainsKey("resourceManager"))
				_currentResourceDictionary = (IResourceDictionary)Application.Current.Resources["resourceManager"];
		}

		public static void AddResource(string key, object value)
		{
			_currentResourceDictionary.AddResource(key, value);
		}
		public static void AddResource<TValue>(string key, TValue value)
		{
			_currentResourceDictionary.AddResource(key, value);
		}
		public static void AddResource<TKey, TValue>(TKey key, TValue value)
		{
			_currentResourceDictionary.AddResource(key, value);
		}
		public static object FindResource(string key)
		{
			return _currentResourceDictionary.FindResource(key);
		}
		public static TValue FindResource<TValue>(string key)
		{
			return _currentResourceDictionary.FindResource<TValue>(key);
		}
		public static TValue FindResource<TKey, TValue>(TKey key)
		{
			return _currentResourceDictionary.FindResource<TKey, TValue>(key);
		}
	}
}
