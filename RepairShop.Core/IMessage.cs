namespace RepairShop.Core
{
	public interface IMessage : IMessage<object>
	{
	}

	public interface IMessage<TContent>
	{
		TContent Content { get; set; }
	}
}
