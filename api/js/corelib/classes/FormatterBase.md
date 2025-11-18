[@serenity-is/corelib](../README.md) / FormatterBase

# Abstract Class: FormatterBase

Defined in: [src/ui/formatters/formatterbase.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatterbase.ts#L5)

## Implements

- [`Formatter`](../interfaces/Formatter.md)

## Constructors

### Constructor

> **new FormatterBase**(): `FormatterBase`

#### Returns

`FormatterBase`

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`FormatterTypeInfo`](../type-aliases/FormatterTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/formatters/formatterbase.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatterbase.ts#L17)

## Methods

### format()

> `abstract` **format**(`ctx`): `FormatterResult`

Defined in: [src/ui/formatters/formatterbase.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatterbase.ts#L6)

#### Parameters

##### ctx

`FormatterContext`

#### Returns

`FormatterResult`

#### Implementation of

[`Formatter`](../interfaces/Formatter.md).[`format`](../interfaces/Formatter.md#format)

***

### registerFormatter()

> `protected` `static` **registerFormatter**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`FormatterTypeInfo`](../type-aliases/FormatterTypeInfo.md)\<`TypeName`\>

Defined in: [src/ui/formatters/formatterbase.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatterbase.ts#L8)

#### Type Parameters

##### TypeName

`TypeName`

#### Parameters

##### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

##### intfAndAttr?

([`InterfaceType`](../type-aliases/InterfaceType.md) \| [`AttributeSpecifier`](../type-aliases/AttributeSpecifier.md))[]

#### Returns

[`FormatterTypeInfo`](../type-aliases/FormatterTypeInfo.md)\<`TypeName`\>
