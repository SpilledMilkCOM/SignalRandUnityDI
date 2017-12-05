using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using SignalRandUnityDI.Models;

namespace SignalRandUnityDI.Hubs
{
	/// <summary>
	/// This class contains the methods for the client to call AND the server to call ALL the connected clients.
	/// NOTE: If there are only callbacks from the servier to the client (browser) then this class may be empty.
	/// </summary>
	[HubName("IndexHub")]  // If this is not named, then camel casing (statusHub) will be used in the JavaScript

	public class IndexHub : Hub
	{
		private readonly IIndexViewModel _indexViewModel;

		// For some good IoC and DI reference:
		// https://docs.microsoft.com/en-us/aspnet/signalr/overview/advanced/dependency-injection

		public IndexHub(IIndexViewModel viewModel)
		{
			// Any data can be injected.  Wanted to keep this simple so stick with the ONE ViewModel.

			_indexViewModel = viewModel;
		}

		[HubMethodName("AddToClickTotal")]
		public void AddToClickTotal()
		{
			_indexViewModel.AddToTotal();

			Clients.All.refreshClickCount(_indexViewModel.ClickTotal.ToString());
		}
	}
}