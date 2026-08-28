# Filtering and Quick Search

Serenity grids support several ways to filter data: **quick filters** (inline editors in the toolbar), **advanced filters** (a filter panel/dialog with multiple conditions), and **quick search** (a text search box). All of these feed into the grid's `RemoteView`, which sends the filter criteria to the server with the list request.

## Quick Filters

Quick filters are inline editors shown in the grid toolbar. They are derived from columns marked with `quickFilter: true` in the columns script, or defined manually via `getQuickFilters()`.

A quick filter is a `QuickFilter` definition:

```ts
interface QuickFilter<TWidget, P> {
    field?: string;                    // field name
    type?: { new(options?: P): TWidget }; // widget constructor (editor)
    handler?: (h: QuickFilterArgs<TWidget>) => void; // custom request handling
    title?: string;                    // label
    options?: P & WidgetProps<{}>;     // editor options
    separator?: boolean;               // render a separator before
    cssClass?: string;
    loadState?: (w, state) => void;    // restore persisted state
    saveState?: (w) => any;            // persist state
    displayText?: (w, label) => string;
}
```

The `QuickFilterBar` widget renders the filters and submits their values with list requests. When a filter changes, the grid reloads with the new criteria.

### Adding a Quick Filter

Quick filters are usually defined by marking a column with `quickFilter: true` in the columns script:

```cs
[QuickFilter]
public string ShipCity { get; set; }
```

You can also add them programmatically by overriding `getQuickFilters()`:

```ts
protected override getQuickFilters() {
    const filters = super.getQuickFilters();
    filters.push({
        field: "OrderDate",
        type: DateEditor,
        title: "Order Date"
    });
    return filters;
}
```

## Advanced Filters

Advanced filters let users build complex conditions with multiple fields, operators, and parentheses. They are edited in a `FilterPanel` hosted in a `FilterDialog`.

The grid's filter bar (`FilterDisplayBar`) shows the active filters and provides the "Edit Filter" button that opens the `FilterDialog`. The `FilterStore` holds the filter lines and builds the criteria expression.

### Filtering Types

Each field uses a filtering type that determines which operators and editor are available. Built-in filtering types include:

| Filtering type | Used for |
| --- | --- |
| `StringFiltering` | Text fields |
| `IntegerFiltering` | Integer fields |
| `DecimalFiltering` | Decimal fields |
| `DateFiltering` | Date fields |
| `DateTimeFiltering` | Date-time fields |
| `BooleanFiltering` | Boolean fields |
| `EnumFiltering` | Enum fields |
| `LookupFiltering` | Lookup fields |
| `ServiceLookupFiltering` | Service lookup fields |
| `EditorFiltering` | Custom editor fields |

The filtering type for a field is determined by its `filteringType` property (set from the `[FilteringType]` attribute or inferred from the field type). Custom filtering types are registered in the `FilteringTypeRegistry`.

## Quick Search

Quick search is a text input in the toolbar that filters the grid by a search query. It is added by `EntityGrid` via `createQuickSearchInput()`.

The `QuickSearchInput` widget:

- Triggers a search after a short delay (`typeDelay`) once the user stops typing.
- Supports selecting a search field (`QuickSearchField`) when multiple fields are configured.
- Shows loading and filtered visual states.

You can customize the search fields by overriding `getQuickSearchFields()`:

```ts
protected override getQuickSearchFields() {
    return [
        { name: "CustomerID", title: "Customer" },
        { name: "ShipCity", title: "Ship City" }
    ];
}
```

## How Filters Reach the Server

1. A quick filter changes or the user edits an advanced filter.
2. The grid updates its `RemoteView` parameters (`view.params`).
3. On the next `populate()`, the view builds a `ListRequest` including the filter criteria.
4. The server applies the criteria and returns the filtered rows.

## See Also

- [FilterPanel (API reference)](../api/js/corelib/classes/FilterPanel.md) — the filter editing panel.
- [FilterDialog (API reference)](../api/js/corelib/classes/FilterDialog.md) — the filter dialog.
- [FilterStore (API reference)](../api/js/corelib/classes/FilterStore.md) — stores filter lines and builds criteria.
- [FilterDisplayBar (API reference)](../api/js/corelib/classes/FilterDisplayBar.md) — the active-filter bar.
- [QuickFilterBar (API reference)](../api/js/corelib/classes/QuickFilterBar.md) — renders quick filters.
- [QuickSearchInput (API reference)](../api/js/corelib/classes/QuickSearchInput.md) — the quick search box.
- [RemoteView and Data Management](remoteview.md) — how filters feed the view.
- [DataGrid Architecture](architecture.md) — how filtering fits into the grid stack.
- [Frontend Framework Overview](../framework/ui/readme.md) — the three client-side packages and how they fit together.