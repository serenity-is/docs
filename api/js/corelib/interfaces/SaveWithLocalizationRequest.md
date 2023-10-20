[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / SaveWithLocalizationRequest

# Interface: SaveWithLocalizationRequest<TEntity\>

## Type parameters

| Name |
| :------ |
| `TEntity` |

## Hierarchy

- [`SaveRequest`](SaveRequest.md)<`TEntity`\>

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

[src/q/servicetypes.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L27)

___

### EntityId

• `Optional` **EntityId**: `any`

#### Inherited from

[SaveRequest](SaveRequest.md).[EntityId](SaveRequest.md#entityid)

#### Defined in

[src/q/servicetypes.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L26)

___

### Localizations

• `Optional` **Localizations**: `Object`

#### Index signature

▪ [key: `string`]: `TEntity`

#### Overrides

[SaveRequest](SaveRequest.md).[Localizations](SaveRequest.md#localizations)

#### Defined in

[src/q/servicetypes.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L40)
