[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / TemplatedDialog

# Class: TemplatedDialog<TOptions\>

[corelib](../modules/corelib.md).TemplatedDialog

## Type parameters

| Name |
| :------ |
| `TOptions` |

## Hierarchy

- [`TemplatedWidget`](corelib.TemplatedWidget.md)<`TOptions`\>

  ↳ **`TemplatedDialog`**

  ↳↳ [`PropertyDialog`](corelib.PropertyDialog.md)

  ↳↳ [`FilterDialog`](corelib.FilterDialog.md)

  ↳↳ [`ColumnPickerDialog`](corelib.ColumnPickerDialog.md)

  ↳↳ [`EntityDialog`](corelib.EntityDialog.md)

  ↳↳ [`ReportDialog`](corelib.Reporting.ReportDialog.md)

## Table of contents

### Constructors

- [constructor](corelib.TemplatedDialog.md#constructor)

### Properties

- [element](corelib.TemplatedDialog.md#element)
- [idPrefix](corelib.TemplatedDialog.md#idprefix)
- [options](corelib.TemplatedDialog.md#options)
- [tabs](corelib.TemplatedDialog.md#tabs)
- [toolbar](corelib.TemplatedDialog.md#toolbar)
- [uniqueName](corelib.TemplatedDialog.md#uniquename)
- [validator](corelib.TemplatedDialog.md#validator)
- [widgetName](corelib.TemplatedDialog.md#widgetname)
- [bootstrapModal](corelib.TemplatedDialog.md#bootstrapmodal)

### Accessors

- [dialogTitle](corelib.TemplatedDialog.md#dialogtitle)
- [isMarkedAsPanel](corelib.TemplatedDialog.md#ismarkedaspanel)
- [isResponsive](corelib.TemplatedDialog.md#isresponsive)

### Methods

- [addCssClass](corelib.TemplatedDialog.md#addcssclass)
- [addValidationRule](corelib.TemplatedDialog.md#addvalidationrule)
- [arrange](corelib.TemplatedDialog.md#arrange)
- [byId](corelib.TemplatedDialog.md#byid)
- [change](corelib.TemplatedDialog.md#change)
- [changeSelect2](corelib.TemplatedDialog.md#changeselect2)
- [destroy](corelib.TemplatedDialog.md#destroy)
- [dialogClose](corelib.TemplatedDialog.md#dialogclose)
- [dialogOpen](corelib.TemplatedDialog.md#dialogopen)
- [getCssClass](corelib.TemplatedDialog.md#getcssclass)
- [getDialogButtons](corelib.TemplatedDialog.md#getdialogbuttons)
- [getDialogOptions](corelib.TemplatedDialog.md#getdialogoptions)
- [getDialogTitle](corelib.TemplatedDialog.md#getdialogtitle)
- [getFallbackTemplate](corelib.TemplatedDialog.md#getfallbacktemplate)
- [getGridField](corelib.TemplatedDialog.md#getgridfield)
- [getModalOptions](corelib.TemplatedDialog.md#getmodaloptions)
- [getTemplate](corelib.TemplatedDialog.md#gettemplate)
- [getTemplateName](corelib.TemplatedDialog.md#gettemplatename)
- [getToolbarButtons](corelib.TemplatedDialog.md#gettoolbarbuttons)
- [getValidatorOptions](corelib.TemplatedDialog.md#getvalidatoroptions)
- [handleResponsive](corelib.TemplatedDialog.md#handleresponsive)
- [init](corelib.TemplatedDialog.md#init)
- [initDialog](corelib.TemplatedDialog.md#initdialog)
- [initModal](corelib.TemplatedDialog.md#initmodal)
- [initTabs](corelib.TemplatedDialog.md#inittabs)
- [initToolbar](corelib.TemplatedDialog.md#inittoolbar)
- [initValidator](corelib.TemplatedDialog.md#initvalidator)
- [initialize](corelib.TemplatedDialog.md#initialize)
- [onDialogClose](corelib.TemplatedDialog.md#ondialogclose)
- [onDialogOpen](corelib.TemplatedDialog.md#ondialogopen)
- [renderContents](corelib.TemplatedDialog.md#rendercontents)
- [resetValidation](corelib.TemplatedDialog.md#resetvalidation)
- [set\_dialogTitle](corelib.TemplatedDialog.md#set_dialogtitle)
- [setupPanelTitle](corelib.TemplatedDialog.md#setuppaneltitle)
- [useBSModal](corelib.TemplatedDialog.md#usebsmodal)
- [useIdPrefix](corelib.TemplatedDialog.md#useidprefix)
- [validateForm](corelib.TemplatedDialog.md#validateform)
- [applyCssSizes](corelib.TemplatedDialog.md#applycsssizes)
- [closePanel](corelib.TemplatedDialog.md#closepanel)
- [create](corelib.TemplatedDialog.md#create)
- [elementFor](corelib.TemplatedDialog.md#elementfor)
- [getCssSize](corelib.TemplatedDialog.md#getcsssize)
- [getWidgetName](corelib.TemplatedDialog.md#getwidgetname)
- [openPanel](corelib.TemplatedDialog.md#openpanel)

## Constructors

### constructor

• **new TemplatedDialog**<`TOptions`\>(`options?`)

#### Type parameters

| Name |
| :------ |
| `TOptions` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `options?` | `TOptions` |

#### Overrides

[TemplatedWidget](corelib.TemplatedWidget.md).[constructor](corelib.TemplatedWidget.md#constructor)

#### Defined in

[src/ui/dialogs/templateddialog.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;16)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[element](corelib.TemplatedWidget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[idPrefix](corelib.TemplatedWidget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;65)

___

### options

• `Protected` **options**: `TOptions`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[options](corelib.TemplatedWidget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;62)

___

### tabs

• `Protected` **tabs**: `JQuery`

#### Defined in

[src/ui/dialogs/templateddialog.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;12)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](corelib.Toolbar.md)

#### Defined in

[src/ui/dialogs/templateddialog.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;13)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[uniqueName](corelib.TemplatedWidget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;64)

___

### validator

• `Protected` **validator**: `Validator`

#### Defined in

[src/ui/dialogs/templateddialog.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;14)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[widgetName](corelib.TemplatedWidget.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;63)

___

### bootstrapModal

▪ `Static` **bootstrapModal**: `boolean`

#### Defined in

[src/ui/dialogs/templateddialog.ts:274](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;274)

## Accessors

### dialogTitle

• `get` **dialogTitle**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/templateddialog.ts:385](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;385)

• `set` **dialogTitle**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:420](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;420)

___

### isMarkedAsPanel

• `Private` `get` **isMarkedAsPanel**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/templateddialog.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;26)

___

### isResponsive

• `Private` `get` **isResponsive**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/templateddialog.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;32)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Overrides

[TemplatedWidget](corelib.TemplatedWidget.md).[addCssClass](corelib.TemplatedWidget.md#addcssclass)

#### Defined in

[src/ui/dialogs/templateddialog.ts:340](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;340)

___

### addValidationRule

▸ **addValidationRule**(`eventClass`, `rule`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `eventClass` | `string` |
| `rule` | (`p1`: `JQuery`) => `string` |

#### Returns

`JQuery`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[addValidationRule](corelib.TemplatedWidget.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;134)

___

### arrange

▸ **arrange**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:316](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;316)

___

### byId

▸ `Protected` **byId**(`id`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

`JQuery`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[byId](corelib.TemplatedWidget.md#byid-1)

#### Defined in

[src/ui/widgets/templatedwidget.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;10)

___

### change

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[change](corelib.TemplatedWidget.md#change)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;142)

▸ **change**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[change](corelib.TemplatedWidget.md#change)

#### Defined in

[src/ui/widgets/widget.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;259)

___

### changeSelect2

▸ **changeSelect2**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[changeSelect2](corelib.TemplatedWidget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;146)

▸ **changeSelect2**(`handler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `handler` | (`e`: `JQueryEventObject`) => `void` |

#### Returns

`void`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[changeSelect2](corelib.TemplatedWidget.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[TemplatedWidget](corelib.TemplatedWidget.md).[destroy](corelib.TemplatedWidget.md#destroy)

#### Defined in

[src/ui/dialogs/templateddialog.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;81)

___

### dialogClose

▸ **dialogClose**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:375](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;375)

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

[src/ui/dialogs/templateddialog.ts:244](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;244)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[getCssClass](corelib.TemplatedWidget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;104)

___

### getDialogButtons

▸ `Protected` **getDialogButtons**(): [`DialogButton`](../interfaces/corelib_q.DialogButton.md)[]

#### Returns

[`DialogButton`](../interfaces/corelib_q.DialogButton.md)[]

#### Defined in

[src/ui/dialogs/templateddialog.ts:349](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;349)

___

### getDialogOptions

▸ `Protected` **getDialogOptions**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/dialogs/templateddialog.ts:353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;353)

___

### getDialogTitle

▸ `Protected` **getDialogTitle**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/templateddialog.ts:371](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;371)

___

### getFallbackTemplate

▸ `Protected` **getFallbackTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[getFallbackTemplate](corelib.TemplatedWidget.md#getfallbacktemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;79)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[getGridField](corelib.TemplatedWidget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;138)

___

### getModalOptions

▸ `Protected` **getModalOptions**(): [`ModalOptions`](../interfaces/corelib.ModalOptions.md)

#### Returns

[`ModalOptions`](../interfaces/corelib.ModalOptions.md)

#### Defined in

[src/ui/dialogs/templateddialog.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;153)

___

### getTemplate

▸ `Protected` **getTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[getTemplate](corelib.TemplatedWidget.md#gettemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;83)

___

### getTemplateName

▸ `Protected` **getTemplateName**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[getTemplateName](corelib.TemplatedWidget.md#gettemplatename)

#### Defined in

[src/ui/widgets/templatedwidget.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;31)

___

### getToolbarButtons

▸ `Protected` **getToolbarButtons**(): [`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Defined in

[src/ui/dialogs/templateddialog.ts:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;220)

___

### getValidatorOptions

▸ `Protected` **getValidatorOptions**(): `ValidationOptions`

#### Returns

`ValidationOptions`

#### Defined in

[src/ui/dialogs/templateddialog.ts:224](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;224)

___

### handleResponsive

▸ `Protected` **handleResponsive**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:451](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;451)

___

### init

▸ **init**(`action?`): [`TemplatedDialog`](corelib.TemplatedDialog.md)<`TOptions`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`TemplatedDialog`](corelib.TemplatedDialog.md)<`TOptions`\>

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[init](corelib.TemplatedWidget.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;179)

___

### initDialog

▸ `Protected` **initDialog**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;104)

___

### initModal

▸ `Protected` **initModal**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;162)

___

### initTabs

▸ `Protected` **initTabs**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:442](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;442)

___

### initToolbar

▸ `Protected` **initToolbar**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;203)

___

### initValidator

▸ `Protected` **initValidator**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:228](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;228)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[initialize](corelib.TemplatedWidget.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;176)

___

### onDialogClose

▸ `Protected` **onDialogClose**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:322](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;322)

___

### onDialogOpen

▸ `Protected` **onDialogOpen**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:309](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;309)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[renderContents](corelib.TemplatedWidget.md#rendercontents)

#### Defined in

[src/ui/widgets/templatedwidget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;110)

___

### resetValidation

▸ `Protected` **resetValidation**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:236](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;236)

___

### set\_dialogTitle

▸ **set_dialogTitle**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:438](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;438)

___

### setupPanelTitle

▸ `Private` **setupPanelTitle**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:394](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;394)

___

### useBSModal

▸ `Private` **useBSModal**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/templateddialog.ts:270](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;270)

___

### useIdPrefix

▸ `Protected` **useIdPrefix**(): `IdPrefixType`

#### Returns

`IdPrefixType`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[useIdPrefix](corelib.TemplatedWidget.md#useidprefix)

#### Defined in

[src/ui/widgets/templatedwidget.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;131)

___

### validateForm

▸ `Protected` **validateForm**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/templateddialog.ts:240](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;240)

___

### applyCssSizes

▸ `Static` `Private` **applyCssSizes**(`opt`, `dialogClass`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `opt` | `any` |
| `dialogClass` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;55)

___

### closePanel

▸ `Static` **closePanel**(`element`, `e?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |
| `e?` | `JQueryEventObject` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:305](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;305)

___

### create

▸ `Static` **create**<`TWidget`, `TOpt`\>(`params`): `TWidget`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](corelib.Widget.md)<`TOpt`, `TWidget`\> |
| `TOpt` | `TOpt` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `params` | [`CreateWidgetParams`](../interfaces/corelib.CreateWidgetParams.md)<`TWidget`, `TOpt`\> |

#### Returns

`TWidget`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[create](corelib.TemplatedWidget.md#create)

#### Defined in

[src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;153)

___

### elementFor

▸ `Static` **elementFor**<`TWidget`\>(`editorType`): `JQuery`

#### Type parameters

| Name |
| :------ |
| `TWidget` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `editorType` | (...`args`: `any`[]) => `TWidget` |

#### Returns

`JQuery`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[elementFor](corelib.TemplatedWidget.md#elementfor)

#### Defined in

[src/ui/widgets/widget.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;128)

___

### getCssSize

▸ `Static` `Private` **getCssSize**(`element`, `name`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |
| `name` | `string` |

#### Returns

`number`

#### Defined in

[src/ui/dialogs/templateddialog.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;37)

___

### getWidgetName

▸ `Static` **getWidgetName**(`type`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `Function` |

#### Returns

`string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[getWidgetName](corelib.TemplatedWidget.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;124)

___

### openPanel

▸ `Static` **openPanel**(`element`, `uniqueName`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |
| `uniqueName` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:276](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;276)
