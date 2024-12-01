[@serenity-is/corelib](../README.md) / CreateWidgetParams

# Interface: CreateWidgetParams\<TWidget, P\>

## Type Parameters

• **TWidget** *extends* [`Widget`](../classes/Widget.md)\<`P`\>

• **P**

## Properties

### container?

> `optional` **container**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\>

#### Defined in

[src/ui/widgets/widget.ts:235](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L235)

***

### element()?

> `optional` **element**: (`e`) => `void`

#### Parameters

##### e

[`Fluent`](Fluent.md)\<`HTMLElement`\>

#### Returns

`void`

#### Defined in

[src/ui/widgets/widget.ts:236](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L236)

***

### init()?

> `optional` **init**: (`w`) => `void`

#### Parameters

##### w

`TWidget`

#### Returns

`void`

#### Defined in

[src/ui/widgets/widget.ts:237](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L237)

***

### options?

> `optional` **options**: `P` & `object`

#### Type declaration

##### class?

> `optional` **class**: `string`

##### element?

> `optional` **element**: `string` \| `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> \| (`el`) => `void`

##### id?

> `optional` **id**: `string`

#### Defined in

[src/ui/widgets/widget.ts:234](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L234)

***

### type()?

> `optional` **type**: (`options`?) => `TWidget`

#### Parameters

##### options?

`P`

#### Returns

`TWidget`

#### prototype

> **prototype**: `TWidget`

#### Defined in

[src/ui/widgets/widget.ts:233](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L233)
