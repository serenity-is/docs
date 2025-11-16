[corelib](../README.md) / CriteriaBuilder

# Class: CriteriaBuilder

Defined in: [src/base/criteria.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L4)

CriteriaBuilder is a class that allows to build unary or binary criteria with completion support.

## Extends

- `Array`

## Indexable

\[`n`: `number`\]: `any`

## Constructors

### Constructor

> **new CriteriaBuilder**(`arrayLength?`): `CriteriaBuilder`

Defined in: C:/Users/volka/AppData/Roaming/npm/node\_modules/typedoc/node\_modules/typescript/lib/lib.es5.d.ts:1514

#### Parameters

##### arrayLength?

`number`

#### Returns

`CriteriaBuilder`

#### Inherited from

`Array.constructor`

## Methods

### bw()

> **bw**(`fromInclusive`, `toInclusive`): `any`[]

Defined in: [src/base/criteria.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L10)

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

***

### contains()

> **contains**(`value`): `any`[]

Defined in: [src/base/criteria.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L18)

Creates a contains criteria

#### Parameters

##### value

`string`

contains value

#### Returns

`any`[]

***

### endsWith()

> **endsWith**(`value`): `any`[]

Defined in: [src/base/criteria.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L26)

Creates a endsWith criteria

#### Parameters

##### value

`string`

endsWith value

#### Returns

`any`[]

***

### eq()

> **eq**(`value`): `any`[]

Defined in: [src/base/criteria.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L34)

Creates an equal (=) criteria

#### Parameters

##### value

`any`

equal value

#### Returns

`any`[]

***

### ge()

> **ge**(`value`): `any`[]

Defined in: [src/base/criteria.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L50)

Creates a greater than or equal criteria

#### Parameters

##### value

`any`

greater than or equal value

#### Returns

`any`[]

***

### gt()

> **gt**(`value`): `any`[]

Defined in: [src/base/criteria.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L42)

Creates a greater than criteria

#### Parameters

##### value

`any`

greater than value

#### Returns

`any`[]

***

### in()

> **in**(`values`): `any`[]

Defined in: [src/base/criteria.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L58)

Creates a in criteria

#### Parameters

##### values

`any`[]

in values

#### Returns

`any`[]

***

### isNotNull()

> **isNotNull**(): `any`[]

Defined in: [src/base/criteria.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L72)

Creates a IS NOT NULL criteria

#### Returns

`any`[]

***

### isNull()

> **isNull**(): `any`[]

Defined in: [src/base/criteria.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L65)

Creates a IS NULL criteria

#### Returns

`any`[]

***

### le()

> **le**(`value`): `any`[]

Defined in: [src/base/criteria.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L80)

Creates a less than or equal to criteria

#### Parameters

##### value

`any`

less than or equal to value

#### Returns

`any`[]

***

### like()

> **like**(`value`): `any`[]

Defined in: [src/base/criteria.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L104)

Creates a LIKE criteria

#### Parameters

##### value

`any`

like value

#### Returns

`any`[]

***

### lt()

> **lt**(`value`): `any`[]

Defined in: [src/base/criteria.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L88)

Creates a less than criteria

#### Parameters

##### value

`any`

less than value

#### Returns

`any`[]

***

### ne()

> **ne**(`value`): `any`[]

Defined in: [src/base/criteria.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L96)

Creates a not equal criteria

#### Parameters

##### value

`any`

not equal value

#### Returns

`any`[]

***

### notIn()

> **notIn**(`values`): `any`[]

Defined in: [src/base/criteria.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L120)

Creates a NOT IN criteria

#### Parameters

##### values

`any`[]

array of NOT IN values

#### Returns

`any`[]

***

### notLike()

> **notLike**(`value`): `any`[]

Defined in: [src/base/criteria.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L128)

Creates a NOT LIKE criteria

#### Parameters

##### value

`any`

not like value

#### Returns

`any`[]

***

### startsWith()

> **startsWith**(`value`): `any`[]

Defined in: [src/base/criteria.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/criteria.ts#L112)

Creates a STARTS WITH criteria

#### Parameters

##### value

`string`

startsWith value

#### Returns

`any`[]
