[@serenity-is/corelib](../README.md) / PropertyPanel

# Class: PropertyPanel\<TItem, P\>

Defined in: [src/ui/widgets/propertypanel.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L14)

A panel that hosts a [PropertyGrid](PropertyGrid.md) for editing an entity, providing
load/save of the entity and its id, and deriving form options from the
panel's type name.

## Extends

- [`BasePanel`](BasePanel.md)\<`P`\>

## Type Parameters

### TItem

`TItem`

The entity type edited by the panel.

### P

`P`

Widget props type.

## Constructors

### Constructor

> **new PropertyPanel**\<`TItem`, `P`\>(`props`): `PropertyPanel`\<`TItem`, `P`\>

Defined in: [src/ui/widgets/propertypanel.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L25)

Creates a property panel, initializing the property grid and loading the
initial (empty) entity.

#### Parameters

##### props

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Widget props forwarded to [BasePanel](BasePanel.md).

#### Returns

`PropertyPanel`\<`TItem`, `P`\>

#### Overrides

[`BasePanel`](BasePanel.md).[`constructor`](BasePanel.md#constructor)

## Properties

### domNode

> `readonly` **domNode**: `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L24)

The DOM node this widget is bound to.

#### Inherited from

[`BasePanel`](BasePanel.md).[`domNode`](BasePanel.md#domnode)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L22)

The id prefix used for this widget's child element ids.

#### Inherited from

[`BasePanel`](BasePanel.md).[`idPrefix`](BasePanel.md#idprefix)

***

### isPanel

> `protected` **isPanel**: `boolean`

Defined in: [src/ui/widgets/basepanel.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L56)

Whether this panel is rendered as a panel.

#### Inherited from

[`BasePanel`](BasePanel.md).[`isPanel`](BasePanel.md#ispanel)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

The widget's options/props.

#### Inherited from

[`BasePanel`](BasePanel.md).[`options`](BasePanel.md#options)

***

### propertyGrid

> `protected` **propertyGrid**: [`PropertyGrid`](PropertyGrid.md)

Defined in: [src/ui/widgets/propertypanel.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L159)

The property grid hosted by this panel.

***

### responsive

> `protected` **responsive**: `boolean`

Defined in: [src/ui/widgets/basepanel.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L58)

Whether this panel is responsive.

#### Inherited from

[`BasePanel`](BasePanel.md).[`responsive`](BasePanel.md#responsive)

***

### tabs

> `protected` **tabs**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/basepanel.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L50)

The initialized tabs element, if the panel has a `Tabs` div.

#### Inherited from

[`BasePanel`](BasePanel.md).[`tabs`](BasePanel.md#tabs)

***

### toolbar

> `protected` **toolbar**: [`Toolbar`](Toolbar.md)

Defined in: [src/ui/widgets/basepanel.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L52)

The initialized toolbar, if the panel has a `Toolbar` div.

#### Inherited from

[`BasePanel`](BasePanel.md).[`toolbar`](BasePanel.md#toolbar)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L20)

A unique name for this widget instance, used for event namespacing.

#### Inherited from

[`BasePanel`](BasePanel.md).[`uniqueName`](BasePanel.md#uniquename)

***

### validator

> `protected` **validator**: [`Validator`](Validator.md)

Defined in: [src/ui/widgets/basepanel.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L54)

The form validator, if the panel has a `Form` element.

#### Inherited from

[`BasePanel`](BasePanel.md).[`validator`](BasePanel.md#validator)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/widgets/propertypanel.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L15)

#### Overrides

[`BasePanel`](BasePanel.md).[`[typeInfo]`](BasePanel.md#typeinfo)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:334](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L334)

#### Inherited from

[`BasePanel`](BasePanel.md).[`isComponent`](BasePanel.md#iscomponent)

## Accessors

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L82)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`BasePanel`](BasePanel.md).[`element`](BasePanel.md#element)

***

### entity

#### Get Signature

> **get** **entity**(): `TItem`

Defined in: [src/ui/widgets/propertypanel.ts:123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L123)

Gets the entity currently loaded in the panel.

##### Returns

`TItem`

#### Set Signature

> **set** **entity**(`value`): `void`

Defined in: [src/ui/widgets/propertypanel.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L138)

Sets the entity loaded in the panel.

##### Parameters

###### value

`TItem`

The entity to set; null is replaced with an empty object.

##### Returns

`void`

***

### entityId

#### Get Signature

> **get** **entityId**(): `any`

Defined in: [src/ui/widgets/propertypanel.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L130)

Gets the id of the entity currently loaded in the panel.

##### Returns

`any`

#### Set Signature

> **set** **entityId**(`value`): `void`

Defined in: [src/ui/widgets/propertypanel.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L146)

Sets the id of the entity loaded in the panel.

##### Parameters

###### value

`any`

The entity id to set.

##### Returns

`void`

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L307)

Returns the widget's props/options.

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`BasePanel`](BasePanel.md).[`props`](BasePanel.md#props)

## Methods

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/widgets/widget.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L89)

Adds the widget's CSS class to its DOM node.

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`addCssClass`](BasePanel.md#addcssclass)

***

### addValidationRule()

#### Call Signature

> **addValidationRule**(`rule`, `uniqueName?`): `void`

Defined in: [src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

Adds a validation rule to the widget's DOM node.

##### Parameters

###### rule

(`input`) => `string`

The validation rule function, or a unique name when the
  two-argument overload is used.

###### uniqueName?

`string`

A unique name for the rule, or the rule function when
  the two-argument overload is used.

##### Returns

`void`

##### Inherited from

[`BasePanel`](BasePanel.md).[`addValidationRule`](BasePanel.md#addvalidationrule)

#### Call Signature

> **addValidationRule**(`uniqueName`, `rule`): `void`

Defined in: [src/ui/widgets/widget.ts:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L143)

Adds a validation rule to the widget's DOM node.

##### Parameters

###### uniqueName

`string`

A unique name for the rule, or the rule function when
  the two-argument overload is used.

###### rule

(`input`) => `string`

The validation rule function, or a unique name when the
  two-argument overload is used.

##### Returns

`void`

##### Inherited from

[`BasePanel`](BasePanel.md).[`addValidationRule`](BasePanel.md#addvalidationrule)

***

### afterRender()

> `protected` **afterRender**(`callback`): `void`

Defined in: [src/ui/widgets/widget.ts:228](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L228)

Queues a callback to run after the widget's contents are rendered.

#### Parameters

##### callback

() => `void`

The callback to run after rendering.

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`afterRender`](BasePanel.md#afterrender)

***

### arrange()

> **arrange**(): `void`

Defined in: [src/ui/widgets/basepanel.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L63)

Triggers a `layout` event on all visible `.require-layout` elements.

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`arrange`](BasePanel.md#arrange)

***

### byId()

> `protected` **byId**\<`TElement`\>(`id`): [`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

Defined in: [src/ui/widgets/widget.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L154)

Finds a child element by its prefix-relative id.

#### Type Parameters

##### TElement

`TElement` *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

The id relative to the widget's id prefix.

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

A [Fluent](../functions/Fluent.md) wrapper for the matching element.

#### Inherited from

[`BasePanel`](BasePanel.md).[`byId`](BasePanel.md#byid)

***

### change()

> **change**(`handler`): `void`

Defined in: [src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

Registers a `change` handler on the widget's DOM node.

#### Parameters

##### handler

(`e`) => `void`

The change event handler.

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`change`](BasePanel.md#change)

***

### changeSelect2()

> **changeSelect2**(`handler`): `void`

Defined in: [src/ui/widgets/widget.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L188)

Registers a `change` handler that ignores changes originating from
combobox setting values.

#### Parameters

##### handler

(`e`) => `void`

The change event handler.

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`changeSelect2`](BasePanel.md#changeselect2)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L98)

Determines whether rendering should be deferred until [init](#init) is
called.

#### Returns

`boolean`

True to defer rendering.

#### Inherited from

[`BasePanel`](BasePanel.md).[`deferRender`](BasePanel.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/widgets/propertypanel.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L35)

Destroys the property grid and validator, then delegates to the base destroy.

#### Returns

`void`

#### Overrides

[`BasePanel`](BasePanel.md).[`destroy`](BasePanel.md#destroy)

***

### findById()

> `protected` **findById**\<`TElement`\>(`id`): `TElement`

Defined in: [src/ui/widgets/widget.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L163)

Finds a child element by its prefix-relative id.

#### Type Parameters

##### TElement

`TElement` *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

The id relative to the widget's id prefix.

#### Returns

`TElement`

The matching element, or null if not found.

#### Inherited from

[`BasePanel`](BasePanel.md).[`findById`](BasePanel.md#findbyid)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

Returns the CSS class(es) applied to the widget's DOM node.

#### Returns

`string`

The space-separated CSS class string.

#### Inherited from

[`BasePanel`](BasePanel.md).[`getCssClass`](BasePanel.md#getcssclass)

***

### getCustomAttribute()

> `protected` **getCustomAttribute**\<`TAttr`\>(`attrType`, `inherit`): `TAttr`

Defined in: [src/ui/widgets/widget.ts:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L220)

Returns a custom attribute applied to the widget's type.

#### Type Parameters

##### TAttr

`TAttr` *extends* [`CustomAttribute`](CustomAttribute.md)

#### Parameters

##### attrType

(...`args`) => `TAttr`

The attribute type to look up.

##### inherit

`boolean` = `true`

Whether to search inherited types; defaults to true.

#### Returns

`TAttr`

The matching attribute, or null.

#### Inherited from

[`BasePanel`](BasePanel.md).[`getCustomAttribute`](BasePanel.md#getcustomattribute)

***

### getFormKey()

> `protected` **getFormKey**(): `string`

Defined in: [src/ui/widgets/propertypanel.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L73)

Returns the form key derived from the panel's type name, used to look up
the form definition and local text prefix.

#### Returns

`string`

The form key (e.g. "MyPanel" for "MyModule.MyPanel").

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L171)

Returns the closest `.field` element containing the widget's DOM node.

#### Returns

[`Fluent`](../interfaces/Fluent.md)

A [Fluent](../functions/Fluent.md) wrapper for the grid field.

#### Inherited from

[`BasePanel`](BasePanel.md).[`getGridField`](BasePanel.md#getgridfield)

***

### getPropertyGridOptions()

> `protected` **getPropertyGridOptions**(): [`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

Defined in: [src/ui/widgets/propertypanel.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L90)

Returns the options used to configure the property grid.

#### Returns

[`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

The property grid options.

***

### getPropertyItems()

> `protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

Defined in: [src/ui/widgets/propertypanel.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L103)

Returns the property items for the panel's form.

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

The property items to render.

***

### getSaveEntity()

> `protected` **getSaveEntity**(): `TItem`

Defined in: [src/ui/widgets/propertypanel.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L112)

Saves the current editor values into a new entity object.

#### Returns

`TItem`

The saved entity.

***

### getToolbarButtons()

> `protected` **getToolbarButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

Defined in: [src/ui/widgets/basepanel.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L73)

Returns the buttons to show in the panel toolbar.

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

Toolbar button definitions.

#### Inherited from

[`BasePanel`](BasePanel.md).[`getToolbarButtons`](BasePanel.md#gettoolbarbuttons)

***

### getValidatorOptions()

> `protected` **getValidatorOptions**(): `any`

Defined in: [src/ui/widgets/basepanel.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L81)

Returns the options used to configure the form validator.

#### Returns

`any`

Validator options object.

#### Inherited from

[`BasePanel`](BasePanel.md).[`getValidatorOptions`](BasePanel.md#getvalidatoroptions)

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L243)

Initializes the widget, rendering its contents if rendering was deferred.

#### Returns

`this`

This widget instance.

#### Inherited from

[`BasePanel`](BasePanel.md).[`init`](BasePanel.md#init)

***

### initPropertyGrid()

> `protected` **initPropertyGrid**(): `void`

Defined in: [src/ui/widgets/propertypanel.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L51)

Initializes the property grid from the `PropertyGrid` div, if present.

#### Returns

`void`

***

### initTabs()

> `protected` **initTabs**(): `void`

Defined in: [src/ui/widgets/basepanel.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L88)

Initializes the tabs from the `Tabs` div, if present.

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`initTabs`](BasePanel.md#inittabs)

***

### initToolbar()

> `protected` **initToolbar**(): `void`

Defined in: [src/ui/widgets/basepanel.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L98)

Initializes the toolbar from the `Toolbar` div, if present.

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`initToolbar`](BasePanel.md#inittoolbar)

***

### initValidator()

> `protected` **initValidator**(): `void`

Defined in: [src/ui/widgets/basepanel.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L108)

Initializes the form validator from the `Form` element, if present.

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`initValidator`](BasePanel.md#initvalidator)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L266)

Renders the widget's contents and runs any queued after-render callbacks.

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`internalRenderContents`](BasePanel.md#internalrendercontents)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L291)

Renders the widget from a legacy `getTemplate` string, if defined.

#### Returns

`boolean`

True if a legacy template was rendered.

#### Inherited from

[`BasePanel`](BasePanel.md).[`legacyTemplateRender`](BasePanel.md#legacytemplaterender)

***

### loadInitialEntity()

> `protected` **loadInitialEntity**(): `void`

Defined in: [src/ui/widgets/propertypanel.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L62)

Loads an empty entity into the property grid.

#### Returns

`void`

***

### render()

> **render**(): `any`

Defined in: [src/ui/widgets/widget.ts:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L253)

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

Defined in: [src/ui/widgets/widget.ts:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L281)

Renders the widget's contents. Override this to provide custom content.

#### Returns

`any`

The rendered contents.

#### Inherited from

[`BasePanel`](BasePanel.md).[`renderContents`](BasePanel.md#rendercontents)

***

### resetValidation()

> `protected` **resetValidation**(): `void`

Defined in: [src/ui/widgets/basepanel.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L119)

Resets all validation state on the form validator, if present.

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`resetValidation`](BasePanel.md#resetvalidation)

***

### syncOrAsyncThen()

> `protected` **syncOrAsyncThen**\<`T`\>(`syncMethod`, `asyncMethod`, `then`): `void`

Defined in: [src/ui/widgets/widget.ts:318](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L318)

Runs a method synchronously or asynchronously depending on the widget's
`useAsync` flag, then invokes a continuation.

#### Type Parameters

##### T

`T`

#### Parameters

##### syncMethod

() => `T`

The synchronous method to run.

##### asyncMethod

() => `PromiseLike`\<`T`\>

The asynchronous method to run.

##### then

(`v`) => `void`

The continuation invoked with the result.

#### Returns

`void`

#### Inherited from

[`BasePanel`](BasePanel.md).[`syncOrAsyncThen`](BasePanel.md#syncorasyncthen)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:329](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L329)

Returns an id prefix helper for resolving child element ids.

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

An [IdPrefixType](../type-aliases/IdPrefixType.md) proxy for this widget's id prefix.

#### Inherited from

[`BasePanel`](BasePanel.md).[`useIdPrefix`](BasePanel.md#useidprefix)

***

### validateBeforeSave()

> `protected` **validateBeforeSave**(): `boolean`

Defined in: [src/ui/widgets/propertypanel.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertypanel.ts#L154)

Validates the form before saving.

#### Returns

`boolean`

True if the form is valid.

***

### validateForm()

> `protected` **validateForm**(): `boolean`

Defined in: [src/ui/widgets/basepanel.ts:129](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/basepanel.ts#L129)

Validates the form, returning whether it is valid.

#### Returns

`boolean`

True if there is no validator or the form is valid.

#### Inherited from

[`BasePanel`](BasePanel.md).[`validateForm`](BasePanel.md#validateform)

***

### create()

> `static` **create**\<`TWidget`, `P`\>(`params`): `TWidget`

Defined in: [src/ui/widgets/widget.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L202)

Creates a widget instance from the given params, appending its element to
the container and invoking the init/init callbacks.

#### Type Parameters

##### TWidget

`TWidget` *extends* [`Widget`](Widget.md)\<`P`\>

##### P

`P`

#### Parameters

##### params

[`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)\<`TWidget`, `P`\>

The widget creation params.

#### Returns

`TWidget`

The created widget instance.

#### Inherited from

[`BasePanel`](BasePanel.md).[`create`](BasePanel.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L75)

Creates the default DOM element for a widget.

#### Returns

`HTMLElement`

A new `div` element.

#### Inherited from

[`BasePanel`](BasePanel.md).[`createDefaultElement`](BasePanel.md#createdefaultelement)

***

### getWidgetName()

> `static` **getWidgetName**(`type`): `string`

Defined in: [src/ui/widgets/widget.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L131)

Returns the widget name for a type, used for association and unique names.

#### Parameters

##### type

`Function`

The widget type.

#### Returns

`string`

The widget name.

#### Inherited from

[`BasePanel`](BasePanel.md).[`getWidgetName`](BasePanel.md#getwidgetname)

***

### registerClass()

> `protected` `static` **registerClass**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

Defined in: [src/ui/widgets/widget.ts:342](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L342)

Registers this type as a class with the given type name.

#### Type Parameters

##### TypeName

`TypeName`

#### Parameters

##### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

The type name to register.

##### intfAndAttr?

([`InterfaceType`](../type-aliases/InterfaceType.md) \| [`AttributeSpecifier`](../type-aliases/AttributeSpecifier.md))[]

Optional interfaces and attributes.

#### Returns

[`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

The class type info.

#### Inherited from

[`BasePanel`](BasePanel.md).[`registerClass`](BasePanel.md#registerclass)

***

### registerEditor()

> `protected` `static` **registerEditor**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`TypeName`\>

Defined in: [src/ui/widgets/widget.ts:357](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L357)

Registers this type as an editor with the given type name.

#### Type Parameters

##### TypeName

`TypeName`

#### Parameters

##### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

The type name to register.

##### intfAndAttr?

([`InterfaceType`](../type-aliases/InterfaceType.md) \| [`AttributeSpecifier`](../type-aliases/AttributeSpecifier.md))[]

Optional interfaces and attributes.

#### Returns

[`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`TypeName`\>

The editor type info.

#### Inherited from

[`BasePanel`](BasePanel.md).[`registerEditor`](BasePanel.md#registereditor)
