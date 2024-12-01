[@serenity-is/corelib](../README.md) / PrefixedContext

# Class: PrefixedContext

## Constructors

### new PrefixedContext()

> **new PrefixedContext**(`idPrefix`): [`PrefixedContext`](PrefixedContext.md)

#### Parameters

##### idPrefix

`string`

#### Returns

[`PrefixedContext`](PrefixedContext.md)

#### Defined in

[src/ui/widgets/prefixedcontext.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L5)

## Properties

### idPrefix

> `readonly` **idPrefix**: `string`

#### Defined in

[src/ui/widgets/prefixedcontext.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L5)

## Methods

### byId()

> **byId**(`id`): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Parameters

##### id

`string`

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/widgets/prefixedcontext.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L8)

***

### w()

> **w**\<`TWidget`\>(`id`, `type`): `TWidget`

#### Type Parameters

• **TWidget**

#### Parameters

##### id

`string`

##### type

(...`args`) => `TWidget`

#### Returns

`TWidget`

#### Defined in

[src/ui/widgets/prefixedcontext.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L12)
