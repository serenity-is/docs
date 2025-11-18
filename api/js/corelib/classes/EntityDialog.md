[@serenity-is/corelib](../README.md) / EntityDialog

# Class: EntityDialog\<TItem, P\>

Defined in: [src/ui/dialogs/entitydialog.tsx:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L17)

## Extends

- [`BaseDialog`](BaseDialog.md)\<`P`\>

## Type Parameters

### TItem

`TItem`

### P

`P` = \{ \}

## Implements

- [`IEditDialog`](IEditDialog.md)
- [`IReadOnly`](IReadOnly.md)

## Constructors

### Constructor

> **new EntityDialog**\<`TItem`, `P`\>(`props?`): `EntityDialog`\<`TItem`, `P`\>

Defined in: [src/ui/dialogs/entitydialog.tsx:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L37)

#### Parameters

##### props?

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Returns

`EntityDialog`\<`TItem`, `P`\>

#### Overrides

[`BaseDialog`](BaseDialog.md).[`constructor`](BaseDialog.md#constructor)

## Properties

### applyChangesButton

> `protected` **applyChangesButton**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L28)

***

### cloneButton

> `protected` **cloneButton**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L31)

***

### deleteButton

> `protected` **deleteButton**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L29)

***

### dialog

> `protected` **dialog**: [`Dialog`](Dialog.md)

Defined in: [src/ui/dialogs/basedialog.tsx:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L20)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`dialog`](BaseDialog.md#dialog)

***

### domNode

> `readonly` **domNode**: `HTMLElement`

Defined in: [src/ui/widgets/widget.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L14)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`domNode`](BaseDialog.md#domnode)

***

### editButton

> `protected` **editButton**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L32)

***

### editClicked

