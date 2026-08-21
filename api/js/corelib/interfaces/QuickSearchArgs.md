[@serenity-is/corelib](../README.md) / QuickSearchArgs

# Interface: QuickSearchArgs

Defined in: [src/ui/datagrid/quicksearchinput.tsx:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L18)

Arguments passed to quick search callbacks.

## Properties

### done()

> **done**: (`found?`) => `void`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L24)

Callback to signal that the search completed; pass false when no results were found.

#### Parameters

##### found?

`boolean`

#### Returns

`void`

***

### field?

> `optional` **field**: `string`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L20)

Name of the selected search field, if any.

***

### handled?

> `optional` **handled**: `boolean`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L26)

When set, the search was already handled by a callback.

***

### query

> **query**: `string`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L22)

The search query text.
