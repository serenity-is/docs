[@serenity-is/corelib](../README.md) / QuickFilterBar

# Class: QuickFilterBar\<P\>

## Extends

- [`Widget`](Widget.md)\<`P`\>

## Type Parameters

• **P** *extends* [`QuickFilterBarOptions`](../interfaces/QuickFilterBarOptions.md) = [`QuickFilterBarOptions`](../interfaces/QuickFilterBarOptions.md)

## Constructors

### new QuickFilterBar()

> **new QuickFilterBar**\<`P`\>(`props`): [`QuickFilterBar`](QuickFilterBar.md)\<`P`\>

#### Parameters

##### props

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Returns

[`QuickFilterBar`](QuickFilterBar.md)\<`P`\>

#### Overrides

[`Widget`](Widget.md).[`constructor`](Widget.md#constructors)

#### Defined in

[src/ui/datagrid/quickfilterbar.tsx:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L22)

## Properties

### domNode

> `readonly` **domNode**: `HTMLElement`

#### Inherited from

[`Widget`](Widget.md).[`domNode`](Widget.md#domnode)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

***

### idPrefix

> `readonly` **idPrefix**: `string`

#### Inherited from

[`Widget`](Widget.md).[`idPrefix`](Widget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

***

### onChange()

> **onChange**: (`e`) => `void`

#### Parameters

##### e

`Event`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/quickfilterbar.tsx:338](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L338)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`Widget`](Widget.md).[`options`](Widget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L14)

***

### uniqueName

> `readonly` **uniqueName**: `string`

#### Inherited from

[`Widget`](Widget.md).[`uniqueName`](Widget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

#### Inherited from

[`Widget`](Widget.md).[`isComponent`](Widget.md#iscomponent)

#### Defined in

[src/ui/widgets/widget.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L223)

***

### typeInfo

> `static` **typeInfo**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity.Widget"`\>

#### Inherited from

[`Widget`](Widget.md).[`typeInfo`](Widget.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L11)

## Accessors

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`Widget`](Widget.md).[`element`](Widget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`Widget`](Widget.md).[`props`](Widget.md#props)

#### Defined in

[src/ui/widgets/widget.ts:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L207)

## Methods

### add()

> **add**\<`TWidget`, `TOptions`\>(`opt`): `TWidget`

#### Type Parameters

• **TWidget** *extends* [`Widget`](Widget.md)\<`any`\>

• **TOptions**

#### Parameters

##### opt

[`QuickFilter`](../interfaces/QuickFilter.md)\<`TWidget`, `TOptions`\>

#### Returns

`TWidget`

#### Defined in

[src/ui/datagrid/quickfilterbar.tsx:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L40)

***

### add\_submitHandlers()

> `protected` **add\_submitHandlers**(`action`): `void`

#### Parameters

##### action

(`request`) => `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/quickfilterbar.tsx:351](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L351)

***

### addBoolean()

> **addBoolean**(`field`, `title`?, `yes`?, `no`?): [`SelectEditor`](SelectEditor.md)\<[`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>

#### Parameters

##### field

`string`

##### title?

`string`

##### yes?

`string`

##### no?

`string`

#### Returns

[`SelectEditor`](SelectEditor.md)\<[`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>

#### Defined in

[src/ui/datagrid/quickfilterbar.tsx:303](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L303)

***

### addCssClass()

> `protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[`Widget`](Widget.md).[`addCssClass`](Widget.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

***

### addDateRange()

> **addDateRange**(`field`, `title`?): [`DateEditor`](DateEditor.md)\<[`DateEditorOptions`](../interfaces/DateEditorOptions.md)\>

#### Parameters

##### field

`string`

##### title?

`string`

#### Returns

[`DateEditor`](DateEditor.md)\<[`DateEditorOptions`](../interfaces/DateEditorOptions.md)\>

#### Defined in

[src/ui/datagrid/quickfilterbar.tsx:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L143)

***

### addDateTimeRange()

> **addDateTimeRange**(`field`, `title`?): [`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Parameters

##### field

`string`

##### title?

`string`

#### Returns

[`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Defined in

[src/ui/datagrid/quickfilterbar.tsx:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L220)

***

### addSeparator()

> **addSeparator**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/quickfilterbar.tsx:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L36)

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

[`Widget`](Widget.md).[`addValidationRule`](Widget.md#addvalidationrule)

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

[`Widget`](Widget.md).[`addValidationRule`](Widget.md#addvalidationrule)

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

[`Widget`](Widget.md).[`afterRender`](Widget.md#afterrender)

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

[`Widget`](Widget.md).[`byId`](Widget.md#byid)

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

[`Widget`](Widget.md).[`change`](Widget.md#change)

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

[`Widget`](Widget.md).[`changeSelect2`](Widget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L122)

***

### clear\_submitHandlers()

> `protected` **clear\_submitHandlers**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/quickfilterbar.tsx:359](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L359)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`Widget`](Widget.md).[`deferRender`](Widget.md#deferrender)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Overrides

[`Widget`](Widget.md).[`destroy`](Widget.md#destroy)

#### Defined in

[src/ui/datagrid/quickfilterbar.tsx:342](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L342)

***

### find()

> **find**\<`TWidget`\>(`type`, `field`): `TWidget`

#### Type Parameters

• **TWidget**

#### Parameters

##### type

(...`args`) => `TWidget`

##### field

`string`

#### Returns

`TWidget`

#### Defined in

[src/ui/datagrid/quickfilterbar.tsx:362](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L362)

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

[`Widget`](Widget.md).[`findById`](Widget.md#findbyid)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[`Widget`](Widget.md).[`getCssClass`](Widget.md#getcssclass)

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

[`Widget`](Widget.md).[`getCustomAttribute`](Widget.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`Widget`](Widget.md).[`getGridField`](Widget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L114)

***

### init()

> **init**(): `this`

#### Returns

`this`

#### Inherited from

[`Widget`](Widget.md).[`init`](Widget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L157)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[`Widget`](Widget.md).[`internalRenderContents`](Widget.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L177)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`Widget`](Widget.md).[`legacyTemplateRender`](Widget.md#legacytemplaterender)

#### Defined in

[src/ui/widgets/widget.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L194)

***

### onSubmit()

> **onSubmit**(`request`): `void`

#### Parameters

##### request

[`ListRequest`](../interfaces/ListRequest.md)

#### Returns

`void`

#### Defined in

[src/ui/datagrid/quickfilterbar.tsx:347](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L347)

***

### remove\_submitHandlers()

> `protected` **remove\_submitHandlers**(`action`): `void`

#### Parameters

##### action

(`request`) => `void`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/quickfilterbar.tsx:355](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L355)

***

### render()

> **render**(): `any`

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[`Widget`](Widget.md).[`render`](Widget.md#render)

#### Defined in

[src/ui/widgets/widget.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L167)

***

### renderContents()

> `protected` **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[`Widget`](Widget.md).[`renderContents`](Widget.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L188)

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

[`Widget`](Widget.md).[`syncOrAsyncThen`](Widget.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L211)

***

### tryFind()

> **tryFind**\<`TWidget`\>(`type`, `field`): `TWidget`

#### Type Parameters

• **TWidget**

#### Parameters

##### type

(...`args`) => `TWidget`

##### field

`string`

#### Returns

`TWidget`

#### Defined in

[src/ui/datagrid/quickfilterbar.tsx:368](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L368)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`Widget`](Widget.md).[`useIdPrefix`](Widget.md#useidprefix)

#### Defined in

[src/ui/widgets/widget.ts:218](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L218)

***

### boolean()

> `static` **boolean**(`field`, `title`?, `yes`?, `no`?): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`SelectEditor`](SelectEditor.md)\<[`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>, [`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>

#### Parameters

##### field

`string`

##### title?

`string`

##### yes?

`string`

##### no?

`string`

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`SelectEditor`](SelectEditor.md)\<[`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>, [`SelectEditorOptions`](../interfaces/SelectEditorOptions.md)\>

#### Defined in

[src/ui/datagrid/quickfilterbar.tsx:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L307)

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

[`Widget`](Widget.md).[`create`](Widget.md#create)

#### Defined in

[src/ui/widgets/widget.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L130)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[`Widget`](Widget.md).[`createDefaultElement`](Widget.md#createdefaultelement)

#### Defined in

[src/ui/widgets/widget.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L56)

***

### dateRange()

> `static` **dateRange**(`field`, `title`?): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateEditor`](DateEditor.md)\<[`DateEditorOptions`](../interfaces/DateEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Parameters

##### field

`string`

##### title?

`string`

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateEditor`](DateEditor.md)\<[`DateEditorOptions`](../interfaces/DateEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Defined in

[src/ui/datagrid/quickfilterbar.tsx:147](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L147)

***

### dateTimeRange()

> `static` **dateTimeRange**(`field`, `title`?, `useUtc`?): [`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Parameters

##### field

`string`

##### title?

`string`

##### useUtc?

`boolean`

#### Returns

[`QuickFilter`](../interfaces/QuickFilter.md)\<[`DateTimeEditor`](DateTimeEditor.md)\<[`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>, [`DateTimeEditorOptions`](../interfaces/DateTimeEditorOptions.md)\>

#### Defined in

[src/ui/datagrid/quickfilterbar.tsx:224](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilterbar.tsx#L224)

***

### getWidgetName()

> `static` **getWidgetName**(`type`): `string`

#### Parameters

##### type

`Function`

#### Returns

`string`

#### Inherited from

[`Widget`](Widget.md).[`getWidgetName`](Widget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
