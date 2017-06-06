namespace RepairShop.Core
{
	public interface INotifier
	{
		void NotifyMessage(IMessage message);
		void RegisterListener(IListener listener);
		void UnRegisterListener(IListener listener);
	}
}
