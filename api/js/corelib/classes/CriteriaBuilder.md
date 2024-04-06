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

[src/base/criteria.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L10)

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

[src/base/criteria.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L18)

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

[src/base/criteria.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L26)

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

[src/base/criteria.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L34)

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

[src/base/criteria.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L50)

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

[src/base/criteria.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L42)

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

[src/base/criteria.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L58)

___

### isNotNull

▸ **isNotNull**(): `any`[]

Creates a IS NOT NULL criteria

#### Returns

`any`[]

#### Defined in

[src/base/criteria.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L72)

___

### isNull

▸ **isNull**(): `any`[]

Creates a IS NULL criteria

#### Returns

`any`[]

#### Defined in

[src/base/criteria.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L65)

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

[src/base/criteria.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L80)

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

[src/base/criteria.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L104)

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

[src/base/criteria.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L88)

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

[src/base/criteria.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L96)

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

[src/base/criteria.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L120)

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

[src/base/criteria.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L128)

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

[src/base/criteria.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L112)
