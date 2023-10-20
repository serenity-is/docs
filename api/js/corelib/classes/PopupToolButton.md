[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / PopupToolButton

# Class: PopupToolButton

## Hierarchy

- [`PopupMenuButton`](PopupMenuButton.md)

  ↳ **`PopupToolButton`**

## Table of contents

### Constructors

- [constructor](PopupToolButton.md#constructor)

### Properties

- [element](PopupToolButton.md#element)
- [idPrefix](PopupToolButton.md#idprefix)
- [options](PopupToolButton.md#options)
- [uniqueName](PopupToolButton.md#uniquename)
- [widgetName](PopupToolButton.md#widgetname)

### Methods

- [addCssClass](PopupToolButton.md#addcssclass)
- [addValidationRule](PopupToolButton.md#addvalidationrule)
- [change](PopupToolButton.md#change)
- [changeSelect2](PopupToolButton.md#changeselect2)
- [destroy](PopupToolButton.md#destroy)
- [getCssClass](PopupToolButton.md#getcssclass)
- [getGridField](PopupToolButton.md#getgridfield)
- [init](PopupToolButton.md#init)
- [initialize](PopupToolButton.md#initialize)
- [renderContents](PopupToolButton.md#rendercontents)
- [create](PopupToolButton.md#create)
- [elementFor](PopupToolButton.md#elementfor)
- [getWidgetName](PopupToolButton.md#getwidgetname)

## Constructors

### constructor

• **new PopupToolButton**(`div`, `opt`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `div` | `JQuery` |
| `opt` | [`PopupToolButtonOptions`](../interfaces/PopupToolButtonOptions.md) |

#### Overrides

[PopupMenuButton](PopupMenuButton.md).[constructor](PopupMenuButton.md#constructor)

#### Defined in

[src/ui/widgets/toolbar.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.ts#L74)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[PopupMenuButton](PopupMenuButton.md).[element](PopupMenuButton.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[PopupMenuButton](PopupMenuButton.md).[idPrefix](PopupMenuButton.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### options

• `Protected` **options**: [`PopupMenuButtonOptions`](../interfaces/PopupMenuButtonOptions.md)

#### Inherited from

[PopupMenuButton](PopupMenuButton.md).[options](PopupMenuButton.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[PopupMenuButton](PopupMenuButton.md).[uniqueName](PopupMenuButton.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[PopupMenuButton](PopupMenuButton.md).[widgetName](PopupMenuButton.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[PopupMenuButton](PopupMenuButton.md).[addCssClass](PopupMenuButton.md#addcssclass)

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

[PopupMenuButton](PopupMenuButton.md).[addValidationRule](PopupMenuButton.md#addvalidationrule)

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

[PopupMenuButton](PopupMenuButton.md).[change](PopupMenuButton.md#change)

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

[PopupMenuButton](PopupMenuButton.md).[change](PopupMenuButton.md#change)

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

[PopupMenuButton](PopupMenuButton.md).[changeSelect2](PopupMenuButton.md#changeselect2)

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

[PopupMenuButton](PopupMenuButton.md).[changeSelect2](PopupMenuButton.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[PopupMenuButton](PopupMenuButton.md).[destroy](PopupMenuButton.md#destroy)

#### Defined in

[src/ui/widgets/toolbar.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/toolbar.ts#L58)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[PopupMenuButton](PopupMenuButton.md).[getCssClass](PopupMenuButton.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[PopupMenuButton](PopupMenuButton.md).[getGridField](PopupMenuButton.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### init

▸ **init**(`action?`): [`PopupToolButton`](PopupToolButton.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`PopupToolButton`](PopupToolButton.md)

#### Inherited from

[PopupMenuButton](PopupMenuButton.md).[init](PopupMenuButton.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[PopupMenuButton](PopupMenuButton.md).[initialize](PopupMenuButton.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[PopupMenuButton](PopupMenuButton.md).[renderContents](PopupMenuButton.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

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

[PopupMenuButton](PopupMenuButton.md).[create](PopupMenuButton.md#create)

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

[PopupMenuButton](PopupMenuButton.md).[elementFor](PopupMenuButton.md#elementfor)

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

[PopupMenuButton](PopupMenuButton.md).[getWidgetName](PopupMenuButton.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
