[@serenity-is/corelib](../README.md) / CheckLabelPosition

# Enumeration: CheckLabelPosition

Defined in: [src/ui/editors/booleaneditor.tsx:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/booleaneditor.tsx#L8)

Where the caption of a checkbox is, when it is rendered in a form field.

## Enumeration Members

### End

> **End**: `1`

Defined in: [src/ui/editors/booleaneditor.tsx:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/booleaneditor.tsx#L12)

The checkbox is first and the caption is after it, on the end side (right in LTR). It saves horizontal space, and lets several checkboxes share a row.

***

### EndAligned

> **EndAligned**: `2`

Defined in: [src/ui/editors/booleaneditor.tsx:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/booleaneditor.tsx#L14)

Like `End`, but the caption area before the checkbox is left empty, so the checkbox starts where the other editors do. For a checkbox alone in its row.

***

### Start

> **Start**: `0`

Defined in: [src/ui/editors/booleaneditor.tsx:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/booleaneditor.tsx#L10)

The default: the caption is at the start (left in LTR) in the caption area, and the checkbox is after it, where the other editors start.
