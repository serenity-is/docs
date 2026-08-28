# DataGrid Architecture

Serenity grids are built from a layered stack. At the top is the `DataGrid` widget from `@serenity-is/corelib`, which orchestrates everything: it creates a `SleekGrid` instance for rendering, uses a `RemoteView` as its data source, builds columns from metadata, and wires up the toolbar, filters, pager, and persistence.

## The Layers

| Layer | Type | Responsibility |
| --- | --- | --- |
| Grid widget | `DataGrid` / `EntityGrid` (`@serenity-is/corelib`) | Orchestrates columns, toolbar, filters, pager, persistence, and (for `EntityGrid`) CRUD dialogs and routing |
| Grid engine | `SleekGrid` (`@serenity-is/sleekgrid`) | Renders the virtualized table: columns, rows, cell editors, formatters, selection, grouping |
| Data source | `RemoteView` (`@serenity-is/corelib`) | Loads data from the server, handles sorting, paging, filtering, and grouping |
| Metadata | `PropertyItem[]` | Column and form definitions generated server-side from your columns/form classes |

## DataGrid

`DataGrid<TItem, P>` is the base grid widget. It extends `Widget` and implements `IDataGrid` and `IReadOnly`. It is responsible for:

- **Creating the SleekGrid instance** — `createSlickGrid()` constructs a `new SleekGrid(...)` with the processed columns and options, and registers the `AutoTooltips` plugin.
- **Building columns** — `createColumns()` converts `PropertyItem` metadata into SleekGrid `Column` objects (via `PropertyItemColumnConverter`), then `postProcessColumns()` applies edit links, formatters, and other column transforms.
- **Providing grid options** — `getSlickOptions()` returns the `GridOptions` (multi-select off, multi-column sort on, cell navigation off by default).
- **Wiring the toolbar** — `getButtons()` returns the `ToolButton[]` shown in the grid's toolbar.
- **Wiring filters** — the advanced filter bar (`FilterDisplayBar` + `FilterStore`) and quick filters (`QuickFilterBar`).
- **Paging** — the `SlickPager` widget, driven by the `RemoteView`.
- **Persistence** — saving/restoring column widths, visibility, sort, and filters (see [Persisting Settings](persisting_settings.md)).
- **Data loading** — `prepareSubmit()` / `onViewSubmit()` prepare the request parameters, and the view loads data from the server.

## EntityGrid

`EntityGrid<TItem, P>` extends `DataGrid` and adds entity/CRUD integration:

- **Service integration** — `getService()` returns the service base URL (e.g. `LanguageService.baseUrl`).
- **Dialog integration** — `getDialogType()` returns the dialog class used for add/edit.
- **Routing** — handles hash routes like `#edit/123` and `#new` to open dialogs.
- **Toolbar buttons** — adds the standard add/edit/delete buttons and the include-deleted toggle.
- **Quick search** — adds the quick search input.

A typical generated grid (`LanguagePage.ts`) wires these up:

```ts
class LanguageGrid<P = {}> extends EntityGrid<LanguageRow, P> {
    static override[Symbol.typeInfo] = this.registerClass(nsAdministration);

    protected override getColumnsKey() { return LanguageColumns.columnsKey; }
    protected override getDialogType() { return LanguageDialog; }
    protected override getRowDefinition() { return LanguageRow; }
    protected override getService() { return LanguageService.baseUrl; }
}
```

## RemoteView

`RemoteView<TItem>` is the grid's data source. It implements `IRemoteView` (which extends SleekGrid's `IDataView`) and adds server-side data operations:

- **Loading** — calls the list service with the current request parameters.
- **Sorting** — sends the sort columns to the server.
- **Paging** — tracks the current page and page size.
- **Filtering** — applies quick filters and advanced filters to the request.
- **Grouping** — supports server-side grouping and group totals.

The grid's `view` property holds the `RemoteView`. You can access it to read the current items, page info, or to trigger a refresh.

## How a Grid Loads Data

1. The grid calls `prepareSubmit()`, which prepares the request parameters (sort, filters, paging) in `view.params`.
2. `getGridCanLoad()` notifies `onCanSubmit` subscribers; if any cancel, loading stops.
3. The `RemoteView` calls the list service (e.g. `LanguageService.List`).
4. The response (`ListResponse`) populates the view's items and total count.
5. The view notifies the grid, which re-renders the visible rows.

## See Also

- [DataGrid (API reference)](../api/js/corelib/classes/DataGrid.md) — the full `DataGrid` API.
- [EntityGrid (API reference)](../api/js/corelib/classes/EntityGrid.md) — the full `EntityGrid` API.
- [RemoteView (API reference)](../api/js/corelib/classes/RemoteView.md), [IRemoteView (API reference)](../api/js/corelib/interfaces/IRemoteView.md) — the data source.
- [SleekGrid (API reference)](../api/js/sleekgrid/classes/SleekGrid.md) — the grid engine.
- [Creating and Configuring Grids](creating-grids.md) — building grids step by step.
- [EntityGrid CRUD](entitygrid-crud.md) — CRUD workflows with dialogs.
- [Persisting Settings](persisting_settings.md) — saving grid settings.
- [Frontend Framework Overview](../framework/ui/readme.md) — the three client-side packages and how they fit together.