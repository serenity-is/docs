# Data Binding and Change Events

This page covers how Serenity binds entity data to editors and how change events flow between widgets, dialogs, and grids.

## Binding Entities to Editors

The `PropertyGrid` binds an entity to its editors:

- `propertyGrid.load(entity)` — loads entity values into the editors (via `ISetEditValue`).
- `propertyGrid.save()` — collects edited values back into an entity (via `IGetEditValue`).
- `propertyGrid.value` — a shortcut for both.

The `EditorUtils` namespace provides lower-level helpers:

| Function | Purpose |
| --- | --- |
| `EditorUtils.getValue(editor)` | Reads an editor's value. |
| `EditorUtils.setValue(editor, value)` | Sets an editor's value. |
| `EditorUtils.saveValue(editor, item, target)` | Writes an editor's value into a target object. |
| `EditorUtils.getDisplayText(editor)` | Gets an editor's display text. |
| `EditorUtils.setReadonly(element, value)` | Sets read-only state. |

## Change Events

### Widget Change Events

The `Widget` base class provides change handlers:

```ts
this.change((e) => {
    // handle change
});

this.changeSelect2((e) => {
    // like change, but ignores changes from combobox value setting
});
```

These are namespaced with the widget's `uniqueName`, so they can be removed cleanly.

### Editor Change Events

Editors fire `change` events when their value changes. You can listen on the editor's element:

```ts
this.form.SomeField.element.on("change", () => {
    // react to the change
});
```

## Data Change Events Between Widgets

When a dialog saves or deletes an entity, it notifies its owner (usually a grid) so the grid can refresh. This uses the `ondatachange` event and the `SubDialogHelper`:

```ts
import { SubDialogHelper } from "@serenity-is/corelib";

// Bind a dialog's data change to an owner widget
SubDialogHelper.bindToDataChange(dialog, this, (e) => {
    this.refresh();
});

// Trigger a data change event on a dialog
SubDialogHelper.triggerDataChange(dialog);

// Bubble a dialog's data change up to its owner
SubDialogHelper.bubbleDataChange(dialog, this);
```

The `DataChangeInfo` event carries the operation type, entity id, and entity:

```ts
interface DataChangeInfo extends Event {
    operationType: string;  // insert / update / delete
    entityId: any;
    entity: any;
}
```

This is how `EntityGrid` refreshes after a dialog saves — the grid binds to the dialog's data change via `SubDialogHelper.bindToDataChange` and calls `subDialogDataChange()`.

## Busy States and Error Handling

Service calls show a blocking overlay by default (`blockUI: true`). You can control this per call:

```ts
await MyService.Save(request, undefined, { blockUI: false });
```

Errors are handled with `try/catch` or the `onError` option (see [Type-Safe Service Calls](service-calls.md)).

## See Also

- [EditorUtils (API reference)](../api/js/corelib/@serenity-is/namespaces/EditorUtils/README.md) — editor value helpers.
- [SubDialogHelper (API reference)](../api/js/corelib/@serenity-is/namespaces/SubDialogHelper/README.md) — data change coordination.
- [DataChangeInfo (API reference)](../api/js/corelib/interfaces/DataChangeInfo.md) — the data change event payload.
- [PropertyGrid and Forms](../editors/propertygrid.md) — binding entities to editors.
- [EntityDialog and CRUD Workflows](../dialogs/entitydialog.md) — how dialogs notify grids.
- [Type-Safe Service Calls](service-calls.md) — service calls and error handling.
- [Frontend Framework Overview](ui/readme.md) — the three client-side packages and how they fit together.