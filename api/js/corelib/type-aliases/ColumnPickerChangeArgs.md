[@serenity-is/corelib](../README.md) / ColumnPickerChangeArgs

# Type Alias: ColumnPickerChangeArgs

> **ColumnPickerChangeArgs** = `object`

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L18)

Arguments passed to the column picker change callback when columns are
toggled, reordered, or restored to defaults.

## Properties

### reorderedColumns

> **reorderedColumns**: `boolean`

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L22)

Whether columns were reordered.

***

### restoredDefaults

> **restoredDefaults**: `boolean`

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L24)

Whether the default column order/visibility was restored.

***

### toggledColumns

> **toggledColumns**: `Column`[]

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L20)

Columns whose visibility was toggled.
