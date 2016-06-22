# 前言

## 什么是Serenity平台

Serenity 是建立在开源技术上的ASP.NET MVC/Javascript应用程序平台。
Serenity is an ASP.NET MVC / Javascript application platform which has been built on open source technologies.

它旨在使开发变得更简单，同时避免重复代码，减少花在重复任务的时间并提供最佳的软件设计实践，从而降低了维护成本。
It aims to make development easier while reducing maintenance costs by avoiding boiler-plate code, reducing the time spent on repetitive tasks and applying the best software design practices.


##谁适合使用该平台Who/What This Platform Is For

Serenity 最适合应用于有大量数据输入的表单业务应用程序或者面向公众的后台管理网站，它的功能同样也适用于其他类型的Web应用程序。
Serenity is best suited to business applications with many data entry forms or administrative interface of public facing web sites. It's features can be useful for other kinds of web applications as well.


## 在哪里可寻找到相关信息Where To Look For Information

在阅读本指南和其教程以后, 跟随以下资源可获取有关Serenity的详细信息。
After reading this guide and its tutorials, follow resources below for more information about Serenity.

<dl>

  <dt>Github Repository:</dt>
  <dd><a href='https://github.com/volkanceylan/Serenity'>https://github.com/volkanceylan/Serenity</a></dd>

  <dt>Issues / Questions</dt>
  <dd><a href='https://github.com/volkanceylan/Serenity/issues'>https://github.com/volkanceylan/Serenity/issues</a></dd>
  
  <dt>Change Log:</dt>
  <dd><a href='https://github.com/volkanceylan/Serenity/blob/master/CHANGELOG.md'>https://github.com/volkanceylan/Serenity/blob/master/CHANGELOG.md</a></dd>

  <dt>Serene Application Template:</dt>
  <dd><a href='https://visualstudiogallery.msdn.microsoft.com/559ec6fc-feef-4077-b6d5-5a99408a6681'>https://visualstudiogallery.msdn.microsoft.com/559ec6fc-feef-4077-b6d5-5a99408a6681</a></dd>

  <dt>Tutorial / Sample Source Code:</dt>
  <dd><a href='https://github.com/volkanceylan/Serenity-Tutorials'>https://github.com/volkanceylan/Serenity-Tutorials</a></dd>


</dl>


## 名字有什么含义What's In The Name

Serenity 在字典中解释为 *平和*，*舒适*，*沉着*
Serenity has dictionary meanings of *peace*, *comfort* and *calmness*.

这正是我们使用Serenity努力实现的目标，我们希望你在安装并使用Serenity之后，你会觉得这太……
This is what we are trying to achieve with Serenity. We hope that after installing and using it you will feel this way too...

## 它提供了哪些功能What Features It Provides

* 模块化、 基于服务的 web 应用程序模型 A modular, service based web application model
* 为SQL表生成初始服务/用户界面的代码生成器Code generator to produce initial services / user interface code for an SQL table
* 服务器上的基于T4模板生成智能感知/编译时验证的引用脚本部件T4 based code generation on server to reference script widgets with intellisense / compile time validation
* 基于T4模板生成从脚本端调用AJAX服务的同时提供编译时类型安全和智能感知 based code generation to provide compile time type safety and intellisense while calling AJAX services from script side.
* 基于属性（Attribute）的表单定义系统（在服务器端用一个简单的C#类编写用户界面）An attribute based form definition system (prepare UI in server side with a simple C# class)
* 通过表单定义实现全自动无缝数据绑定（表单 <-> 实体 <-> 服务）Automatic seamless data-binding through form definitions (form <-> entity <-> service).
* 缓存助手（本地/分布式）Caching Helpers (Local / Distributed)
* 自动缓存验证Automatic cache validation
* 配置系统（独立的存储介质。可以数据库，文件等形式保存设置）Configuration System (storage medium independent. store settings in database, file, whatever...)
* 简单的日志记录Simple Logging
* 报表（报表只提供数据，不依赖于渲染形式，类似于MVC）Reporting (reports just provide data, has no dependency on rendering, similar to MVC)
* 脚本引用，压缩（使用Node / UglifyJS / CleanCSS）和内容版本化（不再需要额外按F5/清除浏览器缓存）Script bundling, minification (making use of Node / UglifyJS / CleanCSS) and content versioning (no more F5 / clear browser cache)
* 流式SQL生成器（SELECT/INSERT/UPDATE/DELETE）Fluent SQL Builder (SELECT/INSERT/UPDATE/DELETE)
* 微型ORM（集成Dapper） Micro ORM (also Dapper is integrated)
* 可定制的类REST服务，用于实体类的重用信息并做自动验证Customizable handlers for REST like services that work by reusing information in entity classes and do automatic validation.
* 基于属性（Attribute）的导航菜单Attribute based navigation menu
* 用户界面本地化（本地化文本可存储在json文件，嵌入的资源文件，数据库，内存等）UI Localization (store localized texts in json files, embedded resource, database, in memory class, anywhere)
* 数据本地化（使用扩展表机制帮助本地化，甚至支持用户输入，如查找表）Data Localization (using an extension table mechanism helps to localize even data entered by users,  like lookup tables)
* 脚本插件系统（灵感来自jQueryUI，但更适合C#代码）Script widget system (inspired by jQueryUI but more suitable for C# code)
* 客户端和服务端验证（基于jQuery验证插件，但可分离依赖）Client side and server side validation (based on jQuery validate plugin, but abstracts dependency)
* 操作日志（在CDC中不可用）Audit logging (where CDC is not available)
* 基于数据系统集成测试System for data based integration tests
* 动态脚本Dynamic scripts
* 脚本端模板Script side templates

