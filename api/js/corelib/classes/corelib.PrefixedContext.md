[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / PrefixedContext

# Class: PrefixedContext

[corelib](../modules/corelib.md).PrefixedContext

## Table of contents

### Constructors

- [constructor](corelib.PrefixedContext.md#constructor)

### Properties

- [idPrefix](corelib.PrefixedContext.md#idprefix)

### Methods

- [byId](corelib.PrefixedContext.md#byid)
- [w](corelib.PrefixedContext.md#w)

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
