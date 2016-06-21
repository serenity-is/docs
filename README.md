# 前言

## 什么是Serenity平台

Serenity 是建立在开源技术上的ASP.NET MVC/Javascript应用程序平台。
Serenity is an ASP.NET MVC / Javascript application platform which has been built on open source technologies.

它旨在使开发变得更简单，同时避免重复代码，减少花在重复任务的时间并提供最佳的软件设计实践，从而降低了维护成本。
It aims to make development easier while reducing maintenance costs by avoiding boiler-plate code, reducing the time spent on repetitive tasks and applying the best software design practices.


##谁适合使用该平台Who/What This Platform Is For

Serenity 最适合应用于有大量数据输入的表单业务应用程序或者面向公众的网站后台管理，它的功能同样也适用于其他类型的Web应用程序。
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
* 代码生成器为SQL表生成初始服务/用户界面代码Code generator to produce initial services / user interface code for an SQL table
* T4 based code generation on server to reference script widgets with intellisense / compile time validation
* T4 based code generation to provide compile time type safety and intellisense while calling AJAX services from script side.
* An attribute based form definition system (prepare UI in server side with a simple C# class)
* Automatic seamless data-binding through form definitions (form <-> entity <-> service).
* Caching Helpers (Local / Distributed)
* Automatic cache validation
* Configuration System (storage medium independent. store settings in database, file, whatever...)
* Simple Logging
* Reporting (reports just provide data, has no dependency on rendering, similar to MVC)
* Script bundling, minification (making use of Node / UglifyJS / CleanCSS) and content versioning (no more F5 / clear browser cache)
* Fluent SQL Builder (SELECT/INSERT/UPDATE/DELETE)
* Micro ORM (also Dapper is integrated)
* Customizable handlers for REST like services that work by reusing information in entity classes and do automatic validation.
* Attribute based navigation menu
* UI Localization (store localized texts in json files, embedded resource, database, in memory class, anywhere)
* Data Localization (using an extension table mechanism helps to localize even data entered by users,  like lookup tables)
* Script widget system (inspired by jQueryUI but more suitable for C# code)
* Client side and server side validation (based on jQuery validate plugin, but abstracts dependency)
* Audit logging (where CDC is not available)
* System for data based integration tests
* Dynamic scripts
* Script side templates

## Background

> This part was originally written for a CodeProject article as an introduction to Serenity. The article was rejected with the reason that it didn't contain code but was an ad for code. They were right, as i did put a link to Movie tutorial in this guide, instead of copy pasting code. 

> You can safely skip to next chapter, if you don't like reading history :)

We, developers, are all solving the same sets of problems everyday. Just like college students working on their problem books.

Even though we know that they are already solved and have answers somewhere, it doesn't stop us from working on them. Actually, it helps us improve our skills, and hey you can't learn without making some mistakes, can you? But we should learn where to draw a line between training and wasting time.

When you start a new project, you have several decisions to make on platform, architecture and set of libraries. Today you have so many choices for every single topic. Yes, having some options is good, as long as they are limited, as our time is not infinite. 

Here is a short history about *Serenity*, which aims to handle common tasks you deal with business applications, and let you spare your precious time focusing on features specific to your application domain.

My first real job in web technologies was in a web agency designing country-specific web sites of some of big names in industry, e.g. automative companies (btw, we are talking about 10+ years past, time flows fast).

As I had a software architect career in desktop applications before I signed there, I was asked to design a ASP.NET WebForms platform for them. They explained that they have many shared modules, like news, galleries, navigation at each site, but as requirements are different, they had to copy/paste then customize code specific to every customer. When they wanted to add a common feature, they had to repeat it for every site.

At that time, there weren't so many CMS systems in market, and I designed one for them, without even knowing it was called a CMS. For me, it wasn't perfect, not even good enough as I just had a few weeks to design it. But they were very pleased with the result, as it took development of new sites down to days/weeks from months. Also resulting code was more manageable than before.

Learning from that experience, and mistakes, that poor-mans CMS became something better. Later, that platform is evolved to be used by applications in varying domains, like a help-desk system, a CRM, ERP, personnel management, electronic document management, university student information system and more.

To be compatible with different kinds of applications, systems and even legacy databases, it had to be flexible and went through many architectural changes.

Now it takes us to Serenity. Even though it is an open source project for about 2 years, it has a much older background. But it is also young, energetic, and is not afraid of change. It can adapt to new technologies as they became popular and stable. This might mean breaking changes from time to time, but we strive to keep them to a minimum without being paranoid about backwards compability.

