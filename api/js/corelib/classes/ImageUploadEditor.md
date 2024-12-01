[@serenity-is/corelib](../README.md) / ImageUploadEditor

# Class: ImageUploadEditor\<P\>

## Extends

- [`FileUploadEditor`](FileUploadEditor.md)\<`P`\>

## Type Parameters

• **P** *extends* [`ImageUploadEditorOptions`](../interfaces/ImageUploadEditorOptions.md) = [`ImageUploadEditorOptions`](../interfaces/ImageUploadEditorOptions.md)

## Constructors

### new ImageUploadEditor()

> **new ImageUploadEditor**\<`P`\>(`props`): [`ImageUploadEditor`](ImageUploadEditor.md)\<`P`\>

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

#### Returns

[`ImageUploadEditor`](ImageUploadEditor.md)\<`P`\>

#### Overrides

[`FileUploadEditor`](FileUploadEditor.md).[`constructor`](FileUploadEditor.md#constructors)

#### Defined in

[src/ui/editors/uploadeditors.tsx:261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L261)

## Properties

### domNode

> `readonly` **domNode**: `HTMLElement`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`domNode`](FileUploadEditor.md#domnode)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

***

### entity

> `protected` **entity**: [`UploadedFile`](../interfaces/UploadedFile.md)

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`entity`](FileUploadEditor.md#entity)

#### Defined in

[src/ui/editors/uploadeditors.tsx:251](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L251)

***

### fileSymbols

> `protected` **fileSymbols**: `HTMLElement`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`fileSymbols`](FileUploadEditor.md#filesymbols)

#### Defined in

[src/ui/editors/uploadeditors.tsx:254](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L254)

***

### hiddenInput

> `protected` **hiddenInput**: `HTMLInputElement`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`hiddenInput`](FileUploadEditor.md#hiddeninput)

#### Defined in

[src/ui/editors/uploadeditors.tsx:256](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L256)

***

### idPrefix

> `readonly` **idPrefix**: `string`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`idPrefix`](FileUploadEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>\>

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`options`](FileUploadEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L14)

***

### progress

