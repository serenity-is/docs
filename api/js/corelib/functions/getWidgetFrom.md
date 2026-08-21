[@serenity-is/corelib](../README.md) / getWidgetFrom

# Function: getWidgetFrom()

> **getWidgetFrom**\<`TWidget`\>(`element`, `type?`, `context?`): `TWidget`

Defined in: [src/ui/widgets/widgetutils.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widgetutils.ts#L108)

Finds a widget associated with an element, throwing an error if none is
found.

## Type Parameters

### TWidget

`TWidget`

## Parameters

### element

The element (or selector/array-like) to search.

`string` | `Element` | `ArrayLike`\<`HTMLElement`\>

### type?

(...`args`) => `TWidget`

Optional widget type to filter by.

### context?

`HTMLElement`

Optional DOM node used to resolve a selector.

## Returns

`TWidget`

The matching widget.
