[@serenity-is/corelib](../README.md) / QuickSearchInput

# Class: QuickSearchInput\<P\>

Defined in: [src/ui/datagrid/quicksearchinput.tsx:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L54)

A text input that triggers a search after a short delay, with optional
field selection and loading/filtered visual states.

## Extends

- [`Widget`](Widget.md)\<`P`\>

## Type Parameters

### P

`P` *extends* [`QuickSearchInputOptions`](../interfaces/QuickSearchInputOptions.md) = [`QuickSearchInputOptions`](../interfaces/QuickSearchInputOptions.md)

Options type for the widget.

## Constructors

### Constructor

> **new QuickSearchInput**\<`P`\>(`props`): `QuickSearchInput`\<`P`\>

Defined in: [src/ui/datagrid/quicksearchinput.tsx:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L70)

Creates a quick search input widget.

#### Parameters

##### props

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Widget props forwarded to the base widget.

#### Returns

`QuickSearchInput`\<`P`\>

#### Overrides

[`Widget`](Widget.md).[`constructor`](Widget.md#constructor)

## Properties

### domNode

> `readonly` **domNode**: `HTMLInputElement`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L58)

The DOM node this widget is bound to.

#### Overrides

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

Defined in: [src/ui/datagrid/quicksearchinput.tsx:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L55)

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

### checkIfValueChanged()

> `protected` **checkIfValueChanged**(): `void`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L113)

Checks whether the input value changed and schedules a search if so.

#### Returns

`void`

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

Defined in: [src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

Destroys the widget, removing its association with the DOM node, its CSS
classes and its event handlers.

#### Returns

`void`

#### Inherited from

[`Widget`](Widget.md).[`destroy`](Widget.md#destroy)

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

### get\_field()

> **get\_field**(): [`QuickSearchField`](../interfaces/QuickSearchField.md)

Defined in: [src/ui/datagrid/quicksearchinput.tsx:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L150)

Returns the currently selected search field.

#### Returns

[`QuickSearchField`](../interfaces/QuickSearchField.md)

The active [QuickSearchField](../interfaces/QuickSearchField.md).

***

### get\_value()

> **get\_value**(): `string`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L142)

Returns the current trimmed input value.

#### Returns

`string`

The search query text.

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

Defined in: [src/ui/widgets/widget.ts:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L281)

Renders the widget's contents. Override this to provide custom content.

#### Returns

`any`

The rendered contents.

#### Inherited from

[`Widget`](Widget.md).[`renderContents`](Widget.md#rendercontents)

***

### restoreState()

> **restoreState**(`value`, `field`): `void`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L179)

Restores a previously persisted search state (text and field).

#### Parameters

##### value

`string`

The search text to restore.

##### field

[`QuickSearchField`](../interfaces/QuickSearchField.md)

The search field to restore.

#### Returns

`void`

***

### searchNow()

> `protected` **searchNow**(`value`): `void`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:197](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L197)

Executes the search for the given value, toggling loading/filtered states
and invoking the configured search callbacks.

#### Parameters

##### value

`string`

The search query text.

#### Returns

`void`

***

### set\_field()

> **set\_field**(`value`): `void`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L158)

Sets the active search field and refreshes the placeholder.

#### Parameters

##### value

[`QuickSearchField`](../interfaces/QuickSearchField.md)

The field to select.

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

### updateInputPlaceHolder()

> `protected` **updateInputPlaceHolder**(): `void`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L170)

Updates the field selector link text with the active field title.

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

> `static` **createDefaultElement**(): `HTMLInputElement`

Defined in: [src/ui/datagrid/quicksearchinput.tsx:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quicksearchinput.tsx#L57)

Creates the default DOM element for a widget.

#### Returns

`HTMLInputElement`

A new `div` element.

#### Overrides

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
