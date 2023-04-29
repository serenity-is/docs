[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / PropertyDialog

# Class: PropertyDialog<TItem, TOptions\>

[corelib](../modules/corelib.md).PropertyDialog

## Type parameters

| Name |
| :------ |
| `TItem` |
| `TOptions` |

## Hierarchy

- [`TemplatedDialog`](corelib.TemplatedDialog.md)<`TOptions`\>

  ↳ **`PropertyDialog`**

## Table of contents

### Constructors

- [constructor](corelib.PropertyDialog.md#constructor)

### Properties

- [element](corelib.PropertyDialog.md#element)
- [entity](corelib.PropertyDialog.md#entity)
- [entityId](corelib.PropertyDialog.md#entityid)
- [idPrefix](corelib.PropertyDialog.md#idprefix)
- [options](corelib.PropertyDialog.md#options)
- [propertyGrid](corelib.PropertyDialog.md#propertygrid)
- [propertyItemsData](corelib.PropertyDialog.md#propertyitemsdata)
- [tabs](corelib.PropertyDialog.md#tabs)
- [toolbar](corelib.PropertyDialog.md#toolbar)
- [uniqueName](corelib.PropertyDialog.md#uniquename)
- [validator](corelib.PropertyDialog.md#validator)
- [widgetName](corelib.PropertyDialog.md#widgetname)
- [bootstrapModal](corelib.PropertyDialog.md#bootstrapmodal)

### Accessors

- [dialogTitle](corelib.PropertyDialog.md#dialogtitle)
- [isMarkedAsPanel](corelib.PropertyDialog.md#ismarkedaspanel)
- [isResponsive](corelib.PropertyDialog.md#isresponsive)

### Methods

- [addCssClass](corelib.PropertyDialog.md#addcssclass)
- [addValidationRule](corelib.PropertyDialog.md#addvalidationrule)
- [afterInit](corelib.PropertyDialog.md#afterinit)
- [arrange](corelib.PropertyDialog.md#arrange)
- [byId](corelib.PropertyDialog.md#byid)
- [cancelClick](corelib.PropertyDialog.md#cancelclick)
- [change](corelib.PropertyDialog.md#change)
- [changeSelect2](corelib.PropertyDialog.md#changeselect2)
- [destroy](corelib.PropertyDialog.md#destroy)
- [dialogClose](corelib.PropertyDialog.md#dialogclose)
- [dialogOpen](corelib.PropertyDialog.md#dialogopen)
- [getCssClass](corelib.PropertyDialog.md#getcssclass)
- [getDialogButtons](corelib.PropertyDialog.md#getdialogbuttons)
- [getDialogOptions](corelib.PropertyDialog.md#getdialogoptions)
- [getDialogTitle](corelib.PropertyDialog.md#getdialogtitle)
- [getFallbackTemplate](corelib.PropertyDialog.md#getfallbacktemplate)
- [getFormKey](corelib.PropertyDialog.md#getformkey)
- [getGridField](corelib.PropertyDialog.md#getgridfield)
- [getModalOptions](corelib.PropertyDialog.md#getmodaloptions)
- [getPropertyGridOptions](corelib.PropertyDialog.md#getpropertygridoptions)
- [getPropertyItems](corelib.PropertyDialog.md#getpropertyitems)
- [getPropertyItemsData](corelib.PropertyDialog.md#getpropertyitemsdata)
- [getPropertyItemsDataAsync](corelib.PropertyDialog.md#getpropertyitemsdataasync)
- [getSaveEntity](corelib.PropertyDialog.md#getsaveentity)
- [getTemplate](corelib.PropertyDialog.md#gettemplate)
- [getTemplateName](corelib.PropertyDialog.md#gettemplatename)
- [getToolbarButtons](corelib.PropertyDialog.md#gettoolbarbuttons)
- [getValidatorOptions](corelib.PropertyDialog.md#getvalidatoroptions)
- [get\_entity](corelib.PropertyDialog.md#get_entity)
- [get\_entityId](corelib.PropertyDialog.md#get_entityid)
- [handleResponsive](corelib.PropertyDialog.md#handleresponsive)
- [init](corelib.PropertyDialog.md#init)
- [initAsync](corelib.PropertyDialog.md#initasync)
- [initDialog](corelib.PropertyDialog.md#initdialog)
- [initModal](corelib.PropertyDialog.md#initmodal)
- [initPropertyGrid](corelib.PropertyDialog.md#initpropertygrid)
- [initSync](corelib.PropertyDialog.md#initsync)
- [initTabs](corelib.PropertyDialog.md#inittabs)
- [initToolbar](corelib.PropertyDialog.md#inittoolbar)
- [initValidator](corelib.PropertyDialog.md#initvalidator)
- [initialize](corelib.PropertyDialog.md#initialize)
- [internalInit](corelib.PropertyDialog.md#internalinit)
- [loadInitialEntity](corelib.PropertyDialog.md#loadinitialentity)
- [okClick](corelib.PropertyDialog.md#okclick)
- [okClickValidated](corelib.PropertyDialog.md#okclickvalidated)
- [onDialogClose](corelib.PropertyDialog.md#ondialogclose)
- [onDialogOpen](corelib.PropertyDialog.md#ondialogopen)
- [renderContents](corelib.PropertyDialog.md#rendercontents)
- [resetValidation](corelib.PropertyDialog.md#resetvalidation)
- [set\_dialogTitle](corelib.PropertyDialog.md#set_dialogtitle)
- [set\_entity](corelib.PropertyDialog.md#set_entity)
- [set\_entityId](corelib.PropertyDialog.md#set_entityid)
- [updateTitle](corelib.PropertyDialog.md#updatetitle)
- [useAsync](corelib.PropertyDialog.md#useasync)
- [useIdPrefix](corelib.PropertyDialog.md#useidprefix)
- [validateBeforeSave](corelib.PropertyDialog.md#validatebeforesave)
- [validateForm](corelib.PropertyDialog.md#validateform)
- [closePanel](corelib.PropertyDialog.md#closepanel)
- [create](corelib.PropertyDialog.md#create)
- [elementFor](corelib.PropertyDialog.md#elementfor)
- [getWidgetName](corelib.PropertyDialog.md#getwidgetname)
- [openPanel](corelib.PropertyDialog.md#openpanel)

## Constructors

### constructor

• **new PropertyDialog**<`TItem`, `TOptions`\>(`opt?`)

#### Type parameters

| Name |
| :------ |
| `TItem` |
| `TOptions` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `opt?` | `TOptions` |

#### Overrides

[TemplatedDialog](corelib.TemplatedDialog.md).[constructor](corelib.TemplatedDialog.md#constructor)

#### Defined in

[src/ui/dialogs/propertydialog.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;12)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[element](corelib.TemplatedDialog.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;61)

___

### entity

• `Protected` **entity**: `TItem`

#### Defined in

[src/ui/dialogs/propertydialog.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;8)

___

### entityId

• `Protected` **entityId**: `any`

#### Defined in

[src/ui/dialogs/propertydialog.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;9)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[idPrefix](corelib.TemplatedDialog.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;65)

___

### options

• `Protected` **options**: `TOptions`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[options](corelib.TemplatedDialog.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;62)

___

### propertyGrid

• `Protected` **propertyGrid**: [`PropertyGrid`](corelib.PropertyGrid.md)

#### Defined in

[src/ui/dialogs/propertydialog.ts:204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;204)

___

### propertyItemsData

• `Protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)

#### Defined in

[src/ui/dialogs/propertydialog.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;10)

___

### tabs

• `Protected` **tabs**: `JQuery`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[tabs](corelib.TemplatedDialog.md#tabs)

#### Defined in

[src/ui/dialogs/templateddialog.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;12)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](corelib.Toolbar.md)

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[toolbar](corelib.TemplatedDialog.md#toolbar)

#### Defined in

[src/ui/dialogs/templateddialog.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;13)

___

### uniqueName

• `Protected` **uniqueName**: `string`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[uniqueName](corelib.TemplatedDialog.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;64)

___

### validator

• `Protected` **validator**: `Validator`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[validator](corelib.TemplatedDialog.md#validator)

#### Defined in

[src/ui/dialogs/templateddialog.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;14)

___

### widgetName

• `Protected` **widgetName**: `string`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[widgetName](corelib.TemplatedDialog.md#widgetname)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;63)

___

### bootstrapModal

▪ `Static` **bootstrapModal**: `boolean`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[bootstrapModal](corelib.TemplatedDialog.md#bootstrapmodal)

#### Defined in

[src/ui/dialogs/templateddialog.ts:274](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;274)

## Accessors

### dialogTitle

• `get` **dialogTitle**(): `string`

#### Returns

`string`

#### Inherited from

TemplatedDialog.dialogTitle

#### Defined in

[src/ui/dialogs/templateddialog.ts:385](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;385)

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

[src/ui/dialogs/templateddialog.ts:420](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;420)

___

### isMarkedAsPanel

• `Private` `get` **isMarkedAsPanel**(): `boolean`

#### Returns

`boolean`

#### Inherited from

TemplatedDialog.isMarkedAsPanel

#### Defined in

[src/ui/dialogs/templateddialog.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;26)

___

### isResponsive

• `Private` `get` **isResponsive**(): `boolean`

#### Returns

`boolean`

#### Inherited from

TemplatedDialog.isResponsive

#### Defined in

[src/ui/dialogs/templateddialog.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;32)

## Methods

### addCssClass

▸ `Protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[addCssClass](corelib.TemplatedDialog.md#addcssclass)

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

[TemplatedDialog](corelib.TemplatedDialog.md).[addValidationRule](corelib.TemplatedDialog.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;134)

___

### afterInit

▸ `Protected` **afterInit**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;38)

___

### arrange

▸ **arrange**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[arrange](corelib.TemplatedDialog.md#arrange)

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

[TemplatedDialog](corelib.TemplatedDialog.md).[byId](corelib.TemplatedDialog.md#byid)

#### Defined in

[src/ui/widgets/templatedwidget.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;10)

___

### cancelClick

▸ `Protected` **cancelClick**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;89)

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

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;142)

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

[TemplatedDialog](corelib.TemplatedDialog.md).[changeSelect2](corelib.TemplatedDialog.md#changeselect2)

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

[TemplatedDialog](corelib.TemplatedDialog.md).[changeSelect2](corelib.TemplatedDialog.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;260)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[TemplatedDialog](corelib.TemplatedDialog.md).[destroy](corelib.TemplatedDialog.md#destroy)

#### Defined in

[src/ui/dialogs/propertydialog.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;45)

___

### dialogClose

▸ **dialogClose**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[dialogClose](corelib.TemplatedDialog.md#dialogclose)

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

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[dialogOpen](corelib.TemplatedDialog.md#dialogopen)

#### Defined in

[src/ui/dialogs/templateddialog.ts:244](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;244)

___

### getCssClass

▸ `Protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[getCssClass](corelib.TemplatedDialog.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;104)

___

### getDialogButtons

▸ `Protected` **getDialogButtons**(): [`DialogButton`](../interfaces/corelib_q.DialogButton.md)[]

#### Returns

[`DialogButton`](../interfaces/corelib_q.DialogButton.md)[]

#### Overrides

[TemplatedDialog](corelib.TemplatedDialog.md).[getDialogButtons](corelib.TemplatedDialog.md#getdialogbuttons)

#### Defined in

[src/ui/dialogs/propertydialog.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;65)

___

### getDialogOptions

▸ `Protected` **getDialogOptions**(): `any`

#### Returns

`any`

#### Overrides

[TemplatedDialog](corelib.TemplatedDialog.md).[getDialogOptions](corelib.TemplatedDialog.md#getdialogoptions)

#### Defined in

[src/ui/dialogs/propertydialog.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;59)

___

### getDialogTitle

▸ `Protected` **getDialogTitle**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[getDialogTitle](corelib.TemplatedDialog.md#getdialogtitle)

#### Defined in

[src/ui/dialogs/templateddialog.ts:371](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;371)

___

### getFallbackTemplate

▸ `Protected` **getFallbackTemplate**(): `string`

#### Returns

`string`

#### Overrides

[TemplatedDialog](corelib.TemplatedDialog.md).[getFallbackTemplate](corelib.TemplatedDialog.md#getfallbacktemplate)

#### Defined in

[src/ui/dialogs/propertydialog.ts:206](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;206)

___

### getFormKey

▸ `Protected` **getFormKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/propertydialog.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;105)

___

### getGridField

▸ **getGridField**(): `JQuery`

#### Returns

`JQuery`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[getGridField](corelib.TemplatedDialog.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;138)

___

### getModalOptions

▸ `Protected` **getModalOptions**(): [`ModalOptions`](../interfaces/corelib.ModalOptions.md)

#### Returns

[`ModalOptions`](../interfaces/corelib.ModalOptions.md)

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[getModalOptions](corelib.TemplatedDialog.md#getmodaloptions)

#### Defined in

[src/ui/dialogs/templateddialog.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;153)

___

### getPropertyGridOptions

▸ `Protected` **getPropertyGridOptions**(): [`PropertyGridOptions`](../interfaces/corelib.PropertyGridOptions.md)

#### Returns

[`PropertyGridOptions`](../interfaces/corelib.PropertyGridOptions.md)

#### Defined in

[src/ui/dialogs/propertydialog.ts:127](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;127)

___

### getPropertyItems

▸ `Protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Defined in

[src/ui/dialogs/propertydialog.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;137)

___

### getPropertyItemsData

▸ `Protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)

#### Returns

[`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)

#### Defined in

[src/ui/dialogs/propertydialog.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;141)

___

### getPropertyItemsDataAsync

▸ `Protected` **getPropertyItemsDataAsync**(): `Promise`<[`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)\>

#### Returns

`Promise`<[`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)\>

#### Defined in

[src/ui/dialogs/propertydialog.ts:160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;160)

___

### getSaveEntity

▸ `Protected` **getSaveEntity**(): `TItem`

#### Returns

`TItem`

#### Defined in

[src/ui/dialogs/propertydialog.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;169)

___

### getTemplate

▸ `Protected` **getTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[getTemplate](corelib.TemplatedDialog.md#gettemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;83)

___

### getTemplateName

▸ `Protected` **getTemplateName**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[getTemplateName](corelib.TemplatedDialog.md#gettemplatename)

#### Defined in

[src/ui/widgets/templatedwidget.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;31)

___

### getToolbarButtons

▸ `Protected` **getToolbarButtons**(): [`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/corelib.ToolButton.md)[]

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[getToolbarButtons](corelib.TemplatedDialog.md#gettoolbarbuttons)

#### Defined in

[src/ui/dialogs/templateddialog.ts:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;220)

___

### getValidatorOptions

▸ `Protected` **getValidatorOptions**(): `ValidationOptions`

#### Returns

`ValidationOptions`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[getValidatorOptions](corelib.TemplatedDialog.md#getvalidatoroptions)

#### Defined in

[src/ui/dialogs/templateddialog.ts:224](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;224)

___

### get\_entity

▸ `Protected` **get_entity**(): `TItem`

#### Returns

`TItem`

#### Defined in

[src/ui/dialogs/propertydialog.ts:181](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;181)

___

### get\_entityId

▸ `Protected` **get_entityId**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/dialogs/propertydialog.ts:189](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;189)

___

### handleResponsive

▸ `Protected` **handleResponsive**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[handleResponsive](corelib.TemplatedDialog.md#handleresponsive)

#### Defined in

[src/ui/dialogs/templateddialog.ts:451](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;451)

___

### init

▸ **init**(`action?`): [`PropertyDialog`](corelib.PropertyDialog.md)<`TItem`, `TOptions`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`PropertyDialog`](corelib.PropertyDialog.md)<`TItem`, `TOptions`\>

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[init](corelib.TemplatedDialog.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;179)

___

### initAsync

▸ `Protected` **initAsync**(): `Promise`<`void`\>

#### Returns

`Promise`<`void`\>

#### Defined in

[src/ui/dialogs/propertydialog.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;32)

___

### initDialog

▸ `Protected` **initDialog**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[initDialog](corelib.TemplatedDialog.md#initdialog)

#### Defined in

[src/ui/dialogs/templateddialog.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;104)

___

### initModal

▸ `Protected` **initModal**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[initModal](corelib.TemplatedDialog.md#initmodal)

#### Defined in

[src/ui/dialogs/templateddialog.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;162)

___

### initPropertyGrid

▸ `Protected` **initPropertyGrid**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;93)

___

### initSync

▸ `Protected` **initSync**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;26)

___

### initTabs

▸ `Protected` **initTabs**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[initTabs](corelib.TemplatedDialog.md#inittabs)

#### Defined in

[src/ui/dialogs/templateddialog.ts:442](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;442)

___

### initToolbar

▸ `Protected` **initToolbar**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[initToolbar](corelib.TemplatedDialog.md#inittoolbar)

#### Defined in

[src/ui/dialogs/templateddialog.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;203)

___

### initValidator

▸ `Protected` **initValidator**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[initValidator](corelib.TemplatedDialog.md#initvalidator)

#### Defined in

[src/ui/dialogs/templateddialog.ts:228](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;228)

___

### initialize

▸ **initialize**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[initialize](corelib.TemplatedDialog.md#initialize)

#### Defined in

[src/ui/widgets/widget.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;176)

___

### internalInit

▸ **internalInit**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;21)

___

### loadInitialEntity

▸ `Protected` **loadInitialEntity**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;177)

___

### okClick

▸ `Protected` **okClick**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;77)

___

### okClickValidated

▸ `Protected` **okClickValidated**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;85)

___

### onDialogClose

▸ `Protected` **onDialogClose**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[onDialogClose](corelib.TemplatedDialog.md#ondialogclose)

#### Defined in

[src/ui/dialogs/templateddialog.ts:322](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;322)

___

### onDialogOpen

▸ `Protected` **onDialogOpen**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[onDialogOpen](corelib.TemplatedDialog.md#ondialogopen)

#### Defined in

[src/ui/dialogs/templateddialog.ts:309](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;309)

___

### renderContents

▸ `Protected` **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[renderContents](corelib.TemplatedDialog.md#rendercontents)

#### Defined in

[src/ui/widgets/templatedwidget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;110)

___

### resetValidation

▸ `Protected` **resetValidation**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[resetValidation](corelib.TemplatedDialog.md#resetvalidation)

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

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[set_dialogTitle](corelib.TemplatedDialog.md#set_dialogtitle)

#### Defined in

[src/ui/dialogs/templateddialog.ts:438](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;438)

___

### set\_entity

▸ `Protected` **set_entity**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `TItem` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;185)

___

### set\_entityId

▸ `Protected` **set_entityId**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;193)

___

### updateTitle

▸ `Protected` **updateTitle**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:201](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;201)

___

### useAsync

▸ `Protected` **useAsync**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/propertydialog.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;41)

___

### useIdPrefix

▸ `Protected` **useIdPrefix**(): `IdPrefixType`

#### Returns

`IdPrefixType`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[useIdPrefix](corelib.TemplatedDialog.md#useidprefix)

#### Defined in

[src/ui/widgets/templatedwidget.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#line&#x3D;131)

___

### validateBeforeSave

▸ `Protected` **validateBeforeSave**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/propertydialog.ts:197](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#line&#x3D;197)

___

### validateForm

▸ `Protected` **validateForm**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[validateForm](corelib.TemplatedDialog.md#validateform)

#### Defined in

[src/ui/dialogs/templateddialog.ts:240](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;240)

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

[TemplatedDialog](corelib.TemplatedDialog.md).[create](corelib.TemplatedDialog.md#create)

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

[TemplatedDialog](corelib.TemplatedDialog.md).[elementFor](corelib.TemplatedDialog.md#elementfor)

#### Defined in

[src/ui/widgets/widget.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;128)

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

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[openPanel](corelib.TemplatedDialog.md#openpanel)

#### Defined in

[src/ui/dialogs/templateddialog.ts:276](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;276)
