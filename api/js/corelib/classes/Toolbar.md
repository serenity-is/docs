[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / Toolbar

# Class: Toolbar

## Hierarchy

- [`Widget`](Widget.md)<[`ToolbarOptions`](../interfaces/ToolbarOptions.md)\>

  ↳ **`Toolbar`**

## Table of contents

### Constructors

- [constructor](Toolbar.md#constructor)

### Properties

- [element](Toolbar.md#element)
- [idPrefix](Toolbar.md#idprefix)
- [mouseTrap](Toolbar.md#mousetrap)
- [options](Toolbar.md#options)
- [uniqueName](Toolbar.md#uniquename)
- [widgetName](Toolbar.md#widgetname)

### Methods

- [addCssClass](Toolbar.md#addcssclass)
- [addValidationRule](Toolbar.md#addvalidationrule)
- [change](Toolbar.md#change)
- [changeSelect2](Toolbar.md#changeselect2)
- [createButton](Toolbar.md#createbutton)
- [createButtons](Toolbar.md#createbuttons)
- [destroy](Toolbar.md#destroy)
- [findButton](Toolbar.md#findbutton)
- [getCssClass](Toolbar.md#getcssclass)
- [getGridField](Toolbar.md#getgridfield)
- [init](Toolbar.md#init)
- [initialize](Toolbar.md#initialize)
- [renderContents](Toolbar.md#rendercontents)
- [updateInterface](Toolbar.md#updateinterface)
- [create](Toolbar.md#create)
- [elementFor](Toolbar.md#elementfor)
- [getWidgetName](Toolbar.md#getwidgetname)

## Constructors

### constructor

• **new Toolbar**(`div`, `options`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `div` | `JQuery` |
| `options` | [`ToolbarOptions`](../interfaces/ToolbarOptions.md) |

#### Overrides

[Widget](Widget.md).[constructor](Widget.md#constructor)

#### Defined in

[src/ui/widgets/toolbar.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.ts#L89)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[Widget](Widget.md).[element](Widget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[Widget](Widget.md).[idPrefix](Widget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### mouseTrap

• `Protected` **mouseTrap**: `any`

#### Defined in

[src/ui/widgets/toolbar.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.ts#L114)

___

### options

• `Protected` **options**: [`ToolbarOptions`](../interfaces/ToolbarOptions.md)

#### Inherited from

[Widget](Widget.md).[options](Widget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[Widget](Widget.md).[uniqueName](Widget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[Widget](Widget.md).[widgetName](Widget.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[addCssClass](Widget.md#addcssclass)

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

[Widget](Widget.md).[addValidationRule](Widget.md#addvalidationrule)

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

[Widget](Widget.md).[change](Widget.md#change)

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

[Widget](Widget.md).[change](Widget.md#change)

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

[Widget](Widget.md).[changeSelect2](Widget.md#changeselect2)

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

[Widget](Widget.md).[changeSelect2](Widget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### createButton

▸ `Protected` **createButton**(`container`, `b`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `container` | `JQuery` |
| `b` | [`ToolButton`](../interfaces/ToolButton.md) |

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

[Widget](Widget.md).[destroy](Widget.md#destroy)

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

[Widget](Widget.md).[getCssClass](Widget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[Widget](Widget.md).[getGridField](Widget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### init

▸ **init**(`action?`): [`Toolbar`](Toolbar.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`Toolbar`](Toolbar.md)

#### Inherited from

[Widget](Widget.md).[init](Widget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[initialize](Widget.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[renderContents](Widget.md#rendercontents)

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
| `TWidget` | extends [`Widget`](Widget.md)<`TOpt`, `TWidget`\> |
| `TOpt` | `TOpt` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `params` | [`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)<`TWidget`, `TOpt`\> |

#### Returns

`TWidget`

#### Inherited from

[Widget](Widget.md).[create](Widget.md#create)

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

[Widget](Widget.md).[elementFor](Widget.md#elementfor)

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

[Widget](Widget.md).[getWidgetName](Widget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
