[@serenity-is/corelib](../README.md) / PropertyDialog

# Class: PropertyDialog<TItem, TOptions\>

## Type parameters

| Name |
| :------ |
| `TItem` |
| `TOptions` |

## Hierarchy

- [`TemplatedDialog`](TemplatedDialog.md)<`TOptions`\>

  ↳ **`PropertyDialog`**

## Table of contents

### Constructors

- [constructor](PropertyDialog.md#constructor)

### Properties

- [element](PropertyDialog.md#element)
- [entity](PropertyDialog.md#entity)
- [entityId](PropertyDialog.md#entityid)
- [idPrefix](PropertyDialog.md#idprefix)
- [options](PropertyDialog.md#options)
- [propertyGrid](PropertyDialog.md#propertygrid)
- [propertyItemsData](PropertyDialog.md#propertyitemsdata)
- [tabs](PropertyDialog.md#tabs)
- [toolbar](PropertyDialog.md#toolbar)
- [uniqueName](PropertyDialog.md#uniquename)
- [validator](PropertyDialog.md#validator)
- [widgetName](PropertyDialog.md#widgetname)
- [bootstrapModal](PropertyDialog.md#bootstrapmodal)

### Accessors

- [dialogTitle](PropertyDialog.md#dialogtitle)
- [isMarkedAsPanel](PropertyDialog.md#ismarkedaspanel)
- [isResponsive](PropertyDialog.md#isresponsive)

### Methods

- [addCssClass](PropertyDialog.md#addcssclass)
- [addValidationRule](PropertyDialog.md#addvalidationrule)
- [afterInit](PropertyDialog.md#afterinit)
- [arrange](PropertyDialog.md#arrange)
- [byId](PropertyDialog.md#byid)
- [cancelClick](PropertyDialog.md#cancelclick)
- [change](PropertyDialog.md#change)
- [changeSelect2](PropertyDialog.md#changeselect2)
- [destroy](PropertyDialog.md#destroy)
- [dialogClose](PropertyDialog.md#dialogclose)
- [dialogOpen](PropertyDialog.md#dialogopen)
- [getCssClass](PropertyDialog.md#getcssclass)
- [getDialogButtons](PropertyDialog.md#getdialogbuttons)
- [getDialogOptions](PropertyDialog.md#getdialogoptions)
- [getDialogTitle](PropertyDialog.md#getdialogtitle)
- [getFallbackTemplate](PropertyDialog.md#getfallbacktemplate)
- [getFormKey](PropertyDialog.md#getformkey)
- [getGridField](PropertyDialog.md#getgridfield)
- [getModalOptions](PropertyDialog.md#getmodaloptions)
- [getPropertyGridOptions](PropertyDialog.md#getpropertygridoptions)
- [getPropertyItems](PropertyDialog.md#getpropertyitems)
- [getPropertyItemsData](PropertyDialog.md#getpropertyitemsdata)
- [getPropertyItemsDataAsync](PropertyDialog.md#getpropertyitemsdataasync)
- [getSaveEntity](PropertyDialog.md#getsaveentity)
- [getTemplate](PropertyDialog.md#gettemplate)
- [getTemplateName](PropertyDialog.md#gettemplatename)
- [getToolbarButtons](PropertyDialog.md#gettoolbarbuttons)
- [getValidatorOptions](PropertyDialog.md#getvalidatoroptions)
- [get\_entity](PropertyDialog.md#get_entity)
- [get\_entityId](PropertyDialog.md#get_entityid)
- [handleResponsive](PropertyDialog.md#handleresponsive)
- [init](PropertyDialog.md#init)
- [initAsync](PropertyDialog.md#initasync)
- [initDialog](PropertyDialog.md#initdialog)
- [initModal](PropertyDialog.md#initmodal)
- [initPropertyGrid](PropertyDialog.md#initpropertygrid)
- [initSync](PropertyDialog.md#initsync)
- [initTabs](PropertyDialog.md#inittabs)
- [initToolbar](PropertyDialog.md#inittoolbar)
- [initValidator](PropertyDialog.md#initvalidator)
- [initialize](PropertyDialog.md#initialize)
- [internalInit](PropertyDialog.md#internalinit)
- [loadInitialEntity](PropertyDialog.md#loadinitialentity)
- [okClick](PropertyDialog.md#okclick)
- [okClickValidated](PropertyDialog.md#okclickvalidated)
- [onDialogClose](PropertyDialog.md#ondialogclose)
- [onDialogOpen](PropertyDialog.md#ondialogopen)
- [renderContents](PropertyDialog.md#rendercontents)
- [resetValidation](PropertyDialog.md#resetvalidation)
- [set\_dialogTitle](PropertyDialog.md#set_dialogtitle)
- [set\_entity](PropertyDialog.md#set_entity)
- [set\_entityId](PropertyDialog.md#set_entityid)
- [updateTitle](PropertyDialog.md#updatetitle)
- [useAsync](PropertyDialog.md#useasync)
- [useIdPrefix](PropertyDialog.md#useidprefix)
- [validateBeforeSave](PropertyDialog.md#validatebeforesave)
- [validateForm](PropertyDialog.md#validateform)
- [closePanel](PropertyDialog.md#closepanel)
- [create](PropertyDialog.md#create)
- [elementFor](PropertyDialog.md#elementfor)
- [getWidgetName](PropertyDialog.md#getwidgetname)
- [openPanel](PropertyDialog.md#openpanel)

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

[TemplatedDialog](TemplatedDialog.md).[constructor](TemplatedDialog.md#constructor)

#### Defined in

[src/ui/dialogs/propertydialog.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L12)

## Properties

### element

• **element**: `JQuery`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[element](TemplatedDialog.md#element)

#### Defined in

[src/ui/widgets/widget.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L61)

___

### entity

• `Protected` **entity**: `TItem`

#### Defined in

[src/ui/dialogs/propertydialog.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L8)

___

### entityId

• `Protected` **entityId**: `any`

#### Defined in

[src/ui/dialogs/propertydialog.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L9)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[idPrefix](TemplatedDialog.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L65)

___

### options

• `Protected` **options**: `TOptions`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[options](TemplatedDialog.md#options)

#### Defined in

[src/ui/widgets/widget.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L62)

___

### propertyGrid

• `Protected` **propertyGrid**: [`PropertyGrid`](PropertyGrid.md)

#### Defined in

[src/ui/dialogs/propertydialog.ts:204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L204)

___

### propertyItemsData

• `Protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Defined in

[src/ui/dialogs/propertydialog.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L10)

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

### afterInit

▸ `Protected` **afterInit**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L38)

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

### cancelClick

▸ `Protected` **cancelClick**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L89)

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

#### Overrides

[TemplatedDialog](TemplatedDialog.md).[destroy](TemplatedDialog.md#destroy)

#### Defined in

[src/ui/dialogs/propertydialog.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L45)

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

▸ `Protected` **getDialogButtons**(): [`DialogButton`](../interfaces/DialogButton.md)[]

#### Returns

[`DialogButton`](../interfaces/DialogButton.md)[]

#### Overrides

[TemplatedDialog](TemplatedDialog.md).[getDialogButtons](TemplatedDialog.md#getdialogbuttons)

#### Defined in

[src/ui/dialogs/propertydialog.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L65)

___

### getDialogOptions

▸ `Protected` **getDialogOptions**(): `any`

#### Returns

`any`

#### Overrides

[TemplatedDialog](TemplatedDialog.md).[getDialogOptions](TemplatedDialog.md#getdialogoptions)

#### Defined in

[src/ui/dialogs/propertydialog.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L59)

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

#### Overrides

[TemplatedDialog](TemplatedDialog.md).[getFallbackTemplate](TemplatedDialog.md#getfallbacktemplate)

#### Defined in

[src/ui/dialogs/propertydialog.ts:206](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L206)

___

### getFormKey

▸ `Protected` **getFormKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/propertydialog.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L105)

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

### getPropertyGridOptions

▸ `Protected` **getPropertyGridOptions**(): [`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

#### Returns

[`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

#### Defined in

[src/ui/dialogs/propertydialog.ts:127](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L127)

___

### getPropertyItems

▸ `Protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Defined in

[src/ui/dialogs/propertydialog.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L137)

___

### getPropertyItemsData

▸ `Protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Defined in

[src/ui/dialogs/propertydialog.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L141)

___

### getPropertyItemsDataAsync

▸ `Protected` **getPropertyItemsDataAsync**(): `Promise`<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Returns

`Promise`<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Defined in

[src/ui/dialogs/propertydialog.ts:160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L160)

___

### getSaveEntity

▸ `Protected` **getSaveEntity**(): `TItem`

#### Returns

`TItem`

#### Defined in

[src/ui/dialogs/propertydialog.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L169)

___

### getTemplate

▸ `Protected` **getTemplate**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[getTemplate](TemplatedDialog.md#gettemplate)

#### Defined in

[src/ui/widgets/templatedwidget.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L83)

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

### get\_entity

▸ `Protected` **get_entity**(): `TItem`

#### Returns

`TItem`

#### Defined in

[src/ui/dialogs/propertydialog.ts:181](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L181)

___

### get\_entityId

▸ `Protected` **get_entityId**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/dialogs/propertydialog.ts:189](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L189)

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

▸ **init**(`action?`): [`PropertyDialog`](PropertyDialog.md)<`TItem`, `TOptions`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`PropertyDialog`](PropertyDialog.md)<`TItem`, `TOptions`\>

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[init](TemplatedDialog.md#init)

#### Defined in

[src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

___

### initAsync

▸ `Protected` **initAsync**(): `Promise`<`void`\>

#### Returns

`Promise`<`void`\>

#### Defined in

[src/ui/dialogs/propertydialog.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L32)

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

### initPropertyGrid

▸ `Protected` **initPropertyGrid**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L93)

___

### initSync

▸ `Protected` **initSync**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L26)

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

### internalInit

▸ **internalInit**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L21)

___

### loadInitialEntity

▸ `Protected` **loadInitialEntity**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L177)

___

### okClick

▸ `Protected` **okClick**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L77)

___

### okClickValidated

▸ `Protected` **okClickValidated**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L85)

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

### set\_entity

▸ `Protected` **set_entity**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `TItem` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L185)

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

[src/ui/dialogs/propertydialog.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L193)

___

### updateTitle

▸ `Protected` **updateTitle**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:201](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L201)

___

### useAsync

▸ `Protected` **useAsync**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/propertydialog.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L41)

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

### validateBeforeSave

▸ `Protected` **validateBeforeSave**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/propertydialog.ts:197](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L197)

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
