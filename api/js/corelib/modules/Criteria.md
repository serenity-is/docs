[@serenity-is/corelib](../README.md) / Criteria

# Namespace: Criteria

## Table of contents

### Variables

- [Operator](Criteria.md#operator)
- [parse](Criteria.md#parse)

### Functions

- [and](Criteria.md#and)
- [isEmpty](Criteria.md#isempty)
- [join](Criteria.md#join)
- [not](Criteria.md#not)
- [or](Criteria.md#or)
- [paren](Criteria.md#paren)

## Variables

### Operator

• **Operator**: typeof [`CriteriaOperator`](../enums/CriteriaOperator.md)

Provides access to the `CriteriaOperator` enum, e.g list of operator keys

#### Defined in

[src/q/criteria.ts:774](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L774)

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

[src/q/criteria.ts:849](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L849)

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

[src/q/criteria.ts:763](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L763)

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

[src/q/criteria.ts:779](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L779)

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

[src/q/criteria.ts:791](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L791)

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

[src/q/criteria.ts:805](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L805)

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

[src/q/criteria.ts:815](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L815)

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

[src/q/criteria.ts:829](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#L829)
