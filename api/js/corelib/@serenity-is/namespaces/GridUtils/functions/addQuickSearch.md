[@serenity-is/corelib](../../../../README.md) / [GridUtils](../README.md) / addQuickSearch

# Function: addQuickSearch()

> **addQuickSearch**(`options`): [`QuickSearchInput`](../../../../classes/QuickSearchInput.md)

Defined in: [src/ui/helpers/gridutils.tsx:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridutils.tsx#L77)

Adds a quick search input to a container and wires it to the given view.

## Parameters

### options

The quick search options.

#### beforeSearch?

(`args`) => `void`

#### container

`HTMLElement` \| `ArrayLike`\<`HTMLElement`\>

#### fields?

[`QuickSearchField`](../../../../interfaces/QuickSearchField.md)[]

#### search?

(`args`) => `void`

#### view?

[`IRemoteView`](../../../../interfaces/IRemoteView.md)\<`any`\>

## Returns

[`QuickSearchInput`](../../../../classes/QuickSearchInput.md)

The created QuickSearchInput widget.
