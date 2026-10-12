[@serenity-is/corelib](../README.md) / ColumnPickerDialogOptions

# Interface: ColumnPickerDialogOptions

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L30)

Options for the [ColumnPickerDialog](../classes/ColumnPickerDialog.md).

## Properties

### columns?

> `optional` **columns**: `Column`\<`any`\>[] \| () => `Column`\<`any`\>[]

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L32)

Columns to display in the picker, or a function returning them.

***

### dataGrid?

> `optional` **dataGrid**: [`IDataGrid`](IDataGrid.md)

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L38)

Data grid the picker is associated with.

***

### defaultOrder?

> `optional` **defaultOrder**: `string`[] \| () => `string`[]

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L34)

Default column order, or a function returning it.

***

### defaultVisible?

> `optional` **defaultVisible**: `string`[] \| () => `string`[]

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L36)

Default visible column ids, or a function returning them.

***

### onChange()?

> `optional` **onChange**: (`args`) => `Promise`\<`any`\>

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L42)

Callback invoked when the picker state changes.

#### Parameters

##### args

[`ColumnPickerChangeArgs`](../type-aliases/ColumnPickerChangeArgs.md)

#### Returns

`Promise`\<`any`\>

***

### reorderColumns()?

> `optional` **reorderColumns**: (`columnIds`, `setVisible?`) => `boolean`

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L46)

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

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L40)

SleekGrid instance the picker operates on.

***

### toggleColumns()?

> `optional` **toggleColumns**: (`columnIds`, `show?`) => `Column`\<`any`\>[]

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L44)

Custom handler for toggling column visibility.

#### Parameters

##### columnIds

`string`[]

##### show?

`boolean`

#### Returns

`Column`\<`any`\>[]
