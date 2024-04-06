[@serenity-is/corelib](../README.md) / PrefixedContext

# Class: PrefixedContext

## Table of contents

### Constructors

- [constructor](PrefixedContext.md#constructor)

### Properties

- [idPrefix](PrefixedContext.md#idprefix)

### Methods

- [byId](PrefixedContext.md#byid)
- [w](PrefixedContext.md#w)

## Constructors

### constructor

• **new PrefixedContext**(`idPrefix`): [`PrefixedContext`](PrefixedContext.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `idPrefix` | `string` |

#### Returns

[`PrefixedContext`](PrefixedContext.md)

#### Defined in

[src/ui/widgets/prefixedcontext.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L5)

## Properties

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Defined in

[src/ui/widgets/prefixedcontext.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L5)

## Methods

### byId

▸ **byId**(`id`): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/widgets/prefixedcontext.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L8)

___

### w

▸ **w**\<`TWidget`\>(`id`, `type`): `TWidget`

#### Type parameters

| Name |
| :------ |
| `TWidget` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |
| `type` | (...`args`: `any`[]) => `TWidget` |

#### Returns

`TWidget`

#### Defined in

[src/ui/widgets/prefixedcontext.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L12)
