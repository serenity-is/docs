# Grid Edit Controller (Inline Editing)

`GridEditController` is a StartSharp-only feature from `@serenity-is/pro.extensions` (Pro.Extensions) that enables inline editing on grids with many automatic features on top of the base SleekGrid editing mechanism.

It lets users edit grid cells directly — add, update, and delete rows inline — without opening a dialog, and handles saving, validation, undo, and an actions column for you.

## Enabling Inline Editing

Create a `GridEditController` in the grid's `afterInit` method, passing the grid and options:

```ts
import { EntityGrid, gridPageInit } from "@serenity-is/corelib";
import { ProductColumns, ProductDialog, ProductRow, ProductService } from "@serenity-is/demo.northwind";
import { GridEditController } from "@serenity-is/pro.extensions";

export class ProductInlineEditingGrid<P = {}> extends EntityGrid<ProductRow, P> {
    static override[Symbol.typeInfo] = this.registerClass(nsDemoAdvancedSamples);

    protected override getColumnsKey() { return ProductColumns.columnsKey; }
    protected override getDialogType() { return ProductDialog; }
    protected override getRowDefinition() { return ProductRow; }
    protected override getService() { return ProductService.baseUrl; }

    declare protected editController: GridEditController<ProductRow>;

    protected override afterInit() {
        super.afterInit();

        this.editController = new GridEditController({
            grid: this,
            actionsColumn: ProductColumns.Fields.ProductID,
            appendActions: true,
            addRow: "top",
            addRowFrozen: true,
            deleteRowViaKey: true,
            editorParams: {
                inplaceAdd: false
            },
        });
    }

    protected override getButtons() {
        const buttons = super.getButtons();

        buttons.push(GridEditController.undoButton(() => this.editController));
        buttons.push(GridEditController.saveChangesButton(() => this.editController));

        return buttons;
    }
}
```

This example (from the Advanced Samples `InlineEditing` page) enables inline editing with:

- An **actions column** on `ProductID` with append actions.
- An **add row** at the top, frozen so it stays visible.
- **Delete via Ctrl+Delete**.
- **Undo** and **Save Changes** toolbar buttons.

## Key Options

`GridEditController` accepts a `GridEditOptions` object. The most important options:

| Option | Description |
| --- | --- |
| `grid` | The `DataGrid` to enable inline editing on (required). |
| `actionsColumn` | Column id for the actions (apply/delete/add-row icon). Default `"RowEditActions"`. |
| `appendActions` | Append actions to the existing column formatter instead of replacing it (`true`, `"before"`, or `"after"`). |
| `addRow` | Enable inline adding of new rows. `true`/`"bottom"` adds at the bottom, `"top"` at the top. |
| `addRowFrozen` | Keep the add row always visible (frozen). Requires `autoAdd` and the enhanced layout. |
| `autoAdd` | Automatically add a new item when editing the add row (e.g. when moving outside it). |
| `autoSave` | Automatically save changes when a cell is changed. |
| `saveLocally` | Save changes on the client side without calling a service. |
| `deleteRowViaKey` | Allow deleting items with Ctrl+Delete. |
| `commitRowViaKey` | Commit and save active row edits with Ctrl+Enter. |
| `undoRowDblEsc` | Cancel all changes in a row with Escape twice. |
| `showDeleteAction` | Show a delete action for each data row (requires `actionsColumn`). |
| `showDeleteConfirmation` | Show a confirmation dialog before deleting. |
| `showValidationError` | Show validation errors. |
| `required` | Whether a cell must have a value (defaults from `propertyItem.required`). |
| `validator` | A callback to validate a value; return an error message or null. |
| `editable` | A callback to decide if a cell is editable. |
| `canEditItem` / `canDeleteItem` | Callbacks to decide whether an item can be edited/deleted. |
| `editorType` / `editorParams` / `editorInit` | Control the editor used for cells. |
| `afterCommitEdit` | Called after a cell edit is committed. |
| `afterSaveChanges` | Called after all changes are saved. |
| `refreshAfterSave` | Whether to refresh the grid after saving (default `true`). |
| `resetOnLoad` | Reset all changes when grid data is loaded. |
| `createServiceMethod` / `updateServiceMethod` / `deleteServiceMethod` | Service methods for create/update/delete. |
| `saveHandler` / `deleteHandler` / `bulkSaveHandler` | Custom save/delete handlers. |
| `hasInsertPermission` / `hasUpdatePermission` / `hasDeletePermission` | Permission checks. |
| `isReadOnly` | Whether the grid is read-only. |

