[@serenity-is/corelib](../README.md) / setElementReadOnly

# Function: setElementReadOnly()

> **setElementReadOnly**(`elements`, `value`): `void`

Defined in: [src/base/html.ts:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L152)

Sets readonly class and disabled (for select, radio, checkbox) or readonly attribute (for other inputs) on given element.
It does not check for attached widgets.

## Parameters

### elements

Element or array-like of elements

`Element` | `ArrayLike`\<`Element`\>

### value

`boolean`

Readonly state

## Returns

`void`
