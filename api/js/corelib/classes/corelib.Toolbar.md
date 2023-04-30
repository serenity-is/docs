[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / Toolbar

# Class: Toolbar

[corelib](../modules/corelib.md).Toolbar

## Hierarchy

- [`Widget`](corelib.Widget.md)<[`ToolbarOptions`](../interfaces/corelib.ToolbarOptions.md)\>

  ↳ **`Toolbar`**

## Table of contents

### Constructors

- [constructor](corelib.Toolbar.md#constructor)

### Properties

- [element](corelib.Toolbar.md#element)
- [idPrefix](corelib.Toolbar.md#idprefix)
- [mouseTrap](corelib.Toolbar.md#mousetrap)
- [options](corelib.Toolbar.md#options)
- [uniqueName](corelib.Toolbar.md#uniquename)
- [widgetName](corelib.Toolbar.md#widgetname)

### Methods

- [addCssClass](corelib.Toolbar.md#addcssclass)
- [addValidationRule](corelib.Toolbar.md#addvalidationrule)
- [change](corelib.Toolbar.md#change)
- [changeSelect2](corelib.Toolbar.md#changeselect2)
- [createButton](corelib.Toolbar.md#createbutton)
- [createButtons](corelib.Toolbar.md#createbuttons)
- [destroy](corelib.Toolbar.md#destroy)
- [findButton](corelib.Toolbar.md#findbutton)
- [getCssClass](corelib.Toolbar.md#getcssclass)
- [getGridField](corelib.Toolbar.md#getgridfield)
- [init](corelib.Toolbar.md#init)
- [initialize](corelib.Toolbar.md#initialize)
- [renderContents](corelib.Toolbar.md#rendercontents)
- [updateInterface](corelib.Toolbar.md#updateinterface)
- [create](corelib.Toolbar.md#create)
- [elementFor](corelib.Toolbar.md#elementfor)
- [getWidgetName](corelib.Toolbar.md#getwidgetname)

## Constructors

### constructor

• **new Toolbar**(`div`, `options`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `div` | `JQuery` |
| `options` | [`ToolbarOptions`](../interfaces/corelib.ToolbarOptions.md) |

#### Overrides

[Widget](corelib.Widget.md).[constructor](corelib.Widget.md#constructor)

#### Defined in

[src/ui/widgets/toolbar.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.ts#L89)

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

### mouseTrap

• `Protected` **mouseTrap**: `any`

#### Defined in

[src/ui/widgets/toolbar.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.ts#L114)

___

### options

• `Protected` **options**: [`ToolbarOptions`](../interfaces/corelib.ToolbarOptions.md)

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

### createButton

▸ `Protected` **createButton**(`container`, `b`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `container` | `JQuery` |
| `b` | [`ToolButton`](../interfaces/corelib.ToolButton.md) |

#### Returns

`void`

#### Defined in

[src/ui/widgets/toolbar.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.ts#L131)

___

### createButtons

▸ `Protected` **createButtons**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/toolbar.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.ts#L116)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[Widget](corelib.Widget.md).[destroy](corelib.Widget.md#destroy)

#### Defined in

[src/ui/widgets/toolbar.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.ts#L99)

___

### findButton

▸ **findButton**(`className`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `className` | `string` |

#### Returns

`JQuery`

#### Defined in

[src/ui/widgets/toolbar.ts:212](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.ts#L212)

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

### init

▸ **init**(`action?`): [`Toolbar`](corelib.Toolbar.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`Toolbar`](corelib.Toolbar.md)

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

### updateInterface

▸ **updateInterface**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/toolbar.ts:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.ts#L219)

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
