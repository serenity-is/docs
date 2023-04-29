[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / EntityDialog

# Class: EntityDialog<TItem, TOptions\>

[corelib](../modules/corelib.md).EntityDialog

## Type parameters

| Name |
| :------ |
| `TItem` |
| `TOptions` |

## Hierarchy

- [`TemplatedDialog`](corelib.TemplatedDialog.md)<`TOptions`\>

  ↳ **`EntityDialog`**

## Implements

- [`IEditDialog`](corelib.IEditDialog.md)
- [`IReadOnly`](corelib.IReadOnly.md)

## Table of contents

### Constructors

- [constructor](corelib.EntityDialog.md#constructor)

### Properties

- [\_entitySingular](corelib.EntityDialog.md#_entitysingular)
- [\_entityType](corelib.EntityDialog.md#_entitytype)
- [\_formKey](corelib.EntityDialog.md#_formkey)
- [\_idProperty](corelib.EntityDialog.md#_idproperty)
- [\_isActiveProperty](corelib.EntityDialog.md#_isactiveproperty)
- [\_localTextDbPrefix](corelib.EntityDialog.md#_localtextdbprefix)
- [\_nameProperty](corelib.EntityDialog.md#_nameproperty)
- [\_readonly](corelib.EntityDialog.md#_readonly)
- [\_service](corelib.EntityDialog.md#_service)
- [applyChangesButton](corelib.EntityDialog.md#applychangesbutton)
- [cloneButton](corelib.EntityDialog.md#clonebutton)
- [deleteButton](corelib.EntityDialog.md#deletebutton)
- [editButton](corelib.EntityDialog.md#editbutton)
- [editClicked](corelib.EntityDialog.md#editclicked)
- [element](corelib.EntityDialog.md#element)
- [entity](corelib.EntityDialog.md#entity)
- [entityId](corelib.EntityDialog.md#entityid)
- [idPrefix](corelib.EntityDialog.md#idprefix)
- [localizationButton](corelib.EntityDialog.md#localizationbutton)
- [localizationGrid](corelib.EntityDialog.md#localizationgrid)
- [localizationLastValue](corelib.EntityDialog.md#localizationlastvalue)
- [localizationPendingValue](corelib.EntityDialog.md#localizationpendingvalue)
- [options](corelib.EntityDialog.md#options)
- [propertyGrid](corelib.EntityDialog.md#propertygrid)
- [propertyItemsData](corelib.EntityDialog.md#propertyitemsdata)
- [saveAndCloseButton](corelib.EntityDialog.md#saveandclosebutton)
- [tabs](corelib.EntityDialog.md#tabs)
- [toolbar](corelib.EntityDialog.md#toolbar)
- [undeleteButton](corelib.EntityDialog.md#undeletebutton)
- [uniqueName](corelib.EntityDialog.md#uniquename)
- [validator](corelib.EntityDialog.md#validator)
- [widgetName](corelib.EntityDialog.md#widgetname)
- [bootstrapModal](corelib.EntityDialog.md#bootstrapmodal)
- [defaultLanguageList](corelib.EntityDialog.md#defaultlanguagelist)

### Accessors

- [dialogTitle](corelib.EntityDialog.md#dialogtitle)
- [isMarkedAsPanel](corelib.EntityDialog.md#ismarkedaspanel)
- [isResponsive](corelib.EntityDialog.md#isresponsive)
- [readOnly](corelib.EntityDialog.md#readonly)

### Methods

- [addCssClass](corelib.EntityDialog.md#addcssclass)
- [addValidationRule](corelib.EntityDialog.md#addvalidationrule)
- [afterInit](corelib.EntityDialog.md#afterinit)
- [afterLoadEntity](corelib.EntityDialog.md#afterloadentity)
- [arrange](corelib.EntityDialog.md#arrange)
- [attrs](corelib.EntityDialog.md#attrs)
- [beforeLoadEntity](corelib.EntityDialog.md#beforeloadentity)
- [byId](corelib.EntityDialog.md#byid)
- [change](corelib.EntityDialog.md#change)
- [changeSelect2](corelib.EntityDialog.md#changeselect2)
- [deleteHandler](corelib.EntityDialog.md#deletehandler)
- [destroy](corelib.EntityDialog.md#destroy)
- [dialogClose](corelib.EntityDialog.md#dialogclose)
- [dialogOpen](corelib.EntityDialog.md#dialogopen)
- [doDelete](corelib.EntityDialog.md#dodelete)
- [getCloningEntity](corelib.EntityDialog.md#getcloningentity)
- [getCssClass](corelib.EntityDialog.md#getcssclass)
- [getDeleteOptions](corelib.EntityDialog.md#getdeleteoptions)
- [getDeletePermission](corelib.EntityDialog.md#getdeletepermission)
- [getDialogButtons](corelib.EntityDialog.md#getdialogbuttons)
- [getDialogOptions](corelib.EntityDialog.md#getdialogoptions)
- [getDialogTitle](corelib.EntityDialog.md#getdialogtitle)
- [getEntityNameFieldValue](corelib.EntityDialog.md#getentitynamefieldvalue)
- [getEntitySingular](corelib.EntityDialog.md#getentitysingular)
- [getEntityTitle](corelib.EntityDialog.md#getentitytitle)
- [getEntityType](corelib.EntityDialog.md#getentitytype)
- [getFallbackTemplate](corelib.EntityDialog.md#getfallbacktemplate)
- [getFormKey](corelib.EntityDialog.md#getformkey)
- [getGridField](corelib.EntityDialog.md#getgridfield)
- [getIdProperty](corelib.EntityDialog.md#getidproperty)
- [getInsertPermission](corelib.EntityDialog.md#getinsertpermission)
- [getIsActiveProperty](corelib.EntityDialog.md#getisactiveproperty)
- [getIsDeletedProperty](corelib.EntityDialog.md#getisdeletedproperty)
- [getLangs](corelib.EntityDialog.md#getlangs)
- [getLanguages](corelib.EntityDialog.md#getlanguages)
- [getLoadByIdOptions](corelib.EntityDialog.md#getloadbyidoptions)
- [getLoadByIdRequest](corelib.EntityDialog.md#getloadbyidrequest)
- [getLocalTextDbPrefix](corelib.EntityDialog.md#getlocaltextdbprefix)
- [getLocalTextPrefix](corelib.EntityDialog.md#getlocaltextprefix)
- [getLocalizationGridValue](corelib.EntityDialog.md#getlocalizationgridvalue)
- [getModalOptions](corelib.EntityDialog.md#getmodaloptions)
- [getNameProperty](corelib.EntityDialog.md#getnameproperty)
- [getPendingLocalizations](corelib.EntityDialog.md#getpendinglocalizations)
- [getPropertyGridOptions](corelib.EntityDialog.md#getpropertygridoptions)
- [getPropertyItems](corelib.EntityDialog.md#getpropertyitems)
- [getPropertyItemsData](corelib.EntityDialog.md#getpropertyitemsdata)
- [getPropertyItemsDataAsync](corelib.EntityDialog.md#getpropertyitemsdataasync)
- [getRowDefinition](corelib.EntityDialog.md#getrowdefinition)
- [getSaveEntity](corelib.EntityDialog.md#getsaveentity)
- [getSaveOptions](corelib.EntityDialog.md#getsaveoptions)
- [getSaveRequest](corelib.EntityDialog.md#getsaverequest)
- [getService](corelib.EntityDialog.md#getservice)
- [getTemplate](corelib.EntityDialog.md#gettemplate)
- [getTemplateName](corelib.EntityDialog.md#gettemplatename)
- [getToolbarButtons](corelib.EntityDialog.md#gettoolbarbuttons)
- [getUndeleteOptions](corelib.EntityDialog.md#getundeleteoptions)
- [getUpdatePermission](corelib.EntityDialog.md#getupdatepermission)
- [getValidatorOptions](corelib.EntityDialog.md#getvalidatoroptions)
- [get\_entity](corelib.EntityDialog.md#get_entity)
- [get\_entityId](corelib.EntityDialog.md#get_entityid)
- [get\_readOnly](corelib.EntityDialog.md#get_readonly)
- [handleResponsive](corelib.EntityDialog.md#handleresponsive)
- [hasDeletePermission](corelib.EntityDialog.md#hasdeletepermission)
- [hasInsertPermission](corelib.EntityDialog.md#hasinsertpermission)
- [hasSavePermission](corelib.EntityDialog.md#hassavepermission)
- [hasUpdatePermission](corelib.EntityDialog.md#hasupdatepermission)
- [init](corelib.EntityDialog.md#init)
- [initAsync](corelib.EntityDialog.md#initasync)
- [initDialog](corelib.EntityDialog.md#initdialog)
- [initLocalizationGrid](corelib.EntityDialog.md#initlocalizationgrid)
- [initLocalizationGridCommon](corelib.EntityDialog.md#initlocalizationgridcommon)
- [initModal](corelib.EntityDialog.md#initmodal)
- [initPropertyGrid](corelib.EntityDialog.md#initpropertygrid)
- [initSync](corelib.EntityDialog.md#initsync)
- [initTabs](corelib.EntityDialog.md#inittabs)
- [initToolbar](corelib.EntityDialog.md#inittoolbar)
- [initValidator](corelib.EntityDialog.md#initvalidator)
- [initialize](corelib.EntityDialog.md#initialize)
- [internalInit](corelib.EntityDialog.md#internalinit)
- [isCloneMode](corelib.EntityDialog.md#isclonemode)
- [isDeleted](corelib.EntityDialog.md#isdeleted)
- [isEditMode](corelib.EntityDialog.md#iseditmode)
- [isLocalizationMode](corelib.EntityDialog.md#islocalizationmode)
- [isLocalizationModeAndChanged](corelib.EntityDialog.md#islocalizationmodeandchanged)
- [isNew](corelib.EntityDialog.md#isnew)
- [isNewOrDeleted](corelib.EntityDialog.md#isnewordeleted)
- [isViewMode](corelib.EntityDialog.md#isviewmode)
- [load](corelib.EntityDialog.md#load)
- [loadById](corelib.EntityDialog.md#loadbyid)
- [loadByIdAndOpenDialog](corelib.EntityDialog.md#loadbyidandopendialog)
- [loadByIdHandler](corelib.EntityDialog.md#loadbyidhandler)
- [loadEntity](corelib.EntityDialog.md#loadentity)
- [loadEntityAndOpenDialog](corelib.EntityDialog.md#loadentityandopendialog)
- [loadLocalization](corelib.EntityDialog.md#loadlocalization)
- [loadNewAndOpenDialog](corelib.EntityDialog.md#loadnewandopendialog)
- [loadResponse](corelib.EntityDialog.md#loadresponse)
- [localizationButtonClick](corelib.EntityDialog.md#localizationbuttonclick)
- [onDeleteSuccess](corelib.EntityDialog.md#ondeletesuccess)
- [onDialogClose](corelib.EntityDialog.md#ondialogclose)
- [onDialogOpen](corelib.EntityDialog.md#ondialogopen)
- [onLoadingData](corelib.EntityDialog.md#onloadingdata)
- [onSaveSuccess](corelib.EntityDialog.md#onsavesuccess)
- [reloadById](corelib.EntityDialog.md#reloadbyid)
- [renderContents](corelib.EntityDialog.md#rendercontents)
- [resetValidation](corelib.EntityDialog.md#resetvalidation)
- [save](corelib.EntityDialog.md#save)
- [saveHandler](corelib.EntityDialog.md#savehandler)
- [save\_submitHandler](corelib.EntityDialog.md#save_submithandler)
- [setLocalizationGridCurrentValues](corelib.EntityDialog.md#setlocalizationgridcurrentvalues)
- [set\_dialogTitle](corelib.EntityDialog.md#set_dialogtitle)
- [set\_entity](corelib.EntityDialog.md#set_entity)
- [set\_entityId](corelib.EntityDialog.md#set_entityid)
- [set\_readOnly](corelib.EntityDialog.md#set_readonly)
- [showSaveSuccessMessage](corelib.EntityDialog.md#showsavesuccessmessage)
- [undelete](corelib.EntityDialog.md#undelete)
- [undeleteHandler](corelib.EntityDialog.md#undeletehandler)
- [updateInterface](corelib.EntityDialog.md#updateinterface)
- [updateTitle](corelib.EntityDialog.md#updatetitle)
- [useAsync](corelib.EntityDialog.md#useasync)
- [useIdPrefix](corelib.EntityDialog.md#useidprefix)
- [useViewMode](corelib.EntityDialog.md#useviewmode)
- [validateBeforeSave](corelib.EntityDialog.md#validatebeforesave)
- [validateForm](corelib.EntityDialog.md#validateform)
- [closePanel](corelib.EntityDialog.md#closepanel)
- [create](corelib.EntityDialog.md#create)
- [elementFor](corelib.EntityDialog.md#elementfor)
- [getWidgetName](corelib.EntityDialog.md#getwidgetname)
- [openPanel](corelib.EntityDialog.md#openpanel)

## Constructors

### constructor

• **new EntityDialog**<`TItem`, `TOptions`\>(`opt?`)

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

[src/ui/dialogs/entitydialog.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;37)

## Properties

### \_entitySingular

• `Private` **\_entitySingular**: `string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:280](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;280)

___

### \_entityType

• `Private` **\_entityType**: `string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:212](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;212)

___

### \_formKey

• `Private` **\_formKey**: `string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:239](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;239)

___

### \_idProperty

• `Private` **\_idProperty**: `string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:320](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;320)

___

### \_isActiveProperty

• `Private` **\_isActiveProperty**: `string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:337](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;337)

___

### \_localTextDbPrefix

• `Private` **\_localTextDbPrefix**: `string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;253)

___

### \_nameProperty

• `Private` **\_nameProperty**: `string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:302](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;302)

___

### \_readonly

• `Private` **\_readonly**: `boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;1131)

___

### \_service

• `Private` **\_service**: `string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:358](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;358)

___

### applyChangesButton

• `Protected` **applyChangesButton**: `JQuery`

#### Defined in

[src/ui/dialogs/entitydialog.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;24)

___

### cloneButton

• `Protected` **cloneButton**: `JQuery`

#### Defined in

[src/ui/dialogs/entitydialog.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;27)

___

### deleteButton

• `Protected` **deleteButton**: `JQuery`

#### Defined in

[src/ui/dialogs/entitydialog.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;25)

___

### editButton

• `Protected` **editButton**: `JQuery`

#### Defined in

[src/ui/dialogs/entitydialog.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;28)

___

### editClicked

• `Protected` **editClicked**: `boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;1184)

___

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

[src/ui/dialogs/entitydialog.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;17)

___

### entityId

• `Protected` **entityId**: `any`

#### Defined in

[src/ui/dialogs/entitydialog.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;18)

___

### idPrefix

• `Readonly` **idPrefix**: `string`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[idPrefix](corelib.TemplatedDialog.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#line&#x3D;65)

___

### localizationButton

• `Protected` **localizationButton**: `JQuery`

#### Defined in

[src/ui/dialogs/entitydialog.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;31)

___

### localizationGrid

• `Protected` **localizationGrid**: [`PropertyGrid`](corelib.PropertyGrid.md)

#### Defined in

[src/ui/dialogs/entitydialog.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;30)

___

### localizationLastValue

• `Protected` **localizationLastValue**: `any`

#### Defined in

[src/ui/dialogs/entitydialog.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;33)

___

### localizationPendingValue

• `Protected` **localizationPendingValue**: `any`

#### Defined in

[src/ui/dialogs/entitydialog.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;32)

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

[src/ui/dialogs/entitydialog.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;20)

___

### propertyItemsData

• `Protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)

#### Defined in

[src/ui/dialogs/entitydialog.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;19)

___

### saveAndCloseButton

• `Protected` **saveAndCloseButton**: `JQuery`

#### Defined in

[src/ui/dialogs/entitydialog.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;23)

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

#### Overrides

[TemplatedDialog](corelib.TemplatedDialog.md).[toolbar](corelib.TemplatedDialog.md#toolbar)

#### Defined in

[src/ui/dialogs/entitydialog.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;22)

___

### undeleteButton

• `Protected` **undeleteButton**: `JQuery`

#### Defined in

[src/ui/dialogs/entitydialog.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;26)

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

___

### defaultLanguageList

▪ `Static` **defaultLanguageList**: () => `string`[][]

#### Type declaration

▸ (): `string`[][]

##### Returns

`string`[][]

#### Defined in

[src/ui/dialogs/entitydialog.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;35)

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

___

### readOnly

• `get` **readOnly**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;1133)

• `set` **readOnly**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;1137)

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

[src/ui/dialogs/entitydialog.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;63)

___

### afterLoadEntity

▸ `Protected` **afterLoadEntity**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:454](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;454)

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

### attrs

▸ `Protected` **attrs**<`TAttr`\>(`attrType`): `TAttr`[]

#### Type parameters

| Name |
| :------ |
| `TAttr` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `attrType` | (...`args`: `any`[]) => `TAttr` |

#### Returns

`TAttr`[]

#### Defined in

[src/ui/dialogs/entitydialog.ts:204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;204)

___

### beforeLoadEntity

▸ `Protected` **beforeLoadEntity**(`entity`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `TItem` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:449](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;449)

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

### deleteHandler

▸ `Protected` **deleteHandler**(`options`, `callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`ServiceOptions`](../interfaces/corelib_q.ServiceOptions.md)<[`DeleteResponse`](../interfaces/corelib_q.DeleteResponse.md)\> |
| `callback` | (`response`: [`DeleteResponse`](../interfaces/corelib_q.DeleteResponse.md)) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:168](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;168)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[TemplatedDialog](corelib.TemplatedDialog.md).[destroy](corelib.TemplatedDialog.md#destroy)

#### Defined in

[src/ui/dialogs/entitydialog.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;70)

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

### doDelete

▸ `Protected` **doDelete**(`callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback` | (`response`: [`DeleteResponse`](../interfaces/corelib_q.DeleteResponse.md)) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;172)

___

### getCloningEntity

▸ `Protected` **getCloningEntity**(): `TItem`

#### Returns

`TItem`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1028](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;1028)

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

### getDeleteOptions

▸ `Protected` **getDeleteOptions**(`callback`): [`ServiceOptions`](../interfaces/corelib_q.ServiceOptions.md)<[`DeleteResponse`](../interfaces/corelib_q.DeleteResponse.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback` | (`response`: [`DeleteResponse`](../interfaces/corelib_q.DeleteResponse.md)) => `void` |

#### Returns

[`ServiceOptions`](../interfaces/corelib_q.ServiceOptions.md)<[`DeleteResponse`](../interfaces/corelib_q.DeleteResponse.md)\>

#### Defined in

[src/ui/dialogs/entitydialog.ts:164](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;164)

___

### getDeletePermission

▸ `Protected` **getDeletePermission**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;1161)

___

### getDialogButtons

▸ `Protected` **getDialogButtons**(): [`DialogButton`](../interfaces/corelib_q.DialogButton.md)[]

#### Returns

[`DialogButton`](../interfaces/corelib_q.DialogButton.md)[]

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[getDialogButtons](corelib.TemplatedDialog.md#getdialogbuttons)

#### Defined in

[src/ui/dialogs/templateddialog.ts:349](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;349)

___

### getDialogOptions

▸ `Protected` **getDialogOptions**(): `any`

#### Returns

`any`

#### Inherited from

[TemplatedDialog](corelib.TemplatedDialog.md).[getDialogOptions](corelib.TemplatedDialog.md#getdialogoptions)

#### Defined in

[src/ui/dialogs/templateddialog.ts:353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/templateddialog.ts#line&#x3D;353)

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

### getEntityNameFieldValue

▸ `Protected` **getEntityNameFieldValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/dialogs/entitydialog.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;109)

___

### getEntitySingular

▸ `Protected` **getEntitySingular**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:282](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;282)

___

### getEntityTitle

▸ `Protected` **getEntityTitle**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;113)

___

### getEntityType

▸ `Protected` **getEntityType**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;214)

___

### getFallbackTemplate

▸ `Protected` **getFallbackTemplate**(): `string`

#### Returns

`string`

#### Overrides

[TemplatedDialog](corelib.TemplatedDialog.md).[getFallbackTemplate](corelib.TemplatedDialog.md#getfallbacktemplate)

#### Defined in

[src/ui/dialogs/entitydialog.ts:1194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;1194)

___

### getFormKey

▸ `Protected` **getFormKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:241](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;241)

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

### getIdProperty

▸ `Protected` **getIdProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:322](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;322)

___

### getInsertPermission

▸ `Protected` **getInsertPermission**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;1153)

___

### getIsActiveProperty

▸ `Protected` **getIsActiveProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:339](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;339)

___

### getIsDeletedProperty

▸ `Protected` **getIsDeletedProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:354](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;354)

___

### getLangs

▸ `Private` **getLangs**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/dialogs/entitydialog.ts:609](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;609)

___

### getLanguages

▸ `Protected` **getLanguages**(): `any`[]

#### Returns

`any`[]

#### Defined in

[src/ui/dialogs/entitydialog.ts:601](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;601)

___

### getLoadByIdOptions

▸ `Protected` **getLoadByIdOptions**(`id`, `callback`): [`ServiceOptions`](../interfaces/corelib_q.ServiceOptions.md)<[`RetrieveResponse`](../interfaces/corelib_q.RetrieveResponse.md)<`TItem`\>\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `any` |
| `callback` | (`response`: [`RetrieveResponse`](../interfaces/corelib_q.RetrieveResponse.md)<`TItem`\>) => `void` |

#### Returns

[`ServiceOptions`](../interfaces/corelib_q.ServiceOptions.md)<[`RetrieveResponse`](../interfaces/corelib_q.RetrieveResponse.md)<`TItem`\>\>

#### Defined in

[src/ui/dialogs/entitydialog.ts:472](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;472)

___

### getLoadByIdRequest

▸ `Protected` **getLoadByIdRequest**(`id`): [`RetrieveRequest`](../interfaces/corelib_q.RetrieveRequest.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `any` |

#### Returns

[`RetrieveRequest`](../interfaces/corelib_q.RetrieveRequest.md)

#### Defined in

[src/ui/dialogs/entitydialog.ts:476](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;476)

___

### getLocalTextDbPrefix

▸ `Protected` **getLocalTextDbPrefix**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;255)

___

### getLocalTextPrefix

▸ `Protected` **getLocalTextPrefix**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:267](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;267)

___

### getLocalizationGridValue

▸ `Protected` **getLocalizationGridValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/dialogs/entitydialog.ts:687](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;687)

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

### getNameProperty

▸ `Protected` **getNameProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:304](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;304)

___

### getPendingLocalizations

▸ `Protected` **getPendingLocalizations**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/dialogs/entitydialog.ts:700](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;700)

___

### getPropertyGridOptions

▸ `Protected` **getPropertyGridOptions**(): [`PropertyGridOptions`](../interfaces/corelib.PropertyGridOptions.md)

#### Returns

[`PropertyGridOptions`](../interfaces/corelib.PropertyGridOptions.md)

#### Defined in

[src/ui/dialogs/entitydialog.ts:774](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;774)

___

### getPropertyItems

▸ `Protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/corelib_q.PropertyItem.md)[]

#### Defined in

[src/ui/dialogs/entitydialog.ts:742](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;742)

___

### getPropertyItemsData

▸ `Protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)

#### Returns

[`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)

#### Defined in

[src/ui/dialogs/entitydialog.ts:746](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;746)

___

### getPropertyItemsDataAsync

▸ `Protected` **getPropertyItemsDataAsync**(): `Promise`<[`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)\>

#### Returns

`Promise`<[`PropertyItemsData`](../interfaces/corelib_q.PropertyItemsData.md)\>

#### Defined in

[src/ui/dialogs/entitydialog.ts:765](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;765)

___

### getRowDefinition

▸ `Protected` **getRowDefinition**(): [`IRowDefinition`](../interfaces/corelib.IRowDefinition.md)

#### Returns

[`IRowDefinition`](../interfaces/corelib.IRowDefinition.md)

#### Defined in

[src/ui/dialogs/entitydialog.ts:208](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;208)

___

### getSaveEntity

▸ `Protected` **getSaveEntity**(): `TItem`

#### Returns

`TItem`

#### Defined in

[src/ui/dialogs/entitydialog.ts:823](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;823)

___

### getSaveOptions

▸ `Protected` **getSaveOptions**(`callback`): [`ServiceOptions`](../interfaces/corelib_q.ServiceOptions.md)<[`SaveResponse`](../interfaces/corelib_q.SaveResponse.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback` | (`response`: [`SaveResponse`](../interfaces/corelib_q.SaveResponse.md)) => `void` |

#### Returns

[`ServiceOptions`](../interfaces/corelib_q.ServiceOptions.md)<[`SaveResponse`](../interfaces/corelib_q.SaveResponse.md)\>

#### Defined in

[src/ui/dialogs/entitydialog.ts:788](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;788)

___

### getSaveRequest

▸ `Protected` **getSaveRequest**(): [`SaveRequest`](../interfaces/corelib_q.SaveRequest.md)<`TItem`\>

#### Returns

[`SaveRequest`](../interfaces/corelib_q.SaveRequest.md)<`TItem`\>

#### Defined in

[src/ui/dialogs/entitydialog.ts:841](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;841)

___

### getService

▸ `Protected` **getService**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:360](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;360)

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

#### Overrides

[TemplatedDialog](corelib.TemplatedDialog.md).[getToolbarButtons](corelib.TemplatedDialog.md#gettoolbarbuttons)

#### Defined in

[src/ui/dialogs/entitydialog.ts:900](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;900)

___

### getUndeleteOptions

▸ `Protected` **getUndeleteOptions**(`callback?`): [`ServiceOptions`](../interfaces/corelib_q.ServiceOptions.md)<[`UndeleteResponse`](../interfaces/corelib_q.UndeleteResponse.md)\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback?` | (`response`: [`UndeleteResponse`](../interfaces/corelib_q.UndeleteResponse.md)) => `void` |

#### Returns

[`ServiceOptions`](../interfaces/corelib_q.ServiceOptions.md)<[`UndeleteResponse`](../interfaces/corelib_q.UndeleteResponse.md)\>

#### Defined in

[src/ui/dialogs/entitydialog.ts:1101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;1101)

___

### getUpdatePermission

▸ `Protected` **getUpdatePermission**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;1157)

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

[src/ui/dialogs/entitydialog.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;93)

___

### get\_entityId

▸ `Protected` **get_entityId**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/dialogs/entitydialog.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;101)

___

### get\_readOnly

▸ **get_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[IReadOnly](corelib.IReadOnly.md).[get_readOnly](corelib.IReadOnly.md#get_readonly)

#### Defined in

[src/ui/dialogs/entitydialog.ts:1141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;1141)

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

### hasDeletePermission

▸ `Protected` **hasDeletePermission**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;1165)

___

### hasInsertPermission

▸ `Protected` **hasInsertPermission**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;1170)

___

### hasSavePermission

▸ `Protected` **hasSavePermission**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;1180)

___

### hasUpdatePermission

▸ `Protected` **hasUpdatePermission**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;1175)

___

### init

▸ **init**(`action?`): [`EntityDialog`](corelib.EntityDialog.md)<`TItem`, `TOptions`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `action?` | (`widget`: `any`) => `void` |

#### Returns

[`EntityDialog`](corelib.EntityDialog.md)<`TItem`, `TOptions`\>

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

[src/ui/dialogs/entitydialog.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;57)

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

### initLocalizationGrid

▸ `Protected` **initLocalizationGrid**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:512](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;512)

___

### initLocalizationGridCommon

▸ `Protected` **initLocalizationGridCommon**(`pgOptions`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `pgOptions` | [`PropertyGridOptions`](../interfaces/corelib.PropertyGridOptions.md) |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:521](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;521)

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

[src/ui/dialogs/entitydialog.ts:730](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;730)

___

### initSync

▸ `Protected` **initSync**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;51)

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

#### Overrides

[TemplatedDialog](corelib.TemplatedDialog.md).[initToolbar](corelib.TemplatedDialog.md#inittoolbar)

#### Defined in

[src/ui/dialogs/entitydialog.ts:880](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;880)

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

[src/ui/dialogs/entitydialog.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;46)

___

### isCloneMode

▸ `Protected` **isCloneMode**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;130)

___

### isDeleted

▸ `Protected` **isDeleted**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;138)

___

### isEditMode

▸ `Protected` **isEditMode**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;134)

___

### isLocalizationMode

▸ `Protected` **isLocalizationMode**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:570](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;570)

___

### isLocalizationModeAndChanged

▸ `Protected` **isLocalizationModeAndChanged**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:574](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;574)

___

### isNew

▸ `Protected` **isNew**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:156](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;156)

___

### isNewOrDeleted

▸ `Protected` **isNewOrDeleted**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;160)

___

### isViewMode

▸ `Protected` **isViewMode**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;1186)

___

### load

▸ **load**(`entityOrId`, `done`, `fail?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entityOrId` | `any` |
| `done` | () => `void` |
| `fail?` | (`ex`: [`Exception`](corelib_q.Exception.md)) => `void` |

#### Returns

`void`

#### Implementation of

[IEditDialog](corelib.IEditDialog.md).[load](corelib.IEditDialog.md#load)

#### Defined in

[src/ui/dialogs/entitydialog.ts:373](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;373)

___

### loadById

▸ **loadById**(`id`, `callback?`, `fail?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `any` |
| `callback?` | (`response`: [`RetrieveResponse`](../interfaces/corelib_q.RetrieveResponse.md)<`TItem`\>) => `void` |
| `fail?` | () => `void` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:486](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;486)

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

[src/ui/dialogs/entitydialog.ts:459](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;459)

___

### loadByIdHandler

▸ `Protected` **loadByIdHandler**(`options`, `callback`, `fail`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`ServiceOptions`](../interfaces/corelib_q.ServiceOptions.md)<[`RetrieveResponse`](../interfaces/corelib_q.RetrieveResponse.md)<`TItem`\>\> |
| `callback` | (`response`: [`RetrieveResponse`](../interfaces/corelib_q.RetrieveResponse.md)<`TItem`\>) => `void` |
| `fail` | () => `void` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:507](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;507)

___

### loadEntity

▸ `Protected` **loadEntity**(`entity`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `TItem` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:434](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;434)

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

[src/ui/dialogs/entitydialog.ts:419](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;419)

___

### loadLocalization

▸ `Protected` **loadLocalization**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:623](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;623)

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

[src/ui/dialogs/entitydialog.ts:414](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;414)

___

### loadResponse

▸ `Protected` **loadResponse**(`data`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `data` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:424](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;424)

___

### localizationButtonClick

▸ `Protected` **localizationButtonClick**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:583](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;583)

___

### onDeleteSuccess

▸ `Protected` **onDeleteSuccess**(`response`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `response` | [`DeleteResponse`](../interfaces/corelib_q.DeleteResponse.md) |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:201](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;201)

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

### onLoadingData

▸ `Protected` **onLoadingData**(`data`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `data` | [`RetrieveResponse`](../interfaces/corelib_q.RetrieveResponse.md)<`TItem`\> |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:469](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;469)

___

### onSaveSuccess

▸ `Protected` **onSaveSuccess**(`response`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `response` | [`SaveResponse`](../interfaces/corelib_q.SaveResponse.md) |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:861](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;861)

___

### reloadById

▸ `Protected` **reloadById**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:482](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;482)

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

### save

▸ `Protected` **save**(`callback?`): `boolean` \| `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback?` | (`response`: [`SaveResponse`](../interfaces/corelib_q.SaveResponse.md)) => `void` |

#### Returns

`boolean` \| `void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:869](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;869)

___

### saveHandler

▸ `Protected` **saveHandler**(`options`, `callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`ServiceOptions`](../interfaces/corelib_q.ServiceOptions.md)<[`SaveResponse`](../interfaces/corelib_q.SaveResponse.md)\> |
| `callback` | (`response`: [`SaveResponse`](../interfaces/corelib_q.SaveResponse.md)) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:875](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;875)

___

### save\_submitHandler

▸ `Protected` **save_submitHandler**(`callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback` | (`response`: [`SaveResponse`](../interfaces/corelib_q.SaveResponse.md)) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:864](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;864)

___

### setLocalizationGridCurrentValues

▸ `Protected` **setLocalizationGridCurrentValues**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:666](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;666)

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

▸ `Protected` **set_entity**(`entity`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `entity` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;97)

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

[src/ui/dialogs/entitydialog.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;105)

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

[IReadOnly](corelib.IReadOnly.md).[set_readOnly](corelib.IReadOnly.md#set_readonly)

#### Defined in

[src/ui/dialogs/entitydialog.ts:1145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;1145)

___

### showSaveSuccessMessage

▸ `Protected` **showSaveSuccessMessage**(`response`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `response` | [`SaveResponse`](../interfaces/corelib_q.SaveResponse.md) |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:896](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;896)

___

### undelete

▸ `Protected` **undelete**(`callback?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback?` | (`response`: [`UndeleteResponse`](../interfaces/corelib_q.UndeleteResponse.md)) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;1109)

___

### undeleteHandler

▸ `Protected` **undeleteHandler**(`options`, `callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`ServiceOptions`](../interfaces/corelib_q.ServiceOptions.md)<[`UndeleteResponse`](../interfaces/corelib_q.UndeleteResponse.md)\> |
| `callback` | (`response`: [`UndeleteResponse`](../interfaces/corelib_q.UndeleteResponse.md)) => `void` |

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;1105)

___

### updateInterface

▸ `Protected` **updateInterface**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1051](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;1051)

___

### updateTitle

▸ `Protected` **updateTitle**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;126)

___

### useAsync

▸ `Protected` **useAsync**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;66)

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

### useViewMode

▸ `Protected` **useViewMode**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:1190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;1190)

___

### validateBeforeSave

▸ `Protected` **validateBeforeSave**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.ts:784](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.ts#line&#x3D;784)

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
