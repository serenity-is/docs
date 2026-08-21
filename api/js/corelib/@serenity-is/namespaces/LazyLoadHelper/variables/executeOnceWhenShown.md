[@serenity-is/corelib](../../../../README.md) / [LazyLoadHelper](../README.md) / executeOnceWhenShown

# Variable: executeOnceWhenShown()

> `const` **executeOnceWhenShown**: (`el`, `callback`) => `number` = `executeOnceWhenVisible`

Defined in: [src/ui/helpers/lazyloadhelper.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/lazyloadhelper.ts#L10)

Executes the given callback once when the element becomes visible.

Executes a callback once when the element becomes visible.
If the element is already visible (positive `offsetWidth` / `offsetHeight`), the callback is invoked immediately and `null` is returned.
Otherwise registers via [LayoutTimer.onShown](../../LayoutTimer/functions/onShown.md) and auto-unregisters after the first fire.

## Parameters

### el

Target element or array-like collection (first element is used).

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

### callback

`Function`

Function to invoke when visible.

## Returns

`number`

The [LayoutTimer](../../LayoutTimer/README.md) registration key, or `null` if already visible / element missing.

## Deprecated

Prefer `IntersectionObserver` or `ResizeObserver`. Kept for legacy `triggerLayoutOnShow` compatibility.
