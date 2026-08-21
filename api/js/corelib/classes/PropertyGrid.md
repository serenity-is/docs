[@serenity-is/corelib](../README.md) / PropertyGrid

# Class: PropertyGrid\<P\>

Defined in: [src/ui/widgets/propertygrid.tsx:409](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L409)

A widget that renders a set of [PropertyItem](../interfaces/PropertyItem.md)s as a form, organizing
them into categories and/or tabs, and manages loading/saving values to and
from the underlying editors.

## Extends

- [`Widget`](Widget.md)\<`P`\>

## Type Parameters

### P

`P` *extends* [`PropertyGridOptions`](../interfaces/PropertyGridOptions.md) = [`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

Widget props type, constrained to [PropertyGridOptions](../interfaces/PropertyGridOptions.md).

## Constructors

### Constructor

> **new PropertyGrid**\<`P`\>(`props`): `PropertyGrid`\<`P`\>

Defined in: [src/ui/widgets/widget.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L31)

Creates a widget bound to the given props, resolving the DOM node,
associating the widget with it and rendering its contents.

#### Parameters

##### props

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

The widget props, including the target element.

#### Returns

`PropertyGrid`\<`P`\>

#### Inherited from

[`Widget`](Widget.md).[`constructor`](Widget.md#constructor)

## Properties

### domNode

> `readonly` **domNode**: `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L24)

The DOM node this widget is bound to.

#### Inherited from

