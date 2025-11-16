[corelib](../README.md) / ImageUploadEditor

# Class: ImageUploadEditor\<P\>

Defined in: [src/ui/editors/uploadeditors.tsx:258](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L258)

## Extends

- [`FileUploadEditor`](FileUploadEditor.md)\<`P`\>

## Type Parameters

### P

`P` *extends* [`ImageUploadEditorOptions`](../interfaces/ImageUploadEditorOptions.md) = [`ImageUploadEditorOptions`](../interfaces/ImageUploadEditorOptions.md)

## Constructors

### Constructor

> **new ImageUploadEditor**\<`P`\>(`props`): `ImageUploadEditor`\<`P`\>

Defined in: [src/ui/editors/uploadeditors.tsx:261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L261)

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

#### Returns

`ImageUploadEditor`\<`P`\>

#### Overrides

[`FileUploadEditor`](FileUploadEditor.md).[`constructor`](FileUploadEditor.md#constructor)

## Properties

### domNode

> `readonly` **domNode**: `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L14)

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`domNode`](FileUploadEditor.md#domnode)

***

### entity

> `protected` **entity**: [`UploadedFile`](../interfaces/UploadedFile.md)

Defined in: [src/ui/editors/uploadeditors.tsx:250](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L250)

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`entity`](FileUploadEditor.md#entity)

***

### fileSymbols

> `protected` **fileSymbols**: `HTMLElement`

Defined in: [src/ui/editors/uploadeditors.tsx:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L253)

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`fileSymbols`](FileUploadEditor.md#filesymbols)

***

### hiddenInput

> `protected` **hiddenInput**: `HTMLInputElement`

Defined in: [src/ui/editors/uploadeditors.tsx:255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L255)

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`hiddenInput`](FileUploadEditor.md#hiddeninput)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L13)

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`idPrefix`](FileUploadEditor.md#idprefix)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>\>

Defined in: [src/ui/widgets/widget.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L11)

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`options`](FileUploadEditor.md#options)

***

### progress

> `protected` **progress**: `HTMLElement`

Defined in: [src/ui/editors/uploadeditors.tsx:252](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L252)

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`progress`](FileUploadEditor.md#progress)

***

### toolbar

> `protected` **toolbar**: [`Toolbar`](Toolbar.md)

Defined in: [src/ui/editors/uploadeditors.tsx:251](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L251)

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`toolbar`](FileUploadEditor.md#toolbar)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`uniqueName`](FileUploadEditor.md#uniquename)

***

### uploadInput

> `protected` **uploadInput**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/editors/uploadeditors.tsx:254](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L254)

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`uploadInput`](FileUploadEditor.md#uploadinput)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/editors/uploadeditors.tsx:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L259)

#### Overrides

[`FileUploadEditor`](FileUploadEditor.md).[`[typeInfo]`](FileUploadEditor.md#typeinfo)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L219)

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`isComponent`](FileUploadEditor.md#iscomponent)

## Accessors

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L59)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`element`](FileUploadEditor.md#element)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L203)

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`props`](FileUploadEditor.md#props)

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

[`FileUploadEditor`](FileUploadEditor.md).[`readOnly`](FileUploadEditor.md#readonly)

***

### value

#### Get Signature

> **get** **value**(): [`UploadedFile`](../interfaces/UploadedFile.md)

Defined in: [src/ui/editors/uploadeditors.tsx:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L180)

##### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)

#### Set Signature

> **set** **value**(`v`): `void`

Defined in: [src/ui/editors/uploadeditors.tsx:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L219)

##### Parameters

###### v

[`UploadedFile`](../interfaces/UploadedFile.md)

##### Returns

`void`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`value`](FileUploadEditor.md#value)

## Methods

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

#### Returns

`void`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`addCssClass`](FileUploadEditor.md#addcssclass)

***

### addFileButtonText()

> `protected` **addFileButtonText**(): `string`

Defined in: [src/ui/editors/uploadeditors.tsx:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L84)

#### Returns

`string`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`addFileButtonText`](FileUploadEditor.md#addfilebuttontext)

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

[`FileUploadEditor`](FileUploadEditor.md).[`addValidationRule`](FileUploadEditor.md#addvalidationrule)

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

[`FileUploadEditor`](FileUploadEditor.md).[`addValidationRule`](FileUploadEditor.md#addvalidationrule)

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

[`FileUploadEditor`](FileUploadEditor.md).[`afterRender`](FileUploadEditor.md#afterrender)

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

[`FileUploadEditor`](FileUploadEditor.md).[`byId`](FileUploadEditor.md#byid)

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

[`FileUploadEditor`](FileUploadEditor.md).[`change`](FileUploadEditor.md#change)

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

[`FileUploadEditor`](FileUploadEditor.md).[`changeSelect2`](FileUploadEditor.md#changeselect2)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

#### Returns

`boolean`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`deferRender`](FileUploadEditor.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/widgets/widget.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L42)

#### Returns

`void`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`destroy`](FileUploadEditor.md#destroy)

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

[`FileUploadEditor`](FileUploadEditor.md).[`findById`](FileUploadEditor.md#findbyid)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/ui/editors/uploadeditors.tsx:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L138)

#### Returns

`boolean`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`get_readOnly`](FileUploadEditor.md#get_readonly)

***

### get\_required()

> **get\_required**(): `boolean`

Defined in: [src/ui/editors/uploadeditors.tsx:164](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L164)

#### Returns

`boolean`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`get_required`](FileUploadEditor.md#get_required)

***

### get\_value()

> **get\_value**(): [`UploadedFile`](../interfaces/UploadedFile.md)

Defined in: [src/ui/editors/uploadeditors.tsx:172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L172)

#### Returns

[`UploadedFile`](../interfaces/UploadedFile.md)

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`get_value`](FileUploadEditor.md#get_value)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

#### Returns

`string`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`getCssClass`](FileUploadEditor.md#getcssclass)

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

[`FileUploadEditor`](FileUploadEditor.md).[`getCustomAttribute`](FileUploadEditor.md#getcustomattribute)

***

### getEditValue()

> **getEditValue**(`property`, `target`): `void`

Defined in: [src/ui/editors/uploadeditors.tsx:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L223)

#### Parameters

##### property

[`PropertyItem`](../interfaces/PropertyItem.md)

##### target

`any`

#### Returns

`void`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`getEditValue`](FileUploadEditor.md#geteditvalue)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

#### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`getGridField`](FileUploadEditor.md#getgridfield)

***

### getToolButtons()

> `protected` **getToolButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

Defined in: [src/ui/editors/uploadeditors.tsx:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L88)

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`getToolButtons`](FileUploadEditor.md#gettoolbuttons)

***

### getUploadInputOptions()

> `protected` **getUploadInputOptions**(): [`UploadInputOptions`](../interfaces/UploadInputOptions.md)

Defined in: [src/ui/editors/uploadeditors.tsx:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L57)

#### Returns

[`UploadInputOptions`](../interfaces/UploadInputOptions.md)

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`getUploadInputOptions`](FileUploadEditor.md#getuploadinputoptions)

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

#### Returns

`this`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`init`](FileUploadEditor.md#init)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L173)

#### Returns

`void`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`internalRenderContents`](FileUploadEditor.md#internalrendercontents)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L190)

#### Returns

`boolean`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`legacyTemplateRender`](FileUploadEditor.md#legacytemplaterender)

***

### populate()

> `protected` **populate**(): `void`

Defined in: [src/ui/editors/uploadeditors.tsx:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L113)

#### Returns

`void`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`populate`](FileUploadEditor.md#populate)

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

[`FileUploadEditor`](FileUploadEditor.md).[`render`](FileUploadEditor.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

#### Returns

`any`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`renderContents`](FileUploadEditor.md#rendercontents)

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

Defined in: [src/ui/editors/uploadeditors.tsx:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L142)

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`set_readOnly`](FileUploadEditor.md#set_readonly)

***

### set\_required()

> **set\_required**(`value`): `void`

Defined in: [src/ui/editors/uploadeditors.tsx:168](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L168)

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`set_required`](FileUploadEditor.md#set_required)

***

### set\_value()

> **set\_value**(`value`): `void`

Defined in: [src/ui/editors/uploadeditors.tsx:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L184)

#### Parameters

##### value

[`UploadedFile`](../interfaces/UploadedFile.md)

#### Returns

`void`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`set_value`](FileUploadEditor.md#set_value)

***

### setEditValue()

> **setEditValue**(`source`, `property`): `void`

Defined in: [src/ui/editors/uploadeditors.tsx:227](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L227)

#### Parameters

##### source

`any`

##### property

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

`void`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`setEditValue`](FileUploadEditor.md#seteditvalue)

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

[`FileUploadEditor`](FileUploadEditor.md).[`syncOrAsyncThen`](FileUploadEditor.md#syncorasyncthen)

***

### updateInterface()

> `protected` **updateInterface**(): `void`

Defined in: [src/ui/editors/uploadeditors.tsx:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L130)

#### Returns

`void`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`updateInterface`](FileUploadEditor.md#updateinterface)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L214)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`useIdPrefix`](FileUploadEditor.md#useidprefix)

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

[`FileUploadEditor`](FileUploadEditor.md).[`create`](FileUploadEditor.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L52)

#### Returns

`HTMLElement`

#### Inherited from

[`FileUploadEditor`](FileUploadEditor.md).[`createDefaultElement`](FileUploadEditor.md#createdefaultelement)

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

[`FileUploadEditor`](FileUploadEditor.md).[`getWidgetName`](FileUploadEditor.md#getwidgetname)

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

[`FileUploadEditor`](FileUploadEditor.md).[`registerClass`](FileUploadEditor.md#registerclass)

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

[`FileUploadEditor`](FileUploadEditor.md).[`registerEditor`](FileUploadEditor.md#registereditor)
