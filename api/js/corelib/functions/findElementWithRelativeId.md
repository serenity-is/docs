[@serenity-is/corelib](../README.md) / findElementWithRelativeId

# Function: findElementWithRelativeId()

> **findElementWithRelativeId**(`element`, `relativeId`, `context?`): `HTMLElement`

Defined in: [src/compat/html-compat.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/html-compat.ts#L54)

Resolves a sibling/related element by a suffix relative to a source element's id.

## Parameters

### element

Source element or array-like/jQuery-like wrapper containing it.

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

### relativeId

`string`

Suffix to append to the source id (with/without leading `_`) when searching.

### context?

`HTMLElement`

Scope element for `querySelector`; defaults to the source element's root node. When omitted the search also falls back to `document.getElementById`.

## Returns

`HTMLElement`

The matched `HTMLElement`, or `null` if the source is `null` or no match is found.

## Remarks

Tries `"#" + fromId + relativeId` then `"#" + fromId + "_" + relativeId`, progressively stripping trailing `"_segment"` segments from `fromId` until a match or exhaustion. Compat helper from `Q.findElementWithRelativeId`.

## Example

```ts
findElementWithRelativeId(document.getElementById("Customer_Name"), "_City"); // finds #Customer_City if present
```
