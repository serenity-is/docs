[@serenity-is/corelib](../README.md) / EntityDialog

# Class: EntityDialog\<TItem, P\>

Defined in: [src/ui/dialogs/entitydialog.tsx:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L23)

Base dialog for editing entities, integrating property grids, save/delete
operations, localization, and toolbar buttons.

## Extends

- [`BaseDialog`](BaseDialog.md)\<`P`\>

## Type Parameters

### TItem

`TItem`

Entity row type.

### P

`P` = \{ \}

Widget props type.

## Implements

- [`IEditDialog`](IEditDialog.md)
- [`IReadOnly`](IReadOnly.md)

## Constructors

### Constructor

> **new EntityDialog**\<`TItem`, `P`\>(`props?`): `EntityDialog`\<`TItem`, `P`\>

Defined in: [src/ui/dialogs/entitydialog.tsx:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L47)

Creates an entity dialog and loads property items.

#### Parameters

##### props?

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Widget props forwarded to the base dialog.

#### Returns

`EntityDialog`\<`TItem`, `P`\>

#### Overrides

[`BaseDialog`](BaseDialog.md).[`constructor`](BaseDialog.md#constructor)

## Properties

### applyChangesButton

> `protected` **applyChangesButton**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L34)

***

### cloneButton

> `protected` **cloneButton**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L37)

***

### deleteButton

> `protected` **deleteButton**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L35)

***

### dialog

> `protected` **dialog**: [`Dialog`](Dialog.md)

Defined in: [src/ui/dialogs/basedialog.tsx:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L25)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`dialog`](BaseDialog.md#dialog)

***

### domNode

> `readonly` **domNode**: `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L24)

The DOM node this widget is bound to.

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`domNode`](BaseDialog.md#domnode)

***

### editButton

> `protected` **editButton**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L38)

***

### editClicked

> `protected` **editClicked**: `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:1188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1188)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L22)

The id prefix used for this widget's child element ids.

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`idPrefix`](BaseDialog.md#idprefix)

***

### localizer

> `protected` **localizer**: [`EntityLocalizer`](EntityLocalizer.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L40)

***

### localizerButton

> `protected` **localizerButton**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L41)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

