[@serenity-is/corelib](../README.md) / RetrieveLocalizationResponse

# Interface: RetrieveLocalizationResponse\<TEntity\>

## Type parameters

| Name |
| :------ |
| `TEntity` |

## Hierarchy

- [`ServiceResponse`](ServiceResponse.md)

  ↳ **`RetrieveLocalizationResponse`**

## Table of contents

### Properties

- [Entities](RetrieveLocalizationResponse.md#entities)
- [Error](RetrieveLocalizationResponse.md#error)

## Properties

### Entities

• `Optional` **Entities**: `Object`

#### Index signature

▪ [key: `string`]: `TEntity`

#### Defined in

[../base/dist/index.d.ts:537](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L537)

___

### Error

• `Optional` **Error**: [`ServiceError`](ServiceError.md)

#### Inherited from

[ServiceResponse](ServiceResponse.md).[Error](ServiceResponse.md#error)

#### Defined in

[../base/dist/index.d.ts:456](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L456)
