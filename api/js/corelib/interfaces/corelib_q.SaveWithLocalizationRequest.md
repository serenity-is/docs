[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/q](../modules/corelib_q.md) / SaveWithLocalizationRequest

# Interface: SaveWithLocalizationRequest<TEntity\>

[corelib/q](../modules/corelib_q.md).SaveWithLocalizationRequest

## Type parameters

| Name |
| :------ |
| `TEntity` |

## Hierarchy

- [`SaveRequest`](corelib_q.SaveRequest.md)<`TEntity`\>

  ↳ **`SaveWithLocalizationRequest`**

## Table of contents

### Properties

- [Entity](corelib_q.SaveWithLocalizationRequest.md#entity)
- [EntityId](corelib_q.SaveWithLocalizationRequest.md#entityid)
- [Localizations](corelib_q.SaveWithLocalizationRequest.md#localizations)

## Properties

### Entity

• `Optional` **Entity**: `TEntity`

#### Inherited from

[SaveRequest](corelib_q.SaveRequest.md).[Entity](corelib_q.SaveRequest.md#entity)

#### Defined in

[src/q/servicetypes.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L27)

___

### EntityId

• `Optional` **EntityId**: `any`

#### Inherited from

[SaveRequest](corelib_q.SaveRequest.md).[EntityId](corelib_q.SaveRequest.md#entityid)

#### Defined in

[src/q/servicetypes.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L26)

___

### Localizations

• `Optional` **Localizations**: `Object`

#### Index signature

▪ [key: `string`]: `TEntity`

#### Overrides

[SaveRequest](corelib_q.SaveRequest.md).[Localizations](corelib_q.SaveRequest.md#localizations)

#### Defined in

[src/q/servicetypes.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/servicetypes.ts#L40)
