[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](../modules/corelib_q.md) / RetrieveLocalizationResponse

# Interface: RetrieveLocalizationResponse<TEntity\>

[corelib/q](../modules/corelib_q.md).RetrieveLocalizationResponse

## Type parameters

| Name |
| :------ |
| `TEntity` |

## Hierarchy

- [`ServiceResponse`](corelib_q.ServiceResponse.md)

  ↳ **`RetrieveLocalizationResponse`**

## Table of contents

### Properties

- [Entities](corelib_q.RetrieveLocalizationResponse.md#entities)
- [Error](corelib_q.RetrieveLocalizationResponse.md#error)

## Properties

### Entities

• `Optional` **Entities**: `Object`

#### Index signature

▪ [key: `string`]: `TEntity`

#### Defined in

[src/q/servicetypes.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#line&#x3D;115)

___

### Error

• `Optional` **Error**: [`ServiceError`](corelib_q.ServiceError.md)

#### Inherited from

[ServiceResponse](corelib_q.ServiceResponse.md).[Error](corelib_q.ServiceResponse.md#error)

#### Defined in

[src/q/servicetypes.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#line&#x3D;10)
