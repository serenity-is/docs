[@serenity-is/corelib](../README.md) / formatterTypeInfo

# Function: formatterTypeInfo()

> **formatterTypeInfo**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`FormatterTypeInfo`](../type-aliases/FormatterTypeInfo.md)\<`TypeName`\>

Defined in: [src/base/system.ts:646](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L646)

Creates [FormatterTypeInfo](../type-aliases/FormatterTypeInfo.md) for a formatter class. Automatically includes [ISlickFormatter](../classes/ISlickFormatter.md).

## Type Parameters

### TypeName

`TypeName`

String-literal formatter type name.

## Parameters

### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

Fully-qualified formatter name (e.g. `"MyApp.MyFormatter"`).

### intfAndAttr?

([`InterfaceType`](../type-aliases/InterfaceType.md) \| [`AttributeSpecifier`](../type-aliases/AttributeSpecifier.md))[]

Optional interfaces and attributes.

## Returns

[`FormatterTypeInfo`](../type-aliases/FormatterTypeInfo.md)\<`TypeName`\>

A [FormatterTypeInfo](../type-aliases/FormatterTypeInfo.md) to assign to `[Symbol.typeInfo]`.
