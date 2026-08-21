[@serenity-is/corelib](../README.md) / FilterDialog

# Class: FilterDialog\<P\>

Defined in: [src/ui/filtering/filterdialog.tsx:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdialog.tsx#L10)

A dialog that hosts a [FilterPanel](FilterPanel.md) for editing filters.

## Extends

- [`BaseDialog`](BaseDialog.md)\<`P`\>

## Type Parameters

### P

`P` = \{ \}

Widget props type.

## Constructors

### Constructor

> **new FilterDialog**\<`P`\>(`props`): `FilterDialog`\<`P`\>

Defined in: [src/ui/filtering/filterdialog.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdialog.tsx#L19)

Creates a filter dialog.

#### Parameters

##### props

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Widget props.

#### Returns

`FilterDialog`\<`P`\>

#### Overrides

[`BaseDialog`](BaseDialog.md).[`constructor`](BaseDialog.md#constructor)

## Properties

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

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L22)

The id prefix used for this widget's child element ids.

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`idPrefix`](BaseDialog.md#idprefix)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

The widget's options/props.

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`options`](BaseDialog.md#options)

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

Defined in: [src/ui/filtering/filterdialog.tsx:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdialog.tsx#L11)

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

[`PropertyDialog`](PropertyDialog.md).[`dialogTitle`](PropertyDialog.md#dialogtitle)

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

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L307)

Returns the widget's props/options.

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`props`](BaseDialog.md#props)

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

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L43)

Cleans up tabs, toolbar, validator, and dialog resources.

#### Returns

`void`

#### Inherited from

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

### get\_filterPanel()

> **get\_filterPanel**(): [`FilterPanel`](FilterPanel.md)

Defined in: [src/ui/filtering/filterdialog.tsx:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdialog.tsx#L34)

Returns the filter panel.

#### Returns

[`FilterPanel`](FilterPanel.md)

The filter panel.

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

### getDialogButtons()

> `protected` **getDialogButtons**(): [`DialogButton`](../interfaces/DialogButton.md)[]

Defined in: [src/ui/filtering/filterdialog.tsx:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdialog.tsx#L60)

Returns the dialog buttons.

#### Returns

[`DialogButton`](../interfaces/DialogButton.md)[]

Dialog button definitions.

#### Overrides

[`BaseDialog`](BaseDialog.md).[`getDialogButtons`](BaseDialog.md#getdialogbuttons)

***

### getDialogOptions()

> `protected` **getDialogOptions**(): [`DialogOptions`](../interfaces/DialogOptions.md)

Defined in: [src/ui/filtering/filterdialog.tsx:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdialog.tsx#L50)

Returns the dialog options.

#### Returns

[`DialogOptions`](../interfaces/DialogOptions.md)

Dialog options.

#### Overrides

[`BaseDialog`](BaseDialog.md).[`getDialogOptions`](BaseDialog.md#getdialogoptions)

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

### getToolbarButtons()

> `protected` **getToolbarButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

Defined in: [src/ui/dialogs/basedialog.tsx:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L193)

Returns the toolbar buttons for this dialog.

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

Tool button definitions.

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getToolbarButtons`](BaseDialog.md#gettoolbarbuttons)

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

Defined in: [src/ui/filtering/filterdialog.tsx:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdialog.tsx#L42)

Renders the dialog contents with the filter panel.

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
