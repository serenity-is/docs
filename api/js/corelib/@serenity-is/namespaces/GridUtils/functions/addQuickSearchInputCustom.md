[@serenity-is/corelib](../../../../README.md) / [GridUtils](../README.md) / addQuickSearchInputCustom

# ~~Function: addQuickSearchInputCustom()~~

> **addQuickSearchInputCustom**(`container`, `search`, `fields?`): [`QuickSearchInput`](../../../../classes/QuickSearchInput.md)

Defined in: [src/ui/helpers/gridutils.tsx:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridutils.tsx#L180)

## Parameters

### container

The container element (or array-like of elements).

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

### search

(`field`, `query`, `done`) => `void`

The custom search handler.

### fields?

[`QuickSearchField`](../../../../interfaces/QuickSearchField.md)[]

Optional quick search fields.

## Returns

[`QuickSearchInput`](../../../../classes/QuickSearchInput.md)

The created QuickSearchInput widget.

## Deprecated

use addQuickSearch with named args
Adds a quick search input with a custom search handler.
