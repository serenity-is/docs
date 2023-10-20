[@serenity-is](../README.md) / [Modules](../modules.md) / [q](../modules/q.md) / SaveWithLocalizationRequest

# Interface: SaveWithLocalizationRequest<TEntity\>

[q](../modules/q.md).SaveWithLocalizationRequest

## Type parameters

| Name |
| :------ |
| `TEntity` |

## Hierarchy

- [`SaveRequest`](q.SaveRequest.md)<`TEntity`\>

  ↳ **`SaveWithLocalizationRequest`**

## Table of contents

### Properties

- [Entity](q.SaveWithLocalizationRequest.md#entity)
- [EntityId](q.SaveWithLocalizationRequest.md#entityid)
- [Localizations](q.SaveWithLocalizationRequest.md#localizations)

## Properties

### Entity

• `Optional` **Entity**: `TEntity`

#### Inherited from

[SaveRequest](q.SaveRequest.md).[Entity](q.SaveRequest.md#entity)

#### Defined in

[src/q/servicetypes.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L27)

___

### EntityId

• `Optional` **EntityId**: `any`

#### Inherited from

[SaveRequest](q.SaveRequest.md).[EntityId](q.SaveRequest.md#entityid)

#### Defined in

[src/q/servicetypes.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L26)

___

### Localizations

• `Optional` **Localizations**: `Object`

#### Index signature

▪ [key: `string`]: `TEntity`

#### Overrides

[SaveRequest](q.SaveRequest.md).[Localizations](q.SaveRequest.md#localizations)

#### Defined in

[src/q/servicetypes.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L40)
