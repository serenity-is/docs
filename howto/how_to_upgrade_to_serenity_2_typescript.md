# How To: Upgrade to Serenity 2.0 and Enable TypeScript

Serenity has TypeScript support starting with version 2.0.

This is a migration guide for users that started with an older Serene template, and wants to use TypeScript features.

If you don't need TypeScript, just update your Serenity packages and it should work as normal.

> Even if you won't need TypeScript, it's recommended to perform steps listed here to keep your project up to date and avoid future problems.


## Should I Use TypeScript?

TypeScript support in Serenity is rather new and you might experience a few issues. TypeScript compiler itself is also still in development and has some glitches like Compile on Save support is only working with VS2015, or having build ordering problems with MSBUILD projects.

There are also some usability problems. For example there is no intellisense for method overriding.

Anyway, TypeScript is probably the future for Serenity applications, as it has a stronger backing at the moment (Microsoft and average number of users). Also TypeScript feels like native javascript with proper refactoring and compile time type checking. 

We've been using Saltaralle since start but its future is a bit blurry. It didn't get any updates since Saltaralle is acquired by Bridge.NET, last June (2015).

Saltaralle support in Serenity is more stable than TypeScript support for now.



## Migrating Your Serene Application to v2.0