> `protected` **editClicked**: `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:745](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L745)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L13)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`idPrefix`](BaseDialog.md#idprefix)

***

### localizer

> `protected` **localizer**: [`EntityLocalizer`](EntityLocalizer.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L34)

***

### localizerButton

> `protected` **localizerButton**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L35)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L11)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`options`](BaseDialog.md#options)

***

### propertyGrid

> `protected` **propertyGrid**: [`PropertyGrid`](PropertyGrid.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L25)

***

### propertyItemsData

> `protected` **propertyItemsData**: [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L24)

***

### saveAndCloseButton

> `protected` **saveAndCloseButton**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L27)

***

### tabs

> `protected` **tabs**: [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Defined in: [src/ui/dialogs/basedialog.tsx:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L17)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`tabs`](BaseDialog.md#tabs)

***

### toolbar

> `protected` **toolbar**: [`Toolbar`](Toolbar.md)

Defined in: [src/ui/dialogs/basedialog.tsx:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L18)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`toolbar`](BaseDialog.md#toolbar)

***

### undeleteButton

> `protected` **undeleteButton**: [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L30)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`uniqueName`](BaseDialog.md#uniquename)

***

### validator

> `protected` **validator**: `any`

Defined in: [src/ui/dialogs/basedialog.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L19)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`validator`](BaseDialog.md#validator)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/dialogs/entitydialog.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L19)

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`[typeInfo]`](IReadOnly.md#typeinfo)

#### Overrides

[`BaseDialog`](BaseDialog.md).[`[typeInfo]`](BaseDialog.md#typeinfo)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L219)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`isComponent`](BaseDialog.md#iscomponent)

## Accessors

### dialogTitle

#### Get Signature

> **get** **dialogTitle**(): `string`

Defined in: [src/ui/dialogs/basedialog.tsx:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L211)

##### Returns

`string`

#### Set Signature

> **set** **dialogTitle**(`value`): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:215](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L215)

##### Parameters

###### value

`string`

##### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`dialogTitle`](BaseDialog.md#dialogtitle)

***

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L59)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`element`](BaseDialog.md#element)

***

### entity

#### Get Signature

> **get** **entity**(): `TItem`

Defined in: [src/ui/dialogs/entitydialog.tsx:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L69)

##### Returns

`TItem`

#### Set Signature

> **set** **entity**(`value`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L73)

##### Parameters

###### value

`TItem`

##### Returns

`void`

***

### entityId

#### Get Signature

> **get** **entityId**(): `any`

Defined in: [src/ui/dialogs/entitydialog.tsx:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L82)

##### Returns

`any`

#### Set Signature

> **set** **entityId**(`value`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L86)

##### Parameters

###### value

`any`

##### Returns

`void`

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L203)

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`props`](BaseDialog.md#props)

***

### readOnly

#### Get Signature

> **get** **readOnly**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:694](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L694)

##### Returns

`boolean`

#### Set Signature

> **set** **readOnly**(`value`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:698](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L698)

##### Parameters

###### value

`boolean`

##### Returns

`void`

***

### defaultLanguageList

#### Get Signature

> **get** `static` **defaultLanguageList**(): `string`[][]

Defined in: [src/ui/dialogs/entitydialog.tsx:770](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L770)

##### Returns

`string`[][]

#### Set Signature

> **set** `static` **defaultLanguageList**(`value`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:774](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L774)

##### Parameters

###### value

`string`[][]

##### Returns

`void`

## Methods

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L58)

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`addCssClass`](BaseDialog.md#addcssclass)

***

### addValidationRule()

#### Call Signature

> **addValidationRule**(`rule`, `uniqueName?`): `void`

Defined in: [src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)

##### Parameters

###### rule

(`input`) => `string`

###### uniqueName?

`string`

##### Returns

`void`

##### Inherited from

[`BaseDialog`](BaseDialog.md).[`addValidationRule`](BaseDialog.md#addvalidationrule)

#### Call Signature

> **addValidationRule**(`uniqueName`, `rule`): `void`

Defined in: [src/ui/widgets/widget.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L96)

##### Parameters

###### uniqueName

`string`

###### rule

(`input`) => `string`

##### Returns

`void`

##### Inherited from

[`BaseDialog`](BaseDialog.md).[`addValidationRule`](BaseDialog.md#addvalidationrule)

***

### afterInit()

> `protected` **afterInit**(): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L52)

#### Returns

`void`

***

### afterLoadEntity()

> `protected` **afterLoadEntity**(): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:358](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L358)

#### Returns

`void`

***

### afterRender()

> `protected` **afterRender**(`callback`): `void`

Defined in: [src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

#### Parameters

##### callback

() => `void`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`afterRender`](BaseDialog.md#afterrender)

***

### arrange()

> **arrange**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L184)

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`arrange`](BaseDialog.md#arrange)

***

### beforeLoadEntity()

> `protected` **beforeLoadEntity**(`entity`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:354](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L354)

#### Parameters

##### entity

`TItem`

#### Returns

`void`

***

### byId()

> `protected` **byId**\<`TElement`\>(`id`): [`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

Defined in: [src/ui/widgets/widget.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L102)

#### Type Parameters

##### TElement

`TElement` *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`byId`](BaseDialog.md#byid)

***

### change()

> **change**(`handler`): `void`

Defined in: [src/ui/widgets/widget.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L114)

#### Parameters

##### handler

(`e`) => `void`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`change`](BaseDialog.md#change)

***

### changeSelect2()

> **changeSelect2**(`handler`): `void`

Defined in: [src/ui/widgets/widget.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L118)

#### Parameters

##### handler

(`e`) => `void`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`changeSelect2`](BaseDialog.md#changeselect2)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

#### Returns

`boolean`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`deferRender`](BaseDialog.md#deferrender)

***

### deleteHandler()

> `protected` **deleteHandler**(`options`, `callback`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L142)

#### Parameters

##### options

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`DeleteResponse`](../interfaces/DeleteResponse.md)\>

##### callback

(`response`) => `void`

