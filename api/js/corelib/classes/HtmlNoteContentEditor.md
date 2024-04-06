[@serenity-is/corelib](../README.md) / HtmlNoteContentEditor

# Class: HtmlNoteContentEditor\<P\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`HtmlContentEditorOptions`](../interfaces/HtmlContentEditorOptions.md) = [`HtmlContentEditorOptions`](../interfaces/HtmlContentEditorOptions.md) |

## Hierarchy

- [`HtmlContentEditor`](HtmlContentEditor.md)\<`P`\>

  ↳ **`HtmlNoteContentEditor`**

## Table of contents

### Constructors

- [constructor](HtmlNoteContentEditor.md#constructor)

### Properties

- [domNode](HtmlNoteContentEditor.md#domnode)
- [idPrefix](HtmlNoteContentEditor.md#idprefix)
- [options](HtmlNoteContentEditor.md#options)
- [uniqueName](HtmlNoteContentEditor.md#uniquename)
- [CKEditorBasePath](HtmlNoteContentEditor.md#ckeditorbasepath)
- [CKEditorVer](HtmlNoteContentEditor.md#ckeditorver)
- [typeInfo](HtmlNoteContentEditor.md#typeinfo)

### Accessors

- [element](HtmlNoteContentEditor.md#element)
- [props](HtmlNoteContentEditor.md#props)
- [value](HtmlNoteContentEditor.md#value)

### Methods

- [addCssClass](HtmlNoteContentEditor.md#addcssclass)
- [addValidationRule](HtmlNoteContentEditor.md#addvalidationrule)
- [change](HtmlNoteContentEditor.md#change)
- [changeSelect2](HtmlNoteContentEditor.md#changeselect2)
- [destroy](HtmlNoteContentEditor.md#destroy)
- [getConfig](HtmlNoteContentEditor.md#getconfig)
- [getCssClass](HtmlNoteContentEditor.md#getcssclass)
- [getCustomAttribute](HtmlNoteContentEditor.md#getcustomattribute)
- [getEditorInstance](HtmlNoteContentEditor.md#geteditorinstance)
- [getFieldElement](HtmlNoteContentEditor.md#getfieldelement)
- [getGridField](HtmlNoteContentEditor.md#getgridfield)
- [getLanguage](HtmlNoteContentEditor.md#getlanguage)
- [get\_readOnly](HtmlNoteContentEditor.md#get_readonly)
- [get\_value](HtmlNoteContentEditor.md#get_value)
- [init](HtmlNoteContentEditor.md#init)
- [instanceReady](HtmlNoteContentEditor.md#instanceready)
- [internalInit](HtmlNoteContentEditor.md#internalinit)
- [internalRenderContents](HtmlNoteContentEditor.md#internalrendercontents)
- [render](HtmlNoteContentEditor.md#render)
- [renderContents](HtmlNoteContentEditor.md#rendercontents)
- [set\_readOnly](HtmlNoteContentEditor.md#set_readonly)
- [set\_value](HtmlNoteContentEditor.md#set_value)
- [syncOrAsyncThen](HtmlNoteContentEditor.md#syncorasyncthen)
- [useIdPrefix](HtmlNoteContentEditor.md#useidprefix)
- [create](HtmlNoteContentEditor.md#create)
- [createDefaultElement](HtmlNoteContentEditor.md#createdefaultelement)
- [getCKEditorBasePath](HtmlNoteContentEditor.md#getckeditorbasepath)
- [getWidgetName](HtmlNoteContentEditor.md#getwidgetname)
- [includeCKEditor](HtmlNoteContentEditor.md#includeckeditor)

## Constructors

### constructor

• **new HtmlNoteContentEditor**\<`P`\>(`props`): [`HtmlNoteContentEditor`](HtmlNoteContentEditor.md)\<`P`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `P` | extends [`HtmlContentEditorOptions`](../interfaces/HtmlContentEditorOptions.md) = [`HtmlContentEditorOptions`](../interfaces/HtmlContentEditorOptions.md) |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props` | [`EditorProps`](../README.md#editorprops)\<`P`\> |

#### Returns

[`HtmlNoteContentEditor`](HtmlNoteContentEditor.md)\<`P`\>

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[constructor](HtmlContentEditor.md#constructor)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L25)

## Properties

### domNode

• `Readonly` **domNode**: `HTMLTextAreaElement`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[domNode](HtmlContentEditor.md#domnode)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L21)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[idPrefix](HtmlContentEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### options

• `Protected` `Readonly` **options**: [`WidgetProps`](../README.md#widgetprops)\<[`EditorProps`](../README.md#editorprops)\<`P`\>\>

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[options](HtmlContentEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

___

### uniqueName

• `Protected` `Readonly` **uniqueName**: `string`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[uniqueName](HtmlContentEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

___

### CKEditorBasePath

▪ `Static` **CKEditorBasePath**: `string`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[CKEditorBasePath](HtmlContentEditor.md#ckeditorbasepath)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L198)

___

### CKEditorVer

▪ `Static` **CKEditorVer**: `string` = `"4.22.1"`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[CKEditorVer](HtmlContentEditor.md#ckeditorver)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:197](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L197)

___

### typeInfo

▪ `Static` **typeInfo**: [`ClassTypeInfo`](../README.md#classtypeinfo)\<``"Serenity.EditorWidget"``\>

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[typeInfo](HtmlContentEditor.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L202)

## Accessors

### element

• `get` **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

HtmlContentEditor.element

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

___

### props

• `get` **props**(): [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Returns

[`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

HtmlContentEditor.props

#### Defined in

[src/ui/widgets/widget.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L182)

___

### value

• `get` **value**(): `string`

#### Returns

`string`

#### Inherited from

HtmlContentEditor.value

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L162)

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

[src/ui/editors/htmlcontenteditor.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L173)

## Methods

### addCssClass

▸ **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[addCssClass](HtmlContentEditor.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

___

### addValidationRule

▸ **addValidationRule**(`rule`, `uniqueName?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `rule` | (`input`: `HTMLInputElement` \| `HTMLSelectElement` \| `HTMLTextAreaElement`) => `string` |
| `uniqueName?` | `string` |

#### Returns

`void`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[addValidationRule](HtmlContentEditor.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L99)

▸ **addValidationRule**(`uniqueName`, `rule`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `uniqueName` | `string` |
| `rule` | (`input`: `HTMLInputElement` \| `HTMLSelectElement` \| `HTMLTextAreaElement`) => `string` |

#### Returns

`void`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[addValidationRule](HtmlContentEditor.md#addvalidationrule)

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

[HtmlContentEditor](HtmlContentEditor.md).[change](HtmlContentEditor.md#change)

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

[HtmlContentEditor](HtmlContentEditor.md).[changeSelect2](HtmlContentEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[destroy](HtmlContentEditor.md#destroy)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L146)

___

### getConfig

▸ **getConfig**(): [`CKEditorConfig`](../interfaces/CKEditorConfig.md)

#### Returns

[`CKEditorConfig`](../interfaces/CKEditorConfig.md)

#### Overrides

[HtmlContentEditor](HtmlContentEditor.md).[getConfig](HtmlContentEditor.md#getconfig)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L238)

___

### getCssClass

▸ **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[getCssClass](HtmlContentEditor.md#getcssclass)

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

[HtmlContentEditor](HtmlContentEditor.md).[getCustomAttribute](HtmlContentEditor.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getEditorInstance

▸ **getEditorInstance**(): `any`

#### Returns

`any`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[getEditorInstance](HtmlContentEditor.md#geteditorinstance)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L141)

___

### getFieldElement

▸ **getFieldElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[getFieldElement](HtmlContentEditor.md#getfieldelement)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

___

### getGridField

▸ **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[getGridField](HtmlContentEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

___

### getLanguage

▸ **getLanguage**(): `string`

#### Returns

`string`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[getLanguage](HtmlContentEditor.md#getlanguage)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L72)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[get_readOnly](HtmlContentEditor.md#get_readonly)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L177)

___

### get\_value

▸ **get_value**(): `string`

#### Returns

`string`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[get_value](HtmlContentEditor.md#get_value)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L152)

___

### init

▸ **init**(): `this`

#### Returns

`this`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[init](HtmlContentEditor.md#init)

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

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[instanceReady](HtmlContentEditor.md#instanceready)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L60)

___

### internalInit

▸ **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[internalInit](HtmlContentEditor.md#internalinit)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

___

### internalRenderContents

▸ **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[internalRenderContents](HtmlContentEditor.md#internalrendercontents)

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

[HtmlContentEditor](HtmlContentEditor.md).[render](HtmlContentEditor.md#render)

#### Defined in

[src/ui/widgets/widget.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L159)

___

### renderContents

▸ **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[renderContents](HtmlContentEditor.md#rendercontents)

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

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[set_readOnly](HtmlContentEditor.md#set_readonly)

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

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[set_value](HtmlContentEditor.md#set_value)

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

[HtmlContentEditor](HtmlContentEditor.md).[syncOrAsyncThen](HtmlContentEditor.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L186)

___

### useIdPrefix

▸ **useIdPrefix**(): [`IdPrefixType`](../README.md#idprefixtype)

#### Returns

[`IdPrefixType`](../README.md#idprefixtype)

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[useIdPrefix](HtmlContentEditor.md#useidprefix)

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

[HtmlContentEditor](HtmlContentEditor.md).[create](HtmlContentEditor.md#create)

#### Defined in

[src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

___

### createDefaultElement

▸ **createDefaultElement**(): `HTMLTextAreaElement`

#### Returns

`HTMLTextAreaElement`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[createDefaultElement](HtmlContentEditor.md#createdefaultelement)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L23)

___

### getCKEditorBasePath

▸ **getCKEditorBasePath**(): `string`

#### Returns

`string`

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[getCKEditorBasePath](HtmlContentEditor.md#getckeditorbasepath)

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

[HtmlContentEditor](HtmlContentEditor.md).[getWidgetName](HtmlContentEditor.md#getwidgetname)

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

#### Inherited from

[HtmlContentEditor](HtmlContentEditor.md).[includeCKEditor](HtmlContentEditor.md#includeckeditor)

#### Defined in

[src/ui/editors/htmlcontenteditor.ts:215](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.ts#L215)
