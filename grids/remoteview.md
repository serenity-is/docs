# RemoteView and Data Management

`RemoteView<TItem>` is the data source that powers Serenity grids. It implements `IRemoteView` (which extends SleekGrid's `IDataView`) and adds server-side data operations on top: loading, sorting, paging, filtering, and grouping.

A grid's `view` property holds its `RemoteView`. You rarely create one directly — `DataGrid` does it for you — but understanding it helps you customize how grids load and refresh data.

## What RemoteView Does

- **Loads data from the server** — calls the list service (e.g. `LanguageService.List`) with the current request parameters.
- **Sorting** — sends the sort columns to the server (or sorts locally when `localSort` is enabled).
- **Paging** — tracks the current page and page size, and sends `Skip` / `Take` in the request.
- **Filtering** — applies quick filters and advanced filters to the request.
- **Grouping** — supports server-side grouping and group totals.
- **Server aggregates** — can ask the server for grand and per-group totals instead of calculating them from the loaded page (`serverAggregates`).

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
| `serverAggregates` | Ask the server for grand and per-group totals instead of calculating them from the loaded rows (see below). |
| `indeterminatePaging` | Page without knowing the total count (see [Indeterminate paging](#indeterminate-load-more-paging)). |

### Data Access

- `getItems()` — all items in the view.
- `getItemById(id)` — an item by its id.
- `getItemByIdx(i)` — an item by its index.
- `getLength()` — the number of rows (including group/totals rows).
- `getRows()` — the current rows (items, groups, and totals).
- `getFilteredItems()` — the filtered items.

### Paging

- `getPagingInfo()` — returns `{ rowsPerPage, actualRowsPerPage, page, totalCount, loading, error, dataView, indeterminate, hasMore }`.
- `getTotalCount()` — the total number of records on the server (or the number of rows known so far when paging is indeterminate).
- `seekToPage` — the page to seek to when loading.

`rowsPerPage` reports the page size *requested* by the grid, while `actualRowsPerPage` tracks the page size *applied* by the server (from the response's `Take`). When server-side paging limits (`RequestHandlerSettings.DefaultPageSize` / `MaxPageSize`) clamp the requested size, paging calculations use `actualRowsPerPage` so the grid stays correct — see [Server-Side Page Size Limits](../services/list_request_handler.md#server-side-page-size-limits).

The internals of paging are hooks, so a view that loads rows in another way can reuse them instead of duplicating the
logic:

| Member | Purpose |
| --- | --- |
| `page`, `totalCount`, `more` | Now `protected`, so a subclass can read and adjust the paging state |
| `applyResponse(data)` | Sets the paging state and items from a response; return `false` when the rows are not used |
| `setRequestPaging(request)` | Sets the `Skip` / `Take` of a request (called after `onSubmit`) |
| `keepServerTotals()` | Return `true` when the request matches the same rows, so the previous server totals are kept (`totalsKept`) |

### Sorting

- `sortBy` — the current sort expressions.
- `sort(comparer, ascending)` — sorts locally with a custom comparer.

### Grouping

- `setGrouping(groupingInfo)` — configures grouping levels.
- `getGroups()` — the current groups.
- `getGrandTotals()` — the grand totals.
- `expandGroup` / `collapseGroup` / `expandAllGroups` / `collapseAllGroups` — group expansion.

Since 10.7.0 the grouping helpers are **public statics**, so the same logic can be used without a view instance (the
instance methods delegate to them): `normalizeGroupingInfos`, `getRequestSort`, `getGroupByToRequest`,
`getAggregatesToRequest`, `findServerGroup`, `groupKeyText`, `groupingDelimiter` (now a static readonly property),
`copyServerValues` and `formatGroupValue`. `groupKeyText` is public too, so callers can encode a group key the same way
the view does.

`RemoteView` also orders request results by the grouping fields, in the view's sort order (a `GroupBy` gets
`Descending: true` when the matching sort field is descending), so rows of a group stay together — and when the server
has to drop groups because there are too many, the ones left out are the last ones.

## Server-Side Aggregates

By default the footer (grand) totals and the group totals of a grid are calculated from the rows that are **loaded**, so on
a paged grid they only describe the current page. Set `serverAggregates` to have the server calculate them from all the
rows the request matches (see [Aggregates and Grouping](../services/list_request_handler.md#aggregates-and-grouping)):

```ts
// e.g. in a script init file, for all grids
DataGrid.defaultOptions.serverAggregates = true;

// or per grid, overriding it in getViewOptions()
protected override getViewOptions() {
    return { ...super.getViewOptions(), serverAggregates: true };
}
```

- The aggregates are derived from the grid's own configuration — the grand aggregators and the group aggregators — so a
  column with a summary type, and a grouped grid, work without additional code.
- The view falls back to the loaded page rows when the server returns no aggregates (an older server or a handler without
  the `Aggregates` capability), when the aggregator is one the server can't calculate (e.g. a weighted average), or when a
  local filter hides rows.
- It only reloads when the aggregates, the groupings or the sort change, and keeps the previous totals when a request
  reuses them (`totalsKept`).

## Indeterminate (Load-More) Paging

Counting every row is slow on large tables, so a view can instead ask whether there are more rows after the page:

```ts
const view = new RemoteView<MyRow>({ idField: "Id", url: MyService.listUrl, rowsPerPage: 100,
    indeterminatePaging: true });
```

- The request sends `IncludeMore` instead of `ExcludeTotalCount`, so `totalCount` reflects only the rows known so far
  (`skip + rows + (more ? 1 : 0)`).
- `getPagingInfo()` exposes `indeterminate` and `hasMore`.
- An empty page past the end falls back to the last page that has rows.
- `SlickPager` takes the same `indeterminatePaging` option (or reads it from the view): it hides the total page count and
  the last-page button, disables the next button when there are no more rows, and accepts any page number typed in. Its
  status uses the `PagerTexts.RangeStatus` text ("Showing {from} to {to} records") when the total is unknown.

For infinite / virtual scrolling views built on the same paging hooks, see the StartSharp documentation.

### Refreshing

- `populate()` — loads data from the server.
- `refresh()` — refreshes the view (re-applies local filtering/grouping).
- `beginUpdate()` / `endUpdate()` — batch multiple changes into one refresh.
- `populateLock()` / `populateUnlock()` — temporarily prevent loading.

### Events

- `onDataLoading` — fired when data loading begins.
- `onDataLoaded` — fired when data loading completes.

> `onProcessData` runs **after** the loading state of the finished request is cleared, so a callback that starts a new
> request (for example a grid that learns its columns from the data and then asks the server for summaries) no longer has
> that request aborted. Cleanup only clears the loading flag when it still belongs to the finished request.
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