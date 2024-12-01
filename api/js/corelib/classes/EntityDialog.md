[@serenity-is/corelib](../README.md) / EntityDialog

# Class: EntityDialog\<TItem, P\>

## Extends

- [`BaseDialog`](BaseDialog.md)\<`P`\>

## Type Parameters

• **TItem**

• **P** = \{\}

## Implements

- [`IEditDialog`](IEditDialog.md)
- [`IReadOnly`](IReadOnly.md)

## Constructors

### new EntityDialog()

> **new EntityDialog**\<`TItem`, `P`\>(`props`?): [`EntityDialog`](EntityDialog.md)\<`TItem`, `P`\>

#### Parameters

##### props?

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Returns

[`EntityDialog`](EntityDialog.md)\<`TItem`, `P`\>

#### Overrides

[`BaseDialog`](BaseDialog.md).[`constructor`](BaseDialog.md#constructors)

#### Defined in

[src/ui/dialogs/entitydialog.tsx:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L38)

## Properties

### applyChangesButton

> `protected` **applyChangesButton**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/dialogs/entitydialog.tsx:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L29)

***

### cloneButton

> `protected` **cloneButton**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/dialogs/entitydialog.tsx:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L32)

***

### deleteButton

> `protected` **deleteButton**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/dialogs/entitydialog.tsx:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L30)

***

### dialog

> `protected` **dialog**: [`Dialog`](Dialog.md)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`dialog`](BaseDialog.md#dialog)

#### Defined in

[src/ui/dialogs/basedialog.tsx:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L20)

***

### domNode

> `readonly` **domNode**: `HTMLElement`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`domNode`](BaseDialog.md#domnode)

#### Defined in

[src/ui/widgets/widget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L17)

***

### editButton

> `protected` **editButton**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/dialogs/entitydialog.tsx:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L33)

***

### editClicked

> `protected` **editClicked**: `boolean`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:758](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L758)

***

### idPrefix