#### Returns

`void`

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L59)

#### Returns

`void`

#### Overrides

[`BaseDialog`](BaseDialog.md).[`destroy`](BaseDialog.md#destroy)

***

### dialogClose()

> **dialogClose**(`result?`): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L207)

#### Parameters

##### result?

`string`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`dialogClose`](BaseDialog.md#dialogclose)

***

### dialogOpen()

> **dialogOpen**(`asPanel?`): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L121)

#### Parameters

##### asPanel?

`boolean`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`dialogOpen`](BaseDialog.md#dialogopen)

***

### doDelete()

> `protected` **doDelete**(`callback`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L150)

#### Parameters

##### callback

(`response`) => `void`

#### Returns

`void`

***

### findById()

> `protected` **findById**\<`TElement`\>(`id`): `TElement`

Defined in: [src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

#### Type Parameters

##### TElement

`TElement` *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

#### Returns

`TElement`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`findById`](BaseDialog.md#findbyid)

***

### ~~get\_entityId()~~

> `protected` **get\_entityId**(): `any`

Defined in: [src/ui/dialogs/entitydialog.tsx:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L78)

#### Returns

`any`

#### Deprecated

use entityId

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:702](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L702)

#### Returns

`boolean`

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`get_readOnly`](IReadOnly.md#get_readonly)

***

### getCloningEntity()

> `protected` **getCloningEntity**(): `TItem`

Defined in: [src/ui/dialogs/entitydialog.tsx:634](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L634)

#### Returns

`TItem`

***

### getCreateServiceMethod()

> `protected` **getCreateServiceMethod**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:501](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L501)

#### Returns

`string`

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

#### Returns

