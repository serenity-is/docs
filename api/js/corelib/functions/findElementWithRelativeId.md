[@serenity-is/corelib](../README.md) / findElementWithRelativeId

# Function: findElementWithRelativeId()

> **findElementWithRelativeId**(`element`, `relativeId`, `context`?): `HTMLElement`

Finds the first element with the given relative id to the source element.
It can handle underscores in the source element id.

## Parameters

### element

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

### relativeId

`string`

the relative id to the source element

### context?

`HTMLElement`

the context element (optional)

## Returns

`HTMLElement`

the element with the given relative id to the source element.

## Defined in

[src/q/html-compat.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/html-compat.ts#L40)