The widget's options/props.

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`options`](BaseDialog.md#options)

***

### propertyGrid

> `protected` **propertyGrid**: [`PropertyGrid`](PropertyGrid.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L31)

***

### propertyItemsData

> `protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L30)

***

### saveAndCloseButton

> `protected` **saveAndCloseButton**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L33)

***

### tabs

> `protected` **tabs**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Defined in: [src/ui/dialogs/basedialog.tsx:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L22)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`tabs`](BaseDialog.md#tabs)

***

### toolbar

> `protected` **toolbar**: [`Toolbar`](Toolbar.md)

Defined in: [src/ui/dialogs/basedialog.tsx:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L23)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`toolbar`](BaseDialog.md#toolbar)

***

### undeleteButton

> `protected` **undeleteButton**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L36)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L20)

A unique name for this widget instance, used for event namespacing.

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`uniqueName`](BaseDialog.md#uniquename)

***

### validator

> `protected` **validator**: `any`

Defined in: [src/ui/dialogs/basedialog.tsx:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L24)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`validator`](BaseDialog.md#validator)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/dialogs/entitydialog.tsx:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L25)

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`[typeInfo]`](IReadOnly.md#typeinfo)

#### Overrides

[`BaseDialog`](BaseDialog.md).[`[typeInfo]`](BaseDialog.md#typeinfo)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:334](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L334)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`isComponent`](BaseDialog.md#iscomponent)

## Accessors

### dialogTitle

#### Get Signature

> **get** **dialogTitle**(): `string`

Defined in: [src/ui/dialogs/basedialog.tsx:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L291)

Returns the current dialog title.

##### Returns

`string`

The dialog title.

#### Set Signature

> **set** **dialogTitle**(`value`): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:296](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L296)

Sets the dialog title.

##### Parameters

###### value

`string`

##### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`dialogTitle`](BaseDialog.md#dialogtitle)

***

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L82)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`element`](BaseDialog.md#element)

***

### entity

#### Get Signature

> **get** **entity**(): `TItem`

Defined in: [src/ui/dialogs/entitydialog.tsx:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L97)

Returns the current entity.

##### Returns

`TItem`

The entity.

#### Set Signature

> **set** **entity**(`value`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L102)

Sets the current entity.

##### Parameters

###### value

`TItem`

##### Returns

`void`

***

### entityId

#### Get Signature

> **get** **entityId**(): `any`

Defined in: [src/ui/dialogs/entitydialog.tsx:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L115)

Returns the current entity id.

##### Returns

`any`

The entity id.

#### Set Signature

> **set** **entityId**(`value`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L120)

Sets the current entity id.

##### Parameters

###### value

`any`

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

[`BaseDialog`](BaseDialog.md).[`props`](BaseDialog.md#props)

***

### readOnly

#### Get Signature

> **get** **readOnly**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:1083](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1083)

Whether the dialog is in read-only mode.

##### Returns

`boolean`

#### Set Signature

> **set** **readOnly**(`value`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:1088](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1088)

Sets whether the dialog is in read-only mode.

##### Parameters

###### value

`boolean`

##### Returns

`void`

***

### defaultLanguageList

#### Get Signature

> **get** `static` **defaultLanguageList**(): `string`[][]

Defined in: [src/ui/dialogs/entitydialog.tsx:1229](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1229)

Returns the default language list for localization.

##### Returns

`string`[][]

The default language list.

#### Set Signature

> **set** `static` **defaultLanguageList**(`value`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:1234](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1234)

Sets the default language list for localization.

##### Parameters

###### value

`string`[][]

##### Returns

`void`

## Methods

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L73)

Hook for subclasses to add CSS classes; the class goes to the dialog/modal/panel element.

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`addCssClass`](BaseDialog.md#addcssclass)

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

[`BaseDialog`](BaseDialog.md).[`addValidationRule`](BaseDialog.md#addvalidationrule)

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

[`BaseDialog`](BaseDialog.md).[`addValidationRule`](BaseDialog.md#addvalidationrule)

***

### afterInit()

> `protected` **afterInit**(): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L69)

Hook invoked after the dialog is initialized.

#### Returns

`void`

***

### afterLoadEntity()

> `protected` **afterLoadEntity**(): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:530](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L530)

Hook invoked after loading an entity; updates the interface and title.

#### Returns

`void`

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

[`BaseDialog`](BaseDialog.md).[`afterRender`](BaseDialog.md#afterrender)

***

### arrange()

> **arrange**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:248](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L248)

Triggers layout on all elements that require it.

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`arrange`](BaseDialog.md#arrange)

***

### beforeLoadEntity()

> `protected` **beforeLoadEntity**(`entity`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:523](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L523)

Hook invoked before loading an entity; clears localization state.

#### Parameters

##### entity

`TItem`

The entity being loaded.

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

[`BaseDialog`](BaseDialog.md).[`byId`](BaseDialog.md#byid)

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

[`BaseDialog`](BaseDialog.md).[`change`](BaseDialog.md#change)

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

[`BaseDialog`](BaseDialog.md).[`changeSelect2`](BaseDialog.md#changeselect2)

***

### commitEdits()

> `protected` **commitEdits**(): `Promise`\<`boolean`\>

Defined in: [src/ui/dialogs/entitydialog.tsx:765](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L765)

Commits pending edits in the property grid.

#### Returns

`Promise`\<`boolean`\>

True when the commit succeeds.

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

[`BaseDialog`](BaseDialog.md).[`deferRender`](BaseDialog.md#deferrender)

***

### deleteHandler()

> `protected` **deleteHandler**(`options`, `callback`): `PromiseLike`\<[`DeleteResponse`](../interfaces/DeleteResponse.md)\>

Defined in: [src/ui/dialogs/entitydialog.tsx:241](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L241)

Executes the delete service call.

#### Parameters

##### options

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`DeleteResponse`](../interfaces/DeleteResponse.md)\>

Service options.

##### callback

(`response`) => `void`

Callback invoked on success.

#### Returns

`PromiseLike`\<[`DeleteResponse`](../interfaces/DeleteResponse.md)\>

A promise resolving to the delete response.

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L83)

Cleans up the property grid, localizer, and toolbar buttons.

#### Returns

`void`

#### Overrides

[`BaseDialog`](BaseDialog.md).[`destroy`](BaseDialog.md#destroy)

***

### dialogClose()

> **dialogClose**(`result?`): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:283](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L283)

Closes the dialog with the given result.

#### Parameters

##### result?

`string`

The close result.

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`dialogClose`](BaseDialog.md#dialogclose)

***

### dialogOpen()

> **dialogOpen**(`asPanel?`): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L158)

Opens the dialog, optionally as a panel.

#### Parameters

##### asPanel?

`boolean`

When true, opens as a panel instead of a modal dialog.

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`dialogOpen`](BaseDialog.md#dialogopen)

***

### doDelete()

> `protected` **doDelete**(`callback`): `PromiseLike`\<[`DeleteResponse`](../interfaces/DeleteResponse.md)\>

Defined in: [src/ui/dialogs/entitydialog.tsx:258](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L258)

Deletes the current entity.

#### Parameters

##### callback

(`response`) => `void`

Callback invoked on success.

#### Returns

`PromiseLike`\<[`DeleteResponse`](../interfaces/DeleteResponse.md)\>

A promise resolving to the delete response.

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

[`BaseDialog`](BaseDialog.md).[`findById`](BaseDialog.md#findbyid)

***

### ~~get\_entityId()~~

> `protected` **get\_entityId**(): `any`

Defined in: [src/ui/dialogs/entitydialog.tsx:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L107)

#### Returns

`any`

#### Deprecated

use entityId

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:1096](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1096)

Returns whether the dialog is in read-only mode.

#### Returns

`boolean`

True when read-only.

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`get_readOnly`](IReadOnly.md#get_readonly)

***

### getCloningEntity()

> `protected` **getCloningEntity**(): `TItem`

Defined in: [src/ui/dialogs/entitydialog.tsx:991](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L991)

Returns a clone of the current entity with identity and state fields removed.

#### Returns

`TItem`

The cloning entity.

***

### getConcurrencyVersionProperty()

> `protected` **getConcurrencyVersionProperty**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:414](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L414)

Returns the concurrency version property for the entity, if any.

#### Returns

`string`

The concurrency version property name.

***

### getCreateServiceMethod()

> `protected` **getCreateServiceMethod**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:785](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L785)

Returns the create service method name.

#### Returns

`string`

The service method.

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

Returns the CSS class(es) applied to the widget's DOM node.

#### Returns

`string`

The space-separated CSS class string.

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getCssClass`](BaseDialog.md#getcssclass)

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

[`BaseDialog`](BaseDialog.md).[`getCustomAttribute`](BaseDialog.md#getcustomattribute)

***

### getDeleteOptions()

> `protected` **getDeleteOptions**(`callback`): [`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`DeleteResponse`](../interfaces/DeleteResponse.md)\>

Defined in: [src/ui/dialogs/entitydialog.tsx:218](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L218)

Returns the options for the delete service call.

#### Parameters

##### callback

(`response`) => `void`

Callback invoked on success.

#### Returns

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`DeleteResponse`](../interfaces/DeleteResponse.md)\>

Service options.

***

### getDeletePermission()

> `protected` **getDeletePermission**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:1132](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1132)

Returns the delete permission for the entity.

#### Returns

`string`

The delete permission, or undefined.

***

### getDeleteRequest()

> `protected` **getDeleteRequest**(): [`DeleteRequest`](../interfaces/DeleteRequest.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L207)

Returns the delete request for the current entity.

#### Returns

[`DeleteRequest`](../interfaces/DeleteRequest.md)

The delete request.

***

### getDeleteServiceMethod()

> `protected` **getDeleteServiceMethod**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:249](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L249)

Returns the delete service method name.

#### Returns

`string`

The service method.

***

### getDialogButtons()

> `protected` **getDialogButtons**(): [`DialogButton`](../interfaces/DialogButton.md)[]

Defined in: [src/ui/dialogs/basedialog.tsx:275](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L275)

Returns the dialog buttons for this dialog.

#### Returns

[`DialogButton`](../interfaces/DialogButton.md)[]

Dialog button definitions.

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getDialogButtons`](BaseDialog.md#getdialogbuttons)

***

### getDialogOptions()

> `protected` **getDialogOptions**(): [`DialogOptions`](../interfaces/DialogOptions.md)

Defined in: [src/ui/dialogs/basedialog.tsx:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L97)

Returns the options used to create the underlying dialog.

#### Returns

[`DialogOptions`](../interfaces/DialogOptions.md)

Dialog options.

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getDialogOptions`](BaseDialog.md#getdialogoptions)

***

### getEntityNameFieldValue()

> `protected` **getEntityNameFieldValue**(): `any`

Defined in: [src/ui/dialogs/entitydialog.tsx:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L128)

Returns the value of the entity name field.

#### Returns

`any`

The name field value.

***

### getEntitySingular()

> `protected` **getEntitySingular**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:351](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L351)

Returns the localized singular name for the entity.

#### Returns

`string`

The entity singular name.

***

### getEntityTitle()

> `protected` **getEntityTitle**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:136](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L136)

Returns the title for the dialog based on the current mode.

#### Returns

`string`

The dialog title.

***

### getEntityType()

> `protected` **getEntityType**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:284](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L284)

Returns the entity type name derived from the dialog class name.

#### Returns

`string`

The entity type.

***

### getFormKey()

> `protected` **getFormKey**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:309](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L309)

Returns the form key used to load property items.

#### Returns

`string`

The form key.

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L171)

Returns the closest `.field` element containing the widget's DOM node.

#### Returns

[`Fluent`](../interfaces/Fluent.md)

A [Fluent](../functions/Fluent.md) wrapper for the grid field.

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getGridField`](BaseDialog.md#getgridfield)

***

### getIdProperty()

> `protected` **getIdProperty**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:381](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L381)

Returns the id property for the entity.

#### Returns

`string`

The id property name.

***

### getInitialDialogTitle()

> `protected` **getInitialDialogTitle**(): `string`

Defined in: [src/ui/dialogs/basedialog.tsx:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L81)

Returns the initial dialog title.

#### Returns

`string`

The initial title text.

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getInitialDialogTitle`](BaseDialog.md#getinitialdialogtitle)

***

### getInsertPermission()

> `protected` **getInsertPermission**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:1116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1116)

Returns the insert permission for the entity.

#### Returns

`string`

The insert permission, or undefined.

***

### getIsActiveProperty()

> `protected` **getIsActiveProperty**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:398](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L398)

Returns the is-active property for the entity.

#### Returns

`string`

The is-active property name.

***

### getIsDeletedProperty()

> `protected` **getIsDeletedProperty**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:406](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L406)

#### Returns

`string`

***

### getLanguages()

> `protected` **getLanguages**(): [`LanguageList`](../type-aliases/LanguageList.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:685](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L685)

Returns the list of languages for localization.

#### Returns

[`LanguageList`](../type-aliases/LanguageList.md)

The language list.

***

### getLoadByIdOptions()

> `protected` **getLoadByIdOptions**(`id`, `callback`): [`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>\>

Defined in: [src/ui/dialogs/entitydialog.tsx:570](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L570)

Returns the options for the retrieve service call.

#### Parameters

##### id

`any`

The entity id to load.

##### callback

(`response`) => `void`

Callback invoked on success.

#### Returns

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>\>

Service options.

***

### getLoadByIdRequest()

> `protected` **getLoadByIdRequest**(`id`): [`RetrieveRequest`](../interfaces/RetrieveRequest.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:588](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L588)

Returns the retrieve request for an entity id.

#### Parameters

##### id

`any`

The entity id.

#### Returns

[`RetrieveRequest`](../interfaces/RetrieveRequest.md)

The retrieve request.

***

### getLocalizerOptions()

> `protected` **getLocalizerOptions**(): [`EntityLocalizerOptions`](../interfaces/EntityLocalizerOptions.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:656](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L656)

Returns the options for the entity localizer.

#### Returns

[`EntityLocalizerOptions`](../interfaces/EntityLocalizerOptions.md)

Localizer options.

***

### getLocalTextDbPrefix()

> `protected` **getLocalTextDbPrefix**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:322](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L322)

Returns the local text database prefix for this dialog.

#### Returns

`string`

The local text db prefix.

***

### getLocalTextPrefix()

> `protected` **getLocalTextPrefix**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:338](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L338)

