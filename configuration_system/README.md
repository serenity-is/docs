# 配置系统

.NET 应用程序通常在 app.config（桌面应用程序）或 web.config（web应用程序）文件保存配置。

虽然，在 Web 应用程序用文件存储配置很普遍，但有时也需要在数据库表中存储一些配置，使其可用于网站群中的所有服务器，且只须在一个位置设置。

就像 IsolatedStorage 有应用程序（Application）、机器（Machine）、用户（User）等作用域，配置设置可能有不同的作用域：

- Application - 运行 Web 应用程序的所有服务器之间共享
- Server - 只应用于当前服务器
- User - 只应用于当前用户

还有举出更多的例子。

如果你只有一台服务器，*Application* 和 *Server* 可以存储在 web.confg 文件，但是在网站群的结构下，Application 设置应存储在所有服务器可访问的位置（数据库或共享的文件夹）。

用户设置通常与用户 ID 一道存储在数据库中。

Serenity 提供了一个可扩展的配置系统。


