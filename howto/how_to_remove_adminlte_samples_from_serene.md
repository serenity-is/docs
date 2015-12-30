# How To: Remove AdminLTE Samples From Serene

Serene has a *Theme Samples* navigation section which contains sample pages from AdminLTE. You should remove these pages before publishing.

Open *MyProject.Web/Modules/Common/Navigation/NavigationItems.cs* and remove lines containing *Theme Samples*.

Remove folder *MyProject.Web/Modules/AdminLTE*.

REBUILD solution and then transform all templates.