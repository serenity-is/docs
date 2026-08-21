[@serenity-is/corelib](../README.md) / FilterPanel

# Class: FilterPanel\<P\>

Defined in: [src/ui/filtering/filterpanel.tsx:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L108)

A panel for building filter criteria with multiple filter lines.

## Extends

- [`FilterWidgetBase`](FilterWidgetBase.md)\<`P`\>

## Type Parameters

### P

`P` = \{ \}

Widget props type.

## Constructors

### Constructor

> **new FilterPanel**\<`P`\>(`props`): `FilterPanel`\<`P`\>

Defined in: [src/ui/filtering/filterpanel.tsx:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L119)

Creates a filter panel.

#### Parameters

##### props

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Widget props.

#### Returns

`FilterPanel`\<`P`\>

#### Overrides

[`FilterWidgetBase`](FilterWidgetBase.md).[`constructor`](FilterWidgetBase.md#constructor)

## Properties

### domNode

> `readonly` **domNode**: `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L24)

The DOM node this widget is bound to.

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`domNode`](FilterWidgetBase.md#domnode)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L22)

The id prefix used for this widget's child element ids.

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`idPrefix`](FilterWidgetBase.md#idprefix)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

The widget's options/props.

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`options`](FilterWidgetBase.md#options)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L20)

A unique name for this widget instance, used for event namespacing.

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`uniqueName`](FilterWidgetBase.md#uniquename)

***

### updateStoreOnReset

> **updateStoreOnReset**: `boolean`

Defined in: [src/ui/filtering/filterpanel.tsx:217](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L217)

Whether the store is updated when the panel is reset.

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/filtering/filterpanel.tsx:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L109)

#### Overrides

[`FilterWidgetBase`](FilterWidgetBase.md).[`[typeInfo]`](FilterWidgetBase.md#typeinfo)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:334](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L334)

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`isComponent`](FilterWidgetBase.md#iscomponent)

## Accessors

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L82)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`element`](FilterWidgetBase.md#element)

***

### hasErrors

#### Get Signature

> **get** **hasErrors**(): `boolean`

Defined in: [src/ui/filtering/filterpanel.tsx:254](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L254)

Whether the panel has validation errors.

##### Returns

`boolean`

True when errors exist.

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L307)

Returns the widget's props/options.

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`props`](FilterWidgetBase.md#props)

***

### showInitialLine

#### Get Signature

> **get** **showInitialLine**(): `boolean`

Defined in: [src/ui/filtering/filterpanel.tsx:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L133)

Whether an initial empty line is shown.

##### Returns

`boolean`

True when shown.

#### Set Signature

> **set** **showInitialLine**(`value`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L138)

Sets whether an initial empty line is shown.

##### Parameters

###### value

`boolean`

##### Returns

`void`

***

### showSearchButton

#### Get Signature

> **get** **showSearchButton**(): `boolean`

Defined in: [src/ui/filtering/filterpanel.tsx:204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L204)

Whether the search button is shown.

##### Returns

`boolean`

True when shown.

#### Set Signature

> **set** **showSearchButton**(`value`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:209](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L209)

Sets whether the search button is shown.

##### Parameters

###### value

`boolean`

##### Returns

`void`

## Methods

### addButtonClick()

> `protected` **addButtonClick**(`e`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:329](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L329)

Handles the add-button click.

#### Parameters

##### e

`Event`

The click event.

#### Returns

`void`

***

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/widgets/widget.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L89)

Adds the widget's CSS class to its DOM node.

#### Returns

`void`

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`addCssClass`](FilterWidgetBase.md#addcssclass)

***

### addEmptyRow()

> `protected` **addEmptyRow**(`popupField`): `HTMLElement`

Defined in: [src/ui/filtering/filterpanel.tsx:381](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L381)

Adds an empty filter row.

#### Parameters

##### popupField

`boolean`

Whether to open the field dropdown.

#### Returns

`HTMLElement`

The new row element.

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`addValidationRule`](FilterWidgetBase.md#addvalidationrule)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`addValidationRule`](FilterWidgetBase.md#addvalidationrule)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`afterRender`](FilterWidgetBase.md#afterrender)

***

### andOrClick()

> `protected` **andOrClick**(`e`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:593](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L593)

Handles the and/or toggle click.

#### Parameters

##### e

`Event`

The click event.

#### Returns

`void`

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`byId`](FilterWidgetBase.md#byid)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`change`](FilterWidgetBase.md#change)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`changeSelect2`](FilterWidgetBase.md#changeselect2)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`deferRender`](FilterWidgetBase.md#deferrender)

***

### deleteRowClick()

> `protected` **deleteRowClick**(`e`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:568](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L568)

Handles the delete-row click.

#### Parameters

##### e

`Event`

The click event.

#### Returns

`void`

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/filtering/filterwidgetbase.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L31)

Cleans up the filter store subscription.

#### Returns

`void`

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`destroy`](FilterWidgetBase.md#destroy)

***

### filterStoreChanged()

> `protected` **filterStoreChanged**(): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L150)

Updates the rows when the filter store changes.

#### Returns

`void`

#### Overrides

[`FilterWidgetBase`](FilterWidgetBase.md).[`filterStoreChanged`](FilterWidgetBase.md#filterstorechanged)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`findById`](FilterWidgetBase.md#findbyid)

***

### findEmptyRow()

> `protected` **findEmptyRow**(): `HTMLElement`

Defined in: [src/ui/filtering/filterpanel.tsx:359](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L359)

Finds an empty row, if any.

#### Returns

`HTMLElement`

The empty row element, or null.

***

### get\_hasErrors()

> `protected` **get\_hasErrors**(): `boolean`

Defined in: [src/ui/filtering/filterpanel.tsx:263](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L263)

Whether the panel has validation errors.

#### Returns

`boolean`

True when errors exist.

***

### get\_store()

> **get\_store**(): [`FilterStore`](FilterStore.md)

Defined in: [src/ui/filtering/filterwidgetbase.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L52)

Returns the filter store.

#### Returns

[`FilterStore`](FilterStore.md)

The filter store.

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`get_store`](FilterWidgetBase.md#get_store)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

Returns the CSS class(es) applied to the widget's DOM node.

#### Returns

`string`

The space-separated CSS class string.

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`getCssClass`](FilterWidgetBase.md#getcssclass)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`getCustomAttribute`](FilterWidgetBase.md#getcustomattribute)

***

### getFieldFor()

> `protected` **getFieldFor**(`row`): [`PropertyItem`](../interfaces/PropertyItem.md)

Defined in: [src/ui/filtering/filterpanel.tsx:475](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L475)

Returns the field for a row.

#### Parameters

##### row

`HTMLElement`

The row element.

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

The field, or null.

***

### getFilteringFor()

> `protected` **getFilteringFor**(`row`): [`IFiltering`](IFiltering.md)

Defined in: [src/ui/filtering/filterpanel.tsx:493](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L493)

Returns the filtering handler for a row.

#### Parameters

##### row

`HTMLElement`

The row element.

#### Returns

[`IFiltering`](IFiltering.md)

The filtering handler, or null.

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L171)

Returns the closest `.field` element containing the widget's DOM node.

#### Returns

[`Fluent`](../interfaces/Fluent.md)

A [Fluent](../functions/Fluent.md) wrapper for the grid field.

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`getGridField`](FilterWidgetBase.md#getgridfield)

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L243)

Initializes the widget, rendering its contents if rendering was deferred.

#### Returns

`this`

This widget instance.

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`init`](FilterWidgetBase.md#init)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L266)

Renders the widget's contents and runs any queued after-render callbacks.

#### Returns

`void`

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`internalRenderContents`](FilterWidgetBase.md#internalrendercontents)

***

### leftRightParenClick()

> `protected` **leftRightParenClick**(`e`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:604](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L604)

Handles the left/right parenthesis click.

#### Parameters

##### e

`Event`

The click event.

#### Returns

`void`

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L291)

Renders the widget from a legacy `getTemplate` string, if defined.

#### Returns

`boolean`

True if a legacy template was rendered.

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`legacyTemplateRender`](FilterWidgetBase.md#legacytemplaterender)

***

### onRowFieldChange()

> `protected` **onRowFieldChange**(`e`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:423](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L423)

Handles the field change event.

#### Parameters

##### e

`Event`

The change event.

#### Returns

`void`

***

### onRowOperatorChange()

> `protected` **onRowOperatorChange**(`e`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:520](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L520)

Handles the operator change event.

#### Parameters

##### e

`Event`

The change event.

#### Returns

`void`

***

### populateOperatorList()

> `protected` **populateOperatorList**(`row`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:455](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L455)

Populates the operator list for a row.

#### Parameters

##### row

`HTMLElement`

The row element.

#### Returns

`void`

***

### removeFiltering()

> `protected` **removeFiltering**(`row`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:446](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L446)

Removes the filtering handler from a row.

#### Parameters

##### row

`HTMLElement`

The row element.

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`render`](FilterWidgetBase.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/filtering/filterpanel.tsx:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L223)

Renders the filter panel contents.

#### Returns

`any`

The rendered content.

#### Overrides

[`FilterWidgetBase`](FilterWidgetBase.md).[`renderContents`](FilterWidgetBase.md#rendercontents)

***

### resetButtonClick()

> `protected` **resetButtonClick**(`e`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:338](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L338)

Handles the reset-button click.

#### Parameters

##### e

`Event`

The click event.

#### Returns

`void`

***

### rowFieldChange()

> `protected` **rowFieldChange**(`row`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:433](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L433)

Handles a field change for a row.

#### Parameters

##### row

`HTMLElement`

The row element.

#### Returns

`void`

***

### rowOperatorChange()

> `protected` **rowOperatorChange**(`row`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:535](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L535)

Handles an operator change for a row.

#### Parameters

##### row

`HTMLElement`

The row element.

#### Returns

`void`

***

### search()

> **search**(): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:270](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L270)

Builds filter lines from the current rows and updates the store.

#### Returns

`void`

***

### searchButtonClick()

> `protected` **searchButtonClick**(`e`): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:245](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L245)

Handles the search button click.

#### Parameters

##### e

`Event`

The click event.

#### Returns

`void`

***

### set\_store()

> **set\_store**(`value`): `void`

Defined in: [src/ui/filtering/filterwidgetbase.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterwidgetbase.ts#L60)

Sets the filter store and subscribes to its changes.

#### Parameters

##### value

[`FilterStore`](FilterStore.md)

The filter store.

#### Returns

`void`

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`set_store`](FilterWidgetBase.md#set_store)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`syncOrAsyncThen`](FilterWidgetBase.md#syncorasyncthen)

***

### updateButtons()

> `protected` **updateButtons**(): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:584](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L584)

Updates the visibility of the search and reset buttons.

#### Returns

`void`

***

### updateParens()

> `protected` **updateParens**(): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:613](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L613)

Updates the parenthesis indicators for all rows.

#### Returns

`void`

***

### updateRowsFromStore()

> **updateRowsFromStore**(): `void`

Defined in: [src/ui/filtering/filterpanel.tsx:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterpanel.tsx#L158)

Rebuilds the filter rows from the store.

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`useIdPrefix`](FilterWidgetBase.md#useidprefix)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`create`](FilterWidgetBase.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L75)

Creates the default DOM element for a widget.

#### Returns

`HTMLElement`

A new `div` element.

#### Inherited from

[`FilterWidgetBase`](FilterWidgetBase.md).[`createDefaultElement`](FilterWidgetBase.md#createdefaultelement)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`getWidgetName`](FilterWidgetBase.md#getwidgetname)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`registerClass`](FilterWidgetBase.md#registerclass)

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

[`FilterWidgetBase`](FilterWidgetBase.md).[`registerEditor`](FilterWidgetBase.md#registereditor)
