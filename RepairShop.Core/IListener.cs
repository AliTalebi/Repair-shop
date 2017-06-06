namespace RepairShop.Core
{
	public interface IListener
	{
		void ReceiveMessage(IMessage message);
	}
}