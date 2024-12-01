[@serenity-is/corelib](../README.md) / PropertyPanel

# Class: PropertyPanel\<TItem, P\>

## Extends

- [`BasePanel`](BasePanel.md)\<`P`\>

## Type Parameters

• **TItem**

• **P**

## Constructors

### new PropertyPanel()

> **new PropertyPanel**\<`TItem`, `P`\>(`props`): [`PropertyPanel`](PropertyPanel.md)\<`TItem`, `P`\>

#### Parameters

##### props

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Returns

[`PropertyPanel`](PropertyPanel.md)\<`TItem`, `P`\>

#### Overrides

[`BasePanel`](BasePanel.md).[`constructor`](BasePanel.md#constructors)

#### Defined in

[src/ui/widgets/propertypanel.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L15)

## Properties

### domNode

> `readonly` **domNode**: `HTMLElement`

#### Inherited from

[`BasePanel`](BasePanel.md).[`domNode`](BasePanel.md#domnode)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

***

### idPrefix

> `readonly` **idPrefix**: `string`

#### Inherited from

[`BasePanel`](BasePanel.md).[`idPrefix`](BasePanel.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

***

### isPanel

> `protected` **isPanel**: `boolean`

#### Inherited from

[`BasePanel`](BasePanel.md).[`isPanel`](BasePanel.md#ispanel)

#### Defined in

[src/ui/widgets/basepanel.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L39)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`BasePanel`](BasePanel.md).[`options`](BasePanel.md#options)

#### Defined in

[src/ui/widgets/widget.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L14)

***

### propertyGrid

> `protected` **propertyGrid**: [`PropertyGrid`](PropertyGrid.md)\<[`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)\>

#### Defined in

[src/ui/widgets/propertypanel.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L106)

***

### responsive

> `protected` **responsive**: `boolean`

#### Inherited from

[`BasePanel`](BasePanel.md).[`responsive`](BasePanel.md#responsive)

#### Defined in

[src/ui/widgets/basepanel.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L40)

***

### tabs

> `protected` **tabs**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`BasePanel`](BasePanel.md).[`tabs`](BasePanel.md#tabs)

#### Defined in

[src/ui/widgets/basepanel.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L36)

***

### toolbar

> `protected` **toolbar**: [`Toolbar`](Toolbar.md)\<[`ToolbarOptions`](../interfaces/ToolbarOptions.md)\>

#### Inherited from

[`BasePanel`](BasePanel.md).[`toolbar`](BasePanel.md#toolbar)

#### Defined in

[src/ui/widgets/basepanel.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L37)

***

### uniqueName

> `readonly` **uniqueName**: `string`

#### Inherited from

[`BasePanel`](BasePanel.md).[`uniqueName`](BasePanel.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

***

### validator

> `protected` **validator**: [`Validator`](Validator.md)

#### Inherited from

[`BasePanel`](BasePanel.md).[`validator`](BasePanel.md#validator)

#### Defined in

[src/ui/widgets/basepanel.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L38)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

#### Inherited from

[`BasePanel`](BasePanel.md).[`isComponent`](BasePanel.md#iscomponent)

#### Defined in

[src/ui/widgets/widget.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L223)

***

### typeInfo

> `static` **typeInfo**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity.Widget"`\>

#### Inherited from

[`BasePanel`](BasePanel.md).[`typeInfo`](BasePanel.md#typeinfo)

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

[`BasePanel`](BasePanel.md).[`element`](BasePanel.md#element)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

***

### entity

#### Get Signature

> **get** **entity**(): `TItem`

##### Returns

`TItem`

#### Set Signature

> **set** **entity**(`value`): `void`

##### Parameters

###### value

`TItem`

##### Returns

`void`

#### Defined in

[src/ui/widgets/propertypanel.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L86)

***

### entityId

#### Get Signature

> **get** **entityId**(): `any`

##### Returns

`any`

#### Set Signature

> **set** **entityId**(`value`): `void`

##### Parameters

###### value

`any`

##### Returns

`void`

#### Defined in

[src/ui/widgets/propertypanel.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L90)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`BasePanel`](BasePanel.md).[`props`](BasePanel.md#props)

#### Defined in

[src/ui/widgets/widget.ts:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L207)

## Methods

### addCssClass()

> `protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`addCssClass`](BasePanel.md#addcssclass)

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

[`BasePanel`](BasePanel.md).[`addValidationRule`](BasePanel.md#addvalidationrule)

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

[`BasePanel`](BasePanel.md).[`addValidationRule`](BasePanel.md#addvalidationrule)

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

[`BasePanel`](BasePanel.md).[`afterRender`](BasePanel.md#afterrender)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

***

### arrange()

> **arrange**(): `void`

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`arrange`](BasePanel.md#arrange)

#### Defined in

[src/ui/widgets/basepanel.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L42)

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

[`BasePanel`](BasePanel.md).[`byId`](BasePanel.md#byid)

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

[`BasePanel`](BasePanel.md).[`change`](BasePanel.md#change)

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

[`BasePanel`](BasePanel.md).[`changeSelect2`](BasePanel.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L122)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`BasePanel`](BasePanel.md).[`deferRender`](BasePanel.md#deferrender)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Overrides

[`BasePanel`](BasePanel.md).[`destroy`](BasePanel.md#destroy)

#### Defined in

[src/ui/widgets/propertypanel.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L22)

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

[`BasePanel`](BasePanel.md).[`findById`](BasePanel.md#findbyid)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[`BasePanel`](BasePanel.md).[`getCssClass`](BasePanel.md#getcssclass)

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

[`BasePanel`](BasePanel.md).[`getCustomAttribute`](BasePanel.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

***

### getFormKey()

> `protected` **getFormKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/widgets/propertypanel.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L48)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`BasePanel`](BasePanel.md).[`getGridField`](BasePanel.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L114)

***

### getPropertyGridOptions()

> `protected` **getPropertyGridOptions**(): [`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

#### Returns

[`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

#### Defined in

[src/ui/widgets/propertypanel.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L64)

***

### getPropertyItems()

> `protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Defined in

[src/ui/widgets/propertypanel.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L73)

***

### getSaveEntity()

> `protected` **getSaveEntity**(): `TItem`

#### Returns

`TItem`

#### Defined in

[src/ui/widgets/propertypanel.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L78)

***

### getToolbarButtons()

> `protected` **getToolbarButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Inherited from

[`BasePanel`](BasePanel.md).[`getToolbarButtons`](BasePanel.md#gettoolbarbuttons)

#### Defined in

[src/ui/widgets/basepanel.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L48)

***

### getValidatorOptions()

> `protected` **getValidatorOptions**(): `any`

#### Returns

`any`

#### Inherited from

[`BasePanel`](BasePanel.md).[`getValidatorOptions`](BasePanel.md#getvalidatoroptions)

#### Defined in

[src/ui/widgets/basepanel.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L52)

***

### init()

> **init**(): `this`

#### Returns

`this`

#### Inherited from

[`BasePanel`](BasePanel.md).[`init`](BasePanel.md#init)

#### Defined in

[src/ui/widgets/widget.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L157)

***

### initPropertyGrid()

> `protected` **initPropertyGrid**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertypanel.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L34)

***

### initTabs()

> `protected` **initTabs**(): `void`

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`initTabs`](BasePanel.md#inittabs)

#### Defined in

[src/ui/widgets/basepanel.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L56)

***

### initToolbar()

> `protected` **initToolbar**(): `void`

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`initToolbar`](BasePanel.md#inittoolbar)

#### Defined in

[src/ui/widgets/basepanel.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L63)

***

### initValidator()

> `protected` **initValidator**(): `void`

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`initValidator`](BasePanel.md#initvalidator)

#### Defined in

[src/ui/widgets/basepanel.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L70)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`internalRenderContents`](BasePanel.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L177)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`BasePanel`](BasePanel.md).[`legacyTemplateRender`](BasePanel.md#legacytemplaterender)

#### Defined in

[src/ui/widgets/widget.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L194)

***

### loadInitialEntity()

> `protected` **loadInitialEntity**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/widgets/propertypanel.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L42)

***

### render()

> **render**(): `any`

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[`BasePanel`](BasePanel.md).[`render`](BasePanel.md#render)

#### Defined in

[src/ui/widgets/widget.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L167)

***

### renderContents()

> `protected` **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[`BasePanel`](BasePanel.md).[`renderContents`](BasePanel.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L188)

***

### resetValidation()

> `protected` **resetValidation**(): `void`

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`resetValidation`](BasePanel.md#resetvalidation)

#### Defined in

[src/ui/widgets/basepanel.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L78)

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

[`BasePanel`](BasePanel.md).[`syncOrAsyncThen`](BasePanel.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L211)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`BasePanel`](BasePanel.md).[`useIdPrefix`](BasePanel.md#useidprefix)

#### Defined in

[src/ui/widgets/widget.ts:218](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L218)

***

### validateBeforeSave()

> `protected` **validateBeforeSave**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/widgets/propertypanel.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L102)

***

### validateForm()

> `protected` **validateForm**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`BasePanel`](BasePanel.md).[`validateForm`](BasePanel.md#validateform)

#### Defined in

[src/ui/widgets/basepanel.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L84)

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

[`BasePanel`](BasePanel.md).[`create`](BasePanel.md#create)

#### Defined in

[src/ui/widgets/widget.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L130)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[`BasePanel`](BasePanel.md).[`createDefaultElement`](BasePanel.md#createdefaultelement)

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

[`BasePanel`](BasePanel.md).[`getWidgetName`](BasePanel.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
