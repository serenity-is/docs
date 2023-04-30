[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / FilterDialog

# Class: FilterDialog

[corelib](../modules/corelib.md).FilterDialog

## Hierarchy

- [`TemplatedDialog`](corelib.TemplatedDialog.md)<`any`\>

  ↳ **`FilterDialog`**

## Table of contents

### Constructors

- [constructor](corelib.FilterDialog.md#constructor)

### Properties

- [element](corelib.FilterDialog.md#element)
- [filterPanel](corelib.FilterDialog.md#filterpanel)
- [idPrefix](corelib.FilterDialog.md#idprefix)
- [options](corelib.FilterDialog.md#options)
- [tabs](corelib.FilterDialog.md#tabs)
- [toolbar](corelib.FilterDialog.md#toolbar)
- [uniqueName](corelib.FilterDialog.md#uniquename)
- [validator](corelib.FilterDialog.md#validator)
- [widgetName](corelib.FilterDialog.md#widgetname)
- [bootstrapModal](corelib.FilterDialog.md#bootstrapmodal)

### Accessors

- [dialogTitle](corelib.FilterDialog.md#dialogtitle)
- [isMarkedAsPanel](corelib.FilterDialog.md#ismarkedaspanel)
- [isResponsive](corelib.FilterDialog.md#isresponsive)

### Methods

- [addCssClass](corelib.FilterDialog.md#addcssclass)
- [addValidationRule](corelib.FilterDialog.md#addvalidationrule)
- [arrange](corelib.FilterDialog.md#arrange)
- [byId](corelib.FilterDialog.md#byid)
- [change](corelib.FilterDialog.md#change)
- [changeSelect2](corelib.FilterDialog.md#changeselect2)
- [destroy](corelib.FilterDialog.md#destroy)
- [dialogClose](corelib.FilterDialog.md#dialogclose)
- [dialogOpen](corelib.FilterDialog.md#dialogopen)
- [getCssClass](corelib.FilterDialog.md#getcssclass)
- [getDialogButtons](corelib.FilterDialog.md#getdialogbuttons)
- [getDialogOptions](corelib.FilterDialog.md#getdialogoptions)
- [getDialogTitle](corelib.FilterDialog.md#getdialogtitle)
- [getFallbackTemplate](corelib.FilterDialog.md#getfallbacktemplate)
- [getGridField](corelib.FilterDialog.md#getgridfield)
- [getModalOptions](corelib.FilterDialog.md#getmodaloptions)
- [getTemplate](corelib.FilterDialog.md#gettemplate)
- [getTemplateName](corelib.FilterDialog.md#gettemplatename)
- [getToolbarButtons](corelib.FilterDialog.md#gettoolbarbuttons)
- [getValidatorOptions](corelib.FilterDialog.md#getvalidatoroptions)
- [get\_filterPanel](corelib.FilterDialog.md#get_filterpanel)
- [handleResponsive](corelib.FilterDialog.md#handleresponsive)
- [init](corelib.FilterDialog.md#init)
- [initDialog](corelib.FilterDialog.md#initdialog)
- [initModal](corelib.FilterDialog.md#initmodal)
- [initTabs](corelib.FilterDialog.md#inittabs)
- [initToolbar](corelib.FilterDialog.md#inittoolbar)
- [initValidator](corelib.FilterDialog.md#initvalidator)
- [initialize](corelib.FilterDialog.md#initialize)
- [onDialogClose](corelib.FilterDialog.md#ondialogclose)
- [onDialogOpen](corelib.FilterDialog.md#ondialogopen)
- [renderContents](corelib.FilterDialog.md#rendercontents)
- [resetValidation](corelib.FilterDialog.md#resetvalidation)
- [set\_dialogTitle](corelib.FilterDialog.md#set_dialogtitle)
- [useIdPrefix](corelib.FilterDialog.md#useidprefix)
- [validateForm](corelib.FilterDialog.md#validateform)
- [closePanel](corelib.FilterDialog.md#closepanel)
- [create](corelib.FilterDialog.md#create)
- [elementFor](corelib.FilterDialog.md#elementfor)
- [getWidgetName](corelib.FilterDialog.md#getwidgetname)
- [openPanel](corelib.FilterDialog.md#openpanel)

## Constructors

### constructor

• **new FilterDialog**()

#### Overrides

[TemplatedDialog](corelib.TemplatedDialog.md).[constructor](corelib.TemplatedDialog.md#constructor)

#### Defined in

[src/ui/filtering/filterdialog.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdialog.ts#L11)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[element](corelib.TemplatedDialog.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### filterPanel

• `Private` **filterPanel**: [`FilterPanel`](corelib.FilterPanel.md)

#### Defined in

[src/ui/filtering/filterdialog.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdialog.ts#L9)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[idPrefix](corelib.TemplatedDialog.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### options

• `Protected` **options**: `any`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[options](corelib.TemplatedDialog.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### tabs

• `Protected` **tabs**: `JQuery`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[tabs](corelib.TemplatedDialog.md#tabs)

#### Defined in

[src/ui/dialogs/templateddialog.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L12)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](corelib.Toolbar.md)

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[toolbar](corelib.TemplatedDialog.md#toolbar)

#### Defined in

[src/ui/dialogs/templateddialog.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L13)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[uniqueName](corelib.TemplatedDialog.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L64)

___

### validator

• `Protected` **validator**: `Validator`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[validator](corelib.TemplatedDialog.md#validator)

#### Defined in

[src/ui/dialogs/templateddialog.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L14)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[widgetName](corelib.TemplatedDialog.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

___

### bootstrapModal

▪ `Static` **bootstrapModal**: `boolean`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[bootstrapModal](corelib.TemplatedDialog.md#bootstrapmodal)

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

[src/ui/dialogs/templateddialog.ts:385](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L385)

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

[src/ui/dialogs/templateddialog.ts:420](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L420)

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

[TemplatedDialog](corelib.TemplatedDialog.md).[addCssClass](corelib.TemplatedDialog.md#addcssclass)

#### Defined in

[src/ui/dialogs/templateddialog.ts:340](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L340)

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

[TemplatedDialog](corelib.TemplatedDialog.md).[addValidationRule](corelib.TemplatedDialog.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L134)

___

### arrange

▸ **arrange**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[arrange](corelib.TemplatedDialog.md#arrange)

#### Defined in

[src/ui/dialogs/templateddialog.ts:316](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L316)

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

[TemplatedDialog](corelib.TemplatedDialog.md).[byId](corelib.TemplatedDialog.md#byid)

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

[TemplatedDialog](corelib.TemplatedDialog.md).[change](corelib.TemplatedDialog.md#change)

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

[TemplatedDialog](corelib.TemplatedDialog.md).[change](corelib.TemplatedDialog.md#change)

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

[TemplatedDialog](corelib.TemplatedDialog.md).[changeSelect2](corelib.TemplatedDialog.md#changeselect2)

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

[TemplatedDialog](corelib.TemplatedDialog.md).[changeSelect2](corelib.TemplatedDialog.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[destroy](corelib.TemplatedDialog.md#destroy)

#### Defined in

[src/ui/dialogs/templateddialog.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L81)

___

### dialogClose

▸ **dialogClose**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[dialogClose](corelib.TemplatedDialog.md#dialogclose)

#### Defined in

[src/ui/dialogs/templateddialog.ts:375](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L375)

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

[TemplatedDialog](corelib.TemplatedDialog.md).[dialogOpen](corelib.TemplatedDialog.md#dialogopen)

#### Defined in

[src/ui/dialogs/templateddialog.ts:244](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L244)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[getCssClass](corelib.TemplatedDialog.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L104)

___

### getDialogButtons

▸ `Protected` **getDialogButtons**(): { `click`: () => `void` ; `text`: `string`  }[]

#### Returns

{ `click`: () => `void` ; `text`: `string`  }[]

#### Overrides

[TemplatedDialog](corelib.TemplatedDialog.md).[getDialogButtons](corelib.TemplatedDialog.md#getdialogbuttons)

#### Defined in

[src/ui/filtering/filterdialog.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdialog.ts#L30)

___

### getDialogOptions

▸ `Protected` **getDialogOptions**(): `any`

#### Returns

`any`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[getDialogOptions](corelib.TemplatedDialog.md#getdialogoptions)

#### Defined in

[src/ui/dialogs/templateddialog.ts:353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L353)

___

### getDialogTitle

▸ `Protected` **getDialogTitle**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[getDialogTitle](corelib.TemplatedDialog.md#getdialogtitle)

#### Defined in

[src/ui/dialogs/templateddialog.ts:371](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L371)

___

### getFallbackTemplate

▸ `Protected` **getFallbackTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[getFallbackTemplate](corelib.TemplatedDialog.md#getfallbacktemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L79)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[getGridField](corelib.TemplatedDialog.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getModalOptions

▸ `Protected` **getModalOptions**(): [`ModalOptions`](../interfaces/corelib.ModalOptions.md)

#### Returns

[`ModalOptions`](../interfaces/corelib.ModalOptions.md)

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[getModalOptions](corelib.TemplatedDialog.md#getmodaloptions)

#### Defined in

[src/ui/dialogs/templateddialog.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L153)

___

### getTemplate

▸ `Protected` **getTemplate**(): `string`

#### Returns

`string`

#### Overrides

[TemplatedDialog](corelib.TemplatedDialog.md).[getTemplate](corelib.TemplatedDialog.md#gettemplate)

#### Defined in

[src/ui/filtering/filterdialog.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdialog.ts#L26)

___

### getTemplateName

▸ `Protected` **getTemplateName**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[getTemplateName](corelib.TemplatedDialog.md#gettemplatename)

#### Defined in

[src/ui/widgets/templatedwidget.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L31)

___

### getToolbarButtons

▸ `Protected` **getToolbarButtons**(): [`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[getToolbarButtons](corelib.TemplatedDialog.md#gettoolbarbuttons)

#### Defined in

[src/ui/dialogs/templateddialog.ts:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L220)

___

### getValidatorOptions

▸ `Protected` **getValidatorOptions**(): `ValidationOptions`

#### Returns

`ValidationOptions`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[getValidatorOptions](corelib.TemplatedDialog.md#getvalidatoroptions)

#### Defined in

[src/ui/dialogs/templateddialog.ts:224](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L224)

___

### get\_filterPanel

▸ **get_filterPanel**(): [`FilterPanel`](corelib.FilterPanel.md)

#### Returns

[`FilterPanel`](corelib.FilterPanel.md)

#### Defined in

[src/ui/filtering/filterdialog.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/filtering/filterdialog.ts#L22)

___

### handleResponsive

▸ `Protected` **handleResponsive**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[handleResponsive](corelib.TemplatedDialog.md#handleresponsive)

#### Defined in

[src/ui/dialogs/templateddialog.ts:451](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L451)

___

### init

▸ **init**(`action?`): [`FilterDialog`](corelib.FilterDialog.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`FilterDialog`](corelib.FilterDialog.md)

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[init](corelib.TemplatedDialog.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initDialog

▸ `Protected` **initDialog**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[initDialog](corelib.TemplatedDialog.md#initdialog)

#### Defined in

[src/ui/dialogs/templateddialog.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L104)

___

### initModal

▸ `Protected` **initModal**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[initModal](corelib.TemplatedDialog.md#initmodal)

#### Defined in

[src/ui/dialogs/templateddialog.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L162)

___

### initTabs

▸ `Protected` **initTabs**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[initTabs](corelib.TemplatedDialog.md#inittabs)

#### Defined in

[src/ui/dialogs/templateddialog.ts:442](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L442)

___

### initToolbar

▸ `Protected` **initToolbar**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[initToolbar](corelib.TemplatedDialog.md#inittoolbar)

#### Defined in

[src/ui/dialogs/templateddialog.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L203)

___

### initValidator

▸ `Protected` **initValidator**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[initValidator](corelib.TemplatedDialog.md#initvalidator)

#### Defined in

[src/ui/dialogs/templateddialog.ts:228](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L228)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[initialize](corelib.TemplatedDialog.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L176)

___

### onDialogClose

▸ `Protected` **onDialogClose**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[onDialogClose](corelib.TemplatedDialog.md#ondialogclose)

#### Defined in

[src/ui/dialogs/templateddialog.ts:322](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L322)

___

### onDialogOpen

▸ `Protected` **onDialogOpen**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[onDialogOpen](corelib.TemplatedDialog.md#ondialogopen)

#### Defined in

[src/ui/dialogs/templateddialog.ts:309](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L309)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[renderContents](corelib.TemplatedDialog.md#rendercontents)

#### Defined in

[src/ui/widgets/templatedwidget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L110)

___

### resetValidation

▸ `Protected` **resetValidation**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[resetValidation](corelib.TemplatedDialog.md#resetvalidation)

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

[TemplatedDialog](corelib.TemplatedDialog.md).[set_dialogTitle](corelib.TemplatedDialog.md#set_dialogtitle)

#### Defined in

[src/ui/dialogs/templateddialog.ts:438](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L438)

___

### useIdPrefix

▸ `Protected` **useIdPrefix**(): `IdPrefixType`

#### Returns

`IdPrefixType`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[useIdPrefix](corelib.TemplatedDialog.md#useidprefix)

#### Defined in

[src/ui/widgets/templatedwidget.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L131)

___

### validateForm

▸ `Protected` **validateForm**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[validateForm](corelib.TemplatedDialog.md#validateform)

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

[TemplatedDialog](corelib.TemplatedDialog.md).[closePanel](corelib.TemplatedDialog.md#closepanel)

#### Defined in

[src/ui/dialogs/templateddialog.ts:305](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L305)

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

[TemplatedDialog](corelib.TemplatedDialog.md).[create](corelib.TemplatedDialog.md#create)

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

[TemplatedDialog](corelib.TemplatedDialog.md).[elementFor](corelib.TemplatedDialog.md#elementfor)

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

[TemplatedDialog](corelib.TemplatedDialog.md).[getWidgetName](corelib.TemplatedDialog.md#getwidgetname)

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

[TemplatedDialog](corelib.TemplatedDialog.md).[openPanel](corelib.TemplatedDialog.md#openpanel)

#### Defined in

[src/ui/dialogs/templateddialog.ts:276](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L276)
