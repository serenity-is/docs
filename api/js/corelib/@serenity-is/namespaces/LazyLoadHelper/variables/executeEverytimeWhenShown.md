[@serenity-is/corelib](../../../../README.md) / [LazyLoadHelper](../README.md) / executeEverytimeWhenShown

# Variable: executeEverytimeWhenShown()

> `const` **executeEverytimeWhenShown**: (`el`, `callback`, `callNowIfVisible`) => `number` = `executeEverytimeWhenVisible`

Defined in: [src/ui/helpers/lazyloadhelper.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/lazyloadhelper.ts#L14)

Executes the given callback every time the element becomes visible.

Executes a callback every time the element becomes visible.
Unlike [executeOnceWhenVisible](../../../../functions/executeOnceWhenVisible.md), the registration persists and fires on each hidden-to-visible transition.

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

The [LayoutTimer](../../LayoutTimer/README.md) registration key, or `null` if the element is missing.

## Deprecated

Prefer `IntersectionObserver` / `ResizeObserver`. Kept for legacy `triggerLayoutOnShow` compatibility.