> `readonly` **idPrefix**: `string`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`idPrefix`](BaseDialog.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

***

### localizer

> `protected` **localizer**: [`EntityLocalizer`](EntityLocalizer.md)

#### Defined in

[src/ui/dialogs/entitydialog.tsx:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L35)

***

### localizerButton

> `protected` **localizerButton**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/dialogs/entitydialog.tsx:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L36)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`options`](BaseDialog.md#options)

#### Defined in

[src/ui/widgets/widget.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L14)

***

### propertyGrid

> `protected` **propertyGrid**: [`PropertyGrid`](PropertyGrid.md)\<[`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)\>

#### Defined in

[src/ui/dialogs/entitydialog.tsx:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L26)

***

### propertyItemsData

> `protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Defined in

[src/ui/dialogs/entitydialog.tsx:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L25)

***

### saveAndCloseButton

> `protected` **saveAndCloseButton**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/dialogs/entitydialog.tsx:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L28)

***

### tabs

> `protected` **tabs**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`tabs`](BaseDialog.md#tabs)

#### Defined in

[src/ui/dialogs/basedialog.tsx:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L17)

***

### toolbar

> `protected` **toolbar**: [`Toolbar`](Toolbar.md)\<[`ToolbarOptions`](../interfaces/ToolbarOptions.md)\>

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`toolbar`](BaseDialog.md#toolbar)

#### Defined in

[src/ui/dialogs/basedialog.tsx:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L18)

***

### undeleteButton

> `protected` **undeleteButton**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Defined in

[src/ui/dialogs/entitydialog.tsx:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L31)

***

### uniqueName

> `readonly` **uniqueName**: `string`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`uniqueName`](BaseDialog.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

***

### validator

> `protected` **validator**: `any`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`validator`](BaseDialog.md#validator)

#### Defined in

[src/ui/dialogs/basedialog.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L19)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`isComponent`](BaseDialog.md#iscomponent)

#### Defined in

[src/ui/widgets/widget.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L223)

***

### typeInfo

> `static` **typeInfo**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity.Widget"`\>

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`typeInfo`](BaseDialog.md#typeinfo)

#### Defined in

[src/ui/widgets/widget.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L11)

## Accessors

### dialogTitle

#### Get Signature

> **get** **dialogTitle**(): `string`

##### Returns

`string`

#### Set Signature

> **set** **dialogTitle**(`value`): `void`

##### Parameters

###### value

`string`

##### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`dialogTitle`](BaseDialog.md#dialogtitle)

#### Defined in

[src/ui/dialogs/basedialog.tsx:210](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L210)

***

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`element`](BaseDialog.md#element)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

***

### entity

#### Get Signature

> **get** **entity**(): `TItem`

##### Returns

`TItem`

#### Set Signature

> **set** **entity**(`value`): `void`

##### Parameters

###### value

`TItem`

##### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L70)

***

### entityId

#### Get Signature

> **get** **entityId**(): `any`

##### Returns

`any`

#### Set Signature

> **set** **entityId**(`value`): `void`

##### Parameters

###### value

`any`

##### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L83)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`props`](BaseDialog.md#props)

#### Defined in

[src/ui/widgets/widget.ts:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L207)

***

### readOnly

#### Get Signature

> **get** **readOnly**(): `boolean`

##### Returns

`boolean`

#### Set Signature

> **set** **readOnly**(`value`): `void`

##### Parameters

###### value

`boolean`

##### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:707](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L707)

***

### defaultLanguageList

#### Get Signature

> **get** `static` **defaultLanguageList**(): `string`[][]

##### Returns

`string`[][]

#### Set Signature

> **set** `static` **defaultLanguageList**(`value`): `void`

##### Parameters

###### value

`string`[][]

##### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:783](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L783)

## Methods

### addCssClass()

> `protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`addCssClass`](BaseDialog.md#addcssclass)

#### Defined in

[src/ui/dialogs/basedialog.tsx:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L57)

***

### addValidationRule()

#### Call Signature

> **addValidationRule**(`rule`, `uniqueName`?): `void`

##### Parameters

###### rule

(`input`) => `string`

###### uniqueName?

`string`

##### Returns

`void`

##### Inherited from

[`BaseDialog`](BaseDialog.md).[`addValidationRule`](BaseDialog.md#addvalidationrule)

##### Defined in

[src/ui/widgets/widget.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L99)

#### Call Signature

> **addValidationRule**(`uniqueName`, `rule`): `void`

##### Parameters

###### uniqueName

`string`

###### rule

(`input`) => `string`

##### Returns

`void`

##### Inherited from

[`BaseDialog`](BaseDialog.md).[`addValidationRule`](BaseDialog.md#addvalidationrule)

##### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

***

### afterInit()

> `protected` **afterInit**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L53)

***

### afterLoadEntity()

> `protected` **afterLoadEntity**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:371](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L371)

***

### afterRender()

> `protected` **afterRender**(`callback`): `void`

#### Parameters

##### callback

() => `void`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`afterRender`](BaseDialog.md#afterrender)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

***

### arrange()

> **arrange**(): `void`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`arrange`](BaseDialog.md#arrange)

#### Defined in

[src/ui/dialogs/basedialog.tsx:183](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L183)

***

### beforeLoadEntity()

> `protected` **beforeLoadEntity**(`entity`): `void`

#### Parameters

##### entity

`TItem`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:367](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L367)

***

### byId()

> `protected` **byId**\<`TElement`\>(`id`): [`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

#### Type Parameters

• **TElement** *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`byId`](BaseDialog.md#byid)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

***

### change()

> **change**(`handler`): `void`

#### Parameters

##### handler

(`e`) => `void`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`change`](BaseDialog.md#change)

#### Defined in

[src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

***

### changeSelect2()

> **changeSelect2**(`handler`): `void`

#### Parameters

##### handler

(`e`) => `void`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`changeSelect2`](BaseDialog.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L122)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`deferRender`](BaseDialog.md#deferrender)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

***

### deleteHandler()

> `protected` **deleteHandler**(`options`, `callback`): `void`

#### Parameters

##### options

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`DeleteResponse`](../interfaces/DeleteResponse.md)\>

##### callback

