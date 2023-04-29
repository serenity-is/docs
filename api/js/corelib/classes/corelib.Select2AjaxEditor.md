[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / Select2AjaxEditor

# Class: Select2AjaxEditor<TOptions, TItem\>

[corelib](../modules/corelib.md).Select2AjaxEditor

## Type parameters

| Name |
| :------ |
| `TOptions` |
| `TItem` |

## Hierarchy

- [`Widget`](corelib.Widget.md)<`TOptions`\>

  ↳ **`Select2AjaxEditor`**

## Implements

- [`IStringValue`](corelib.IStringValue.md)

## Table of contents

### Constructors

- [constructor](corelib.Select2AjaxEditor.md#constructor)

### Properties

- [element](corelib.Select2AjaxEditor.md#element)
- [idPrefix](corelib.Select2AjaxEditor.md#idprefix)
- [options](corelib.Select2AjaxEditor.md#options)
- [pageSize](corelib.Select2AjaxEditor.md#pagesize)
- [uniqueName](corelib.Select2AjaxEditor.md#uniquename)
- [widgetName](corelib.Select2AjaxEditor.md#widgetname)

### Accessors

- [value](corelib.Select2AjaxEditor.md#value)

### Methods

- [addCssClass](corelib.Select2AjaxEditor.md#addcssclass)
- [addInplaceCreate](corelib.Select2AjaxEditor.md#addinplacecreate)
- [addValidationRule](corelib.Select2AjaxEditor.md#addvalidationrule)
- [change](corelib.Select2AjaxEditor.md#change)
- [changeSelect2](corelib.Select2AjaxEditor.md#changeselect2)
- [destroy](corelib.Select2AjaxEditor.md#destroy)
- [emptyItemText](corelib.Select2AjaxEditor.md#emptyitemtext)
- [executeQuery](corelib.Select2AjaxEditor.md#executequery)
- [executeQueryByKey](corelib.Select2AjaxEditor.md#executequerybykey)
- [getCssClass](corelib.Select2AjaxEditor.md#getcssclass)
- [getGridField](corelib.Select2AjaxEditor.md#getgridfield)
- [getItemKey](corelib.Select2AjaxEditor.md#getitemkey)
- [getItemText](corelib.Select2AjaxEditor.md#getitemtext)
- [getSelect2Options](corelib.Select2AjaxEditor.md#getselect2options)
- [getService](corelib.Select2AjaxEditor.md#getservice)
- [getTypeDelay](corelib.Select2AjaxEditor.md#gettypedelay)
- [get\_select2Container](corelib.Select2AjaxEditor.md#get_select2container)
- [get\_value](corelib.Select2AjaxEditor.md#get_value)
- [init](corelib.Select2AjaxEditor.md#init)
- [initialize](corelib.Select2AjaxEditor.md#initialize)
- [inplaceCreateClick](corelib.Select2AjaxEditor.md#inplacecreateclick)
- [query](corelib.Select2AjaxEditor.md#query)
- [queryByKey](corelib.Select2AjaxEditor.md#querybykey)
- [renderContents](corelib.Select2AjaxEditor.md#rendercontents)
- [set\_value](corelib.Select2AjaxEditor.md#set_value)
- [create](corelib.Select2AjaxEditor.md#create)
- [elementFor](corelib.Select2AjaxEditor.md#elementfor)
- [getWidgetName](corelib.Select2AjaxEditor.md#getwidgetname)

## Constructors

### constructor

• **new Select2AjaxEditor**<`TOptions`, `TItem`\>(`hidden`, `opt`)

#### Type parameters

| Name |
| :------ |
| `TOptions` |
| `TItem` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `hidden` | `JQuery` |
| `opt` | `TOptions` |

#### Overrides

[Widget](corelib.Widget.md).[constructor](corelib.Widget.md#constructor)

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#line&#x3D;13)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[Widget](corelib.Widget.md).[element](corelib.Widget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[idPrefix](corelib.Widget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;65)

___

### options

• `Protected` **options**: `TOptions`

#### Inherited from

[Widget](corelib.Widget.md).[options](corelib.Widget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;62)

___

### pageSize

• **pageSize**: `number` = `50`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#line&#x3D;11)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[uniqueName](corelib.Widget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[Widget](corelib.Widget.md).[widgetName](corelib.Widget.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;63)

## Accessors

### value

• `get` **value**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#line&#x3D;159)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#line&#x3D;177)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[addCssClass](corelib.Widget.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;100)

___

### addInplaceCreate

▸ `Protected` **addInplaceCreate**(`title`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `title` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#line&#x3D;137)

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

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;134)

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

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;142)

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

[Widget](corelib.Widget.md).[changeSelect2](corelib.Widget.md#changeselect2)

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

[Widget](corelib.Widget.md).[changeSelect2](corelib.Widget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[destroy](corelib.Widget.md#destroy)

#### Defined in

[src/ui/widgets/widget.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;92)

___

### emptyItemText

▸ `Protected` **emptyItemText**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#line&#x3D;32)

___

### executeQuery

▸ `Protected` **executeQuery**(`options`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`ServiceOptions`](../interfaces/corelib_q.ServiceOptions.md)<[`ListResponse`](../interfaces/corelib_q.ListResponse.md)<`any`\>\> |

#### Returns

`void`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#line&#x3D;56)

___

### executeQueryByKey

▸ `Protected` **executeQueryByKey**(`options`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`ServiceOptions`](../interfaces/corelib_q.ServiceOptions.md)<[`RetrieveResponse`](../interfaces/corelib_q.RetrieveResponse.md)<`any`\>\> |

#### Returns

`void`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#line&#x3D;72)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[Widget](corelib.Widget.md).[getCssClass](corelib.Widget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;104)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[Widget](corelib.Widget.md).[getGridField](corelib.Widget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;138)

___

### getItemKey

▸ `Protected` **getItemKey**(`item`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `any` |

#### Returns

`string`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#line&#x3D;76)

___

### getItemText

▸ `Protected` **getItemText**(`item`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `any` |

#### Returns

`string`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#line&#x3D;80)

___

### getSelect2Options

▸ `Protected` **getSelect2Options**(): `Select2Options`

#### Returns

`Select2Options`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#line&#x3D;88)

___

### getService

▸ `Protected` **getService**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#line&#x3D;40)

___

### getTypeDelay

▸ `Protected` **getTypeDelay**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#line&#x3D;84)

___

### get\_select2Container

▸ `Protected` **get_select2Container**(): `JQuery`

#### Returns

`JQuery`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#line&#x3D;151)

___

### get\_value

▸ **get_value**(): `string`

#### Returns

`string`

#### Implementation of

[IStringValue](corelib.IStringValue.md).[get_value](corelib.IStringValue.md#get_value)

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#line&#x3D;155)

___

### init

▸ **init**(`action?`): [`Select2AjaxEditor`](corelib.Select2AjaxEditor.md)<`TOptions`, `TItem`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`Select2AjaxEditor`](corelib.Select2AjaxEditor.md)<`TOptions`, `TItem`\>

#### Inherited from

[Widget](corelib.Widget.md).[init](corelib.Widget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[initialize](corelib.Widget.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;176)

___

### inplaceCreateClick

▸ `Protected` **inplaceCreateClick**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#line&#x3D;148)

___

### query

▸ `Protected` **query**(`request`, `callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `request` | [`ListRequest`](../interfaces/corelib_q.ListRequest.md) |
| `callback` | (`p1`: [`ListResponse`](../interfaces/corelib_q.ListResponse.md)<`any`\>) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#line&#x3D;44)

___

### queryByKey

▸ `Protected` **queryByKey**(`key`, `callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |
| `callback` | (`p1`: `any`) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#line&#x3D;60)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](corelib.Widget.md).[renderContents](corelib.Widget.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;184)

___

### set\_value

▸ **set_value**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Implementation of

[IStringValue](corelib.IStringValue.md).[set_value](corelib.IStringValue.md#set_value)

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#line&#x3D;163)

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

[Widget](corelib.Widget.md).[elementFor](corelib.Widget.md#elementfor)

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

[Widget](corelib.Widget.md).[getWidgetName](corelib.Widget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;124)
