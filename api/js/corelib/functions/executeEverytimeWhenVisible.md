[@serenity-is/corelib](../README.md) / executeEverytimeWhenVisible

# ~~Function: executeEverytimeWhenVisible()~~

> **executeEverytimeWhenVisible**(`el`, `callback`, `callNowIfVisible`): `number`

Defined in: [src/compat/layouttimer.ts:271](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layouttimer.ts#L271)

Executes a callback every time the element becomes visible.
Unlike [executeOnceWhenVisible](executeOnceWhenVisible.md), the registration persists and fires on each hidden-to-visible transition.

## Parameters

### el

Target element or array-like collection (first element is used).

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

### callback

`Function`

Function to invoke each time the element is shown.

### callNowIfVisible

`boolean`

When `true` and the element is already visible, invokes the callback immediately before registering.

## Returns

`number`

The [LayoutTimer](../@serenity-is/namespaces/LayoutTimer/README.md) registration key, or `null` if the element is missing.

## Deprecated

Prefer `IntersectionObserver` / `ResizeObserver`. Kept for legacy `triggerLayoutOnShow` compatibility.