`string`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getCssClass`](BaseDialog.md#getcssclass)

***

### getCustomAttribute()

> `protected` **getCustomAttribute**\<`TAttr`\>(`attrType`, `inherit`): `TAttr`

Defined in: [src/ui/widgets/widget.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L138)

#### Type Parameters

##### TAttr

`TAttr` *extends* [`CustomAttribute`](CustomAttribute.md)

#### Parameters

##### attrType

(...`args`) => `TAttr`

##### inherit

`boolean` = `true`

#### Returns

`TAttr`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getCustomAttribute`](BaseDialog.md#getcustomattribute)

***

### getDeleteOptions()

> `protected` **getDeleteOptions**(`callback`): [`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`DeleteResponse`](../interfaces/DeleteResponse.md)\>

Defined in: [src/ui/dialogs/entitydialog.tsx:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L138)

#### Parameters

##### callback

(`response`) => `void`

#### Returns

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`DeleteResponse`](../interfaces/DeleteResponse.md)\>

***

### getDeletePermission()

> `protected` **getDeletePermission**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:722](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L722)

#### Returns

`string`

***

### getDeleteServiceMethod()

> `protected` **getDeleteServiceMethod**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L146)

#### Returns

`string`

***

### getDialogButtons()

> `protected` **getDialogButtons**(): [`DialogButton`](../interfaces/DialogButton.md)[]

Defined in: [src/ui/dialogs/basedialog.tsx:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L203)

#### Returns

[`DialogButton`](../interfaces/DialogButton.md)[]

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getDialogButtons`](BaseDialog.md#getdialogbuttons)

***

### getDialogOptions()

> `protected` **getDialogOptions**(): [`DialogOptions`](../interfaces/DialogOptions.md)

Defined in: [src/ui/dialogs/basedialog.tsx:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L70)

#### Returns

[`DialogOptions`](../interfaces/DialogOptions.md)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getDialogOptions`](BaseDialog.md#getdialogoptions)

***

### getEntityNameFieldValue()

> `protected` **getEntityNameFieldValue**(): `any`

Defined in: [src/ui/dialogs/entitydialog.tsx:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L90)

#### Returns

`any`

***

### getEntitySingular()

> `protected` **getEntitySingular**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:232](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L232)

#### Returns

`string`

***

### getEntityTitle()

> `protected` **getEntityTitle**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L94)

#### Returns

`string`

***

### getEntityType()

> `protected` **getEntityType**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:181](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L181)

#### Returns

`string`

***

### getFormKey()

> `protected` **getFormKey**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L202)

#### Returns

`string`

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

#### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getGridField`](BaseDialog.md#getgridfield)

***

### getIdProperty()

> `protected` **getIdProperty**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:254](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L254)

#### Returns

`string`

***

### getInitialDialogTitle()

> `protected` **getInitialDialogTitle**(): `string`

Defined in: [src/ui/dialogs/basedialog.tsx:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L62)

#### Returns

`string`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getInitialDialogTitle`](BaseDialog.md#getinitialdialogtitle)

***

### getInsertPermission()

> `protected` **getInsertPermission**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:714](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L714)

#### Returns

`string`

***

### getIsActiveProperty()

> `protected` **getIsActiveProperty**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:267](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L267)

#### Returns

`string`

***

### getIsDeletedProperty()

> `protected` **getIsDeletedProperty**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:275](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L275)

#### Returns

`string`

***

### getLanguages()

> `protected` **getLanguages**(): [`LanguageList`](../type-aliases/LanguageList.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:452](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L452)

#### Returns

[`LanguageList`](../type-aliases/LanguageList.md)

***

### getLoadByIdOptions()

> `protected` **getLoadByIdOptions**(`id`, `callback`): [`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>\>

Defined in: [src/ui/dialogs/entitydialog.tsx:380](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L380)

#### Parameters

##### id

`any`

##### callback

(`response`) => `void`

#### Returns

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>\>

***

### getLoadByIdRequest()

> `protected` **getLoadByIdRequest**(`id`): [`RetrieveRequest`](../interfaces/RetrieveRequest.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:393](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L393)

#### Parameters

##### id

`any`

#### Returns

[`RetrieveRequest`](../interfaces/RetrieveRequest.md)

***

### getLocalizerOptions()

> `protected` **getLocalizerOptions**(): [`EntityLocalizerOptions`](../interfaces/EntityLocalizerOptions.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:431](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L431)

#### Returns

[`EntityLocalizerOptions`](../interfaces/EntityLocalizerOptions.md)

***

### getLocalTextDbPrefix()

> `protected` **getLocalTextDbPrefix**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L211)

#### Returns

`string`

***

### getLocalTextPrefix()

> `protected` **getLocalTextPrefix**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L223)

#### Returns

`string`

***

### getNameProperty()

> `protected` **getNameProperty**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:241](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L241)

#### Returns

`string`

***

### getPropertyGridOptions()

> `protected` **getPropertyGridOptions**(): [`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:488](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L488)

#### Returns

[`PropertyGridOptions`](../interfaces/PropertyGridOptions.md)

***

### getPropertyItems()

> `protected` **getPropertyItems**(): [`PropertyItem`](../interfaces/PropertyItem.md)[]

Defined in: [src/ui/dialogs/entitydialog.tsx:464](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L464)

#### Returns

[`PropertyItem`](../interfaces/PropertyItem.md)[]

***

### getPropertyItemsData()

> `protected` **getPropertyItemsData**(): [`PropertyItemsData`](../interfaces/PropertyItemsData.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:468](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L468)

#### Returns

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

***

### getPropertyItemsDataAsync()

> `protected` **getPropertyItemsDataAsync**(): `Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

Defined in: [src/ui/dialogs/entitydialog.tsx:483](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L483)

#### Returns

`Promise`\<[`PropertyItemsData`](../interfaces/PropertyItemsData.md)\>

***

### getRetrieveServiceMethod()

> `protected` **getRetrieveServiceMethod**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:403](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L403)

#### Returns

`string`

***

### getRowDefinition()

