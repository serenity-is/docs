[@serenity-is/corelib](../README.md) / Criteria

# Namespace: Criteria

## Table of contents

### Variables

- [Operator](Criteria.md#operator)

### Functions

- [and](Criteria.md#and)
- [isEmpty](Criteria.md#isempty)
- [join](Criteria.md#join)
- [not](Criteria.md#not)
- [or](Criteria.md#or)
- [paren](Criteria.md#paren)
- [parse](Criteria.md#parse)

## Variables

### Operator

• **Operator**: typeof [`CriteriaOperator`](../enums/CriteriaOperator.md)

#### Defined in

[../base/dist/index.d.ts:174](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L174)

## Functions

### and

▸ **and**(`c1`, `c2`, `...rest`): `any`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `c1` | `any`[] |
| `c2` | `any`[] |
| `...rest` | `any`[][] |

#### Returns

`any`[]

#### Defined in

[../base/dist/index.d.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L173)

___

### isEmpty

▸ **isEmpty**(`c`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `c` | `any`[] |

#### Returns

`boolean`

#### Defined in

[../base/dist/index.d.ts:175](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L175)

___

### join

▸ **join**(`c1`, `op`, `c2`): `any`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `c1` | `any`[] |
| `op` | `string` |
| `c2` | `any`[] |

#### Returns

`any`[]

#### Defined in

[../base/dist/index.d.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L176)

___

### not

▸ **not**(`c`): (`string` \| `any`[])[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `c` | `any`[] |

#### Returns

(`string` \| `any`[])[]

#### Defined in

[../base/dist/index.d.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L177)

___

### or

▸ **or**(`c1`, `c2`, `...rest`): `any`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `c1` | `any`[] |
| `c2` | `any`[] |
| `...rest` | `any`[][] |

#### Returns

`any`[]

#### Defined in

[../base/dist/index.d.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L178)

___

### paren

▸ **paren**(`c`): `any`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `c` | `any`[] |

#### Returns

`any`[]

#### Defined in

[../base/dist/index.d.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L179)

___

### parse

▸ **parse**(`expression`, `params?`): `any`[]

Parses a criteria expression to Serenity Criteria array format.
The string may optionally contain parameters like `A >= @p1 and B < @p2`.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `expression` | `string` | The criteria expression. |
| `params?` | `any` | The dictionary containing parameter values like { p1: 10, p2: 20 }. |

#### Returns

`any`[]

**`Example`**

```ts
parseCriteria('A >=
```

**`P1`**

and B < @p2', { p1: 5, p2: 4 }) // [[[a], '>=' 5], 'and', [[b], '<', 4]]

#### Defined in

[../base/dist/index.d.ts:180](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L180)

▸ **parse**(`strings`, `...values`): `any`[]

Parses a criteria expression to Serenity Criteria array format.
The expression may contain parameter placeholders like `A >= ${p1}`
where p1 is a variable in the scope.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `strings` | `TemplateStringsArray` | The string fragments. |
| `...values` | `any`[] | The tagged template arguments. |

#### Returns

`any`[]

**`Example`**

```ts
var a = 5, b = 4;
parseCriteria`A >= ${a} and B < ${b}` // [[[a], '>=' 5], 'and', [[b], '<', 4]]
```

#### Defined in

[../base/dist/index.d.ts:180](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L180)