(`response`) => `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L143)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Overrides

[`BaseDialog`](BaseDialog.md).[`destroy`](BaseDialog.md#destroy)

#### Defined in

[src/ui/dialogs/entitydialog.tsx:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L60)

***

### dialogClose()

> **dialogClose**(`result`?): `void`

#### Parameters

##### result?

`string`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`dialogClose`](BaseDialog.md#dialogclose)

#### Defined in

[src/ui/dialogs/basedialog.tsx:206](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L206)

***

### dialogOpen()

> **dialogOpen**(`asPanel`?): `void`

#### Parameters

##### asPanel?

`boolean`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`dialogOpen`](BaseDialog.md#dialogopen)

#### Defined in

[src/ui/dialogs/basedialog.tsx:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L120)

***

### doDelete()

> `protected` **doDelete**(`callback`): `void`

#### Parameters

##### callback

(`response`) => `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L151)

***

### findById()

> `protected` **findById**\<`TElement`\>(`id`): `TElement`

#### Type Parameters

• **TElement** *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

#### Returns

`TElement`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`findById`](BaseDialog.md#findbyid)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

***

### ~~get\_entityId()~~

> `protected` **get\_entityId**(): `any`

#### Returns

`any`

#### Deprecated

use entityId

#### Defined in

[src/ui/dialogs/entitydialog.tsx:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L79)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

#### Returns

`boolean`

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`get_readOnly`](IReadOnly.md#get_readonly)

#### Defined in

[src/ui/dialogs/entitydialog.tsx:715](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L715)

***

### getCloningEntity()

> `protected` **getCloningEntity**(): `TItem`

#### Returns

`TItem`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:647](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L647)

***

### getCreateServiceMethod()

> `protected` **getCreateServiceMethod**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:514](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L514)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getCssClass`](BaseDialog.md#getcssclass)

#### Defined in

[src/ui/widgets/widget.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L75)

***

### getCustomAttribute()

> `protected` **getCustomAttribute**\<`TAttr`\>(`attrType`, `inherit`): `TAttr`

#### Type Parameters

• **TAttr**

#### Parameters

##### attrType

(...`args`) => `TAttr`

##### inherit

`boolean` = `true`

#### Returns

`TAttr`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getCustomAttribute`](BaseDialog.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

***

### getDeleteOptions()

> `protected` **getDeleteOptions**(`callback`): [`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`DeleteResponse`](../interfaces/DeleteResponse.md)\>

#### Parameters

##### callback

(`response`) => `void`

#### Returns

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`DeleteResponse`](../interfaces/DeleteResponse.md)\>

#### Defined in

[src/ui/dialogs/entitydialog.tsx:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L139)

***

### getDeletePermission()

> `protected` **getDeletePermission**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:735](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L735)

***

### getDeleteServiceMethod()

> `protected` **getDeleteServiceMethod**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:147](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L147)

***

### getDialogButtons()

> `protected` **getDialogButtons**(): [`DialogButton`](../interfaces/DialogButton.md)[]

#### Returns

[`DialogButton`](../interfaces/DialogButton.md)[]

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getDialogButtons`](BaseDialog.md#getdialogbuttons)

#### Defined in

[src/ui/dialogs/basedialog.tsx:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L202)

***

### getDialogOptions()

> `protected` **getDialogOptions**(): [`DialogOptions`](../interfaces/DialogOptions.md)

#### Returns

[`DialogOptions`](../interfaces/DialogOptions.md)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getDialogOptions`](BaseDialog.md#getdialogoptions)

#### Defined in

[src/ui/dialogs/basedialog.tsx:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L69)

***

### getEntityNameFieldValue()

> `protected` **getEntityNameFieldValue**(): `any`

#### Returns

`any`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L91)

***

### getEntitySingular()

> `protected` **getEntitySingular**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:239](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L239)

***

### getEntityTitle()

> `protected` **getEntityTitle**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L95)

***

### getEntityType()

> `protected` **getEntityType**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L182)

***

### getFormKey()

> `protected` **getFormKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L207)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getGridField`](BaseDialog.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L114)

***

### getIdProperty()

> `protected` **getIdProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:264](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L264)

***

### getInitialDialogTitle()

> `protected` **getInitialDialogTitle**(): `string`

#### Returns

