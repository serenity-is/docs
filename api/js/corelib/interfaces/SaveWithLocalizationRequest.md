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

[../base/dist/index.d.ts:462](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L462)

___

### EntityId

• `Optional` **EntityId**: `any`

#### Inherited from

[SaveRequest](SaveRequest.md).[EntityId](SaveRequest.md#entityid)

#### Defined in

[../base/dist/index.d.ts:461](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L461)

___

### Localizations

• `Optional` **Localizations**: `Object`

#### Index signature

▪ [key: `string`]: `TEntity`

#### Overrides

[SaveRequest](SaveRequest.md).[Localizations](SaveRequest.md#localizations)

#### Defined in

[../base/dist/index.d.ts:472](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L472)
