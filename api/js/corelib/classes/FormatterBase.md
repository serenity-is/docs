[@serenity-is/corelib](../README.md) / FormatterBase

# Abstract Class: FormatterBase

Defined in: [src/ui/formatters/formatterbase.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatterbase.ts#L9)

Base class for Serenity formatters. Provides the static `registerFormatter` helper
used by formatter subclasses with `static [Symbol.typeInfo] = this.registerFormatter(...)`.

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

Defined in: [src/ui/formatters/formatterbase.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatterbase.ts#L33)

## Methods

### format()

> `abstract` **format**(`ctx`): `FormatterResult`

Defined in: [src/ui/formatters/formatterbase.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatterbase.ts#L15)

Formats the cell value.

#### Parameters

##### ctx

`FormatterContext`

Formatter context containing item/column/value/grid.

#### Returns

`FormatterResult`

Rendered content for the cell.

#### Implementation of

[`Formatter`](../interfaces/Formatter.md).[`format`](../interfaces/Formatter.md#format)

***

### registerFormatter()

> `protected` `static` **registerFormatter**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`FormatterTypeInfo`](../type-aliases/FormatterTypeInfo.md)\<`TypeName`\>

Defined in: [src/ui/formatters/formatterbase.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatterbase.ts#L24)

Registers the formatter type under the given formal name.

#### Type Parameters

##### TypeName

`TypeName`

String literal for the formatter's full name.

#### Parameters

##### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

Full name (e.g. `"MyProject.MyFormatter"`).

##### intfAndAttr?

([`InterfaceType`](../type-aliases/InterfaceType.md) \| [`AttributeSpecifier`](../type-aliases/AttributeSpecifier.md))[]

Optional interfaces / attribute specifiers.

#### Returns

[`FormatterTypeInfo`](../type-aliases/FormatterTypeInfo.md)\<`TypeName`\>

The created type info.