`string`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getInitialDialogTitle`](BaseDialog.md#getinitialdialogtitle)

#### Defined in

[src/ui/dialogs/basedialog.tsx:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L61)

***

### getInsertPermission()

> `protected` **getInsertPermission**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:727](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L727)

***

### getIsActiveProperty()

> `protected` **getIsActiveProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:278](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L278)

***

### getIsDeletedProperty()

> `protected` **getIsDeletedProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:286](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L286)

***

### getLanguages()

> `protected` **getLanguages**(): [`LanguageList`](../type-aliases/LanguageList.md)

#### Returns

[`LanguageList`](../type-aliases/LanguageList.md)

#### Defined in

[src/ui/dialogs/entitydialog.tsx:465](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L465)

***

### getLoadByIdOptions()

> `protected` **getLoadByIdOptions**(`id`, `callback`): [`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>\>

#### Parameters

##### id

`any`

##### callback

(`response`) => `void`

#### Returns

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>\>

#### Defined in

[src/ui/dialogs/entitydialog.tsx:393](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L393)

***

### getLoadByIdRequest()

> `protected` **getLoadByIdRequest**(`id`): [`RetrieveRequest`](../interfaces/RetrieveRequest.md)

#### Parameters

##### id

`any`

#### Returns

[`RetrieveRequest`](../interfaces/RetrieveRequest.md)

#### Defined in

[src/ui/dialogs/entitydialog.tsx:406](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L406)

***

### getLocalizerOptions()

> `protected` **getLocalizerOptions**(): [`EntityLocalizerOptions`](../interfaces/EntityLocalizerOptions.md)

#### Returns

[`EntityLocalizerOptions`](../interfaces/EntityLocalizerOptions.md)

#### Defined in

[src/ui/dialogs/entitydialog.tsx:444](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L444)

***

### getLocalTextDbPrefix()

> `protected` **getLocalTextDbPrefix**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:217](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L217)

***

### getLocalTextPrefix()

> `protected` **getLocalTextPrefix**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:229](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L229)

***

### getNameProperty()

> `protected` **getNameProperty**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:250](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L250)

***

### getPropertyGridOptions()

> `protected` **getPropertyGridOptions**(): [`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

#### Returns

[`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

#### Defined in

[src/ui/dialogs/entitydialog.tsx:501](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L501)

***

### getPropertyItems()

> `protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

#### Defined in

[src/ui/dialogs/entitydialog.tsx:477](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L477)

***

### getPropertyItemsData()

> `protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Defined in

[src/ui/dialogs/entitydialog.tsx:481](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L481)

***

### getPropertyItemsDataAsync()

> `protected` **getPropertyItemsDataAsync**(): `Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Returns

`Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

#### Defined in

[src/ui/dialogs/entitydialog.tsx:496](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L496)

***

### getRetrieveServiceMethod()

> `protected` **getRetrieveServiceMethod**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:416](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L416)

***

### getRowDefinition()

> `protected` **getRowDefinition**(): [`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Returns

[`IRowDefinition`](../interfaces/IRowDefinition.md)

#### Defined in

[src/ui/dialogs/entitydialog.tsx:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L176)

***

### getSaveEntity()

> `protected` **getSaveEntity**(): `TItem`

#### Returns

`TItem`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:539](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L539)

***

### getSaveOptions()

> `protected` **getSaveOptions**(`callback`, `initiator`?): [`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`SaveResponse`](../interfaces/SaveResponse.md)\>

#### Parameters

##### callback

(`response`) => `void`

##### initiator?

[`SaveInitiator`](../type-aliases/SaveInitiator.md)

#### Returns

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`SaveResponse`](../interfaces/SaveResponse.md)\>

#### Defined in

[src/ui/dialogs/entitydialog.tsx:522](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L522)

***

### getSaveRequest()

> `protected` **getSaveRequest**(): [`SaveRequest`](../interfaces/SaveRequest.md)\<`TItem`\>

#### Returns

[`SaveRequest`](../interfaces/SaveRequest.md)\<`TItem`\>

#### Defined in

[src/ui/dialogs/entitydialog.tsx:552](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L552)

***

### getService()

> `protected` **getService**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:292](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L292)

***

### getToolbarButtons()

> `protected` **getToolbarButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Overrides

