# Introduction

## What is Serenity Platform

Serenity is a Javascript / .NET application platform which has been built on open source technologies.

It aims to make development easier while reducing maintenance costs by avoiding boiler-plate code, reducing the time spent on repetitive tasks and applying best software design practices.

## What's In The Name

Serenity has dictionary meanings of *peace*, *comfort* and *calmness*.

This is what we are trying to achieve with Serenity. We hope that after installing and using it you will feel this way too...

## Who/What This Platform Is For

Serenity is best suited to business applications with many data entry forms or administrative interface of public facing web sites.

This doesn't mean that it can't be used for other types of applications. Some features like script versioning/bundling, caching, code generation, fluent sql builders etc. can be helpful for any kind of application.

## What Features Does It Provide

* A modular, service based web application model
* Code generator to produce initial services / user interface code for an SQL table
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

