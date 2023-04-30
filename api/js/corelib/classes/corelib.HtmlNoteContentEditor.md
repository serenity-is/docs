[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / HtmlNoteContentEditor

# Class: HtmlNoteContentEditor

[corelib](../modules/corelib.md).HtmlNoteContentEditor

## Hierarchy

- [`HtmlContentEditor`](corelib.HtmlContentEditor.md)

  ↳ **`HtmlNoteContentEditor`**

## Table of contents

### Constructors

- [constructor](corelib.HtmlNoteContentEditor.md#constructor)

### Properties

- [element](corelib.HtmlNoteContentEditor.md#element)
- [idPrefix](corelib.HtmlNoteContentEditor.md#idprefix)
- [options](corelib.HtmlNoteContentEditor.md#options)
- [uniqueName](corelib.HtmlNoteContentEditor.md#uniquename)
- [widgetName](corelib.HtmlNoteContentEditor.md#widgetname)
- [CKEditorBasePath](corelib.HtmlNoteContentEditor.md#ckeditorbasepath)
- [CKEditorVer](corelib.HtmlNoteContentEditor.md#ckeditorver)

### Accessors

- [value](corelib.HtmlNoteContentEditor.md#value)

### Methods

- [addCssClass](corelib.HtmlNoteContentEditor.md#addcssclass)
- [addValidationRule](corelib.HtmlNoteContentEditor.md#addvalidationrule)
- [change](corelib.HtmlNoteContentEditor.md#change)
- [changeSelect2](corelib.HtmlNoteContentEditor.md#changeselect2)
- [destroy](corelib.HtmlNoteContentEditor.md#destroy)
- [getConfig](corelib.HtmlNoteContentEditor.md#getconfig)
- [getCssClass](corelib.HtmlNoteContentEditor.md#getcssclass)
- [getEditorInstance](corelib.HtmlNoteContentEditor.md#geteditorinstance)
- [getGridField](corelib.HtmlNoteContentEditor.md#getgridfield)
- [getLanguage](corelib.HtmlNoteContentEditor.md#getlanguage)
- [get\_readOnly](corelib.HtmlNoteContentEditor.md#get_readonly)
- [get\_value](corelib.HtmlNoteContentEditor.md#get_value)
- [init](corelib.HtmlNoteContentEditor.md#init)
- [initialize](corelib.HtmlNoteContentEditor.md#initialize)
- [instanceReady](corelib.HtmlNoteContentEditor.md#instanceready)
- [renderContents](corelib.HtmlNoteContentEditor.md#rendercontents)
- [set\_readOnly](corelib.HtmlNoteContentEditor.md#set_readonly)
- [set\_value](corelib.HtmlNoteContentEditor.md#set_value)
- [create](corelib.HtmlNoteContentEditor.md#create)
- [elementFor](corelib.HtmlNoteContentEditor.md#elementfor)
- [getCKEditorBasePath](corelib.HtmlNoteContentEditor.md#getckeditorbasepath)
- [getWidgetName](corelib.HtmlNoteContentEditor.md#getwidgetname)
- [includeCKEditor](corelib.HtmlNoteContentEditor.md#includeckeditor)

## Constructors

### constructor

• **new HtmlNoteContentEditor**(`textArea`, `opt?`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `textArea` | `JQuery` |
| `opt?` | [`HtmlContentEditorOptions`](../interfaces/corelib.HtmlContentEditorOptions.md) |

#### Overrides

[HtmlContentEditor](corelib.HtmlContentEditor.md).[constructor](corelib.HtmlContentEditor.md#constructor)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:228](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L228)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[HtmlContentEditor](corelib.HtmlContentEditor.md).[element](corelib.HtmlContentEditor.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[HtmlContentEditor](corelib.HtmlContentEditor.md).[idPrefix](corelib.HtmlContentEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### options

• `Protected` **options**: [`HtmlContentEditorOptions`](../interfaces/corelib.HtmlContentEditorOptions.md)

#### Inherited from

[HtmlContentEditor](corelib.HtmlContentEditor.md).[options](corelib.HtmlContentEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[HtmlContentEditor](corelib.HtmlContentEditor.md).[uniqueName](corelib.HtmlContentEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[HtmlContentEditor](corelib.HtmlContentEditor.md).[widgetName](corelib.HtmlContentEditor.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

___

### CKEditorBasePath

▪ `Static` **CKEditorBasePath**: `string`

#### Inherited from

[HtmlContentEditor](corelib.HtmlContentEditor.md).[CKEditorBasePath](corelib.HtmlContentEditor.md#ckeditorbasepath)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L191)

___

### CKEditorVer

▪ `Static` **CKEditorVer**: `string` = `"4.7.1"`

#### Inherited from

[HtmlContentEditor](corelib.HtmlContentEditor.md).[CKEditorVer](corelib.HtmlContentEditor.md#ckeditorver)

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

[HtmlContentEditor](corelib.HtmlContentEditor.md).[addCssClass](corelib.HtmlContentEditor.md#addcssclass)

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

[HtmlContentEditor](corelib.HtmlContentEditor.md).[addValidationRule](corelib.HtmlContentEditor.md#addvalidationrule)

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

[HtmlContentEditor](corelib.HtmlContentEditor.md).[change](corelib.HtmlContentEditor.md#change)

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

[HtmlContentEditor](corelib.HtmlContentEditor.md).[change](corelib.HtmlContentEditor.md#change)

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

[HtmlContentEditor](corelib.HtmlContentEditor.md).[changeSelect2](corelib.HtmlContentEditor.md#changeselect2)

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

[HtmlContentEditor](corelib.HtmlContentEditor.md).[changeSelect2](corelib.HtmlContentEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[HtmlContentEditor](corelib.HtmlContentEditor.md).[destroy](corelib.HtmlContentEditor.md#destroy)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L139)

___

### getConfig

▸ `Protected` **getConfig**(): [`CKEditorConfig`](../interfaces/corelib.CKEditorConfig.md)

#### Returns

[`CKEditorConfig`](../interfaces/corelib.CKEditorConfig.md)

#### Overrides

[HtmlContentEditor](corelib.HtmlContentEditor.md).[getConfig](corelib.HtmlContentEditor.md#getconfig)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:232](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L232)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[HtmlContentEditor](corelib.HtmlContentEditor.md).[getCssClass](corelib.HtmlContentEditor.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getEditorInstance

▸ `Protected` **getEditorInstance**(): `any`

#### Returns

`any`

#### Inherited from

[HtmlContentEditor](corelib.HtmlContentEditor.md).[getEditorInstance](corelib.HtmlContentEditor.md#geteditorinstance)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L134)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[HtmlContentEditor](corelib.HtmlContentEditor.md).[getGridField](corelib.HtmlContentEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getLanguage

▸ `Protected` **getLanguage**(): `string`

#### Returns

`string`

#### Inherited from

[HtmlContentEditor](corelib.HtmlContentEditor.md).[getLanguage](corelib.HtmlContentEditor.md#getlanguage)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L66)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[HtmlContentEditor](corelib.HtmlContentEditor.md).[get_readOnly](corelib.HtmlContentEditor.md#get_readonly)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L170)

___

### get\_value

▸ **get_value**(): `string`

#### Returns

`string`

#### Inherited from

[HtmlContentEditor](corelib.HtmlContentEditor.md).[get_value](corelib.HtmlContentEditor.md#get_value)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L145)

___

### init

▸ **init**(`action?`): [`HtmlNoteContentEditor`](corelib.HtmlNoteContentEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`HtmlNoteContentEditor`](corelib.HtmlNoteContentEditor.md)

#### Inherited from

[HtmlContentEditor](corelib.HtmlContentEditor.md).[init](corelib.HtmlContentEditor.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[HtmlContentEditor](corelib.HtmlContentEditor.md).[initialize](corelib.HtmlContentEditor.md#initialize)

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

[HtmlContentEditor](corelib.HtmlContentEditor.md).[instanceReady](corelib.HtmlContentEditor.md#instanceready)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L56)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[HtmlContentEditor](corelib.HtmlContentEditor.md).[renderContents](corelib.HtmlContentEditor.md#rendercontents)

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

[HtmlContentEditor](corelib.HtmlContentEditor.md).[set_readOnly](corelib.HtmlContentEditor.md#set_readonly)

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

[HtmlContentEditor](corelib.HtmlContentEditor.md).[set_value](corelib.HtmlContentEditor.md#set_value)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L159)

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

[HtmlContentEditor](corelib.HtmlContentEditor.md).[create](corelib.HtmlContentEditor.md#create)

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

[HtmlContentEditor](corelib.HtmlContentEditor.md).[elementFor](corelib.HtmlContentEditor.md#elementfor)

#### Defined in

[src/ui/widgets/widget.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L128)

___

### getCKEditorBasePath

▸ `Static` **getCKEditorBasePath**(): `string`

#### Returns

`string`

#### Inherited from

[HtmlContentEditor](corelib.HtmlContentEditor.md).[getCKEditorBasePath](corelib.HtmlContentEditor.md#getckeditorbasepath)

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

[HtmlContentEditor](corelib.HtmlContentEditor.md).[getWidgetName](corelib.HtmlContentEditor.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)

___

### includeCKEditor

▸ `Static` **includeCKEditor**(): `void`

#### Returns

`void`

#### Inherited from

[HtmlContentEditor](corelib.HtmlContentEditor.md).[includeCKEditor](corelib.HtmlContentEditor.md#includeckeditor)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:208](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L208)
