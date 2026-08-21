[@serenity-is/corelib](../README.md) / QuickSearchInputOptions

# Interface: QuickSearchInputOptions

Defined in: [src/ui/datagrid/quicksearchinput.tsx:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L32)

Options for the [QuickSearchInput](../classes/QuickSearchInput.md) widget.

## Properties

### beforeSearch()?

> `optional` **beforeSearch**: (`args`) => `void`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L44)

Callback invoked before the search is executed.

#### Parameters

##### args

[`QuickSearchArgs`](QuickSearchArgs.md)

#### Returns

`void`

***

### fields?

> `optional` **fields**: [`QuickSearchField`](QuickSearchField.md)[]

Defined in: [src/ui/datagrid/quicksearchinput.tsx:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L38)

Optional list of fields the user can search within.

***

### filteredParentClass?

> `optional` **filteredParentClass**: `string`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L40)

CSS class added to the parent element when the search filters results.

***

### loadingParentClass?

> `optional` **loadingParentClass**: `string`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L36)

CSS class added to the parent element while a search is in progress.

***

### ~~onSearch()?~~

> `optional` **onSearch**: (`field`, `query`, `done`) => `void`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L42)

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

Defined in: [src/ui/datagrid/quicksearchinput.tsx:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L46)

Callback that performs the actual search.

#### Parameters

##### args

[`QuickSearchArgs`](QuickSearchArgs.md)

#### Returns

`void`

***

### typeDelay?

> `optional` **typeDelay**: `number`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L34)

Delay in milliseconds before the search is triggered after typing stops.
