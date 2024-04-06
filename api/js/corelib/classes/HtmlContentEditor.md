[@serenity-is/corelib](../README.md) / HtmlContentEditor

# Class: HtmlContentEditor\<P\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`HtmlContentEditorOptions`](../interfaces/HtmlContentEditorOptions.md) = [`HtmlContentEditorOptions`](../interfaces/HtmlContentEditorOptions.md) |

## Hierarchy

- [`EditorWidget`](EditorWidget.md)\<`P`\>

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
- [domNode](HtmlContentEditor.md#domnode)
- [idPrefix](HtmlContentEditor.md#idprefix)
- [options](HtmlContentEditor.md#options)
- [uniqueName](HtmlContentEditor.md#uniquename)
- [CKEditorBasePath](HtmlContentEditor.md#ckeditorbasepath)
- [CKEditorVer](HtmlContentEditor.md#ckeditorver)
- [typeInfo](HtmlContentEditor.md#typeinfo)

### Accessors

- [element](HtmlContentEditor.md#element)
- [props](HtmlContentEditor.md#props)
- [value](HtmlContentEditor.md#value)

### Methods

- [addCssClass](HtmlContentEditor.md#addcssclass)
- [addValidationRule](HtmlContentEditor.md#addvalidationrule)
- [change](HtmlContentEditor.md#change)
- [changeSelect2](HtmlContentEditor.md#changeselect2)
- [destroy](HtmlContentEditor.md#destroy)
- [getConfig](HtmlContentEditor.md#getconfig)
- [getCssClass](HtmlContentEditor.md#getcssclass)
- [getCustomAttribute](HtmlContentEditor.md#getcustomattribute)
- [getEditorInstance](HtmlContentEditor.md#geteditorinstance)
- [getFieldElement](HtmlContentEditor.md#getfieldelement)
- [getGridField](HtmlContentEditor.md#getgridfield)
- [getLanguage](HtmlContentEditor.md#getlanguage)
- [get\_readOnly](HtmlContentEditor.md#get_readonly)
- [get\_value](HtmlContentEditor.md#get_value)
- [init](HtmlContentEditor.md#init)
- [instanceReady](HtmlContentEditor.md#instanceready)
- [internalInit](HtmlContentEditor.md#internalinit)
- [internalRenderContents](HtmlContentEditor.md#internalrendercontents)
- [render](HtmlContentEditor.md#render)
- [renderContents](HtmlContentEditor.md#rendercontents)
- [set\_readOnly](HtmlContentEditor.md#set_readonly)
- [set\_value](HtmlContentEditor.md#set_value)
- [syncOrAsyncThen](HtmlContentEditor.md#syncorasyncthen)
- [useIdPrefix](HtmlContentEditor.md#useidprefix)
- [create](HtmlContentEditor.md#create)
- [createDefaultElement](HtmlContentEditor.md#createdefaultelement)
- [getCKEditorBasePath](HtmlContentEditor.md#getckeditorbasepath)
- [getWidgetName](HtmlContentEditor.md#getwidgetname)
- [includeCKEditor](HtmlContentEditor.md#includeckeditor)

## Constructors

### constructor

• **new HtmlContentEditor**\<`P`\>(`props`): [`HtmlContentEditor`](HtmlContentEditor.md)\<`P`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`HtmlContentEditorOptions`](../interfaces/HtmlContentEditorOptions.md) = [`HtmlContentEditorOptions`](../interfaces/HtmlContentEditorOptions.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | [`EditorProps`](../README.md#editorprops)\<`P`\> |

#### Returns

[`HtmlContentEditor`](HtmlContentEditor.md)\<`P`\>

#### Overrides

[EditorWidget](EditorWidget.md).[constructor](EditorWidget.md#constructor)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L25)

## Properties

### \_instanceReady

• `Private` **\_instanceReady**: `boolean`

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L20)

___

### domNode

• `Readonly` **domNode**: `HTMLTextAreaElement`

#### Overrides

[EditorWidget](EditorWidget.md).[domNode](EditorWidget.md#domnode)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L21)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[EditorWidget](EditorWidget.md).[idPrefix](EditorWidget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### options

• `Protected` `Readonly` **options**: [`WidgetProps`](../README.md#widgetprops)\<[`EditorProps`](../README.md#editorprops)\<`P`\>\>

#### Inherited from

[EditorWidget](EditorWidget.md).[options](EditorWidget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

___

### uniqueName

• `Protected` `Readonly` **uniqueName**: `string`

#### Inherited from

[EditorWidget](EditorWidget.md).[uniqueName](EditorWidget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

___

### CKEditorBasePath

▪ `Static` **CKEditorBasePath**: `string`

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L198)

___

### CKEditorVer

▪ `Static` **CKEditorVer**: `string` = `"4.22.1"`

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:197](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L197)

___

### typeInfo

▪ `Static` **typeInfo**: [`ClassTypeInfo`](../README.md#classtypeinfo)\<``"Serenity.EditorWidget"``\>

#### Inherited from

[EditorWidget](EditorWidget.md).[typeInfo](EditorWidget.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L202)

## Accessors

### element

• `get` **element**(): [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

#### Returns

[`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

EditorWidget.element

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

___

### props

• `get` **props**(): [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Returns

[`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

EditorWidget.props

#### Defined in

[src/ui/widgets/widget.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L182)

___

### value

• `get` **value**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L162)

• `set` **value**(`v`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `v` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L173)

## Methods

### addCssClass

▸ **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[addCssClass](EditorWidget.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

___

### addValidationRule

▸ **addValidationRule**(`rule`, `uniqueName?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `rule` | (`input`: `HTMLSelectElement` \| `HTMLInputElement` \| `HTMLTextAreaElement`) => `string` |
| `uniqueName?` | `string` |

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[addValidationRule](EditorWidget.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L99)

▸ **addValidationRule**(`uniqueName`, `rule`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `uniqueName` | `string` |
| `rule` | (`input`: `HTMLSelectElement` \| `HTMLInputElement` \| `HTMLTextAreaElement`) => `string` |

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[addValidationRule](EditorWidget.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### change

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `Event`) => `void` |

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[change](EditorWidget.md#change)

#### Defined in

[src/ui/widgets/widget.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L114)

___

### changeSelect2

▸ **changeSelect2**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `Event`) => `void` |

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[changeSelect2](EditorWidget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[EditorWidget](EditorWidget.md).[destroy](EditorWidget.md#destroy)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L146)

___

### getConfig

▸ **getConfig**(): [`CKEditorConfig`](../interfaces/CKEditorConfig.md)

#### Returns

[`CKEditorConfig`](../interfaces/CKEditorConfig.md)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L91)

___

### getCssClass

▸ **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[EditorWidget](EditorWidget.md).[getCssClass](EditorWidget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L75)

___

### getCustomAttribute

▸ **getCustomAttribute**\<`TAttr`\>(`attrType`, `inherit?`): `TAttr`

#### Type parameters

| Name |
| :------ |
| `TAttr` |

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `attrType` | (...`args`: `any`[]) => `TAttr` | `undefined` |
| `inherit` | `boolean` | `true` |

#### Returns

`TAttr`

#### Inherited from

[EditorWidget](EditorWidget.md).[getCustomAttribute](EditorWidget.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getEditorInstance

▸ **getEditorInstance**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L141)

___

### getFieldElement

▸ **getFieldElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[EditorWidget](EditorWidget.md).[getFieldElement](EditorWidget.md#getfieldelement)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

___

### getGridField

▸ **getGridField**(): [`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent-1.md)\<`HTMLElement`\>

#### Inherited from

[EditorWidget](EditorWidget.md).[getGridField](EditorWidget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

___

### getLanguage

▸ **getLanguage**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L72)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IReadOnly](IReadOnly.md).[get_readOnly](IReadOnly.md#get_readonly)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L177)

___

### get\_value

▸ **get_value**(): `string`

#### Returns

`string`

#### Implementation of

[IStringValue](IStringValue.md).[get_value](IStringValue.md#get_value)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L152)

___

### init

▸ **init**(): `this`

#### Returns

`this`

#### Inherited from

[EditorWidget](EditorWidget.md).[init](EditorWidget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

___

### instanceReady

▸ **instanceReady**(`x`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `x` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L60)

___

### internalInit

▸ **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[internalInit](EditorWidget.md#internalinit)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

___

### internalRenderContents

▸ **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[internalRenderContents](EditorWidget.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L169)

___

### render

▸ **render**(): `any`

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[EditorWidget](EditorWidget.md).[render](EditorWidget.md#render)

#### Defined in

[src/ui/widgets/widget.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L159)

___

### renderContents

▸ **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[EditorWidget](EditorWidget.md).[renderContents](EditorWidget.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L178)

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

[src/ui/editors/htmlcontenteditor.ts:181](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L181)

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

[src/ui/editors/htmlcontenteditor.ts:166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L166)

___

### syncOrAsyncThen

▸ **syncOrAsyncThen**\<`T`\>(`syncMethod`, `asyncMethod`, `then`): `void`

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `syncMethod` | () => `T` |
| `asyncMethod` | () => `PromiseLike`\<`T`\> |
| `then` | (`v`: `T`) => `void` |

#### Returns

`void`

#### Inherited from

[EditorWidget](EditorWidget.md).[syncOrAsyncThen](EditorWidget.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L186)

___

### useIdPrefix

▸ **useIdPrefix**(): [`IdPrefixType`](../README.md#idprefixtype)

#### Returns

[`IdPrefixType`](../README.md#idprefixtype)

#### Inherited from

[EditorWidget](EditorWidget.md).[useIdPrefix](EditorWidget.md#useidprefix)

#### Defined in

[src/ui/widgets/widget.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L193)

___

### create

▸ **create**\<`TWidget`, `P`\>(`params`): `TWidget`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](Widget.md)\<`P`\> |
| `P` | `P` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `params` | [`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)\<`TWidget`, `P`\> |

#### Returns

`TWidget`

#### Inherited from

[EditorWidget](EditorWidget.md).[create](EditorWidget.md#create)

#### Defined in

[src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

___

### createDefaultElement

▸ **createDefaultElement**(): `HTMLTextAreaElement`

#### Returns

`HTMLTextAreaElement`

#### Overrides

[EditorWidget](EditorWidget.md).[createDefaultElement](EditorWidget.md#createdefaultelement)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L23)

___

### getCKEditorBasePath

▸ **getCKEditorBasePath**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:200](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L200)

___

### getWidgetName

▸ **getWidgetName**(`type`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `Function` |

#### Returns

`string`

#### Inherited from

[EditorWidget](EditorWidget.md).[getWidgetName](EditorWidget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)

___

### includeCKEditor

▸ **includeCKEditor**(`then`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `then` | () => `void` |

#### Returns

`void`

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:215](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L215)
