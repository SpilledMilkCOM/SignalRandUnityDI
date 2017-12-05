namespace SignalRandUnityDI.Models
{
	public class IndexViewModel : IIndexViewModel
	{
		private int _clickTotal;

		public int ClickTotal => _clickTotal;

		public void AddToTotal()
		{
			// Just so it's thread safe

			lock(this)
			{
				_clickTotal++;
			}
		}
	}
}