[@serenity-is/corelib](../README.md) / ColumnPickerChangeArgs

# Type Alias: ColumnPickerChangeArgs

> **ColumnPickerChangeArgs** = `object`

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L19)

Arguments passed to the column picker change callback when columns are
toggled, reordered, or restored to defaults.

## Properties

### reorderedColumns

> **reorderedColumns**: `boolean`

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L23)

Whether columns were reordered.

***

### restoredDefaults

> **restoredDefaults**: `boolean`

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L25)

Whether the default column order/visibility was restored.

***

### toggledColumns

> **toggledColumns**: `Column`[]

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L21)

Columns whose visibility was toggled.