[`BaseDialog`](BaseDialog.md).[`getToolbarButtons`](BaseDialog.md#gettoolbarbuttons)

#### Defined in

[src/ui/dialogs/entitydialog.tsx:586](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L586)

***

### getUndeleteOptions()

> `protected` **getUndeleteOptions**(`callback`?): [`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`UndeleteResponse`](../interfaces/UndeleteResponse.md)\>

#### Parameters

##### callback?

(`response`) => `void`

#### Returns

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`UndeleteResponse`](../interfaces/UndeleteResponse.md)\>

#### Defined in

[src/ui/dialogs/entitydialog.tsx:675](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L675)

***

### getUndeleteServiceMethod()

> `protected` **getUndeleteServiceMethod**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:683](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L683)

***

### getUpdatePermission()

> `protected` **getUpdatePermission**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:731](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L731)

***

### getUpdateServiceMethod()

> `protected` **getUpdateServiceMethod**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:518](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L518)

***

### getValidatorOptions()

> `protected` **getValidatorOptions**(): `any`

#### Returns

`any`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getValidatorOptions`](BaseDialog.md#getvalidatoroptions)

#### Defined in

[src/ui/dialogs/basedialog.tsx:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L163)

***

### handleResponsive()

> `protected` **handleResponsive**(): `void`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`handleResponsive`](BaseDialog.md#handleresponsive)

#### Defined in

[src/ui/dialogs/basedialog.tsx:226](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L226)

***

### hasDeletePermission()

> `protected` **hasDeletePermission**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:739](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L739)

***

### hasInsertPermission()

> `protected` **hasInsertPermission**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:744](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L744)

***

### hasSavePermission()

> `protected` **hasSavePermission**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:754](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L754)

***

### hasUpdatePermission()

> `protected` **hasUpdatePermission**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:749](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L749)

***

### init()

> **init**(): `this`

#### Returns

`this`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`init`](BaseDialog.md#init)

#### Defined in

[src/ui/widgets/widget.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L157)

***

### initDialog()

> `protected` **initDialog**(): `void`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`initDialog`](BaseDialog.md#initdialog)

#### Defined in

[src/ui/dialogs/basedialog.tsx:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L97)

***

### initLocalizer()

> `protected` **initLocalizer**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:460](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L460)

***

### initPropertyGrid()

> `protected` **initPropertyGrid**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:469](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L469)

***

### initTabs()

> `protected` **initTabs**(): `void`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`initTabs`](BaseDialog.md#inittabs)

#### Defined in

[src/ui/dialogs/basedialog.tsx:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L219)

***

### initToolbar()

> `protected` **initToolbar**(): `void`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`initToolbar`](BaseDialog.md#inittoolbar)

#### Defined in

[src/ui/dialogs/basedialog.tsx:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L152)

***

### initUIDialog()

> `protected` **initUIDialog**(): `void`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`initUIDialog`](BaseDialog.md#inituidialog)

#### Defined in

[src/ui/dialogs/basedialog.tsx:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L106)

***

### initValidator()

> `protected` **initValidator**(): `void`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`initValidator`](BaseDialog.md#initvalidator)

#### Defined in

[src/ui/dialogs/basedialog.tsx:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L167)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`internalRenderContents`](BaseDialog.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L177)

***

### isCloneMode()

> `protected` **isCloneMode**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L108)

***

### isDeleted()

> `protected` **isDeleted**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L116)

***

### isEditMode()

> `protected` **isEditMode**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L112)

***

### isNew()

> `protected` **isNew**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L131)

***

### isNewOrDeleted()

> `protected` **isNewOrDeleted**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L135)

***

### isStaticPanel()