> `protected` **progress**: `HTMLElement`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`progress`](FileUploadEditor.md#progress)

#### Defined in

[src/ui/editors/uploadeditors.tsx:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L253)

***

### toolbar

> `protected` **toolbar**: [`Toolbar`](Toolbar.md)\<[`ToolbarOptions`](../interfaces/ToolbarOptions.md)\>

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`toolbar`](FileUploadEditor.md#toolbar)

#### Defined in

[src/ui/editors/uploadeditors.tsx:252](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L252)

***

### uniqueName

> `readonly` **uniqueName**: `string`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`uniqueName`](FileUploadEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

***

### uploadInput

> `protected` **uploadInput**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`uploadInput`](FileUploadEditor.md#uploadinput)

#### Defined in

[src/ui/editors/uploadeditors.tsx:255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L255)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`isComponent`](FileUploadEditor.md#iscomponent)

#### Defined in

[src/ui/widgets/widget.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L223)

***

### typeInfo

> `static` **typeInfo**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity.EditorWidget"`\>

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`typeInfo`](FileUploadEditor.md#typeinfo)

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

[`FileUploadEditor`](FileUploadEditor.md).[`element`](FileUploadEditor.md#element)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`props`](FileUploadEditor.md#props)

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

[`FileUploadEditor`](FileUploadEditor.md).[`readOnly`](FileUploadEditor.md#readonly)

#### Defined in

[src/ui/editors/editorwidget.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorwidget.ts#L23)

***

### value

#### Get Signature

> **get** **value**(): [`UploadedFile`](../interfaces/UploadedFile.md)

##### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)

#### Set Signature

> **set** **value**(`v`): `void`

##### Parameters

###### v

[`UploadedFile`](../interfaces/UploadedFile.md)

##### Returns

`void`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`value`](FileUploadEditor.md#value)

#### Defined in

[src/ui/editors/uploadeditors.tsx:181](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L181)

## Methods

### addCssClass()

> `protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`addCssClass`](FileUploadEditor.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

***

### addFileButtonText()

> `protected` **addFileButtonText**(): `string`

#### Returns

`string`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`addFileButtonText`](FileUploadEditor.md#addfilebuttontext)

#### Defined in

[src/ui/editors/uploadeditors.tsx:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L85)

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

[`FileUploadEditor`](FileUploadEditor.md).[`addValidationRule`](FileUploadEditor.md#addvalidationrule)

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

[`FileUploadEditor`](FileUploadEditor.md).[`addValidationRule`](FileUploadEditor.md#addvalidationrule)

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

[`FileUploadEditor`](FileUploadEditor.md).[`afterRender`](FileUploadEditor.md#afterrender)

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

[`FileUploadEditor`](FileUploadEditor.md).[`byId`](FileUploadEditor.md#byid)

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

[`FileUploadEditor`](FileUploadEditor.md).[`change`](FileUploadEditor.md#change)

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

[`FileUploadEditor`](FileUploadEditor.md).[`changeSelect2`](FileUploadEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L122)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`deferRender`](FileUploadEditor.md#deferrender)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`destroy`](FileUploadEditor.md#destroy)

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

[`FileUploadEditor`](FileUploadEditor.md).[`findById`](FileUploadEditor.md#findbyid)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`get_readOnly`](FileUploadEditor.md#get_readonly)

#### Defined in

[src/ui/editors/uploadeditors.tsx:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L139)

***

### get\_required()

> **get\_required**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`get_required`](FileUploadEditor.md#get_required)

#### Defined in

[src/ui/editors/uploadeditors.tsx:165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L165)

***

### get\_value()

> **get\_value**(): [`UploadedFile`](../interfaces/UploadedFile.md)

#### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`get_value`](FileUploadEditor.md#get_value)

#### Defined in

[src/ui/editors/uploadeditors.tsx:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L173)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`getCssClass`](FileUploadEditor.md#getcssclass)

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

[`FileUploadEditor`](FileUploadEditor.md).[`getCustomAttribute`](FileUploadEditor.md#getcustomattribute)

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

[`FileUploadEditor`](FileUploadEditor.md).[`getEditValue`](FileUploadEditor.md#geteditvalue)

#### Defined in

[src/ui/editors/uploadeditors.tsx:224](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L224)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`getGridField`](FileUploadEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L114)

***

### getToolButtons()

> `protected` **getToolButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`getToolButtons`](FileUploadEditor.md#gettoolbuttons)

#### Defined in

[src/ui/editors/uploadeditors.tsx:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L89)

***

### getUploadInputOptions()

> `protected` **getUploadInputOptions**(): [`UploadInputOptions`](../interfaces/UploadInputOptions.md)

#### Returns

[`UploadInputOptions`](../interfaces/UploadInputOptions.md)

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`getUploadInputOptions`](FileUploadEditor.md#getuploadinputoptions)

#### Defined in

[src/ui/editors/uploadeditors.tsx:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L58)

***

### init()

> **init**(): `this`

#### Returns

`this`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`init`](FileUploadEditor.md#init)

#### Defined in

[src/ui/widgets/widget.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L157)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`internalRenderContents`](FileUploadEditor.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L177)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`legacyTemplateRender`](FileUploadEditor.md#legacytemplaterender)

#### Defined in

[src/ui/widgets/widget.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L194)

***

### populate()

> `protected` **populate**(): `void`

#### Returns

`void`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`populate`](FileUploadEditor.md#populate)

#### Defined in

[src/ui/editors/uploadeditors.tsx:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L114)

***

### render()

> **render**(): `any`

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`render`](FileUploadEditor.md#render)

#### Defined in

[src/ui/widgets/widget.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L167)

***

### renderContents()

> `protected` **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`renderContents`](FileUploadEditor.md#rendercontents)

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

[`FileUploadEditor`](FileUploadEditor.md).[`set_readOnly`](FileUploadEditor.md#set_readonly)

#### Defined in

[src/ui/editors/uploadeditors.tsx:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L143)

***

### set\_required()

> **set\_required**(`value`): `void`

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`set_required`](FileUploadEditor.md#set_required)

#### Defined in

[src/ui/editors/uploadeditors.tsx:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L169)

***

### set\_value()

> **set\_value**(`value`): `void`

#### Parameters

##### value

[`UploadedFile`](../interfaces/UploadedFile.md)

#### Returns

`void`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`set_value`](FileUploadEditor.md#set_value)

#### Defined in

[src/ui/editors/uploadeditors.tsx:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L185)

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

[`FileUploadEditor`](FileUploadEditor.md).[`setEditValue`](FileUploadEditor.md#seteditvalue)

#### Defined in

[src/ui/editors/uploadeditors.tsx:228](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L228)

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

[`FileUploadEditor`](FileUploadEditor.md).[`syncOrAsyncThen`](FileUploadEditor.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L211)

***

### updateInterface()

> `protected` **updateInterface**(): `void`

#### Returns

`void`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`updateInterface`](FileUploadEditor.md#updateinterface)

#### Defined in

[src/ui/editors/uploadeditors.tsx:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L131)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`useIdPrefix`](FileUploadEditor.md#useidprefix)

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

[`FileUploadEditor`](FileUploadEditor.md).[`create`](FileUploadEditor.md#create)

#### Defined in

[src/ui/widgets/widget.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L130)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`createDefaultElement`](FileUploadEditor.md#createdefaultelement)

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

[`FileUploadEditor`](FileUploadEditor.md).[`getWidgetName`](FileUploadEditor.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
