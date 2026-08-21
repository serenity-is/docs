[@serenity-is/corelib](../README.md) / getjQuery

# Function: getjQuery()

> **getjQuery**(): `any`

Defined in: [src/base/environment.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/environment.ts#L9)

Gets the globally available jQuery instance, if any.

## Returns

`any`

The jQuery function when available, otherwise `undefined`.

## Remarks

Checks both `jQuery` and `$` globals. Returns `undefined` when jQuery is
not loaded or does not expose `fn`, allowing the codebase to fall back to
native DOM / Bootstrap 5 APIs.