Returns the local text prefix for this dialog.

#### Returns

`string`

The local text prefix.

***

### getNameProperty()

> `protected` **getNameProperty**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:364](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L364)

Returns the name property for the entity.

#### Returns

`string`

The name property name.

***

### getPropertyGridOptions()

> `protected` **getPropertyGridOptions**(): [`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:752](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L752)

Returns the options for the property grid.

#### Returns

[`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

Property grid options.

***

### getPropertyItems()

> `protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

Defined in: [src/ui/dialogs/entitydialog.tsx:716](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L716)

Returns the property items for this dialog.

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

The property items.

***

### getPropertyItemsData()

> `protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:724](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L724)

Loads the property items data, either from script data or local items.

#### Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

The property items data.

***

### getPropertyItemsDataAsync()

> `protected` **getPropertyItemsDataAsync**(): `Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

Defined in: [src/ui/dialogs/entitydialog.tsx:743](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L743)

Asynchronously loads the property items data.

#### Returns

`Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

A promise resolving to the property items data.

***

### getRetrieveServiceMethod()

> `protected` **getRetrieveServiceMethod**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:605](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L605)

Returns the retrieve service method name.

#### Returns

`string`

The service method.

***

### getRowDefinition()

> `protected` **getRowDefinition**(): [`IRowDefinition`](../interfaces/IRowDefinition.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:274](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L274)