> `protected` **isStaticPanel**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`isStaticPanel`](BaseDialog.md#isstaticpanel)

#### Defined in

[src/ui/dialogs/basedialog.tsx:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L65)

***

### isViewMode()

> `protected` **isViewMode**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:760](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L760)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`legacyTemplateRender`](BaseDialog.md#legacytemplaterender)

#### Defined in

[src/ui/widgets/widget.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L194)

***

### load()

> **load**(`entityOrId`, `done`, `fail`?): `void`

#### Parameters

##### entityOrId

`any`

##### done

() => `void`

##### fail?

(`ex`) => `void`

#### Returns

`void`

#### Implementation of

[`IEditDialog`](IEditDialog.md).[`load`](IEditDialog.md#load)

#### Defined in

[src/ui/dialogs/entitydialog.tsx:300](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L300)

***

### loadById()

> **loadById**(`id`, `callback`?, `fail`?): `void`

#### Parameters

##### id

`any`

##### callback?

(`response`) => `void`

##### fail?

() => `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:420](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L420)

***

### loadByIdAndOpenDialog()

> **loadByIdAndOpenDialog**(`entityId`, `asPanel`?, `callback`?, `fail`?): `void`

#### Parameters

##### entityId

`any`

##### asPanel?

`boolean`

##### callback?

(`response`) => `void`

##### fail?

() => `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:376](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L376)

***

### loadByIdHandler()

> `protected` **loadByIdHandler**(`options`, `callback`, `fail`): `void`

#### Parameters

##### options

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>\>

##### callback

(`response`) => `void`

##### fail

() => `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:424](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L424)

***

### loadEntity()

> `protected` **loadEntity**(`entity`): `void`

#### Parameters

##### entity

`TItem`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:357](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L357)

***

### loadEntityAndOpenDialog()

> **loadEntityAndOpenDialog**(`entity`, `asPanel`?): `void`

#### Parameters

##### entity

`TItem`

##### asPanel?

`boolean`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:341](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L341)

***

### loadNewAndOpenDialog()

> **loadNewAndOpenDialog**(`asPanel`?): `void`

#### Parameters

##### asPanel?

`boolean`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:336](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L336)

***

### loadResponse()

> `protected` **loadResponse**(`data`): `void`

#### Parameters

##### data

`any`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:346](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L346)

***

### onClose()

> **onClose**(`handler`, `opt`?): `void`

Attaches a dialog/modal/panel close event handler. See Dialog.close for more info.

#### Parameters

##### handler

(`result`?, `e`?) => `void`

##### opt?

###### opt.before

`boolean`

###### opt.oneOff

`boolean`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`onClose`](BaseDialog.md#onclose)

#### Defined in

[src/ui/dialogs/basedialog.tsx:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L139)

***

### onDeleteSuccess()

> `protected` **onDeleteSuccess**(`response`): `void`

#### Parameters

##### response

[`DeleteResponse`](../interfaces/DeleteResponse.md)

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L173)

***

### onDialogClose()

> `protected` **onDialogClose**(`result`?): `void`

#### Parameters

##### result?

`string`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`onDialogClose`](BaseDialog.md#ondialogclose)

#### Defined in

[src/ui/dialogs/basedialog.tsx:189](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L189)

***

### onDialogOpen()

> `protected` **onDialogOpen**(): `void`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`onDialogOpen`](BaseDialog.md#ondialogopen)

#### Defined in

[src/ui/dialogs/basedialog.tsx:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L131)

***

### onLoadingData()

> `protected` **onLoadingData**(`data`): `void`

#### Parameters

##### data

[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:390](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L390)

***

### onOpen()

> **onOpen**(`handler`, `opt`?): `void`

Attaches a dialog/modal/panel open event handler. See Dialog.open for more info.

#### Parameters

##### handler

(`e`?) => `void`

##### opt?

###### opt.before

`boolean`

###### opt.oneOff

`boolean`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`onOpen`](BaseDialog.md#onopen)

#### Defined in

[src/ui/dialogs/basedialog.tsx:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L144)

***

### onSaveSuccess()

> `protected` **onSaveSuccess**(`response`, `initiator`?): `void`

#### Parameters

##### response

[`SaveResponse`](../interfaces/SaveResponse.md)

##### initiator?

[`SaveInitiator`](../type-aliases/SaveInitiator.md)

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:563](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L563)

***

### propertyItemsReady()

> `protected` **propertyItemsReady**(`itemsData`): `void`

#### Parameters

##### itemsData

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L47)

***

### reloadById()

> `protected` **reloadById**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:412](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L412)

***

### render()

> **render**(): `any`

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`render`](BaseDialog.md#render)

#### Defined in

[src/ui/widgets/widget.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L167)

***

### renderContents()

> `protected` **renderContents**(): `any`

#### Returns

`any`

#### Overrides

[`BaseDialog`](BaseDialog.md).[`renderContents`](BaseDialog.md#rendercontents)

#### Defined in

[src/ui/dialogs/entitydialog.tsx:768](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L768)

***

### resetValidation()

> `protected` **resetValidation**(): `void`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`resetValidation`](BaseDialog.md#resetvalidation)

#### Defined in

[src/ui/dialogs/basedialog.tsx:175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L175)

***

### retrieveLocalizations()

> `protected` **retrieveLocalizations**(): `Promise`\<`Record`\<`string`, `Partial`\<`TItem`\>\>\>

#### Returns

`Promise`\<`Record`\<`string`, `Partial`\<`TItem`\>\>\>

#### Defined in

[src/ui/dialogs/entitydialog.tsx:429](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L429)

***

### save()

> `protected` **save**(`callback`?, `initiator`?): `boolean` \| `void`

#### Parameters

##### callback?

(`response`) => `void`

##### initiator?

[`SaveInitiator`](../type-aliases/SaveInitiator.md)

#### Returns

`boolean` \| `void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:572](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L572)

