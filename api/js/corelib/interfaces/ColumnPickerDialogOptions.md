[@serenity-is/corelib](../README.md) / ColumnPickerDialogOptions

# Interface: ColumnPickerDialogOptions

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L21)

## Properties

### columns?

> `optional` **columns**: `Column`\<`any`\>[] \| () => `Column`\<`any`\>[]

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L22)

***

### dataGrid?

> `optional` **dataGrid**: [`IDataGrid`](IDataGrid.md)

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L25)

***

### defaultOrder?

> `optional` **defaultOrder**: `string`[] \| () => `string`[]

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L23)

***

### defaultVisible?

> `optional` **defaultVisible**: `string`[] \| () => `string`[]

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L24)

***

### onChange()?

> `optional` **onChange**: (`args`) => `Promise`\<`any`\>

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L27)

#### Parameters

##### args

[`ColumnPickerChangeArgs`](../type-aliases/ColumnPickerChangeArgs.md)

#### Returns

`Promise`\<`any`\>

***

### reorderColumns()?

> `optional` **reorderColumns**: (`columnIds`, `setVisible?`) => `boolean`

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L29)

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

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L26)

***

### toggleColumns()?

> `optional` **toggleColumns**: (`columnIds`, `show?`) => `Column`\<`any`\>[]

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L28)

#### Parameters

##### columnIds

`string`[]

##### show?

`boolean`

#### Returns

`Column`\<`any`\>[]
