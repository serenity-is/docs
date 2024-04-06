[@serenity-is/corelib](../README.md) / ListResponse

# Interface: ListResponse\<TEntity\>

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

[src/base/servicetypes.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L84)

___

### Error

• `Optional` **Error**: [`ServiceError`](ServiceError.md)

#### Inherited from

[ServiceResponse](ServiceResponse.md).[Error](ServiceResponse.md#error)

#### Defined in

[src/base/servicetypes.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L10)

___

### Skip

• `Optional` **Skip**: `number`

#### Defined in

[src/base/servicetypes.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L87)

___

### Take

• `Optional` **Take**: `number`

#### Defined in

[src/base/servicetypes.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L88)

___

### TotalCount

• `Optional` **TotalCount**: `number`

#### Defined in

[src/base/servicetypes.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L86)

___

### Values

• `Optional` **Values**: `any`[]

#### Defined in

[src/base/servicetypes.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L85)