## 背景Background

> 这部分原本是写在CodeProject上的一编介绍Serenity的文章，由于这篇文章是一篇宣传代码的广告却没有包含代码而被拒绝。他们没有错，因为我在本指南中做了一个视频教程链接，而不是复制粘贴代码。
This part was originally written for a CodeProject article as an introduction to Serenity. The article was rejected with the reason that it didn't contain code but was an ad for code. They were right, as i did put a link to Movie tutorial in this guide, instead of copy pasting code. 

> 如果你不喜欢了解历史，您可以毫无影响地跳到下一章 :) You can safely skip to next chapter, if you don't like reading history :)

我们开发人员每天都在解决一系列相同的问题，就像大学生做习题书一样工作。We, developers, are all solving the same sets of problems everyday. Just like college students working on their problem books.

即使我们知道他们已经有合适的解决方案，但依避免不了面对相同的工作。实际上，它可以帮助提高我们的技术，你总不能在不犯错误中学习吧？但我们应该学会如何界定培训和浪费时间。Even though we know that they are already solved and have answers somewhere, it doesn't stop us from working on them. Actually, it helps us improve our skills, and hey you can't learn without making some mistakes, can you? But we should learn where to draw a line between training and wasting time.

当你开始一个新的项目时，你需要作出几个决定：使用哪个平台，如何组织架构及使用哪些类库。今天，你可以在每一次的话题中有如此多的选择，是的，具有一些选项是好事，只要这些选项是在有限的范围内，因为我们的时间不是无限的。When you start a new project, you have several decisions to make on platform, architecture and set of libraries. Today you have so many choices for every single topic. Yes, having some options is good, as long as they are limited, as our time is not infinite. 

下面是关于*Serenity*的简短历史：Serenity旨在处理你业务应用程序中的常见任务，并让你腾出宝贵的时间专注于特定应用程序域的功能。Here is a short history about *Serenity*, which aims to handle common tasks you deal with business applications, and let you spare your precious time focusing on features specific to your application domain.

我的第一份正式的关于Web技术的工作是在设计国家特定Web站点的一些大牌行业，如汽车公司（顺便感慨一下，我们在谈论的是十多年以前的往事了，时光流逝的真快）。My first real job in web technologies was in a web agency designing country-specific web sites of some of big names in industry, e.g. automative companies (btw, we are talking about 10+ years past, time flows fast).

As I had a software architect career in desktop applications before I signed there, I was asked to design a ASP.NET WebForms platform for them. They explained that they have many shared modules, like news, galleries, navigation at each site, but as requirements are different, they had to copy/paste then customize code specific to every customer. When they wanted to add a common feature, they had to repeat it for every site.

At that time, there weren't so many CMS systems in market, and I designed one for them, without even knowing it was called a CMS. For me, it wasn't perfect, not even good enough as I just had a few weeks to design it. But they were very pleased with the result, as it took development of new sites down to days/weeks from months. Also resulting code was more manageable than before.

Learning from that experience, and mistakes, that poor-mans CMS became something better. Later, that platform is evolved to be used by applications in varying domains, like a help-desk system, a CRM, ERP, personnel management, electronic document management, university student information system and more.

To be compatible with different kinds of applications, systems and even legacy databases, it had to be flexible and went through many architectural changes.

Now it takes us to Serenity. Even though it is an open source project for about 2 years, it has a much older background. But it is also young, energetic, and is not afraid of change. It can adapt to new technologies as they became popular and stable. This might mean breaking changes from time to time, but we strive to keep them to a minimum without being paranoid about backwards compability.

