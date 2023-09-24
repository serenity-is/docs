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

[src/ui/dialogs/templateddialog.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L16)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[element](corelib.TemplatedWidget.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[idPrefix](corelib.TemplatedWidget.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### options

• `Protected` **options**: `TOptions`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[options](corelib.TemplatedWidget.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### tabs

• `Protected` **tabs**: `JQuery`

#### Defined in

[src/ui/dialogs/templateddialog.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L12)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](corelib.Toolbar.md)

#### Defined in

[src/ui/dialogs/templateddialog.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L13)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[uniqueName](corelib.TemplatedWidget.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### validator

• `Protected` **validator**: `Validator`

#### Defined in

[src/ui/dialogs/templateddialog.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L14)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[widgetName](corelib.TemplatedWidget.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

___

### bootstrapModal

▪ `Static` **bootstrapModal**: `boolean`

#### Defined in

[src/ui/dialogs/templateddialog.ts:274](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L274)

## Accessors

### dialogTitle

• `get` **dialogTitle**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/templateddialog.ts:360](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L360)

• `set` **dialogTitle**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:395](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L395)

___

### isMarkedAsPanel

• `Private` `get` **isMarkedAsPanel**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/templateddialog.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L26)

___

### isResponsive

• `Private` `get` **isResponsive**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/templateddialog.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L32)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Overrides

[TemplatedWidget](corelib.TemplatedWidget.md).[addCssClass](corelib.TemplatedWidget.md#addcssclass)

#### Defined in

[src/ui/dialogs/templateddialog.ts:315](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L315)

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

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

___

### arrange

▸ **arrange**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L291)

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

[src/ui/widgets/templatedwidget.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L10)

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

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

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

[src/ui/widgets/widget.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L259)

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

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

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

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[TemplatedWidget](corelib.TemplatedWidget.md).[destroy](corelib.TemplatedWidget.md#destroy)

#### Defined in

[src/ui/dialogs/templateddialog.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L81)

___

### dialogClose

▸ **dialogClose**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:350](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L350)

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

[src/ui/dialogs/templateddialog.ts:244](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L244)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[getCssClass](corelib.TemplatedWidget.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getDialogButtons

▸ `Protected` **getDialogButtons**(): [`DialogButton`](../interfaces/corelib_q.DialogButton.md)[]

#### Returns

[`DialogButton`](../interfaces/corelib_q.DialogButton.md)[]

#### Defined in

[src/ui/dialogs/templateddialog.ts:324](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L324)

___

### getDialogOptions

▸ `Protected` **getDialogOptions**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/dialogs/templateddialog.ts:328](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L328)

___

### getDialogTitle

▸ `Protected` **getDialogTitle**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/templateddialog.ts:346](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L346)

___

### getFallbackTemplate

▸ `Protected` **getFallbackTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[getFallbackTemplate](corelib.TemplatedWidget.md#getfallbacktemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L79)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[getGridField](corelib.TemplatedWidget.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getModalOptions

▸ `Protected` **getModalOptions**(): [`ModalOptions`](../interfaces/corelib.ModalOptions.md)

#### Returns

[`ModalOptions`](../interfaces/corelib.ModalOptions.md)

#### Defined in

[src/ui/dialogs/templateddialog.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L153)

___

### getTemplate

▸ `Protected` **getTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[getTemplate](corelib.TemplatedWidget.md#gettemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L83)

___

### getTemplateName

▸ `Protected` **getTemplateName**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[getTemplateName](corelib.TemplatedWidget.md#gettemplatename)

#### Defined in

[src/ui/widgets/templatedwidget.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L31)

___

### getToolbarButtons

▸ `Protected` **getToolbarButtons**(): [`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Defined in

[src/ui/dialogs/templateddialog.ts:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L220)

___

### getValidatorOptions

▸ `Protected` **getValidatorOptions**(): `ValidationOptions`

#### Returns

`ValidationOptions`

#### Defined in

[src/ui/dialogs/templateddialog.ts:224](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L224)

___

### handleResponsive

▸ `Protected` **handleResponsive**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:426](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L426)

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

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initDialog

▸ `Protected` **initDialog**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L104)

___

### initModal

▸ `Protected` **initModal**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L162)

___

### initTabs

▸ `Protected` **initTabs**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:417](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L417)

___

### initToolbar

▸ `Protected` **initToolbar**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L203)

___

### initValidator

▸ `Protected` **initValidator**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:228](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L228)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[initialize](corelib.TemplatedWidget.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### onDialogClose

▸ `Protected` **onDialogClose**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:297](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L297)

___

### onDialogOpen

▸ `Protected` **onDialogOpen**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:284](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L284)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[renderContents](corelib.TemplatedWidget.md#rendercontents)

#### Defined in

[src/ui/widgets/templatedwidget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L110)

___

### resetValidation

▸ `Protected` **resetValidation**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:236](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L236)

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

[src/ui/dialogs/templateddialog.ts:413](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L413)

___

### setupPanelTitle

▸ `Private` **setupPanelTitle**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/templateddialog.ts:369](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L369)

___

### useBSModal

▸ `Private` **useBSModal**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/templateddialog.ts:270](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L270)

___

### useIdPrefix

▸ `Protected` **useIdPrefix**(): `IdPrefixType`

#### Returns

`IdPrefixType`

#### Inherited from

[TemplatedWidget](corelib.TemplatedWidget.md).[useIdPrefix](corelib.TemplatedWidget.md#useidprefix)

#### Defined in

[src/ui/widgets/templatedwidget.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L131)

___

### validateForm

▸ `Protected` **validateForm**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/templateddialog.ts:240](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L240)

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

[src/ui/dialogs/templateddialog.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L55)

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

[src/ui/dialogs/templateddialog.ts:280](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L280)

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

[src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

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

[src/ui/widgets/widget.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L128)

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

[src/ui/dialogs/templateddialog.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L37)

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

[src/ui/widgets/widget.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L124)

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

[src/ui/dialogs/templateddialog.ts:276](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L276)
