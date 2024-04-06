[@serenity-is/corelib](../README.md) / PropertyDialog

# Class: PropertyDialog\<TItem, P\>

## Type parameters

| Name |
| :------ |
| `TItem` |
| `P` |

## Hierarchy

- [`TemplatedDialog`](TemplatedDialog.md)\<`P`\>

  ↳ **`PropertyDialog`**

## Table of contents

### Constructors

- [constructor](PropertyDialog.md#constructor)

### Properties

- [dialog](PropertyDialog.md#dialog)
- [domNode](PropertyDialog.md#domnode)
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
- [typeInfo](PropertyDialog.md#typeinfo)

### Accessors

- [dialogTitle](PropertyDialog.md#dialogtitle)
- [element](PropertyDialog.md#element)
- [props](PropertyDialog.md#props)

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
- [findById](PropertyDialog.md#findbyid)
- [getCssClass](PropertyDialog.md#getcssclass)
- [getCustomAttribute](PropertyDialog.md#getcustomattribute)
- [getDialogButtons](PropertyDialog.md#getdialogbuttons)
- [getDialogOptions](PropertyDialog.md#getdialogoptions)
- [getFieldElement](PropertyDialog.md#getfieldelement)
- [getFormKey](PropertyDialog.md#getformkey)
- [getGridField](PropertyDialog.md#getgridfield)
- [getInitialDialogTitle](PropertyDialog.md#getinitialdialogtitle)
- [getPropertyGridOptions](PropertyDialog.md#getpropertygridoptions)
- [getPropertyItems](PropertyDialog.md#getpropertyitems)
- [getPropertyItemsData](PropertyDialog.md#getpropertyitemsdata)
- [getPropertyItemsDataAsync](PropertyDialog.md#getpropertyitemsdataasync)
- [getSaveEntity](PropertyDialog.md#getsaveentity)
- [getTemplate](PropertyDialog.md#gettemplate)
- [getToolbarButtons](PropertyDialog.md#gettoolbarbuttons)
- [getValidatorOptions](PropertyDialog.md#getvalidatoroptions)
- [get\_entity](PropertyDialog.md#get_entity)
- [get\_entityId](PropertyDialog.md#get_entityid)
- [handleResponsive](PropertyDialog.md#handleresponsive)
- [init](PropertyDialog.md#init)
- [initDialog](PropertyDialog.md#initdialog)
- [initPropertyGrid](PropertyDialog.md#initpropertygrid)
- [initTabs](PropertyDialog.md#inittabs)
- [initToolbar](PropertyDialog.md#inittoolbar)
- [initUIDialog](PropertyDialog.md#inituidialog)
- [initValidator](PropertyDialog.md#initvalidator)
- [internalInit](PropertyDialog.md#internalinit)
- [internalRenderContents](PropertyDialog.md#internalrendercontents)
- [isClosable](PropertyDialog.md#isclosable)
- [isStatic](PropertyDialog.md#isstatic)
- [isStaticPanel](PropertyDialog.md#isstaticpanel)
- [loadInitialEntity](PropertyDialog.md#loadinitialentity)
- [okClick](PropertyDialog.md#okclick)
- [okClickValidated](PropertyDialog.md#okclickvalidated)
- [onDialogClose](PropertyDialog.md#ondialogclose)
- [onDialogOpen](PropertyDialog.md#ondialogopen)
- [propertyItemsReady](PropertyDialog.md#propertyitemsready)
- [render](PropertyDialog.md#render)
- [renderContents](PropertyDialog.md#rendercontents)
- [resetValidation](PropertyDialog.md#resetvalidation)
- [set\_entity](PropertyDialog.md#set_entity)
- [set\_entityId](PropertyDialog.md#set_entityid)
- [syncOrAsyncThen](PropertyDialog.md#syncorasyncthen)
- [updateTitle](PropertyDialog.md#updatetitle)
- [useAsync](PropertyDialog.md#useasync)
- [useIdPrefix](PropertyDialog.md#useidprefix)
- [validateBeforeSave](PropertyDialog.md#validatebeforesave)
- [validateForm](PropertyDialog.md#validateform)
- [create](PropertyDialog.md#create)
- [createDefaultElement](PropertyDialog.md#createdefaultelement)
- [getWidgetName](PropertyDialog.md#getwidgetname)

## Constructors

### constructor

• **new PropertyDialog**\<`TItem`, `P`\>(`props?`): [`PropertyDialog`](PropertyDialog.md)\<`TItem`, `P`\>

#### Type parameters

| Name |
| :------ |
| `TItem` |
| `P` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props?` | [`WidgetProps`](../README.md#widgetprops)\<`P`\> |

#### Returns

[`PropertyDialog`](PropertyDialog.md)\<`TItem`, `P`\>

#### Overrides

[TemplatedDialog](TemplatedDialog.md).[constructor](TemplatedDialog.md#constructor)

#### Defined in

[src/ui/dialogs/propertydialog.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L18)

## Properties

### dialog

• `Protected` **dialog**: [`Dialog`](Dialog.md)

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[dialog](TemplatedDialog.md#dialog)

#### Defined in

[src/ui/dialogs/templateddialog.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L20)

___

### domNode

• `Readonly` **domNode**: `HTMLElement`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[domNode](TemplatedDialog.md#domnode)

#### Defined in

[src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

___

### entity

• `Protected` **entity**: `TItem`

#### Defined in

[src/ui/dialogs/propertydialog.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L12)

___

### entityId

• `Protected` **entityId**: `any`

#### Defined in

[src/ui/dialogs/propertydialog.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L13)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[idPrefix](TemplatedDialog.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### options

• `Protected` `Readonly` **options**: [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[options](TemplatedDialog.md#options)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

___

### propertyGrid

• `Protected` **propertyGrid**: [`PropertyGrid`](PropertyGrid.md)\<[`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)\>

#### Defined in

[src/ui/dialogs/propertydialog.ts:198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L198)

___

### propertyItemsData

• `Protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Defined in

[src/ui/dialogs/propertydialog.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L14)

___

### tabs

• `Protected` **tabs**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[tabs](TemplatedDialog.md#tabs)

#### Defined in

[src/ui/dialogs/templateddialog.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L17)

___

### toolbar

• `Protected` **toolbar**: [`Toolbar`](Toolbar.md)\<[`ToolbarOptions`](../interfaces/ToolbarOptions.md)\>

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[toolbar](TemplatedDialog.md#toolbar)

#### Defined in

[src/ui/dialogs/templateddialog.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L18)

___

### uniqueName

• `Protected` `Readonly` **uniqueName**: `string`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[uniqueName](TemplatedDialog.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

___

### validator

• `Protected` **validator**: `any`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[validator](TemplatedDialog.md#validator)

#### Defined in

[src/ui/dialogs/templateddialog.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L19)

___

### typeInfo

▪ `Static` **typeInfo**: [`ClassTypeInfo`](../README.md#classtypeinfo)\<``"Serenity.Widget"``\>

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[typeInfo](TemplatedDialog.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

## Accessors

### dialogTitle

• `get` **dialogTitle**(): `string`

#### Returns

`string`

#### Inherited from

TemplatedDialog.dialogTitle

#### Defined in

[src/ui/dialogs/templateddialog.ts:189](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L189)

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

[src/ui/dialogs/templateddialog.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L193)

___

### element

• `get` **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

TemplatedDialog.element

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

___

### props

• `get` **props**(): [`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Returns

[`WidgetProps`](../README.md#widgetprops)\<`P`\>

#### Inherited from

TemplatedDialog.props

#### Defined in

[src/ui/widgets/widget.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L182)

## Methods

### addCssClass

▸ **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[addCssClass](TemplatedDialog.md#addcssclass)

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

[TemplatedDialog](TemplatedDialog.md).[addValidationRule](TemplatedDialog.md#addvalidationrule)

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

[TemplatedDialog](TemplatedDialog.md).[addValidationRule](TemplatedDialog.md#addvalidationrule)

#### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

___

### afterInit

▸ **afterInit**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L32)

___

### arrange

▸ **arrange**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[arrange](TemplatedDialog.md#arrange)

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

[TemplatedDialog](TemplatedDialog.md).[byId](TemplatedDialog.md#byid)

#### Defined in

[src/ui/widgets/templatedwidget.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L8)

___

### cancelClick

▸ **cancelClick**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L87)

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

[TemplatedDialog](TemplatedDialog.md).[change](TemplatedDialog.md#change)

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

[TemplatedDialog](TemplatedDialog.md).[changeSelect2](TemplatedDialog.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[TemplatedDialog](TemplatedDialog.md).[destroy](TemplatedDialog.md#destroy)

#### Defined in

[src/ui/dialogs/propertydialog.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L39)

___

### dialogClose

▸ **dialogClose**(`result?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `result?` | `string` |

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[dialogClose](TemplatedDialog.md#dialogclose)

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

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[dialogOpen](TemplatedDialog.md#dialogopen)

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

[TemplatedDialog](TemplatedDialog.md).[findById](TemplatedDialog.md#findbyid)

#### Defined in

[src/ui/widgets/templatedwidget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L12)

___

### getCssClass

▸ **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[getCssClass](TemplatedDialog.md#getcssclass)

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

[TemplatedDialog](TemplatedDialog.md).[getCustomAttribute](TemplatedDialog.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

___

### getDialogButtons

▸ **getDialogButtons**(): [`DialogButton`](../interfaces/DialogButton.md)[]

#### Returns

[`DialogButton`](../interfaces/DialogButton.md)[]

#### Overrides

[TemplatedDialog](TemplatedDialog.md).[getDialogButtons](TemplatedDialog.md#getdialogbuttons)

#### Defined in

[src/ui/dialogs/propertydialog.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L59)

___

### getDialogOptions

▸ **getDialogOptions**(): [`DialogOptions`](../interfaces/DialogOptions.md)

#### Returns

[`DialogOptions`](../interfaces/DialogOptions.md)

#### Overrides

[TemplatedDialog](TemplatedDialog.md).[getDialogOptions](TemplatedDialog.md#getdialogoptions)

#### Defined in

[src/ui/dialogs/propertydialog.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L53)

___

### getFieldElement

▸ **getFieldElement**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[getFieldElement](TemplatedDialog.md#getfieldelement)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

___

### getFormKey

▸ **getFormKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/propertydialog.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L100)

___

### getGridField

▸ **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[getGridField](TemplatedDialog.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

___

### getInitialDialogTitle

▸ **getInitialDialogTitle**(): `string`

#### Returns

`string`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[getInitialDialogTitle](TemplatedDialog.md#getinitialdialogtitle)

#### Defined in

[src/ui/dialogs/templateddialog.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L50)

___

### getPropertyGridOptions

▸ **getPropertyGridOptions**(): [`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

#### Returns

[`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

#### Defined in

[src/ui/dialogs/propertydialog.ts:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L121)

___

### getPropertyItems

▸ **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Defined in

[src/ui/dialogs/propertydialog.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L131)

___

### getPropertyItemsData

▸ **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Defined in

[src/ui/dialogs/propertydialog.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L135)

___

### getPropertyItemsDataAsync

▸ **getPropertyItemsDataAsync**(): `Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Returns

`Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Defined in

[src/ui/dialogs/propertydialog.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L154)

___

### getSaveEntity

▸ **getSaveEntity**(): `TItem`

#### Returns

`TItem`

#### Defined in

[src/ui/dialogs/propertydialog.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L163)

___

### getTemplate

▸ **getTemplate**(): `string`

#### Returns

`string`

#### Overrides

[TemplatedDialog](TemplatedDialog.md).[getTemplate](TemplatedDialog.md#gettemplate)

#### Defined in

[src/ui/dialogs/propertydialog.ts:200](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L200)

___

### getToolbarButtons

▸ **getToolbarButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[getToolbarButtons](TemplatedDialog.md#gettoolbarbuttons)

#### Defined in

[src/ui/dialogs/templateddialog.ts:127](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L127)

___

### getValidatorOptions

▸ **getValidatorOptions**(): `any`

#### Returns

`any`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[getValidatorOptions](TemplatedDialog.md#getvalidatoroptions)

#### Defined in

[src/ui/dialogs/templateddialog.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L142)

___

### get\_entity

▸ **get_entity**(): `TItem`

#### Returns

`TItem`

#### Defined in

[src/ui/dialogs/propertydialog.ts:175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L175)

___

### get\_entityId

▸ **get_entityId**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/dialogs/propertydialog.ts:183](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L183)

___

### handleResponsive

▸ **handleResponsive**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[handleResponsive](TemplatedDialog.md#handleresponsive)

#### Defined in

[src/ui/dialogs/templateddialog.ts:205](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L205)

___

### init

▸ **init**(): `this`

#### Returns

`this`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[init](TemplatedDialog.md#init)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

___

### initDialog

▸ **initDialog**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[initDialog](TemplatedDialog.md#initdialog)

#### Defined in

[src/ui/dialogs/templateddialog.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L86)

___

### initPropertyGrid

▸ **initPropertyGrid**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L91)

___

### initTabs

▸ **initTabs**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[initTabs](TemplatedDialog.md#inittabs)

#### Defined in

[src/ui/dialogs/templateddialog.ts:198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L198)

___

### initToolbar

▸ **initToolbar**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[initToolbar](TemplatedDialog.md#inittoolbar)

#### Defined in

[src/ui/dialogs/templateddialog.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L131)

___

### initUIDialog

▸ **initUIDialog**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[initUIDialog](TemplatedDialog.md#inituidialog)

#### Defined in

[src/ui/dialogs/templateddialog.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L95)

___

### initValidator

▸ **initValidator**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[initValidator](TemplatedDialog.md#initvalidator)

#### Defined in

[src/ui/dialogs/templateddialog.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L146)

___

### internalInit

▸ **internalInit**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[internalInit](TemplatedDialog.md#internalinit)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

___

### internalRenderContents

▸ **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[internalRenderContents](TemplatedDialog.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L169)

___

### isClosable

▸ **isClosable**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/propertydialog.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L15)

___

### isStatic

▸ **isStatic**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/propertydialog.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L16)

___

### isStaticPanel

▸ **isStaticPanel**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[isStaticPanel](TemplatedDialog.md#isstaticpanel)

#### Defined in

[src/ui/dialogs/templateddialog.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L54)

___

### loadInitialEntity

▸ **loadInitialEntity**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L171)

___

### okClick

▸ **okClick**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L75)

___

### okClickValidated

▸ **okClickValidated**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L83)

___

### onDialogClose

▸ **onDialogClose**(`result?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `result?` | `string` |

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[onDialogClose](TemplatedDialog.md#ondialogclose)

#### Defined in

[src/ui/dialogs/templateddialog.ts:168](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L168)

___

### onDialogOpen

▸ **onDialogOpen**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[onDialogOpen](TemplatedDialog.md#ondialogopen)

#### Defined in

[src/ui/dialogs/templateddialog.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L120)

___

### propertyItemsReady

▸ **propertyItemsReady**(`itemsData`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemsData` | [`PropertyItemsData`](../interfaces/PropertyItemsData.md) |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L26)

___

### render

▸ **render**(): `any`

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[render](TemplatedDialog.md#render)

#### Defined in

[src/ui/widgets/widget.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L159)

___

### renderContents

▸ **renderContents**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[renderContents](TemplatedDialog.md#rendercontents)

#### Defined in

[src/ui/widgets/templatedwidget.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/templatedwidget.ts#L20)

___

### resetValidation

▸ **resetValidation**(): `void`

#### Returns

`void`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[resetValidation](TemplatedDialog.md#resetvalidation)

#### Defined in

[src/ui/dialogs/templateddialog.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L154)

___

### set\_entity

▸ **set_entity**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `TItem` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L179)

___

### set\_entityId

▸ **set_entityId**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L187)

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

[TemplatedDialog](TemplatedDialog.md).[syncOrAsyncThen](TemplatedDialog.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L186)

___

### updateTitle

▸ **updateTitle**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/propertydialog.ts:195](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L195)

___

### useAsync

▸ **useAsync**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/propertydialog.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L35)

___

### useIdPrefix

▸ **useIdPrefix**(): [`IdPrefixType`](../README.md#idprefixtype)

#### Returns

[`IdPrefixType`](../README.md#idprefixtype)

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[useIdPrefix](TemplatedDialog.md#useidprefix)

#### Defined in

[src/ui/widgets/widget.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L193)

___

### validateBeforeSave

▸ **validateBeforeSave**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/propertydialog.ts:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/propertydialog.ts#L191)

___

### validateForm

▸ **validateForm**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[validateForm](TemplatedDialog.md#validateform)

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

[TemplatedDialog](TemplatedDialog.md).[create](TemplatedDialog.md#create)

#### Defined in

[src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

___

### createDefaultElement

▸ **createDefaultElement**(): `HTMLDivElement`

#### Returns

`HTMLDivElement`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[createDefaultElement](TemplatedDialog.md#createdefaultelement)

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

[TemplatedDialog](TemplatedDialog.md).[getWidgetName](TemplatedDialog.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
