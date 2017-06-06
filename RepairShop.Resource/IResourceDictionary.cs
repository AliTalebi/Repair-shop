namespace RepairShop.Resource
{
	public interface IResourceDictionary
	{
		void AddResource(string key, object value);
		void AddResource<TValue>(string key, TValue value);
		void AddResource<TKey, TValue>(TKey key, TValue value);

		object FindResource(string key);
		TValue FindResource<TValue>(string key);
		TValue FindResource<TKey, TValue>(TKey key);
	}
}
