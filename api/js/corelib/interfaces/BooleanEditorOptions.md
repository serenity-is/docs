[@serenity-is/corelib](../README.md) / BooleanEditorOptions

# Interface: BooleanEditorOptions

Defined in: [src/ui/editors/booleaneditor.tsx:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/booleaneditor.tsx#L22)

Options for the [BooleanEditor](../classes/BooleanEditor.md).

## Properties

### labelPosition?

> `optional` **labelPosition**: [`CheckLabelPosition`](../enumerations/CheckLabelPosition.md)

Defined in: [src/ui/editors/booleaneditor.tsx:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/booleaneditor.tsx#L29)

Where the field caption is, when the editor is rendered in a form field. At the start in the caption area by default.
With `End`, the checkbox is placed first and the caption is shown after it, on the end side (right in LTR), which
saves horizontal space and lets several checkboxes share a row. `EndAligned` leaves the caption area empty, so the
checkbox lines up with the other editors, for one that is alone in its row.