## The Actions Column

The actions column shows per-row actions like apply, delete, and add-row icons. You can create it:

- **Server-side** — add a property to your columns class:

  ```cs
  [GridEditActionsColumn]
  public object GridEditActions { get; set; }
  ```

- **Client-side** — use `GridEditController.createActionColumn` to create a column and add it to the grid's columns.

## Toolbar Buttons

`GridEditController` provides static helpers to create toolbar buttons:

```ts
buttons.push(GridEditController.undoButton(() => this.editController));
buttons.push(GridEditController.saveChangesButton(() => this.editController));
```

- `saveChangesButton(controller)` — a "Save Changes" button, disabled when there are no pending changes.
- `undoButton(controller)` — an "Undo Changes" button, disabled when there are no pending changes.

## Saving and Undoing

- `saveChanges()` — saves all pending changes (create/update/delete) to the server (or locally when `saveLocally` is set).
- `undoChanges()` — reverts all pending changes.
- `isDirty()` — whether there are unsaved changes.

## Using GridEditController in a Grid Editor

`GridEditController` also works inside a grid editor (a `GridEditorBase`-derived editor used in a master-detail form). The Advanced Samples `InlineGridEditor` page shows this — an `OrderDetailsEditor` gets inline editing with auto-save, add-row, and a custom validator:

```ts
export class InlineOrderDetailsEditor<P = {}> extends OrderDetailsEditor {
    static override[Symbol.typeInfo] = this.registerClass(nsDemoAdvancedSamples);

    declare protected editController: GridEditController<ProductRow>;

    protected override afterInit() {
        super.afterInit();

        const fld = OrderDetailColumns.Fields;

        this.editController = new GridEditController({
            grid: this,
            addRow: true,
            autoSave: true,
            deleteRowViaKey: true,
            addRowInit: item => {
                if (this.connectedMode)
                    item.OrderID = this.orderId;
            },
            editorParams: () => ({ inplaceAdd: false }),
            afterCommitEdit: args => {
                if ([fld.Quantity, fld.Discount, fld.UnitPrice].includes(args.column?.id)) {
                    const item = args.item;
                    item.LineTotal = (item.Quantity || 0) * (item.UnitPrice || 0) - (item.Discount || 0);
                }
            },
            validator: (value, args) => {
                if (args.column?.field === fld.ProductName) {
                    const productId = toId(value);
                    const sameProduct = this.view.getItems().find(x => x.ProductID === productId);
                    if (sameProduct && this.itemId(sameProduct) !== this.itemId(args.item)) {
                        return "This product is already in order details!";
                    }
                }
                return null;
            }
        });
    }
}
```

When using a grid editor inside a dialog, remember to commit any pending edit before saving the dialog — override `validateBeforeSave`:

```ts
override validateBeforeSave() {
    if (!this.form.DetailList.getGrid().commitCurrentEdit())
        return false;
    return super.validateBeforeSave();
}
```

## How It Works

`GridEditController` builds on the base SleekGrid cell editing mechanism (see [Cell Editing](../../grids/cell-editing.md)). It:

- Sets the grid's `editable`, `editorFactory`, `enableCellNavigation`, `autoEdit`, and `editCommandHandler` options.
- Provides an `EditorFactory` that resolves the right editor for each cell (from the column's `editableProperty`/`sourceItem`, or the `editorType` option).
- Wraps editors in a `GridEditWrapper` that adapts Serenity editors to the SleekGrid `Editor` contract.
- Tracks dirty/new/deleted items and handles saving, validation, and undo.
- Adds the actions column and per-row actions.

## See Also

- [Cell Editing](../../grids/cell-editing.md) — the underlying SleekGrid editing mechanism.
- [DataGrid Architecture](../../grids/architecture.md) — how grids fit together.
- [Creating and Configuring Grids](../../grids/creating-grids.md) — building grids.
- The `GridEditController` implementation lives in `pro-features/src/pro.extensions/Modules/GridEditing/` (`GridEditController.tsx`, `GridEditOptions.ts`, `GridEditWrapper.ts`).