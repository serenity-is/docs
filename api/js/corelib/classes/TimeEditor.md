[@serenity-is/corelib](../README.md) / TimeEditor

# Class: TimeEditor\<P\>

Note that this editor's value is number of minutes, e.g. for
16:30, value will be 990. If you want to use a TimeSpan field
use TimeSpanEditor instead.

## Extends

- [`TimeEditorBase`](TimeEditorBase.md)\<`P`\>

## Type Parameters

• **P** *extends* [`TimeEditorOptions`](../interfaces/TimeEditorOptions.md) = [`TimeEditorOptions`](../interfaces/TimeEditorOptions.md)

## Constructors

### new TimeEditor()

> **new TimeEditor**\<`P`\>(`props`): [`TimeEditor`](TimeEditor.md)\<`P`\>

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

#### Returns

[`TimeEditor`](TimeEditor.md)\<`P`\>

#### Overrides

[`TimeEditorBase`](TimeEditorBase.md).[`constructor`](TimeEditorBase.md#constructors)

#### Defined in

[src/ui/editors/timeeditor.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L106)

## Properties

### domNode

> `readonly` **domNode**: `HTMLSelectElement`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`domNode`](TimeEditorBase.md#domnode)

#### Defined in

[src/ui/editors/timeeditor.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L17)

***

### idPrefix

> `readonly` **idPrefix**: `string`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`idPrefix`](TimeEditorBase.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

***

### minutes

> `protected` **minutes**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`minutes`](TimeEditorBase.md#minutes)

#### Defined in

[src/ui/editors/timeeditor.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L19)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>\>

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`options`](TimeEditorBase.md#options)

#### Defined in

[src/ui/widgets/widget.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L14)

***

### uniqueName

> `readonly` **uniqueName**: `string`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`uniqueName`](TimeEditorBase.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`isComponent`](TimeEditorBase.md#iscomponent)

#### Defined in

[src/ui/widgets/widget.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L223)

***

### typeInfo

> `static` **typeInfo**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity.EditorWidget"`\>

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`typeInfo`](TimeEditorBase.md#typeinfo)

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

[`TimeEditorBase`](TimeEditorBase.md).[`element`](TimeEditorBase.md#element)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

***

### hour

#### Get Signature

> **get** **hour**(): `number`

##### Returns

`number`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`hour`](TimeEditorBase.md#hour)

#### Defined in

[src/ui/editors/timeeditor.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L45)

***

### hourAndMin

#### Get Signature

> **get** **hourAndMin**(): `string`

Returns value in HH:mm format

##### Returns

`string`

#### Set Signature

> **set** **hourAndMin**(`value`): `void`

Sets value in HH:mm format

##### Parameters

###### value

`string`

##### Returns

`void`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`hourAndMin`](TimeEditorBase.md#hourandmin)

#### Defined in

[src/ui/editors/timeeditor.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L64)

***

### minute

#### Get Signature

> **get** **minute**(): `number`

##### Returns

`number`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`minute`](TimeEditorBase.md#minute)

#### Defined in

[src/ui/editors/timeeditor.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L49)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`props`](TimeEditorBase.md#props)

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

[`TimeEditorBase`](TimeEditorBase.md).[`readOnly`](TimeEditorBase.md#readonly)

#### Defined in

[src/ui/editors/editorwidget.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorwidget.ts#L23)

***

### value

#### Get Signature

> **get** **value**(): `number`

##### Returns

`number`

#### Set Signature

> **set** **value**(`value`): `void`

##### Parameters

###### value

`number`

##### Returns

`void`

#### Defined in

[src/ui/editors/timeeditor.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L112)

## Methods

### addCssClass()

> `protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`addCssClass`](TimeEditorBase.md#addcssclass)

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

[`TimeEditorBase`](TimeEditorBase.md).[`addValidationRule`](TimeEditorBase.md#addvalidationrule)

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

[`TimeEditorBase`](TimeEditorBase.md).[`addValidationRule`](TimeEditorBase.md#addvalidationrule)

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

[`TimeEditorBase`](TimeEditorBase.md).[`afterRender`](TimeEditorBase.md#afterrender)

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

[`TimeEditorBase`](TimeEditorBase.md).[`byId`](TimeEditorBase.md#byid)

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

[`TimeEditorBase`](TimeEditorBase.md).[`change`](TimeEditorBase.md#change)

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

[`TimeEditorBase`](TimeEditorBase.md).[`changeSelect2`](TimeEditorBase.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L122)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`deferRender`](TimeEditorBase.md#deferrender)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`destroy`](TimeEditorBase.md#destroy)

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

[`TimeEditorBase`](TimeEditorBase.md).[`findById`](TimeEditorBase.md#findbyid)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`get_readOnly`](TimeEditorBase.md#get_readonly)

#### Defined in

[src/ui/editors/timeeditor.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L53)

***

### get\_value()

> `protected` **get\_value**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/editors/timeeditor.ts:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L121)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`getCssClass`](TimeEditorBase.md#getcssclass)

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

[`TimeEditorBase`](TimeEditorBase.md).[`getCustomAttribute`](TimeEditorBase.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`getGridField`](TimeEditorBase.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L114)

***

### init()

> **init**(): `this`

#### Returns

`this`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`init`](TimeEditorBase.md#init)

#### Defined in

[src/ui/widgets/widget.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L157)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`internalRenderContents`](TimeEditorBase.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L177)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`legacyTemplateRender`](TimeEditorBase.md#legacytemplaterender)

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

[`TimeEditorBase`](TimeEditorBase.md).[`render`](TimeEditorBase.md#render)

#### Defined in

[src/ui/widgets/widget.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L167)

***

### renderContents()

> `protected` **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`renderContents`](TimeEditorBase.md#rendercontents)

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

[`TimeEditorBase`](TimeEditorBase.md).[`set_readOnly`](TimeEditorBase.md#set_readonly)

#### Defined in

[src/ui/editors/timeeditor.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L57)

***

### set\_value()

> `protected` **set\_value**(`value`): `void`

#### Parameters

##### value

`number`

#### Returns

`void`

#### Defined in

[src/ui/editors/timeeditor.ts:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L144)

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

[`TimeEditorBase`](TimeEditorBase.md).[`syncOrAsyncThen`](TimeEditorBase.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L211)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`useIdPrefix`](TimeEditorBase.md#useidprefix)

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

[`TimeEditorBase`](TimeEditorBase.md).[`create`](TimeEditorBase.md#create)

#### Defined in

[src/ui/widgets/widget.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L130)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`createDefaultElement`](TimeEditorBase.md#createdefaultelement)

#### Defined in

[src/ui/editors/timeeditor.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L16)

***

### getWidgetName()

> `static` **getWidgetName**(`type`): `string`

#### Parameters

##### type

`Function`

#### Returns

`string`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`getWidgetName`](TimeEditorBase.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
