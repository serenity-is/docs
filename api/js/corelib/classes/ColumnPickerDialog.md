[serenity-is/corelib](../README.md) / ColumnPickerDialog

# Class: ColumnPickerDialog\<P\>

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L31)

## Extends

- [`BaseDialog`](BaseDialog.md)\<`P`\>

## Type Parameters

### P

`P` *extends* [`ColumnPickerDialogOptions`](../interfaces/ColumnPickerDialogOptions.md) = [`ColumnPickerDialogOptions`](../interfaces/ColumnPickerDialogOptions.md)

## Constructors

### Constructor

> **new ColumnPickerDialog**\<`P`\>(`opt`): `ColumnPickerDialog`\<`P`\>

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L46)

#### Parameters

##### opt

`P`

#### Returns

`ColumnPickerDialog`\<`P`\>

#### Overrides

[`BaseDialog`](BaseDialog.md).[`constructor`](BaseDialog.md#constructor)

## Properties

### dialog

> `protected` **dialog**: [`Dialog`](Dialog.md)

Defined in: [src/ui/dialogs/basedialog.tsx:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L20)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`dialog`](BaseDialog.md#dialog)

***

### domNode

> `readonly` **domNode**: `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L14)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`domNode`](BaseDialog.md#domnode)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L13)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`idPrefix`](BaseDialog.md#idprefix)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L11)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`options`](BaseDialog.md#options)

***

### tabs

> `protected` **tabs**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Defined in: [src/ui/dialogs/basedialog.tsx:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L17)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`tabs`](BaseDialog.md#tabs)

***

### toolbar

> `protected` **toolbar**: [`Toolbar`](Toolbar.md)

Defined in: [src/ui/dialogs/basedialog.tsx:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L18)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`toolbar`](BaseDialog.md#toolbar)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`uniqueName`](BaseDialog.md#uniquename)

***

### validator

> `protected` **validator**: `any`

Defined in: [src/ui/dialogs/basedialog.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L19)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`validator`](BaseDialog.md#validator)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L33)

#### Overrides

[`BaseDialog`](BaseDialog.md).[`[typeInfo]`](BaseDialog.md#typeinfo)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L219)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`isComponent`](BaseDialog.md#iscomponent)

## Accessors

### dialogTitle

#### Get Signature

> **get** **dialogTitle**(): `string`

Defined in: [src/ui/dialogs/basedialog.tsx:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L211)

##### Returns

`string`

#### Set Signature

> **set** **dialogTitle**(`value`): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:215](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L215)

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

Defined in: [src/ui/widgets/widget.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L59)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`element`](BaseDialog.md#element)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L203)

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`props`](BaseDialog.md#props)

## Methods

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L58)

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`addCssClass`](BaseDialog.md#addcssclass)

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

[`BaseDialog`](BaseDialog.md).[`addValidationRule`](BaseDialog.md#addvalidationrule)

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

[`BaseDialog`](BaseDialog.md).[`addValidationRule`](BaseDialog.md#addvalidationrule)

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

[`BaseDialog`](BaseDialog.md).[`afterRender`](BaseDialog.md#afterrender)

***

### arrange()

> **arrange**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L184)

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`arrange`](BaseDialog.md#arrange)

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

[`BaseDialog`](BaseDialog.md).[`byId`](BaseDialog.md#byid)

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

[`BaseDialog`](BaseDialog.md).[`change`](BaseDialog.md#change)

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

[`BaseDialog`](BaseDialog.md).[`changeSelect2`](BaseDialog.md#changeselect2)

***

### createColumnItems()

> `protected` **createColumnItems**(): `void`

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:364](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L364)

#### Returns

`void`

***

### createSearch()

> `protected` **createSearch**(`div`): `void`

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L180)

#### Parameters

##### div

`HTMLElement`

#### Returns

`void`

***

### deferRender()

> `protected` **deferRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

#### Returns

`boolean`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`deferRender`](BaseDialog.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L121)

#### Returns

`void`

#### Overrides

[`BaseDialog`](BaseDialog.md).[`destroy`](BaseDialog.md#destroy)

***

### dialogClose()

> **dialogClose**(`result?`): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L207)

#### Parameters

##### result?

`string`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`dialogClose`](BaseDialog.md#dialogclose)

***

### dialogOpen()

> **dialogOpen**(`asPanel?`): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L121)

#### Parameters

##### asPanel?

`boolean`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`dialogOpen`](BaseDialog.md#dialogopen)

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

[`BaseDialog`](BaseDialog.md).[`findById`](BaseDialog.md#findbyid)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

#### Returns

`string`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getCssClass`](BaseDialog.md#getcssclass)

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

[`BaseDialog`](BaseDialog.md).[`getCustomAttribute`](BaseDialog.md#getcustomattribute)

***

### getDialogButtons()

> `protected` **getDialogButtons**(): [`DialogButton`](../interfaces/DialogButton.md)[]

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:305](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L305)

#### Returns

[`DialogButton`](../interfaces/DialogButton.md)[]

#### Overrides

[`BaseDialog`](BaseDialog.md).[`getDialogButtons`](BaseDialog.md#getdialogbuttons)

***

### getDialogOptions()

> `protected` **getDialogOptions**(): [`DialogOptions`](../interfaces/DialogOptions.md)

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:298](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L298)

#### Returns

[`DialogOptions`](../interfaces/DialogOptions.md)

#### Overrides

[`BaseDialog`](BaseDialog.md).[`getDialogOptions`](BaseDialog.md#getdialogoptions)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

#### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getGridField`](BaseDialog.md#getgridfield)

***

### getInitialDialogTitle()

> `protected` **getInitialDialogTitle**(): `string`

Defined in: [src/ui/dialogs/basedialog.tsx:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L62)

#### Returns

`string`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getInitialDialogTitle`](BaseDialog.md#getinitialdialogtitle)

***

### getToolbarButtons()

> `protected` **getToolbarButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

Defined in: [src/ui/dialogs/basedialog.tsx:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L149)

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getToolbarButtons`](BaseDialog.md#gettoolbarbuttons)

***

### getValidatorOptions()

> `protected` **getValidatorOptions**(): `any`

Defined in: [src/ui/dialogs/basedialog.tsx:164](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L164)

#### Returns

`any`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getValidatorOptions`](BaseDialog.md#getvalidatoroptions)

***

### handleResponsive()

> `protected` **handleResponsive**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:227](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L227)

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`handleResponsive`](BaseDialog.md#handleresponsive)

***

### handleRestoreDefaults()

> `protected` **handleRestoreDefaults**(): `void`

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L186)

#### Returns

`void`

***

### handleSearch()

> `protected` **handleSearch**(`_field`, `query`, `done`): `void`

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:251](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L251)

#### Parameters

##### \_field

`string`

##### query

`string`

##### done

(`found`) => `void`

#### Returns

`void`

***

### handleToggleAllClick()

> `protected` **handleToggleAllClick**(): `void`

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:231](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L231)

#### Returns

`void`

***

### handleToggleClick()

> `protected` **handleToggleClick**(`e`): `void`

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L135)

#### Parameters

##### e

`MouseEvent`

#### Returns

`void`

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

#### Returns

`this`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`init`](BaseDialog.md#init)

***

### initDialog()

> `protected` **initDialog**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L98)

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`initDialog`](BaseDialog.md#initdialog)

***

### initTabs()

> `protected` **initTabs**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L220)

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`initTabs`](BaseDialog.md#inittabs)

***

### initToolbar()

> `protected` **initToolbar**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L153)

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`initToolbar`](BaseDialog.md#inittoolbar)

***

### initUIDialog()

> `protected` **initUIDialog**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L107)

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`initUIDialog`](BaseDialog.md#inituidialog)

***

### initValidator()

> `protected` **initValidator**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:168](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L168)

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`initValidator`](BaseDialog.md#initvalidator)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L173)

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`internalRenderContents`](BaseDialog.md#internalrendercontents)

***

### isStaticPanel()

> `protected` **isStaticPanel**(): `boolean`

Defined in: [src/ui/dialogs/basedialog.tsx:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L66)

#### Returns

`boolean`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`isStaticPanel`](BaseDialog.md#isstaticpanel)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L190)

#### Returns

`boolean`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`legacyTemplateRender`](BaseDialog.md#legacytemplaterender)

***

### onClose()

> **onClose**(`handler`, `opt?`): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:140](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L140)

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

Defined in: [src/ui/dialogs/basedialog.tsx:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L190)

#### Parameters

##### result?

`string`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`onDialogClose`](BaseDialog.md#ondialogclose)

***

### onDialogOpen()

> `protected` **onDialogOpen**(): `void`

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:384](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L384)

#### Returns

`void`

#### Overrides

[`BaseDialog`](BaseDialog.md).[`onDialogOpen`](BaseDialog.md#ondialogopen)

***

### onOpen()

> **onOpen**(`handler`, `opt?`): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L145)

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

Defined in: [src/ui/widgets/widget.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L163)

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

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L155)

#### Returns

`any`

#### Overrides

[`BaseDialog`](BaseDialog.md).[`renderContents`](BaseDialog.md#rendercontents)

***

### resetValidation()

> `protected` **resetValidation**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L176)

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`resetValidation`](BaseDialog.md#resetvalidation)

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

[`BaseDialog`](BaseDialog.md).[`syncOrAsyncThen`](BaseDialog.md#syncorasyncthen)

***

### updateToggleAllValue()

> `protected` **updateToggleAllValue**(): `boolean`

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:246](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L246)

#### Returns

`boolean`

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L214)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`useIdPrefix`](BaseDialog.md#useidprefix)

***

### validateForm()

> `protected` **validateForm**(): `boolean`

Defined in: [src/ui/dialogs/basedialog.tsx:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L180)

#### Returns

`boolean`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`validateForm`](BaseDialog.md#validateform)

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

[`BaseDialog`](BaseDialog.md).[`create`](BaseDialog.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLDivElement`

Defined in: [src/ui/dialogs/basedialog.tsx:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L15)

#### Returns

`HTMLDivElement`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`createDefaultElement`](BaseDialog.md#createdefaultelement)

***

### createToolButton()

> `static` **createToolButton**(`optOrDataGrid`): [`ToolButton`](../interfaces/ToolButton.md)

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:273](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L273)

#### Parameters

##### optOrDataGrid

[`IDataGrid`](../interfaces/IDataGrid.md) | [`ColumnPickerDialogOptions`](../interfaces/ColumnPickerDialogOptions.md)

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)

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

[`BaseDialog`](BaseDialog.md).[`getWidgetName`](BaseDialog.md#getwidgetname)

***

### openDialog()

> `static` **openDialog**(`opt`): `void`

Defined in: [src/ui/datagrid/columnpickerdialog.tsx:392](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/columnpickerdialog.tsx#L392)

#### Parameters

##### opt

[`ColumnPickerDialogOptions`](../interfaces/ColumnPickerDialogOptions.md)

#### Returns

`void`

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

[`BaseDialog`](BaseDialog.md).[`registerClass`](BaseDialog.md#registerclass)

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

[`BaseDialog`](BaseDialog.md).[`registerEditor`](BaseDialog.md#registereditor)
