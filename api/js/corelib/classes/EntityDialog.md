[@serenity-is/corelib](../README.md) / EntityDialog

# Class: EntityDialog\<TItem, P\>

## Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `TItem` |
| `P` | {} |

## Hierarchy

- [`TemplatedDialog`](TemplatedDialog.md)\<`P`\>

  ↳ **`EntityDialog`**

## Implements

- [`IEditDialog`](IEditDialog.md)
- [`IReadOnly`](IReadOnly.md)

## Table of contents

### Constructors

- [constructor](EntityDialog.md#constructor)

### Properties

- [applyChangesButton](EntityDialog.md#applychangesbutton)
- [cloneButton](EntityDialog.md#clonebutton)
- [deleteButton](EntityDialog.md#deletebutton)
- [dialog](EntityDialog.md#dialog)
- [domNode](EntityDialog.md#domnode)
- [editButton](EntityDialog.md#editbutton)
- [editClicked](EntityDialog.md#editclicked)
- [entity](EntityDialog.md#entity)
- [entityId](EntityDialog.md#entityid)
- [idPrefix](EntityDialog.md#idprefix)
- [localizationButton](EntityDialog.md#localizationbutton)
- [localizationGrid](EntityDialog.md#localizationgrid)
- [localizationLastValue](EntityDialog.md#localizationlastvalue)
- [localizationPendingValue](EntityDialog.md#localizationpendingvalue)
- [options](EntityDialog.md#options)
- [propertyGrid](EntityDialog.md#propertygrid)
- [propertyItemsData](EntityDialog.md#propertyitemsdata)
- [saveAndCloseButton](EntityDialog.md#saveandclosebutton)
- [tabs](EntityDialog.md#tabs)
- [toolbar](EntityDialog.md#toolbar)
- [undeleteButton](EntityDialog.md#undeletebutton)
- [uniqueName](EntityDialog.md#uniquename)
- [validator](EntityDialog.md#validator)
- [defaultLanguageList](EntityDialog.md#defaultlanguagelist)
- [typeInfo](EntityDialog.md#typeinfo)

### Accessors

- [dialogTitle](EntityDialog.md#dialogtitle)
- [element](EntityDialog.md#element)
- [props](EntityDialog.md#props)
- [readOnly](EntityDialog.md#readonly)

### Methods

- [addCssClass](EntityDialog.md#addcssclass)
- [addValidationRule](EntityDialog.md#addvalidationrule)
- [afterInit](EntityDialog.md#afterinit)
- [afterLoadEntity](EntityDialog.md#afterloadentity)
- [arrange](EntityDialog.md#arrange)
- [beforeLoadEntity](EntityDialog.md#beforeloadentity)
- [byId](EntityDialog.md#byid)
- [change](EntityDialog.md#change)
- [changeSelect2](EntityDialog.md#changeselect2)
- [deleteHandler](EntityDialog.md#deletehandler)
- [destroy](EntityDialog.md#destroy)
- [dialogClose](EntityDialog.md#dialogclose)
- [dialogOpen](EntityDialog.md#dialogopen)
- [doDelete](EntityDialog.md#dodelete)
- [findById](EntityDialog.md#findbyid)
- [getCloningEntity](EntityDialog.md#getcloningentity)
- [getCssClass](EntityDialog.md#getcssclass)
- [getCustomAttribute](EntityDialog.md#getcustomattribute)
- [getDeleteOptions](EntityDialog.md#getdeleteoptions)
- [getDeletePermission](EntityDialog.md#getdeletepermission)
- [getDialogButtons](EntityDialog.md#getdialogbuttons)
- [getDialogOptions](EntityDialog.md#getdialogoptions)
- [getEntityNameFieldValue](EntityDialog.md#getentitynamefieldvalue)
- [getEntitySingular](EntityDialog.md#getentitysingular)
- [getEntityTitle](EntityDialog.md#getentitytitle)
- [getEntityType](EntityDialog.md#getentitytype)
- [getFieldElement](EntityDialog.md#getfieldelement)
- [getFormKey](EntityDialog.md#getformkey)
- [getGridField](EntityDialog.md#getgridfield)
- [getIdProperty](EntityDialog.md#getidproperty)
- [getInitialDialogTitle](EntityDialog.md#getinitialdialogtitle)
- [getInsertPermission](EntityDialog.md#getinsertpermission)
- [getIsActiveProperty](EntityDialog.md#getisactiveproperty)
- [getIsDeletedProperty](EntityDialog.md#getisdeletedproperty)
- [getLanguages](EntityDialog.md#getlanguages)
- [getLoadByIdOptions](EntityDialog.md#getloadbyidoptions)
- [getLoadByIdRequest](EntityDialog.md#getloadbyidrequest)
- [getLocalTextDbPrefix](EntityDialog.md#getlocaltextdbprefix)
- [getLocalTextPrefix](EntityDialog.md#getlocaltextprefix)
- [getLocalizationGridValue](EntityDialog.md#getlocalizationgridvalue)
- [getNameProperty](EntityDialog.md#getnameproperty)
- [getPendingLocalizations](EntityDialog.md#getpendinglocalizations)
- [getPropertyGridOptions](EntityDialog.md#getpropertygridoptions)
- [getPropertyItems](EntityDialog.md#getpropertyitems)
- [getPropertyItemsData](EntityDialog.md#getpropertyitemsdata)
- [getPropertyItemsDataAsync](EntityDialog.md#getpropertyitemsdataasync)
- [getRowDefinition](EntityDialog.md#getrowdefinition)
- [getSaveEntity](EntityDialog.md#getsaveentity)
- [getSaveOptions](EntityDialog.md#getsaveoptions)
- [getSaveRequest](EntityDialog.md#getsaverequest)
- [getService](EntityDialog.md#getservice)
- [getTemplate](EntityDialog.md#gettemplate)
- [getToolbarButtons](EntityDialog.md#gettoolbarbuttons)
- [getUndeleteOptions](EntityDialog.md#getundeleteoptions)
- [getUpdatePermission](EntityDialog.md#getupdatepermission)
- [getValidatorOptions](EntityDialog.md#getvalidatoroptions)
- [get\_entity](EntityDialog.md#get_entity)
- [get\_entityId](EntityDialog.md#get_entityid)
- [get\_readOnly](EntityDialog.md#get_readonly)
- [handleResponsive](EntityDialog.md#handleresponsive)
- [hasDeletePermission](EntityDialog.md#hasdeletepermission)
- [hasInsertPermission](EntityDialog.md#hasinsertpermission)
- [hasSavePermission](EntityDialog.md#hassavepermission)
- [hasUpdatePermission](EntityDialog.md#hasupdatepermission)
- [init](EntityDialog.md#init)
- [initDialog](EntityDialog.md#initdialog)
- [initLocalizationGrid](EntityDialog.md#initlocalizationgrid)
- [initLocalizationGridCommon](EntityDialog.md#initlocalizationgridcommon)
- [initPropertyGrid](EntityDialog.md#initpropertygrid)
- [initTabs](EntityDialog.md#inittabs)
- [initToolbar](EntityDialog.md#inittoolbar)
- [initUIDialog](EntityDialog.md#inituidialog)
- [initValidator](EntityDialog.md#initvalidator)
- [internalInit](EntityDialog.md#internalinit)
- [internalRenderContents](EntityDialog.md#internalrendercontents)
- [isCloneMode](EntityDialog.md#isclonemode)
- [isDeleted](EntityDialog.md#isdeleted)
- [isEditMode](EntityDialog.md#iseditmode)
- [isLocalizationMode](EntityDialog.md#islocalizationmode)
- [isLocalizationModeAndChanged](EntityDialog.md#islocalizationmodeandchanged)
- [isNew](EntityDialog.md#isnew)
- [isNewOrDeleted](EntityDialog.md#isnewordeleted)
- [isStaticPanel](EntityDialog.md#isstaticpanel)
- [isViewMode](EntityDialog.md#isviewmode)
- [load](EntityDialog.md#load)
- [loadById](EntityDialog.md#loadbyid)
- [loadByIdAndOpenDialog](EntityDialog.md#loadbyidandopendialog)
- [loadByIdHandler](EntityDialog.md#loadbyidhandler)
- [loadEntity](EntityDialog.md#loadentity)
- [loadEntityAndOpenDialog](EntityDialog.md#loadentityandopendialog)
- [loadLocalization](EntityDialog.md#loadlocalization)
- [loadNewAndOpenDialog](EntityDialog.md#loadnewandopendialog)
- [loadResponse](EntityDialog.md#loadresponse)
- [localizationButtonClick](EntityDialog.md#localizationbuttonclick)
- [onDeleteSuccess](EntityDialog.md#ondeletesuccess)
- [onDialogClose](EntityDialog.md#ondialogclose)
- [onDialogOpen](EntityDialog.md#ondialogopen)
- [onLoadingData](EntityDialog.md#onloadingdata)
- [onSaveSuccess](EntityDialog.md#onsavesuccess)
- [propertyItemsReady](EntityDialog.md#propertyitemsready)
- [reloadById](EntityDialog.md#reloadbyid)
- [render](EntityDialog.md#render)
- [renderContents](EntityDialog.md#rendercontents)
- [resetValidation](EntityDialog.md#resetvalidation)
- [save](EntityDialog.md#save)
- [saveHandler](EntityDialog.md#savehandler)
- [save\_submitHandler](EntityDialog.md#save_submithandler)
- [setLocalizationGridCurrentValues](EntityDialog.md#setlocalizationgridcurrentvalues)
- [set\_entity](EntityDialog.md#set_entity)
- [set\_entityId](EntityDialog.md#set_entityid)
- [set\_readOnly](EntityDialog.md#set_readonly)
- [showSaveSuccessMessage](EntityDialog.md#showsavesuccessmessage)
- [syncOrAsyncThen](EntityDialog.md#syncorasyncthen)
- [undelete](EntityDialog.md#undelete)
- [undeleteHandler](EntityDialog.md#undeletehandler)
- [updateInterface](EntityDialog.md#updateinterface)
- [updateTitle](EntityDialog.md#updatetitle)
- [useAsync](EntityDialog.md#useasync)
- [useIdPrefix](EntityDialog.md#useidprefix)
- [useViewMode](EntityDialog.md#useviewmode)
- [validateBeforeSave](EntityDialog.md#validatebeforesave)
- [validateForm](EntityDialog.md#validateform)
- [create](EntityDialog.md#create)
- [createDefaultElement](EntityDialog.md#createdefaultelement)
- [getWidgetName](EntityDialog.md#getwidgetname)

## Constructors

### constructor

• **new EntityDialog**\<`TItem`, `P`\>(`props?`): [`EntityDialog`](EntityDialog.md)\<`TItem`, `P`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TItem` | `TItem` |
| `P` | {} |

#### Parameters

| Name | Type |
| :------ | :------ |
| `props?` | [`WidgetProps`](../README.md#widgetprops)\<`P`\> |

#### Returns

[`EntityDialog`](EntityDialog.md)\<`TItem`, `P`\>

#### Overrides

[TemplatedDialog](TemplatedDialog.md).[constructor](TemplatedDialog.md#constructor)

#### Defined in

[src/ui/dialogs/entitydialog.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L40)

## Properties

### applyChangesButton

• `Protected` **applyChangesButton**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/dialogs/entitydialog.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L27)

___

### cloneButton

• `Protected` **cloneButton**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/dialogs/entitydialog.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L30)

___

### deleteButton

• `Protected` **deleteButton**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/dialogs/entitydialog.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L28)

___

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

### editButton

• `Protected` **editButton**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/dialogs/entitydialog.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L31)

___

### editClicked

• `Protected` **editClicked**: `boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L1148)

___

### entity

• `Protected` **entity**: `TItem`

#### Defined in

[src/ui/dialogs/entitydialog.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L20)

___

### entityId

• `Protected` **entityId**: `any`

#### Defined in

[src/ui/dialogs/entitydialog.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L21)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[idPrefix](TemplatedDialog.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

___

### localizationButton

• `Protected` **localizationButton**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/dialogs/entitydialog.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L34)

___

### localizationGrid

• `Protected` **localizationGrid**: [`PropertyGrid`](PropertyGrid.md)\<[`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)\>

#### Defined in

[src/ui/dialogs/entitydialog.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L33)

___

### localizationLastValue

• `Protected` **localizationLastValue**: `any`

#### Defined in

[src/ui/dialogs/entitydialog.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L36)

___

### localizationPendingValue

• `Protected` **localizationPendingValue**: `any`

#### Defined in

[src/ui/dialogs/entitydialog.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L35)

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

[src/ui/dialogs/entitydialog.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L23)

___

### propertyItemsData

• `Protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Defined in

[src/ui/dialogs/entitydialog.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L22)

___

### saveAndCloseButton

• `Protected` **saveAndCloseButton**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/dialogs/entitydialog.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L26)

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

#### Overrides

[TemplatedDialog](TemplatedDialog.md).[toolbar](TemplatedDialog.md#toolbar)

#### Defined in

[src/ui/dialogs/entitydialog.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L25)

___

### undeleteButton

• `Protected` **undeleteButton**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/dialogs/entitydialog.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L29)

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

### defaultLanguageList

▪ `Static` **defaultLanguageList**: () => `string`[][]

#### Type declaration

▸ (): `string`[][]

##### Returns

`string`[][]

#### Defined in

[src/ui/dialogs/entitydialog.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L38)

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

___

### readOnly

• `get` **readOnly**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1097](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L1097)

• `set` **readOnly**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L1101)

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

[src/ui/dialogs/entitydialog.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L55)

___

### afterLoadEntity

▸ **afterLoadEntity**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:428](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L428)

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

### beforeLoadEntity

▸ **beforeLoadEntity**(`entity`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `TItem` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:423](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L423)

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

### deleteHandler

▸ **deleteHandler**(`options`, `callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`DeleteResponse`](../interfaces/DeleteResponse.md)\> |
| `callback` | (`response`: [`DeleteResponse`](../interfaces/DeleteResponse.md)) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L160)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[TemplatedDialog](TemplatedDialog.md).[destroy](TemplatedDialog.md#destroy)

#### Defined in

[src/ui/dialogs/entitydialog.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L62)

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

### doDelete

▸ **doDelete**(`callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback` | (`response`: [`DeleteResponse`](../interfaces/DeleteResponse.md)) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:164](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L164)

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

### getCloningEntity

▸ **getCloningEntity**(): `TItem`

#### Returns

`TItem`

#### Defined in

[src/ui/dialogs/entitydialog.ts:995](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L995)

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

### getDeleteOptions

▸ **getDeleteOptions**(`callback`): [`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`DeleteResponse`](../interfaces/DeleteResponse.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback` | (`response`: [`DeleteResponse`](../interfaces/DeleteResponse.md)) => `void` |

#### Returns

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`DeleteResponse`](../interfaces/DeleteResponse.md)\>

#### Defined in

[src/ui/dialogs/entitydialog.ts:156](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L156)

___

### getDeletePermission

▸ **getDeletePermission**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1125](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L1125)

___

### getDialogButtons

▸ **getDialogButtons**(): [`DialogButton`](../interfaces/DialogButton.md)[]

#### Returns

[`DialogButton`](../interfaces/DialogButton.md)[]

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[getDialogButtons](TemplatedDialog.md#getdialogbuttons)

#### Defined in

[src/ui/dialogs/templateddialog.ts:181](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L181)

___

### getDialogOptions

▸ **getDialogOptions**(): [`DialogOptions`](../interfaces/DialogOptions.md)

#### Returns

[`DialogOptions`](../interfaces/DialogOptions.md)

#### Inherited from

[TemplatedDialog](TemplatedDialog.md).[getDialogOptions](TemplatedDialog.md#getdialogoptions)

#### Defined in

[src/ui/dialogs/templateddialog.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#L58)

___

### getEntityNameFieldValue

▸ **getEntityNameFieldValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/dialogs/entitydialog.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L101)

___

### getEntitySingular

▸ **getEntitySingular**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:267](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L267)

___

### getEntityTitle

▸ **getEntityTitle**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L105)

___

### getEntityType

▸ **getEntityType**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L202)

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

[src/ui/dialogs/entitydialog.ts:228](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L228)

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

### getIdProperty

▸ **getIdProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:296](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L296)

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

### getInsertPermission

▸ **getInsertPermission**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L1117)

___

### getIsActiveProperty

▸ **getIsActiveProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:313](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L313)

___

### getIsDeletedProperty

▸ **getIsDeletedProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:328](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L328)

___

### getLanguages

▸ **getLanguages**(): `any`[]

#### Returns

`any`[]

#### Defined in

[src/ui/dialogs/entitydialog.ts:576](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L576)

___

### getLoadByIdOptions

▸ **getLoadByIdOptions**(`id`, `callback`): [`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `any` |
| `callback` | (`response`: [`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>) => `void` |

#### Returns

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>\>

#### Defined in

[src/ui/dialogs/entitydialog.ts:446](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L446)

___

### getLoadByIdRequest

▸ **getLoadByIdRequest**(`id`): [`RetrieveRequest`](../interfaces/RetrieveRequest.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `any` |

#### Returns

[`RetrieveRequest`](../interfaces/RetrieveRequest.md)

#### Defined in

[src/ui/dialogs/entitydialog.ts:450](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L450)

___

### getLocalTextDbPrefix

▸ **getLocalTextDbPrefix**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:241](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L241)

___

### getLocalTextPrefix

▸ **getLocalTextPrefix**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L253)

___

### getLocalizationGridValue

▸ **getLocalizationGridValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/dialogs/entitydialog.ts:662](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L662)

___

### getNameProperty

▸ **getNameProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:278](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L278)

___

### getPendingLocalizations

▸ **getPendingLocalizations**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/dialogs/entitydialog.ts:675](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L675)

___

### getPropertyGridOptions

▸ **getPropertyGridOptions**(): [`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

#### Returns

[`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

#### Defined in

[src/ui/dialogs/entitydialog.ts:746](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L746)

___

### getPropertyItems

▸ **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Defined in

[src/ui/dialogs/entitydialog.ts:714](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L714)

___

### getPropertyItemsData

▸ **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Defined in

[src/ui/dialogs/entitydialog.ts:718](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L718)

___

### getPropertyItemsDataAsync

▸ **getPropertyItemsDataAsync**(): `Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Returns

`Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Defined in

[src/ui/dialogs/entitydialog.ts:737](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L737)

___

### getRowDefinition

▸ **getRowDefinition**(): [`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Returns

[`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Defined in

[src/ui/dialogs/entitydialog.ts:196](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L196)

___

### getSaveEntity

▸ **getSaveEntity**(): `TItem`

#### Returns

`TItem`

#### Defined in

[src/ui/dialogs/entitydialog.ts:795](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L795)

___

### getSaveOptions

▸ **getSaveOptions**(`callback`): [`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`SaveResponse`](../interfaces/SaveResponse.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback` | (`response`: [`SaveResponse`](../interfaces/SaveResponse.md)) => `void` |

#### Returns

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`SaveResponse`](../interfaces/SaveResponse.md)\>

#### Defined in

[src/ui/dialogs/entitydialog.ts:760](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L760)

___

### getSaveRequest

▸ **getSaveRequest**(): [`SaveRequest`](../interfaces/SaveRequest.md)\<`TItem`\>

#### Returns

[`SaveRequest`](../interfaces/SaveRequest.md)\<`TItem`\>

#### Defined in

[src/ui/dialogs/entitydialog.ts:813](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L813)

___

### getService

▸ **getService**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:334](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L334)

___

### getTemplate

▸ **getTemplate**(): `string`

#### Returns

`string`

#### Overrides

[TemplatedDialog](TemplatedDialog.md).[getTemplate](TemplatedDialog.md#gettemplate)

#### Defined in

[src/ui/dialogs/entitydialog.ts:1158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L1158)

___

### getToolbarButtons

▸ **getToolbarButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Overrides

[TemplatedDialog](TemplatedDialog.md).[getToolbarButtons](TemplatedDialog.md#gettoolbarbuttons)

#### Defined in

[src/ui/dialogs/entitydialog.ts:872](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L872)

___

### getUndeleteOptions

▸ **getUndeleteOptions**(`callback?`): [`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`UndeleteResponse`](../interfaces/UndeleteResponse.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback?` | (`response`: [`UndeleteResponse`](../interfaces/UndeleteResponse.md)) => `void` |

#### Returns

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`UndeleteResponse`](../interfaces/UndeleteResponse.md)\>

#### Defined in

[src/ui/dialogs/entitydialog.ts:1065](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L1065)

___

### getUpdatePermission

▸ **getUpdatePermission**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L1121)

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

[src/ui/dialogs/entitydialog.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L85)

___

### get\_entityId

▸ **get_entityId**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/dialogs/entitydialog.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L93)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IReadOnly](IReadOnly.md).[get_readOnly](IReadOnly.md#get_readonly)

#### Defined in

[src/ui/dialogs/entitydialog.ts:1105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L1105)

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

### hasDeletePermission

▸ **hasDeletePermission**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1129](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L1129)

___

### hasInsertPermission

▸ **hasInsertPermission**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L1134)

___

### hasSavePermission

▸ **hasSavePermission**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L1144)

___

### hasUpdatePermission

▸ **hasUpdatePermission**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L1139)

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

### initLocalizationGrid

▸ **initLocalizationGrid**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:486](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L486)

___

### initLocalizationGridCommon

▸ **initLocalizationGridCommon**(`pgOptions`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `pgOptions` | [`PropertyGridOptions`](../interfaces/PropertyGridOptions.md) |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:495](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L495)

___

### initPropertyGrid

▸ **initPropertyGrid**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:705](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L705)

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

#### Overrides

[TemplatedDialog](TemplatedDialog.md).[initToolbar](TemplatedDialog.md#inittoolbar)

#### Defined in

[src/ui/dialogs/entitydialog.ts:852](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L852)

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

### isCloneMode

▸ **isCloneMode**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L122)

___

### isDeleted

▸ **isDeleted**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L130)

___

### isEditMode

▸ **isEditMode**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L126)

___

### isLocalizationMode

▸ **isLocalizationMode**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:545](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L545)

___

### isLocalizationModeAndChanged

▸ **isLocalizationModeAndChanged**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:549](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L549)

___

### isNew

▸ **isNew**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L148)

___

### isNewOrDeleted

▸ **isNewOrDeleted**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L152)

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

### isViewMode

▸ **isViewMode**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L1150)

___

### load

▸ **load**(`entityOrId`, `done`, `fail?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entityOrId` | `any` |
| `done` | () => `void` |
| `fail?` | (`ex`: [`Exception`](Exception.md)) => `void` |

#### Returns

`void`

#### Implementation of

[IEditDialog](IEditDialog.md).[load](IEditDialog.md#load)

#### Defined in

[src/ui/dialogs/entitydialog.ts:347](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L347)

___

### loadById

▸ **loadById**(`id`, `callback?`, `fail?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `any` |
| `callback?` | (`response`: [`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>) => `void` |
| `fail?` | () => `void` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:460](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L460)

___

### loadByIdAndOpenDialog

▸ **loadByIdAndOpenDialog**(`entityId`, `asPanel?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entityId` | `any` |
| `asPanel?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:433](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L433)

___

### loadByIdHandler

▸ **loadByIdHandler**(`options`, `callback`, `fail`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>\> |
| `callback` | (`response`: [`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>) => `void` |
| `fail` | () => `void` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:481](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L481)

___

### loadEntity

▸ **loadEntity**(`entity`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `TItem` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:408](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L408)

___

### loadEntityAndOpenDialog

▸ **loadEntityAndOpenDialog**(`entity`, `asPanel?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `TItem` |
| `asPanel?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:393](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L393)

___

### loadLocalization

▸ **loadLocalization**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:598](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L598)

___

### loadNewAndOpenDialog

▸ **loadNewAndOpenDialog**(`asPanel?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `asPanel?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:388](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L388)

___

### loadResponse

▸ **loadResponse**(`data`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `data` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:398](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L398)

___

### localizationButtonClick

▸ **localizationButtonClick**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:558](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L558)

___

### onDeleteSuccess

▸ **onDeleteSuccess**(`response`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `response` | [`DeleteResponse`](../interfaces/DeleteResponse.md) |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L193)

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

### onLoadingData

▸ **onLoadingData**(`data`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `data` | [`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\> |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:443](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L443)

___

### onSaveSuccess

▸ **onSaveSuccess**(`response`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `response` | [`SaveResponse`](../interfaces/SaveResponse.md) |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:833](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L833)

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

[src/ui/dialogs/entitydialog.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L49)

___

### reloadById

▸ **reloadById**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:456](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L456)

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

### save

▸ **save**(`callback?`): `boolean` \| `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback?` | (`response`: [`SaveResponse`](../interfaces/SaveResponse.md)) => `void` |

#### Returns

`boolean` \| `void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:841](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L841)

___

### saveHandler

▸ **saveHandler**(`options`, `callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`SaveResponse`](../interfaces/SaveResponse.md)\> |
| `callback` | (`response`: [`SaveResponse`](../interfaces/SaveResponse.md)) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:847](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L847)

___

### save\_submitHandler

▸ **save_submitHandler**(`callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback` | (`response`: [`SaveResponse`](../interfaces/SaveResponse.md)) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:836](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L836)

___

### setLocalizationGridCurrentValues

▸ **setLocalizationGridCurrentValues**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:641](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L641)

___

### set\_entity

▸ **set_entity**(`entity`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L89)

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

[src/ui/dialogs/entitydialog.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L97)

___

### set\_readOnly

▸ **set_readOnly**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Implementation of

[IReadOnly](IReadOnly.md).[set_readOnly](IReadOnly.md#set_readonly)

#### Defined in

[src/ui/dialogs/entitydialog.ts:1109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L1109)

___

### showSaveSuccessMessage

▸ **showSaveSuccessMessage**(`response`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `response` | [`SaveResponse`](../interfaces/SaveResponse.md) |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:868](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L868)

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

### undelete

▸ **undelete**(`callback?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback?` | (`response`: [`UndeleteResponse`](../interfaces/UndeleteResponse.md)) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1073](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L1073)

___

### undeleteHandler

▸ **undeleteHandler**(`options`, `callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`UndeleteResponse`](../interfaces/UndeleteResponse.md)\> |
| `callback` | (`response`: [`UndeleteResponse`](../interfaces/UndeleteResponse.md)) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1069](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L1069)

___

### updateInterface

▸ **updateInterface**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1018](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L1018)

___

### updateTitle

▸ **updateTitle**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L118)

___

### useAsync

▸ **useAsync**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L58)

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

### useViewMode

▸ **useViewMode**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L1154)

___

### validateBeforeSave

▸ **validateBeforeSave**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:756](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#L756)

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
