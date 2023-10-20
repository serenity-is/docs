[@serenity-is](../README.md) / [Modules](../modules.md) / [q](../modules/q.md) / RetrieveLocalizationResponse

# Interface: RetrieveLocalizationResponse<TEntity\>

[q](../modules/q.md).RetrieveLocalizationResponse

## Type parameters

| Name |
| :------ |
| `TEntity` |

## Hierarchy

- [`ServiceResponse`](q.ServiceResponse.md)

  ↳ **`RetrieveLocalizationResponse`**

## Table of contents

### Properties

- [Entities](q.RetrieveLocalizationResponse.md#entities)
- [Error](q.RetrieveLocalizationResponse.md#error)

## Properties

### Entities

• `Optional` **Entities**: `Object`

#### Index signature

▪ [key: `string`]: `TEntity`

#### Defined in

[src/q/servicetypes.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L115)

___

### Error

• `Optional` **Error**: [`ServiceError`](q.ServiceError.md)

#### Inherited from

[ServiceResponse](q.ServiceResponse.md).[Error](q.ServiceResponse.md#error)

#### Defined in

[src/q/servicetypes.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L10)