Returns the row definition for this dialog.

#### Returns

[`IRowDefinition`](../interfaces/IRowDefinition.md)

The row definition, or null.

***

### getSaveEntity()

> `protected` **getSaveEntity**(): `TItem`

Defined in: [src/ui/dialogs/entitydialog.tsx:824](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L824)

Returns the entity populated from the property grid.

#### Returns

`TItem`

The saved entity.

***

### getSaveOptions()

> `protected` **getSaveOptions**(`callback`, `initiator?`): [`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`SaveResponse`](../interfaces/SaveResponse.md)\>

Defined in: [src/ui/dialogs/entitydialog.tsx:803](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L803)

Returns the options for the save service call.

#### Parameters

##### callback

(`response`) => `void`

Callback invoked on success.

##### initiator?

[`SaveInitiator`](../type-aliases/SaveInitiator.md)

How the save was initiated.

#### Returns

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`SaveResponse`](../interfaces/SaveResponse.md)\>

Service options.

***

### getSaveRequest()

> `protected` **getSaveRequest**(): [`SaveRequest`](../interfaces/SaveRequest.md)\<`TItem`\>

Defined in: [src/ui/dialogs/entitydialog.tsx:851](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L851)

Returns the save request for the current entity.

#### Returns

[`SaveRequest`](../interfaces/SaveRequest.md)\<`TItem`\>

The save request.

***

### getService()

> `protected` **getService**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:420](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L420)

#### Returns

`string`

***

### getToolbarButtons()

> `protected` **getToolbarButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

Defined in: [src/ui/dialogs/entitydialog.tsx:918](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L918)

Returns the toolbar buttons for the entity dialog.

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

Tool button definitions.

#### Overrides

[`BaseDialog`](BaseDialog.md).[`getToolbarButtons`](BaseDialog.md#gettoolbarbuttons)

***

### getUndeleteOptions()

> `protected` **getUndeleteOptions**(`callback?`): [`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`UndeleteResponse`](../interfaces/UndeleteResponse.md)\>

