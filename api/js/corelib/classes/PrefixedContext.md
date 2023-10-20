[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / PrefixedContext

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

• **new PrefixedContext**(`idPrefix`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `idPrefix` | `string` |

#### Defined in

[src/ui/widgets/prefixedcontext.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L4)

## Properties

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Defined in

[src/ui/widgets/prefixedcontext.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L4)

## Methods

### byId

▸ **byId**(`id`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

`JQuery`

#### Defined in

[src/ui/widgets/prefixedcontext.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L7)

___

### w

▸ **w**<`TWidget`\>(`id`, `type`): `TWidget`

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

[src/ui/widgets/prefixedcontext.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L11)
