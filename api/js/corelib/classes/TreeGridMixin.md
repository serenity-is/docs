[@serenity-is/corelib](../README.md) / TreeGridMixin

# Class: TreeGridMixin\<TItem\>

Defined in: [src/ui/datagrid/treegridmixin.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L14)

Adds tree / hierarchy support to a [DataGrid](DataGrid.md) by handling indentation,
expand/collapse toggles, and parent-before-child ordering.
Attach by constructing the mixin with the target grid and hierarchy options.

## Type Parameters

### TItem

`TItem`

Row type displayed in the grid.

## Constructors

### Constructor

> **new TreeGridMixin**\<`TItem`\>(`options`): `TreeGridMixin`\<`TItem`\>

Defined in: [src/ui/datagrid/treegridmixin.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L23)

Creates a tree mixin for the specified grid.

#### Parameters

##### options

[`TreeGridMixinOptions`](../interfaces/TreeGridMixinOptions.md)\<`TItem`\>

Hierarchy configuration including grid reference and parent id accessor.

#### Returns

`TreeGridMixin`\<`TItem`\>

## Methods

### collapseAll()

> **collapseAll**(): `void`

Defined in: [src/ui/datagrid/treegridmixin.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L72)

Collapses all rows in the associated grid.

#### Returns

`void`

***

### expandAll()

> **expandAll**(): `void`

Defined in: [src/ui/datagrid/treegridmixin.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L78)

Expands all rows in the associated grid.

#### Returns

`void`

***

### toggleAll()

> **toggleAll**(): `void`

Defined in: [src/ui/datagrid/treegridmixin.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L64)

Toggles all rows between collapsed and expanded.
If every row is collapsed, all rows are expanded and vice versa.

#### Returns

`void`

***

### applyTreeOrdering()

> `static` **applyTreeOrdering**\<`TItem`\>(`items`, `getId`, `getParentId`): `TItem`[]

Defined in: [src/ui/datagrid/treegridmixin.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L90)

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
