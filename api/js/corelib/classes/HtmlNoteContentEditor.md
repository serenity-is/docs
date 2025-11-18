[@serenity-is/corelib](../README.md) / HtmlNoteContentEditor

# Class: HtmlNoteContentEditor\<P\>

Defined in: [src/ui/editors/htmlcontenteditor.tsx:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L243)

## Extends

- [`HtmlContentEditor`](HtmlContentEditor.md)\<`P`\>

## Type Parameters

### P

`P` *extends* [`HtmlContentEditorOptions`](../interfaces/HtmlContentEditorOptions.md) = [`HtmlContentEditorOptions`](../interfaces/HtmlContentEditorOptions.md)

## Constructors

### Constructor

> **new HtmlNoteContentEditor**\<`P`\>(`props`): `HtmlNoteContentEditor`\<`P`\>

Defined in: [src/ui/editors/htmlcontenteditor.tsx:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L24)

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

#### Returns

`HtmlNoteContentEditor`\<`P`\>

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`constructor`](HtmlContentEditor.md#constructor)

## Properties

### domNode

> `readonly` **domNode**: `HTMLTextAreaElement`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L20)

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`domNode`](HtmlContentEditor.md#domnode)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L13)

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`idPrefix`](HtmlContentEditor.md#idprefix)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>\>

Defined in: [src/ui/widgets/widget.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L11)

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`options`](HtmlContentEditor.md#options)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`uniqueName`](HtmlContentEditor.md#uniquename)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/editors/htmlcontenteditor.tsx:244](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L244)

#### Overrides

[`HtmlContentEditor`](HtmlContentEditor.md).[`[typeInfo]`](HtmlContentEditor.md#typeinfo)

***

### CKEditorBasePath

> `static` **CKEditorBasePath**: `string`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L211)

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`CKEditorBasePath`](HtmlContentEditor.md#ckeditorbasepath)

***

### CKEditorVer

> `static` **CKEditorVer**: `string` = `"4.22.1"`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:210](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L210)

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`CKEditorVer`](HtmlContentEditor.md#ckeditorver)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L219)

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`isComponent`](HtmlContentEditor.md#iscomponent)

## Accessors

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L59)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`element`](HtmlContentEditor.md#element)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L203)

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`props`](HtmlContentEditor.md#props)

***

### readOnly

#### Get Signature

> **get** **readOnly**(): `boolean`

Defined in: [src/ui/editors/editorwidget.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorwidget.ts#L20)

##### Returns

`boolean`

#### Set Signature

> **set** **readOnly**(`value`): `void`

Defined in: [src/ui/editors/editorwidget.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorwidget.ts#L25)

##### Parameters

###### value

`boolean`

##### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`readOnly`](HtmlContentEditor.md#readonly)

***

### value

#### Get Signature

> **get** **value**(): `string`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L175)

##### Returns

`string`

#### Set Signature

> **set** **value**(`v`): `void`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L186)

##### Parameters

###### v

`string`

##### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`value`](HtmlContentEditor.md#value)

## Methods

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

#### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`addCssClass`](HtmlContentEditor.md#addcssclass)

***

### addValidationRule()

#### Call Signature

> **addValidationRule**(`rule`, `uniqueName?`): `void`

Defined in: [src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)

##### Parameters

###### rule

(`input`) => `string`

###### uniqueName?

`string`

##### Returns

`void`

##### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`addValidationRule`](HtmlContentEditor.md#addvalidationrule)

#### Call Signature

> **addValidationRule**(`uniqueName`, `rule`): `void`

Defined in: [src/ui/widgets/widget.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L96)

##### Parameters

###### uniqueName

`string`

###### rule

(`input`) => `string`

##### Returns

`void`

##### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`addValidationRule`](HtmlContentEditor.md#addvalidationrule)

***

### afterRender()

> `protected` **afterRender**(`callback`): `void`

Defined in: [src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

#### Parameters

##### callback

() => `void`

#### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`afterRender`](HtmlContentEditor.md#afterrender)

***

### byId()

> `protected` **byId**\<`TElement`\>(`id`): [`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

Defined in: [src/ui/widgets/widget.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L102)

#### Type Parameters

##### TElement

`TElement` *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`byId`](HtmlContentEditor.md#byid)

***

### change()

> **change**(`handler`): `void`

Defined in: [src/ui/widgets/widget.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L114)

#### Parameters

##### handler

(`e`) => `void`

#### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`change`](HtmlContentEditor.md#change)

***

### changeSelect2()

> **changeSelect2**(`handler`): `void`

Defined in: [src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

#### Parameters

##### handler

(`e`) => `void`

#### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`changeSelect2`](HtmlContentEditor.md#changeselect2)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

#### Returns

`boolean`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`deferRender`](HtmlContentEditor.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L159)

#### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`destroy`](HtmlContentEditor.md#destroy)

***

### findById()

> `protected` **findById**\<`TElement`\>(`id`): `TElement`

Defined in: [src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

#### Type Parameters

##### TElement

`TElement` *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

#### Returns

`TElement`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`findById`](HtmlContentEditor.md#findbyid)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L190)

#### Returns

`boolean`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`get_readOnly`](HtmlContentEditor.md#get_readonly)

***

### get\_value()

> **get\_value**(): `string`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L165)

#### Returns

`string`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`get_value`](HtmlContentEditor.md#get_value)

***

### getConfig()

> `protected` **getConfig**(): [`CKEditorConfig`](../interfaces/CKEditorConfig.md)

Defined in: [src/ui/editors/htmlcontenteditor.tsx:246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L246)

#### Returns

[`CKEditorConfig`](../interfaces/CKEditorConfig.md)

#### Overrides

[`HtmlContentEditor`](HtmlContentEditor.md).[`getConfig`](HtmlContentEditor.md#getconfig)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

#### Returns

`string`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`getCssClass`](HtmlContentEditor.md#getcssclass)

***

### getCustomAttribute()

> `protected` **getCustomAttribute**\<`TAttr`\>(`attrType`, `inherit`): `TAttr`

Defined in: [src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

#### Type Parameters

##### TAttr

`TAttr` *extends* [`CustomAttribute`](CustomAttribute.md)

#### Parameters

##### attrType

(...`args`) => `TAttr`

##### inherit

`boolean` = `true`

#### Returns

`TAttr`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`getCustomAttribute`](HtmlContentEditor.md#getcustomattribute)

***

### getEditorInstance()

> `protected` **getEditorInstance**(): `any`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L154)

#### Returns

`any`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`getEditorInstance`](HtmlContentEditor.md#geteditorinstance)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

#### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`getGridField`](HtmlContentEditor.md#getgridfield)

***

### getLanguage()

> `protected` **getLanguage**(): `string`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L71)

#### Returns

`string`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`getLanguage`](HtmlContentEditor.md#getlanguage)

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

#### Returns

`this`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`init`](HtmlContentEditor.md#init)

***

### instanceReady()

> `protected` **instanceReady**(`x`): `void`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L59)

#### Parameters

##### x

`any`

#### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`instanceReady`](HtmlContentEditor.md#instanceready)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L173)

#### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`internalRenderContents`](HtmlContentEditor.md#internalrendercontents)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L190)

#### Returns

`boolean`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`legacyTemplateRender`](HtmlContentEditor.md#legacytemplaterender)

***

### render()

> **render**(): `any`

Defined in: [src/ui/widgets/widget.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L163)

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`render`](HtmlContentEditor.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

#### Returns

`any`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`renderContents`](HtmlContentEditor.md#rendercontents)

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L194)

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`set_readOnly`](HtmlContentEditor.md#set_readonly)

***

### set\_value()

> **set\_value**(`value`): `void`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L179)

#### Parameters

##### value

`string`

#### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`set_value`](HtmlContentEditor.md#set_value)

***

### syncOrAsyncThen()

> `protected` **syncOrAsyncThen**\<`T`\>(`syncMethod`, `asyncMethod`, `then`): `void`

Defined in: [src/ui/widgets/widget.ts:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L207)

#### Type Parameters

##### T

`T`

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

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L214)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`useIdPrefix`](HtmlContentEditor.md#useidprefix)

***

### create()

> `static` **create**\<`TWidget`, `P`\>(`params`): `TWidget`

Defined in: [src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

#### Type Parameters

##### TWidget

`TWidget` *extends* [`Widget`](Widget.md)\<`P`\>

##### P

`P`

#### Parameters

##### params

[`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)\<`TWidget`, `P`\>

#### Returns

`TWidget`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`create`](HtmlContentEditor.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLTextAreaElement`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L22)

#### Returns

`HTMLTextAreaElement`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`createDefaultElement`](HtmlContentEditor.md#createdefaultelement)

***

### getCKEditorBasePath()

> `static` **getCKEditorBasePath**(): `string`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:213](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L213)

#### Returns

`string`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`getCKEditorBasePath`](HtmlContentEditor.md#getckeditorbasepath)

***

### getWidgetName()

> `static` **getWidgetName**(`type`): `string`

Defined in: [src/ui/widgets/widget.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L91)

#### Parameters

##### type

`Function`

#### Returns

`string`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`getWidgetName`](HtmlContentEditor.md#getwidgetname)

***

### includeCKEditor()

> `static` **includeCKEditor**(`then`): `void`

Defined in: [src/ui/editors/htmlcontenteditor.tsx:226](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/htmlcontenteditor.tsx#L226)

#### Parameters

##### then

() => `void`

#### Returns

`void`

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`includeCKEditor`](HtmlContentEditor.md#includeckeditor)

***

### registerClass()

> `protected` `static` **registerClass**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

Defined in: [src/ui/widgets/widget.ts:221](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L221)

#### Type Parameters

##### TypeName

`TypeName`

#### Parameters

##### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

##### intfAndAttr?

([`InterfaceType`](../type-aliases/InterfaceType.md) \| [`AttributeSpecifier`](../type-aliases/AttributeSpecifier.md))[]

#### Returns

[`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`registerClass`](HtmlContentEditor.md#registerclass)

***

### registerEditor()

> `protected` `static` **registerEditor**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`TypeName`\>

Defined in: [src/ui/widgets/widget.ts:230](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L230)

#### Type Parameters

##### TypeName

`TypeName`

#### Parameters

##### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

##### intfAndAttr?

([`InterfaceType`](../type-aliases/InterfaceType.md) \| [`AttributeSpecifier`](../type-aliases/AttributeSpecifier.md))[]

#### Returns

[`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`TypeName`\>

#### Inherited from

[`HtmlContentEditor`](HtmlContentEditor.md).[`registerEditor`](HtmlContentEditor.md#registereditor)
