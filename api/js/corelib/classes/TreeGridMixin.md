[corelib](../README.md) / TreeGridMixin

# Class: TreeGridMixin\<TItem\>

Defined in: [src/ui/datagrid/treegridmixin.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L11)

A mixin that can be applied to a DataGrid for tree functionality

## Type Parameters

### TItem

`TItem`

## Constructors

### Constructor

> **new TreeGridMixin**\<`TItem`\>(`options`): `TreeGridMixin`\<`TItem`\>

Defined in: [src/ui/datagrid/treegridmixin.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L15)

#### Parameters

##### options

[`TreeGridMixinOptions`](../interfaces/TreeGridMixinOptions.md)\<`TItem`\>

#### Returns

`TreeGridMixin`\<`TItem`\>

## Methods

### collapseAll()

> **collapseAll**(): `void`

Defined in: [src/ui/datagrid/treegridmixin.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L59)

#### Returns

`void`

***

### expandAll()

> **expandAll**(): `void`

Defined in: [src/ui/datagrid/treegridmixin.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L64)

#### Returns

`void`

***

### toggleAll()

> **toggleAll**(): `void`

Defined in: [src/ui/datagrid/treegridmixin.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L52)

Expands / collapses all rows in a grid automatically

#### Returns

`void`

***

### applyTreeOrdering()

> `static` **applyTreeOrdering**\<`TItem`\>(`items`, `getId`, `getParentId`): `TItem`[]

Defined in: [src/ui/datagrid/treegridmixin.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L76)

Reorders a set of items so that parents comes before their children.
This method is required for proper tree ordering, as it is not so easy to perform with SQL.

#### Type Parameters

##### TItem

`TItem`

#### Parameters

##### items

`TItem`[]

list of items to be ordered

##### getId

(`item`) => `any`

a delegate to get ID of a record (must return same ID with grid identity field)

##### getParentId

(`item`) => `any`

a delegate to get parent ID of a record

#### Returns

`TItem`[]
