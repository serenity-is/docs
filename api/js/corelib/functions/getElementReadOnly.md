[@serenity-is/corelib](../README.md) / getElementReadOnly

# Function: getElementReadOnly()

> **getElementReadOnly**(`el`): `boolean` \| `null`

Gets readonly state of an element. If the element is null, returns null.
It does not check for attached widgets. It returns true if the element has readonly class,
disabled attribute (select, radio, checkbox) or readonly attribute (other inputs).

## Parameters

### el

`Element`

element

## Returns

`boolean` \| `null`

## Defined in

[src/base/html.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L128)
