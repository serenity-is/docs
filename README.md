# 前言

## 什么是Serenity平台

Serenity 是建立在开源技术上的ASP.NET MVC/Javascript应用程序平台。

它旨在使开发变得更简单，同时避免重复代码，减少花在重复任务的时间并提供最佳的软件设计实践，从而降低了维护成本。


##谁适合使用该平台

Serenity 最适合应用于有大量数据输入的表单业务应用程序或者面向公众的后台管理网站，它的功能同样也适用于其他类型的Web应用程序。


## 在哪里可找到相关信息

在阅读本指南和其教程以后, 跟随以下资源可获取有关Serenity的详细信息。

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


## 名字有什么含义

Serenity 在字典中解释为 *平和*，*舒适*，*沉着*。

这正是我们使用Serenity努力实现的目标，我们希望你在安装并使用Serenity之后，你会觉得这太……

## 它提供了哪些功能

* 模块化、 基于服务的 web 应用程序模型 
* 为SQL表生成初始服务/用户界面的代码生成器
* 服务器上的基于T4模板生成智能感知/编译时验证的引用脚本部件
* 基于T4模板生成从脚本端调用AJAX服务的同时提供编译时类型安全和智能感知 
* 基于属性（Attribute）的表单定义系统（在服务器端用一个简单的C#类编写用户界面）
* 通过表单定义实现全自动无缝数据绑定（表单 <-> 实体 <-> 服务）
* 缓存助手（本地/分布式）
* 自动缓存验证
* 配置系统（独立的存储介质。可以数据库，文件等形式保存设置）
* 简单的日志记录
* 报表（报表只提供数据，不依赖于渲染形式，类似于MVC）
* 脚本引用，压缩（使用Node / UglifyJS / CleanCSS）和内容版本化（不再需要额外按F5/清除浏览器缓存）
* 流式SQL生成器（SELECT/INSERT/UPDATE/DELETE）
* 微型ORM（集成Dapper） 
* 可定制的类REST服务，用于实体类的重用信息并做自动验证
* 基于属性（Attribute）的导航菜单
* 用户界面本地化（本地化文本可存储在json文件，嵌入的资源文件，数据库，内存等）
* 数据本地化（使用扩展表机制帮助本地化，甚至支持用户输入，如查找表）
* 脚本插件系统（灵感来自jQueryUI，但更适合C#代码）
* 客户端和服务端验证（基于jQuery验证插件，但可分离依赖）
* 操作日志（在CDC中不可用）
* 基于数据系统集成测试
* 动态脚本
* 脚本端模板

## 背景

> 这部分原本是写在CodeProject上的一编介绍Serenity的文章，由于这篇文章是一篇宣传代码的广告却没有包含代码而被拒绝。他们没有错，因为我在本指南中做了一个视频教程链接，而不是复制粘贴代码。

> 如果你不喜欢了解历史，您可以毫无影响地跳到下一章 :) 

我们开发人员每天都在解决一系列相同的问题，就像大学生做习题书一样工作。

即使我们知道他们已经有合适的解决方案，但依避免不了面对相同的工作。实际上，它可以帮助提高我们的技术，你总不能在不犯错误中学习吧？但我们应该学会如何界定培训和浪费时间。

当你开始一个新的项目时，你需要作出几个决定：使用哪个平台，如何组织架构及使用哪些类库。今天，你可以在每一次的话题中有如此多的选择，是的，具有一些选项是好事，只要这些选项是在有限的范围内，因为我们的时间不是无限的。

下面是关于*Serenity*的简短历史：Serenity旨在处理你业务应用程序中的常见任务，并让你腾出宝贵的时间专注于特定应用程序域的功能。

我的第一份正式的关于Web技术的工作是在设计国家特定Web站点的一些大牌行业，如汽车公司（顺便感慨一下，我们在谈论的是十多年以前的往事了，时光流逝的真快）。

在与他们签约之前我有一段桌面应用程序的软件架构师职业生涯，我应邀去为他们设计一个ASP.NET WebForms平台。他们解释说，他们有很多共享模块，如新闻，列表，导航，但由于需求不同，他们不得不先复制/粘贴，然后根据每个客户的具体需求自定义代码。当他们想要添加一个共同功能时，他们就得重复修改每个网站。

当时，在市场中没有那么多的CMS系统，我为他们设计了一个系统，甚至都不知道它被称为CMS。对我来说，它并不完美，甚至还有瑕疵，因为我只用了几周的时间去设计它，但是他们却非常满意这个结果，因为它使开发一个新网站的时间由数月提高到数日/周，同时生成的代码也比以前任何时候都更易于管理。

从错误和经验中学习，那个简陋的CMS逐渐完善成为更好的系统平台，后来，该平台不断地演变并被应用在不同领域，例如帮助台系统、CRM、ERP、人事管理系统、电子文档管理系统，大学学生信息系统等。

为了与不同类型的应用程序、系统及老旧的数据库兼容，它必须具有足够的灵活性，并经历了多次的架构调整。

现在我们看到的Serenity，即使它是一个开源了2年左右的项目，其实它有一个更久远的历史，但它依然年轻，精力充沛，并且不害怕改变。它与时俱进并保持稳定，这可能意味着随着时间的变化会有不继的重大更改，但我们努力将它保持在最低限度且不偏执地向后保持兼容。