> `protected` **getRowDefinition**(): [`IRowDefinition`](../interfaces/IRowDefinition.md)

Defined in: [src/ui/dialogs/entitydialog.tsx:175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L175)

#### Returns

[`IRowDefinition`](../interfaces/IRowDefinition.md)

***

### getSaveEntity()

> `protected` **getSaveEntity**(): `TItem`

Defined in: [src/ui/dialogs/entitydialog.tsx:526](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L526)

#### Returns

`TItem`

***

### getSaveOptions()

> `protected` **getSaveOptions**(`callback`, `initiator?`): [`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`SaveResponse`](../interfaces/SaveResponse.md)\>

Defined in: [src/ui/dialogs/entitydialog.tsx:509](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L509)

#### Parameters

##### callback

(`response`) => `void`

##### initiator?

[`SaveInitiator`](../type-aliases/SaveInitiator.md)

#### Returns

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`SaveResponse`](../interfaces/SaveResponse.md)\>

***

### getSaveRequest()

> `protected` **getSaveRequest**(): [`SaveRequest`](../interfaces/SaveRequest.md)\<`TItem`\>

Defined in: [src/ui/dialogs/entitydialog.tsx:539](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L539)

#### Returns

[`SaveRequest`](../interfaces/SaveRequest.md)\<`TItem`\>

***

### getService()

> `protected` **getService**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L281)

#### Returns

`string`

***

### getToolbarButtons()

> `protected` **getToolbarButtons**(): [`ToolButton`](../interfaces/ToolButton.md)[]

Defined in: [src/ui/dialogs/entitydialog.tsx:573](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L573)

#### Returns

[`ToolButton`](../interfaces/ToolButton.md)[]

#### Overrides

[`BaseDialog`](BaseDialog.md).[`getToolbarButtons`](BaseDialog.md#gettoolbarbuttons)

***

### getUndeleteOptions()

> `protected` **getUndeleteOptions**(`callback?`): [`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`UndeleteResponse`](../interfaces/UndeleteResponse.md)\>

Defined in: [src/ui/dialogs/entitydialog.tsx:662](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L662)

#### Parameters

##### callback?

(`response`) => `void`

#### Returns

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`UndeleteResponse`](../interfaces/UndeleteResponse.md)\>

***

### getUndeleteServiceMethod()

> `protected` **getUndeleteServiceMethod**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:670](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L670)

#### Returns

`string`

***

### getUpdatePermission()

> `protected` **getUpdatePermission**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:718](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L718)

#### Returns

`string`

***

### getUpdateServiceMethod()

> `protected` **getUpdateServiceMethod**(): `string`

Defined in: [src/ui/dialogs/entitydialog.tsx:505](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L505)

#### Returns

`string`

***

### getValidatorOptions()

> `protected` **getValidatorOptions**(): `any`

Defined in: [src/ui/dialogs/basedialog.tsx:164](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L164)

#### Returns

