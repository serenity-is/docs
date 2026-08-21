[@serenity-is/corelib](../README.md) / PropertyFieldEditor

# Function: PropertyFieldEditor()

> **PropertyFieldEditor**(`props`): `void`

Defined in: [src/ui/widgets/propertygrid.tsx:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L50)

Creates and initializes the editor widget for a property field, applying
editor params, max length, placeholder and editor addons.

## Parameters

### props

Editor rendering props.

#### fieldElement

[`PropertyFieldElement`](../type-aliases/PropertyFieldElement.md)

#### idPrefix?

`string`

#### item

`Pick`\<[`PropertyItem`](../interfaces/PropertyItem.md), `"editorCssClass"` \| `"editorType"` \| `"editorParams"` \| `"maxLength"` \| `"name"` \| `"editorAddons"` \| `"placeholder"`\>

#### localTextPrefix?

`string`

## Returns

`void`
