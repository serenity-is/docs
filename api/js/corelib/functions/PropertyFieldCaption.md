[@serenity-is/corelib](../README.md) / PropertyFieldCaption

# Function: PropertyFieldCaption()

> **PropertyFieldCaption**(`props`): `HTMLLabelElement`

Defined in: [src/ui/widgets/propertygrid.tsx:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L27)

Renders the caption (label) for a property field, including the required
marker and localized title/hint text.

## Parameters

### props

Caption rendering props.

#### idPrefix?

`string`

#### item

`Pick`\<[`PropertyItem`](../interfaces/PropertyItem.md), `"name"` \| `"hint"` \| `"labelWidth"` \| `"required"` \| `"title"`\>

#### localTextPrefix?

`string`

## Returns

`HTMLLabelElement`

The label element for the field.
