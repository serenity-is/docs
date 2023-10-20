[@serenity-is/corelib](../README.md) / HtmlContentEditor

# Class: HtmlContentEditor

## Hierarchy

- [`Widget`](Widget.md)<[`HtmlContentEditorOptions`](../interfaces/HtmlContentEditorOptions.md)\>

  ↳ **`HtmlContentEditor`**

  ↳↳ [`HtmlNoteContentEditor`](HtmlNoteContentEditor.md)

  ↳↳ [`HtmlReportContentEditor`](HtmlReportContentEditor.md)

## Implements

- [`IStringValue`](IStringValue.md)
- [`IReadOnly`](IReadOnly.md)

## Table of contents

### Constructors

- [constructor](HtmlContentEditor.md#constructor)

### Properties

- [\_instanceReady](HtmlContentEditor.md#_instanceready)
- [element](HtmlContentEditor.md#element)
- [idPrefix](HtmlContentEditor.md#idprefix)
- [options](HtmlContentEditor.md#options)
- [uniqueName](HtmlContentEditor.md#uniquename)
- [widgetName](HtmlContentEditor.md#widgetname)
- [CKEditorBasePath](HtmlContentEditor.md#ckeditorbasepath)
- [CKEditorVer](HtmlContentEditor.md#ckeditorver)

### Accessors

- [value](HtmlContentEditor.md#value)

### Methods

- [addCssClass](HtmlContentEditor.md#addcssclass)
- [addValidationRule](HtmlContentEditor.md#addvalidationrule)
- [change](HtmlContentEditor.md#change)
- [changeSelect2](HtmlContentEditor.md#changeselect2)
- [destroy](HtmlContentEditor.md#destroy)
- [getConfig](HtmlContentEditor.md#getconfig)
- [getCssClass](HtmlContentEditor.md#getcssclass)
- [getEditorInstance](HtmlContentEditor.md#geteditorinstance)
- [getGridField](HtmlContentEditor.md#getgridfield)
- [getLanguage](HtmlContentEditor.md#getlanguage)
- [get\_readOnly](HtmlContentEditor.md#get_readonly)
- [get\_value](HtmlContentEditor.md#get_value)
- [init](HtmlContentEditor.md#init)
- [initialize](HtmlContentEditor.md#initialize)
- [instanceReady](HtmlContentEditor.md#instanceready)
- [renderContents](HtmlContentEditor.md#rendercontents)
- [set\_readOnly](HtmlContentEditor.md#set_readonly)
- [set\_value](HtmlContentEditor.md#set_value)
- [create](HtmlContentEditor.md#create)
- [elementFor](HtmlContentEditor.md#elementfor)
- [getCKEditorBasePath](HtmlContentEditor.md#getckeditorbasepath)
- [getWidgetName](HtmlContentEditor.md#getwidgetname)
- [includeCKEditor](HtmlContentEditor.md#includeckeditor)

## Constructors

### constructor

• **new HtmlContentEditor**(`textArea`, `opt?`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `textArea` | `JQuery` |
| `opt?` | [`HtmlContentEditorOptions`](../interfaces/HtmlContentEditorOptions.md) |

#### Overrides

[Widget](Widget.md).[constructor](Widget.md#constructor)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L22)

## Properties

### \_instanceReady

• `Private` **\_instanceReady**: `boolean`

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L20)

___

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

• `Protected` **options**: [`HtmlContentEditorOptions`](../interfaces/HtmlContentEditorOptions.md)

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

___

### CKEditorBasePath

▪ `Static` **CKEditorBasePath**: `string`

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L191)

___

### CKEditorVer

▪ `Static` **CKEditorVer**: `string` = `"4.7.1"`

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L190)

## Accessors

### value

• `get` **value**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L155)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L166)

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

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[Widget](Widget.md).[destroy](Widget.md#destroy)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L139)

___

### getConfig

▸ `Protected` **getConfig**(): [`CKEditorConfig`](../interfaces/CKEditorConfig.md)

#### Returns

[`CKEditorConfig`](../interfaces/CKEditorConfig.md)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L85)

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

### getEditorInstance

▸ `Protected` **getEditorInstance**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L134)

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

### getLanguage

▸ `Protected` **getLanguage**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L66)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IReadOnly](IReadOnly.md).[get_readOnly](IReadOnly.md#get_readonly)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L170)

___

### get\_value

▸ **get_value**(): `string`

#### Returns

`string`

#### Implementation of

[IStringValue](IStringValue.md).[get_value](IStringValue.md#get_value)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L145)

___

### init

▸ **init**(`action?`): [`HtmlContentEditor`](HtmlContentEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`HtmlContentEditor`](HtmlContentEditor.md)

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

### instanceReady

▸ `Protected` **instanceReady**(`x`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `x` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L56)

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

### set\_readOnly

▸ **set_readOnly**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Implementation of

[IReadOnly](IReadOnly.md).[set_readOnly](IReadOnly.md#set_readonly)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L174)

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

[src/ui/editors/htmlcontenteditor.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L159)

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

### getCKEditorBasePath

▸ `Static` **getCKEditorBasePath**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L193)

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

___

### includeCKEditor

▸ `Static` **includeCKEditor**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:208](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L208)
