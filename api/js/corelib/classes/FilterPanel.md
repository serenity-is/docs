[serenity-is/corelib](../README.md) / FilterPanel

# Class: FilterPanel\<P\>

Defined in: [src/ui/filtering/filterpanel.tsx:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L69)

## Extends

- [`FilterWidgetBase`](FilterWidgetBase.md)\<`P`\>

## Type Parameters

### P

`P` = \{ \}

## Constructors

### Constructor

> **new FilterPanel**\<`P`\>(`props`): `FilterPanel`\<`P`\>

Defined in: [src/ui/filtering/filterpanel.tsx:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L76)

#### Parameters

##### props

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Returns

`FilterPanel`\<`P`\>

#### Overrides

[`FilterWidgetBase`](FilterWidgetBase.md).[`constructor`](FilterWidgetBase.md#constructor)

## Properties

### domNode

> `readonly` **domNode**: `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L14)

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`domNode`](FilterWidgetBase.md#domnode)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L13)

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`idPrefix`](FilterWidgetBase.md#idprefix)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L11)

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`options`](FilterWidgetBase.md#options)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`uniqueName`](FilterWidgetBase.md#uniquename)

***

### updateStoreOnReset

> **updateStoreOnReset**: `boolean`

Defined in: [src/ui/filtering/filterpanel.tsx:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L157)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/filtering/filterpanel.tsx:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L70)

#### Overrides

[`FilterWidgetBase`](FilterWidgetBase.md).[`[typeInfo]`](FilterWidgetBase.md#typeinfo)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L219)

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`isComponent`](FilterWidgetBase.md#iscomponent)

## Accessors

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L59)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`element`](FilterWidgetBase.md#element)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L203)

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`props`](FilterWidgetBase.md#props)

***

### showInitialLine

#### Get Signature

> **get** **showInitialLine**(): `boolean`

Defined in: [src/ui/filtering/filterpanel.tsx:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L86)

##### Returns

`boolean`

#### Set Signature

> **set** **showInitialLine**(`value`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L90)

##### Parameters

###### value

`boolean`

##### Returns

`void`

***

### showSearchButton

#### Get Signature

> **get** **showSearchButton**(): `boolean`

Defined in: [src/ui/filtering/filterpanel.tsx:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L146)

##### Returns

`boolean`

#### Set Signature

> **set** **showSearchButton**(`value`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L150)

##### Parameters

###### value

`boolean`

##### Returns

`void`

## Methods

### addButtonClick()

> `protected` **addButtonClick**(`e`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:241](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L241)

#### Parameters

##### e

`Event`

#### Returns

`void`

***

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

#### Returns

`void`

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`addCssClass`](FilterWidgetBase.md#addcssclass)

***

### addEmptyRow()

> `protected` **addEmptyRow**(`popupField`): `HTMLElement`

Defined in: [src/ui/filtering/filterpanel.tsx:280](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L280)

#### Parameters

##### popupField

`boolean`

#### Returns

`HTMLElement`

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`addValidationRule`](FilterWidgetBase.md#addvalidationrule)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`addValidationRule`](FilterWidgetBase.md#addvalidationrule)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`afterRender`](FilterWidgetBase.md#afterrender)

***

### andOrClick()

> `protected` **andOrClick**(`e`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:447](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L447)

#### Parameters

##### e

`Event`

#### Returns

`void`

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`byId`](FilterWidgetBase.md#byid)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`change`](FilterWidgetBase.md#change)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`changeSelect2`](FilterWidgetBase.md#changeselect2)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

#### Returns

`boolean`

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`deferRender`](FilterWidgetBase.md#deferrender)

***

### deleteRowClick()

> `protected` **deleteRowClick**(`e`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:429](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L429)

#### Parameters

##### e

`Event`

#### Returns

`void`

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/filtering/filterwidgetbase.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L20)

#### Returns

`void`

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`destroy`](FilterWidgetBase.md#destroy)

***

### filterStoreChanged()

> `protected` **filterStoreChanged**(): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L99)

#### Returns

`void`

#### Overrides

[`FilterWidgetBase`](FilterWidgetBase.md).[`filterStoreChanged`](FilterWidgetBase.md#filterstorechanged)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`findById`](FilterWidgetBase.md#findbyid)

***

### findEmptyRow()

> `protected` **findEmptyRow**(): `HTMLElement`

Defined in: [src/ui/filtering/filterpanel.tsx:263](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L263)

#### Returns

`HTMLElement`

***

### get\_hasErrors()

> **get\_hasErrors**(): `boolean`

Defined in: [src/ui/filtering/filterpanel.tsx:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L182)

#### Returns

`boolean`

***

### get\_store()

> **get\_store**(): [`FilterStore`](FilterStore.md)

Defined in: [src/ui/filtering/filterwidgetbase.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L34)

#### Returns

[`FilterStore`](FilterStore.md)

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`get_store`](FilterWidgetBase.md#get_store)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

#### Returns

`string`

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`getCssClass`](FilterWidgetBase.md#getcssclass)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`getCustomAttribute`](FilterWidgetBase.md#getcustomattribute)

***

### getFieldFor()

> `protected` **getFieldFor**(`row`): [`PropertyItem`](../interfaces/PropertyItem.md)

Defined in: [src/ui/filtering/filterpanel.tsx:353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L353)

#### Parameters

##### row

`HTMLElement`

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

***

### getFilteringFor()

> `protected` **getFilteringFor**(`row`): [`IFiltering`](IFiltering.md)

Defined in: [src/ui/filtering/filterpanel.tsx:366](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L366)

#### Parameters

##### row

`HTMLElement`

#### Returns

[`IFiltering`](IFiltering.md)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

#### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`getGridField`](FilterWidgetBase.md#getgridfield)

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

#### Returns

`this`

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`init`](FilterWidgetBase.md#init)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L173)

#### Returns

`void`

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`internalRenderContents`](FilterWidgetBase.md#internalrendercontents)

***

### leftRightParenClick()

> `protected` **leftRightParenClick**(`e`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:454](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L454)

#### Parameters

##### e

`Event`

#### Returns

`void`

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L190)

#### Returns

`boolean`

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`legacyTemplateRender`](FilterWidgetBase.md#legacytemplaterender)

***

### onRowFieldChange()

> `protected` **onRowFieldChange**(`e`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:318](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L318)

#### Parameters

##### e

`Event`

#### Returns

`void`

***

### onRowOperatorChange()

> `protected` **onRowOperatorChange**(`e`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:389](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L389)

#### Parameters

##### e

`Event`

#### Returns

`void`

***

### populateOperatorList()

> `protected` **populateOperatorList**(`row`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:338](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L338)

#### Parameters

##### row

`HTMLElement`

#### Returns

`void`

***

### removeFiltering()

> `protected` **removeFiltering**(`row`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:333](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L333)

#### Parameters

##### row

`HTMLElement`

#### Returns

`void`

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`render`](FilterWidgetBase.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/filtering/filterpanel.tsx:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L159)

#### Returns

`any`

#### Overrides

[`FilterWidgetBase`](FilterWidgetBase.md).[`renderContents`](FilterWidgetBase.md#rendercontents)

***

### resetButtonClick()

> `protected` **resetButtonClick**(`e`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L246)

#### Parameters

##### e

`Event`

#### Returns

`void`

***

### rowFieldChange()

> `protected` **rowFieldChange**(`row`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:324](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L324)

#### Parameters

##### row

`HTMLElement`

#### Returns

`void`

***

### rowOperatorChange()

> `protected` **rowOperatorChange**(`row`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:400](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L400)

#### Parameters

##### row

`HTMLElement`

#### Returns

`void`

***

### search()

> **search**(): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L186)

#### Returns

`void`

***

### searchButtonClick()

> `protected` **searchButtonClick**(`e`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L177)

#### Parameters

##### e

`Event`

#### Returns

`void`

***

### set\_store()

> **set\_store**(`value`): `void`

Defined in: [src/ui/filtering/filterwidgetbase.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L38)

#### Parameters

##### value

[`FilterStore`](FilterStore.md)

#### Returns

`void`

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`set_store`](FilterWidgetBase.md#set_store)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`syncOrAsyncThen`](FilterWidgetBase.md#syncorasyncthen)

***

### updateButtons()

> `protected` **updateButtons**(): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:442](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L442)

#### Returns

`void`

***

### updateParens()

> `protected` **updateParens**(): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:460](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L460)

#### Returns

`void`

***

### updateRowsFromStore()

> **updateRowsFromStore**(): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L104)

#### Returns

`void`

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L214)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`useIdPrefix`](FilterWidgetBase.md#useidprefix)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`create`](FilterWidgetBase.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L52)

#### Returns

`HTMLElement`

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`createDefaultElement`](FilterWidgetBase.md#createdefaultelement)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`getWidgetName`](FilterWidgetBase.md#getwidgetname)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`registerClass`](FilterWidgetBase.md#registerclass)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`registerEditor`](FilterWidgetBase.md#registereditor)
