# Creating and Configuring Grids

This page shows how to create grids in a Serene/StartSharp application and how to configure them. There are two kinds of grids:

- **EntityGrid** — the common case, bound to a row/entity with CRUD dialogs, routing, and service integration.
- **DataGrid** — the base grid, used directly for grids that don't follow the standard entity CRUD pattern.

## Creating an EntityGrid

A typical generated grid extends `EntityGrid` and overrides a few methods to wire up its columns, dialog, row, and service:

```ts
import { EntityGrid } from "@serenity-is/corelib";
import { RoleColumns, RoleRow, RoleService } from "../../ServerTypes/Administration";
import { RoleDialog } from "./RoleDialog";

export class RoleGrid extends EntityGrid<RoleRow> {
    protected override getColumnsKey() { return RoleColumns.columnsKey; }
    protected override getDialogType() { return RoleDialog; }
    protected override getRowDefinition() { return RoleRow; }
    protected override getService() { return RoleService.baseUrl; }
}
```

The key methods:

| Method | Purpose |
| --- | --- |
| `getColumnsKey()` | The columns script key (e.g. `RoleColumns.columnsKey`). |
| `getDialogType()` | The dialog class opened for add/edit. |
| `getRowDefinition()` | The row class (provides id property, local text prefix, etc.). |
| `getService()` | The service base URL (e.g. `RoleService.baseUrl`). |
| `getIdProperty()` | The id field name (defaults to the row's id property). |
| `getIsActiveProperty()` | The is-active field name (for soft-delete grids). |
| `getLocalTextPrefix()` | The local text prefix for the grid. |

## Registering the Grid

Grids are registered with `registerClass` so they can be looked up by key:

```ts
export class RoleGrid extends EntityGrid<RoleRow> {
    static override[Symbol.typeInfo] = this.registerClass(nsAdministration);
    // ...
}
```

See [Type Registration](../framework/ui/type-registration.md) for details.

## Creating a Standalone DataGrid

When a grid doesn't follow the standard entity CRUD pattern, extend `DataGrid` directly. The `PermissionCheckEditor` in the template is a good example — it's a tree grid of permission keys that loads data from a remote data script rather than a list service:

```ts
export class PermissionCheckEditor<P extends PermissionCheckEditorOptions = PermissionCheckEditorOptions>
    extends DataGrid<PermissionCheckItem, P> {

    static override[Symbol.typeInfo] = this.registerEditor(nsAdministration, [IGetEditValue, ISetEditValue]);

    protected override getIdProperty() { return "Key"; }

    protected override getGridCanLoad() {
        return false; // don't load from a list service
    }

    protected override getButtons(): ToolButton[] {
        return [];
    }
}
```

Because it doesn't load from a service, it overrides `getGridCanLoad()` to return `false` and populates the view manually with `this.view.setItems(...)`.

## Configuring Columns

Columns come from the columns script (a `PropertyItem[]`), converted to SleekGrid columns by `createColumns()`. You can customize columns by overriding `createColumns()`:

```ts
protected override createColumns() {
    let columns = new UserColumns(super.createColumns());

    columns.ImpersonationToken && (columns.ImpersonationToken.format = ctx => !ctx.value ? "" :
        <a target="_blank" href={resolveUrl(`~/Account/ImpersonateAs?token=${encodeURIComponent(ctx.value)}`)}>
            <i class={faIcon("user-secret", "primary")}></i>
        </a>);

    return columns.valueOf();
}
```

This example (from `UserGrid.tsx`) wraps a column in a custom formatter using JSX.

## Configuring the Toolbar

Override `getButtons()` to add toolbar buttons:

```ts
protected override getButtons(): ToolButton[] {
    return [
        {
            title: "My Action",
            cssClass: "my-action-button",
            onClick: () => { /* ... */ }
        }
    ];
}
```

## Configuring Quick Filters

Quick filters are derived from columns marked with `quickFilter: true` in the columns script. Override `getQuickFilters()` to customize them, or `createQuickFilters()` to build them manually.

## Configuring Sorting and Paging

- `getDefaultSortBy()` — the default sort order (e.g. `["Name"]` or `["Name desc"]`).
- `usePager()` — return `true` to show a pager (EntityGrid does this by default).
- `getViewOptions()` — configures the `RemoteView` (id field, sort, rows per page).

## Configuring Grid Options

Override `getSlickOptions()` to customize the underlying SleekGrid options:

```ts
protected override getSlickOptions() {
    const opt = super.getSlickOptions();
    opt.rowHeight = 40;
    opt.forceFitColumns = true;
    return opt;
}
```

## Refreshing the Grid

- `this.view.populate()` — reloads data from the server.
- `this.refresh()` — refreshes the grid.
- `this.view.setItems(items, true)` — replaces the items locally (used by standalone grids).

## See Also

- [DataGrid (API reference)](../api/js/corelib/classes/DataGrid.md) — the full `DataGrid` API.
- [EntityGrid (API reference)](../api/js/corelib/classes/EntityGrid.md) — the full `EntityGrid` API.
- [DataGrid Architecture](architecture.md) — how the grid stack fits together.
- [RemoteView and Data Management](remoteview.md) — the grid's data source.
- [EntityGrid CRUD](entitygrid-crud.md) — CRUD workflows with dialogs.
- [Type Registration](../framework/ui/type-registration.md) — registering grid types.
- [Frontend Framework Overview](../framework/ui/readme.md) — the three client-side packages and how they fit together.