Defined in: [src/ui/dialogs/entitydialog.tsx:1035](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1035)

Returns the options for the undelete service call.

#### Parameters

##### callback?

(`response`) => `void`

Optional callback invoked on success.

#### Returns

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`UndeleteResponse`](../interfaces/UndeleteResponse.md)\>

Service options.

***

### getUndeletePermission()

> `protected` **getUndeletePermission**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:1149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1149)

Returns the permission key required to undelete a row.

#### Returns

`string`

Undelete permission or undefined.

***

### getUndeleteRequest()

> `protected` **getUndeleteRequest**(): [`UndeleteRequest`](../interfaces/UndeleteRequest.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:1026](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1026)

Returns the undelete request for the current entity.

#### Returns

[`UndeleteRequest`](../interfaces/UndeleteRequest.md)

The undelete request.

***

### getUndeleteServiceMethod()

> `protected` **getUndeleteServiceMethod**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:1066](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1066)

Returns the undelete service method name.

#### Returns

`string`

The service method.

***

### getUpdatePermission()

> `protected` **getUpdatePermission**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:1124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1124)

Returns the update permission for the entity.

#### Returns

`string`

The update permission, or undefined.

***

### getUpdateServiceMethod()

> `protected` **getUpdateServiceMethod**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:793](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L793)

Returns the update service method name.

#### Returns

`string`

The service method.

***

### getValidatorOptions()

> `protected` **getValidatorOptions**(): `any`

Defined in: [src/ui/dialogs/basedialog.tsx:215](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L215)

Returns the validator options for the form.

#### Returns

`any`

