[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](../modules/corelib_q.md) / ListResponse

# Interface: ListResponse<TEntity\>

[corelib/q](../modules/corelib_q.md).ListResponse

## Type parameters

| Name |
| :------ |
| `TEntity` |

## Hierarchy

- [`ServiceResponse`](corelib_q.ServiceResponse.md)

  ↳ **`ListResponse`**

## Table of contents

### Properties

- [Entities](corelib_q.ListResponse.md#entities)
- [Error](corelib_q.ListResponse.md#error)
- [Skip](corelib_q.ListResponse.md#skip)
- [Take](corelib_q.ListResponse.md#take)
- [TotalCount](corelib_q.ListResponse.md#totalcount)
- [Values](corelib_q.ListResponse.md#values)

## Properties

### Entities

• `Optional` **Entities**: `TEntity`[]

#### Defined in

[src/q/servicetypes.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#line&#x3D;93)

___

### Error

• `Optional` **Error**: [`ServiceError`](corelib_q.ServiceError.md)

#### Inherited from

[ServiceResponse](corelib_q.ServiceResponse.md).[Error](corelib_q.ServiceResponse.md#error)

#### Defined in

[src/q/servicetypes.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#line&#x3D;10)

___

### Skip

• `Optional` **Skip**: `number`

#### Defined in

[src/q/servicetypes.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#line&#x3D;96)

___

### Take

• `Optional` **Take**: `number`

#### Defined in

[src/q/servicetypes.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#line&#x3D;97)

___

### TotalCount

• `Optional` **TotalCount**: `number`

#### Defined in

[src/q/servicetypes.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#line&#x3D;95)

___

### Values

• `Optional` **Values**: `any`[]

#### Defined in

[src/q/servicetypes.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#line&#x3D;94)
