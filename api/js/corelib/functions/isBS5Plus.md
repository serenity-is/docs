[@serenity-is/corelib](../README.md) / isBS5Plus

# Function: isBS5Plus()

> **isBS5Plus**(): `boolean`

Defined in: [src/base/environment.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/environment.ts#L33)

Determines whether Bootstrap 5 or later is loaded on the page.

## Returns

`boolean`

`true` if Bootstrap 5+ is detected, otherwise `false`.

## Remarks

Uses the global `bootstrap.Modal.VERSION` when available. Explicitly
excludes Bootstrap 4 (major version `"4"`) so that Bootstrap 4 is treated
as neither BS3 nor BS5+.
