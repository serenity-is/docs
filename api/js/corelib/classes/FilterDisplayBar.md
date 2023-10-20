[@serenity-is/corelib](../README.md) / FilterDisplayBar

# Class: FilterDisplayBar

## Hierarchy

- [`FilterWidgetBase`](FilterWidgetBase.md)<`any`\>

  ↳ **`FilterDisplayBar`**

## Table of contents

### Constructors

- [constructor](FilterDisplayBar.md#constructor)

### Properties

- [element](FilterDisplayBar.md#element)
- [idPrefix](FilterDisplayBar.md#idprefix)
- [options](FilterDisplayBar.md#options)
- [uniqueName](FilterDisplayBar.md#uniquename)
- [widgetName](FilterDisplayBar.md#widgetname)

### Methods

- [addCssClass](FilterDisplayBar.md#addcssclass)
- [addValidationRule](FilterDisplayBar.md#addvalidationrule)
- [byId](FilterDisplayBar.md#byid)
- [change](FilterDisplayBar.md#change)
- [changeSelect2](FilterDisplayBar.md#changeselect2)
- [destroy](FilterDisplayBar.md#destroy)
- [filterStoreChanged](FilterDisplayBar.md#filterstorechanged)
- [getCssClass](FilterDisplayBar.md#getcssclass)
- [getFallbackTemplate](FilterDisplayBar.md#getfallbacktemplate)
- [getGridField](FilterDisplayBar.md#getgridfield)
- [getTemplate](FilterDisplayBar.md#gettemplate)
- [getTemplateName](FilterDisplayBar.md#gettemplatename)
- [get\_store](FilterDisplayBar.md#get_store)
- [init](FilterDisplayBar.md#init)
- [initialize](FilterDisplayBar.md#initialize)
- [renderContents](FilterDisplayBar.md#rendercontents)
- [set\_store](FilterDisplayBar.md#set_store)
- [useIdPrefix](FilterDisplayBar.md#useidprefix)
- [create](FilterDisplayBar.md#create)
- [elementFor](FilterDisplayBar.md#elementfor)
- [getWidgetName](FilterDisplayBar.md#getwidgetname)

## Constructors

### constructor

• **new FilterDisplayBar**(`div`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `div` | `JQuery` |

#### Overrides

[FilterWidgetBase](FilterWidgetBase.md).[constructor](FilterWidgetBase.md#constructor)

#### Defined in

[src/ui/filtering/filterdisplaybar.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdisplaybar.ts#L9)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[element](FilterWidgetBase.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[idPrefix](FilterWidgetBase.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### options

• `Protected` **options**: `any`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[options](FilterWidgetBase.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[uniqueName](FilterWidgetBase.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[widgetName](FilterWidgetBase.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[addCssClass](FilterWidgetBase.md#addcssclass)

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

[FilterWidgetBase](FilterWidgetBase.md).[addValidationRule](FilterWidgetBase.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

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

[FilterWidgetBase](FilterWidgetBase.md).[byId](FilterWidgetBase.md#byid)

#### Defined in

[src/ui/widgets/templatedwidget.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L10)

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

[FilterWidgetBase](FilterWidgetBase.md).[change](FilterWidgetBase.md#change)

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

[FilterWidgetBase](FilterWidgetBase.md).[change](FilterWidgetBase.md#change)

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

[FilterWidgetBase](FilterWidgetBase.md).[changeSelect2](FilterWidgetBase.md#changeselect2)

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

[FilterWidgetBase](FilterWidgetBase.md).[changeSelect2](FilterWidgetBase.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[destroy](FilterWidgetBase.md#destroy)

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L19)

___

### filterStoreChanged

▸ `Protected` **filterStoreChanged**(): `void`

#### Returns

`void`

#### Overrides

[FilterWidgetBase](FilterWidgetBase.md).[filterStoreChanged](FilterWidgetBase.md#filterstorechanged)

#### Defined in

[src/ui/filtering/filterdisplaybar.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdisplaybar.ts#L38)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[getCssClass](FilterWidgetBase.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getFallbackTemplate

▸ `Protected` **getFallbackTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[getFallbackTemplate](FilterWidgetBase.md#getfallbacktemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L79)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[getGridField](FilterWidgetBase.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getTemplate

▸ `Protected` **getTemplate**(): `string`

#### Returns

`string`

#### Overrides

[FilterWidgetBase](FilterWidgetBase.md).[getTemplate](FilterWidgetBase.md#gettemplate)

#### Defined in

[src/ui/filtering/filterdisplaybar.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdisplaybar.ts#L52)

___

### getTemplateName

▸ `Protected` **getTemplateName**(): `string`

#### Returns

`string`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[getTemplateName](FilterWidgetBase.md#gettemplatename)

#### Defined in

[src/ui/widgets/templatedwidget.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L31)

___

### get\_store

▸ **get_store**(): [`FilterStore`](FilterStore.md)

#### Returns

[`FilterStore`](FilterStore.md)

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[get_store](FilterWidgetBase.md#get_store)

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L33)

___

### init

▸ **init**(`action?`): [`FilterDisplayBar`](FilterDisplayBar.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`FilterDisplayBar`](FilterDisplayBar.md)

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[init](FilterWidgetBase.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[initialize](FilterWidgetBase.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[renderContents](FilterWidgetBase.md#rendercontents)

#### Defined in

[src/ui/widgets/templatedwidget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L110)

___

### set\_store

▸ **set_store**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`FilterStore`](FilterStore.md) |

#### Returns

`void`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[set_store](FilterWidgetBase.md#set_store)

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L37)

___

### useIdPrefix

▸ `Protected` **useIdPrefix**(): `IdPrefixType`

#### Returns

`IdPrefixType`

#### Inherited from

[FilterWidgetBase](FilterWidgetBase.md).[useIdPrefix](FilterWidgetBase.md#useidprefix)

#### Defined in

[src/ui/widgets/templatedwidget.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L131)

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

[FilterWidgetBase](FilterWidgetBase.md).[create](FilterWidgetBase.md#create)

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

[FilterWidgetBase](FilterWidgetBase.md).[elementFor](FilterWidgetBase.md#elementfor)

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

[FilterWidgetBase](FilterWidgetBase.md).[getWidgetName](FilterWidgetBase.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
