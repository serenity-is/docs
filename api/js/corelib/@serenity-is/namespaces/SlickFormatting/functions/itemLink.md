[@serenity-is/corelib](../../../../README.md) / [SlickFormatting](../README.md) / itemLink

# Function: itemLink()

> **itemLink**\<`TItem`\>(`itemType`, `idField`, `getText`, `cssClass?`, `encode?`): [`Format`](../../../../type-aliases/Format.md)\<`TItem`\>

Defined in: [src/ui/helpers/slickformatting.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickformatting.tsx#L21)

Returns a formatter that renders an edit link for an item.

## Type Parameters

### TItem

`TItem` = `any`

The type of the row item.

## Parameters

### itemType

`string`

The type of the item, e.g. "Northwind.Customer".

### idField

`string`

The name of the field holding the item id.

### getText

[`Format`](../../../../type-aliases/Format.md)\<`TItem`\>

A formatter that produces the link text, or null to use the raw value.

### cssClass?

(`ctx`) => `string`

Optional function returning an extra CSS class for the link.

### encode?

`boolean` = `true`

Whether to HTML-encode the text. Defaults to true.

## Returns

[`Format`](../../../../type-aliases/Format.md)\<`TItem`\>

The item link formatter.
