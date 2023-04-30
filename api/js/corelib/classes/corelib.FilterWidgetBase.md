[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / FilterWidgetBase

# Class: FilterWidgetBase<TOptions\>

[corelib](../modules/corelib.md).FilterWidgetBase

## Type parameters

| Name |
| :------ |
| `TOptions` |

## Hierarchy

- [`TemplatedWidget`](corelib.TemplatedWidget.md)<`TOptions`\>

  ↳ **`FilterWidgetBase`**

  ↳↳ [`FilterPanel`](corelib.FilterPanel.md)

  ↳↳ [`FilterDisplayBar`](corelib.FilterDisplayBar.md)

## Table of contents

### Constructors

- [constructor](corelib.FilterWidgetBase.md#constructor)

### Properties

- [element](corelib.FilterWidgetBase.md#element)
- [idPrefix](corelib.FilterWidgetBase.md#idprefix)
- [onFilterStoreChanged](corelib.FilterWidgetBase.md#onfilterstorechanged)
- [options](corelib.FilterWidgetBase.md#options)
- [store](corelib.FilterWidgetBase.md#store)
- [uniqueName](corelib.FilterWidgetBase.md#uniquename)
- [widgetName](corelib.FilterWidgetBase.md#widgetname)

### Methods

- [addCssClass](corelib.FilterWidgetBase.md#addcssclass)
- [addValidationRule](corelib.FilterWidgetBase.md#addvalidationrule)
- [byId](corelib.FilterWidgetBase.md#byid)
- [change](corelib.FilterWidgetBase.md#change)
- [changeSelect2](corelib.FilterWidgetBase.md#changeselect2)
- [destroy](corelib.FilterWidgetBase.md#destroy)
- [filterStoreChanged](corelib.FilterWidgetBase.md#filterstorechanged)
- [getCssClass](corelib.FilterWidgetBase.md#getcssclass)
- [getFallbackTemplate](corelib.FilterWidgetBase.md#getfallbacktemplate)
- [getGridField](corelib.FilterWidgetBase.md#getgridfield)
- [getTemplate](corelib.FilterWidgetBase.md#gettemplate)
- [getTemplateName](corelib.FilterWidgetBase.md#gettemplatename)
- [get\_store](corelib.FilterWidgetBase.md#get_store)
- [init](corelib.FilterWidgetBase.md#init)
- [initialize](corelib.FilterWidgetBase.md#initialize)
- [renderContents](corelib.FilterWidgetBase.md#rendercontents)
- [set\_store](corelib.FilterWidgetBase.md#set_store)
- [useIdPrefix](corelib.FilterWidgetBase.md#useidprefix)
- [create](corelib.FilterWidgetBase.md#create)
- [elementFor](corelib.FilterWidgetBase.md#elementfor)
- [getWidgetName](corelib.FilterWidgetBase.md#getwidgetname)

## Constructors

### constructor

• **new FilterWidgetBase**<`TOptions`\>(`div`, `opt?`)

#### Type parameters

| Name |
| :------ |
| `TOptions` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `div` | `JQuery` |
| `opt?` | `TOptions` |

#### Overrides

[TemplatedWidget](corelib.TemplatedWidget.md).[constructor](corelib.TemplatedWidget.md#constructor)

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L11)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[element](corelib.TemplatedWidget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[idPrefix](corelib.TemplatedWidget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### onFilterStoreChanged

• `Private` **onFilterStoreChanged**: () => `void`

#### Type declaration

▸ (): `void`

##### Returns

`void`

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L9)

___

### options

• `Protected` **options**: `TOptions`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[options](corelib.TemplatedWidget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### store

• `Private` **store**: [`FilterStore`](corelib.FilterStore.md)

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L7)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[uniqueName](corelib.TemplatedWidget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[widgetName](corelib.TemplatedWidget.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[addCssClass](corelib.TemplatedWidget.md#addcssclass)

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

[TemplatedWidget](corelib.TemplatedWidget.md).[addValidationRule](corelib.TemplatedWidget.md#addvalidationrule)

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

[TemplatedWidget](corelib.TemplatedWidget.md).[byId](corelib.TemplatedWidget.md#byid-1)

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

[TemplatedWidget](corelib.TemplatedWidget.md).[change](corelib.TemplatedWidget.md#change)

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

[TemplatedWidget](corelib.TemplatedWidget.md).[change](corelib.TemplatedWidget.md#change)

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

[TemplatedWidget](corelib.TemplatedWidget.md).[changeSelect2](corelib.TemplatedWidget.md#changeselect2)

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

[TemplatedWidget](corelib.TemplatedWidget.md).[changeSelect2](corelib.TemplatedWidget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[TemplatedWidget](corelib.TemplatedWidget.md).[destroy](corelib.TemplatedWidget.md#destroy)

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L19)

___

### filterStoreChanged

▸ `Protected` **filterStoreChanged**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L30)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[getCssClass](corelib.TemplatedWidget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getFallbackTemplate

▸ `Protected` **getFallbackTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[getFallbackTemplate](corelib.TemplatedWidget.md#getfallbacktemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L79)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[getGridField](corelib.TemplatedWidget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getTemplate

▸ `Protected` **getTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[getTemplate](corelib.TemplatedWidget.md#gettemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L83)

___

### getTemplateName

▸ `Protected` **getTemplateName**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[getTemplateName](corelib.TemplatedWidget.md#gettemplatename)

#### Defined in

[src/ui/widgets/templatedwidget.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L31)

___

### get\_store

▸ **get_store**(): [`FilterStore`](corelib.FilterStore.md)

#### Returns

[`FilterStore`](corelib.FilterStore.md)

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L33)

___

### init

▸ **init**(`action?`): [`FilterWidgetBase`](corelib.FilterWidgetBase.md)<`TOptions`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`FilterWidgetBase`](corelib.FilterWidgetBase.md)<`TOptions`\>

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[init](corelib.TemplatedWidget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[initialize](corelib.TemplatedWidget.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[renderContents](corelib.TemplatedWidget.md#rendercontents)

#### Defined in

[src/ui/widgets/templatedwidget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L110)

___

### set\_store

▸ **set_store**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | [`FilterStore`](corelib.FilterStore.md) |

#### Returns

`void`

#### Defined in

[src/ui/filtering/filterwidgetbase.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L37)

___

### useIdPrefix

▸ `Protected` **useIdPrefix**(): `IdPrefixType`

#### Returns

`IdPrefixType`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[useIdPrefix](corelib.TemplatedWidget.md#useidprefix)

#### Defined in

[src/ui/widgets/templatedwidget.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L131)

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

[TemplatedWidget](corelib.TemplatedWidget.md).[create](corelib.TemplatedWidget.md#create)

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

[TemplatedWidget](corelib.TemplatedWidget.md).[elementFor](corelib.TemplatedWidget.md#elementfor)

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

[TemplatedWidget](corelib.TemplatedWidget.md).[getWidgetName](corelib.TemplatedWidget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)