`any`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getValidatorOptions`](BaseDialog.md#getvalidatoroptions)

***

### handleResponsive()

> `protected` **handleResponsive**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:227](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L227)

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`handleResponsive`](BaseDialog.md#handleresponsive)

***

### hasDeletePermission()

> `protected` **hasDeletePermission**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:726](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L726)

#### Returns

`boolean`

***

### hasInsertPermission()

> `protected` **hasInsertPermission**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:731](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L731)

#### Returns

`boolean`

***

### hasSavePermission()

> `protected` **hasSavePermission**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:741](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L741)

#### Returns

`boolean`

***

### hasUpdatePermission()

> `protected` **hasUpdatePermission**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:736](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L736)

#### Returns

`boolean`

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

#### Returns

`this`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`init`](BaseDialog.md#init)

***

### initDialog()

> `protected` **initDialog**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L98)

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`initDialog`](BaseDialog.md#initdialog)

***

### initLocalizer()

> `protected` **initLocalizer**(): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:447](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L447)

#### Returns

`void`

***

### initPropertyGrid()

> `protected` **initPropertyGrid**(): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:456](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L456)

#### Returns

`void`

***

### initTabs()

> `protected` **initTabs**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L220)

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`initTabs`](BaseDialog.md#inittabs)

***

### initToolbar()

> `protected` **initToolbar**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L153)

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`initToolbar`](BaseDialog.md#inittoolbar)

***

### initUIDialog()

> `protected` **initUIDialog**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L107)

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`initUIDialog`](BaseDialog.md#inituidialog)

***

### initValidator()

> `protected` **initValidator**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:168](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L168)

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`initValidator`](BaseDialog.md#initvalidator)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L173)

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`internalRenderContents`](BaseDialog.md#internalrendercontents)

***

### isCloneMode()

> `protected` **isCloneMode**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L107)

#### Returns

`boolean`

***

### isDeleted()

> `protected` **isDeleted**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L115)

#### Returns

`boolean`

***

### isEditMode()

> `protected` **isEditMode**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L111)

#### Returns

`boolean`

***

### isNew()

> `protected` **isNew**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L130)

#### Returns

`boolean`

***

### isNewOrDeleted()

> `protected` **isNewOrDeleted**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L134)

#### Returns

`boolean`

***

### isStaticPanel()

> `protected` **isStaticPanel**(): `boolean`

Defined in: [src/ui/dialogs/basedialog.tsx:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L66)

#### Returns

`boolean`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`isStaticPanel`](BaseDialog.md#isstaticpanel)

***

### isViewMode()

> `protected` **isViewMode**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:747](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L747)

#### Returns

`boolean`

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L190)

#### Returns

`boolean`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`legacyTemplateRender`](BaseDialog.md#legacytemplaterender)

***

### load()

> **load**(`entityOrId`, `done`, `fail?`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:288](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L288)

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

***

### loadById()

> **loadById**(`id`, `callback?`, `fail?`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:407](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L407)

#### Parameters

##### id

`any`

##### callback?

(`response`) => `void`

##### fail?

() => `void`

#### Returns

`void`

***

### loadByIdAndOpenDialog()

> **loadByIdAndOpenDialog**(`entityId`, `asPanel?`, `callback?`, `fail?`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:363](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L363)

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

***

### loadByIdHandler()

> `protected` **loadByIdHandler**(`options`, `callback`, `fail`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:411](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L411)

#### Parameters

##### options

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>\>

##### callback

(`response`) => `void`

##### fail

() => `void`

#### Returns

`void`

***

### loadEntity()

> `protected` **loadEntity**(`entity`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:344](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L344)

#### Parameters

##### entity

`TItem`

#### Returns

`void`

***

### loadEntityAndOpenDialog()

> **loadEntityAndOpenDialog**(`entity`, `asPanel?`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:328](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L328)

#### Parameters

##### entity

`TItem`

##### asPanel?

`boolean`

#### Returns

`void`

***

### loadNewAndOpenDialog()

> **loadNewAndOpenDialog**(`asPanel?`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:323](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L323)

#### Parameters

##### asPanel?

`boolean`

#### Returns

`void`

***

### loadResponse()

> `protected` **loadResponse**(`data`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:333](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L333)

#### Parameters

##### data

`any`

#### Returns

`void`

***

### onClose()

> **onClose**(`handler`, `opt?`): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:140](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L140)

Attaches a dialog/modal/panel close event handler. See Dialog.close for more info.

#### Parameters

##### handler

(`result?`, `e?`) => `void`

##### opt?

###### before?

`boolean`

###### oneOff?

`boolean`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`onClose`](BaseDialog.md#onclose)

***

### onDeleteSuccess()

> `protected` **onDeleteSuccess**(`response`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L172)

#### Parameters

##### response

[`DeleteResponse`](../interfaces/DeleteResponse.md)

#### Returns

`void`

***

### onDialogClose()

> `protected` **onDialogClose**(`result?`): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L190)

#### Parameters

##### result?

`string`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`onDialogClose`](BaseDialog.md#ondialogclose)

***

### onDialogOpen()

> `protected` **onDialogOpen**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:132](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L132)

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`onDialogOpen`](BaseDialog.md#ondialogopen)

***

### onLoadingData()

> `protected` **onLoadingData**(`data`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:377](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L377)

#### Parameters

##### data

[`RetrieveResponse`](../interfaces/RetrieveResponse.md)\<`TItem`\>

#### Returns

`void`

***

### onOpen()

> **onOpen**(`handler`, `opt?`): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L145)

Attaches a dialog/modal/panel open event handler. See Dialog.open for more info.

#### Parameters

##### handler

(`e?`) => `void`

##### opt?

###### before?

`boolean`

###### oneOff?

`boolean`

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`onOpen`](BaseDialog.md#onopen)

***

### onSaveSuccess()

> `protected` **onSaveSuccess**(`response`, `initiator?`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:550](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L550)

#### Parameters

##### response

[`SaveResponse`](../interfaces/SaveResponse.md)

##### initiator?

[`SaveInitiator`](../type-aliases/SaveInitiator.md)

#### Returns

`void`

***

### propertyItemsReady()

> `protected` **propertyItemsReady**(`itemsData`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L46)

#### Parameters

##### itemsData

[`PropertyItemsData`](../interfaces/PropertyItemsData.md)

#### Returns

`void`

***

### reloadById()

> `protected` **reloadById**(): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:399](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L399)

#### Returns

`void`

***

### render()

> **render**(): `any`

Defined in: [src/ui/widgets/widget.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L163)

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`render`](BaseDialog.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/dialogs/entitydialog.tsx:755](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L755)

#### Returns

`any`

#### Overrides

[`BaseDialog`](BaseDialog.md).[`renderContents`](BaseDialog.md#rendercontents)

***

### resetValidation()

> `protected` **resetValidation**(): `void`

Defined in: [src/ui/dialogs/basedialog.tsx:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L176)

#### Returns

`void`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`resetValidation`](BaseDialog.md#resetvalidation)

***

### retrieveLocalizations()

> `protected` **retrieveLocalizations**(): `Promise`\<`Record`\<`string`, `Partial`\<`TItem`\>\>\>

Defined in: [src/ui/dialogs/entitydialog.tsx:416](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L416)

#### Returns

`Promise`\<`Record`\<`string`, `Partial`\<`TItem`\>\>\>

***

### save()

> `protected` **save**(`callback?`, `initiator?`): `boolean` \| `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:559](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L559)