***

### save\_submitHandler()

> `protected` **save\_submitHandler**(`callback`, `initiator`): `void`

#### Parameters

##### callback

(`response`) => `void`

##### initiator

[`SaveInitiator`](../type-aliases/SaveInitiator.md)

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:567](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L567)

***

### saveHandler()

> `protected` **saveHandler**(`options`, `callback`, `initiator`): `void`

#### Parameters

##### options

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`SaveResponse`](../interfaces/SaveResponse.md)\>

##### callback

(`response`) => `void`

##### initiator

[`SaveInitiator`](../type-aliases/SaveInitiator.md)

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:578](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L578)

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`set_readOnly`](IReadOnly.md#set_readonly)

#### Defined in

[src/ui/dialogs/entitydialog.tsx:719](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L719)

***

### showSaveSuccessMessage()

> `protected` **showSaveSuccessMessage**(`response`, `initiator`?): `void`

#### Parameters

##### response

[`SaveResponse`](../interfaces/SaveResponse.md)

##### initiator?

[`SaveInitiator`](../type-aliases/SaveInitiator.md)

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:582](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L582)

***

### syncOrAsyncThen()

> `protected` **syncOrAsyncThen**\<`T`\>(`syncMethod`, `asyncMethod`, `then`): `void`

#### Type Parameters

• **T**

#### Parameters

##### syncMethod

() => `T`

##### asyncMethod

() => `PromiseLike`\<`T`\>

##### then

(`v`) => `void`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`syncOrAsyncThen`](BaseDialog.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L211)

***

### undelete()

> `protected` **undelete**(`callback`?): `void`

#### Parameters

##### callback?

(`response`) => `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:687](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L687)

***

### undeleteHandler()

> `protected` **undeleteHandler**(`options`, `callback`): `void`

#### Parameters

##### options

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`UndeleteResponse`](../interfaces/UndeleteResponse.md)\>

##### callback

(`response`) => `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:679](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L679)

***

### updateInterface()

> `protected` **updateInterface**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:666](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L666)

***

### updateTitle()

> `protected` **updateTitle**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L104)

***

### useAsync()

> `protected` **useAsync**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L56)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`useIdPrefix`](BaseDialog.md#useidprefix)

#### Defined in

[src/ui/widgets/widget.ts:218](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L218)

***

### useViewMode()

> `protected` **useViewMode**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:764](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L764)

***

### validateBeforeSave()

> `protected` **validateBeforeSave**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/ui/dialogs/entitydialog.tsx:510](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L510)

***

### validateForm()

> `protected` **validateForm**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`validateForm`](BaseDialog.md#validateform)

#### Defined in

[src/ui/dialogs/basedialog.tsx:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L179)

***

### create()

> `static` **create**\<`TWidget`, `P`\>(`params`): `TWidget`

#### Type Parameters

• **TWidget** *extends* [`Widget`](Widget.md)\<`P`\>

• **P**

#### Parameters

##### params

[`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)\<`TWidget`, `P`\>

#### Returns

`TWidget`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`create`](BaseDialog.md#create)

#### Defined in

[src/ui/widgets/widget.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L130)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLDivElement`

#### Returns

`HTMLDivElement`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`createDefaultElement`](BaseDialog.md#createdefaultelement)

#### Defined in

[src/ui/dialogs/basedialog.tsx:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L15)

***

### getWidgetName()

> `static` **getWidgetName**(`type`): `string`

#### Parameters

##### type

`Function`

#### Returns

`string`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getWidgetName`](BaseDialog.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
