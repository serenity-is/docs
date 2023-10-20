[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / Select2AjaxEditor

# Class: Select2AjaxEditor<TOptions, TItem\>

## Type parameters

| Name |
| :------ |
| `TOptions` |
| `TItem` |

## Hierarchy

- [`Widget`](Widget.md)<`TOptions`\>

  ↳ **`Select2AjaxEditor`**

## Implements

- [`IStringValue`](IStringValue.md)

## Table of contents

### Constructors

- [constructor](Select2AjaxEditor.md#constructor)

### Properties

- [element](Select2AjaxEditor.md#element)
- [idPrefix](Select2AjaxEditor.md#idprefix)
- [options](Select2AjaxEditor.md#options)
- [pageSize](Select2AjaxEditor.md#pagesize)
- [uniqueName](Select2AjaxEditor.md#uniquename)
- [widgetName](Select2AjaxEditor.md#widgetname)

### Accessors

- [value](Select2AjaxEditor.md#value)

### Methods

- [addCssClass](Select2AjaxEditor.md#addcssclass)
- [addInplaceCreate](Select2AjaxEditor.md#addinplacecreate)
- [addValidationRule](Select2AjaxEditor.md#addvalidationrule)
- [change](Select2AjaxEditor.md#change)
- [changeSelect2](Select2AjaxEditor.md#changeselect2)
- [destroy](Select2AjaxEditor.md#destroy)
- [emptyItemText](Select2AjaxEditor.md#emptyitemtext)
- [executeQuery](Select2AjaxEditor.md#executequery)
- [executeQueryByKey](Select2AjaxEditor.md#executequerybykey)
- [getCssClass](Select2AjaxEditor.md#getcssclass)
- [getGridField](Select2AjaxEditor.md#getgridfield)
- [getItemKey](Select2AjaxEditor.md#getitemkey)
- [getItemText](Select2AjaxEditor.md#getitemtext)
- [getSelect2Options](Select2AjaxEditor.md#getselect2options)
- [getService](Select2AjaxEditor.md#getservice)
- [getTypeDelay](Select2AjaxEditor.md#gettypedelay)
- [get\_select2Container](Select2AjaxEditor.md#get_select2container)
- [get\_value](Select2AjaxEditor.md#get_value)
- [init](Select2AjaxEditor.md#init)
- [initialize](Select2AjaxEditor.md#initialize)
- [inplaceCreateClick](Select2AjaxEditor.md#inplacecreateclick)
- [query](Select2AjaxEditor.md#query)
- [queryByKey](Select2AjaxEditor.md#querybykey)
- [renderContents](Select2AjaxEditor.md#rendercontents)
- [set\_value](Select2AjaxEditor.md#set_value)
- [create](Select2AjaxEditor.md#create)
- [elementFor](Select2AjaxEditor.md#elementfor)
- [getWidgetName](Select2AjaxEditor.md#getwidgetname)

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

[Widget](Widget.md).[constructor](Widget.md#constructor)

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#L13)

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

### options

• `Protected` **options**: `TOptions`

#### Inherited from

[Widget](Widget.md).[options](Widget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### pageSize

• **pageSize**: `number` = `50`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#L11)

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

## Accessors

### value

• `get` **value**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#L159)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#L177)

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

### addInplaceCreate

▸ `Protected` **addInplaceCreate**(`title`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `title` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#L137)

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

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[Widget](Widget.md).[destroy](Widget.md#destroy)

#### Defined in

[src/ui/widgets/widget.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L92)

___

### emptyItemText

▸ `Protected` **emptyItemText**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#L32)

___

### executeQuery

▸ `Protected` **executeQuery**(`options`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`ServiceOptions`](../interfaces/ServiceOptions.md)<[`ListResponse`](../interfaces/ListResponse.md)<`any`\>\> |

#### Returns

`void`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#L56)

___

### executeQueryByKey

▸ `Protected` **executeQueryByKey**(`options`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`ServiceOptions`](../interfaces/ServiceOptions.md)<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)<`any`\>\> |

#### Returns

`void`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#L72)

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

### getItemKey

▸ `Protected` **getItemKey**(`item`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `any` |

#### Returns

`string`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#L76)

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

[src/ui/editors/select2ajaxeditor.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#L80)

___

### getSelect2Options

▸ `Protected` **getSelect2Options**(): `Select2Options`

#### Returns

`Select2Options`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#L88)

___

### getService

▸ `Protected` **getService**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#L40)

___

### getTypeDelay

▸ `Protected` **getTypeDelay**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#L84)

___

### get\_select2Container

▸ `Protected` **get_select2Container**(): `JQuery`

#### Returns

`JQuery`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#L151)

___

### get\_value

▸ **get_value**(): `string`

#### Returns

`string`

#### Implementation of

[IStringValue](IStringValue.md).[get_value](IStringValue.md#get_value)

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#L155)

___

### init

▸ **init**(`action?`): [`Select2AjaxEditor`](Select2AjaxEditor.md)<`TOptions`, `TItem`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`Select2AjaxEditor`](Select2AjaxEditor.md)<`TOptions`, `TItem`\>

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

### inplaceCreateClick

▸ `Protected` **inplaceCreateClick**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#L148)

___

### query

▸ `Protected` **query**(`request`, `callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `request` | [`ListRequest`](../interfaces/ListRequest.md) |
| `callback` | (`p1`: [`ListResponse`](../interfaces/ListResponse.md)<`any`\>) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#L44)

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

[src/ui/editors/select2ajaxeditor.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#L60)

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

### set\_value

▸ **set_value**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Implementation of

[IStringValue](IStringValue.md).[set_value](IStringValue.md#set_value)

#### Defined in

[src/ui/editors/select2ajaxeditor.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2ajaxeditor.ts#L163)

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
