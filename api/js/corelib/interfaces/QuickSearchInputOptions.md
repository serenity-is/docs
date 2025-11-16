[corelib](../README.md) / QuickSearchInputOptions

# Interface: QuickSearchInputOptions

Defined in: [src/ui/datagrid/quicksearchinput.tsx:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L10)

## Properties

### fields?

> `optional` **fields**: [`QuickSearchField`](QuickSearchField.md)[]

Defined in: [src/ui/datagrid/quicksearchinput.tsx:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L15)

***

### filteredParentClass?

> `optional` **filteredParentClass**: `string`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L13)

***

### loadingParentClass?

> `optional` **loadingParentClass**: `string`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L12)

***

### onSearch()?

> `optional` **onSearch**: (`field`, `query`, `done`) => `void`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L14)

#### Parameters

##### field

`string`

##### query

`string`

##### done

(`found`) => `void`

#### Returns

`void`

***

### typeDelay?

> `optional` **typeDelay**: `number`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L11)
