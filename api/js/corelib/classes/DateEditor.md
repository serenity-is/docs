[@serenity-is/corelib](../README.md) / DateEditor

# Class: DateEditor\<P\>

## Extends

- [`EditorWidget`](EditorWidget.md)\<`P`\>

## Type Parameters

• **P** *extends* [`DateEditorOptions`](../interfaces/DateEditorOptions.md) = [`DateEditorOptions`](../interfaces/DateEditorOptions.md)

## Implements

- [`IStringValue`](IStringValue.md)
- [`IReadOnly`](IReadOnly.md)

## Constructors

### new DateEditor()

> **new DateEditor**\<`P`\>(`props`): [`DateEditor`](DateEditor.md)\<`P`\>

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

#### Returns

[`DateEditor`](DateEditor.md)\<`P`\>

#### Overrides

[`EditorWidget`](EditorWidget.md).[`constructor`](EditorWidget.md#constructors)

#### Defined in

[src/ui/editors/dateeditor.tsx:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L21)

## Properties

### domNode

> `readonly` **domNode**: `HTMLInputElement`

#### Overrides

[`EditorWidget`](EditorWidget.md).[`domNode`](EditorWidget.md#domnode)

#### Defined in

[src/ui/editors/dateeditor.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L19)

***

### idPrefix

> `readonly` **idPrefix**: `string`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`idPrefix`](EditorWidget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>\>

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`options`](EditorWidget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L14)

***

### uniqueName

> `readonly` **uniqueName**: `string`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`uniqueName`](EditorWidget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

***

### dateInputChange()

> `static` **dateInputChange**: (`e`) => `void`

#### Parameters

##### e

`Event`

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.tsx:213](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L213)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`isComponent`](EditorWidget.md#iscomponent)

#### Defined in

[src/ui/widgets/widget.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L223)

***

### typeInfo

> `static` **typeInfo**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity.EditorWidget"`\>

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`typeInfo`](EditorWidget.md#typeinfo)

#### Defined in

[src/ui/editors/editorwidget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorwidget.ts#L17)

***

### useFlatpickr

> `static` **useFlatpickr**: `boolean`

#### Defined in

[src/ui/editors/dateeditor.tsx:221](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L221)

## Accessors

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`element`](EditorWidget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`props`](EditorWidget.md#props)

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

[`EditorWidget`](EditorWidget.md).[`readOnly`](EditorWidget.md#readonly)

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

#### Defined in

[src/ui/editors/dateeditor.tsx:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L110)

***

### valueAsDate

#### Get Signature

> **get** **valueAsDate**(): `Date`

##### Returns

`Date`

#### Set Signature

> **set** **valueAsDate**(`v`): `void`

##### Parameters

###### v

`Date`

##### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.tsx:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L137)

## Methods

### addCssClass()

> `protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`addCssClass`](EditorWidget.md#addcssclass)

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

[`EditorWidget`](EditorWidget.md).[`addValidationRule`](EditorWidget.md#addvalidationrule)

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

[`EditorWidget`](EditorWidget.md).[`addValidationRule`](EditorWidget.md#addvalidationrule)

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

[`EditorWidget`](EditorWidget.md).[`afterRender`](EditorWidget.md#afterrender)

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

[`EditorWidget`](EditorWidget.md).[`byId`](EditorWidget.md#byid)

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

[`EditorWidget`](EditorWidget.md).[`change`](EditorWidget.md#change)

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

[`EditorWidget`](EditorWidget.md).[`changeSelect2`](EditorWidget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L122)

***

### createFlatPickrTrigger()

> **createFlatPickrTrigger**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[src/ui/editors/dateeditor.tsx:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L253)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`deferRender`](EditorWidget.md#deferrender)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Overrides

[`EditorWidget`](EditorWidget.md).[`destroy`](EditorWidget.md#destroy)

#### Defined in

[src/ui/editors/dateeditor.tsx:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L94)

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

[`EditorWidget`](EditorWidget.md).[`findById`](EditorWidget.md#findbyid)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

***

### get\_maxDate()

> **get\_maxDate**(): `Date`

#### Returns

`Date`

#### Defined in

[src/ui/editors/dateeditor.tsx:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L190)

***

### get\_maxValue()

> **get\_maxValue**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/dateeditor.tsx:174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L174)

***

### get\_minDate()

> **get\_minDate**(): `Date`

#### Returns

`Date`

#### Defined in

[src/ui/editors/dateeditor.tsx:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L182)

***

### get\_minValue()

> **get\_minValue**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/dateeditor.tsx:166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L166)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`get_readOnly`](IReadOnly.md#get_readonly)

#### Defined in

[src/ui/editors/dateeditor.tsx:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L153)

***

### get\_sqlMinMax()

> **get\_sqlMinMax**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/dateeditor.tsx:198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L198)

***

### get\_value()

> **get\_value**(): `string`

#### Returns

`string`

#### Implementation of

[`IStringValue`](IStringValue.md).[`get_value`](IStringValue.md#get_value)

#### Defined in

[src/ui/editors/dateeditor.tsx:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L101)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`getCssClass`](EditorWidget.md#getcssclass)

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

[`EditorWidget`](EditorWidget.md).[`getCustomAttribute`](EditorWidget.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

***

### getFlatpickrOptions()

> **getFlatpickrOptions**(`input`): `any`

#### Parameters

##### input

`HTMLElement`

#### Returns

`any`

#### Defined in

[src/ui/editors/dateeditor.tsx:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L223)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`getGridField`](EditorWidget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L114)

***

### init()

> **init**(): `this`

#### Returns

`this`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`init`](EditorWidget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L157)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`internalRenderContents`](EditorWidget.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L177)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`legacyTemplateRender`](EditorWidget.md#legacytemplaterender)

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

[`EditorWidget`](EditorWidget.md).[`render`](EditorWidget.md#render)

#### Defined in

[src/ui/widgets/widget.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L167)

***

### renderContents()

> `protected` **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`renderContents`](EditorWidget.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L188)

***

### set\_maxDate()

> **set\_maxDate**(`value`): `void`

#### Parameters

##### value

`Date`

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.tsx:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L194)

***

### set\_maxValue()

> **set\_maxValue**(`value`): `void`

#### Parameters

##### value

`string`

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.tsx:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L178)

***

### set\_minDate()

> **set\_minDate**(`value`): `void`

#### Parameters

##### value

`Date`

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.tsx:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L186)

***

### set\_minValue()

> **set\_minValue**(`value`): `void`

#### Parameters

##### value

`string`

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.tsx:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L170)

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`set_readOnly`](IReadOnly.md#set_readonly)

#### Defined in

[src/ui/editors/dateeditor.tsx:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L157)

***

### set\_sqlMinMax()

> **set\_sqlMinMax**(`value`): `void`

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.tsx:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L202)

***

### set\_value()

> **set\_value**(`value`): `void`

#### Parameters

##### value

`string`

#### Returns

`void`

#### Implementation of

[`IStringValue`](IStringValue.md).[`set_value`](IStringValue.md#set_value)

#### Defined in

[src/ui/editors/dateeditor.tsx:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L114)

***

### setToToday()

> **setToToday**(`triggerChange`?): `void`

#### Parameters

##### triggerChange?

`boolean`

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.tsx:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L89)

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

[`EditorWidget`](EditorWidget.md).[`syncOrAsyncThen`](EditorWidget.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L211)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`useIdPrefix`](EditorWidget.md#useidprefix)

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

[`EditorWidget`](EditorWidget.md).[`create`](EditorWidget.md#create)

#### Defined in

[src/ui/widgets/widget.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L130)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLInputElement`

#### Returns

`HTMLInputElement`

#### Overrides

[`EditorWidget`](EditorWidget.md).[`createDefaultElement`](EditorWidget.md#createdefaultelement)

#### Defined in

[src/ui/editors/dateeditor.tsx:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L18)

***

### dateInputKeyup()

> `static` **dateInputKeyup**(`e`): `void`

#### Parameters

##### e

`KeyboardEvent`

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.tsx:217](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L217)

***

### getWidgetName()

> `static` **getWidgetName**(`type`): `string`

#### Parameters

##### type

`Function`

#### Returns

`string`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`getWidgetName`](EditorWidget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)

***

### uiPickerZIndexWorkaround()

> `static` **uiPickerZIndexWorkaround**(`el`): `void`

#### Parameters

##### el

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

#### Returns

`void`

#### Defined in

[src/ui/editors/dateeditor.tsx:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L259)
