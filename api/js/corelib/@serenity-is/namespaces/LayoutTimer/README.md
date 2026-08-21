[@serenity-is/corelib](../../../README.md) / LayoutTimer

# ~~LayoutTimer~~

Legacy polling-based layout timer that detects size and visibility changes.
Compat shim for the old `Q.LayoutTimer` / `Serenity.LayoutTimer` API. Polls registered elements every ~100 ms,
supports optional debouncing, and fires handlers when width, height, or visibility transitions occur.
Prefer `ResizeObserver` or `Fluent.on(..., 'layout')` with CSS-based layouts for new code.

## Deprecated

Kept for backward compatibility with legacy `layoutFillHeight` and `triggerLayoutOnShow` callers. Use `ResizeObserver` instead.

## Functions

- [~~off~~](functions/off.md)
- [~~onHeightChange~~](functions/onHeightChange.md)
- [~~onShown~~](functions/onShown.md)
- [~~onSizeChange~~](functions/onSizeChange.md)
- [~~onWidthChange~~](functions/onWidthChange.md)
- [~~store~~](functions/store.md)
- [~~trigger~~](functions/trigger.md)
