[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / PopupToolButton

# Class: PopupToolButton

[corelib](../modules/corelib.md).PopupToolButton

## Hierarchy

- [`PopupMenuButton`](corelib.PopupMenuButton.md)

  ↳ **`PopupToolButton`**

## Table of contents

### Constructors

- [constructor](corelib.PopupToolButton.md#constructor)

### Properties

- [element](corelib.PopupToolButton.md#element)
- [idPrefix](corelib.PopupToolButton.md#idprefix)
- [options](corelib.PopupToolButton.md#options)
- [uniqueName](corelib.PopupToolButton.md#uniquename)
- [widgetName](corelib.PopupToolButton.md#widgetname)

### Methods

- [addCssClass](corelib.PopupToolButton.md#addcssclass)
- [addValidationRule](corelib.PopupToolButton.md#addvalidationrule)
- [change](corelib.PopupToolButton.md#change)
- [changeSelect2](corelib.PopupToolButton.md#changeselect2)
- [destroy](corelib.PopupToolButton.md#destroy)
- [getCssClass](corelib.PopupToolButton.md#getcssclass)
- [getGridField](corelib.PopupToolButton.md#getgridfield)
- [init](corelib.PopupToolButton.md#init)
- [initialize](corelib.PopupToolButton.md#initialize)
- [renderContents](corelib.PopupToolButton.md#rendercontents)
- [create](corelib.PopupToolButton.md#create)
- [elementFor](corelib.PopupToolButton.md#elementfor)
- [getWidgetName](corelib.PopupToolButton.md#getwidgetname)

## Constructors

### constructor

• **new PopupToolButton**(`div`, `opt`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `div` | `JQuery` |
| `opt` | [`PopupToolButtonOptions`](../interfaces/corelib.PopupToolButtonOptions.md) |

#### Overrides

[PopupMenuButton](corelib.PopupMenuButton.md).[constructor](corelib.PopupMenuButton.md#constructor)

#### Defined in

[src/ui/widgets/toolbar.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.ts#L74)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[PopupMenuButton](corelib.PopupMenuButton.md).[element](corelib.PopupMenuButton.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[PopupMenuButton](corelib.PopupMenuButton.md).[idPrefix](corelib.PopupMenuButton.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### options

• `Protected` **options**: [`PopupMenuButtonOptions`](../interfaces/corelib.PopupMenuButtonOptions.md)

#### Inherited from

[PopupMenuButton](corelib.PopupMenuButton.md).[options](corelib.PopupMenuButton.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[PopupMenuButton](corelib.PopupMenuButton.md).[uniqueName](corelib.PopupMenuButton.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[PopupMenuButton](corelib.PopupMenuButton.md).[widgetName](corelib.PopupMenuButton.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[PopupMenuButton](corelib.PopupMenuButton.md).[addCssClass](corelib.PopupMenuButton.md#addcssclass)

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

[PopupMenuButton](corelib.PopupMenuButton.md).[addValidationRule](corelib.PopupMenuButton.md#addvalidationrule)

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

[PopupMenuButton](corelib.PopupMenuButton.md).[change](corelib.PopupMenuButton.md#change)

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

[PopupMenuButton](corelib.PopupMenuButton.md).[change](corelib.PopupMenuButton.md#change)

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

[PopupMenuButton](corelib.PopupMenuButton.md).[changeSelect2](corelib.PopupMenuButton.md#changeselect2)

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

[PopupMenuButton](corelib.PopupMenuButton.md).[changeSelect2](corelib.PopupMenuButton.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[PopupMenuButton](corelib.PopupMenuButton.md).[destroy](corelib.PopupMenuButton.md#destroy)

#### Defined in

[src/ui/widgets/toolbar.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.ts#L58)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[PopupMenuButton](corelib.PopupMenuButton.md).[getCssClass](corelib.PopupMenuButton.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[PopupMenuButton](corelib.PopupMenuButton.md).[getGridField](corelib.PopupMenuButton.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### init

▸ **init**(`action?`): [`PopupToolButton`](corelib.PopupToolButton.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`PopupToolButton`](corelib.PopupToolButton.md)

#### Inherited from

[PopupMenuButton](corelib.PopupMenuButton.md).[init](corelib.PopupMenuButton.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[PopupMenuButton](corelib.PopupMenuButton.md).[initialize](corelib.PopupMenuButton.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[PopupMenuButton](corelib.PopupMenuButton.md).[renderContents](corelib.PopupMenuButton.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

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

[PopupMenuButton](corelib.PopupMenuButton.md).[create](corelib.PopupMenuButton.md#create)

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

[PopupMenuButton](corelib.PopupMenuButton.md).[elementFor](corelib.PopupMenuButton.md#elementfor)

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

[PopupMenuButton](corelib.PopupMenuButton.md).[getWidgetName](corelib.PopupMenuButton.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
