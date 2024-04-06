[@serenity-is/corelib](../README.md) / SaveWithLocalizationRequest

# Interface: SaveWithLocalizationRequest\<TEntity\>

## Type parameters

| Name |
| :------ |
| `TEntity` |

## Hierarchy

- [`SaveRequest`](SaveRequest.md)\<`TEntity`\>

  ↳ **`SaveWithLocalizationRequest`**

## Table of contents

### Properties

- [Entity](SaveWithLocalizationRequest.md#entity)
- [EntityId](SaveWithLocalizationRequest.md#entityid)
- [Localizations](SaveWithLocalizationRequest.md#localizations)

## Properties

### Entity

• `Optional` **Entity**: `TEntity`

#### Inherited from

[SaveRequest](SaveRequest.md).[Entity](SaveRequest.md#entity)

#### Defined in

[src/base/servicetypes.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L18)

___

### EntityId

• `Optional` **EntityId**: `any`

#### Inherited from

[SaveRequest](SaveRequest.md).[EntityId](SaveRequest.md#entityid)

#### Defined in

[src/base/servicetypes.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L17)

___

### Localizations

• `Optional` **Localizations**: `Object`

#### Index signature

▪ [key: `string`]: `TEntity`

#### Overrides

[SaveRequest](SaveRequest.md).[Localizations](SaveRequest.md#localizations)

#### Defined in

[src/base/servicetypes.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L31)
