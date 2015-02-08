# Configuration System

.NET applications usually stores their configuration in app.config (desktop) or web.config (web) files.

Though, its common practice to store configuration in such files for web applications, sometimes it might be required to store some configuration in a database table to make it available to all servers in a web farm, and set it from one location.

Just like IsolatedStorage has scopes like Application, Machine, User etc, a configuration setting might have different scopes:

- Application - Shared between all servers that runs a web application
- Server - Applies to current server only
- User - Applies to current user only

Number of samples can be increased.

If you have just one server, *Application* and *Server* scopes can be stored in web.config file, but in a web farm setup, Application settings should be stored in a location accessible from all servers (database or shared folder).

User settings are usually stored in database along with a User ID.

Serenity provides an extensible configuration system.


