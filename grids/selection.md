# Selection and Row Operations

Serenity grids support row selection through SleekGrid selection models and through corelib selection mixins that add checkbox/radio columns. This page covers both, plus common row operations.

## SleekGrid Selection Models

SleekGrid uses a `SelectionModel` (a `GridPlugin`) to manage selection. The built-in `RowSelectionModel` treats selection as whole rows.

### RowSelectionModel

`RowSelectionModel` provides:

- **Active-cell-driven selection** — moving the active cell selects the new row (`selectActiveRow`, default `true`).
- **Shift+Up/Down** — extends the selection range.
- **Ctrl/Meta/Shift-click** — toggles individual rows.

```ts
import { RowSelectionModel } from "@serenity-is/sleekgrid";

grid.setSelectionModel(new RowSelectionModel());
```

### Grid Selection Methods

The grid exposes selection methods:

| Method | Purpose |
| --- | --- |
| `setSelectedRows(rows)` | Selects the given row indices. |
| `getSelectedRows()` | Returns the selected row indices. |
| `setSelectionModel(model)` | Sets the selection model. |
| `getSelectionModel()` | Returns the current selection model. |
| `onSelectedRowsChanged` | Event fired when the selection changes. |

## Corelib Selection Mixins

For grids that need a checkbox or radio column, corelib provides two mixins.

### GridRowSelectionMixin (multi-select)

`GridRowSelectionMixin` adds multi (checkbox) row selection with a select-all header checkbox:

```ts
import { GridRowSelectionMixin } from "@serenity-is/corelib";

declare private rowSelection: GridRowSelectionMixin;

protected override onViewSubmit() {
    // ...
}

protected override afterInit() {
    super.afterInit();

    this.rowSelection = new GridRowSelectionMixin(this);
    this.rowSelection.setSelectedKeys(this.getView().getItems().map(x => x.ID.toString()));
}
```

Create the select column with `GridRowSelectionMixin.createSelectColumn`:

```ts
protected override createColumns() {
    const columns = super.createColumns();
    columns.splice(0, 0, GridRowSelectionMixin.createSelectColumn(() => this.rowSelection));
    return columns;
}
```

Key methods:

| Method | Purpose |
| --- | --- |
| `getSelectedKeys()` | The keys of the selected items. |
| `getSelectedAsInt32()` / `getSelectedAsInt64()` | Selected keys as numbers. |
| `setSelectedKeys(keys)` | Replaces the selection with the given keys. |
| `selectKeys(keys)` | Adds keys to the selection. |
| `clear()` | Clears the selection. |
| `resetCheckedAndRefresh()` | Clears the selection and reloads the grid. |
| `createSelectColumn(getMixin, columnOptions?)` | Creates the checkbox select column. |

### GridRadioSelectionMixin (single-select)

`GridRadioSelectionMixin` adds single (radio) row selection:

```ts
import { GridRadioSelectionMixin } from "@serenity-is/corelib";

declare private radioSelection: GridRadioSelectionMixin;

protected override afterInit() {
    super.afterInit();
    this.radioSelection = new GridRadioSelectionMixin(this);
}
```

It provides `clear()` and `resetCheckedAndRefresh()`.

Both mixins accept a `selectable` option to control which items can be selected:

```ts
new GridRowSelectionMixin(this, {
    selectable: item => item.IsActive
});
```

## Row Operations

Common row operations on a grid:

```ts
// Get the item at a row index
const item = this.itemAt(row);

// Get the id of the item at a row index
const id = this.itemId(row);

// Get the row index for an item id
const row = this.rowById(id);

// Get the current items
const items = this.view.getItems();

// Reload from the server
this.view.populate();

// Refresh the grid
this.refresh();
```

## See Also

- [RowSelectionModel (API reference)](../api/js/sleekgrid/classes/RowSelectionModel.md) — the SleekGrid selection model.
- [GridRowSelectionMixin (API reference)](../api/js/corelib/classes/GridRowSelectionMixin.md) — checkbox multi-select.
- [GridRadioSelectionMixin (API reference)](../api/js/corelib/classes/GridRadioSelectionMixin.md) — radio single-select.
- [CellRange (API reference)](../api/js/sleekgrid/classes/CellRange.md) — selection ranges.
- [SleekGrid (API reference)](../api/js/sleekgrid/classes/SleekGrid.md) — the grid's selection methods.
- [DataGrid Architecture](architecture.md) — how grids fit together.
- [Frontend Framework Overview](../framework/ui/readme.md) — the three client-side packages and how they fit together.