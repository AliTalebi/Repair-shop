namespace RepairShop.Resource
{
	public static class ResourceManager
	{
		public static void AddResource(string key, object value) { }
		public static void AddResource<TValue>(string key, TValue value) { }
		public static void AddResource<TKey, TValue>(TKey key, TValue value) { }
		public static object FindResource(string key) { return null; }
		public static TValue FindResource<TValue>(string key) { return default(TValue); }
		public static TValue FindResource<TKey, TValue>(TKey key) { return default(TValue); }
	}
}
