[@serenity-is/corelib](../README.md) / PrefixedContext

# Class: PrefixedContext

Defined in: [src/ui/widgets/prefixedcontext.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L4)

## Constructors

### Constructor

> **new PrefixedContext**(`idPrefix`): `PrefixedContext`

Defined in: [src/ui/widgets/prefixedcontext.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L5)

#### Parameters

##### idPrefix

`string`

#### Returns

`PrefixedContext`

## Properties

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/prefixedcontext.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L5)

## Methods

### byId()

> **byId**(`id`): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/prefixedcontext.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L8)

#### Parameters

##### id

`string`

#### Returns

[`Fluent`](../interfaces/Fluent.md)

***

### w()

> **w**\<`TWidget`\>(`id`, `type`): `TWidget`

Defined in: [src/ui/widgets/prefixedcontext.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L12)

#### Type Parameters

##### TWidget

`TWidget`

#### Parameters

##### id

`string`

##### type

(...`args`) => `TWidget`

#### Returns

`TWidget`
