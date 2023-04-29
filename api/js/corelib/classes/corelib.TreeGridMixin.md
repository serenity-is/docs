[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / TreeGridMixin

# Class: TreeGridMixin<TItem\>

[corelib](../modules/corelib.md).TreeGridMixin

A mixin that can be applied to a DataGrid for tree functionality

## Type parameters

| Name |
| :------ |
| `TItem` |

## Table of contents

### Constructors

- [constructor](corelib.TreeGridMixin.md#constructor)

### Properties

- [dataGrid](corelib.TreeGridMixin.md#datagrid)
- [getId](corelib.TreeGridMixin.md#getid)
- [options](corelib.TreeGridMixin.md#options)

### Methods

- [collapseAll](corelib.TreeGridMixin.md#collapseall)
- [expandAll](corelib.TreeGridMixin.md#expandall)
- [toggleAll](corelib.TreeGridMixin.md#toggleall)
- [applyTreeOrdering](corelib.TreeGridMixin.md#applytreeordering)

## Constructors

### constructor

• **new TreeGridMixin**<`TItem`\>(`options`)

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`TreeGridMixinOptions`](../interfaces/corelib.TreeGridMixinOptions.md)<`TItem`\> |

#### Defined in

[src/ui/datagrid/treegridmixin.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#line&#x3D;14)

## Properties

### dataGrid

• `Private` **dataGrid**: [`DataGrid`](corelib.DataGrid.md)<`TItem`, `any`\>

#### Defined in

[src/ui/datagrid/treegridmixin.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#line&#x3D;11)

___

### getId

• `Private` **getId**: (`item`: `TItem`) => `any`

#### Type declaration

▸ (`item`): `any`

##### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |

##### Returns

`any`

#### Defined in

[src/ui/datagrid/treegridmixin.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#line&#x3D;12)

___

### options

• `Private` **options**: [`TreeGridMixinOptions`](../interfaces/corelib.TreeGridMixinOptions.md)<`TItem`\>

#### Defined in

[src/ui/datagrid/treegridmixin.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#line&#x3D;14)

## Methods

### collapseAll

▸ **collapseAll**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/treegridmixin.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#line&#x3D;66)

___

### expandAll

▸ **expandAll**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/treegridmixin.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#line&#x3D;71)

___

### toggleAll

▸ **toggleAll**(): `void`

Expands / collapses all rows in a grid automatically

#### Returns

`void`

#### Defined in

[src/ui/datagrid/treegridmixin.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#line&#x3D;59)

___

### applyTreeOrdering

▸ `Static` **applyTreeOrdering**<`TItem`\>(`items`, `getId`, `getParentId`): `TItem`[]

Reorders a set of items so that parents comes before their children.
This method is required for proper tree ordering, as it is not so easy to perform with SQL.

#### Type parameters

| Name |
| :------ |
| `TItem` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `items` | `TItem`[] | list of items to be ordered |
| `getId` | (`item`: `TItem`) => `any` | a delegate to get ID of a record (must return same ID with grid identity field) |
| `getParentId` | (`item`: `TItem`) => `any` | a delegate to get parent ID of a record |

#### Returns

`TItem`[]

#### Defined in

[src/ui/datagrid/treegridmixin.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#line&#x3D;83)
