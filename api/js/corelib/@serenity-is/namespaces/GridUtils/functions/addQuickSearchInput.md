[@serenity-is/corelib](../../../../README.md) / [GridUtils](../README.md) / addQuickSearchInput

# ~~Function: addQuickSearchInput()~~

> **addQuickSearchInput**(`toolDiv`, `view`, `fields?`, `onChange?`): [`QuickSearchInput`](../../../../classes/QuickSearchInput.md)

Defined in: [src/ui/helpers/gridutils.tsx:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridutils.tsx#L161)

## Parameters

### toolDiv

The toolbar element (or array-like of elements).

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

### view

[`IRemoteView`](../../../../interfaces/IRemoteView.md)\<`any`\>

The remote view.

### fields?

[`QuickSearchField`](../../../../interfaces/QuickSearchField.md)[]

Optional quick search fields.

### onChange?

() => `void`

Optional callback invoked before searching.

## Returns

[`QuickSearchInput`](../../../../classes/QuickSearchInput.md)

The created QuickSearchInput widget.

## Deprecated

use addQuickSearch with named args
Adds a quick search input to a toolbar.
