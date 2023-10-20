[@serenity-is](../README.md) / [Modules](../modules.md) / [q](../modules/q.md) / ListResponse

# Interface: ListResponse<TEntity\>

[q](../modules/q.md).ListResponse

## Type parameters

| Name |
| :------ |
| `TEntity` |

## Hierarchy

- [`ServiceResponse`](q.ServiceResponse.md)

  ↳ **`ListResponse`**

## Table of contents

### Properties

- [Entities](q.ListResponse.md#entities)
- [Error](q.ListResponse.md#error)
- [Skip](q.ListResponse.md#skip)
- [Take](q.ListResponse.md#take)
- [TotalCount](q.ListResponse.md#totalcount)
- [Values](q.ListResponse.md#values)

## Properties

### Entities

• `Optional` **Entities**: `TEntity`[]

#### Defined in

[src/q/servicetypes.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L93)

___

### Error

• `Optional` **Error**: [`ServiceError`](q.ServiceError.md)

#### Inherited from

[ServiceResponse](q.ServiceResponse.md).[Error](q.ServiceResponse.md#error)

#### Defined in

[src/q/servicetypes.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L10)

___

### Skip

• `Optional` **Skip**: `number`

#### Defined in

[src/q/servicetypes.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L96)

___

### Take

• `Optional` **Take**: `number`

#### Defined in

[src/q/servicetypes.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L97)

___

### TotalCount

• `Optional` **TotalCount**: `number`

#### Defined in

[src/q/servicetypes.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L95)

___

### Values

• `Optional` **Values**: `any`[]

#### Defined in

[src/q/servicetypes.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L94)
