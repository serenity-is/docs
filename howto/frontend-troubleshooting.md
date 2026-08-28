# Frontend Troubleshooting

This page covers common client-side issues in Serene/StartSharp applications and how to fix them.

## Type Registration Failures

### "The editor class 'X' was not found"

This error appears when the `EditorTypeRegistry` cannot find an editor type by its key. The error message itself suggests the fix:

```
The editor class "MyProject.MyModule.MyEditor" was not found.

Ensure that the editor type includes a line similar to the following (using the correct full name):
static [Symbol.typeInfo] = this.registerEditor("MyProject.MyModule.MyEditor");

Also, side-effect import this editor class from the current page.ts, grid.ts, or dialog.ts file. For example:
import "./path/to/MyEditor.ts";

After applying the fixes, build the project by running "npm run build" from the project folder.
```

Common causes:

- The editor is not registered with `registerEditor` (or `formatterTypeInfo` for formatters).
- The editor module is not **side-effect imported** — the class must be imported somewhere so its `static { registerType(this) }` block runs.
- The type name doesn't match the key used in the form/column metadata.

### "The element already has widget 'X'!"

Only one widget of the same class can be attached to an element. If you create a second widget of the same class on the same element, this error is thrown. Use a different element, or destroy the existing widget first.

## Missing Grid Refreshes

If a grid doesn't refresh after a dialog saves:

- The dialog must notify the grid via `SubDialogHelper.bindToDataChange` (EntityGrid does this automatically).
- Check that the dialog's `onSaveSuccess` runs and that the grid's `subDialogDataChange()` is called.
- If you open a dialog manually, bind it to the grid yourself:

```ts
SubDialogHelper.bindToDataChange(dialog, this, () => {
    this.refresh();
});
```

## Binding Issues

### Editor value not loading/saving

- The editor must implement the value interfaces the form expects (`IGetEditValue`/`ISetEditValue`, or `IStringValue`/`IDoubleValue`/`IBooleanValue`).
- Check that the editor is registered with the correct interfaces:

```ts
static override[Symbol.typeInfo] = this.registerEditor("MyApp.MyEditor", [IGetEditValue, ISetEditValue]);
```

- For custom editors, verify `get_value`/`set_value` (or `getEditValue`/`setEditValue`) are implemented correctly.

## Signal Updates Not Reflecting

If a signal-driven DOM update doesn't appear:

- Make sure the signal is actually being read inside the JSX (e.g. `{count}` or `class={sig}`), not just assigned once.
- Check that the signal is being mutated via `.value = ...`, not reassigned.
- If the element was removed and re-added, the signal subscription may have been disposed — re-render the element.

## Validation Not Working

- Validation rules are attached with `addValidationRule` and run on form submit.
- A rule returns `null`/empty for valid, a string for invalid.
- If a field isn't validated, check that it has a `name` attribute and is inside the form.

## Service Errors

### "NotAuthorized" / session expired

- The user's session expired. Configure `Config.notLoggedInHandler` to redirect to login:

```ts
Config.notLoggedInHandler = () => window.location.href = "/Account/Login";
```

### Service call fails with a validation error

- The server returned a `ServiceError`. Handle it with `try/catch` or `onError`:

```ts
try {
    await MyService.Save(request);
}
catch (e) {
    notifyError(e.Message);
}
```

## See Also

- [Frontend Patterns Cookbook](frontend-patterns-cookbook.md) — complete working examples.
- [Type Registration](../framework/ui/type-registration.md) — registering types.
- [Data Binding](../framework/data-binding.md) — binding and change events.
- [Signals and Reactivity](../framework/ui/signals.md) — reactive updates.
- [Custom Editors](../editors/custom-editors.md) — validation and custom editors.
- [Type-Safe Service Calls](../framework/service-calls.md) — service errors.
- [Frontend Framework Overview](../framework/ui/readme.md) — the three client-side packages and how they fit together.