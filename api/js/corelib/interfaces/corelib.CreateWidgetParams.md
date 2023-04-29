[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / CreateWidgetParams

# Interface: CreateWidgetParams<TWidget, TOptions\>

[corelib](../modules/corelib.md).CreateWidgetParams

## Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](../classes/corelib.Widget.md)<`TOptions`\> |
| `TOptions` | `TOptions` |

## Table of contents

### Properties

- [container](corelib.CreateWidgetParams.md#container)
- [element](corelib.CreateWidgetParams.md#element)
- [init](corelib.CreateWidgetParams.md#init)
- [options](corelib.CreateWidgetParams.md#options)
- [type](corelib.CreateWidgetParams.md#type)

## Properties

### container

• `Optional` **container**: `JQuery`

#### Defined in

[src/ui/widgets/widget.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;53)

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

[src/ui/widgets/widget.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;54)

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

[src/ui/widgets/widget.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;55)

___

### options

• `Optional` **options**: `TOptions`

#### Defined in

[src/ui/widgets/widget.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;52)

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

[src/ui/widgets/widget.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;51)
