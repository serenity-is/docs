[@serenity-is/corelib](../README.md) / isMobileView

# Function: isMobileView()

> **isMobileView**(): `boolean`

Defined in: [src/compat/layout.ts:195](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layout.ts#L195)

Determines whether the current viewport is considered a mobile view.
Compat helper wrapping `window.matchMedia('(max-width: 767px)')` with a fallback to `window.innerWidth < 768`.

## Returns

`boolean`

`true` if the viewport width is at most 767 px; otherwise `false`.
