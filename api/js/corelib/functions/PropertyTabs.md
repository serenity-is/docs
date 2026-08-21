[@serenity-is/corelib](../README.md) / PropertyTabs

# Function: PropertyTabs()

> **PropertyTabs**(`props`): `DocumentFragment`

Defined in: [src/ui/widgets/propertygrid.tsx:346](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L346)

Renders the full tabbed layout for property items that declare a `tab`,
grouping items without a tab into a leading untabbed section.

## Parameters

### props

Tabs rendering props.

#### container?

`ParentNode`

#### fieldElements?

[`PropertyFieldElement`](../type-aliases/PropertyFieldElement.md)[]

#### idPrefix?

`string`

#### items

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### localTextPrefix?

`string`

#### paneIdPrefix?

`string`

## Returns

`DocumentFragment`

A document fragment containing the tabs, or null when a container
  was provided and the content was appended directly to it.
