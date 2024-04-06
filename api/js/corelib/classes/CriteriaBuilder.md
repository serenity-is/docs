[@serenity-is/corelib](../README.md) / CriteriaBuilder

# Class: CriteriaBuilder

CriteriaBuilder is a class that allows to build unary or binary criteria with completion support.

## Hierarchy

- `Array`

  ↳ **`CriteriaBuilder`**

## Table of contents

### Constructors

- [constructor](CriteriaBuilder.md#constructor)

### Methods

- [bw](CriteriaBuilder.md#bw)
- [contains](CriteriaBuilder.md#contains)
- [endsWith](CriteriaBuilder.md#endswith)
- [eq](CriteriaBuilder.md#eq)
- [ge](CriteriaBuilder.md#ge)
- [gt](CriteriaBuilder.md#gt)
- [in](CriteriaBuilder.md#in)
- [isNotNull](CriteriaBuilder.md#isnotnull)
- [isNull](CriteriaBuilder.md#isnull)
- [le](CriteriaBuilder.md#le)
- [like](CriteriaBuilder.md#like)
- [lt](CriteriaBuilder.md#lt)
- [ne](CriteriaBuilder.md#ne)
- [notIn](CriteriaBuilder.md#notin)
- [notLike](CriteriaBuilder.md#notlike)
- [startsWith](CriteriaBuilder.md#startswith)

## Constructors

### constructor

• **new CriteriaBuilder**(`arrayLength?`): [`CriteriaBuilder`](CriteriaBuilder.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `arrayLength?` | `number` |

#### Returns

[`CriteriaBuilder`](CriteriaBuilder.md)

#### Inherited from

Array.constructor

#### Defined in

../../../../../Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@5.4.4/node_modules/typescript/lib/lib.es5.d.ts:1507

## Methods

### bw

▸ **bw**(`fromInclusive`, `toInclusive`): `any`[]

Creates a between criteria.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `fromInclusive` | `any` | from value |
| `toInclusive` | `any` | to value |

#### Returns

`any`[]

#### Defined in

[../base/dist/index.d.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L49)

___

### contains

▸ **contains**(`value`): `any`[]

Creates a contains criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `string` | contains value |

#### Returns

`any`[]

#### Defined in

[../base/dist/index.d.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L54)

___

### endsWith

▸ **endsWith**(`value`): `any`[]

Creates a endsWith criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `string` | endsWith value |

#### Returns

`any`[]

#### Defined in

[../base/dist/index.d.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L59)

___

### eq

▸ **eq**(`value`): `any`[]

Creates an equal (=) criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `any` | equal value |

#### Returns

`any`[]

#### Defined in

[../base/dist/index.d.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L64)

___

### ge

▸ **ge**(`value`): `any`[]

Creates a greater than or equal criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `any` | greater than or equal value |

#### Returns

`any`[]

#### Defined in

[../base/dist/index.d.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L74)

___

### gt

▸ **gt**(`value`): `any`[]

Creates a greater than criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `any` | greater than value |

#### Returns

`any`[]

#### Defined in

[../base/dist/index.d.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L69)

___

### in

▸ **in**(`values`): `any`[]

Creates a in criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `values` | `any`[] | in values |

#### Returns

`any`[]

#### Defined in

[../base/dist/index.d.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L79)

___

### isNotNull

▸ **isNotNull**(): `any`[]

Creates a IS NOT NULL criteria

#### Returns

`any`[]

#### Defined in

[../base/dist/index.d.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L87)

___

### isNull

▸ **isNull**(): `any`[]

Creates a IS NULL criteria

#### Returns

`any`[]

#### Defined in

[../base/dist/index.d.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L83)

___

### le

▸ **le**(`value`): `any`[]

Creates a less than or equal to criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `any` | less than or equal to value |

#### Returns

`any`[]

#### Defined in

[../base/dist/index.d.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L92)

___

### like

▸ **like**(`value`): `any`[]

Creates a LIKE criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `any` | like value |

#### Returns

`any`[]

#### Defined in

[../base/dist/index.d.ts:107](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L107)

___

### lt

▸ **lt**(`value`): `any`[]

Creates a less than criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `any` | less than value |

#### Returns

`any`[]

#### Defined in

[../base/dist/index.d.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L97)

___

### ne

▸ **ne**(`value`): `any`[]

Creates a not equal criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `any` | not equal value |

#### Returns

`any`[]

#### Defined in

[../base/dist/index.d.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L102)

___

### notIn

▸ **notIn**(`values`): `any`[]

Creates a NOT IN criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `values` | `any`[] | array of NOT IN values |

#### Returns

`any`[]

#### Defined in

[../base/dist/index.d.ts:117](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L117)

___

### notLike

▸ **notLike**(`value`): `any`[]

Creates a NOT LIKE criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `any` | not like value |

#### Returns

`any`[]

#### Defined in

[../base/dist/index.d.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L122)

___

### startsWith

▸ **startsWith**(`value`): `any`[]

Creates a STARTS WITH criteria

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `string` | startsWith value |

#### Returns

`any`[]

#### Defined in

[../base/dist/index.d.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L112)
