[@serenity-is/corelib](../README.md) / blockUndo

# Function: blockUndo()

> **blockUndo**(): `void`

Defined in: [src/base/blockui.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/blockui.ts#L69)

Decrements the block-UI reference count and removes the overlay when it reaches zero.

## Returns

`void`

## Remarks

Also cancels any pending deferred [blockUI](blockUI.md) timer scheduled with `useTimeout: true`.
No-ops if the count is already zero. Removes the `:scope > .blockUI.blockOverlay` element
from `document.body` when the last blocker is undone.

## Example

```ts
blockUndo(); // paired with a prior blockUI()
```
