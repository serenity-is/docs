[@serenity-is/corelib](../README.md) / TimeSpanEditor

# Class: TimeSpanEditor\<P\>

Defined in: [src/ui/editors/timeeditor.ts:226](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L226)

This editor is for TimeSpan fields. It uses a string value in the format "HH:mm".

## Extends

- [`TimeEditorBase`](TimeEditorBase.md)\<`P`\>

## Type Parameters

### P

`P` *extends* [`TimeSpanEditorOptions`](../interfaces/TimeSpanEditorOptions.md) = [`TimeSpanEditorOptions`](../interfaces/TimeSpanEditorOptions.md)

## Constructors

### Constructor

> **new TimeSpanEditor**\<`P`\>(`props`): `TimeSpanEditor`\<`P`\>

Defined in: [src/ui/editors/timeeditor.ts:234](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L234)

Creates a time span editor.

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

Widget props.

#### Returns

`TimeSpanEditor`\<`P`\>

#### Overrides

[`TimeEditorBase`](TimeEditorBase.md).[`constructor`](TimeEditorBase.md#constructor)

## Properties

### domNode

> `readonly` **domNode**: `HTMLSelectElement`

Defined in: [src/ui/editors/timeeditor.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L31)

The hour select element that backs the editor.

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`domNode`](TimeEditorBase.md#domnode)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L22)

The id prefix used for this widget's child element ids.

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`idPrefix`](TimeEditorBase.md#idprefix)

***

### minutes

> `protected` **minutes**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/editors/timeeditor.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L33)

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`minutes`](TimeEditorBase.md#minutes)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>\>

Defined in: [src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

The widget's options/props.

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`options`](TimeEditorBase.md#options)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L20)

A unique name for this widget instance, used for event namespacing.

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`uniqueName`](TimeEditorBase.md#uniquename)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/editors/timeeditor.ts:228](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L228)

#### Overrides

[`TimeEditorBase`](TimeEditorBase.md).[`[typeInfo]`](TimeEditorBase.md#typeinfo)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:334](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L334)

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`isComponent`](TimeEditorBase.md#iscomponent)

## Accessors

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L82)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`element`](TimeEditorBase.md#element)

***

### hour

#### Get Signature

> **get** **hour**(): `number`

Defined in: [src/ui/editors/timeeditor.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L67)

Returns the selected hour.

##### Returns

`number`

The hour value.

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`hour`](TimeEditorBase.md#hour)

***

### hourAndMin

#### Get Signature

> **get** **hourAndMin**(): `string`

Defined in: [src/ui/editors/timeeditor.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L99)

Returns the combined time value in HH:mm format.

##### Returns

`string`

The time string, or null when empty.

#### Set Signature

> **set** **hourAndMin**(`value`): `void`

Defined in: [src/ui/editors/timeeditor.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L110)

Sets the combined time value in HH:mm format.

##### Parameters

###### value

`string`

The time string to set.

##### Returns

`void`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`hourAndMin`](TimeEditorBase.md#hourandmin)

***

### minute

#### Get Signature

> **get** **minute**(): `number`

Defined in: [src/ui/editors/timeeditor.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L75)

Returns the selected minute.

##### Returns

`number`

The minute value.

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`minute`](TimeEditorBase.md#minute)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L307)

Returns the widget's props/options.

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`props`](TimeEditorBase.md#props)

***

### readOnly

#### Get Signature

> **get** **readOnly**(): `boolean`

Defined in: [src/ui/editors/editorwidget.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorwidget.ts#L42)

Returns whether the editor is read-only.

##### Returns

`boolean`

True when read-only.

#### Set Signature

> **set** **readOnly**(`value`): `void`

Defined in: [src/ui/editors/editorwidget.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorwidget.ts#L48)

Sets whether the editor is read-only.

##### Parameters

###### value

`boolean`

##### Returns

`void`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`readOnly`](TimeEditorBase.md#readonly)

***

### value

#### Get Signature

> **get** **value**(): `string`

Defined in: [src/ui/editors/timeeditor.ts:258](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L258)

Returns the current time span value.

##### Returns

`string`

The value in "HH:mm" format.

#### Set Signature

> **set** **value**(`value`): `void`

Defined in: [src/ui/editors/timeeditor.ts:264](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L264)

Sets the time span value.

##### Parameters

###### value

`string`

The time span string to set.

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

[`TimeEditorBase`](TimeEditorBase.md).[`addCssClass`](TimeEditorBase.md#addcssclass)

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

[`TimeEditorBase`](TimeEditorBase.md).[`addValidationRule`](TimeEditorBase.md#addvalidationrule)

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

[`TimeEditorBase`](TimeEditorBase.md).[`addValidationRule`](TimeEditorBase.md#addvalidationrule)

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

[`TimeEditorBase`](TimeEditorBase.md).[`afterRender`](TimeEditorBase.md#afterrender)

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

[`TimeEditorBase`](TimeEditorBase.md).[`byId`](TimeEditorBase.md#byid)

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

[`TimeEditorBase`](TimeEditorBase.md).[`change`](TimeEditorBase.md#change)

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

[`TimeEditorBase`](TimeEditorBase.md).[`changeSelect2`](TimeEditorBase.md#changeselect2)

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

[`TimeEditorBase`](TimeEditorBase.md).[`deferRender`](TimeEditorBase.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

Destroys the widget, removing its association with the DOM node, its CSS
classes and its event handlers.

#### Returns

`void`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`destroy`](TimeEditorBase.md#destroy)

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

[`TimeEditorBase`](TimeEditorBase.md).[`findById`](TimeEditorBase.md#findbyid)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/ui/editors/timeeditor.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L83)

Returns whether the editor is read-only.

#### Returns

`boolean`

True when read-only.

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`get_readOnly`](TimeEditorBase.md#get_readonly)

***

### get\_value()

> `protected` **get\_value**(): `string`

Defined in: [src/ui/editors/timeeditor.ts:244](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L244)

Returns the current time span value.

#### Returns

`string`

The value in "HH:mm" format.

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

Returns the CSS class(es) applied to the widget's DOM node.

#### Returns

`string`

The space-separated CSS class string.

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`getCssClass`](TimeEditorBase.md#getcssclass)

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

[`TimeEditorBase`](TimeEditorBase.md).[`getCustomAttribute`](TimeEditorBase.md#getcustomattribute)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L171)

Returns the closest `.field` element containing the widget's DOM node.

#### Returns

[`Fluent`](../interfaces/Fluent.md)

A [Fluent](../functions/Fluent.md) wrapper for the grid field.

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`getGridField`](TimeEditorBase.md#getgridfield)

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L243)

Initializes the widget, rendering its contents if rendering was deferred.

#### Returns

`this`

This widget instance.

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`init`](TimeEditorBase.md#init)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L266)

Renders the widget's contents and runs any queued after-render callbacks.

#### Returns

`void`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`internalRenderContents`](TimeEditorBase.md#internalrendercontents)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L291)

Renders the widget from a legacy `getTemplate` string, if defined.

#### Returns

`boolean`

True if a legacy template was rendered.

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`legacyTemplateRender`](TimeEditorBase.md#legacytemplaterender)

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

[`TimeEditorBase`](TimeEditorBase.md).[`render`](TimeEditorBase.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/widgets/widget.ts:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L281)

Renders the widget's contents. Override this to provide custom content.

#### Returns

`any`

The rendered contents.

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`renderContents`](TimeEditorBase.md#rendercontents)

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

Defined in: [src/ui/editors/timeeditor.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L91)

Sets whether the editor is read-only.

#### Parameters

##### value

`boolean`

True to enable read-only mode.

#### Returns

`void`

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`set_readOnly`](TimeEditorBase.md#set_readonly)

***

### set\_value()

> `protected` **set\_value**(`value`): `void`

Defined in: [src/ui/editors/timeeditor.ts:250](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L250)

Sets the time span value.

#### Parameters

##### value

`string`

The time span value to set.

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

[`TimeEditorBase`](TimeEditorBase.md).[`syncOrAsyncThen`](TimeEditorBase.md#syncorasyncthen)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:329](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L329)

Returns an id prefix helper for resolving child element ids.

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

An [IdPrefixType](../type-aliases/IdPrefixType.md) proxy for this widget's id prefix.

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`useIdPrefix`](TimeEditorBase.md#useidprefix)

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

[`TimeEditorBase`](TimeEditorBase.md).[`create`](TimeEditorBase.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLElement`

Defined in: [src/ui/editors/timeeditor.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/timeeditor.ts#L29)

Creates the default select element for the time editor.

#### Returns

`HTMLElement`

The hour select element.

#### Inherited from

[`TimeEditorBase`](TimeEditorBase.md).[`createDefaultElement`](TimeEditorBase.md#createdefaultelement)

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

[`TimeEditorBase`](TimeEditorBase.md).[`getWidgetName`](TimeEditorBase.md#getwidgetname)

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

[`TimeEditorBase`](TimeEditorBase.md).[`registerClass`](TimeEditorBase.md#registerclass)

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

[`TimeEditorBase`](TimeEditorBase.md).[`registerEditor`](TimeEditorBase.md#registereditor)
