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

- **Core Functions**
  - [Fluent](fluent.md) — imperative DOM manipulation.
  - [Signals and Reactivity](signals.md) — reactive state and bindings.
  - [JSX with DomWise](jsx.md) — JSX syntax, elements, attributes, events, refs.
  - [Components and Hooks](components.md) — function/class components and hooks.
  - [Type Registration](type-registration.md) — registering widgets, editors, dialogs, formatters.
  - [Criteria](criteria.md) — building filter criteria.
- **Grids** — [DataGrid Architecture](../../grids/architecture.md), [RemoteView and Data Management](../../grids/remoteview.md), [Creating and Configuring Grids](../../grids/creating-grids.md), [EntityGrid CRUD](../../grids/entitygrid-crud.md), [Formatter Types](../../grids/formatter_types.md), [Cell Editing](../../grids/cell-editing.md), [Filtering and Quick Search](../../grids/filtering.md), [Toolbar](../../grids/toolbar.md), [Selection and Row Operations](../../grids/selection.md), [Persisting Settings](../../grids/persisting_settings.md).
- **Script Classes** — the Widget system ([Widgets](../../widgets/README.md), [Widget Class](../../widgets/widget_class.md), [PrefixedContext Class](../../widgets/prefixedcontext_class.md)).
- **Forms and Editors** — [Editors](../../editors/readme.md), [Lookup Editors](../../editors/lookup-editors.md), [PropertyGrid and Forms](../../editors/propertygrid.md), [Custom Editors](../../editors/custom-editors.md).
- **Dialogs** — [EntityDialog and CRUD Workflows](../../dialogs/entitydialog.md).
- **Integration** — [Type-Safe Service Calls](../service-calls.md), [Authorization and Permissions](../authorization-client.md), [Data Binding](../data-binding.md), [Localization and Text](../localization-client.md), [Theming and CSS Customization](../theming.md), [Performance](../performance.md), [Config and Global Settings](../config-client.md).
- **How-To Guides** — [Frontend Patterns Cookbook](../../howto/frontend-patterns-cookbook.md), [Frontend Troubleshooting](../../howto/frontend-troubleshooting.md).

## See Also

- [API Reference: @serenity-is/corelib](../../api/js/corelib/README.md)
- [API Reference: @serenity-is/domwise](../../api/js/domwise/README.md)
- [API Reference: @serenity-is/sleekgrid](../../api/js/sleekgrid/README.md)