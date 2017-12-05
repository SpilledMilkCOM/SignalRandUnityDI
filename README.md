# SignalR and Unity DI

#### Overview

This repository contains mostly template code that is generated from Visual Studio 2017.
The main purpose is to demonstrate an example that uses Unity as the Inversion of Control Container
and the SignalR Hub is constructed from this container and the other Unity objects can be injected
into this hub.  This does not illustrate resolving a hub from Unity, typically this is done through
the GlobalHost.ConnectionManager.

#### My Steps:
1. Create ASP .Net Web App (MVC)
2. Added this README.md to the solution items
3. **Update** all of the NuGet packages (there's about 17 to be updated)
4. Then there's **another** update after that.
5. Add Unity.Mvc from NuGet (this will bring down the needed dependencies)
6. Build and Run to make sure the libraries were downloaded correctly.
7. Created Models/IndexViewModel.cs
8. Updated UnityConfig.RegisterTypes() to add the resolution definition of the ViewModel
9. Added SignalR package through NuGet (read the README)
10. Added a hub (IndexHub)
11. Added client code to wireup the client and the hub.
12. Added the bootstrap code to initialize SignalR using Unity.