namespace SignalRandUnityDI.Models
{
	public interface IIndexViewModel
	{
		int ClickTotal { get; }

		void AddToTotal();
	}
}