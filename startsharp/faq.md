﻿# StartSharp FAQ (Frequently Asked Questions)

This page outlines common questions we receive from users (who are considering buying a StartSharp license) and their relevant answers.

https://github.com/serenity-is/Serenity/projects/1

## Why Should I Buy StartSharp?

Our StartSharp packages contain valuable extra modules, features, and samples in addition to premium support.

By purchasing one of these packages, we aim to help you save your most precious resource `time` while granting you access to additional content.

Also as a bonus, you'll be driving us to add more features to StartSharp and help Serenity move forward.

So we hope that your investment will be a win-win. Thanks for your time and support.

## What happens to my project after my StartSharp subscription ends?

If you choose not to renew, nothing bad happens to your project and your StartSharp license. 

You continue to use your project and can even create new projects based on your existing version of StartSharp.

You can't download new versions of StartSharp, and you'll lose access to our priority support line and StartSharp repository.

You can still update Serenity itself in your project.

## How many devs/projects use Serenity/StartSharp, and how popular it is?

As most Serenity / StartSharp projects are backend applications and require a login, it is not possible to know an exact number.

If you look at Visual Studio Marketplace (by Microsoft) we are one of the most popular extensions with 900k downloads as of writing:

https://marketplace.visualstudio.com/items?itemName=VolkanCeylan.SereneSerenityApplicationTemplate#review-details

Assuming some of these downloads could be re-installs, and some might have downloaded Serene but never used it, we consider at least 30k-50k devs have Serene in their Visual Studio and are actively using it. By looking at all five-star reviews, they seem to be happy so we are too!

## Is Serenity fast enough to be used by large-scale projects?

Yes, certainly. Serenity has very little overhead itself and is being used by projects that have hundreds of thousands of active users, and millions of records.

For example, in a very complex university course registration system, Serenity completes 100k simultaneous active users registration in under half an hour.

## How stable/reliable is Serenity?

We may say it's pretty stable, reliable, and bug-free. 

If you look at all the issues in GitHub opened so far, most of them are how-to questions, and only %1 or even less are actual bug reports.

And when there is an actual bug, we try to solve it shortest time possible. Again, just have a look at past issues.

## How old is Serenity, will it be alive in X years?

Serenity as an open source project since 2013 at GitHub, but as you may see from its [first commit](https://github.com/serenity-is/Serenity/commit/354be3d3e39f9cbbbb7e6d798a53012692d40e20) which is too big for an initial one, it even has a much older background and underwent lots of changes/technologies.

> There not many open source projects that are still alive since those times.

You may have a look at our change log (we didn't keep a change log before October 2014):

https://github.com/serenity-is/Serenity/blob/master/CHANGELOG.md

We tried to keep breaking changes at a minimum and documented any such change that we couldn't avoid.

There are hundreds of large-scale projects that we directly participated in the development, and most of them are still very active.

We can't even imagine giving up on Serenity, as we also have important projects, investments, and years of hard work on it.

Anyway, as Serenity is an open-source project and all premium customers have access to StartSharp sources, it wouldn't be hard to fork it for the community in the worst case (that we don't expect at all to happen).

## Does Serenity have a reporting tool?

Yes, Serenity relies on WKHTMLTOPDF (and Chrome/Puppeteer) for reporting, which converts HTML to PDF using the WebKit engine. It is the natural choice for a web application. It is also possible to use Chrome/Puppeteer.

You can use HTML/CSS and any kind of javascript component to render charts, tables, barcodes, QR, and other kinds of content in reports.

If you prefer some visual report designer, like SQL Server Reporting Services (SSRS), Telerik, DevExpress, etc. it is also possible to integrate them as Serenity itself is based on ASP.NET MVC, any tool that supports it can be used for reporting.

We successfully integrated some of these tools into our projects, but we can't directly distribute/integrate them with StartSharp due to licensing issues. But we'd be happy to help.

## Can we use a cool third-party theme we bought from ThemeForest, WrapBootstrap, etc. in Serenity?

Yes, but not simply by copy-pasting. All themes have different HTML markups and CSS styles. Even though the Serenity theme itself is based on Bootstrap, applying another Bootstrap based-theme requires some manual work. 

Somebody with average CSS/HTML knowledge should be able to do it in a day or two.

We integrated several popular third-party themes for some customer projects, so it's certainly possible.

## Is it possible to do X in Serenity?

Yes. If that is technologically feasible in any web framework, it is possible to do it in Serenity. 

## If I buy a premium package do you become a part of my development team?

Well, nobody asked such a question, but we think some of them thought so :)

Sorry, but no, buying a StartSharp license doesn't make us your employee. 

We try hard to solve your issues and guide you in the best solution, but there is an issue limit per premium package type
(10/15/20 in one year) that we guarantee to respond in a certain time (72, 48, 24 hours).

This is a fair use policy. It doesn't mean that if you ask more questions, we'll not be answering. 

As long as we feel you are not misusing our support, we'll try to reply, but keep in mind that we need to keep a balance 
between our paying customers, and might give others priority.

## Can you implement X for us if we buy the StartSharp?

The `Business` level has 3 hours and `Enterprise` has 5 hours you can use for custom development. 

If it will take more, you may hire our best developers at an hourly rate. 

Contact us at [sales@serenity.is](mailto:sales@serenity.is) for more information and a quote.

## Do you do custom development?

Yes, we participate in many Serenity projects, in form of architectural consultation, custom development, remote assistance, project management, and so on.

This is offered by Serenity authors, and a group of professionals that has many years of experience on real-life, large-scale Serenity projects in various sectors.

Contact us at [sales@serenity.is](mailto:sales@serenity.is) for more information and a quote.

## Do you accept feature requests?

We listen to our users and customers, and their wishes, and try to prioritize their requests. 

We continually check issues, requests, and technology trends and choose what feature would be useful for most, and try to implement them.

But we can't make any promises that your request will make it into Serenity.

## What's Next in StartSharp? Do You Have a Roadmap?

We are regularly adding extra content to *StartSharp*. Some of the ideas/in-progress features as of writing:

- OpenIddict/OAuth Integration
- Mobile/Desktop Apps with Flutter/MAUI
- Plugin System
- Feature Flags
- Survey/Polling Module
- Advanced Integrated Multi-tenancy
- Low-Code Dynamic Entities/Modules/Pages