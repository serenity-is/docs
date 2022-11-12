# Introduction

## What is Serenity?

[Serenity](https://github.com/serenity-is/serenity) is an ASP.NET Core / TypeScript application platform that is built on open-source technologies.

It aims to make development easier while reducing maintenance costs by avoiding boilerplate code, reducing the time spent on repetitive tasks, and applying the best software design practices.

[Serene](https://github.com/serenity-is/serene) is our free, open-source starter application template based on the Serenity platform. We'll mainly use Serene for our tutorial and other samples through this documentation.

[StartSharp](https://serenity.is) is the premium application template we offer to our paid customers. It contains everything in Serene, in addition to a more polished theme, and some [extra features](startsharp/README.md). They are both based on the Serenity platform.

## Who/What This Platform Is For

Serenity is best suited to line-of-business (LOB) applications which can be described as programs that contain integrated capabilities and tie into databases, generally with many forms and listing/reporting pages. 

It is also a good fit for administrative interfaces of public-facing websites. 

Serenity handles most of the internal plumbing for cross-cutting concerns of such applications, including data manipulation, filtering, services, caching, localization, navigation, validation, user access control, and declarative UI.

## What's In The Name

Serenity has dictionary meanings of *peace*, *comfort*, and *calmness*.

This is what we are trying to achieve with Serenity. We hope that after installing and using it you will feel this way too...


## Some of the Out-of-the-Box Features

* A modular, service-based web application model
* A code generator (Sergen) to produce initial services/user interface code for an SQL table
* Two-way transformations between C#/TypeScript code that provides build-time error checking and intelli-sense support
* Attribute-based declarative user interfaces
* Seamless data-binding through form definitions (form <-> entity <-> service).
* Local/distributed caching and invalidation
* Simple, data-driven reporting, Excel export
* Script bundling, minification, and content versioning (no more F5 / clear browser cache)
* Fluent SQL Builders
* Micro ORM and Dapper integration
* Customizable handlers for REST-like services that work by reusing information in entity classes and do automatic validation.
* Attribute-based navigation menu
* UI / Data Localization
* Widget system
* Audit logging

## Where To Look For Information

After reading this guide and its tutorials, follow the resources below for more information about Serenity:

<dl>
  <dt>Home Page:</dt>
  <dd><a href='https://serenity.is' target='_blank'>https://serenity.is</a></dd>

  <dt>Blog:</dt>
  <dd><a href='https://serenity.is/blog' target='_blank'>https://serenity.is/blog</a></dd>

  <dt>Github Repository:</dt>
  <dd><a href='https://github.com/serenity-is/Serenity' target='_blank'>https://github.com/serenity-is/Serenity</a></dd>

  <dt>Issues / Bug Reports</dt>
  <dd><a href='https://github.com/serenity-is/Serenity/issues' target='_blank'>https://github.com/serenity-is/Serenity/issues</a></dd>

  <dt>Discussions / Questions</dt>
  <dd><a href='https://github.com/serenity-is/Serenity/discussions' target='_blank'>https://github.com/serenity-is/Serenity/discussions</a></dd>

  <dt>Community Wiki (FAQ, Troubleshooting and Other Community Edited Content)</dt>
  <dd><a href='https://github.com/serenity-is/Serenity/wiki' target='_blank'>https://github.com/serenity-is/Serenity/wiki</a></dd>
  
  <dt>Change Log:</dt>
  <dd><a href='https://github.com/serenity-is/Serenity/blob/master/CHANGELOG.md' target='_blank'>https://github.com/serenity-is/Serenity/blob/master/CHANGELOG.md</a></dd>

  <dt>Serene Application Template:</dt>
  <dd><a href='https://marketplace.visualstudio.com/items?itemName=VolkanCeylan.SereneSerenityApplicationTemplate'>https://marketplace.visualstudio.com/items?itemName=VolkanCeylan.SereneSerenityApplicationTemplate</a></dd>

  <dt>Serene Github Repository:</dt>
  <dd><a href='https://github.com/serenity-is/Serene' target='_blank'>https://github.com/serenity-is/Serene</a></dd>

</dl>

## Background

> You can safely skip to next chapter, if you don't like reading history :)

We, developers, are all solving the same sets of problems every day. Just like college students working on their problem books.

Even though we know that they are already solved and have answers somewhere, it doesn't stop us from working on them. It could be helpful to improve our skills, and hey you can't learn without making some mistakes, can you? But we should learn where to draw a line between training and wasting time.

When you start a new project, you have several decisions to make on the platform, architecture, and the set of libraries. Today you have so many choices for every single topic. Yes, having some options is good, as long as they are limited, as our time is not infinite. 

Here is a short history of *Serenity*, which aims to handle common tasks you deal with in business applications, and let you spare your precious time focusing on features specific to your application domain.

My first real job in web technologies was in a web agency designing country-specific websites of some of the big names in the industry, e.g. automotive companies (btw, we are talking about 15+ years past, time flows fast).

As I had a software architect career in desktop applications before I signed there, I was asked to design an ASP.NET WebForms platform for them. They explained that they have many shared modules, like news, galleries, and navigation at each site, but as requirements vary, they had to copy/paste, then customize code specific to every customer. When they wanted to add a common feature, they had to repeat it for every site.

At that time, there weren't so many CMS systems in the market, and I designed one for them, without even knowing it was called a CMS. For me, it wasn't perfect, not even good enough as I just had a few weeks to design it. But they were very pleased with the result, as it took the development of new sites down to days/weeks from months. Also resulting code was more manageable than before.

Learning from that experience, and mistakes, that poor-mans CMS became something better. Later, that platform evolved to be used by applications in varying domains, like a help-desk system, a CRM, ERP, personnel management, electronic document management, a university student information system, and more.

To be compatible with different kinds of applications, systems, and even legacy databases, it had to be flexible and went through many architectural changes.

Now it takes us to Serenity. Even though it is an open-source project since 2015, it has a much older background. But it is also young, energetic, and not afraid of change. It can adapt to new technologies as they became popular and stable. This might mean breaking changes from time to time, but we strive to keep them to a minimum without being paranoid about backward compatibility.

