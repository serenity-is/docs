[@serenity-is/corelib](../README.md) / CriteriaBuilder

# Class: CriteriaBuilder

CriteriaBuilder is a class that allows to build unary or binary criteria with completion support.

## Extends

- `Array`

## Indexable

 \[`n`: `number`\]: `any`

## Constructors

### new CriteriaBuilder()

> **new CriteriaBuilder**(`arrayLength`?): [`CriteriaBuilder`](CriteriaBuilder.md)

#### Parameters

##### arrayLength?

`number`

#### Returns

[`CriteriaBuilder`](CriteriaBuilder.md)

#### Inherited from

`Array.constructor`

#### Defined in

C:/Users/volka/AppData/Local/pnpm/global/5/.pnpm/typescript@5.6.3/node\_modules/typescript/lib/lib.es5.d.ts:1507

## Methods

### bw()

> **bw**(`fromInclusive`, `toInclusive`): `any`[]

Creates a between criteria.

#### Parameters

##### fromInclusive

`any`

from value

##### toInclusive

`any`

to value

#### Returns

`any`[]

#### Defined in

[src/base/criteria.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L10)

***

### contains()

> **contains**(`value`): `any`[]

Creates a contains criteria

#### Parameters

##### value

`string`

contains value

#### Returns

`any`[]

#### Defined in

[src/base/criteria.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L18)

***

### endsWith()

> **endsWith**(`value`): `any`[]

Creates a endsWith criteria

#### Parameters

##### value

`string`

endsWith value

#### Returns

`any`[]

#### Defined in

[src/base/criteria.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L26)

***

### eq()

> **eq**(`value`): `any`[]

Creates an equal (=) criteria

#### Parameters

##### value

`any`

equal value

#### Returns

`any`[]

#### Defined in

[src/base/criteria.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L34)

***

### ge()

> **ge**(`value`): `any`[]

Creates a greater than or equal criteria

#### Parameters

##### value

`any`

greater than or equal value

#### Returns

`any`[]

#### Defined in

[src/base/criteria.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L50)

***

### gt()

> **gt**(`value`): `any`[]

Creates a greater than criteria

#### Parameters

##### value

`any`

greater than value

#### Returns

`any`[]

#### Defined in

[src/base/criteria.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L42)

***

### in()

> **in**(`values`): `any`[]

Creates a in criteria

#### Parameters

##### values

`any`[]

in values

#### Returns

`any`[]

#### Defined in

[src/base/criteria.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L58)

***

### isNotNull()

> **isNotNull**(): `any`[]

Creates a IS NOT NULL criteria

#### Returns

`any`[]

#### Defined in

[src/base/criteria.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L72)

***

### isNull()

> **isNull**(): `any`[]

Creates a IS NULL criteria

#### Returns

`any`[]

#### Defined in

[src/base/criteria.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L65)

***

### le()

> **le**(`value`): `any`[]

Creates a less than or equal to criteria

#### Parameters

##### value

`any`

less than or equal to value

#### Returns

`any`[]

#### Defined in

[src/base/criteria.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L80)

***

### like()

> **like**(`value`): `any`[]

Creates a LIKE criteria

#### Parameters

##### value

`any`

like value

#### Returns

`any`[]

#### Defined in

[src/base/criteria.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L104)

***

### lt()

> **lt**(`value`): `any`[]

Creates a less than criteria

#### Parameters

##### value

`any`

less than value

#### Returns

`any`[]

#### Defined in

[src/base/criteria.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L88)

***

### ne()

> **ne**(`value`): `any`[]

Creates a not equal criteria

#### Parameters

##### value

`any`

not equal value

#### Returns

`any`[]

#### Defined in

[src/base/criteria.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L96)

***

### notIn()

> **notIn**(`values`): `any`[]

Creates a NOT IN criteria

#### Parameters

##### values

`any`[]

array of NOT IN values

#### Returns

`any`[]

#### Defined in

[src/base/criteria.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L120)

***

### notLike()

> **notLike**(`value`): `any`[]

Creates a NOT LIKE criteria

#### Parameters

##### value

`any`

not like value

#### Returns

`any`[]

#### Defined in

[src/base/criteria.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L128)

***

### startsWith()

> **startsWith**(`value`): `any`[]

Creates a STARTS WITH criteria

#### Parameters

##### value

`string`

startsWith value

#### Returns

`any`[]

#### Defined in

[src/base/criteria.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L112)