[`Widget`](Widget.md).[`domNode`](Widget.md#domnode)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L22)

The id prefix used for this widget's child element ids.

#### Inherited from

[`Widget`](Widget.md).[`idPrefix`](Widget.md#idprefix)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

The widget's options/props.

#### Inherited from

[`Widget`](Widget.md).[`options`](Widget.md#options)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L20)

A unique name for this widget instance, used for event namespacing.

#### Inherited from

[`Widget`](Widget.md).[`uniqueName`](Widget.md#uniquename)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/widgets/propertygrid.tsx:411](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L411)

#### Overrides

[`Widget`](Widget.md).[`[typeInfo]`](Widget.md#typeinfo)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:334](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L334)

#### Inherited from

[`Widget`](Widget.md).[`isComponent`](Widget.md#iscomponent)

## Accessors

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L82)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`Widget`](Widget.md).[`element`](Widget.md#element)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L307)

Returns the widget's props/options.

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`Widget`](Widget.md).[`props`](Widget.md#props)

***

### value

#### Get Signature

> **get** **value**(): `any`

Defined in: [src/ui/widgets/propertygrid.tsx:620](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L620)

Gets the current values of all editors as an object.

##### Returns

`any`

#### Set Signature

> **set** **value**(`val`): `void`

Defined in: [src/ui/widgets/propertygrid.tsx:628](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L628)

Loads values from an object into all editors.

##### Parameters

###### val

`any`

The object containing values to load.

##### Returns

`void`

## Methods

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/widgets/widget.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L89)

Adds the widget's CSS class to its DOM node.

#### Returns

`void`

#### Inherited from

[`Widget`](Widget.md).[`addCssClass`](Widget.md#addcssclass)

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

[`Widget`](Widget.md).[`addValidationRule`](Widget.md#addvalidationrule)

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

[`Widget`](Widget.md).[`addValidationRule`](Widget.md#addvalidationrule)

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

[`Widget`](Widget.md).[`afterRender`](Widget.md#afterrender)

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

[`Widget`](Widget.md).[`byId`](Widget.md#byid)

***

### canModifyItem()

> `protected` **canModifyItem**(`item`): `boolean`

Defined in: [src/ui/widgets/propertygrid.tsx:672](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L672)

Determines whether a property item may be modified in the current mode.

#### Parameters

##### item

[`PropertyItem`](../interfaces/PropertyItem.md)

The property item to check.

#### Returns

`boolean`

True if the item can be modified.

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

[`Widget`](Widget.md).[`change`](Widget.md#change)

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

[`Widget`](Widget.md).[`changeSelect2`](Widget.md#changeselect2)

***

### commitEdits()

> **commitEdits**(): `Promise`\<`boolean`\>

Defined in: [src/ui/widgets/propertygrid.tsx:605](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L605)

Commits pending edits on all editors that support it.

#### Returns

`Promise`\<`boolean`\>

True if all commits succeeded, false if any editor rejected.

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

[`Widget`](Widget.md).[`deferRender`](Widget.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/widgets/propertygrid.tsx:452](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L452)

Destroys all field editors and clears the grid contents.

#### Returns

`void`

#### Overrides

[`Widget`](Widget.md).[`destroy`](Widget.md#destroy)

***

### enumerateItems()

> **enumerateItems**(`callback`): `void`

Defined in: [src/ui/widgets/propertygrid.tsx:500](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L500)

Invokes a callback for each rendered field with its property item and
editor widget.

#### Parameters

##### callback

(`p1`, `p2`) => `void`

Callback receiving the property item and editor widget.

#### Returns

`void`

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

[`Widget`](Widget.md).[`findById`](Widget.md#findbyid)

***

### get\_editors()

> **get\_editors**(): [`Widget`](Widget.md)\<`any`\>[]

Defined in: [src/ui/widgets/propertygrid.tsx:475](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L475)

Returns the editor widgets for all rendered fields.

#### Returns

[`Widget`](Widget.md)\<`any`\>[]

Array of editor widgets.

***

### get\_idPrefix()

> **get\_idPrefix**(): `string`

Defined in: [src/ui/widgets/propertygrid.tsx:491](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L491)

Returns the id prefix used by this grid.

#### Returns

`string`

The id prefix.

***

### get\_items()

> **get\_items**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

Defined in: [src/ui/widgets/propertygrid.tsx:483](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L483)

Returns the property items for all rendered fields.

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

Array of property items.

***

### get\_mode()

> **get\_mode**(): [`PropertyGridMode`](../enumerations/PropertyGridMode.md)

Defined in: [src/ui/widgets/propertygrid.tsx:514](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L514)

Returns the current grid mode (insert or update).

#### Returns

[`PropertyGridMode`](../enumerations/PropertyGridMode.md)

The current [PropertyGridMode](../enumerations/PropertyGridMode.md).

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

Returns the CSS class(es) applied to the widget's DOM node.

#### Returns

`string`

The space-separated CSS class string.

#### Inherited from

[`Widget`](Widget.md).[`getCssClass`](Widget.md#getcssclass)

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

[`Widget`](Widget.md).[`getCustomAttribute`](Widget.md#getcustomattribute)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L171)

Returns the closest `.field` element containing the widget's DOM node.

#### Returns

[`Fluent`](../interfaces/Fluent.md)

A [Fluent](../functions/Fluent.md) wrapper for the grid field.

#### Inherited from

[`Widget`](Widget.md).[`getGridField`](Widget.md#getgridfield)

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L243)

Initializes the widget, rendering its contents if rendering was deferred.

#### Returns

`this`

This widget instance.

#### Inherited from

[`Widget`](Widget.md).[`init`](Widget.md#init)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L266)

Renders the widget's contents and runs any queued after-render callbacks.

#### Returns

`void`

#### Inherited from

[`Widget`](Widget.md).[`internalRenderContents`](Widget.md#internalrendercontents)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L291)

Renders the widget from a legacy `getTemplate` string, if defined.

#### Returns

`boolean`

True if a legacy template was rendered.

#### Inherited from

[`Widget`](Widget.md).[`legacyTemplateRender`](Widget.md#legacytemplaterender)

***

### load()

> **load**(`source`): `void`

Defined in: [src/ui/widgets/propertygrid.tsx:561](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L561)

Loads values from a source object into all field editors.

#### Parameters

##### source

`any`

The source object to read values from.

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

[`Widget`](Widget.md).[`render`](Widget.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/widgets/propertygrid.tsx:420](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L420)

Renders the property grid contents, building categories/tabs and loading
the initial value.

#### Returns

`any`

The rendered contents.

#### Overrides

[`Widget`](Widget.md).[`renderContents`](Widget.md#rendercontents)

***

### save()

> **save**(`target?`): `any`

Defined in: [src/ui/widgets/propertygrid.tsx:592](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L592)

Saves all field editor values into a target object.

#### Parameters

##### target?

`any`

Optional target object; a new object is created if omitted.

#### Returns

`any`

The object containing the saved values.

***

### set\_mode()

> **set\_mode**(`value`): `void`

Defined in: [src/ui/widgets/propertygrid.tsx:522](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L522)

Sets the grid mode and refreshes the interface.

#### Parameters

##### value

[`PropertyGridMode`](../enumerations/PropertyGridMode.md)

The new [PropertyGridMode](../enumerations/PropertyGridMode.md).

#### Returns

`void`

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

[`Widget`](Widget.md).[`syncOrAsyncThen`](Widget.md#syncorasyncthen)

***

### updateFieldElement()

> `protected` **updateFieldElement**(`fieldElement`): `void`

Defined in: [src/ui/widgets/propertygrid.tsx:720](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L720)

Updates a single field element in the current mode.

#### Parameters

##### fieldElement

[`PropertyFieldElement`](../type-aliases/PropertyFieldElement.md)

The field element to update.

#### Returns

`void`

***

### updateInterface()

> **updateInterface**(): `void`

Defined in: [src/ui/widgets/propertygrid.tsx:727](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L727)

Refreshes the read-only/required state and visibility of all fields.

#### Returns

`void`

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:329](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L329)

Returns an id prefix helper for resolving child element ids.

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

An [IdPrefixType](../type-aliases/IdPrefixType.md) proxy for this widget's id prefix.

#### Inherited from

[`Widget`](Widget.md).[`useIdPrefix`](Widget.md#useidprefix)

***

### canModifyItem()

> `static` **canModifyItem**(`item`, `mode?`): `boolean`

Defined in: [src/ui/widgets/propertygrid.tsx:641](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L641)

Determines whether a property item may be modified in the given mode,
taking insert/update permissions into account.

#### Parameters

##### item

[`PropertyItem`](../interfaces/PropertyItem.md)

The property item to check.

##### mode?

[`PropertyGridMode`](../enumerations/PropertyGridMode.md)

The grid mode; defaults to update semantics when omitted.

#### Returns

`boolean`

True if the item can be modified.

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

[`Widget`](Widget.md).[`create`](Widget.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L75)

Creates the default DOM element for a widget.

#### Returns

`HTMLElement`

A new `div` element.

#### Inherited from

[`Widget`](Widget.md).[`createDefaultElement`](Widget.md#createdefaultelement)

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

[`Widget`](Widget.md).[`getWidgetName`](Widget.md#getwidgetname)

***

### loadFieldValue()

> `static` **loadFieldValue**(`source`, `fieldElement`, `mode?`): `void`

Defined in: [src/ui/widgets/propertygrid.tsx:536](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L536)

Loads a field's value from a source object into its editor, applying
defaults in insert mode.

#### Parameters

##### source

`any`

The source object to read values from.

##### fieldElement

[`PropertyFieldElement`](../type-aliases/PropertyFieldElement.md)

The field element whose editor receives the value.

##### mode?

[`PropertyGridMode`](../enumerations/PropertyGridMode.md)

The grid mode, used to apply insert defaults.

#### Returns

`void`

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

[`Widget`](Widget.md).[`registerClass`](Widget.md#registerclass)

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

[`Widget`](Widget.md).[`registerEditor`](Widget.md#registereditor)

***

### saveFieldValue()

> `static` **saveFieldValue**(`target`, `fieldElement`, `canModify?`): `void`

Defined in: [src/ui/widgets/propertygrid.tsx:576](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L576)

Saves a field's editor value into a target object when the item is
modifiable.

#### Parameters

##### target

`any`

The target object to write values into.

##### fieldElement

[`PropertyFieldElement`](../type-aliases/PropertyFieldElement.md)

The field element whose editor value is saved.

##### canModify?

`boolean`

Whether the item may be modified; defaults to the
  result of [PropertyGrid.canModifyItem](#canmodifyitem-2).

#### Returns

`void`

***

### updateFieldElement()

> `static` **updateFieldElement**(`fieldElement`, `mode?`, `canModify?`): `void`

Defined in: [src/ui/widgets/propertygrid.tsx:683](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/propertygrid.tsx#L683)

Updates a field element's editor read-only/required state and visibility
based on the item and mode.

#### Parameters

##### fieldElement

[`PropertyFieldElement`](../type-aliases/PropertyFieldElement.md)

The field element to update.

##### mode?

[`PropertyGridMode`](../enumerations/PropertyGridMode.md)

The grid mode.

##### canModify?

`boolean`

Whether the item may be modified.

#### Returns

`void`
