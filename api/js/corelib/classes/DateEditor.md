[corelib](../README.md) / DateEditor

# Class: DateEditor\<P\>

Defined in: [src/ui/editors/dateeditor.tsx:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L14)

## Extends

- [`EditorWidget`](EditorWidget.md)\<`P`\>

## Type Parameters

### P

`P` *extends* [`DateEditorOptions`](../interfaces/DateEditorOptions.md) = [`DateEditorOptions`](../interfaces/DateEditorOptions.md)

## Implements

- [`IStringValue`](IStringValue.md)
- [`IReadOnly`](IReadOnly.md)

## Constructors

### Constructor

> **new DateEditor**\<`P`\>(`props`): `DateEditor`\<`P`\>

Defined in: [src/ui/editors/dateeditor.tsx:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L20)

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

#### Returns

`DateEditor`\<`P`\>

#### Overrides

[`EditorWidget`](EditorWidget.md).[`constructor`](EditorWidget.md#constructor)

## Properties

### domNode

> `readonly` **domNode**: `HTMLInputElement`

Defined in: [src/ui/editors/dateeditor.tsx:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L18)

#### Overrides

[`EditorWidget`](EditorWidget.md).[`domNode`](EditorWidget.md#domnode)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L13)

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`idPrefix`](EditorWidget.md#idprefix)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>\>

Defined in: [src/ui/widgets/widget.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L11)

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`options`](EditorWidget.md#options)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`uniqueName`](EditorWidget.md#uniquename)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/editors/dateeditor.tsx:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L15)

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`[typeInfo]`](IReadOnly.md#typeinfo)

#### Overrides

[`EditorWidget`](EditorWidget.md).[`[typeInfo]`](EditorWidget.md#typeinfo)

***

### dateInputChange()

> `static` **dateInputChange**: (`e`) => `void`

Defined in: [src/ui/editors/dateeditor.tsx:213](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L213)

#### Parameters

##### e

`Event`

#### Returns

`void`

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L219)

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`isComponent`](EditorWidget.md#iscomponent)

***

### useFlatpickr

> `static` **useFlatpickr**: `boolean`

Defined in: [src/ui/editors/dateeditor.tsx:221](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L221)

## Accessors

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L59)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`element`](EditorWidget.md#element)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L203)

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`props`](EditorWidget.md#props)

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

[`EditorWidget`](EditorWidget.md).[`readOnly`](EditorWidget.md#readonly)

***

### value

#### Get Signature

> **get** **value**(): `string`

Defined in: [src/ui/editors/dateeditor.tsx:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L110)

##### Returns

`string`

#### Set Signature

> **set** **value**(`v`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L126)

##### Parameters

###### v

`string`

##### Returns

`void`

***

### valueAsDate

#### Get Signature

> **get** **valueAsDate**(): `Date`

Defined in: [src/ui/editors/dateeditor.tsx:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L137)

##### Returns

`Date`

#### Set Signature

> **set** **valueAsDate**(`v`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L149)

##### Parameters

###### v

`Date`

##### Returns

`void`

## Methods

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

#### Returns

`void`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`addCssClass`](EditorWidget.md#addcssclass)

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

[`EditorWidget`](EditorWidget.md).[`addValidationRule`](EditorWidget.md#addvalidationrule)

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

[`EditorWidget`](EditorWidget.md).[`addValidationRule`](EditorWidget.md#addvalidationrule)

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

[`EditorWidget`](EditorWidget.md).[`afterRender`](EditorWidget.md#afterrender)

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

[`EditorWidget`](EditorWidget.md).[`byId`](EditorWidget.md#byid)

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

[`EditorWidget`](EditorWidget.md).[`change`](EditorWidget.md#change)

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

[`EditorWidget`](EditorWidget.md).[`changeSelect2`](EditorWidget.md#changeselect2)

***

### createFlatPickrTrigger()

> **createFlatPickrTrigger**(): `HTMLElement`

Defined in: [src/ui/editors/dateeditor.tsx:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L253)

#### Returns

`HTMLElement`

***

### deferRender()

> `protected` **deferRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

#### Returns

`boolean`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`deferRender`](EditorWidget.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/editors/dateeditor.tsx:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L93)

#### Returns

`void`

#### Overrides

[`EditorWidget`](EditorWidget.md).[`destroy`](EditorWidget.md#destroy)

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

[`EditorWidget`](EditorWidget.md).[`findById`](EditorWidget.md#findbyid)

***

### get\_maxDate()

> **get\_maxDate**(): `Date`

Defined in: [src/ui/editors/dateeditor.tsx:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L190)

#### Returns

`Date`

***

### get\_maxValue()

> **get\_maxValue**(): `string`

Defined in: [src/ui/editors/dateeditor.tsx:174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L174)

#### Returns

`string`

***

### get\_minDate()

> **get\_minDate**(): `Date`

Defined in: [src/ui/editors/dateeditor.tsx:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L182)

#### Returns

`Date`

***

### get\_minValue()

> **get\_minValue**(): `string`

Defined in: [src/ui/editors/dateeditor.tsx:166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L166)

#### Returns

`string`

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/ui/editors/dateeditor.tsx:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L153)

#### Returns

`boolean`

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`get_readOnly`](IReadOnly.md#get_readonly)

***

### get\_sqlMinMax()

> **get\_sqlMinMax**(): `boolean`

Defined in: [src/ui/editors/dateeditor.tsx:198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L198)

#### Returns

`boolean`

***

### get\_value()

> **get\_value**(): `string`

Defined in: [src/ui/editors/dateeditor.tsx:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L101)

#### Returns

`string`

#### Implementation of

[`IStringValue`](IStringValue.md).[`get_value`](IStringValue.md#get_value)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

#### Returns

`string`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`getCssClass`](EditorWidget.md#getcssclass)

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

[`EditorWidget`](EditorWidget.md).[`getCustomAttribute`](EditorWidget.md#getcustomattribute)

***

### getFlatpickrOptions()

> **getFlatpickrOptions**(`input`): `any`

Defined in: [src/ui/editors/dateeditor.tsx:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L223)

#### Parameters

##### input

`HTMLElement`

#### Returns

`any`

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

#### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`getGridField`](EditorWidget.md#getgridfield)

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

#### Returns

`this`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`init`](EditorWidget.md#init)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L173)

#### Returns

`void`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`internalRenderContents`](EditorWidget.md#internalrendercontents)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L190)

#### Returns

`boolean`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`legacyTemplateRender`](EditorWidget.md#legacytemplaterender)

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

[`EditorWidget`](EditorWidget.md).[`render`](EditorWidget.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

#### Returns

`any`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`renderContents`](EditorWidget.md#rendercontents)

***

### set\_maxDate()

> **set\_maxDate**(`value`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L194)

#### Parameters

##### value

`Date`

#### Returns

`void`

***

### set\_maxValue()

> **set\_maxValue**(`value`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L178)

#### Parameters

##### value

`string`

#### Returns

`void`

***

### set\_minDate()

> **set\_minDate**(`value`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L186)

#### Parameters

##### value

`Date`

#### Returns

`void`

***

### set\_minValue()

> **set\_minValue**(`value`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L170)

#### Parameters

##### value

`string`

#### Returns

`void`

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L157)

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`set_readOnly`](IReadOnly.md#set_readonly)

***

### set\_sqlMinMax()

> **set\_sqlMinMax**(`value`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L202)

#### Parameters

##### value

`boolean`

#### Returns

`void`

***

### set\_value()

> **set\_value**(`value`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L114)

#### Parameters

##### value

`string`

#### Returns

`void`

#### Implementation of

[`IStringValue`](IStringValue.md).[`set_value`](IStringValue.md#set_value)

***

### setToToday()

> **setToToday**(`triggerChange?`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L88)

#### Parameters

##### triggerChange?

`boolean`

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

[`EditorWidget`](EditorWidget.md).[`syncOrAsyncThen`](EditorWidget.md#syncorasyncthen)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L214)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`useIdPrefix`](EditorWidget.md#useidprefix)

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

[`EditorWidget`](EditorWidget.md).[`create`](EditorWidget.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLInputElement`

Defined in: [src/ui/editors/dateeditor.tsx:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L17)

#### Returns

`HTMLInputElement`

#### Overrides

[`EditorWidget`](EditorWidget.md).[`createDefaultElement`](EditorWidget.md#createdefaultelement)

***

### dateInputKeyup()

> `static` **dateInputKeyup**(`e`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:217](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L217)

#### Parameters

##### e

`KeyboardEvent`

#### Returns

`void`

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

[`EditorWidget`](EditorWidget.md).[`getWidgetName`](EditorWidget.md#getwidgetname)

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

[`EditorWidget`](EditorWidget.md).[`registerClass`](EditorWidget.md#registerclass)

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

[`EditorWidget`](EditorWidget.md).[`registerEditor`](EditorWidget.md#registereditor)

***

### uiPickerZIndexWorkaround()

> `static` **uiPickerZIndexWorkaround**(`el`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L259)

#### Parameters

##### el

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

#### Returns

`void`
