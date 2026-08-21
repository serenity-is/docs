[@serenity-is/corelib](../README.md) / PropertyFieldLineBreak

# Function: PropertyFieldLineBreak()

> **PropertyFieldLineBreak**(`props`): `HTMLElement`

Defined in: [src/ui/widgets/propertygrid.tsx:132](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L132)

Renders a line-break element when the item's form CSS class requests one at
the current breakpoint, or null otherwise.

## Parameters

### props

Line-break rendering props.

#### item

`Pick`\<[`PropertyItem`](../interfaces/PropertyItem.md), `"formCssClass"`\>

## Returns

`HTMLElement`

A line-break element, or null if none is needed.