#### Parameters

##### callback?

(`response`) => `void`

##### initiator?

[`SaveInitiator`](../type-aliases/SaveInitiator.md)

#### Returns

`boolean` \| `void`

***

### save\_submitHandler()

> `protected` **save\_submitHandler**(`callback`, `initiator`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:554](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L554)

#### Parameters

##### callback

(`response`) => `void`

##### initiator

[`SaveInitiator`](../type-aliases/SaveInitiator.md)

#### Returns

`void`

***

### saveHandler()

> `protected` **saveHandler**(`options`, `callback`, `initiator`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:565](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L565)

#### Parameters

##### options

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`SaveResponse`](../interfaces/SaveResponse.md)\>

##### callback

(`response`) => `void`

##### initiator

[`SaveInitiator`](../type-aliases/SaveInitiator.md)

#### Returns

`void`

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:706](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L706)

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`set_readOnly`](IReadOnly.md#set_readonly)

***

### showSaveSuccessMessage()

> `protected` **showSaveSuccessMessage**(`response`, `initiator?`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:569](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L569)

#### Parameters

##### response

[`SaveResponse`](../interfaces/SaveResponse.md)

##### initiator?

[`SaveInitiator`](../type-aliases/SaveInitiator.md)

#### Returns

`void`

***

### syncOrAsyncThen()

> `protected` **syncOrAsyncThen**\<`T`\>(`syncMethod`, `asyncMethod`, `then`): `void`

Defined in: [src/ui/widgets/widget.ts:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L207)

#### Type Parameters

##### T

`T`

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

***

### undelete()

> `protected` **undelete**(`callback?`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:674](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L674)

#### Parameters

##### callback?

(`response`) => `void`

#### Returns

`void`

***

### undeleteHandler()

> `protected` **undeleteHandler**(`options`, `callback`): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:666](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L666)

