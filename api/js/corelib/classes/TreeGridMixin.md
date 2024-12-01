[@serenity-is/corelib](../README.md) / TreeGridMixin

# Class: TreeGridMixin\<TItem\>

A mixin that can be applied to a DataGrid for tree functionality

## Type Parameters

• **TItem**

## Constructors

### new TreeGridMixin()

> **new TreeGridMixin**\<`TItem`\>(`options`): [`TreeGridMixin`](TreeGridMixin.md)\<`TItem`\>

#### Parameters

##### options

[`TreeGridMixinOptions`](../interfaces/TreeGridMixinOptions.md)\<`TItem`\>

#### Returns

[`TreeGridMixin`](TreeGridMixin.md)\<`TItem`\>

#### Defined in

[src/ui/datagrid/treegridmixin.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L14)

## Methods

### collapseAll()

> **collapseAll**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/treegridmixin.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L66)

***

### expandAll()

> **expandAll**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/treegridmixin.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L71)

***

### toggleAll()

> **toggleAll**(): `void`

Expands / collapses all rows in a grid automatically

#### Returns

`void`

#### Defined in

[src/ui/datagrid/treegridmixin.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L59)

***

### applyTreeOrdering()

> `static` **applyTreeOrdering**\<`TItem`\>(`items`, `getId`, `getParentId`): `TItem`[]

Reorders a set of items so that parents comes before their children.
This method is required for proper tree ordering, as it is not so easy to perform with SQL.

#### Type Parameters

• **TItem**

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

#### Defined in

[src/ui/datagrid/treegridmixin.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L83)
