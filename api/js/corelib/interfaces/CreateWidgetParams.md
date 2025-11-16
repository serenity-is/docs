[serenity-is/corelib](../README.md) / CreateWidgetParams

# Interface: CreateWidgetParams\<TWidget, P\>

Defined in: [src/ui/widgets/widget.ts:248](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L248)

## Type Parameters

### TWidget

`TWidget` *extends* [`Widget`](../classes/Widget.md)\<`P`\>

### P

`P`

## Properties

### container?

> `optional` **container**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\>

Defined in: [src/ui/widgets/widget.ts:251](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L251)

***

### element()?

> `optional` **element**: (`e`) => `void`

Defined in: [src/ui/widgets/widget.ts:252](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L252)

#### Parameters

##### e

[`Fluent`](Fluent.md)

#### Returns

`void`

***

### init()?

> `optional` **init**: (`w`) => `void`

Defined in: [src/ui/widgets/widget.ts:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L253)

#### Parameters

##### w

`TWidget`

#### Returns

`void`

***

### options?

> `optional` **options**: `P` & `object`

Defined in: [src/ui/widgets/widget.ts:250](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L250)

#### Type Declaration

##### class?

> `optional` **class**: `string`

##### element?

> `optional` **element**: `string` \| `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> \| (`el`) => `void`

##### id?

> `optional` **id**: `string`

***

### type?

> `optional` **type**: \{(`options?`): `TWidget`; `prototype`: `TWidget`; \}

Defined in: [src/ui/widgets/widget.ts:249](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L249)

#### Parameters

##### options?

`P`

#### Returns

`TWidget`

#### prototype

> **prototype**: `TWidget`
