[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / FilterDisplayBar

# Class: FilterDisplayBar

[corelib](../modules/corelib.md).FilterDisplayBar

## Hierarchy

- [`FilterWidgetBase`](corelib.FilterWidgetBase.md)<`any`\>

  ↳ **`FilterDisplayBar`**

## Table of contents

### Constructors

- [constructor](corelib.FilterDisplayBar.md#constructor)

### Properties

- [element](corelib.FilterDisplayBar.md#element)
- [idPrefix](corelib.FilterDisplayBar.md#idprefix)
- [options](corelib.FilterDisplayBar.md#options)
- [uniqueName](corelib.FilterDisplayBar.md#uniquename)
- [widgetName](corelib.FilterDisplayBar.md#widgetname)

### Methods

- [addCssClass](corelib.FilterDisplayBar.md#addcssclass)
- [addValidationRule](corelib.FilterDisplayBar.md#addvalidationrule)
- [byId](corelib.FilterDisplayBar.md#byid)
- [change](corelib.FilterDisplayBar.md#change)
- [changeSelect2](corelib.FilterDisplayBar.md#changeselect2)
- [destroy](corelib.FilterDisplayBar.md#destroy)
- [filterStoreChanged](corelib.FilterDisplayBar.md#filterstorechanged)
- [getCssClass](corelib.FilterDisplayBar.md#getcssclass)
- [getFallbackTemplate](corelib.FilterDisplayBar.md#getfallbacktemplate)
- [getGridField](corelib.FilterDisplayBar.md#getgridfield)
- [getTemplate](corelib.FilterDisplayBar.md#gettemplate)
- [getTemplateName](corelib.FilterDisplayBar.md#gettemplatename)
- [get\_store](corelib.FilterDisplayBar.md#get_store)
- [init](corelib.FilterDisplayBar.md#init)
- [initialize](corelib.FilterDisplayBar.md#initialize)
- [renderContents](corelib.FilterDisplayBar.md#rendercontents)
- [set\_store](corelib.FilterDisplayBar.md#set_store)
- [useIdPrefix](corelib.FilterDisplayBar.md#useidprefix)
- [create](corelib.FilterDisplayBar.md#create)
- [elementFor](corelib.FilterDisplayBar.md#elementfor)
- [getWidgetName](corelib.FilterDisplayBar.md#getwidgetname)

## Constructors

### constructor

• **new FilterDisplayBar**(`div`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `div` | `JQuery` |

#### Overrides

[FilterWidgetBase](corelib.FilterWidgetBase.md).[constructor](corelib.FilterWidgetBase.md#constructor)

#### Defined in

[src/ui/filtering/filterdisplaybar.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdisplaybar.ts#line&#x3D;9)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[FilterWidgetBase](corelib.FilterWidgetBase.md).[element](corelib.FilterWidgetBase.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[FilterWidgetBase](corelib.FilterWidgetBase.md).[idPrefix](corelib.FilterWidgetBase.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;65)

___

### options

• `Protected` **options**: `any`

#### Inherited from

[FilterWidgetBase](corelib.FilterWidgetBase.md).[options](corelib.FilterWidgetBase.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;62)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[FilterWidgetBase](corelib.FilterWidgetBase.md).[uniqueName](corelib.FilterWidgetBase.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[FilterWidgetBase](corelib.FilterWidgetBase.md).[widgetName](corelib.FilterWidgetBase.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;63)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](corelib.FilterWidgetBase.md).[addCssClass](corelib.FilterWidgetBase.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;100)

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

[FilterWidgetBase](corelib.FilterWidgetBase.md).[addValidationRule](corelib.FilterWidgetBase.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;134)

___

### byId

▸ `Protected` **byId**(`id`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

`JQuery`

#### Inherited from

[FilterWidgetBase](corelib.FilterWidgetBase.md).[byId](corelib.FilterWidgetBase.md#byid)

#### Defined in

[src/ui/widgets/templatedwidget.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;10)

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

[FilterWidgetBase](corelib.FilterWidgetBase.md).[change](corelib.FilterWidgetBase.md#change)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;142)

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](corelib.FilterWidgetBase.md).[change](corelib.FilterWidgetBase.md#change)

#### Defined in

[src/ui/widgets/widget.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;259)

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

[FilterWidgetBase](corelib.FilterWidgetBase.md).[changeSelect2](corelib.FilterWidgetBase.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;146)

▸ **changeSelect2**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](corelib.FilterWidgetBase.md).[changeSelect2](corelib.FilterWidgetBase.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](corelib.FilterWidgetBase.md).[destroy](corelib.FilterWidgetBase.md#destroy)

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#line&#x3D;19)

___

### filterStoreChanged

▸ `Protected` **filterStoreChanged**(): `void`

#### Returns

`void`

#### Overrides

[FilterWidgetBase](corelib.FilterWidgetBase.md).[filterStoreChanged](corelib.FilterWidgetBase.md#filterstorechanged)

#### Defined in

[src/ui/filtering/filterdisplaybar.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdisplaybar.ts#line&#x3D;38)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[FilterWidgetBase](corelib.FilterWidgetBase.md).[getCssClass](corelib.FilterWidgetBase.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;104)

___

### getFallbackTemplate

▸ `Protected` **getFallbackTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[FilterWidgetBase](corelib.FilterWidgetBase.md).[getFallbackTemplate](corelib.FilterWidgetBase.md#getfallbacktemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;79)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[FilterWidgetBase](corelib.FilterWidgetBase.md).[getGridField](corelib.FilterWidgetBase.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;138)

___

### getTemplate

▸ `Protected` **getTemplate**(): `string`

#### Returns

`string`

#### Overrides

[FilterWidgetBase](corelib.FilterWidgetBase.md).[getTemplate](corelib.FilterWidgetBase.md#gettemplate)

#### Defined in

[src/ui/filtering/filterdisplaybar.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdisplaybar.ts#line&#x3D;52)

___

### getTemplateName

▸ `Protected` **getTemplateName**(): `string`

#### Returns

`string`

#### Inherited from

[FilterWidgetBase](corelib.FilterWidgetBase.md).[getTemplateName](corelib.FilterWidgetBase.md#gettemplatename)

#### Defined in

[src/ui/widgets/templatedwidget.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;31)

___

### get\_store

▸ **get_store**(): [`FilterStore`](corelib.FilterStore.md)

#### Returns

[`FilterStore`](corelib.FilterStore.md)

#### Inherited from

[FilterWidgetBase](corelib.FilterWidgetBase.md).[get_store](corelib.FilterWidgetBase.md#get_store)

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#line&#x3D;33)

___

### init

▸ **init**(`action?`): [`FilterDisplayBar`](corelib.FilterDisplayBar.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`FilterDisplayBar`](corelib.FilterDisplayBar.md)

#### Inherited from

[FilterWidgetBase](corelib.FilterWidgetBase.md).[init](corelib.FilterWidgetBase.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](corelib.FilterWidgetBase.md).[initialize](corelib.FilterWidgetBase.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;176)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](corelib.FilterWidgetBase.md).[renderContents](corelib.FilterWidgetBase.md#rendercontents)

#### Defined in

[src/ui/widgets/templatedwidget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;110)

___

### set\_store

▸ **set_store**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`FilterStore`](corelib.FilterStore.md) |

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](corelib.FilterWidgetBase.md).[set_store](corelib.FilterWidgetBase.md#set_store)

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#line&#x3D;37)

___

### useIdPrefix

▸ `Protected` **useIdPrefix**(): `IdPrefixType`

#### Returns

`IdPrefixType`

#### Inherited from

[FilterWidgetBase](corelib.FilterWidgetBase.md).[useIdPrefix](corelib.FilterWidgetBase.md#useidprefix)

#### Defined in

[src/ui/widgets/templatedwidget.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;131)

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

[FilterWidgetBase](corelib.FilterWidgetBase.md).[create](corelib.FilterWidgetBase.md#create)

#### Defined in

[src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;153)

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

[FilterWidgetBase](corelib.FilterWidgetBase.md).[elementFor](corelib.FilterWidgetBase.md#elementfor)

#### Defined in

[src/ui/widgets/widget.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;128)

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

[FilterWidgetBase](corelib.FilterWidgetBase.md).[getWidgetName](corelib.FilterWidgetBase.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;124)
