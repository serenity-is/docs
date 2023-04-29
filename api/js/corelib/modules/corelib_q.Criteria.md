[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](corelib_q.md) / Criteria

# Namespace: Criteria

[corelib/q](corelib_q.md).Criteria

## Table of contents

### Variables

- [Operator](corelib_q.Criteria.md#operator)
- [parse](corelib_q.Criteria.md#parse)

### Functions

- [and](corelib_q.Criteria.md#and)
- [isEmpty](corelib_q.Criteria.md#isempty)
- [join](corelib_q.Criteria.md#join)
- [not](corelib_q.Criteria.md#not)
- [or](corelib_q.Criteria.md#or)
- [paren](corelib_q.Criteria.md#paren)

## Variables

### Operator

• **Operator**: typeof [`CriteriaOperator`](../enums/corelib_q.CriteriaOperator.md)

Provides access to the `CriteriaOperator` enum

#### Defined in

[src/q/criteria.ts:772](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#line&#x3D;772)

___

### parse

• **parse**: (`expression`: `string`, `params?`: `any`) => `any`[](`strings`: `TemplateStringsArray`, ...`values`: `any`[]) => `any`[]

#### Type declaration

▸ (`expression`, `params?`): `any`[]

Parses a criteria expression to Serenity Criteria array format.
The expression string may be a string literal, optionally containining 
parameters like `A >= @p1 and B < @p2`.

Or, the expression might be a tagged string literal that 
contain parameter placeholders like `A >= ${p1}`
where p1 is a variable in the scope.

**`Example`**

```ts
Criteria.parse("A >=
```

**`P1`**

and B < @p2", { p1: 5, p2: 4 }) // [[[a], '>=' 5], 'and', [[b], '<', 4]]

**`Example`**

```ts
var a = 5; b = 4;
Criteria.parse`A >= ${a} and B < ${b}` // [[[a], '>=' 5], 'and', [[b], '<', 4]]
```

##### Parameters

| Name | Type |
| :------ | :------ |
| `expression` | `string` |
| `params?` | `any` |

##### Returns

`any`[]

▸ (`strings`, `...values`): `any`[]

Parses a criteria expression to Serenity Criteria array format.
The expression string may be a string literal, optionally containining 
parameters like `A >= @p1 and B < @p2`.

Or, the expression might be a tagged string literal that 
contain parameter placeholders like `A >= ${p1}`
where p1 is a variable in the scope.

**`Example`**

```ts
Criteria.parse("A >=
```

**`P1`**

and B < @p2", { p1: 5, p2: 4 }) // [[[a], '>=' 5], 'and', [[b], '<', 4]]

**`Example`**

```ts
var a = 5; b = 4;
Criteria.parse`A >= ${a} and B < ${b}` // [[[a], '>=' 5], 'and', [[b], '<', 4]]
```

##### Parameters

| Name | Type |
| :------ | :------ |
| `strings` | `TemplateStringsArray` |
| `...values` | `any`[] |

##### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:847](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#line&#x3D;847)

## Functions

### and

▸ **and**(`c1`, `c2`, `...rest`): `any`[]

Ands two or more criteria together.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `c1` | `any`[] | First criteria. |
| `c2` | `any`[] | Second criteria. |
| `...rest` | `any`[][] | Other criteria. |

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:761](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#line&#x3D;761)

___

### isEmpty

▸ **isEmpty**(`c`): `boolean`

Determines if a criteria is empty.

#### Parameters

| Name | Type |
| :------ | :------ |
| `c` | `any`[] |

#### Returns

`boolean`

#### Defined in

[src/q/criteria.ts:777](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#line&#x3D;777)

___

### join

▸ **join**(`c1`, `op`, `c2`): `any`[]

Joins two criteria together.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `c1` | `any`[] | First criteria. |
| `op` | `string` | Operator to insert between, e.g. 'or', 'and'. |
| `c2` | `any`[] | Second criteria |

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:789](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#line&#x3D;789)

___

### not

▸ **not**(`c`): (`string` \| `any`[])[]

Negates a criteria.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `c` | `any`[] | Criteria to negate. |

#### Returns

(`string` \| `any`[])[]

#### Defined in

[src/q/criteria.ts:803](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#line&#x3D;803)

___

### or

▸ **or**(`c1`, `c2`, `...rest`): `any`[]

Ors two or more criteria together.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `c1` | `any`[] | First criteria. |
| `c2` | `any`[] | Second criteria. |
| `...rest` | `any`[][] | Other criteria. |

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:813](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#line&#x3D;813)

___

### paren

▸ **paren**(`c`): `any`[]

Puts a criteria in parens. Exists only for compatibility reasons.

#### Parameters

| Name | Type |
| :------ | :------ |
| `c` | `any`[] |

#### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:827](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#line&#x3D;827)
