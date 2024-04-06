[@serenity-is/corelib](../README.md) / CreateWidgetParams

# Interface: CreateWidgetParams\<TWidget, P\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](../classes/Widget.md)\<`P`\> |
| `P` | `P` |

## Table of contents

### Properties

- [container](CreateWidgetParams.md#container)
- [element](CreateWidgetParams.md#element)
- [init](CreateWidgetParams.md#init)
- [options](CreateWidgetParams.md#options)
- [type](CreateWidgetParams.md#type)

## Properties

### container

• `Optional` **container**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\>

#### Defined in

[src/ui/widgets/widget.ts:212](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L212)

___

### element

• `Optional` **element**: (`e`: [`Fluent`](Fluent.md)\<`HTMLElement`\>) => `void`

#### Type declaration

▸ (`e`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `e` | [`Fluent`](Fluent.md)\<`HTMLElement`\> |

##### Returns

`void`

#### Defined in

[src/ui/widgets/widget.ts:213](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L213)

___

### init

• `Optional` **init**: (`w`: `TWidget`) => `void`

#### Type declaration

▸ (`w`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `w` | `TWidget` |

##### Returns

`void`

#### Defined in

[src/ui/widgets/widget.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L214)

___

### options

• `Optional` **options**: `P` & \{ `class?`: `string` ; `element?`: `string` \| `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> \| (`el`: `HTMLElement`) => `void` ; `id?`: `string`  }

#### Defined in

[src/ui/widgets/widget.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L211)

___

### type

• `Optional` **type**: `Object`

#### Call signature

• **new type**(`options?`): `TWidget`

##### Parameters

| Name | Type |
| :------ | :------ |
| `options?` | `P` |

##### Returns

`TWidget`

#### Type declaration

| Name | Type |
| :------ | :------ |
| `prototype` | `TWidget` |

#### Defined in

[src/ui/widgets/widget.ts:210](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L210)
