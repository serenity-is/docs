[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / Flexify

# Class: Flexify

[corelib](../modules/corelib.md).Flexify

## Hierarchy

- [`Widget`](corelib.Widget.md)<[`FlexifyOptions`](../interfaces/corelib.FlexifyOptions.md)\>

  ↳ **`Flexify`**

## Table of contents

### Constructors

- [constructor](corelib.Flexify.md#constructor)

### Properties

- [element](corelib.Flexify.md#element)
- [idPrefix](corelib.Flexify.md#idprefix)
- [options](corelib.Flexify.md#options)
- [uniqueName](corelib.Flexify.md#uniquename)
- [widgetName](corelib.Flexify.md#widgetname)
- [xDifference](corelib.Flexify.md#xdifference)
- [yDifference](corelib.Flexify.md#ydifference)

### Methods

- [addCssClass](corelib.Flexify.md#addcssclass)
- [addValidationRule](corelib.Flexify.md#addvalidationrule)
- [change](corelib.Flexify.md#change)
- [changeSelect2](corelib.Flexify.md#changeselect2)
- [destroy](corelib.Flexify.md#destroy)
- [getCssClass](corelib.Flexify.md#getcssclass)
- [getGridField](corelib.Flexify.md#getgridfield)
- [getXFactor](corelib.Flexify.md#getxfactor)
- [getYFactor](corelib.Flexify.md#getyfactor)
- [init](corelib.Flexify.md#init)
- [initialize](corelib.Flexify.md#initialize)
- [renderContents](corelib.Flexify.md#rendercontents)
- [resizeElement](corelib.Flexify.md#resizeelement)
- [resizeElements](corelib.Flexify.md#resizeelements)
- [storeInitialSize](corelib.Flexify.md#storeinitialsize)
- [create](corelib.Flexify.md#create)
- [elementFor](corelib.Flexify.md#elementfor)
- [getWidgetName](corelib.Flexify.md#getwidgetname)

## Constructors

### constructor

• **new Flexify**(`container`, `options`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `container` | `JQuery` |
| `options` | [`FlexifyOptions`](../interfaces/corelib.FlexifyOptions.md) |

#### Overrides

[Widget](corelib.Widget.md).[constructor](corelib.Widget.md#constructor)

#### Defined in

[src/ui/widgets/flexify.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/flexify.ts#L29)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[Widget](corelib.Widget.md).[element](corelib.Widget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[idPrefix](corelib.Widget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### options

• `Protected` **options**: [`FlexifyOptions`](../interfaces/corelib.FlexifyOptions.md)

#### Inherited from

[Widget](corelib.Widget.md).[options](corelib.Widget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[uniqueName](corelib.Widget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[widgetName](corelib.Widget.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

___

### xDifference

• `Private` **xDifference**: `number` = `0`

#### Defined in

[src/ui/widgets/flexify.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/flexify.ts#L27)

___

### yDifference

• `Private` **yDifference**: `number` = `0`

#### Defined in

[src/ui/widgets/flexify.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/flexify.ts#L28)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[addCssClass](corelib.Widget.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### addValidationRule

▸ **addValidationRule**(`eventClass`, `rule`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `eventClass` | `string` |
| `rule` | (`p1`: `JQuery`) => `string` |

#### Returns

`JQuery`

#### Inherited from

[Widget](corelib.Widget.md).[addValidationRule](corelib.Widget.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

___

### change

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[change](corelib.Widget.md#change)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[change](corelib.Widget.md#change)

#### Defined in

[src/ui/widgets/widget.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L259)

___

### changeSelect2

▸ **changeSelect2**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[changeSelect2](corelib.Widget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

▸ **changeSelect2**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[changeSelect2](corelib.Widget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[destroy](corelib.Widget.md#destroy)

#### Defined in

[src/ui/widgets/widget.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L92)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[Widget](corelib.Widget.md).[getCssClass](corelib.Widget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[Widget](corelib.Widget.md).[getGridField](corelib.Widget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getXFactor

▸ `Private` **getXFactor**(`element`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |

#### Returns

`number`

#### Defined in

[src/ui/widgets/flexify.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/flexify.ts#L70)

___

### getYFactor

▸ `Private` **getYFactor**(`element`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |

#### Returns

`number`

#### Defined in

[src/ui/widgets/flexify.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/flexify.ts#L81)

___

### init

▸ **init**(`action?`): [`Flexify`](corelib.Flexify.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`Flexify`](corelib.Flexify.md)

#### Inherited from

[Widget](corelib.Widget.md).[init](corelib.Widget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[initialize](corelib.Widget.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[renderContents](corelib.Widget.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

___

### resizeElement

▸ `Private` **resizeElement**(`element`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |

#### Returns

`void`

#### Defined in

[src/ui/widgets/flexify.ts:125](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/flexify.ts#L125)

___

### resizeElements

▸ `Private` **resizeElements**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/flexify.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/flexify.ts#L93)

___

### storeInitialSize

▸ **storeInitialSize**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/flexify.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/flexify.ts#L37)

___

### create

▸ `Static` **create**<`TWidget`, `TOpt`\>(`params`): `TWidget`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](corelib.Widget.md)<`TOpt`, `TWidget`\> |
| `TOpt` | `TOpt` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `params` | [`CreateWidgetParams`](../interfaces/corelib.CreateWidgetParams.md)<`TWidget`, `TOpt`\> |

#### Returns

`TWidget`

#### Inherited from

[Widget](corelib.Widget.md).[create](corelib.Widget.md#create)

#### Defined in

[src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

___

### elementFor

▸ `Static` **elementFor**<`TWidget`\>(`editorType`): `JQuery`

#### Type parameters

| Name |
| :------ |
| `TWidget` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `editorType` | (...`args`: `any`[]) => `TWidget` |

#### Returns

`JQuery`

#### Inherited from

[Widget](corelib.Widget.md).[elementFor](corelib.Widget.md#elementfor)

#### Defined in

[src/ui/widgets/widget.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L128)

___

### getWidgetName

▸ `Static` **getWidgetName**(`type`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `Function` |

#### Returns

`string`

#### Inherited from

[Widget](corelib.Widget.md).[getWidgetName](corelib.Widget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
