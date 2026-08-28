# RemoteView and Data Management

`RemoteView<TItem>` is the data source that powers Serenity grids. It implements `IRemoteView` (which extends SleekGrid's `IDataView`) and adds server-side data operations on top: loading, sorting, paging, filtering, and grouping.

A grid's `view` property holds its `RemoteView`. You rarely create one directly — `DataGrid` does it for you — but understanding it helps you customize how grids load and refresh data.

## What RemoteView Does

- **Loads data from the server** — calls the list service (e.g. `LanguageService.List`) with the current request parameters.
- **Sorting** — sends the sort columns to the server (or sorts locally when `localSort` is enabled).
- **Paging** — tracks the current page and page size, and sends `Skip` / `Take` in the request.
- **Filtering** — applies quick filters and advanced filters to the request.
- **Grouping** — supports server-side grouping and group totals.

## The Request

When the view loads data, it builds a `ListRequest`:

- `Skip` — computed from `(page - 1) * rowsPerPage`.
- `Take` — the page size (`rowsPerPage`).
- `Sort` — the current sort expressions (e.g. `["Name"]` or `["Name desc"]`).
- Additional parameters from `view.params` (quick filters, advanced filters, etc.).

The request is sent to `view.url` (the service base URL) via `serviceCall`.

## Key Members

### Options (`RemoteViewOptions`)

| Option | Description |
| --- | --- |
| `url` | The service endpoint URL for data requests. |
| `autoLoad` | When `true`, loads data immediately on construction. |
| `rowsPerPage` | Number of rows per page (`0` for no paging). |
| `seekToPage` | Initial page number to seek to on first load. |
| `sortBy` | Initial sort criteria (string or array, e.g. `"Name desc"`). |
| `params` | Additional parameters to include in every request. |
| `idField` | Name of the field containing unique item identifiers (default `"id"`). |
| `localSort` | When `true`, sorts locally instead of server-side. |
| `filter` | A filter function applied to the data. |
| `onSubmit` | Callback invoked before submitting a request; return `false` to cancel. |
| `onAjaxCall` | Callback invoked before AJAX calls are made. |
| `onProcessData` | Callback to process data received from the server. |
| `getItemMetadata` | Callback to get metadata for individual items. |

### Data Access

- `getItems()` — all items in the view.
- `getItemById(id)` — an item by its id.
- `getItemByIdx(i)` — an item by its index.
- `getLength()` — the number of rows (including group/totals rows).
- `getRows()` — the current rows (items, groups, and totals).
- `getFilteredItems()` — the filtered items.

### Paging

- `getPagingInfo()` — returns `{ rowsPerPage, page, totalCount, loading, error, dataView }`.
- `getTotalCount()` — the total number of records on the server.
- `seekToPage` — the page to seek to when loading.

### Sorting

- `sortBy` — the current sort expressions.
- `sort(comparer, ascending)` — sorts locally with a custom comparer.

### Grouping

- `setGrouping(groupingInfo)` — configures grouping levels.
- `getGroups()` — the current groups.
- `getGrandTotals()` — the grand totals.
- `expandGroup` / `collapseGroup` / `expandAllGroups` / `collapseAllGroups` — group expansion.

### Refreshing

- `populate()` — loads data from the server.
- `refresh()` — refreshes the view (re-applies local filtering/grouping).
- `beginUpdate()` / `endUpdate()` — batch multiple changes into one refresh.
- `populateLock()` / `populateUnlock()` — temporarily prevent loading.

### Events

- `onDataLoading` — fired when data loading begins.
- `onDataLoaded` — fired when data loading completes.
- `onDataChanged` — fired when the underlying data changes.
- `onPagingInfoChanged` — fired when paging information changes.
- `onRowCountChanged` / `onRowsChanged` / `onRowsOrCountChanged` — fired when rows change.
- `onGroupCollapsed` / `onGroupExpanded` — fired when groups are toggled.

## Accessing the View from a Grid

The grid's `view` property exposes the `RemoteView`:

```ts
class MyGrid extends EntityGrid<MyRow, any> {
    // ...

    someMethod() {
        const items = this.view.getItems();
        const paging = this.view.getPagingInfo();
        this.view.populate(); // reload from the server
    }
}
```

## See Also

- [RemoteView (API reference)](../api/js/corelib/classes/RemoteView.md) — the full `RemoteView` API.
- [IRemoteView (API reference)](../api/js/corelib/interfaces/IRemoteView.md) — the view contract.
- [RemoteViewOptions (API reference)](../api/js/corelib/interfaces/RemoteViewOptions.md) — view configuration.
- [DataGrid Architecture](architecture.md) — how the view fits into the grid stack.
- [Creating and Configuring Grids](creating-grids.md) — building grids step by step.
- [Filtering and Quick Search](filtering.md) — how filters feed the view.
- [Frontend Framework Overview](../framework/ui/readme.md) — the three client-side packages and how they fit together.