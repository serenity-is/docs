[@serenity-is/corelib](../README.md) / CreateWidgetParams

# Interface: CreateWidgetParams<TWidget, TOptions\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](../classes/Widget.md)<`TOptions`\> |
| `TOptions` | `TOptions` |

## Table of contents

### Properties

- [container](CreateWidgetParams.md#container)
- [element](CreateWidgetParams.md#element)
- [init](CreateWidgetParams.md#init)
- [options](CreateWidgetParams.md#options)
- [type](CreateWidgetParams.md#type)

## Properties

### container

• `Optional` **container**: `JQuery`

#### Defined in

[src/ui/widgets/widget.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L53)

___

### element

• `Optional` **element**: (`e`: `JQuery`) => `void`

#### Type declaration

▸ (`e`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `JQuery` |

##### Returns

`void`

#### Defined in

[src/ui/widgets/widget.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L54)

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

[src/ui/widgets/widget.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L55)

___

### options

• `Optional` **options**: `TOptions`

#### Defined in

[src/ui/widgets/widget.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L52)

___

### type

• `Optional` **type**: (`element`: `JQuery`, `options?`: `TOptions`) => `TWidget`

#### Type declaration

• **new type**(`element`, `options?`)

##### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |
| `options?` | `TOptions` |

#### Defined in

[src/ui/widgets/widget.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L51)
