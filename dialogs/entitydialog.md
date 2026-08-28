# EntityDialog and CRUD Workflows

`EntityDialog` is the base class for edit dialogs in Serenity. It hosts a `PropertyGrid` for editing an entity and provides the full CRUD workflow: loading (retrieve), saving (create/update), deleting, undeleting, and the toolbar buttons that drive these operations.

## The Dialog Hierarchy

| Class | Purpose |
| --- | --- |
| `BaseDialog` | Base dialog with modal/panel behavior, title, and buttons. |
| `PropertyDialog` | A dialog that edits a single entity's properties with a property grid and OK/Cancel buttons. |
| `EntityDialog` | The full CRUD dialog: property grid + save/delete/undelete + localization + toolbar buttons. |

## Creating an EntityDialog

A typical generated dialog extends `EntityDialog` and overrides a few methods:

```ts
export class LanguageDialog<P = {}> extends EntityDialog<LanguageRow, P> {
    static override[Symbol.typeInfo] = this.registerClass(nsAdministration);

    protected override getFormKey() { return LanguageForm.formKey; }
    protected override getRowDefinition() { return LanguageRow; }
    protected override getService() { return LanguageService.baseUrl; }
}
```

| Method | Purpose |
| --- | --- |
| `getFormKey()` | The form script key (e.g. `LanguageForm.formKey`). |
| `getRowDefinition()` | The row class (provides permissions, id property, etc.). |
| `getService()` | The service base URL (e.g. `LanguageService.baseUrl`). |

## The Lifecycle

### Initialization

The constructor loads the property items (form definition), then initializes the property grid and localizer:

1. `getPropertyItemsData()` loads the form's `PropertyItem[]`.
2. `propertyItemsReady()` calls `initPropertyGrid()` and `initLocalizer()`.
3. `afterInit()` is called as a hook for subclasses.

### Loading an Entity

`load(entityOrId, done, fail)` loads an entity into the dialog:

- If `entityOrId` is `null`, a new empty entity is loaded.
- If it's a string/number, the dialog calls the retrieve service (`.../Retrieve`) via `loadById()`.
- If it's an object, it's loaded directly.

```ts
dialog.load(entityOrId, () => {
    dialog.dialogOpen(asPanel);
});
```

### Saving

`save(callback, initiator)` validates the form, builds a `SaveRequest`, and calls the save service (`.../Create` or `.../Update`):

1. `validateBeforeSave()` — validate the form (override to add custom validation).
2. `getSaveRequest()` — builds the `SaveRequest` from the property grid values.
3. `saveHandler()` — calls the service.
4. `onSaveSuccess()` — handles the response (e.g. notifying the grid to refresh).

### Deleting and Undeleting

- `doDelete(callback)` — calls the delete service (`.../Delete`).
- `undelete(callback)` — calls the undelete service (`.../Undelete`).

Both show a confirmation dialog first.

## Toolbar Buttons

`getToolbarButtons()` builds the standard buttons:

| Button | Action |
| --- | --- |
| **Save and Close** | Saves and closes the dialog. |
| **Apply Changes** | Saves and reloads the entity (stays open). |
| **Delete** | Deletes the entity (edit mode, not deleted). |
| **Undelete** | Restores a deleted entity. |
| **Edit** | Switches from view mode to edit mode. |
| **Clone** | Creates a copy of the entity. |
| **Localization** | Opens the localization dialog. |

Each button's visibility and disabled state are controlled by the dialog's mode and permissions:

```ts
saveAndCloseToolButton({
    onClick: async () => {
        if (!(await this.commitEdits()))
            return;
        this.save(() => this.dialogClose("save-and-close"), "save-and-close")
    },
    visible: () => !this.isDeleted() && !this.isViewMode(),
    disabled: () => !this.hasSavePermission() || this.readOnly,
    ref: el => this.saveAndCloseButton = Fluent(el)
})
```

## Permissions

The dialog checks permissions from the row definition:

| Method | Permission |
| --- | --- |
| `hasSavePermission()` | Row's `insertPermission`/`updatePermission`. |
| `hasDeletePermission()` | Row's `deletePermission`. |

## Modes

The dialog has several modes:

- **Edit mode** — editing an existing entity.
- **Insert mode** — creating a new entity.
- **View mode** — read-only view (with an Edit button).
- **Deleted** — the entity is soft-deleted (shows Undelete).

These are checked with `isEditMode()`, `isViewMode()`, `isDeleted()`, etc.

## See Also

- [EntityDialog (API reference)](../api/js/corelib/classes/EntityDialog.md) — the full `EntityDialog` API.
- [PropertyDialog (API reference)](../api/js/corelib/classes/PropertyDialog.md) — the property dialog base.
- [BaseDialog (API reference)](../api/js/corelib/classes/BaseDialog.md) — the base dialog.
- [PropertyGrid and Forms](../editors/propertygrid.md) — the form engine inside the dialog.
- [EntityGrid CRUD](../grids/entitygrid-crud.md) — the grid side of CRUD.
- [Type Registration](../framework/ui/type-registration.md) — registering dialog types.
- [Frontend Framework Overview](../framework/ui/readme.md) — the three client-side packages and how they fit together.