[@serenity-is/corelib](../README.md) / UrlFormatter

# Class: UrlFormatter

## Implements

- [`Formatter`](../interfaces/Formatter.md)
- [`IInitializeColumn`](IInitializeColumn.md)

## Table of contents

### Constructors

- [constructor](UrlFormatter.md#constructor)

### Properties

- [props](UrlFormatter.md#props)

### Accessors

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

• **new UrlFormatter**(`props?`): [`UrlFormatter`](UrlFormatter.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | `Object` |
| `props.displayFormat?` | `string` |
| `props.displayProperty?` | `string` |
| `props.target?` | `string` |
| `props.urlFormat?` | `string` |
| `props.urlProperty?` | `string` |

#### Returns

[`UrlFormatter`](UrlFormatter.md)

#### Defined in

[src/ui/formatters/formatters.ts:252](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L252)

## Properties

### props

• `Readonly` **props**: `Object` = `{}`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `displayFormat?` | `string` |
| `displayProperty?` | `string` |
| `target?` | `string` |
| `urlFormat?` | `string` |
| `urlProperty?` | `string` |

#### Defined in

[src/ui/formatters/formatters.ts:252](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L252)

## Accessors

### displayFormat

• `get` **displayFormat**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:300](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L300)

• `set` **displayFormat**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:301](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L301)

___

### displayProperty

• `get` **displayProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:297](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L297)

• `set` **displayProperty**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:298](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L298)

___

### target

• `get` **target**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:309](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L309)

• `set` **target**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:310](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L310)

___

### urlFormat

• `get` **urlFormat**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:306](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L306)

• `set` **urlFormat**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L307)

___

### urlProperty

• `get` **urlProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/formatters/formatters.ts:303](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L303)

• `set` **urlProperty**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/formatters/formatters.ts:304](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L304)

## Methods

### format

▸ **format**(`ctx`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `ctx` | `FormatterContext`\<`any`\> |

#### Returns

`string`

#### Implementation of

[Formatter](../interfaces/Formatter.md).[format](../interfaces/Formatter.md#format)

#### Defined in

[src/ui/formatters/formatters.ts:256](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L256)

___

### initializeColumn

▸ **initializeColumn**(`column`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `column` | `Column`\<`any`\> |

#### Returns

`void`

#### Implementation of

[IInitializeColumn](IInitializeColumn.md).[initializeColumn](IInitializeColumn.md#initializecolumn)

#### Defined in

[src/ui/formatters/formatters.ts:285](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/formatters/formatters.ts#L285)
