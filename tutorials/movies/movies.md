
# 教程：Movie 网站 

让我们使用 Serenity 创建一些界面类似于 IMDB (IMDB: 互联网电影数据库，全称The Internet Movie Database)的网站。 

> 你可以在这里找到本教程的源代码： 

> https://github.com/volkanceylan/MovieTutorial



### 创建一个名为 *MovieTutorial* 的新项目

在 Visual Studio 中选择 文件 -> 新建项目。选择 Serene 模板，在名称中输入 *MovieTutorial* 并单击确定按钮。

在解决方案资源管理器中，你应该看到一个名称为 MovieTutorial.Web 的项目。

MovieTutorial.Web 是一个 ASP.NET MVC 应用程序，包含服务器端代码以及静态资源，如CSS文件，图片等。 

MovieTutorial.Web 项目根目录下有一个 tsconfig.json 文件，它表明该项目同时也是一个 TypeScript 项目。在 Modules/ 和 Scripts/ 目录下的所有 .ts 文件将在保存时被编译，并且它们输出的文件将合并到一个名为 MovieTutorial.Web.js 的文件，该文件位于 scripts/site/ 文件夹内。

> 请确保你已安装 TypeScript 1.8.6+ 。  
> 
> 可从  http://www.typescriptlang.org/#download-links  下载适合 Visual Studio 的最新版本。 