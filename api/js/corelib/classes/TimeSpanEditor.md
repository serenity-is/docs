[serenity-is/corelib](../README.md) / TimeSpanEditor

# Class: TimeSpanEditor\<P\>

Defined in: [src/ui/editors/timeeditor.ts:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L155)

This editor is for TimeSpan fields. It uses a string value in the format "HH:mm".

## Extends

- [`TimeEditorBase`](TimeEditorBase.md)\<`P`\>

## Type Parameters

### P

`P` *extends* [`TimeSpanEditorOptions`](../interfaces/TimeSpanEditorOptions.md) = [`TimeSpanEditorOptions`](../interfaces/TimeSpanEditorOptions.md)

## Constructors

### Constructor

> **new TimeSpanEditor**\<`P`\>(`props`): `TimeSpanEditor`\<`P`\>

Defined in: [src/ui/editors/timeeditor.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L159)

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

#### Returns

`TimeSpanEditor`\<`P`\>

#### Overrides

[`TimeEditorBase`](TimeEditorBase.md).[`constructor`](TimeEditorBase.md#constructor)

## Properties

### domNode

> `readonly` **domNode**: `HTMLSelectElement`

Defined in: [src/ui/editors/timeeditor.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L17)

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`domNode`](TimeEditorBase.md#domnode)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L13)

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`idPrefix`](TimeEditorBase.md#idprefix)

***

### minutes

> `protected` **minutes**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/editors/timeeditor.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L19)

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`minutes`](TimeEditorBase.md#minutes)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>\>

Defined in: [src/ui/widgets/widget.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L11)

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`options`](TimeEditorBase.md#options)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`uniqueName`](TimeEditorBase.md#uniquename)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/editors/timeeditor.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L157)

#### Overrides

[`TimeEditorBase`](TimeEditorBase.md).[`[typeInfo]`](TimeEditorBase.md#typeinfo)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L219)

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`isComponent`](TimeEditorBase.md#iscomponent)

## Accessors

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L59)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`element`](TimeEditorBase.md#element)

***

### hour

#### Get Signature

> **get** **hour**(): `number`

Defined in: [src/ui/editors/timeeditor.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L45)

##### Returns

`number`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`hour`](TimeEditorBase.md#hour)

***

### hourAndMin

#### Get Signature

> **get** **hourAndMin**(): `string`

Defined in: [src/ui/editors/timeeditor.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L64)

Returns value in HH:mm format

##### Returns

`string`

#### Set Signature

> **set** **hourAndMin**(`value`): `void`

Defined in: [src/ui/editors/timeeditor.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L74)

Sets value in HH:mm format

##### Parameters

###### value

`string`

##### Returns

`void`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`hourAndMin`](TimeEditorBase.md#hourandmin)

***

### minute

#### Get Signature

> **get** **minute**(): `number`

Defined in: [src/ui/editors/timeeditor.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L49)

##### Returns

`number`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`minute`](TimeEditorBase.md#minute)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L203)

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`props`](TimeEditorBase.md#props)

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

[`TimeEditorBase`](TimeEditorBase.md).[`readOnly`](TimeEditorBase.md#readonly)

***

### value

#### Get Signature

> **get** **value**(): `string`

Defined in: [src/ui/editors/timeeditor.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L173)

##### Returns

`string`

#### Set Signature

> **set** **value**(`value`): `void`

Defined in: [src/ui/editors/timeeditor.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L177)

##### Parameters

###### value

`string`

##### Returns

`void`

## Methods

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

#### Returns

`void`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`addCssClass`](TimeEditorBase.md#addcssclass)

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

[`TimeEditorBase`](TimeEditorBase.md).[`addValidationRule`](TimeEditorBase.md#addvalidationrule)

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

[`TimeEditorBase`](TimeEditorBase.md).[`addValidationRule`](TimeEditorBase.md#addvalidationrule)

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

[`TimeEditorBase`](TimeEditorBase.md).[`afterRender`](TimeEditorBase.md#afterrender)

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

[`TimeEditorBase`](TimeEditorBase.md).[`byId`](TimeEditorBase.md#byid)

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

[`TimeEditorBase`](TimeEditorBase.md).[`change`](TimeEditorBase.md#change)

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

[`TimeEditorBase`](TimeEditorBase.md).[`changeSelect2`](TimeEditorBase.md#changeselect2)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

#### Returns

`boolean`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`deferRender`](TimeEditorBase.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/widgets/widget.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L42)

#### Returns

`void`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`destroy`](TimeEditorBase.md#destroy)

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

[`TimeEditorBase`](TimeEditorBase.md).[`findById`](TimeEditorBase.md#findbyid)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/ui/editors/timeeditor.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L53)

#### Returns

`boolean`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`get_readOnly`](TimeEditorBase.md#get_readonly)

***

### get\_value()

> `protected` **get\_value**(): `string`

Defined in: [src/ui/editors/timeeditor.ts:165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L165)

#### Returns

`string`

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

#### Returns

`string`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`getCssClass`](TimeEditorBase.md#getcssclass)

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

[`TimeEditorBase`](TimeEditorBase.md).[`getCustomAttribute`](TimeEditorBase.md#getcustomattribute)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

#### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`getGridField`](TimeEditorBase.md#getgridfield)

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

#### Returns

`this`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`init`](TimeEditorBase.md#init)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L173)

#### Returns

`void`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`internalRenderContents`](TimeEditorBase.md#internalrendercontents)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L190)

#### Returns

`boolean`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`legacyTemplateRender`](TimeEditorBase.md#legacytemplaterender)

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

[`TimeEditorBase`](TimeEditorBase.md).[`render`](TimeEditorBase.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

#### Returns

`any`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`renderContents`](TimeEditorBase.md#rendercontents)

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

Defined in: [src/ui/editors/timeeditor.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L57)

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`set_readOnly`](TimeEditorBase.md#set_readonly)

***

### set\_value()

> `protected` **set\_value**(`value`): `void`

Defined in: [src/ui/editors/timeeditor.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L169)

#### Parameters

##### value

`string`

#### Returns

`void`

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

[`TimeEditorBase`](TimeEditorBase.md).[`syncOrAsyncThen`](TimeEditorBase.md#syncorasyncthen)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L214)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`useIdPrefix`](TimeEditorBase.md#useidprefix)

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

[`TimeEditorBase`](TimeEditorBase.md).[`create`](TimeEditorBase.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLElement`

Defined in: [src/ui/editors/timeeditor.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L16)

#### Returns

`HTMLElement`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`createDefaultElement`](TimeEditorBase.md#createdefaultelement)

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

[`TimeEditorBase`](TimeEditorBase.md).[`getWidgetName`](TimeEditorBase.md#getwidgetname)

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

[`TimeEditorBase`](TimeEditorBase.md).[`registerClass`](TimeEditorBase.md#registerclass)

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

[`TimeEditorBase`](TimeEditorBase.md).[`registerEditor`](TimeEditorBase.md#registereditor)
