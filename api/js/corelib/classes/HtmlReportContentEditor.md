[@serenity-is/corelib](../README.md) / HtmlReportContentEditor

# Class: HtmlReportContentEditor

## Hierarchy

- [`HtmlContentEditor`](HtmlContentEditor.md)

  ↳ **`HtmlReportContentEditor`**

## Table of contents

### Constructors

- [constructor](HtmlReportContentEditor.md#constructor)

### Properties

- [element](HtmlReportContentEditor.md#element)
- [idPrefix](HtmlReportContentEditor.md#idprefix)
- [options](HtmlReportContentEditor.md#options)
- [uniqueName](HtmlReportContentEditor.md#uniquename)
- [widgetName](HtmlReportContentEditor.md#widgetname)
- [CKEditorBasePath](HtmlReportContentEditor.md#ckeditorbasepath)
- [CKEditorVer](HtmlReportContentEditor.md#ckeditorver)

### Accessors

- [value](HtmlReportContentEditor.md#value)

### Methods

- [addCssClass](HtmlReportContentEditor.md#addcssclass)
- [addValidationRule](HtmlReportContentEditor.md#addvalidationrule)
- [change](HtmlReportContentEditor.md#change)
- [changeSelect2](HtmlReportContentEditor.md#changeselect2)
- [destroy](HtmlReportContentEditor.md#destroy)
- [getConfig](HtmlReportContentEditor.md#getconfig)
- [getCssClass](HtmlReportContentEditor.md#getcssclass)
- [getEditorInstance](HtmlReportContentEditor.md#geteditorinstance)
- [getGridField](HtmlReportContentEditor.md#getgridfield)
- [getLanguage](HtmlReportContentEditor.md#getlanguage)
- [get\_readOnly](HtmlReportContentEditor.md#get_readonly)
- [get\_value](HtmlReportContentEditor.md#get_value)
- [init](HtmlReportContentEditor.md#init)
- [initialize](HtmlReportContentEditor.md#initialize)
- [instanceReady](HtmlReportContentEditor.md#instanceready)
- [renderContents](HtmlReportContentEditor.md#rendercontents)
- [set\_readOnly](HtmlReportContentEditor.md#set_readonly)
- [set\_value](HtmlReportContentEditor.md#set_value)
- [create](HtmlReportContentEditor.md#create)
- [elementFor](HtmlReportContentEditor.md#elementfor)
- [getCKEditorBasePath](HtmlReportContentEditor.md#getckeditorbasepath)
- [getWidgetName](HtmlReportContentEditor.md#getwidgetname)
- [includeCKEditor](HtmlReportContentEditor.md#includeckeditor)

## Constructors

### constructor

• **new HtmlReportContentEditor**(`textArea`, `opt?`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `textArea` | `JQuery` |
| `opt?` | [`HtmlContentEditorOptions`](../interfaces/HtmlContentEditorOptions.md) |

#### Overrides

[HtmlContentEditor](HtmlContentEditor.md).[constructor](HtmlContentEditor.md#constructor)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:248](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L248)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[element](HtmlContentEditor.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[idPrefix](HtmlContentEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### options

• `Protected` **options**: [`HtmlContentEditorOptions`](../interfaces/HtmlContentEditorOptions.md)

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[options](HtmlContentEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[uniqueName](HtmlContentEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[widgetName](HtmlContentEditor.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

___

### CKEditorBasePath

▪ `Static` **CKEditorBasePath**: `string`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[CKEditorBasePath](HtmlContentEditor.md#ckeditorbasepath)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L191)

___

### CKEditorVer

▪ `Static` **CKEditorVer**: `string` = `"4.7.1"`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[CKEditorVer](HtmlContentEditor.md#ckeditorver)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L190)

## Accessors

### value

• `get` **value**(): `string`

#### Returns

`string`

#### Inherited from

HtmlContentEditor.value

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L155)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | `string` |

#### Returns

`void`

#### Inherited from

HtmlContentEditor.value

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L166)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[addCssClass](HtmlContentEditor.md#addcssclass)

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

[HtmlContentEditor](HtmlContentEditor.md).[addValidationRule](HtmlContentEditor.md#addvalidationrule)

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

[HtmlContentEditor](HtmlContentEditor.md).[change](HtmlContentEditor.md#change)

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

[HtmlContentEditor](HtmlContentEditor.md).[change](HtmlContentEditor.md#change)

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

[HtmlContentEditor](HtmlContentEditor.md).[changeSelect2](HtmlContentEditor.md#changeselect2)

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

[HtmlContentEditor](HtmlContentEditor.md).[changeSelect2](HtmlContentEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[destroy](HtmlContentEditor.md#destroy)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L139)

___

### getConfig

▸ `Protected` **getConfig**(): [`CKEditorConfig`](../interfaces/CKEditorConfig.md)

#### Returns

[`CKEditorConfig`](../interfaces/CKEditorConfig.md)

#### Overrides

[HtmlContentEditor](HtmlContentEditor.md).[getConfig](HtmlContentEditor.md#getconfig)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:252](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L252)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[getCssClass](HtmlContentEditor.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getEditorInstance

▸ `Protected` **getEditorInstance**(): `any`

#### Returns

`any`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[getEditorInstance](HtmlContentEditor.md#geteditorinstance)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L134)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[getGridField](HtmlContentEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getLanguage

▸ `Protected` **getLanguage**(): `string`

#### Returns

`string`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[getLanguage](HtmlContentEditor.md#getlanguage)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L66)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[get_readOnly](HtmlContentEditor.md#get_readonly)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L170)

___

### get\_value

▸ **get_value**(): `string`

#### Returns

`string`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[get_value](HtmlContentEditor.md#get_value)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L145)

___

### init

▸ **init**(`action?`): [`HtmlReportContentEditor`](HtmlReportContentEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`HtmlReportContentEditor`](HtmlReportContentEditor.md)

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[init](HtmlContentEditor.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[initialize](HtmlContentEditor.md#initialize)

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

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[instanceReady](HtmlContentEditor.md#instanceready)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L56)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[renderContents](HtmlContentEditor.md#rendercontents)

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

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[set_readOnly](HtmlContentEditor.md#set_readonly)

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

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[set_value](HtmlContentEditor.md#set_value)

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

[HtmlContentEditor](HtmlContentEditor.md).[create](HtmlContentEditor.md#create)

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

[HtmlContentEditor](HtmlContentEditor.md).[elementFor](HtmlContentEditor.md#elementfor)

#### Defined in

[src/ui/widgets/widget.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L128)

___

### getCKEditorBasePath

▸ `Static` **getCKEditorBasePath**(): `string`

#### Returns

`string`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[getCKEditorBasePath](HtmlContentEditor.md#getckeditorbasepath)

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

[HtmlContentEditor](HtmlContentEditor.md).[getWidgetName](HtmlContentEditor.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)

___

### includeCKEditor

▸ `Static` **includeCKEditor**(): `void`

#### Returns

`void`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[includeCKEditor](HtmlContentEditor.md#includeckeditor)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:208](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L208)
