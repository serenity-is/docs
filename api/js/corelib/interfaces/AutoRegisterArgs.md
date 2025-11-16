[corelib](../README.md) / AutoRegisterArgs

# Interface: AutoRegisterArgs\<P, T\>

Defined in: [src/ui/datagrid/datagrid-autoregisterargs.tsx:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-autoregisterargs.tsx#L7)

Arguments for auto register callback

## Type Parameters

### P

`P` = `any`

### T

`T` = `any`

## Properties

### cancel

> **cancel**: `boolean`

Defined in: [src/ui/datagrid/datagrid-autoregisterargs.tsx:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-autoregisterargs.tsx#L10)

Set to true to cancel the auto register process for this grid / dataGrid

***

### dataGrid?

> `optional` **dataGrid**: [`DataGrid`](../classes/DataGrid.md)\<`any`, \{ \}\>

Defined in: [src/ui/datagrid/datagrid-autoregisterargs.tsx:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-autoregisterargs.tsx#L12)

The data grid instance if available

***

### options

> **options**: `Partial`\<`P`\>

Defined in: [src/ui/datagrid/datagrid-autoregisterargs.tsx:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-autoregisterargs.tsx#L20)

Options that can be modified by the callback, which are passed to the plugin/mixin constructor.
Note that the options set here only applies to the auto registered instance and 
not to any manually created instance.

***

### pluginType()

> **pluginType**: (`props`) => `T`

Defined in: [src/ui/datagrid/datagrid-autoregisterargs.tsx:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-autoregisterargs.tsx#L8)

#### Parameters

##### props

`P`

#### Returns

`T`

***

### sleekGrid?

> `optional` **sleekGrid**: `ISleekGrid`

Defined in: [src/ui/datagrid/datagrid-autoregisterargs.tsx:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/datagrid-autoregisterargs.tsx#L14)

The ISleekGrid instance
