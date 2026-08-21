[@serenity-is/corelib](../../../../README.md) / [GridUtils](../README.md) / addIncludeDeletedToggle

# Function: addIncludeDeletedToggle()

> **addIncludeDeletedToggle**(`toolDiv`, `view`, `hint?`, `initial?`): `void`

Defined in: [src/ui/helpers/gridutils.tsx:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/gridutils.tsx#L43)

Adds an "include deleted" toggle button that sets the IncludeDeleted
parameter on the view's submit requests.

## Parameters

### toolDiv

The toolbar element (or array-like of elements).

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

### view

[`IRemoteView`](../../../../interfaces/IRemoteView.md)\<`any`\>

The remote view.

### hint?

`string`

Optional tooltip text.

### initial?

`boolean`

Optional initial state.

## Returns

`void`
