[@serenity-is/corelib](../README.md) / HtmlNoteContentEditor

# Class: HtmlNoteContentEditor\<P\>

## Extends

- [`HtmlContentEditor`](HtmlContentEditor.md)\<`P`\>

## Type Parameters

• **P** *extends* [`HtmlContentEditorOptions`](../interfaces/HtmlContentEditorOptions.md) = [`HtmlContentEditorOptions`](../interfaces/HtmlContentEditorOptions.md)

## Constructors

### new HtmlNoteContentEditor()

> **new HtmlNoteContentEditor**\<`P`\>(`props`): [`HtmlNoteContentEditor`](HtmlNoteContentEditor.md)\<`P`\>

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

#### Returns

[`HtmlNoteContentEditor`](HtmlNoteContentEditor.md)\<`P`\>

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`constructor`](HtmlContentEditor.md#constructors)

#### Defined in

[src/ui/editors/htmlcontenteditor.tsx:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L25)

## Properties

### domNode

> `readonly` **domNode**: `HTMLTextAreaElement`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`domNode`](HtmlContentEditor.md#domnode)

#### Defined in

[src/ui/editors/htmlcontenteditor.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L21)

***

### idPrefix

> `readonly` **idPrefix**: `string`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`idPrefix`](HtmlContentEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>\>

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`options`](HtmlContentEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L14)

***

### uniqueName

