[@serenity-is/corelib](../README.md) / MultipleImageUploadEditor

# Class: MultipleImageUploadEditor\<P\>

## Extends

- [`MultipleFileUploadEditor`](MultipleFileUploadEditor.md)\<`P`\>

## Type Parameters

• **P** *extends* [`ImageUploadEditorOptions`](../interfaces/ImageUploadEditorOptions.md) = [`ImageUploadEditorOptions`](../interfaces/ImageUploadEditorOptions.md)

## Constructors

### new MultipleImageUploadEditor()

> **new MultipleImageUploadEditor**\<`P`\>(`props`): [`MultipleImageUploadEditor`](MultipleImageUploadEditor.md)\<`P`\>

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

#### Returns

[`MultipleImageUploadEditor`](MultipleImageUploadEditor.md)\<`P`\>

#### Overrides

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`constructor`](MultipleFileUploadEditor.md#constructors)

#### Defined in

[src/ui/editors/uploadeditors.tsx:465](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L465)

## Properties

### domNode

> `readonly` **domNode**: `HTMLElement`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`domNode`](MultipleFileUploadEditor.md#domnode)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

***

### hiddenInput

> `protected` **hiddenInput**: `HTMLInputElement`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`hiddenInput`](MultipleFileUploadEditor.md#hiddeninput)

#### Defined in

[src/ui/editors/uploadeditors.tsx:284](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L284)

***

### idPrefix

> `readonly` **idPrefix**: `string`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`idPrefix`](MultipleFileUploadEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>\>

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`options`](MultipleFileUploadEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L14)

***

### progress

