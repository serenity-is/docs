# EntityGrid CRUD Workflows

`EntityGrid` extends `DataGrid` and adds entity/CRUD integration: service calls, dialogs, routing, permissions, and the standard toolbar buttons. This page walks through the CRUD workflow — how a grid loads, adds, edits, and deletes entities.

## The CRUD Flow

1. **List** — the grid's `RemoteView` calls the list service (e.g. `Administration/User/List`) to load rows.
2. **Add** — clicking the add button opens a new-item dialog.
3. **Edit** — clicking an edit link (or a hash route like `#edit/123`) opens an edit dialog.
4. **Save** — the dialog calls the save service (`.../Create` or `.../Update`).
5. **Delete** — the dialog (or a delete button) calls the delete service (`.../Delete`).
6. **Refresh** — after a dialog saves or deletes, the grid refreshes to reflect the change.

## Service Integration

The grid determines its service from `getService()`. By default this is derived from the entity type (e.g. `Administration.User` → `Administration/User`), but generated grids override it explicitly:

```ts
protected override getService() { return UserService.baseUrl; }
```

The list request is sent to `~/Services/<service>/List` (see `getServiceUrl()` / `getServiceMethod()`).

## Opening Dialogs

The add button calls `addButtonClick()`, which calls `editItem(new Object())`. `editItem()` creates the dialog via `createEntityDialog()`, loads the entity (or a new instance), and opens it:

```ts
protected override editItem(entityOrId: any): void {
    this.createEntityDialog(this.getItemType(), dlg => {
        var dialog = safeCast(dlg, IEditDialog);
        if (dialog != null) {
            dialog.load(entityOrId, () => {
                dialog.dialogOpen(this.openDialogsAsPanel ?? DataGrid.defaultOptions.openDialogsAsPanel);
            });
            return;
        }
        // ...
    });
}
```

The dialog type is resolved by `getDialogType()`, which looks it up in the `DialogTypeRegistry` (and can load it lazily).

## Routing

`EntityGrid` handles hash-based routing. When the URL hash is `#new` or `#edit/123`, the grid opens the corresponding dialog:

- `#new` — opens a new-item dialog.
- `#edit/123` — opens an edit dialog for id `123`.
- `#SomeType/new` or `#SomeType/edit/123` — for polymorphic item types.

This is wired in the constructor via the `handleroute` event, and `routeDialog()` keeps the hash in sync with the open dialog.

## Permissions

The grid checks permissions from the row definition to enable/disable actions:

| Method | Permission |
| --- | --- |
| `hasInsertPermission()` | `getInsertPermission()` (row's `insertPermission`) |
| `hasUpdatePermission()` | `getUpdatePermission()` (row's `updatePermission`) |
| `hasDeletePermission()` | `getDeletePermission()` (row's `deletePermission`) |

For example, the add button is disabled when the user lacks insert permission:

```ts
buttons.push({
    title: this.getAddButtonCaption(),
    action: 'add',
    cssClass: 'add-button',
    icon: faIcon("plus-circle", "green"),
    hotkey: 'alt+n',
    onClick: () => { this.addButtonClick(); },
    disabled: () => !this.hasInsertPermission() || this.readOnly
});
```

## Toolbar Buttons

`getButtons()` builds the standard toolbar:

- **Add** — opens a new-item dialog (disabled without insert permission).
- **Refresh** — reloads the grid.
- **Column Picker** — lets users choose visible columns.
- **Filter** — opens the advanced filter dialog.

`createToolbarExtensions()` adds the include-deleted toggle (when the row has an is-active/is-deleted property) and the quick search input.

## Refreshing After a Dialog Saves

When a dialog saves or deletes, it notifies the grid through `SubDialogHelper.bindToDataChange`, which calls `subDialogDataChange()`. This refreshes the grid so the new data appears.

## See Also

- [EntityGrid (API reference)](../api/js/corelib/classes/EntityGrid.md) — the full `EntityGrid` API.
- [DataGrid (API reference)](../api/js/corelib/classes/DataGrid.md) — the base grid API.
- [DataGrid Architecture](architecture.md) — how the grid stack fits together.
- [Creating and Configuring Grids](creating-grids.md) — building grids step by step.
- [EntityDialog and CRUD Workflows](../dialogs/entitydialog.md) — the dialog side of CRUD.
- [Authorization and Permissions](../framework/authorization-client.md) — permission-based UI.
- [Frontend Framework Overview](../framework/ui/readme.md) — the three client-side packages and how they fit together.