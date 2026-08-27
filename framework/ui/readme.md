# Frontend Framework (TypeScript)

Serenity's client-side framework is written in TypeScript and distributed as three npm packages that are installed by default in projects created from the `Serene` and `StartSharp` templates:

- `@serenity-is/corelib` — the main application framework: widgets, grids, dialogs, editors, filtering, formatters, service calls, and more.
- `@serenity-is/domwise` — the JSX runtime and reactive signals layer that the UI is built on.
- `@serenity-is/sleekgrid` — the high-performance, virtualized data grid engine used by grids.

All three are listed in your project's `package.json`:

```json
{
  "dependencies": {
    "@serenity-is/corelib": "workspace:*",
    "@serenity-is/domwise": "workspace:*",
    "@serenity-is/sleekgrid": "workspace:*"
  }
}
```

> In a Serene/StartSharp project, `@serenity-is/corelib` is usually referenced through the `Serenity.Corelib` NuGet package, in which case its version in `package.json` becomes `"./node_modules/.dotnet/serenity.corelib"`. This keeps the client library version in sync with the Serenity NuGet packages in your project file.

## The Three Packages

### @serenity-is/corelib

The main client-side framework. It provides the component system ([`Widget`](../../api/js/corelib/classes/Widget.md)), data grids ([`DataGrid`](../../api/js/corelib/classes/DataGrid.md), [`EntityGrid`](../../api/js/corelib/classes/EntityGrid.md)), dialogs ([`EntityDialog`](../../api/js/corelib/classes/EntityDialog.md)), editors, filtering, formatters, criteria, service calls, localization, and authorization helpers that you use when building application modules.

[API Reference: @serenity-is/corelib](../../api/js/corelib/README.md)

### @serenity-is/domwise

A lightweight JSX library that compiles JSX directly into real DOM nodes — no virtual DOM, no diffing, no reconciliation. It also provides reactive signals (`signal`, `computed`, `effect`) and a lifecycle/disposal system that integrates with Serenity widgets. `@serenity-is/corelib` re-exports everything from `@serenity-is/domwise`, so application code can import `signal`, `Show`, `Component`, etc. directly from `@serenity-is/corelib`.

[API Reference: @serenity-is/domwise](../../api/js/domwise/README.md)

### @serenity-is/sleekgrid

A modern rewrite of SlickGrid in TypeScript. It provides the virtualized, high-performance grid engine — columns, cell editors, formatters, grouping, selection, frozen columns, and plugins. You rarely use it directly; [`DataGrid`](../../api/js/corelib/classes/DataGrid.md) in `@serenity-is/corelib` wraps a [`SleekGrid`](../../api/js/sleekgrid/classes/SleekGrid.md) instance for you.

[API Reference: @serenity-is/sleekgrid](../../api/js/sleekgrid/README.md)

## How the Packages Fit Together

The three packages form a layered stack:

| Layer | Package | Provides |
| --- | --- | --- |
| Application | — | Your Serene/StartSharp modules |
| Framework | `@serenity-is/corelib` | Widgets, grids, dialogs, editors, services |
| Grid engine | `@serenity-is/sleekgrid` | Virtualized grid, columns, cell editors, formatters |
| Foundation | `@serenity-is/domwise` | JSX element creation, reactive signals, lifecycle/disposal |

- `@serenity-is/domwise` is the foundation. It has no dependencies on the other Serenity packages.
- `@serenity-is/sleekgrid` is the grid engine, built on top of `@serenity-is/domwise`.
- `@serenity-is/corelib` builds on both. Its `Widget` base class uses DomWise's disposal system, its `DataGrid` wraps a `SleekGrid` instance, and it re-exports the DomWise API so application code can import everything from one package.

## Where Each Concept Lives

| Concept | Package | API reference |
| --- | --- | --- |
| Widgets, dialogs, editors, grids | `@serenity-is/corelib` | [Widget](../../api/js/corelib/classes/Widget.md), [DataGrid](../../api/js/corelib/classes/DataGrid.md), [EntityDialog](../../api/js/corelib/classes/EntityDialog.md) |
| JSX, components, signals | `@serenity-is/domwise` (re-exported by corelib) | [Component](../../api/js/domwise/classes/Component.md) |
| Grid engine (columns, cell editors, formatters, grouping) | `@serenity-is/sleekgrid` | [SleekGrid](../../api/js/sleekgrid/classes/SleekGrid.md) |
| Service calls, criteria, localization, authorization | `@serenity-is/corelib` | [corelib API](../../api/js/corelib/README.md) |

## Navigating This Section

- **Core Functions** — Fluent DOM manipulation, signals & reactivity, JSX, components & hooks, type registration, criteria.
- **Grids** — DataGrid architecture, creating grids, EntityGrid CRUD, formatters, cell editing, filtering, selection, persisted settings, advanced features.
- **Script Classes** — the Widget system ([Widgets](../../widgets/README.md)).
- **Forms and Editors** — editors, lookup editors, PropertyGrid, custom editors.
- **Dialogs** — EntityDialog and CRUD workflows.
- **Integration** — service calls, authorization, data binding, localization, theming, performance.
- **How-To Guides** — frontend patterns cookbook and troubleshooting.

## See Also

- [API Reference: @serenity-is/corelib](../../api/js/corelib/README.md)
- [API Reference: @serenity-is/domwise](../../api/js/domwise/README.md)
- [API Reference: @serenity-is/sleekgrid](../../api/js/sleekgrid/README.md)