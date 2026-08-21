[@serenity-is/corelib](../README.md) / ColumnPickerDialogOptions

# Interface: ColumnPickerDialogOptions

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L31)

Options for the [ColumnPickerDialog](../classes/ColumnPickerDialog.md).

## Properties

### columns?

> `optional` **columns**: `Column`\<`any`\>[] \| () => `Column`\<`any`\>[]

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L33)

Columns to display in the picker, or a function returning them.

***

### dataGrid?

> `optional` **dataGrid**: [`IDataGrid`](IDataGrid.md)

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L39)

Data grid the picker is associated with.

***

### defaultOrder?

> `optional` **defaultOrder**: `string`[] \| () => `string`[]

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L35)

Default column order, or a function returning it.

***

### defaultVisible?

> `optional` **defaultVisible**: `string`[] \| () => `string`[]

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L37)

Default visible column ids, or a function returning them.

***

### onChange()?

> `optional` **onChange**: (`args`) => `Promise`\<`any`\>

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L43)

Callback invoked when the picker state changes.

#### Parameters

##### args

[`ColumnPickerChangeArgs`](../type-aliases/ColumnPickerChangeArgs.md)

#### Returns

`Promise`\<`any`\>

***

### reorderColumns()?

> `optional` **reorderColumns**: (`columnIds`, `setVisible?`) => `boolean`

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L47)

Custom handler for reordering columns.

#### Parameters

##### columnIds

`string`[]

##### setVisible?

`string`[]

#### Returns

`boolean`

***

### sleekGrid?

> `optional` **sleekGrid**: `ISleekGrid`

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L41)

SleekGrid instance the picker operates on.

***

### toggleColumns()?

> `optional` **toggleColumns**: (`columnIds`, `show?`) => `Column`\<`any`\>[]

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L45)

Custom handler for toggling column visibility.

#### Parameters

##### columnIds

`string`[]

##### show?

`boolean`

#### Returns

`Column`\<`any`\>[]
