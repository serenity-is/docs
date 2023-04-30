[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](corelib.md) / WX

# Namespace: WX

[corelib](corelib.md).WX

## Table of contents

### Functions

- [change](corelib.WX.md#change)
- [changeSelect2](corelib.WX.md#changeselect2)
- [getGridField](corelib.WX.md#getgridfield)
- [getWidget](corelib.WX.md#getwidget)
- [getWidgetName](corelib.WX.md#getwidgetname)
- [hasOriginalEvent](corelib.WX.md#hasoriginalevent)

## Functions

### change

▸ **change**(`widget`, `handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `widget` | `any` |
| `handler` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/wx.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/wx.ts#L14)

___

### changeSelect2

▸ **changeSelect2**(`widget`, `handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `widget` | `any` |
| `handler` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/wx.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/wx.ts#L18)

___

### getGridField

▸ **getGridField**(`widget`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `widget` | [`Widget`](../classes/corelib.Widget.md)<`any`\> |

#### Returns

`JQuery`

#### Defined in

[src/ui/widgets/wx.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/wx.ts#L22)

___

### getWidget

▸ **getWidget**<`TWidget`\>(`element`, `type`): `TWidget`

#### Type parameters

| Name |
| :------ |
| `TWidget` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |
| `type` | `any` |

#### Returns

`TWidget`

#### Defined in

[src/ui/widgets/wx.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/wx.ts#L4)

___

### getWidgetName

▸ **getWidgetName**(`type`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `Function` |

#### Returns

`string`

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)

___

### hasOriginalEvent

▸ **hasOriginalEvent**(`e`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `any` |

#### Returns

`boolean`

#### Defined in

[src/ui/widgets/wx.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/wx.ts#L10)
