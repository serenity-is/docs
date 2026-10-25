[@serenity-is/corelib](../README.md) / getWindowLocation

# Function: getWindowLocation()

> **getWindowLocation**(`opt?`): `Location`

Defined in: [src/base/services.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/services.ts#L28)

Returns the window location object.
Applications should read or assign the location through this function instead of
referencing `window.location` directly, so tests can replace it with a stub, as
jsdom does not implement navigation.

## Parameters

### opt?

pass `{ top: true }` to get the top window's location, e.g. to
break out of an iframe.

#### top?

`boolean`

## Returns

`Location`

The requested Location.
