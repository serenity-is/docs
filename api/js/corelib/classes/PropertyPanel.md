[@serenity-is/corelib](../README.md) / PropertyPanel

# Class: PropertyPanel\<TItem, P\>

Defined in: [src/ui/widgets/propertypanel.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L7)

## Extends

- [`BasePanel`](BasePanel.md)\<`P`\>

## Type Parameters

### TItem

`TItem`

### P

`P`

## Constructors

### Constructor

> **new PropertyPanel**\<`TItem`, `P`\>(`props`): `PropertyPanel`\<`TItem`, `P`\>

Defined in: [src/ui/widgets/propertypanel.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L13)

#### Parameters

##### props

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Returns

`PropertyPanel`\<`TItem`, `P`\>

#### Overrides

[`BasePanel`](BasePanel.md).[`constructor`](BasePanel.md#constructor)

## Properties

### domNode

> `readonly` **domNode**: `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L14)

#### Inherited from

[`BasePanel`](BasePanel.md).[`domNode`](BasePanel.md#domnode)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L13)

#### Inherited from

[`BasePanel`](BasePanel.md).[`idPrefix`](BasePanel.md#idprefix)

***

### isPanel

> `protected` **isPanel**: `boolean`

Defined in: [src/ui/widgets/basepanel.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L39)

#### Inherited from

[`BasePanel`](BasePanel.md).[`isPanel`](BasePanel.md#ispanel)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L11)

#### Inherited from

[`BasePanel`](BasePanel.md).[`options`](BasePanel.md#options)

***

### propertyGrid

> `protected` **propertyGrid**: [`PropertyGrid`](PropertyGrid.md)

Defined in: [src/ui/widgets/propertypanel.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L101)

***

### responsive

> `protected` **responsive**: `boolean`

Defined in: [src/ui/widgets/basepanel.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L40)

#### Inherited from

[`BasePanel`](BasePanel.md).[`responsive`](BasePanel.md#responsive)

***

### tabs

> `protected` **tabs**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/basepanel.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L36)

#### Inherited from

[`BasePanel`](BasePanel.md).[`tabs`](BasePanel.md#tabs)

***

### toolbar

> `protected` **toolbar**: [`Toolbar`](Toolbar.md)

Defined in: [src/ui/widgets/basepanel.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L37)

#### Inherited from

[`BasePanel`](BasePanel.md).[`toolbar`](BasePanel.md#toolbar)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

#### Inherited from

[`BasePanel`](BasePanel.md).[`uniqueName`](BasePanel.md#uniquename)

***

### validator

> `protected` **validator**: [`Validator`](Validator.md)

Defined in: [src/ui/widgets/basepanel.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L38)

#### Inherited from

[`BasePanel`](BasePanel.md).[`validator`](BasePanel.md#validator)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/widgets/propertypanel.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L8)

#### Overrides

[`BasePanel`](BasePanel.md).[`[typeInfo]`](BasePanel.md#typeinfo)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L219)

#### Inherited from

[`BasePanel`](BasePanel.md).[`isComponent`](BasePanel.md#iscomponent)

## Accessors

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L59)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`BasePanel`](BasePanel.md).[`element`](BasePanel.md#element)

***

### entity

#### Get Signature

> **get** **entity**(): `TItem`

Defined in: [src/ui/widgets/propertypanel.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L81)

##### Returns

`TItem`

#### Set Signature

> **set** **entity**(`value`): `void`

Defined in: [src/ui/widgets/propertypanel.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L89)

##### Parameters

###### value

`TItem`

##### Returns

`void`

***

### entityId

#### Get Signature

> **get** **entityId**(): `any`

Defined in: [src/ui/widgets/propertypanel.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L85)

##### Returns

`any`

#### Set Signature

> **set** **entityId**(`value`): `void`

Defined in: [src/ui/widgets/propertypanel.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L93)

##### Parameters

###### value

`any`

##### Returns

`void`

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L203)

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`BasePanel`](BasePanel.md).[`props`](BasePanel.md#props)

## Methods

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`addCssClass`](BasePanel.md#addcssclass)

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

[`BasePanel`](BasePanel.md).[`addValidationRule`](BasePanel.md#addvalidationrule)

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

[`BasePanel`](BasePanel.md).[`addValidationRule`](BasePanel.md#addvalidationrule)

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

[`BasePanel`](BasePanel.md).[`afterRender`](BasePanel.md#afterrender)

***

### arrange()

> **arrange**(): `void`

Defined in: [src/ui/widgets/basepanel.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L42)

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`arrange`](BasePanel.md#arrange)

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

[`BasePanel`](BasePanel.md).[`byId`](BasePanel.md#byid)

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

[`BasePanel`](BasePanel.md).[`change`](BasePanel.md#change)

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

[`BasePanel`](BasePanel.md).[`changeSelect2`](BasePanel.md#changeselect2)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

#### Returns

`boolean`

#### Inherited from

[`BasePanel`](BasePanel.md).[`deferRender`](BasePanel.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/widgets/propertypanel.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L20)

#### Returns

`void`

#### Overrides

[`BasePanel`](BasePanel.md).[`destroy`](BasePanel.md#destroy)

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

[`BasePanel`](BasePanel.md).[`findById`](BasePanel.md#findbyid)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

#### Returns

`string`

#### Inherited from

[`BasePanel`](BasePanel.md).[`getCssClass`](BasePanel.md#getcssclass)

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

[`BasePanel`](BasePanel.md).[`getCustomAttribute`](BasePanel.md#getcustomattribute)

***

### getFormKey()

> `protected` **getFormKey**(): `string`

Defined in: [src/ui/widgets/propertypanel.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L47)

#### Returns

`string`

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

#### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`BasePanel`](BasePanel.md).[`getGridField`](BasePanel.md#getgridfield)

***

### getPropertyGridOptions()

> `protected` **getPropertyGridOptions**(): [`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

Defined in: [src/ui/widgets/propertypanel.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L59)

#### Returns

[`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

***

### getPropertyItems()

> `protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

Defined in: [src/ui/widgets/propertypanel.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L68)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

***

### getSaveEntity()

> `protected` **getSaveEntity**(): `TItem`

Defined in: [src/ui/widgets/propertypanel.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L73)

#### Returns

`TItem`

***

### getToolbarButtons()

> `protected` **getToolbarButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

Defined in: [src/ui/widgets/basepanel.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L48)

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Inherited from

[`BasePanel`](BasePanel.md).[`getToolbarButtons`](BasePanel.md#gettoolbarbuttons)

***

### getValidatorOptions()

> `protected` **getValidatorOptions**(): `any`

Defined in: [src/ui/widgets/basepanel.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L52)

#### Returns

`any`

#### Inherited from

[`BasePanel`](BasePanel.md).[`getValidatorOptions`](BasePanel.md#getvalidatoroptions)

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

#### Returns

`this`

#### Inherited from

[`BasePanel`](BasePanel.md).[`init`](BasePanel.md#init)

***

### initPropertyGrid()

> `protected` **initPropertyGrid**(): `void`

Defined in: [src/ui/widgets/propertypanel.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L33)

#### Returns

`void`

***

### initTabs()

> `protected` **initTabs**(): `void`

Defined in: [src/ui/widgets/basepanel.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L56)

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`initTabs`](BasePanel.md#inittabs)

***

### initToolbar()

> `protected` **initToolbar**(): `void`

Defined in: [src/ui/widgets/basepanel.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L63)

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`initToolbar`](BasePanel.md#inittoolbar)

***

### initValidator()

> `protected` **initValidator**(): `void`

Defined in: [src/ui/widgets/basepanel.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L70)

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`initValidator`](BasePanel.md#initvalidator)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L173)

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`internalRenderContents`](BasePanel.md#internalrendercontents)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L190)

#### Returns

`boolean`

#### Inherited from

[`BasePanel`](BasePanel.md).[`legacyTemplateRender`](BasePanel.md#legacytemplaterender)

***

### loadInitialEntity()

> `protected` **loadInitialEntity**(): `void`

Defined in: [src/ui/widgets/propertypanel.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L41)

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

[`BasePanel`](BasePanel.md).[`render`](BasePanel.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

#### Returns

`any`

#### Inherited from

[`BasePanel`](BasePanel.md).[`renderContents`](BasePanel.md#rendercontents)

***

### resetValidation()

> `protected` **resetValidation**(): `void`

Defined in: [src/ui/widgets/basepanel.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L78)

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`resetValidation`](BasePanel.md#resetvalidation)

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

[`BasePanel`](BasePanel.md).[`syncOrAsyncThen`](BasePanel.md#syncorasyncthen)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L214)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`BasePanel`](BasePanel.md).[`useIdPrefix`](BasePanel.md#useidprefix)

***

### validateBeforeSave()

> `protected` **validateBeforeSave**(): `boolean`

Defined in: [src/ui/widgets/propertypanel.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L97)

#### Returns

`boolean`

***

### validateForm()

> `protected` **validateForm**(): `boolean`

Defined in: [src/ui/widgets/basepanel.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L84)

#### Returns

`boolean`

#### Inherited from

[`BasePanel`](BasePanel.md).[`validateForm`](BasePanel.md#validateform)

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

[`BasePanel`](BasePanel.md).[`create`](BasePanel.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L52)

#### Returns

`HTMLElement`

#### Inherited from

[`BasePanel`](BasePanel.md).[`createDefaultElement`](BasePanel.md#createdefaultelement)

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

[`BasePanel`](BasePanel.md).[`getWidgetName`](BasePanel.md#getwidgetname)

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

[`BasePanel`](BasePanel.md).[`registerClass`](BasePanel.md#registerclass)

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

[`BasePanel`](BasePanel.md).[`registerEditor`](BasePanel.md#registereditor)
