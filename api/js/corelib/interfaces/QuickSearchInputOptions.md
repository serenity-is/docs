[@serenity-is/corelib](../README.md) / QuickSearchInputOptions

# Interface: QuickSearchInputOptions

## Table of contents

### Properties

- [fields](QuickSearchInputOptions.md#fields)
- [filteredParentClass](QuickSearchInputOptions.md#filteredparentclass)
- [loadingParentClass](QuickSearchInputOptions.md#loadingparentclass)
- [onSearch](QuickSearchInputOptions.md#onsearch)
- [typeDelay](QuickSearchInputOptions.md#typedelay)

## Properties

### fields

• `Optional` **fields**: [`QuickSearchField`](QuickSearchField.md)[]

#### Defined in

[src/ui/datagrid/quicksearchinput.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.ts#L16)

___

### filteredParentClass

• `Optional` **filteredParentClass**: `string`

#### Defined in

[src/ui/datagrid/quicksearchinput.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.ts#L14)

___

### loadingParentClass

• `Optional` **loadingParentClass**: `string`

#### Defined in

[src/ui/datagrid/quicksearchinput.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.ts#L13)

___

### onSearch

• `Optional` **onSearch**: (`p1`: `string`, `p2`: `string`, `p3`: (`p1`: `boolean`) => `void`) => `void`

#### Type declaration

▸ (`p1`, `p2`, `p3`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `string` |
| `p2` | `string` |
| `p3` | (`p1`: `boolean`) => `void` |

##### Returns

`void`

#### Defined in

[src/ui/datagrid/quicksearchinput.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.ts#L15)

___

### typeDelay

• `Optional` **typeDelay**: `number`

#### Defined in

[src/ui/datagrid/quicksearchinput.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.ts#L12)
