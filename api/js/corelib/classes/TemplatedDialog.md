[@serenity-is/corelib](../README.md) / TemplatedDialog

# Class: TemplatedDialog\<P\>

## Type parameters

| Name |
| :------ |
| `P` |

## Hierarchy

- [`TemplatedWidget`](TemplatedWidget.md)\<`P`\>

  ↳ **`TemplatedDialog`**

  ↳↳ [`PropertyDialog`](PropertyDialog.md)

  ↳↳ [`FilterDialog`](FilterDialog.md)

  ↳↳ [`ColumnPickerDialog`](ColumnPickerDialog.md)

  ↳↳ [`EntityDialog`](EntityDialog.md)

## Table of contents

### Constructors

- [constructor](TemplatedDialog.md#constructor)

### Properties

- [dialog](TemplatedDialog.md#dialog)
- [domNode](TemplatedDialog.md#domnode)
- [idPrefix](TemplatedDialog.md#idprefix)
- [options](TemplatedDialog.md#options)
- [tabs](TemplatedDialog.md#tabs)
- [toolbar](TemplatedDialog.md#toolbar)
- [uniqueName](TemplatedDialog.md#uniquename)
- [validator](TemplatedDialog.md#validator)
- [typeInfo](TemplatedDialog.md#typeinfo)

### Accessors

- [dialogTitle](TemplatedDialog.md#dialogtitle)
- [element](TemplatedDialog.md#element)
- [props](TemplatedDialog.md#props)

### Methods

- [addCssClass](TemplatedDialog.md#addcssclass)
- [addValidationRule](TemplatedDialog.md#addvalidationrule)
- [arrange](TemplatedDialog.md#arrange)
- [byId](TemplatedDialog.md#byid)
- [change](TemplatedDialog.md#change)
- [changeSelect2](TemplatedDialog.md#changeselect2)
- [destroy](TemplatedDialog.md#destroy)
- [dialogClose](TemplatedDialog.md#dialogclose)
- [dialogOpen](TemplatedDialog.md#dialogopen)
- [findById](TemplatedDialog.md#findbyid)
- [getCssClass](TemplatedDialog.md#getcssclass)
- [getCustomAttribute](TemplatedDialog.md#getcustomattribute)
- [getDialogButtons](TemplatedDialog.md#getdialogbuttons)
- [getDialogOptions](TemplatedDialog.md#getdialogoptions)
- [getFieldElement](TemplatedDialog.md#getfieldelement)
- [getGridField](TemplatedDialog.md#getgridfield)
- [getInitialDialogTitle](TemplatedDialog.md#getinitialdialogtitle)
- [getTemplate](TemplatedDialog.md#gettemplate)
- [getToolbarButtons](TemplatedDialog.md#gettoolbarbuttons)
- [getValidatorOptions](TemplatedDialog.md#getvalidatoroptions)
- [handleResponsive](TemplatedDialog.md#handleresponsive)
- [init](TemplatedDialog.md#init)
- [initDialog](TemplatedDialog.md#initdialog)
- [initTabs](TemplatedDialog.md#inittabs)
- [initToolbar](TemplatedDialog.md#inittoolbar)
- [initUIDialog](TemplatedDialog.md#inituidialog)
- [initValidator](TemplatedDialog.md#initvalidator)
- [internalInit](TemplatedDialog.md#internalinit)
- [internalRenderContents](TemplatedDialog.md#internalrendercontents)
- [isStaticPanel](TemplatedDialog.md#isstaticpanel)
- [onDialogClose](TemplatedDialog.md#ondialogclose)
- [onDialogOpen](TemplatedDialog.md#ondialogopen)
- [render](TemplatedDialog.md#render)
- [renderContents](TemplatedDialog.md#rendercontents)
- [resetValidation](TemplatedDialog.md#resetvalidation)
- [syncOrAsyncThen](TemplatedDialog.md#syncorasyncthen)
- [useIdPrefix](TemplatedDialog.md#useidprefix)
- [validateForm](TemplatedDialog.md#validateform)
- [create](TemplatedDialog.md#create)
- [createDefaultElement](TemplatedDialog.md#createdefaultelement)
- [getWidgetName](TemplatedDialog.md#getwidgetname)

## Constructors

### constructor

• **new TemplatedDialog**\<`P`\>(`props?`): [`TemplatedDialog`](TemplatedDialog.md)\<`P`\>

#### Type parameters

| Name |
| :------ |
| `P` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props?` | [`WidgetProps`](../README.md#widgetprops)\<`P`\> |

#### Returns

[`TemplatedDialog`](TemplatedDialog.md)\<`P`\>

#### Overrides

[TemplatedWidget](TemplatedWidget.md).[constructor](TemplatedWidget.md#constructor)

#### Defined in

[src/ui/dialogs/templateddialog.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L22)

## Properties

### dialog

• `Protected` **dialog**: [`Dialog`](Dialog.md)

#### Defined in

[src/ui/dialogs/templateddialog.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L20)

___

### domNode

• `Readonly` **domNode**: `HTMLElement`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[domNode](TemplatedWidget.md#domnode)

#### Defined in

[src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[idPrefix](TemplatedWidget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### options

• `Protected` `Readonly` **options**: [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[options](TemplatedWidget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

___

### tabs

• `Protected` **tabs**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/dialogs/templateddialog.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L17)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](Toolbar.md)\<[`ToolbarOptions`](../interfaces/ToolbarOptions.md)\>

#### Defined in

[src/ui/dialogs/templateddialog.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L18)

___

### uniqueName

• `Protected` `Readonly` **uniqueName**: `string`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[uniqueName](TemplatedWidget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

___

### validator

• `Protected` **validator**: `any`

#### Defined in

[src/ui/dialogs/templateddialog.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L19)

___

### typeInfo

▪ `Static` **typeInfo**: [`ClassTypeInfo`](../README.md#classtypeinfo)\<``"Serenity.Widget"``\>

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[typeInfo](TemplatedWidget.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

## Accessors

### dialogTitle

• `get` **dialogTitle**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/templateddialog.ts:189](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L189)

• `set` **dialogTitle**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L193)

___

### element

• `get` **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

TemplatedWidget.element

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

___

### props

• `get` **props**(): [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Returns

[`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

TemplatedWidget.props

#### Defined in

[src/ui/widgets/widget.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L182)

## Methods

### addCssClass

▸ **addCssClass**(): `void`

#### Returns

`void`

#### Overrides

[TemplatedWidget](TemplatedWidget.md).[addCssClass](TemplatedWidget.md#addcssclass)

#### Defined in

[src/ui/dialogs/templateddialog.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L46)

___

### addValidationRule

▸ **addValidationRule**(`rule`, `uniqueName?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `rule` | (`input`: `HTMLInputElement` \| `HTMLSelectElement` \| `HTMLTextAreaElement`) => `string` |
| `uniqueName?` | `string` |

#### Returns

`void`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[addValidationRule](TemplatedWidget.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L99)

▸ **addValidationRule**(`uniqueName`, `rule`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `uniqueName` | `string` |
| `rule` | (`input`: `HTMLInputElement` \| `HTMLSelectElement` \| `HTMLTextAreaElement`) => `string` |

#### Returns

`void`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[addValidationRule](TemplatedWidget.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### arrange

▸ **arrange**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L162)

___

### byId

▸ **byId**\<`TElement`\>(`id`): [`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TElement` | extends `HTMLElement` = `HTMLElement` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[byId](TemplatedWidget.md#byid)

#### Defined in

[src/ui/widgets/templatedwidget.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L8)

___

### change

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `Event`) => `void` |

#### Returns

`void`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[change](TemplatedWidget.md#change)

#### Defined in

[src/ui/widgets/widget.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L114)

___

### changeSelect2

▸ **changeSelect2**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `Event`) => `void` |

#### Returns

`void`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[changeSelect2](TemplatedWidget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[TemplatedWidget](TemplatedWidget.md).[destroy](TemplatedWidget.md#destroy)

#### Defined in

[src/ui/dialogs/templateddialog.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L31)

___

### dialogClose

▸ **dialogClose**(`result?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `result?` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L185)

___

### dialogOpen

▸ **dialogOpen**(`asPanel?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `asPanel?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L109)

___

### findById

▸ **findById**\<`TElement`\>(`id`): `TElement`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TElement` | extends `HTMLElement` = `HTMLElement` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

`TElement`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[findById](TemplatedWidget.md#findbyid)

#### Defined in

[src/ui/widgets/templatedwidget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L12)

___

### getCssClass

▸ **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[getCssClass](TemplatedWidget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L75)

___

### getCustomAttribute

▸ **getCustomAttribute**\<`TAttr`\>(`attrType`, `inherit?`): `TAttr`

#### Type parameters

| Name |
| :------ |
| `TAttr` |

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `attrType` | (...`args`: `any`[]) => `TAttr` | `undefined` |
| `inherit` | `boolean` | `true` |

#### Returns

`TAttr`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[getCustomAttribute](TemplatedWidget.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getDialogButtons

▸ **getDialogButtons**(): [`DialogButton`](../interfaces/DialogButton.md)[]

#### Returns

[`DialogButton`](../interfaces/DialogButton.md)[]

#### Defined in

[src/ui/dialogs/templateddialog.ts:181](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L181)

___

### getDialogOptions

▸ **getDialogOptions**(): [`DialogOptions`](../interfaces/DialogOptions.md)

#### Returns

[`DialogOptions`](../interfaces/DialogOptions.md)

#### Defined in

[src/ui/dialogs/templateddialog.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L58)

___

### getFieldElement

▸ **getFieldElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[getFieldElement](TemplatedWidget.md#getfieldelement)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

___

### getGridField

▸ **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[getGridField](TemplatedWidget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

___

### getInitialDialogTitle

▸ **getInitialDialogTitle**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/templateddialog.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L50)

___

### getTemplate

▸ **getTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[getTemplate](TemplatedWidget.md#gettemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L16)

___

### getToolbarButtons

▸ **getToolbarButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Defined in

[src/ui/dialogs/templateddialog.ts:127](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L127)

___

### getValidatorOptions

▸ **getValidatorOptions**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/dialogs/templateddialog.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L142)

___

### handleResponsive

▸ **handleResponsive**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:205](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L205)

___

### init

▸ **init**(): `this`

#### Returns

`this`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[init](TemplatedWidget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

___

### initDialog

▸ **initDialog**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L86)

___

### initTabs

▸ **initTabs**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L198)

___

### initToolbar

▸ **initToolbar**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L131)

___

### initUIDialog

▸ **initUIDialog**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L95)

___

### initValidator

▸ **initValidator**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L146)

___

### internalInit

▸ **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[internalInit](TemplatedWidget.md#internalinit)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

___

### internalRenderContents

▸ **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[internalRenderContents](TemplatedWidget.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L169)

___

### isStaticPanel

▸ **isStaticPanel**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/templateddialog.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L54)

___

### onDialogClose

▸ **onDialogClose**(`result?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `result?` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:168](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L168)

___

### onDialogOpen

▸ **onDialogOpen**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L120)

___

### render

▸ **render**(): `any`

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[render](TemplatedWidget.md#render)

#### Defined in

[src/ui/widgets/widget.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L159)

___

### renderContents

▸ **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[renderContents](TemplatedWidget.md#rendercontents)

#### Defined in

[src/ui/widgets/templatedwidget.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L20)

___

### resetValidation

▸ **resetValidation**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L154)

___

### syncOrAsyncThen

▸ **syncOrAsyncThen**\<`T`\>(`syncMethod`, `asyncMethod`, `then`): `void`

#### Type parameters

| Name |
| :------ |
| `T` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `syncMethod` | () => `T` |
| `asyncMethod` | () => `PromiseLike`\<`T`\> |
| `then` | (`v`: `T`) => `void` |

#### Returns

`void`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[syncOrAsyncThen](TemplatedWidget.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L186)

___

### useIdPrefix

▸ **useIdPrefix**(): [`IdPrefixType`](../README.md#idprefixtype)

#### Returns

[`IdPrefixType`](../README.md#idprefixtype)

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[useIdPrefix](TemplatedWidget.md#useidprefix)

#### Defined in

[src/ui/widgets/widget.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L193)

___

### validateForm

▸ **validateForm**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/templateddialog.ts:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L158)

___

### create

▸ **create**\<`TWidget`, `P`\>(`params`): `TWidget`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](Widget.md)\<`P`\> |
| `P` | `P` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `params` | [`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)\<`TWidget`, `P`\> |

#### Returns

`TWidget`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[create](TemplatedWidget.md#create)

#### Defined in

[src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

___

### createDefaultElement

▸ **createDefaultElement**(): `HTMLDivElement`

#### Returns

`HTMLDivElement`

#### Overrides

[TemplatedWidget](TemplatedWidget.md).[createDefaultElement](TemplatedWidget.md#createdefaultelement)

#### Defined in

[src/ui/dialogs/templateddialog.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L15)

___

### getWidgetName

▸ **getWidgetName**(`type`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `Function` |

#### Returns

`string`

#### Inherited from

[TemplatedWidget](TemplatedWidget.md).[getWidgetName](TemplatedWidget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
