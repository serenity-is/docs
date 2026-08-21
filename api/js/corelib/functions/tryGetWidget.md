[@serenity-is/corelib](../README.md) / tryGetWidget

# Function: tryGetWidget()

> **tryGetWidget**\<`TWidget`\>(`element`, `type?`): `TWidget`

Defined in: [src/ui/widgets/widgetutils.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widgetutils.ts#L64)

Tries to find a widget associated with an element, optionally filtering by
type.

## Type Parameters

### TWidget

`TWidget`

## Parameters

### element

The element (or selector/array-like) to search.

`string` | `Element` | `ArrayLike`\<`HTMLElement`\>

### type?

(...`args`) => `TWidget`

Optional widget type to filter by; when omitted, the first
  associated widget is returned.

## Returns

`TWidget`

The matching widget, or null if none is found.
