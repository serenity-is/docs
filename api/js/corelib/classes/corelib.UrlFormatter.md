[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / UrlFormatter

# Class: UrlFormatter

[corelib](../modules/corelib.md).UrlFormatter

## Implements

- [`Formatter`](../interfaces/corelib_slick.Formatter.md)
- [`IInitializeColumn`](corelib.IInitializeColumn.md)

## Table of contents

### Constructors

- [constructor](corelib.UrlFormatter.md#constructor)

### Properties

- [displayFormat](corelib.UrlFormatter.md#displayformat)
- [displayProperty](corelib.UrlFormatter.md#displayproperty)
- [target](corelib.UrlFormatter.md#target)
- [urlFormat](corelib.UrlFormatter.md#urlformat)
- [urlProperty](corelib.UrlFormatter.md#urlproperty)

### Methods

- [format](corelib.UrlFormatter.md#format)
- [initializeColumn](corelib.UrlFormatter.md#initializecolumn)

## Constructors

### constructor

• **new UrlFormatter**()

## Properties

### displayFormat

• **displayFormat**: `string`

#### Defined in

[src/ui/formatters/formatters.ts:300](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L300)

___

### displayProperty

• **displayProperty**: `string`

#### Defined in

[src/ui/formatters/formatters.ts:297](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L297)

___

### target

• **target**: `string`

#### Defined in

[src/ui/formatters/formatters.ts:309](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L309)

___

### urlFormat

• **urlFormat**: `string`

#### Defined in

[src/ui/formatters/formatters.ts:306](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L306)

___

### urlProperty

• **urlProperty**: `string`

#### Defined in

[src/ui/formatters/formatters.ts:303](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L303)

## Methods

### format

▸ **format**(`ctx`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `ctx` | `FormatterContext`<`any`\> |

#### Returns

`string`

#### Implementation of

[Formatter](../interfaces/corelib_slick.Formatter.md).[format](../interfaces/corelib_slick.Formatter.md#format)

#### Defined in

[src/ui/formatters/formatters.ts:254](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L254)

___

### initializeColumn

▸ **initializeColumn**(`column`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `column` | `Column`<`any`\> |

#### Returns

`void`

#### Implementation of

[IInitializeColumn](corelib.IInitializeColumn.md).[initializeColumn](corelib.IInitializeColumn.md#initializecolumn)

#### Defined in

[src/ui/formatters/formatters.ts:284](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L284)