> `protected` **progress**: `HTMLElement`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`progress`](MultipleFileUploadEditor.md#progress)

#### Defined in

[src/ui/editors/uploadeditors.tsx:283](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L283)

***

### uniqueName

> `readonly` **uniqueName**: `string`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`uniqueName`](MultipleFileUploadEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`isComponent`](MultipleFileUploadEditor.md#iscomponent)

#### Defined in

[src/ui/widgets/widget.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L223)

***

### typeInfo

> `static` **typeInfo**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity.EditorWidget"`\>

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`typeInfo`](MultipleFileUploadEditor.md#typeinfo)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`element`](MultipleFileUploadEditor.md#element)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

***

### jsonEncodeValue

#### Get Signature

> **get** **jsonEncodeValue**(): `boolean`

##### Returns

`boolean`

#### Set Signature

> **set** **jsonEncodeValue**(`value`): `void`

##### Parameters

###### value

`boolean`

##### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`jsonEncodeValue`](MultipleFileUploadEditor.md#jsonencodevalue)

#### Defined in

[src/ui/editors/uploadeditors.tsx:459](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L459)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`props`](MultipleFileUploadEditor.md#props)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`readOnly`](MultipleFileUploadEditor.md#readonly)

#### Defined in

[src/ui/editors/editorwidget.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorwidget.ts#L23)

***

### value

#### Get Signature

> **get** **value**(): [`UploadedFile`](../interfaces/UploadedFile.md)[]

##### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)[]

#### Set Signature

> **set** **value**(`v`): `void`

##### Parameters

###### v

[`UploadedFile`](../interfaces/UploadedFile.md)[]

##### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`value`](MultipleFileUploadEditor.md#value)

#### Defined in

[src/ui/editors/uploadeditors.tsx:415](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L415)

## Methods

### addCssClass()

> `protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`addCssClass`](MultipleFileUploadEditor.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

***

### addFileButtonText()

> `protected` **addFileButtonText**(): `string`

#### Returns

`string`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`addFileButtonText`](MultipleFileUploadEditor.md#addfilebuttontext)

#### Defined in

[src/ui/editors/uploadeditors.tsx:336](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L336)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`addValidationRule`](MultipleFileUploadEditor.md#addvalidationrule)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`addValidationRule`](MultipleFileUploadEditor.md#addvalidationrule)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`afterRender`](MultipleFileUploadEditor.md#afterrender)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`byId`](MultipleFileUploadEditor.md#byid)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`change`](MultipleFileUploadEditor.md#change)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`changeSelect2`](MultipleFileUploadEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L122)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`deferRender`](MultipleFileUploadEditor.md#deferrender)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`destroy`](MultipleFileUploadEditor.md#destroy)

#### Defined in

[src/ui/widgets/widget.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L47)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`findById`](MultipleFileUploadEditor.md#findbyid)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`get_readOnly`](MultipleFileUploadEditor.md#get_readonly)

#### Defined in

[src/ui/editors/uploadeditors.tsx:375](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L375)

***

### get\_required()

> **get\_required**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`get_required`](MultipleFileUploadEditor.md#get_required)

#### Defined in

[src/ui/editors/uploadeditors.tsx:401](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L401)

***

### get\_value()

> **get\_value**(): [`UploadedFile`](../interfaces/UploadedFile.md)[]

#### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)[]

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`get_value`](MultipleFileUploadEditor.md#get_value)

#### Defined in

[src/ui/editors/uploadeditors.tsx:409](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L409)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`getCssClass`](MultipleFileUploadEditor.md#getcssclass)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`getCustomAttribute`](MultipleFileUploadEditor.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

***

### getEditValue()

> **getEditValue**(`property`, `target`): `void`

#### Parameters

##### property

[`PropertyItem`](../interfaces/PropertyItem.md)

##### target

`any`

#### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`getEditValue`](MultipleFileUploadEditor.md#geteditvalue)

#### Defined in

[src/ui/editors/uploadeditors.tsx:431](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L431)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`getGridField`](MultipleFileUploadEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L114)

***

### getToolButtons()

> `protected` **getToolButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`getToolButtons`](MultipleFileUploadEditor.md#gettoolbuttons)

#### Defined in

[src/ui/editors/uploadeditors.tsx:340](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L340)

***

### getUploadInputOptions()

> `protected` **getUploadInputOptions**(): [`UploadInputOptions`](../interfaces/UploadInputOptions.md)

#### Returns

[`UploadInputOptions`](../interfaces/UploadInputOptions.md)

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`getUploadInputOptions`](MultipleFileUploadEditor.md#getuploadinputoptions)

#### Defined in

[src/ui/editors/uploadeditors.tsx:310](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L310)

***

### init()

> **init**(): `this`

#### Returns

`this`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`init`](MultipleFileUploadEditor.md#init)

#### Defined in

[src/ui/widgets/widget.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L157)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`internalRenderContents`](MultipleFileUploadEditor.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L177)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`legacyTemplateRender`](MultipleFileUploadEditor.md#legacytemplaterender)

#### Defined in

[src/ui/widgets/widget.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L194)

***

### populate()

> `protected` **populate**(): `void`

#### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`populate`](MultipleFileUploadEditor.md#populate)

#### Defined in

[src/ui/editors/uploadeditors.tsx:350](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L350)

***

### render()

> **render**(): `any`

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`render`](MultipleFileUploadEditor.md#render)

#### Defined in

[src/ui/widgets/widget.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L167)

***

### renderContents()

> `protected` **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`renderContents`](MultipleFileUploadEditor.md#rendercontents)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`set_readOnly`](MultipleFileUploadEditor.md#set_readonly)

#### Defined in

[src/ui/editors/uploadeditors.tsx:379](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L379)

***

### set\_required()

> **set\_required**(`value`): `void`

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`set_required`](MultipleFileUploadEditor.md#set_required)

#### Defined in

[src/ui/editors/uploadeditors.tsx:405](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L405)

***

### set\_value()

> **set\_value**(`value`): `void`

#### Parameters

##### value

[`UploadedFile`](../interfaces/UploadedFile.md)[]

#### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`set_value`](MultipleFileUploadEditor.md#set_value)

#### Defined in

[src/ui/editors/uploadeditors.tsx:419](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L419)

***

### setEditValue()

> **setEditValue**(`source`, `property`): `void`

#### Parameters

##### source

`any`

##### property

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`setEditValue`](MultipleFileUploadEditor.md#seteditvalue)

#### Defined in

[src/ui/editors/uploadeditors.tsx:440](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L440)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`syncOrAsyncThen`](MultipleFileUploadEditor.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L211)

***

### updateInterface()

> `protected` **updateInterface**(): `void`

#### Returns

`void`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`updateInterface`](MultipleFileUploadEditor.md#updateinterface)

#### Defined in

[src/ui/editors/uploadeditors.tsx:369](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L369)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`useIdPrefix`](MultipleFileUploadEditor.md#useidprefix)

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

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`create`](MultipleFileUploadEditor.md#create)

#### Defined in

[src/ui/widgets/widget.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L130)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`createDefaultElement`](MultipleFileUploadEditor.md#createdefaultelement)

#### Defined in

[src/ui/widgets/widget.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L56)

***

### getWidgetName()

> `static` **getWidgetName**(`type`): `string`

#### Parameters

##### type

`Function`

#### Returns

`string`

#### Inherited from

[`MultipleFileUploadEditor`](MultipleFileUploadEditor.md).[`getWidgetName`](MultipleFileUploadEditor.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