#### Parameters

##### options

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`UndeleteResponse`](../interfaces/UndeleteResponse.md)\>

##### callback

(`response`) => `void`

#### Returns

`void`

***

### updateInterface()

> `protected` **updateInterface**(): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:653](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L653)

#### Returns

`void`

***

### updateTitle()

> `protected` **updateTitle**(): `void`

Defined in: [src/ui/dialogs/entitydialog.tsx:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L103)

#### Returns

`void`

***

### useAsync()

> `protected` **useAsync**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L55)

#### Returns

`boolean`

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L214)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`useIdPrefix`](BaseDialog.md#useidprefix)

***

### useViewMode()

> `protected` **useViewMode**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:751](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L751)

#### Returns

`boolean`

***

### validateBeforeSave()

> `protected` **validateBeforeSave**(): `boolean`

Defined in: [src/ui/dialogs/entitydialog.tsx:497](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/entitydialog.tsx#L497)

#### Returns

`boolean`

***

### validateForm()

> `protected` **validateForm**(): `boolean`

Defined in: [src/ui/dialogs/basedialog.tsx:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L180)

#### Returns

`boolean`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`validateForm`](BaseDialog.md#validateform)

***

### create()

> `static` **create**\<`TWidget`, `P`\>(`params`): `TWidget`

Defined in: [src/ui/widgets/widget.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L126)

#### Type Parameters

##### TWidget

`TWidget` *extends* [`Widget`](Widget.md)\<`P`\>

##### P

`P`

#### Parameters

##### params

[`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)\<`TWidget`, `P`\>

#### Returns

`TWidget`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`create`](BaseDialog.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLDivElement`

Defined in: [src/ui/dialogs/basedialog.tsx:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/dialogs/basedialog.tsx#L15)

#### Returns

`HTMLDivElement`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`createDefaultElement`](BaseDialog.md#createdefaultelement)

***

### getWidgetName()

> `static` **getWidgetName**(`type`): `string`

Defined in: [src/ui/widgets/widget.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L91)

#### Parameters

##### type

`Function`

#### Returns

`string`

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`getWidgetName`](BaseDialog.md#getwidgetname)

***

### registerClass()

> `protected` `static` **registerClass**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

Defined in: [src/ui/widgets/widget.ts:221](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L221)

#### Type Parameters

##### TypeName

`TypeName`

#### Parameters

##### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

##### intfAndAttr?

([`InterfaceType`](../type-aliases/InterfaceType.md) \| [`AttributeSpecifier`](../type-aliases/AttributeSpecifier.md))[]

#### Returns

[`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`registerClass`](BaseDialog.md#registerclass)

***

### registerEditor()

> `protected` `static` **registerEditor**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`TypeName`\>

Defined in: [src/ui/widgets/widget.ts:230](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L230)

#### Type Parameters

##### TypeName

`TypeName`

#### Parameters

##### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

##### intfAndAttr?

([`InterfaceType`](../type-aliases/InterfaceType.md) \| [`AttributeSpecifier`](../type-aliases/AttributeSpecifier.md))[]

#### Returns

[`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`TypeName`\>

#### Inherited from

[`BaseDialog`](BaseDialog.md).[`registerEditor`](BaseDialog.md#registereditor)
