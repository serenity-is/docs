[@serenity-is/corelib](../README.md) / EditLink

# Function: EditLink()

> **EditLink**(`props`): `HTMLAnchorElement`

Defined in: [src/ui/helpers/editlink.tsx:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/editlink.tsx#L13)

Renders an edit link for a given item type and ID.
The link will have a CSS class based on the item type and will point to a URL fragment
that includes the item type and ID.
This is similar to SlickHelper.itemLink function, but it doesn't require a grid context
and does not accept FormatterResult (e.g. html string markup) as children.

## Parameters

### props

The properties for the edit link.

#### children?

`any`

Child elements or text to be displayed inside the link.

#### cssClass?

`string`

Additional CSS class to add to the link (besides s-EditLink and s-[ItemType]Link)

#### itemId

`any`

The ID of the item to link to.

#### itemType?

`string`

The type of the item, e.g. "Northwind.Customer".

#### tabindex?

`number`

Tab index for the link. Default is null, which means no tabindex attribute.

#### tabIndex?

`number`

**Deprecated**

Use tabindex.

## Returns

`HTMLAnchorElement`

An HTML anchor element representing the edit link.
