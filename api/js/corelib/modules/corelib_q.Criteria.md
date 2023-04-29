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

#### Defined in

[src/q/criteria.ts:677](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#line&#x3D;677)

___

### parse

• **parse**: (`expression`: `string`, `params?`: `any`) => `any`[](`strings`: `TemplateStringsArray`, ...`values`: `any`[]) => `any`[]

#### Type declaration

▸ (`expression`, `params?`): `any`[]

##### Parameters

| Name | Type |
| :------ | :------ |
| `expression` | `string` |
| `params?` | `any` |

##### Returns

`any`[]

▸ (`strings`, `...values`): `any`[]

##### Parameters

| Name | Type |
| :------ | :------ |
| `strings` | `TemplateStringsArray` |
| `...values` | `any`[] |

##### Returns

`any`[]

#### Defined in

[src/q/criteria.ts:713](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#line&#x3D;713)

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

[src/q/criteria.ts:667](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#line&#x3D;667)

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

[src/q/criteria.ts:678](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#line&#x3D;678)

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

[src/q/criteria.ts:684](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#line&#x3D;684)

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

[src/q/criteria.ts:694](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#line&#x3D;694)

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

[src/q/criteria.ts:698](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#line&#x3D;698)

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

[src/q/criteria.ts:709](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/criteria.ts#line&#x3D;709)
