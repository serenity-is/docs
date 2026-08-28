# Cell Editing and EditorLock

SleekGrid supports inline cell editing. A column can specify an editor (via the `editor` property), and when the user activates a cell, the grid creates the editor, lets the user change the value, and commits it back to the row item.

> **StartSharp only:** If you are using the **StartSharp** template, you don't need to wire up inline editing manually. The `GridEditController` in `@serenity-is/pro.extensions` (Pro.Extensions) facilitates inline editing with more and automatic features on top of the base SleekGrid editing described on this page — such as inline add/edit/delete rows, auto-save, validation, undo, and an actions column. See [Grid Edit Controller](../startsharp/features/grid-edit-controller.md). The rest of this page documents the underlying SleekGrid editing mechanism that `GridEditController` builds on.

## Enabling Cell Editing

Cell editing is controlled by grid options. To enable it, set `editable: true` in the grid options and assign editors to columns:

```ts
protected override getSlickOptions() {
    const opt = super.getSlickOptions();
    opt.editable = true;
    opt.enableCellNavigation = true;
    return opt;
}
```

A column's editor is set through its `editor` property (an `EditorClass`):

```ts
column.editor = TextCellEdit;
```

## The Editor Contract

Every cell editor implements the `Editor` interface:

```ts
interface Editor {
    destroy(): void;
    applyValue(item: any, value: any): void;
    focus(): void;
    isValueChanged(): boolean;
    loadValue(item: any): void;
    serializeValue(): any;
    validate(): ValidationResult;
}
```

| Method | Purpose |
| --- | --- |
| `loadValue(item)` | Loads the item's field value into the editor. |
| `serializeValue()` | Reads the current editor value for commit. |
| `applyValue(item, value)` | Writes the serialized value back to the item. |
| `validate()` | Validates the current value; returns `{ valid, msg }`. |
| `isValueChanged()` | Whether the value differs from the loaded default. |
| `focus()` | Focuses the editor's input. |
| `destroy()` | Tears down the editor's DOM and listeners. |

## Built-in Cell Editors

SleekGrid ships these editors:

| Editor | Description |
| --- | --- |
| [TextCellEdit](../api/js/sleekgrid/classes/TextCellEdit.md) | Single-line text input. |
| [IntegerCellEdit](../api/js/sleekgrid/classes/IntegerCellEdit.md) | Integer input. |
| [FloatCellEdit](../api/js/sleekgrid/classes/FloatCellEdit.md) | Decimal input with fixed precision. |
| [DateCellEdit](../api/js/sleekgrid/classes/DateCellEdit.md) | Date picker. |
| [YesNoSelectCellEdit](../api/js/sleekgrid/classes/YesNoSelectCellEdit.md) | Yes/No dropdown. |
| [CheckboxCellEdit](../api/js/sleekgrid/classes/CheckboxCellEdit.md) | Checkbox. |
| [PercentCompleteCellEdit](../api/js/sleekgrid/classes/PercentCompleteCellEdit.md) | Percent slider with quick buttons. |
| [LongTextCellEdit](../api/js/sleekgrid/classes/LongTextCellEdit.md) | Detached textarea overlay for long text. |

## The Edit Flow

1. The user activates a cell (click or keyboard navigation).
2. The grid fires `onBeforeEditCell`; if a handler cancels, editing is skipped.
3. The grid creates the editor via the column's `editor` factory and calls `loadValue(item)`.
4. The user edits the value.
5. On commit (Enter, tab, or clicking another cell), the grid calls `serializeValue()`, then `validate()`.
6. If valid, `applyValue(item, value)` writes the value back, and `onCellChange` fires.
7. If invalid, `onValidationError` fires and the edit is not committed.

## EditorLock

`EditorLock` ensures only one edit is active at a time. It prevents concurrent edits and validation races — the grid queries the lock before navigating, sorting, or scrolling while an edit is open.

The grid uses the global `GlobalEditorLock` by default. You can access it via `grid.getEditorLock()`.

Key methods:

| Method | Purpose |
| --- | --- |
| `isActive(controller?)` | Whether an edit controller holds the lock. |
| `activate(controller)` | Acquires the lock (throws if another is active). |
| `deactivate(controller)` | Releases the lock. |
| `commitCurrentEdit()` | Commits the active edit (returns `false` if validation failed). |
| `cancelCurrentEdit()` | Cancels the active edit. |

## Committing and Cancelling from the Grid

The grid exposes editing methods:

- `editActiveCell(editor?)` — starts editing the active cell with the given (or column's) editor.
- `commitCurrentEdit()` — commits the current edit.
- `cancelCurrentEdit()` — cancels the current edit.

## Custom Cell Editors

A custom cell editor implements the `Editor` contract. The simplest approach is to extend `BaseCellEdit` (from the SleekGrid source) or implement `Editor` directly:

```ts
import { Editor, EditorOptions, ValidationResult } from "@serenity-is/sleekgrid";

export class MyCellEdit implements Editor {
    private input: HTMLInputElement;

    constructor(private args: EditorOptions) {
        this.input = this.args.container.appendChild(
            <input type="text" class="editor-text" /> as HTMLInputElement
        );
        this.input.focus();
    }

    destroy() { this.input.remove(); }
    focus() { this.input.focus(); }
    loadValue(item: any) { this.input.value = item[this.args.column.field] ?? ""; }
    serializeValue() { return this.input.value; }
    applyValue(item: any, value: any) { item[this.args.column.field] = value; }
    isValueChanged() { return this.input.value !== this.args.item[this.args.column.field]; }
    validate(): ValidationResult { return { valid: true }; }
}
```

## See Also

- [Editor (API reference)](../api/js/sleekgrid/interfaces/Editor.md) — the editor contract.
- [EditorLock (API reference)](../api/js/sleekgrid/classes/EditorLock.md) — the edit lock.
- [EditorOptions (API reference)](../api/js/sleekgrid/interfaces/EditorOptions.md) — editor construction options.
- [ValidationResult (API reference)](../api/js/sleekgrid/interfaces/ValidationResult.md) — validation result.
- [SleekGrid (API reference)](../api/js/sleekgrid/classes/SleekGrid.md) — the grid's editing methods.
- [DataGrid Architecture](architecture.md) — how SleekGrid fits into the grid stack.
- [Frontend Framework Overview](../framework/ui/readme.md) — the three client-side packages and how they fit together.