Validator options.

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getValidatorOptions`](BaseDialog.md#getvalidatoroptions)

***

### handleResponsive()

> `protected` **handleResponsive**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:314](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L314)

Handles responsive layout for the dialog.

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`handleResponsive`](BaseDialog.md#handleresponsive)

***

### hasDeletePermission()

> `protected` **hasDeletePermission**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:1140](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1140)

Whether the current user has delete permission.

#### Returns

`boolean`

True when permitted.

***

### hasInsertPermission()

> `protected` **hasInsertPermission**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:1166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1166)

Whether the current user has insert permission.

#### Returns

`boolean`

True when permitted.

***

### hasSavePermission()

> `protected` **hasSavePermission**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:1184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1184)

Whether the current user has save permission (insert or update).

#### Returns

`boolean`

True when permitted.

***

### hasUndeletePermission()

> `protected` **hasUndeletePermission**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:1157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1157)

Checks whether the current user may undelete rows.

#### Returns

`boolean`

True when undeletion is allowed.

***

### hasUpdatePermission()

> `protected` **hasUpdatePermission**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:1175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1175)

Whether the current user has update permission.

#### Returns

`boolean`

True when permitted.

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L243)

Initializes the widget, rendering its contents if rendering was deferred.

#### Returns

`this`

This widget instance.

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`init`](BaseDialog.md#init)

***

### initDialog()

> `protected` **initDialog**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L128)

Initializes the underlying dialog element.

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`initDialog`](BaseDialog.md#initdialog)

***

### initLocalizer()

> `protected` **initLocalizer**(): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:676](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L676)

Initializes the entity localizer.

#### Returns

`void`

***

### initPropertyGrid()

> `protected` **initPropertyGrid**(): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:704](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L704)

Initializes the property grid from the PropertyGrid element.

#### Returns

`void`

***

### initTabs()

> `protected` **initTabs**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:304](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L304)

Initializes the tabs from the Tabs element.

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`initTabs`](BaseDialog.md#inittabs)

***

### initToolbar()

> `protected` **initToolbar**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:200](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L200)

Initializes the toolbar from the Toolbar element.

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`initToolbar`](BaseDialog.md#inittoolbar)

***

### initUIDialog()

> `protected` **initUIDialog**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:140](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L140)

Initializes jQuery UI dialog-specific behavior.

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`initUIDialog`](BaseDialog.md#inituidialog)

***

### initValidator()

> `protected` **initValidator**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:222](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L222)

Initializes the form validator.

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`initValidator`](BaseDialog.md#initvalidator)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L266)

Renders the widget's contents and runs any queued after-render callbacks.

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`internalRenderContents`](BaseDialog.md#internalrendercontents)

***

### isCloneMode()

> `protected` **isCloneMode**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:156](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L156)

Whether the dialog is in clone mode.

#### Returns

`boolean`

True when cloning.

***

### isDeleted()

> `protected` **isDeleted**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L172)

Whether the current entity is soft-deleted.

#### Returns

`boolean`

True when deleted.

***

### isEditMode()

> `protected` **isEditMode**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:164](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L164)

Whether the dialog is editing an existing entity.

#### Returns

`boolean`

True when editing.

***

### isNew()

> `protected` **isNew**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L191)

Whether the dialog is creating a new entity.

#### Returns

`boolean`

True when new.

***

### isNewOrDeleted()

> `protected` **isNewOrDeleted**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:199](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L199)

Whether the entity is new or soft-deleted.

#### Returns

`boolean`

True when new or deleted.

***

### isStaticPanel()

> `protected` **isStaticPanel**(): `boolean`

Defined in: [src/ui/dialogs/basedialog.tsx:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L89)

Whether the dialog renders as a static panel.

#### Returns

`boolean`

True when static.

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`isStaticPanel`](BaseDialog.md#isstaticpanel)

***

### isViewMode()

> `protected` **isViewMode**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:1194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1194)

Whether the dialog is in view mode (read-only display of an existing entity).

#### Returns

`boolean`

True when in view mode.

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L291)

Renders the widget from a legacy `getTemplate` string, if defined.

#### Returns

`boolean`

True if a legacy template was rendered.

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`legacyTemplateRender`](BaseDialog.md#legacytemplaterender)

***

### load()

> **load**(`entityOrId`, `done`, `fail?`): `PromiseLike`\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>\>

Defined in: [src/ui/dialogs/entitydialog.tsx:434](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L434)

Loads an entity or id into the dialog.

#### Parameters

##### entityOrId

`any`

Entity instance or identifier to load.

##### done

() => `void`

Callback invoked when loading completes.

##### fail?

(`ex`) => `void`

Optional callback invoked on failure.

#### Returns

`PromiseLike`\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>\>

A promise resolving to the retrieve response.

#### Implementation of

[`IEditDialog`](IEditDialog.md).[`load`](IEditDialog.md#load)

***

### loadById()

> **loadById**(`id`, `callback?`, `fail?`): `PromiseLike`\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>\>

Defined in: [src/ui/dialogs/entitydialog.tsx:616](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L616)

Loads an entity by id.

#### Parameters

##### id

`any`

The entity id.

##### callback?

(`response`) => `void`

Optional callback invoked on success.

##### fail?

() => `void`

Optional callback invoked on failure.

#### Returns

`PromiseLike`\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>\>

A promise resolving to the retrieve response.

***

### loadByIdAndOpenDialog()

> **loadByIdAndOpenDialog**(`entityId`, `asPanel?`, `callback?`, `fail?`): `PromiseLike`\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>\>

Defined in: [src/ui/dialogs/entitydialog.tsx:543](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L543)

Loads an entity by id and opens the dialog.

#### Parameters

##### entityId

`any`

The entity id to load.

##### asPanel?

`boolean`

When true, opens as a panel.

##### callback?

(`response`) => `void`

Optional callback invoked on success.

##### fail?

() => `void`

Optional callback invoked on failure.

#### Returns

`PromiseLike`\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>\>

A promise resolving to the retrieve response.

***

### loadByIdHandler()

> `protected` **loadByIdHandler**(`options`, `callback`, `fail`): `PromiseLike`\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>\>

Defined in: [src/ui/dialogs/entitydialog.tsx:627](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L627)

Executes the retrieve service call.

#### Parameters

##### options

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>\>

Service options.

##### callback

(`response`) => `void`

Callback invoked on success.

##### fail

() => `void`

Callback invoked on failure.

#### Returns

`PromiseLike`\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>\>

A promise resolving to the retrieve response.

***

### loadEntity()

> `protected` **loadEntity**(`entity`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:507](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L507)

Loads an entity into the property grid.

#### Parameters

##### entity

`TItem`

The entity to load.

#### Returns

`void`

***

### loadEntityAndOpenDialog()

> **loadEntityAndOpenDialog**(`entity`, `asPanel?`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:483](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L483)

Loads an entity and opens the dialog.

#### Parameters

##### entity

`TItem`

The entity to load.

##### asPanel?

`boolean`

When true, opens as a panel.

#### Returns

`void`

***

### loadNewAndOpenDialog()

> **loadNewAndOpenDialog**(`asPanel?`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:473](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L473)

Loads a new empty entity and opens the dialog.

#### Parameters

##### asPanel?

`boolean`

When true, opens as a panel.

#### Returns

`void`

***

### loadResponse()

> `protected` **loadResponse**(`data`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:492](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L492)

Loads a retrieve response into the dialog.

#### Parameters

##### data

`any`

The retrieve response data.

#### Returns

`void`

***

### mapSourceItem()

> `protected` **mapSourceItem**(`item`): [`PropertyItem`](../interfaces/PropertyItem.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:697](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L697)

Maps a property item to the item used in the localization grid. The default returns
the item as is (return null for the same effect). Override to clear or modify
permissions / insertable / updatable flags, or to exclude items by returning an item
with `localizable: false`.

#### Parameters

##### item

[`PropertyItem`](../interfaces/PropertyItem.md)

Property item.

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)

The item to use, or null to use the item as is.

***

### onClose()

> **onClose**(`handler`, `opt?`): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L180)

Attaches a dialog/modal/panel close event handler. See Dialog.close for more info.

#### Parameters

##### handler

(`result?`, `e?`) => `void`

##### opt?

###### before?

`boolean`

###### oneOff?

`boolean`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`onClose`](BaseDialog.md#onclose)

***

### onDeleteSuccess()

> `protected` **onDeleteSuccess**(`response`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:267](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L267)

Hook invoked after a successful delete.

#### Parameters

##### response

[`DeleteResponse`](../interfaces/DeleteResponse.md)

The delete response.

#### Returns

`void`

***

### onDialogClose()

> `protected` **onDialogClose**(`result?`): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:258](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L258)

Hook invoked when the dialog closes; destroys the dialog and removes its element.

#### Parameters

##### result?

`string`

The close result.

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`onDialogClose`](BaseDialog.md#ondialogclose)

***

### onDialogOpen()

> `protected` **onDialogOpen**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L172)

Hook invoked when the dialog opens; focuses the first input and arranges layout.

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`onDialogOpen`](BaseDialog.md#ondialogopen)

***

### onLoadingData()

> `protected` **onLoadingData**(`data`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:561](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L561)

Hook invoked when data starts loading.

#### Parameters

##### data

[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>

The retrieve response data.

#### Returns

`void`

***

### onOpen()

> **onOpen**(`handler`, `opt?`): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L185)

Attaches a dialog/modal/panel open event handler. See Dialog.open for more info.

#### Parameters

##### handler

(`e?`) => `void`

##### opt?

###### before?

`boolean`

###### oneOff?

`boolean`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`onOpen`](BaseDialog.md#onopen)

***

### onSaveSuccess()

> `protected` **onSaveSuccess**(`response`, `initiator?`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:867](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L867)

Hook invoked after a successful save.

#### Parameters

##### response

[`SaveResponse`](../interfaces/SaveResponse.md)

The save response.

##### initiator?

[`SaveInitiator`](../type-aliases/SaveInitiator.md)

How the save was initiated.

#### Returns

`void`

***

### propertyItemsReady()

> `protected` **propertyItemsReady**(`itemsData`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L60)

Called once property items are available; initializes the property grid and localizer.

#### Parameters

##### itemsData

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

Property items data.

#### Returns

`void`

***

### reloadById()

> `protected` **reloadById**(): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:597](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L597)

Reloads the current entity by id.

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

[`BaseDialog`](BaseDialog.md).[`render`](BaseDialog.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/dialogs/entitydialog.tsx:1210](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1210)

Renders the dialog contents with toolbar, form, and property grid.

#### Returns

`any`

The rendered content.

#### Overrides

[`BaseDialog`](BaseDialog.md).[`renderContents`](BaseDialog.md#rendercontents)

***

### resetValidation()

> `protected` **resetValidation**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:233](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L233)

Resets all validation state.

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`resetValidation`](BaseDialog.md#resetvalidation)

***

### retrieveLocalizations()

> `protected` **retrieveLocalizations**(): `Promise`\<`Record`\<`string`, `Partial`\<`TItem`\>\>\>

Defined in: [src/ui/dialogs/entitydialog.tsx:637](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L637)

Retrieves existing localizations for the current entity.

#### Returns

`Promise`\<`Record`\<`string`, `Partial`\<`TItem`\>\>\>

A promise resolving to the localizations keyed by language.

***

### save()

> `protected` **save**(`callback?`, `initiator?`): `false` \| `PromiseLike`\<[`SaveResponse`](../interfaces/SaveResponse.md)\>

Defined in: [src/ui/dialogs/entitydialog.tsx:888](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L888)

Validates and saves the entity.

#### Parameters

##### callback?

(`response`) => `void`

Optional callback invoked on success.

##### initiator?

[`SaveInitiator`](../type-aliases/SaveInitiator.md)

How the save was initiated.

#### Returns

`false` \| `PromiseLike`\<[`SaveResponse`](../interfaces/SaveResponse.md)\>

A promise resolving to the save response, or false when validation fails.

***

### save\_submitHandler()

> `protected` **save\_submitHandler**(`callback`, `initiator`): `PromiseLike`\<[`SaveResponse`](../interfaces/SaveResponse.md)\>

Defined in: [src/ui/dialogs/entitydialog.tsx:877](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L877)

Submits the save after validation.

#### Parameters

##### callback

(`response`) => `void`

Callback invoked on success.

##### initiator

[`SaveInitiator`](../type-aliases/SaveInitiator.md)

How the save was initiated.

#### Returns

`PromiseLike`\<[`SaveResponse`](../interfaces/SaveResponse.md)\>

A promise resolving to the save response.

***

### saveHandler()

> `protected` **saveHandler**(`options`, `callback`, `initiator`): `PromiseLike`\<[`SaveResponse`](../interfaces/SaveResponse.md)\>

Defined in: [src/ui/dialogs/entitydialog.tsx:901](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L901)

Executes the save service call.

#### Parameters

##### options

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`SaveResponse`](../interfaces/SaveResponse.md)\>

Service options.

##### callback

(`response`) => `void`

Callback invoked on success.

##### initiator

[`SaveInitiator`](../type-aliases/SaveInitiator.md)

How the save was initiated.

#### Returns

`PromiseLike`\<[`SaveResponse`](../interfaces/SaveResponse.md)\>

A promise resolving to the save response.

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:1104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1104)

Sets whether the dialog is in read-only mode and updates the interface.

#### Parameters

##### value

`boolean`

True to enable read-only mode.

#### Returns

`void`

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`set_readOnly`](IReadOnly.md#set_readonly)

***

### showSaveSuccessMessage()

> `protected` **showSaveSuccessMessage**(`response`, `initiator?`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:910](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L910)

Shows a success message after saving.

#### Parameters

##### response

[`SaveResponse`](../interfaces/SaveResponse.md)

The save response.

##### initiator?

[`SaveInitiator`](../type-aliases/SaveInitiator.md)

How the save was initiated.

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

[`BaseDialog`](BaseDialog.md).[`syncOrAsyncThen`](BaseDialog.md#syncorasyncthen)

***

### undelete()

> `protected` **undelete**(`callback?`): `void` \| `PromiseLike`\<[`UndeleteResponse`](../interfaces/UndeleteResponse.md)\>

Defined in: [src/ui/dialogs/entitydialog.tsx:1075](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1075)

Undeletes the current entity.

#### Parameters

##### callback?

(`response`) => `void`

Optional callback invoked on success.

#### Returns

`void` \| `PromiseLike`\<[`UndeleteResponse`](../interfaces/UndeleteResponse.md)\>

Void or a promise resolving to the undelete response.

***

### undeleteHandler()

> `protected` **undeleteHandler**(`options`, `callback?`): `PromiseLike`\<[`UndeleteResponse`](../interfaces/UndeleteResponse.md)\>

Defined in: [src/ui/dialogs/entitydialog.tsx:1058](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1058)

Executes the undelete service call.

#### Parameters

##### options

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`UndeleteResponse`](../interfaces/UndeleteResponse.md)\>

Service options.

##### callback?

(`response`) => `void`

Optional callback invoked on success.

#### Returns

`PromiseLike`\<[`UndeleteResponse`](../interfaces/UndeleteResponse.md)\>

A promise resolving to the undelete response.

***

### updateInterface()

> `protected` **updateInterface**(): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:1013](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1013)

Updates the interface to reflect the current mode and permissions.

#### Returns

`void`

***

### updateTitle()

> `protected` **updateTitle**(): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L148)

Updates the dialog title from the entity.

#### Returns

`void`

***

### useAsync()

> `protected` **useAsync**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L76)

Whether property items should be loaded asynchronously.

#### Returns

`boolean`

True when async loading is used.

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:329](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L329)

Returns an id prefix helper for resolving child element ids.

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

An [IdPrefixType](../type-aliases/IdPrefixType.md) proxy for this widget's id prefix.

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`useIdPrefix`](BaseDialog.md#useidprefix)

***

### useViewMode()

> `protected` **useViewMode**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:1202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L1202)

Whether view mode is enabled for this dialog.

#### Returns

`boolean`

True when view mode is used.

***

### validateBeforeSave()

> `protected` **validateBeforeSave**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:777](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L777)

Validates the form before saving.

#### Returns

`boolean`

True when the form is valid.

***

### validateForm()

> `protected` **validateForm**(): `boolean`

Defined in: [src/ui/dialogs/basedialog.tsx:241](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L241)

Validates the form.

#### Returns

`boolean`

True when the form is valid.

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`validateForm`](BaseDialog.md#validateform)

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

[`BaseDialog`](BaseDialog.md).[`create`](BaseDialog.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLDivElement`

Defined in: [src/ui/dialogs/basedialog.tsx:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L20)

Creates the default DOM element for a widget.

#### Returns

`HTMLDivElement`

A new `div` element.

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`createDefaultElement`](BaseDialog.md#createdefaultelement)

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

[`BaseDialog`](BaseDialog.md).[`getWidgetName`](BaseDialog.md#getwidgetname)

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

[`BaseDialog`](BaseDialog.md).[`registerClass`](BaseDialog.md#registerclass)

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

[`BaseDialog`](BaseDialog.md).[`registerEditor`](BaseDialog.md#registereditor)