> `readonly` **uniqueName**: `string`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`uniqueName`](HtmlContentEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

***

### CKEditorBasePath

> `static` **CKEditorBasePath**: `string`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`CKEditorBasePath`](HtmlContentEditor.md#ckeditorbasepath)

#### Defined in

[src/ui/editors/htmlcontenteditor.tsx:198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L198)

***

### CKEditorVer

> `static` **CKEditorVer**: `string` = `"4.22.1"`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`CKEditorVer`](HtmlContentEditor.md#ckeditorver)

#### Defined in

[src/ui/editors/htmlcontenteditor.tsx:197](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L197)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`isComponent`](HtmlContentEditor.md#iscomponent)

#### Defined in

[src/ui/widgets/widget.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L223)

***

### typeInfo

> `static` **typeInfo**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity.EditorWidget"`\>

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`typeInfo`](HtmlContentEditor.md#typeinfo)

#### Defined in

[src/ui/editors/editorwidget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorwidget.ts#L17)

## Accessors

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`element`](HtmlContentEditor.md#element)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`props`](HtmlContentEditor.md#props)

#### Defined in

[src/ui/widgets/widget.ts:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L207)

***

### readOnly

#### Get Signature

> **get** **readOnly**(): `boolean`

##### Returns

`boolean`

#### Set Signature

> **set** **readOnly**(`value`): `void`

##### Parameters

###### value

`boolean`

##### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`readOnly`](HtmlContentEditor.md#readonly)

#### Defined in

[src/ui/editors/editorwidget.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorwidget.ts#L23)

***

### value

#### Get Signature

> **get** **value**(): `string`

##### Returns

`string`

#### Set Signature

> **set** **value**(`v`): `void`

##### Parameters

###### v

`string`

##### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`value`](HtmlContentEditor.md#value)

#### Defined in

[src/ui/editors/htmlcontenteditor.tsx:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L162)

## Methods

### addCssClass()

> `protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`addCssClass`](HtmlContentEditor.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

***

### addValidationRule()

#### Call Signature

> **addValidationRule**(`rule`, `uniqueName`?): `void`

##### Parameters

###### rule

(`input`) => `string`

###### uniqueName?

`string`

##### Returns

`void`

##### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`addValidationRule`](HtmlContentEditor.md#addvalidationrule)

##### Defined in

[src/ui/widgets/widget.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L99)

#### Call Signature

> **addValidationRule**(`uniqueName`, `rule`): `void`

##### Parameters

###### uniqueName

`string`

###### rule

(`input`) => `string`

##### Returns

`void`

##### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`addValidationRule`](HtmlContentEditor.md#addvalidationrule)

##### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

***

### afterRender()

> `protected` **afterRender**(`callback`): `void`

#### Parameters

##### callback

() => `void`

#### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`afterRender`](HtmlContentEditor.md#afterrender)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

***

### byId()

> `protected` **byId**\<`TElement`\>(`id`): [`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

#### Type Parameters

• **TElement** *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`byId`](HtmlContentEditor.md#byid)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

***

### change()

> **change**(`handler`): `void`

#### Parameters

##### handler

(`e`) => `void`

#### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`change`](HtmlContentEditor.md#change)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

***

### changeSelect2()

> **changeSelect2**(`handler`): `void`

#### Parameters

##### handler

(`e`) => `void`

#### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`changeSelect2`](HtmlContentEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L122)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`deferRender`](HtmlContentEditor.md#deferrender)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`destroy`](HtmlContentEditor.md#destroy)

#### Defined in

[src/ui/editors/htmlcontenteditor.tsx:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L146)

***

### findById()

> `protected` **findById**\<`TElement`\>(`id`): `TElement`

#### Type Parameters

• **TElement** *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

#### Returns

`TElement`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`findById`](HtmlContentEditor.md#findbyid)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`get_readOnly`](HtmlContentEditor.md#get_readonly)

#### Defined in

[src/ui/editors/htmlcontenteditor.tsx:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L177)

***

### get\_value()

> **get\_value**(): `string`

#### Returns

`string`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`get_value`](HtmlContentEditor.md#get_value)

#### Defined in

[src/ui/editors/htmlcontenteditor.tsx:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L152)

***

### getConfig()

> `protected` **getConfig**(): [`CKEditorConfig`](../interfaces/CKEditorConfig.md)

#### Returns

[`CKEditorConfig`](../interfaces/CKEditorConfig.md)

#### Overrides

[`HtmlContentEditor`](HtmlContentEditor.md).[`getConfig`](HtmlContentEditor.md#getconfig)

#### Defined in

[src/ui/editors/htmlcontenteditor.tsx:235](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L235)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`getCssClass`](HtmlContentEditor.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L75)

***

### getCustomAttribute()

> `protected` **getCustomAttribute**\<`TAttr`\>(`attrType`, `inherit`): `TAttr`

#### Type Parameters

• **TAttr**

#### Parameters

##### attrType

(...`args`) => `TAttr`

##### inherit

`boolean` = `true`

#### Returns

`TAttr`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`getCustomAttribute`](HtmlContentEditor.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

***

### getEditorInstance()

> `protected` **getEditorInstance**(): `any`

#### Returns

`any`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`getEditorInstance`](HtmlContentEditor.md#geteditorinstance)

#### Defined in

[src/ui/editors/htmlcontenteditor.tsx:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L141)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`getGridField`](HtmlContentEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L114)

***

### getLanguage()

> `protected` **getLanguage**(): `string`

#### Returns

`string`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`getLanguage`](HtmlContentEditor.md#getlanguage)

#### Defined in

[src/ui/editors/htmlcontenteditor.tsx:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L72)

***

### init()

> **init**(): `this`

#### Returns

`this`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`init`](HtmlContentEditor.md#init)

#### Defined in

[src/ui/widgets/widget.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L157)

***

### instanceReady()

> `protected` **instanceReady**(`x`): `void`

#### Parameters

##### x

`any`

#### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`instanceReady`](HtmlContentEditor.md#instanceready)

#### Defined in

[src/ui/editors/htmlcontenteditor.tsx:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L60)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`internalRenderContents`](HtmlContentEditor.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L177)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`legacyTemplateRender`](HtmlContentEditor.md#legacytemplaterender)

#### Defined in

[src/ui/widgets/widget.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L194)

***

### render()

> **render**(): `any`

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`render`](HtmlContentEditor.md#render)

#### Defined in

[src/ui/widgets/widget.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L167)

***

### renderContents()

> `protected` **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`renderContents`](HtmlContentEditor.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L188)

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`set_readOnly`](HtmlContentEditor.md#set_readonly)

#### Defined in

[src/ui/editors/htmlcontenteditor.tsx:181](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L181)

***

### set\_value()

> **set\_value**(`value`): `void`

#### Parameters

##### value

`string`

#### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`set_value`](HtmlContentEditor.md#set_value)

#### Defined in

[src/ui/editors/htmlcontenteditor.tsx:166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L166)

***

### syncOrAsyncThen()

> `protected` **syncOrAsyncThen**\<`T`\>(`syncMethod`, `asyncMethod`, `then`): `void`

#### Type Parameters

• **T**

#### Parameters

##### syncMethod

() => `T`

##### asyncMethod

() => `PromiseLike`\<`T`\>

##### then

(`v`) => `void`

#### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`syncOrAsyncThen`](HtmlContentEditor.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L211)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`useIdPrefix`](HtmlContentEditor.md#useidprefix)

#### Defined in

[src/ui/widgets/widget.ts:218](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L218)

***

### create()

> `static` **create**\<`TWidget`, `P`\>(`params`): `TWidget`

#### Type Parameters

• **TWidget** *extends* [`Widget`](Widget.md)\<`P`\>

• **P**

#### Parameters

##### params

[`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)\<`TWidget`, `P`\>

#### Returns

`TWidget`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`create`](HtmlContentEditor.md#create)

#### Defined in

[src/ui/widgets/widget.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L130)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLTextAreaElement`

#### Returns

`HTMLTextAreaElement`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`createDefaultElement`](HtmlContentEditor.md#createdefaultelement)

#### Defined in

[src/ui/editors/htmlcontenteditor.tsx:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L23)

***

### getCKEditorBasePath()

> `static` **getCKEditorBasePath**(): `string`

#### Returns

`string`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`getCKEditorBasePath`](HtmlContentEditor.md#getckeditorbasepath)

#### Defined in

[src/ui/editors/htmlcontenteditor.tsx:200](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L200)

***

### getWidgetName()

> `static` **getWidgetName**(`type`): `string`

#### Parameters

##### type

`Function`

#### Returns

`string`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`getWidgetName`](HtmlContentEditor.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)

***

### includeCKEditor()

> `static` **includeCKEditor**(`then`): `void`

#### Parameters

##### then

() => `void`

#### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`includeCKEditor`](HtmlContentEditor.md#includeckeditor)

#### Defined in

[src/ui/editors/htmlcontenteditor.tsx:215](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L215)
