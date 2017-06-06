namespace RepairShop.Core
{
	public static class EventNotifier
	{
		public static void PublishMessage(IMessage message) { }
		public static void RegisterListener(IListener listener) { }
		public static void UnRegisterListener(IListener listener) { }
	}
}
