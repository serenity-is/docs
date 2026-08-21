[@serenity-is/corelib](../README.md) / executeOnceWhenVisible

# ~~Function: executeOnceWhenVisible()~~

> **executeOnceWhenVisible**(`el`, `callback`): `number`

Defined in: [src/compat/layouttimer.ts:246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layouttimer.ts#L246)

Executes a callback once when the element becomes visible.
If the element is already visible (positive `offsetWidth` / `offsetHeight`), the callback is invoked immediately and `null` is returned.
Otherwise registers via [LayoutTimer.onShown](../@serenity-is/namespaces/LayoutTimer/functions/onShown.md) and auto-unregisters after the first fire.

## Parameters

### el

Target element or array-like collection (first element is used).

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

### callback

`Function`

Function to invoke when visible.

## Returns

`number`

The [LayoutTimer](../@serenity-is/namespaces/LayoutTimer/README.md) registration key, or `null` if already visible / element missing.

## Deprecated

Prefer `IntersectionObserver` or `ResizeObserver`. Kept for legacy `triggerLayoutOnShow` compatibility.
