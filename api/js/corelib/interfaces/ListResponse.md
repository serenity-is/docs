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

[../base/dist/index.d.ts:519](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L519)

___

### Error

• `Optional` **Error**: [`ServiceError`](ServiceError.md)

#### Inherited from

[ServiceResponse](ServiceResponse.md).[Error](ServiceResponse.md#error)

#### Defined in

[../base/dist/index.d.ts:456](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L456)

___

### Skip

• `Optional` **Skip**: `number`

#### Defined in

[../base/dist/index.d.ts:522](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L522)

___

### Take

• `Optional` **Take**: `number`

#### Defined in

[../base/dist/index.d.ts:523](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L523)

___

### TotalCount

• `Optional` **TotalCount**: `number`

#### Defined in

[../base/dist/index.d.ts:521](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L521)

___

### Values

• `Optional` **Values**: `any`[]

#### Defined in

[../base/dist/index.d.ts:520](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L520)
