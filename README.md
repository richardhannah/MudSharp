# MudSharp
MudSharp is a simple MUD (Multi-User Dungeon) that uses the .NET Core framework. Like most MUDs, MudSharp can be accessed with a simple TELNET client connected to a configurable port.

## Project Design
The `MudSharp` Visual Studio solution is broken into several projects.
* `MudSharp.Admin` - Administrative tools and utilities.
* `MudSharp.Admin.Web` - Web front-end for administrative tools.
* `MudSharp.Data` - Data models and repository abstractions.
* `MudSharp.Server` - Core components of running the MudSharp server.
* `MudSharp.World` - Components relating to the game world.
* `MudSharp.Tests` - Unit tests.

The goal is to make MudSharp as portable as possible so the use of NuGet packages and third-party libraries is kept to a minimum.

### Admin
The administrative tools in this project are used in-game as well as via the web interface. The command processor in the `MudSharp.Server` project references the methods and classes in this assembly. The `MudSharp.Admin.Web` project uses the methods and classes from the admin assembly by way of a Web API. Access to the API is authorized by the `IAuthProvider` implementation set in the server configuration.

### Data
EF Core is the ORM of choice for the MudSharp solution. This assumes that SQL Server is the data store of choice, however an implementation of `IPlayerRepository` (for example) can be created to use MongoDB, MySQL, or even flat text files. The game server doesn't care what data store is being used but there is flexibility to change data stores.

### Server
This is the core of the MudSharp project. This contains all socket handling and core game mechanics such as the command processor and authentication provider.

### World
If the `Server` is the core of the MudSharp project, `World` is its heart. This controls all aspects of the game world from picking up an item, to combat, to weather, to NPC AI and so on. Without this project MudSharp would just be a chat room.


## About the Author
Craig Mackles is an avid gamer and has been playing MUDs since 1998 and writing code for them for a number of years. Armageddon and Distant Lands were his choice worlds, also having been a code contibutor to Distant Lands for a few years. For info on Craig's professional career as it relates to development, check out his [LinkedIn profile](https://www.linkedin.com/in/cmackles).