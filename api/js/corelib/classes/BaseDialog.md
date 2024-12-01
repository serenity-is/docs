[@serenity-is/corelib](../README.md) / BaseDialog

# Class: BaseDialog\<P\>

## Extends

- [`Widget`](Widget.md)\<`P`\>

## Extended by

- [`PropertyDialog`](PropertyDialog.md)
- [`FilterDialog`](FilterDialog.md)
- [`ColumnPickerDialog`](ColumnPickerDialog.md)
- [`EntityDialog`](EntityDialog.md)

## Type Parameters

• **P**

## Constructors

### new BaseDialog()

> **new BaseDialog**\<`P`\>(`props`?): [`BaseDialog`](BaseDialog.md)\<`P`\>

#### Parameters

##### props?

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Returns

[`BaseDialog`](BaseDialog.md)\<`P`\>

#### Overrides

[`Widget`](Widget.md).[`constructor`](Widget.md#constructors)

#### Defined in

[src/ui/dialogs/basedialog.tsx:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L22)

## Properties

### dialog

> `protected` **dialog**: [`Dialog`](Dialog.md)

#### Defined in

[src/ui/dialogs/basedialog.tsx:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L20)

***

### domNode

> `readonly` **domNode**: `HTMLElement`

#### Inherited from

[`Widget`](Widget.md).[`domNode`](Widget.md#domnode)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

***

### idPrefix

> `readonly` **idPrefix**: `string`

#### Inherited from

[`Widget`](Widget.md).[`idPrefix`](Widget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`Widget`](Widget.md).[`options`](Widget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L14)

***

### tabs

> `protected` **tabs**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/dialogs/basedialog.tsx:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L17)

***

### toolbar

> `protected` **toolbar**: [`Toolbar`](Toolbar.md)\<[`ToolbarOptions`](../interfaces/ToolbarOptions.md)\>

#### Defined in

[src/ui/dialogs/basedialog.tsx:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L18)

***

### uniqueName

> `readonly` **uniqueName**: `string`

#### Inherited from

[`Widget`](Widget.md).[`uniqueName`](Widget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

***

### validator

> `protected` **validator**: `any`

#### Defined in

[src/ui/dialogs/basedialog.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L19)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

#### Inherited from

[`Widget`](Widget.md).[`isComponent`](Widget.md#iscomponent)

#### Defined in

[src/ui/widgets/widget.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L223)

***

### typeInfo

> `static` **typeInfo**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity.Widget"`\>

#### Inherited from

[`Widget`](Widget.md).[`typeInfo`](Widget.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L11)

## Accessors

### dialogTitle

#### Get Signature

> **get** **dialogTitle**(): `string`

##### Returns

`string`

#### Set Signature

> **set** **dialogTitle**(`value`): `void`

##### Parameters

###### value

`string`

##### Returns

`void`

#### Defined in

[src/ui/dialogs/basedialog.tsx:210](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L210)

***

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`Widget`](Widget.md).[`element`](Widget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`Widget`](Widget.md).[`props`](Widget.md#props)

#### Defined in

[src/ui/widgets/widget.ts:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L207)

## Methods

### addCssClass()

> `protected` **addCssClass**(): `void`

#### Returns

`void`

#### Overrides

[`Widget`](Widget.md).[`addCssClass`](Widget.md#addcssclass)

#### Defined in

[src/ui/dialogs/basedialog.tsx:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L57)

***

### addValidationRule()

#### Call Signature

> **addValidationRule**(`rule`, `uniqueName`?): `void`

##### Parameters

###### rule

(`input`) => `string`

###### uniqueName?

`string`

##### Returns

`void`

##### Inherited from

[`Widget`](Widget.md).[`addValidationRule`](Widget.md#addvalidationrule)

##### Defined in

[src/ui/widgets/widget.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L99)

#### Call Signature

> **addValidationRule**(`uniqueName`, `rule`): `void`

##### Parameters

###### uniqueName

`string`

###### rule

(`input`) => `string`

##### Returns

`void`

##### Inherited from

[`Widget`](Widget.md).[`addValidationRule`](Widget.md#addvalidationrule)

##### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

***

### afterRender()

> `protected` **afterRender**(`callback`): `void`

#### Parameters

##### callback

() => `void`

#### Returns

`void`

#### Inherited from

[`Widget`](Widget.md).[`afterRender`](Widget.md#afterrender)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

***

### arrange()

> **arrange**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/basedialog.tsx:183](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L183)

***

### byId()

> `protected` **byId**\<`TElement`\>(`id`): [`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

#### Type Parameters

• **TElement** *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

#### Inherited from

[`Widget`](Widget.md).[`byId`](Widget.md#byid)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

***

### change()

> **change**(`handler`): `void`

#### Parameters

##### handler

(`e`) => `void`

#### Returns

`void`

#### Inherited from

[`Widget`](Widget.md).[`change`](Widget.md#change)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

***

### changeSelect2()

> **changeSelect2**(`handler`): `void`

#### Parameters

##### handler

(`e`) => `void`

#### Returns

`void`

#### Inherited from

[`Widget`](Widget.md).[`changeSelect2`](Widget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L122)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`Widget`](Widget.md).[`deferRender`](Widget.md#deferrender)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Overrides

[`Widget`](Widget.md).[`destroy`](Widget.md#destroy)

#### Defined in

[src/ui/dialogs/basedialog.tsx:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L31)

***

### dialogClose()

> **dialogClose**(`result`?): `void`

#### Parameters

##### result?

`string`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/basedialog.tsx:206](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L206)

***

### dialogOpen()

> **dialogOpen**(`asPanel`?): `void`

#### Parameters

##### asPanel?

`boolean`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/basedialog.tsx:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L120)

***

### findById()

> `protected` **findById**\<`TElement`\>(`id`): `TElement`

#### Type Parameters

• **TElement** *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

#### Returns

`TElement`

#### Inherited from

[`Widget`](Widget.md).[`findById`](Widget.md#findbyid)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[`Widget`](Widget.md).[`getCssClass`](Widget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L75)

***

### getCustomAttribute()

> `protected` **getCustomAttribute**\<`TAttr`\>(`attrType`, `inherit`): `TAttr`

#### Type Parameters

• **TAttr**

#### Parameters

##### attrType

(...`args`) => `TAttr`

##### inherit

`boolean` = `true`

#### Returns

`TAttr`

#### Inherited from

[`Widget`](Widget.md).[`getCustomAttribute`](Widget.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

***

### getDialogButtons()

> `protected` **getDialogButtons**(): [`DialogButton`](../interfaces/DialogButton.md)[]

#### Returns

[`DialogButton`](../interfaces/DialogButton.md)[]

#### Defined in

[src/ui/dialogs/basedialog.tsx:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L202)

***

### getDialogOptions()

> `protected` **getDialogOptions**(): [`DialogOptions`](../interfaces/DialogOptions.md)

#### Returns

[`DialogOptions`](../interfaces/DialogOptions.md)

#### Defined in

[src/ui/dialogs/basedialog.tsx:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L69)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`Widget`](Widget.md).[`getGridField`](Widget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L114)

***

### getInitialDialogTitle()

> `protected` **getInitialDialogTitle**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/basedialog.tsx:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L61)

***

### getToolbarButtons()

> `protected` **getToolbarButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Defined in

[src/ui/dialogs/basedialog.tsx:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L148)

***

### getValidatorOptions()

> `protected` **getValidatorOptions**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/dialogs/basedialog.tsx:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L163)

***

### handleResponsive()

> `protected` **handleResponsive**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/basedialog.tsx:226](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L226)

***

### init()

> **init**(): `this`

#### Returns

`this`

#### Inherited from

[`Widget`](Widget.md).[`init`](Widget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L157)

***

### initDialog()

> `protected` **initDialog**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/basedialog.tsx:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L97)

***

### initTabs()

> `protected` **initTabs**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/basedialog.tsx:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L219)

***

### initToolbar()

> `protected` **initToolbar**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/basedialog.tsx:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L152)

***

### initUIDialog()

> `protected` **initUIDialog**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/basedialog.tsx:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L106)

***

### initValidator()

> `protected` **initValidator**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/basedialog.tsx:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L167)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[`Widget`](Widget.md).[`internalRenderContents`](Widget.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L177)

***

### isStaticPanel()

> `protected` **isStaticPanel**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/basedialog.tsx:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L65)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`Widget`](Widget.md).[`legacyTemplateRender`](Widget.md#legacytemplaterender)

#### Defined in

[src/ui/widgets/widget.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L194)

***

### onClose()

> **onClose**(`handler`, `opt`?): `void`

Attaches a dialog/modal/panel close event handler. See Dialog.close for more info.

#### Parameters

##### handler

(`result`?, `e`?) => `void`

##### opt?

###### opt.before

`boolean`

###### opt.oneOff

`boolean`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/basedialog.tsx:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L139)

***

### onDialogClose()

> `protected` **onDialogClose**(`result`?): `void`

#### Parameters

##### result?

`string`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/basedialog.tsx:189](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L189)

***

### onDialogOpen()

> `protected` **onDialogOpen**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/basedialog.tsx:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L131)

***

### onOpen()

> **onOpen**(`handler`, `opt`?): `void`

Attaches a dialog/modal/panel open event handler. See Dialog.open for more info.

#### Parameters

##### handler

(`e`?) => `void`

##### opt?

###### opt.before

`boolean`

###### opt.oneOff

`boolean`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/basedialog.tsx:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L144)

***

### render()

> **render**(): `any`

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[`Widget`](Widget.md).[`render`](Widget.md#render)

#### Defined in

[src/ui/widgets/widget.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L167)

***

### renderContents()

> `protected` **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[`Widget`](Widget.md).[`renderContents`](Widget.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L188)

***

### resetValidation()

> `protected` **resetValidation**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/basedialog.tsx:175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L175)

***

### syncOrAsyncThen()

> `protected` **syncOrAsyncThen**\<`T`\>(`syncMethod`, `asyncMethod`, `then`): `void`

#### Type Parameters

• **T**

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

[`Widget`](Widget.md).[`syncOrAsyncThen`](Widget.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L211)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`Widget`](Widget.md).[`useIdPrefix`](Widget.md#useidprefix)

#### Defined in

[src/ui/widgets/widget.ts:218](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L218)

***

### validateForm()

> `protected` **validateForm**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/basedialog.tsx:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L179)

***

### create()

> `static` **create**\<`TWidget`, `P`\>(`params`): `TWidget`

#### Type Parameters

• **TWidget** *extends* [`Widget`](Widget.md)\<`P`\>

• **P**

#### Parameters

##### params

[`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)\<`TWidget`, `P`\>

#### Returns

`TWidget`

#### Inherited from

[`Widget`](Widget.md).[`create`](Widget.md#create)

#### Defined in

[src/ui/widgets/widget.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L130)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLDivElement`

#### Returns

`HTMLDivElement`

#### Overrides

[`Widget`](Widget.md).[`createDefaultElement`](Widget.md#createdefaultelement)

#### Defined in

[src/ui/dialogs/basedialog.tsx:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L15)

***

### getWidgetName()

> `static` **getWidgetName**(`type`): `string`

#### Parameters

##### type

`Function`

#### Returns

`string`

#### Inherited from

[`Widget`](Widget.md).[`getWidgetName`](Widget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
