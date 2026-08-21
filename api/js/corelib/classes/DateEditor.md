[@serenity-is/corelib](../README.md) / DateEditor

# Class: DateEditor\<P\>

Defined in: [src/ui/editors/dateeditor.tsx:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L25)

An editor that renders a date input with a date picker.

## Extends

- [`EditorWidget`](EditorWidget.md)\<`P`\>

## Type Parameters

### P

`P` *extends* [`DateEditorOptions`](../interfaces/DateEditorOptions.md) = [`DateEditorOptions`](../interfaces/DateEditorOptions.md)

Widget props type.

## Implements

- [`IStringValue`](IStringValue.md)
- [`IReadOnly`](IReadOnly.md)

## Constructors

### Constructor

> **new DateEditor**\<`P`\>(`props`): `DateEditor`\<`P`\>

Defined in: [src/ui/editors/dateeditor.tsx:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L38)

Creates a date editor.

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

Widget props.

#### Returns

`DateEditor`\<`P`\>

#### Overrides

[`EditorWidget`](EditorWidget.md).[`constructor`](EditorWidget.md#constructor)

## Properties

### domNode

> `readonly` **domNode**: `HTMLInputElement`

Defined in: [src/ui/editors/dateeditor.tsx:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L32)

The text input element that backs the editor.

#### Overrides

[`EditorWidget`](EditorWidget.md).[`domNode`](EditorWidget.md#domnode)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L22)

The id prefix used for this widget's child element ids.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`idPrefix`](EditorWidget.md#idprefix)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>\>

Defined in: [src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

The widget's options/props.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`options`](EditorWidget.md#options)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L20)

A unique name for this widget instance, used for event namespacing.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`uniqueName`](EditorWidget.md#uniquename)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/editors/dateeditor.tsx:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L26)

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`[typeInfo]`](IReadOnly.md#typeinfo)

#### Overrides

[`EditorWidget`](EditorWidget.md).[`[typeInfo]`](EditorWidget.md#typeinfo)

***

### dateInputChange()

> `static` **dateInputChange**: (`e`) => `void`

Defined in: [src/ui/editors/dateeditor.tsx:316](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L316)

Handles date input change events.

#### Parameters

##### e

`Event`

#### Returns

`void`

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:334](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L334)

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`isComponent`](EditorWidget.md#iscomponent)

***

### useFlatpickr

> `static` **useFlatpickr**: `boolean`

Defined in: [src/ui/editors/dateeditor.tsx:328](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L328)

Whether to prefer flatpickr over jQuery UI datepicker.

## Accessors

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L82)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`element`](EditorWidget.md#element)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L307)

Returns the widget's props/options.

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`props`](EditorWidget.md#props)

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

[`EditorWidget`](EditorWidget.md).[`readOnly`](EditorWidget.md#readonly)

***

### value

#### Get Signature

> **get** **value**(): `string`

Defined in: [src/ui/editors/dateeditor.tsx:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L151)

Returns the current date value.

##### Returns

`string`

The date value.

#### Set Signature

> **set** **value**(`v`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L173)

Sets the date value.

##### Parameters

###### v

`string`

The date value to set.

##### Returns

`void`

***

### valueAsDate

#### Get Signature

> **get** **valueAsDate**(): `Date`

Defined in: [src/ui/editors/dateeditor.tsx:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L188)

Returns the current date value as a Date.

##### Returns

`Date`

The date value.

#### Set Signature

> **set** **valueAsDate**(`v`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L203)

Sets the date value as a Date.

##### Parameters

###### v

`Date`

The date value to set.

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

[`EditorWidget`](EditorWidget.md).[`addCssClass`](EditorWidget.md#addcssclass)

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

[`EditorWidget`](EditorWidget.md).[`addValidationRule`](EditorWidget.md#addvalidationrule)

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

[`EditorWidget`](EditorWidget.md).[`addValidationRule`](EditorWidget.md#addvalidationrule)

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

[`EditorWidget`](EditorWidget.md).[`afterRender`](EditorWidget.md#afterrender)

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

[`EditorWidget`](EditorWidget.md).[`byId`](EditorWidget.md#byid)

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

[`EditorWidget`](EditorWidget.md).[`change`](EditorWidget.md#change)

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

[`EditorWidget`](EditorWidget.md).[`changeSelect2`](EditorWidget.md#changeselect2)

***

### createFlatPickrTrigger()

> **createFlatPickrTrigger**(): `HTMLElement`

Defined in: [src/ui/editors/dateeditor.tsx:368](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L368)

Creates the flatpickr trigger button next to the input.

#### Returns

`HTMLElement`

The trigger element.

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

[`EditorWidget`](EditorWidget.md).[`deferRender`](EditorWidget.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/editors/dateeditor.tsx:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L126)

Cleans up the date picker instance.

#### Returns

`void`

#### Overrides

[`EditorWidget`](EditorWidget.md).[`destroy`](EditorWidget.md#destroy)

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

[`EditorWidget`](EditorWidget.md).[`findById`](EditorWidget.md#findbyid)

***

### get\_maxDate()

> **get\_maxDate**(): `Date`

Defined in: [src/ui/editors/dateeditor.tsx:280](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L280)

Returns the maximum allowed date as a Date.

#### Returns

`Date`

The maximum date.

***

### get\_maxValue()

> **get\_maxValue**(): `string`

Defined in: [src/ui/editors/dateeditor.tsx:248](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L248)

Returns the maximum allowed date value.

#### Returns

`string`

The maximum value.

***

### get\_minDate()

> **get\_minDate**(): `Date`

Defined in: [src/ui/editors/dateeditor.tsx:264](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L264)

Returns the minimum allowed date as a Date.

#### Returns

`Date`

The minimum date.

***

### get\_minValue()

> **get\_minValue**(): `string`

Defined in: [src/ui/editors/dateeditor.tsx:232](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L232)

Returns the minimum allowed date value.

#### Returns

`string`

The minimum value.

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/ui/editors/dateeditor.tsx:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L211)

Returns whether the editor is read-only.

#### Returns

`boolean`

True when read-only.

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`get_readOnly`](IReadOnly.md#get_readonly)

***

### get\_sqlMinMax()

> **get\_sqlMinMax**(): `boolean`

Defined in: [src/ui/editors/dateeditor.tsx:296](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L296)

Whether SQL min/max date bounds are applied.

#### Returns

`boolean`

True when SQL bounds are set.

***

### get\_value()

> **get\_value**(): `string`

Defined in: [src/ui/editors/dateeditor.tsx:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L138)

Returns the current date value in "yyyy-MM-dd" format.

#### Returns

`string`

The date value, or null when empty.

#### Implementation of

[`IStringValue`](IStringValue.md).[`get_value`](IStringValue.md#get_value)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

Returns the CSS class(es) applied to the widget's DOM node.

#### Returns

`string`

The space-separated CSS class string.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`getCssClass`](EditorWidget.md#getcssclass)

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

[`EditorWidget`](EditorWidget.md).[`getCustomAttribute`](EditorWidget.md#getcustomattribute)

***

### getFlatpickrOptions()

> **getFlatpickrOptions**(`input`): `any`

Defined in: [src/ui/editors/dateeditor.tsx:335](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L335)

Returns the flatpickr options for the given input.

#### Parameters

##### input

`HTMLElement`

The input element.

#### Returns

`any`

Flatpickr options.

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L171)

Returns the closest `.field` element containing the widget's DOM node.

#### Returns

[`Fluent`](../interfaces/Fluent.md)

A [Fluent](../functions/Fluent.md) wrapper for the grid field.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`getGridField`](EditorWidget.md#getgridfield)

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L243)

Initializes the widget, rendering its contents if rendering was deferred.

#### Returns

`this`

This widget instance.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`init`](EditorWidget.md#init)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L266)

Renders the widget's contents and runs any queued after-render callbacks.

#### Returns

`void`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`internalRenderContents`](EditorWidget.md#internalrendercontents)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L291)

Renders the widget from a legacy `getTemplate` string, if defined.

#### Returns

`boolean`

True if a legacy template was rendered.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`legacyTemplateRender`](EditorWidget.md#legacytemplaterender)

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

[`EditorWidget`](EditorWidget.md).[`render`](EditorWidget.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/widgets/widget.ts:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L281)

Renders the widget's contents. Override this to provide custom content.

#### Returns

`any`

The rendered contents.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`renderContents`](EditorWidget.md#rendercontents)

***

### set\_maxDate()

> **set\_maxDate**(`value`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:288](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L288)

Sets the maximum allowed date as a Date.

#### Parameters

##### value

`Date`

The maximum date.

#### Returns

`void`

***

### set\_maxValue()

> **set\_maxValue**(`value`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:256](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L256)

Sets the maximum allowed date value.

#### Parameters

##### value

`string`

The maximum value.

#### Returns

`void`

***

### set\_minDate()

> **set\_minDate**(`value`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:272](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L272)

Sets the minimum allowed date as a Date.

#### Parameters

##### value

`Date`

The minimum date.

#### Returns

`void`

***

### set\_minValue()

> **set\_minValue**(`value`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:240](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L240)

Sets the minimum allowed date value.

#### Parameters

##### value

`string`

The minimum value.

#### Returns

`void`

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L219)

Sets whether the editor is read-only.

#### Parameters

##### value

`boolean`

True to enable read-only mode.

#### Returns

`void`

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`set_readOnly`](IReadOnly.md#set_readonly)

***

### set\_sqlMinMax()

> **set\_sqlMinMax**(`value`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:304](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L304)

Sets whether SQL min/max date bounds are applied.

#### Parameters

##### value

`boolean`

True to apply SQL bounds.

#### Returns

`void`

***

### set\_value()

> **set\_value**(`value`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L159)

Sets the date value.

#### Parameters

##### value

`string`

The date value to set.

#### Returns

`void`

#### Implementation of

[`IStringValue`](IStringValue.md).[`set_value`](IStringValue.md#set_value)

***

### setToToday()

> **setToToday**(`triggerChange?`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L118)

Sets the value to today's date.

#### Parameters

##### triggerChange?

`boolean`

When true, triggers a change event.

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

[`EditorWidget`](EditorWidget.md).[`syncOrAsyncThen`](EditorWidget.md#syncorasyncthen)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:329](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L329)

Returns an id prefix helper for resolving child element ids.

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

An [IdPrefixType](../type-aliases/IdPrefixType.md) proxy for this widget's id prefix.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`useIdPrefix`](EditorWidget.md#useidprefix)

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

[`EditorWidget`](EditorWidget.md).[`create`](EditorWidget.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLInputElement`

Defined in: [src/ui/editors/dateeditor.tsx:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L30)

Creates the default text input element for the date editor.

#### Returns

`HTMLInputElement`

The input element.

#### Overrides

[`EditorWidget`](EditorWidget.md).[`createDefaultElement`](EditorWidget.md#createdefaultelement)

***

### dateInputKeyup()

> `static` **dateInputKeyup**(`e`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:323](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L323)

Handles keyup on date inputs to normalize typed dates.

#### Parameters

##### e

`KeyboardEvent`

Keyboard event.

#### Returns

`void`

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

[`EditorWidget`](EditorWidget.md).[`getWidgetName`](EditorWidget.md#getwidgetname)

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

[`EditorWidget`](EditorWidget.md).[`registerClass`](EditorWidget.md#registerclass)

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

[`EditorWidget`](EditorWidget.md).[`registerEditor`](EditorWidget.md#registereditor)

***

### uiPickerZIndexWorkaround()

> `static` **uiPickerZIndexWorkaround**(`el`): `void`

Defined in: [src/ui/editors/dateeditor.tsx:377](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateeditor.tsx#L377)

Applies a z-index workaround for the jQuery UI datepicker popup.

#### Parameters

##### el

The input element or array-like collection.

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

#### Returns

`void`
