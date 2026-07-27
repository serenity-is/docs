[@serenity-is/corelib](../README.md) / QuickSearchInputOptions

# Interface: QuickSearchInputOptions

Defined in: [src/ui/datagrid/quicksearchinput.tsx:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L17)

## Properties

### beforeSearch()?

> `optional` **beforeSearch**: (`args`) => `void`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L24)

#### Parameters

##### args

[`QuickSearchArgs`](QuickSearchArgs.md)

#### Returns

`void`

***

### fields?

> `optional` **fields**: [`QuickSearchField`](QuickSearchField.md)[]

Defined in: [src/ui/datagrid/quicksearchinput.tsx:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L20)

***

### filteredParentClass?

> `optional` **filteredParentClass**: `string`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L21)

***

### loadingParentClass?

> `optional` **loadingParentClass**: `string`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L19)

***

### ~~onSearch()?~~

> `optional` **onSearch**: (`field`, `query`, `done`) => `void`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L23)

#### Parameters

##### field

`string`

##### query

`string`

##### done

(`found?`) => `void`

#### Returns

`void`

#### Deprecated

Prefer search

***

### search()?

> `optional` **search**: (`args`) => `void`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L25)

#### Parameters

##### args

[`QuickSearchArgs`](QuickSearchArgs.md)

#### Returns

`void`

***

### typeDelay?

> `optional` **typeDelay**: `number`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L18)
