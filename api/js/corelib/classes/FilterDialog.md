[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / FilterDialog

# Class: FilterDialog

## Hierarchy

- [`TemplatedDialog`](TemplatedDialog.md)<`any`\>

  ↳ **`FilterDialog`**

## Table of contents

### Constructors

- [constructor](FilterDialog.md#constructor)

### Properties

- [element](FilterDialog.md#element)
- [filterPanel](FilterDialog.md#filterpanel)
- [idPrefix](FilterDialog.md#idprefix)
- [options](FilterDialog.md#options)
- [tabs](FilterDialog.md#tabs)
- [toolbar](FilterDialog.md#toolbar)
- [uniqueName](FilterDialog.md#uniquename)
- [validator](FilterDialog.md#validator)
- [widgetName](FilterDialog.md#widgetname)
- [bootstrapModal](FilterDialog.md#bootstrapmodal)

### Accessors

- [dialogTitle](FilterDialog.md#dialogtitle)
- [isMarkedAsPanel](FilterDialog.md#ismarkedaspanel)
- [isResponsive](FilterDialog.md#isresponsive)

### Methods

- [addCssClass](FilterDialog.md#addcssclass)
- [addValidationRule](FilterDialog.md#addvalidationrule)
- [arrange](FilterDialog.md#arrange)
- [byId](FilterDialog.md#byid)
- [change](FilterDialog.md#change)
- [changeSelect2](FilterDialog.md#changeselect2)
- [destroy](FilterDialog.md#destroy)
- [dialogClose](FilterDialog.md#dialogclose)
- [dialogOpen](FilterDialog.md#dialogopen)
- [getCssClass](FilterDialog.md#getcssclass)
- [getDialogButtons](FilterDialog.md#getdialogbuttons)
- [getDialogOptions](FilterDialog.md#getdialogoptions)
- [getDialogTitle](FilterDialog.md#getdialogtitle)
- [getFallbackTemplate](FilterDialog.md#getfallbacktemplate)
- [getGridField](FilterDialog.md#getgridfield)
- [getModalOptions](FilterDialog.md#getmodaloptions)
- [getTemplate](FilterDialog.md#gettemplate)
- [getTemplateName](FilterDialog.md#gettemplatename)
- [getToolbarButtons](FilterDialog.md#gettoolbarbuttons)
- [getValidatorOptions](FilterDialog.md#getvalidatoroptions)
- [get\_filterPanel](FilterDialog.md#get_filterpanel)
- [handleResponsive](FilterDialog.md#handleresponsive)
- [init](FilterDialog.md#init)
- [initDialog](FilterDialog.md#initdialog)
- [initModal](FilterDialog.md#initmodal)
- [initTabs](FilterDialog.md#inittabs)
- [initToolbar](FilterDialog.md#inittoolbar)
- [initValidator](FilterDialog.md#initvalidator)
- [initialize](FilterDialog.md#initialize)
- [onDialogClose](FilterDialog.md#ondialogclose)
- [onDialogOpen](FilterDialog.md#ondialogopen)
- [renderContents](FilterDialog.md#rendercontents)
- [resetValidation](FilterDialog.md#resetvalidation)
- [set\_dialogTitle](FilterDialog.md#set_dialogtitle)
- [useIdPrefix](FilterDialog.md#useidprefix)
- [validateForm](FilterDialog.md#validateform)
- [closePanel](FilterDialog.md#closepanel)
- [create](FilterDialog.md#create)
- [elementFor](FilterDialog.md#elementfor)
- [getWidgetName](FilterDialog.md#getwidgetname)
- [openPanel](FilterDialog.md#openpanel)

## Constructors

### constructor

• **new FilterDialog**()

#### Overrides

[TemplatedDialog](TemplatedDialog.md).[constructor](TemplatedDialog.md#constructor)

#### Defined in

[src/ui/filtering/filterdialog.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdialog.ts#L11)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[element](TemplatedDialog.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### filterPanel

• `Private` **filterPanel**: [`FilterPanel`](FilterPanel.md)

#### Defined in

[src/ui/filtering/filterdialog.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdialog.ts#L9)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[idPrefix](TemplatedDialog.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### options

• `Protected` **options**: `any`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[options](TemplatedDialog.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### tabs

• `Protected` **tabs**: `JQuery`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[tabs](TemplatedDialog.md#tabs)

#### Defined in

[src/ui/dialogs/templateddialog.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L12)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](Toolbar.md)

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[toolbar](TemplatedDialog.md#toolbar)

#### Defined in

[src/ui/dialogs/templateddialog.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L13)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[uniqueName](TemplatedDialog.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### validator

• `Protected` **validator**: `Validator`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[validator](TemplatedDialog.md#validator)

#### Defined in

[src/ui/dialogs/templateddialog.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L14)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[widgetName](TemplatedDialog.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

___

### bootstrapModal

▪ `Static` **bootstrapModal**: `boolean`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[bootstrapModal](TemplatedDialog.md#bootstrapmodal)

#### Defined in

[src/ui/dialogs/templateddialog.ts:274](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L274)

## Accessors

### dialogTitle

• `get` **dialogTitle**(): `string`

#### Returns

`string`

#### Inherited from

TemplatedDialog.dialogTitle

#### Defined in

[src/ui/dialogs/templateddialog.ts:360](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L360)

• `set` **dialogTitle**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`void`

#### Inherited from

TemplatedDialog.dialogTitle

#### Defined in

[src/ui/dialogs/templateddialog.ts:395](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L395)

___

### isMarkedAsPanel

• `Private` `get` **isMarkedAsPanel**(): `boolean`

#### Returns

`boolean`

#### Inherited from

TemplatedDialog.isMarkedAsPanel

#### Defined in

[src/ui/dialogs/templateddialog.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L26)

___

### isResponsive

• `Private` `get` **isResponsive**(): `boolean`

#### Returns

`boolean`

#### Inherited from

TemplatedDialog.isResponsive

#### Defined in

[src/ui/dialogs/templateddialog.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L32)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[addCssClass](TemplatedDialog.md#addcssclass)

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

[TemplatedDialog](TemplatedDialog.md).[addValidationRule](TemplatedDialog.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

___

### arrange

▸ **arrange**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[arrange](TemplatedDialog.md#arrange)

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

[TemplatedDialog](TemplatedDialog.md).[byId](TemplatedDialog.md#byid)

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

[TemplatedDialog](TemplatedDialog.md).[change](TemplatedDialog.md#change)

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

[TemplatedDialog](TemplatedDialog.md).[change](TemplatedDialog.md#change)

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

[TemplatedDialog](TemplatedDialog.md).[changeSelect2](TemplatedDialog.md#changeselect2)

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

[TemplatedDialog](TemplatedDialog.md).[changeSelect2](TemplatedDialog.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[destroy](TemplatedDialog.md#destroy)

#### Defined in

[src/ui/dialogs/templateddialog.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L81)

___

### dialogClose

▸ **dialogClose**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[dialogClose](TemplatedDialog.md#dialogclose)

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

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[dialogOpen](TemplatedDialog.md#dialogopen)

#### Defined in

[src/ui/dialogs/templateddialog.ts:244](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L244)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[getCssClass](TemplatedDialog.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getDialogButtons

▸ `Protected` **getDialogButtons**(): { `click`: () => `void` ; `text`: `string`  }[]

#### Returns

{ `click`: () => `void` ; `text`: `string`  }[]

#### Overrides

[TemplatedDialog](TemplatedDialog.md).[getDialogButtons](TemplatedDialog.md#getdialogbuttons)

#### Defined in

[src/ui/filtering/filterdialog.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdialog.ts#L30)

___

### getDialogOptions

▸ `Protected` **getDialogOptions**(): `any`

#### Returns

`any`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[getDialogOptions](TemplatedDialog.md#getdialogoptions)

#### Defined in

[src/ui/dialogs/templateddialog.ts:328](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L328)

___

### getDialogTitle

▸ `Protected` **getDialogTitle**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[getDialogTitle](TemplatedDialog.md#getdialogtitle)

#### Defined in

[src/ui/dialogs/templateddialog.ts:346](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L346)

___

### getFallbackTemplate

▸ `Protected` **getFallbackTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[getFallbackTemplate](TemplatedDialog.md#getfallbacktemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L79)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[getGridField](TemplatedDialog.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getModalOptions

▸ `Protected` **getModalOptions**(): [`ModalOptions`](../interfaces/ModalOptions.md)

#### Returns

[`ModalOptions`](../interfaces/ModalOptions.md)

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[getModalOptions](TemplatedDialog.md#getmodaloptions)

#### Defined in

[src/ui/dialogs/templateddialog.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L153)

___

### getTemplate

▸ `Protected` **getTemplate**(): `string`

#### Returns

`string`

#### Overrides

[TemplatedDialog](TemplatedDialog.md).[getTemplate](TemplatedDialog.md#gettemplate)

#### Defined in

[src/ui/filtering/filterdialog.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdialog.ts#L26)

___

### getTemplateName

▸ `Protected` **getTemplateName**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[getTemplateName](TemplatedDialog.md#gettemplatename)

#### Defined in

[src/ui/widgets/templatedwidget.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L31)

___

### getToolbarButtons

▸ `Protected` **getToolbarButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[getToolbarButtons](TemplatedDialog.md#gettoolbarbuttons)

#### Defined in

[src/ui/dialogs/templateddialog.ts:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L220)

___

### getValidatorOptions

▸ `Protected` **getValidatorOptions**(): `ValidationOptions`

#### Returns

`ValidationOptions`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[getValidatorOptions](TemplatedDialog.md#getvalidatoroptions)

#### Defined in

[src/ui/dialogs/templateddialog.ts:224](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L224)

___

### get\_filterPanel

▸ **get_filterPanel**(): [`FilterPanel`](FilterPanel.md)

#### Returns

[`FilterPanel`](FilterPanel.md)

#### Defined in

[src/ui/filtering/filterdialog.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdialog.ts#L22)

___

### handleResponsive

▸ `Protected` **handleResponsive**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[handleResponsive](TemplatedDialog.md#handleresponsive)

#### Defined in

[src/ui/dialogs/templateddialog.ts:426](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L426)

___

### init

▸ **init**(`action?`): [`FilterDialog`](FilterDialog.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`FilterDialog`](FilterDialog.md)

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[init](TemplatedDialog.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initDialog

▸ `Protected` **initDialog**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[initDialog](TemplatedDialog.md#initdialog)

#### Defined in

[src/ui/dialogs/templateddialog.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L104)

___

### initModal

▸ `Protected` **initModal**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[initModal](TemplatedDialog.md#initmodal)

#### Defined in

[src/ui/dialogs/templateddialog.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L162)

___

### initTabs

▸ `Protected` **initTabs**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[initTabs](TemplatedDialog.md#inittabs)

#### Defined in

[src/ui/dialogs/templateddialog.ts:417](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L417)

___

### initToolbar

▸ `Protected` **initToolbar**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[initToolbar](TemplatedDialog.md#inittoolbar)

#### Defined in

[src/ui/dialogs/templateddialog.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L203)

___

### initValidator

▸ `Protected` **initValidator**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[initValidator](TemplatedDialog.md#initvalidator)

#### Defined in

[src/ui/dialogs/templateddialog.ts:228](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L228)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[initialize](TemplatedDialog.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### onDialogClose

▸ `Protected` **onDialogClose**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[onDialogClose](TemplatedDialog.md#ondialogclose)

#### Defined in

[src/ui/dialogs/templateddialog.ts:297](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L297)

___

### onDialogOpen

▸ `Protected` **onDialogOpen**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[onDialogOpen](TemplatedDialog.md#ondialogopen)

#### Defined in

[src/ui/dialogs/templateddialog.ts:284](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L284)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[renderContents](TemplatedDialog.md#rendercontents)

#### Defined in

[src/ui/widgets/templatedwidget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L110)

___

### resetValidation

▸ `Protected` **resetValidation**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[resetValidation](TemplatedDialog.md#resetvalidation)

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

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[set_dialogTitle](TemplatedDialog.md#set_dialogtitle)

#### Defined in

[src/ui/dialogs/templateddialog.ts:413](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L413)

___

### useIdPrefix

▸ `Protected` **useIdPrefix**(): `IdPrefixType`

#### Returns

`IdPrefixType`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[useIdPrefix](TemplatedDialog.md#useidprefix)

#### Defined in

[src/ui/widgets/templatedwidget.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L131)

___

### validateForm

▸ `Protected` **validateForm**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[validateForm](TemplatedDialog.md#validateform)

#### Defined in

[src/ui/dialogs/templateddialog.ts:240](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L240)

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

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[closePanel](TemplatedDialog.md#closepanel)

#### Defined in

[src/ui/dialogs/templateddialog.ts:280](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L280)

___

### create

▸ `Static` **create**<`TWidget`, `TOpt`\>(`params`): `TWidget`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TWidget` | extends [`Widget`](Widget.md)<`TOpt`, `TWidget`\> |
| `TOpt` | `TOpt` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `params` | [`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)<`TWidget`, `TOpt`\> |

#### Returns

`TWidget`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[create](TemplatedDialog.md#create)

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

[TemplatedDialog](TemplatedDialog.md).[elementFor](TemplatedDialog.md#elementfor)

#### Defined in

[src/ui/widgets/widget.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L128)

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

[TemplatedDialog](TemplatedDialog.md).[getWidgetName](TemplatedDialog.md#getwidgetname)

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

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[openPanel](TemplatedDialog.md#openpanel)

#### Defined in

[src/ui/dialogs/templateddialog.ts:276](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L276)
