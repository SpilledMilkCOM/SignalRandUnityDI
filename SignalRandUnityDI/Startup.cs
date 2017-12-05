using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;
using SignalRandUnityDI.Hubs;
using SignalRandUnityDI.Models;
using Unity;

[assembly: OwinStartup(typeof(SignalRandUnityDI.Startup))]
namespace SignalRandUnityDI
{
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			// https://docs.microsoft.com/en-us/aspnet/signalr/overview/advanced/dependency-injection

			// TODO: See if I can set this up in the UnityConfig class.

			// Setup SignalR's IoC registration of the new constructor.
			// (Casting to a UnityContainer was easier than trying to use the IUnityContainer interface)     :(

			var viewModel = ((UnityContainer)UnityConfig.Container).Resolve<IIndexViewModel>();

			// It's pretty easy injecting an object into the Hub.
			// This does not illustrate resolving a hub from Unity, typically this is done through the GlobalHost.ConnectionManager.

			GlobalHost.DependencyResolver.Register(typeof(IndexHub), () => new IndexHub(viewModel));

			// Any connection or hub wire up and configuration should go here
			// NOTE: If you forget this they your JavaScript connection will be null and you will see warnings for path references as well.

			app.MapSignalR();
		}
	}
}