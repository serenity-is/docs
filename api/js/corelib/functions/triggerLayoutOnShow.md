[@serenity-is/corelib](../README.md) / triggerLayoutOnShow

# Function: triggerLayoutOnShow()

> **triggerLayoutOnShow**(`element`): `void`

Defined in: [src/compat/layout.ts:206](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layout.ts#L206)

Triggers a `layout` event each time the element becomes visible.
Compat shim for `triggerLayoutOnShow`. Uses [executeEverytimeWhenVisible](executeEverytimeWhenVisible.md) to fire `Fluent.trigger(element, 'layout')` on visibility transitions.

## Parameters

### element

Target element or array-like collection (first element is used). No-op if the element is missing.

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

## Returns

`void`
