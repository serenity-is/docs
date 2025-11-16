[corelib](../README.md) / findElementWithRelativeId

# Function: findElementWithRelativeId()

> **findElementWithRelativeId**(`element`, `relativeId`, `context?`): `HTMLElement`

Defined in: [src/compat/html-compat.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/html-compat.ts#L39)

Finds the first element with the given relative id to the source element.
It can handle underscores in the source element id.

## Parameters

### element

the source element

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
