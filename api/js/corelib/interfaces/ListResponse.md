[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / ListResponse

# Interface: ListResponse<TEntity\>

## Type parameters

| Name |
| :------ |
| `TEntity` |

## Hierarchy

- [`ServiceResponse`](ServiceResponse.md)

  ↳ **`ListResponse`**

## Table of contents

### Properties

- [Entities](ListResponse.md#entities)
- [Error](ListResponse.md#error)
- [Skip](ListResponse.md#skip)
- [Take](ListResponse.md#take)
- [TotalCount](ListResponse.md#totalcount)
- [Values](ListResponse.md#values)

## Properties

### Entities

• `Optional` **Entities**: `TEntity`[]

#### Defined in

[src/q/servicetypes.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L93)

___

### Error

• `Optional` **Error**: [`ServiceError`](ServiceError.md)

#### Inherited from

[ServiceResponse](ServiceResponse.md).[Error](ServiceResponse.md#error)

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
