[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / QuickFilterBar

# Class: QuickFilterBar

[corelib](../modules/corelib.md).QuickFilterBar

## Hierarchy

- [`Widget`](corelib.Widget.md)<[`QuickFilterBarOptions`](../interfaces/corelib.QuickFilterBarOptions.md)\>

  ↳ **`QuickFilterBar`**

## Table of contents

### Constructors

- [constructor](corelib.QuickFilterBar.md#constructor)

### Properties

- [element](corelib.QuickFilterBar.md#element)
- [idPrefix](corelib.QuickFilterBar.md#idprefix)
- [onChange](corelib.QuickFilterBar.md#onchange)
- [options](corelib.QuickFilterBar.md#options)
- [submitHandlers](corelib.QuickFilterBar.md#submithandlers)
- [uniqueName](corelib.QuickFilterBar.md#uniquename)
- [widgetName](corelib.QuickFilterBar.md#widgetname)

### Methods

- [add](corelib.QuickFilterBar.md#add)
- [addBoolean](corelib.QuickFilterBar.md#addboolean)
- [addCssClass](corelib.QuickFilterBar.md#addcssclass)
- [addDateRange](corelib.QuickFilterBar.md#adddaterange)
- [addDateTimeRange](corelib.QuickFilterBar.md#adddatetimerange)
- [addSeparator](corelib.QuickFilterBar.md#addseparator)
- [addValidationRule](corelib.QuickFilterBar.md#addvalidationrule)
- [add\_submitHandlers](corelib.QuickFilterBar.md#add_submithandlers)
- [change](corelib.QuickFilterBar.md#change)
- [changeSelect2](corelib.QuickFilterBar.md#changeselect2)
- [clear\_submitHandlers](corelib.QuickFilterBar.md#clear_submithandlers)
- [destroy](corelib.QuickFilterBar.md#destroy)
- [find](corelib.QuickFilterBar.md#find)
- [getCssClass](corelib.QuickFilterBar.md#getcssclass)
- [getGridField](corelib.QuickFilterBar.md#getgridfield)
- [init](corelib.QuickFilterBar.md#init)
- [initialize](corelib.QuickFilterBar.md#initialize)
- [onSubmit](corelib.QuickFilterBar.md#onsubmit)
- [remove\_submitHandlers](corelib.QuickFilterBar.md#remove_submithandlers)
- [renderContents](corelib.QuickFilterBar.md#rendercontents)
- [tryFind](corelib.QuickFilterBar.md#tryfind)
- [boolean](corelib.QuickFilterBar.md#boolean)
- [create](corelib.QuickFilterBar.md#create)
- [dateRange](corelib.QuickFilterBar.md#daterange)
- [dateTimeRange](corelib.QuickFilterBar.md#datetimerange)
- [elementFor](corelib.QuickFilterBar.md#elementfor)
- [getWidgetName](corelib.QuickFilterBar.md#getwidgetname)

## Constructors

### constructor

• **new QuickFilterBar**(`container`, `options?`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `container` | `JQuery` |
| `options?` | [`QuickFilterBarOptions`](../interfaces/corelib.QuickFilterBarOptions.md) |

#### Overrides

[Widget](corelib.Widget.md).[constructor](corelib.Widget.md#constructor)

#### Defined in

[src/ui/datagrid/quickfilterbar.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.ts#L20)

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

### onChange

• **onChange**: (`e`: `JQueryEventObject`) => `void`

#### Type declaration

▸ (`e`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `JQueryEventObject` |

##### Returns

`void`

#### Defined in

[src/ui/datagrid/quickfilterbar.ts:355](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.ts#L355)

___

### options

• `Protected` **options**: [`QuickFilterBarOptions`](../interfaces/corelib.QuickFilterBarOptions.md)

#### Inherited from

[Widget](corelib.Widget.md).[options](corelib.Widget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### submitHandlers

• `Private` **submitHandlers**: `any`

#### Defined in

[src/ui/datagrid/quickfilterbar.ts:357](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.ts#L357)

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

### add

▸ **add**<`TWidget`, `TOptions`\>(`opt`): `TWidget`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](corelib.Widget.md)<`any`, `TWidget`\> |
| `TOptions` | `TOptions` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `opt` | [`QuickFilter`](../interfaces/corelib.QuickFilter.md)<`TWidget`, `TOptions`\> |

#### Returns

`TWidget`

#### Defined in

[src/ui/datagrid/quickfilterbar.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.ts#L38)

___

### addBoolean

▸ **addBoolean**(`field`, `title?`, `yes?`, `no?`): [`SelectEditor`](corelib.SelectEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |
| `yes?` | `string` |
| `no?` | `string` |

#### Returns

[`SelectEditor`](corelib.SelectEditor.md)

#### Defined in

[src/ui/datagrid/quickfilterbar.ts:320](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.ts#L320)

___

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[addCssClass](corelib.Widget.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### addDateRange

▸ **addDateRange**(`field`, `title?`): [`DateEditor`](corelib.DateEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |

#### Returns

[`DateEditor`](corelib.DateEditor.md)

#### Defined in

[src/ui/datagrid/quickfilterbar.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.ts#L138)

___

### addDateTimeRange

▸ **addDateTimeRange**(`field`, `title?`): [`DateTimeEditor`](corelib.DateTimeEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |

#### Returns

[`DateTimeEditor`](corelib.DateTimeEditor.md)

#### Defined in

[src/ui/datagrid/quickfilterbar.ts:227](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.ts#L227)

___

### addSeparator

▸ **addSeparator**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/quickfilterbar.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.ts#L34)

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

### add\_submitHandlers

▸ `Protected` **add_submitHandlers**(`action`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `action` | (`request`: [`ListRequest`](../interfaces/corelib_q.ListRequest.md)) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/quickfilterbar.ts:368](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.ts#L368)

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

### clear\_submitHandlers

▸ `Protected` **clear_submitHandlers**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/quickfilterbar.ts:376](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.ts#L376)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[Widget](corelib.Widget.md).[destroy](corelib.Widget.md#destroy)

#### Defined in

[src/ui/datagrid/quickfilterbar.ts:359](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.ts#L359)

___

### find

▸ **find**<`TWidget`\>(`type`, `field`): `TWidget`

#### Type parameters

| Name |
| :------ |
| `TWidget` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | (...`args`: `any`[]) => `TWidget` |
| `field` | `string` |

#### Returns

`TWidget`

#### Defined in

[src/ui/datagrid/quickfilterbar.ts:379](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.ts#L379)

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

▸ **init**(`action?`): [`QuickFilterBar`](corelib.QuickFilterBar.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`QuickFilterBar`](corelib.QuickFilterBar.md)

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

### onSubmit

▸ **onSubmit**(`request`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `request` | [`ListRequest`](../interfaces/corelib_q.ListRequest.md) |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/quickfilterbar.ts:364](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.ts#L364)

___

### remove\_submitHandlers

▸ `Protected` **remove_submitHandlers**(`action`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `action` | (`request`: [`ListRequest`](../interfaces/corelib_q.ListRequest.md)) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/datagrid/quickfilterbar.ts:372](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.ts#L372)

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

### tryFind

▸ **tryFind**<`TWidget`\>(`type`, `field`): `TWidget`

#### Type parameters

| Name |
| :------ |
| `TWidget` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | (...`args`: `any`[]) => `TWidget` |
| `field` | `string` |

#### Returns

`TWidget`

#### Defined in

[src/ui/datagrid/quickfilterbar.ts:383](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.ts#L383)

___

### boolean

▸ `Static` **boolean**(`field`, `title?`, `yes?`, `no?`): [`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`SelectEditor`](corelib.SelectEditor.md), [`SelectEditorOptions`](../interfaces/corelib.SelectEditorOptions.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |
| `yes?` | `string` |
| `no?` | `string` |

#### Returns

[`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`SelectEditor`](corelib.SelectEditor.md), [`SelectEditorOptions`](../interfaces/corelib.SelectEditorOptions.md)\>

#### Defined in

[src/ui/datagrid/quickfilterbar.ts:324](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.ts#L324)

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

### dateRange

▸ `Static` **dateRange**(`field`, `title?`): [`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`DateEditor`](corelib.DateEditor.md), [`DateTimeEditorOptions`](../interfaces/corelib.DateTimeEditorOptions.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |

#### Returns

[`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`DateEditor`](corelib.DateEditor.md), [`DateTimeEditorOptions`](../interfaces/corelib.DateTimeEditorOptions.md)\>

#### Defined in

[src/ui/datagrid/quickfilterbar.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.ts#L142)

___

### dateTimeRange

▸ `Static` **dateTimeRange**(`field`, `title?`, `useUtc?`): [`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`DateTimeEditor`](corelib.DateTimeEditor.md), [`DateTimeEditorOptions`](../interfaces/corelib.DateTimeEditorOptions.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `field` | `string` |
| `title?` | `string` |
| `useUtc?` | `boolean` |

#### Returns

[`QuickFilter`](../interfaces/corelib.QuickFilter.md)<[`DateTimeEditor`](corelib.DateTimeEditor.md), [`DateTimeEditorOptions`](../interfaces/corelib.DateTimeEditorOptions.md)\>

#### Defined in

[src/ui/datagrid/quickfilterbar.ts:231](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.ts#L231)

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
