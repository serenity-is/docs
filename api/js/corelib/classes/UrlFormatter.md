[@serenity-is/corelib](../README.md) / UrlFormatter

# Class: UrlFormatter

## Implements

- [`Formatter`](../interfaces/Formatter.md)
- [`IInitializeColumn`](IInitializeColumn.md)

## Table of contents

### Constructors

- [constructor](UrlFormatter.md#constructor)

### Properties

- [displayFormat](UrlFormatter.md#displayformat)
- [displayProperty](UrlFormatter.md#displayproperty)
- [target](UrlFormatter.md#target)
- [urlFormat](UrlFormatter.md#urlformat)
- [urlProperty](UrlFormatter.md#urlproperty)

### Methods

- [format](UrlFormatter.md#format)
- [initializeColumn](UrlFormatter.md#initializecolumn)

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

[Formatter](../interfaces/Formatter.md).[format](../interfaces/Formatter.md#format)

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

[IInitializeColumn](IInitializeColumn.md).[initializeColumn](IInitializeColumn.md#initializecolumn)

#### Defined in

[src/ui/formatters/formatters.ts:284](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L284)
