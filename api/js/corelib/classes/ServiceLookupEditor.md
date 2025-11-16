[serenity-is/corelib](../README.md) / ServiceLookupEditor

# Class: ServiceLookupEditor\<P, TItem\>

Defined in: [src/ui/editors/servicelookupeditor.ts:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L187)

## Extends

- [`ServiceLookupEditorBase`](ServiceLookupEditorBase.md)\<[`ServiceLookupEditorOptions`](../interfaces/ServiceLookupEditorOptions.md), `TItem`\>

## Type Parameters

### P

`P` *extends* [`ServiceLookupEditorOptions`](../interfaces/ServiceLookupEditorOptions.md) = [`ServiceLookupEditorOptions`](../interfaces/ServiceLookupEditorOptions.md)

### TItem

`TItem` = `any`

## Constructors

### Constructor

> **new ServiceLookupEditor**\<`P`, `TItem`\>(`props`): `ServiceLookupEditor`\<`P`, `TItem`\>

Defined in: [src/ui/editors/servicelookupeditor.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L190)

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

#### Returns

`ServiceLookupEditor`\<`P`, `TItem`\>

#### Overrides

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`constructor`](ServiceLookupEditorBase.md#constructor)

## Properties

### cascadeLink

> `protected` **cascadeLink**: [`CascadedWidgetLink`](CascadedWidgetLink.md)\<[`Widget`](Widget.md)\<`any`\>\>

Defined in: [src/ui/editors/comboboxeditor.tsx:574](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L574)

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`cascadeLink`](ServiceLookupEditorBase.md#cascadelink)

***

### domNode

> `readonly` **domNode**: `HTMLInputElement`

Defined in: [src/ui/editors/comboboxeditor.tsx:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L44)

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`domNode`](ServiceLookupEditorBase.md#domnode)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L13)

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`idPrefix`](ServiceLookupEditorBase.md#idprefix)

***

### lastCreateTerm

> `protected` **lastCreateTerm**: `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L49)

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`lastCreateTerm`](ServiceLookupEditorBase.md#lastcreateterm)

***

### onInitNewEntity()

> **onInitNewEntity**: (`entity`) => `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:745](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L745)

#### Parameters

##### entity

`TItem`

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`onInitNewEntity`](ServiceLookupEditorBase.md#oninitnewentity)

***

### openDialogAsPanel

> **openDialogAsPanel**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:857](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L857)

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`openDialogAsPanel`](ServiceLookupEditorBase.md#opendialogaspanel)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<[`EditorProps`](../type-aliases/EditorProps.md)\<[`ServiceLookupEditorOptions`](../interfaces/ServiceLookupEditorOptions.md)\>\>

Defined in: [src/ui/widgets/widget.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L11)

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`options`](ServiceLookupEditorBase.md#options)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`uniqueName`](ServiceLookupEditorBase.md#uniquename)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/editors/servicelookupeditor.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L188)

#### Overrides

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`[typeInfo]`](ServiceLookupEditorBase.md#typeinfo)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L219)

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`isComponent`](ServiceLookupEditorBase.md#iscomponent)

## Accessors

### cascadeField

#### Get Signature

> **get** **cascadeField**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:618](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L618)

##### Returns

`string`

#### Set Signature

> **set** **cascadeField**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:626](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L626)

##### Parameters

###### value

`string`

##### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`cascadeField`](ServiceLookupEditorBase.md#cascadefield)

***

### cascadeFrom

#### Get Signature

> **get** **cascadeFrom**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:599](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L599)

##### Returns

`string`

#### Set Signature

> **set** **cascadeFrom**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:610](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L610)

##### Parameters

###### value

`string`

##### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`cascadeFrom`](ServiceLookupEditorBase.md#cascadefrom)

***

### cascadeValue

#### Get Signature

> **get** **cascadeValue**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:634](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L634)

##### Returns

`any`

#### Set Signature

> **set** **cascadeValue**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:646](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L646)

##### Parameters

###### value

`any`

##### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`cascadeValue`](ServiceLookupEditorBase.md#cascadevalue)

***

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L59)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`element`](ServiceLookupEditorBase.md#element)

***

### filterField

#### Get Signature

> **get** **filterField**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:654](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L654)

##### Returns

`string`

#### Set Signature

> **set** **filterField**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:662](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L662)

##### Parameters

###### value

`string`

##### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`filterField`](ServiceLookupEditorBase.md#filterfield)

***

### filterValue

#### Get Signature

> **get** **filterValue**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:670](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L670)

##### Returns

`any`

#### Set Signature

> **set** **filterValue**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:682](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L682)

##### Parameters

###### value

`any`

##### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`filterValue`](ServiceLookupEditorBase.md#filtervalue)

***

### itemById

#### Get Signature

> **get** `protected` **itemById**(): `object`

Defined in: [src/ui/editors/comboboxeditor.tsx:272](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L272)

##### Returns

`object`

#### Set Signature

> **set** `protected` **itemById**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:279](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L279)

##### Parameters

###### value

##### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`itemById`](ServiceLookupEditorBase.md#itembyid)

***

### items

#### Get Signature

> **get** **items**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

Defined in: [src/ui/editors/comboboxeditor.tsx:255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L255)

##### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

#### Set Signature

> **set** **items**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:262](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L262)

##### Parameters

###### value

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

##### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`items`](ServiceLookupEditorBase.md#items)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L203)

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`props`](ServiceLookupEditorBase.md#props)

***

### readOnly

#### Get Signature

> **get** **readOnly**(): `boolean`

Defined in: [src/ui/editors/editorwidget.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorwidget.ts#L20)

##### Returns

`boolean`

#### Set Signature

> **set** **readOnly**(`value`): `void`

Defined in: [src/ui/editors/editorwidget.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorwidget.ts#L25)

##### Parameters

###### value

`boolean`

##### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`readOnly`](ServiceLookupEditorBase.md#readonly)

***

### selectedItem

#### Get Signature

> **get** **selectedItem**(): `TItem`

Defined in: [src/ui/editors/comboboxeditor.tsx:495](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L495)

##### Returns

`TItem`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`selectedItem`](ServiceLookupEditorBase.md#selecteditem)

***

### selectedItems

#### Get Signature

> **get** **selectedItems**(): `TItem`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:505](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L505)

##### Returns

`TItem`[]

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`selectedItems`](ServiceLookupEditorBase.md#selecteditems)

***

### text

#### Get Signature

> **get** **text**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:544](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L544)

##### Returns

`string`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`text`](ServiceLookupEditorBase.md#text)

***

### value

#### Get Signature

> **get** **value**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:476](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L476)

##### Returns

`string`

#### Set Signature

> **set** **value**(`v`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:491](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L491)

##### Parameters

###### v

`string`

##### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`value`](ServiceLookupEditorBase.md#value)

***

### values

#### Get Signature

> **get** **values**(): `string`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:524](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L524)

##### Returns

`string`[]

#### Set Signature

> **set** **values**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:532](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L532)

##### Parameters

###### value

`string`[]

##### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`values`](ServiceLookupEditorBase.md#values)

## Methods

### abortPendingQuery()

> `protected` **abortPendingQuery**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L157)

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`abortPendingQuery`](ServiceLookupEditorBase.md#abortpendingquery)

***

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`addCssClass`](ServiceLookupEditorBase.md#addcssclass)

***

### addInplaceCreate()

> `protected` **addInplaceCreate**(`addTitle`, `editTitle`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:311](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L311)

#### Parameters

##### addTitle

`string`

##### editTitle

`string`

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`addInplaceCreate`](ServiceLookupEditorBase.md#addinplacecreate)

***

### addItem()

> **addItem**(`item`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:294](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L294)

#### Parameters

##### item

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`addItem`](ServiceLookupEditorBase.md#additem)

***

### addOption()

> **addOption**(`key`, `text`, `source?`, `disabled?`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:302](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L302)

#### Parameters

##### key

`string`

##### text

`string`

##### source?

`any`

##### disabled?

`boolean`

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`addOption`](ServiceLookupEditorBase.md#addoption)

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

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`addValidationRule`](ServiceLookupEditorBase.md#addvalidationrule)

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

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`addValidationRule`](ServiceLookupEditorBase.md#addvalidationrule)

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

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`afterRender`](ServiceLookupEditorBase.md#afterrender)

***

### allowClear()

> `protected` **allowClear**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L148)

#### Returns

`boolean`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`allowClear`](ServiceLookupEditorBase.md#allowclear)

***

### asyncSearch()

> `protected` **asyncSearch**(`query`): `Promise`\<[`ComboboxSearchResult`](../interfaces/ComboboxSearchResult.md)\<`TItem`\>\>

Defined in: [src/ui/editors/servicelookupeditor.ts:164](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L164)

#### Parameters

##### query

[`ComboboxSearchQuery`](../interfaces/ComboboxSearchQuery.md)

#### Returns

`Promise`\<[`ComboboxSearchResult`](../interfaces/ComboboxSearchResult.md)\<`TItem`\>\>

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`asyncSearch`](ServiceLookupEditorBase.md#asyncsearch)

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

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`byId`](ServiceLookupEditorBase.md#byid)

***

### canSearch()

> `protected` **canSearch**(`byId`): `boolean`

Defined in: [src/ui/editors/servicelookupeditor.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L154)

#### Parameters

##### byId

`boolean`

#### Returns

`boolean`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`canSearch`](ServiceLookupEditorBase.md#cansearch)

***

### cascadeItems()

> `protected` **cascadeItems**(`items`): `TItem`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:686](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L686)

#### Parameters

##### items

`TItem`[]

#### Returns

`TItem`[]

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`cascadeItems`](ServiceLookupEditorBase.md#cascadeitems)

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

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`change`](ServiceLookupEditorBase.md#change)

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

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`changeSelect2`](ServiceLookupEditorBase.md#changeselect2)

***

### clearItems()

> **clearItems**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:286](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L286)

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`clearItems`](ServiceLookupEditorBase.md#clearitems)

***

### createEditDialog()

> `protected` **createEditDialog**(`callback`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:735](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L735)

#### Parameters

##### callback

(`dlg`) => `void`

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`createEditDialog`](ServiceLookupEditorBase.md#createeditdialog)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

#### Returns

`boolean`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`deferRender`](ServiceLookupEditorBase.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L79)

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`destroy`](ServiceLookupEditorBase.md#destroy)

***

### editDialogDataChange()

> `protected` **editDialogDataChange**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:770](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L770)

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`editDialogDataChange`](ServiceLookupEditorBase.md#editdialogdatachange)

***

### emptyItemText()

> `protected` **emptyItemText**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L100)

#### Returns

`string`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`emptyItemText`](ServiceLookupEditorBase.md#emptyitemtext)

***

### filterItems()

> `protected` **filterItems**(`items`): `TItem`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:708](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L708)

#### Parameters

##### items

`TItem`[]

#### Returns

`TItem`[]

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`filterItems`](ServiceLookupEditorBase.md#filteritems)

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

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`findById`](ServiceLookupEditorBase.md#findbyid)

***

### get\_cascadeField()

> `protected` **get\_cascadeField**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:614](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L614)

#### Returns

`string`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`get_cascadeField`](ServiceLookupEditorBase.md#get_cascadefield)

***

### get\_cascadeFrom()

> `protected` **get\_cascadeFrom**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:595](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L595)

#### Returns

`string`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`get_cascadeFrom`](ServiceLookupEditorBase.md#get_cascadefrom)

***

### get\_cascadeValue()

> `protected` **get\_cascadeValue**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:630](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L630)

#### Returns

`any`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`get_cascadeValue`](ServiceLookupEditorBase.md#get_cascadevalue)

***

### get\_delimited()

> **get\_delimited**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:251](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L251)

#### Returns

`boolean`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`get_delimited`](ServiceLookupEditorBase.md#get_delimited)

***

### get\_filterField()

> `protected` **get\_filterField**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:650](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L650)

#### Returns

`string`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`get_filterField`](ServiceLookupEditorBase.md#get_filterfield)

***

### get\_filterValue()

> `protected` **get\_filterValue**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:666](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L666)

#### Returns

`any`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`get_filterValue`](ServiceLookupEditorBase.md#get_filtervalue)

***

### get\_itemByKey()

> `protected` **get\_itemByKey**(): `object`

Defined in: [src/ui/editors/comboboxeditor.tsx:446](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L446)

#### Returns

`object`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`get_itemByKey`](ServiceLookupEditorBase.md#get_itembykey)

***

### get\_items()

> `protected` **get\_items**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

Defined in: [src/ui/editors/comboboxeditor.tsx:442](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L442)

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`get_items`](ServiceLookupEditorBase.md#get_items)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:548](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L548)

#### Returns

`boolean`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`get_readOnly`](ServiceLookupEditorBase.md#get_readonly)

***

### get\_text()

> `protected` **get\_text**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:536](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L536)

#### Returns

`string`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`get_text`](ServiceLookupEditorBase.md#get_text)

***

### get\_value()

> **get\_value**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:472](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L472)

#### Returns

`string`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`get_value`](ServiceLookupEditorBase.md#get_value)

***

### get\_values()

> `protected` **get\_values**(): `string`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:520](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L520)

#### Returns

`string`[]

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`get_values`](ServiceLookupEditorBase.md#get_values)

***

### getCascadeCriteria()

> `protected` **getCascadeCriteria**(): `any`[]

Defined in: [src/ui/editors/servicelookupeditor.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L70)

#### Returns

`any`[]

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getCascadeCriteria`](ServiceLookupEditorBase.md#getcascadecriteria)

***

### getCascadeFromValue()

> `protected` **getCascadeFromValue**(`parent`): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:570](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L570)

#### Parameters

##### parent

[`Widget`](Widget.md)\<`any`\>

#### Returns

`any`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getCascadeFromValue`](ServiceLookupEditorBase.md#getcascadefromvalue)

***

### getComboboxContainer()

> `protected` **getComboboxContainer**(): `HTMLElement`

Defined in: [src/ui/editors/comboboxeditor.tsx:438](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L438)

#### Returns

`HTMLElement`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getComboboxContainer`](ServiceLookupEditorBase.md#getcomboboxcontainer)

***

### getComboboxOptions()

> `protected` **getComboboxOptions**(): [`ComboboxOptions`](../interfaces/ComboboxOptions.md)

Defined in: [src/ui/editors/comboboxeditor.tsx:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L161)

#### Returns

[`ComboboxOptions`](../interfaces/ComboboxOptions.md)

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getComboboxOptions`](ServiceLookupEditorBase.md#getcomboboxoptions)

***

### getCreateSearchChoice()

> **getCreateSearchChoice**(`getName`): (`s`) => `object`

Defined in: [src/ui/editors/comboboxeditor.tsx:373](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L373)

#### Parameters

##### getName

(`z`) => `string`

#### Returns

> (`s`): `object`

##### Parameters

###### s

`string`

##### Returns

`object`

###### id

> **id**: `string`

###### text

> **text**: `string`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getCreateSearchChoice`](ServiceLookupEditorBase.md#getcreatesearchchoice)

***

### getCriteria()

> `protected` **getCriteria**(`query`): `any`[]

Defined in: [src/ui/editors/servicelookupeditor.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L113)

#### Parameters

##### query

[`ComboboxSearchQuery`](../interfaces/ComboboxSearchQuery.md)

#### Returns

`any`[]

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getCriteria`](ServiceLookupEditorBase.md#getcriteria)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

#### Returns

`string`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getCssClass`](ServiceLookupEditorBase.md#getcssclass)

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

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getCustomAttribute`](ServiceLookupEditorBase.md#getcustomattribute)

***

### getDialogTypeKey()

> `protected` **getDialogTypeKey**(): `string`

Defined in: [src/ui/editors/servicelookupeditor.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L25)

#### Returns

`string`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getDialogTypeKey`](ServiceLookupEditorBase.md#getdialogtypekey)

***

### getEditValue()

> **getEditValue**(`property`, `target`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:429](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L429)

#### Parameters

##### property

[`PropertyItem`](../interfaces/PropertyItem.md)

##### target

`any`

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getEditValue`](ServiceLookupEditorBase.md#geteditvalue)

***

### getFilterCriteria()

> `protected` **getFilterCriteria**(): `any`[]

Defined in: [src/ui/editors/servicelookupeditor.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L88)

#### Returns

`any`[]

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getFilterCriteria`](ServiceLookupEditorBase.md#getfiltercriteria)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

#### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getGridField`](ServiceLookupEditorBase.md#getgridfield)

***

### getIdField()

> `protected` **getIdField**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L109)

#### Returns

`any`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getIdField`](ServiceLookupEditorBase.md#getidfield)

***

### getIdListCriteria()

> `protected` **getIdListCriteria**(`idList`): `any`[]

Defined in: [src/ui/editors/servicelookupeditor.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L99)

#### Parameters

##### idList

`any`[]

#### Returns

`any`[]

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getIdListCriteria`](ServiceLookupEditorBase.md#getidlistcriteria)

***

### getIncludeColumns()

> `protected` **getIncludeColumns**(): `string`[]

Defined in: [src/ui/editors/servicelookupeditor.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L52)

#### Returns

`string`[]

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getIncludeColumns`](ServiceLookupEditorBase.md#getincludecolumns)

***

### getListRequest()

> `protected` **getListRequest**(`query`): [`ListRequest`](../interfaces/ListRequest.md)

Defined in: [src/ui/editors/servicelookupeditor.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L119)

#### Parameters

##### query

[`ComboboxSearchQuery`](../interfaces/ComboboxSearchQuery.md)

#### Returns

[`ListRequest`](../interfaces/ListRequest.md)

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getListRequest`](ServiceLookupEditorBase.md#getlistrequest)

***

### getPageSize()

> `protected` **getPageSize**(): `number`

Defined in: [src/ui/editors/comboboxeditor.tsx:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L105)

#### Returns

`number`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getPageSize`](ServiceLookupEditorBase.md#getpagesize)

***

### getService()

> `protected` **getService**(): `string`

Defined in: [src/ui/editors/servicelookupeditor.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L40)

#### Returns

`string`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getService`](ServiceLookupEditorBase.md#getservice)

***

### getServiceCallOptions()

> `protected` **getServiceCallOptions**(`query`): [`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>\>

Defined in: [src/ui/editors/servicelookupeditor.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L141)

#### Parameters

##### query

[`ComboboxSearchQuery`](../interfaces/ComboboxSearchQuery.md)

#### Returns

[`ServiceOptions`](../interfaces/ServiceOptions.md)\<[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>\>

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getServiceCallOptions`](ServiceLookupEditorBase.md#getservicecalloptions)

***

### getServiceUrl()

> `protected` **getServiceUrl**(): `string`

Defined in: [src/ui/editors/servicelookupeditor.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L44)

#### Returns

`string`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getServiceUrl`](ServiceLookupEditorBase.md#getserviceurl)

***

### getSort()

> `protected` **getSort**(): `any`[]

Defined in: [src/ui/editors/servicelookupeditor.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L66)

#### Returns

`any`[]

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getSort`](ServiceLookupEditorBase.md#getsort)

***

### getTextField()

> `protected` **getTextField**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L120)

#### Returns

`any`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getTextField`](ServiceLookupEditorBase.md#gettextfield)

***

### getTypeDelay()

> `protected` **getTypeDelay**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L96)

#### Returns

`any`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getTypeDelay`](ServiceLookupEditorBase.md#gettypedelay)

***

### hasAsyncSource()

> `protected` **hasAsyncSource**(): `boolean`

Defined in: [src/ui/editors/servicelookupeditor.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/servicelookupeditor.ts#L150)

#### Returns

`boolean`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`hasAsyncSource`](ServiceLookupEditorBase.md#hasasyncsource)

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

#### Returns

`this`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`init`](ServiceLookupEditorBase.md#init)

***

### initNewEntity()

> `protected` **initNewEntity**(`entity`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:747](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L747)

#### Parameters

##### entity

`TItem`

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`initNewEntity`](ServiceLookupEditorBase.md#initnewentity)

***

### inplaceCreateClick()

> `protected` **inplaceCreateClick**(`e`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:782](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L782)

#### Parameters

##### e

`Event`

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`inplaceCreateClick`](ServiceLookupEditorBase.md#inplacecreateclick)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L173)

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`internalRenderContents`](ServiceLookupEditorBase.md#internalrendercontents)

***

### isAutoComplete()

> `protected` **isAutoComplete**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:369](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L369)

#### Returns

`boolean`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`isAutoComplete`](ServiceLookupEditorBase.md#isautocomplete)

***

### isMultiple()

> `protected` **isMultiple**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L153)

#### Returns

`boolean`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`isMultiple`](ServiceLookupEditorBase.md#ismultiple)

***

### itemDisabled()

> `protected` **itemDisabled**(`item`): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L131)

#### Parameters

##### item

`TItem`

#### Returns

`boolean`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`itemDisabled`](ServiceLookupEditorBase.md#itemdisabled)

***

### itemId()

> `protected` **itemId**(`item`): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L113)

#### Parameters

##### item

`TItem`

#### Returns

`string`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`itemId`](ServiceLookupEditorBase.md#itemid)

***

### itemText()

> `protected` **itemText**(`item`): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L124)

#### Parameters

##### item

`TItem`

#### Returns

`string`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`itemText`](ServiceLookupEditorBase.md#itemtext)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L190)

#### Returns

`boolean`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`legacyTemplateRender`](ServiceLookupEditorBase.md#legacytemplaterender)

***

### mapItem()

> `protected` **mapItem**(`item`): [`ComboboxItem`](../interfaces/ComboboxItem.md)

Defined in: [src/ui/editors/comboboxeditor.tsx:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L135)

#### Parameters

##### item

`TItem`

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`mapItem`](ServiceLookupEditorBase.md#mapitem)

***

### mapItems()

> `protected` **mapItems**(`items`): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

Defined in: [src/ui/editors/comboboxeditor.tsx:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L144)

#### Parameters

##### items

`TItem`[]

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`mapItems`](ServiceLookupEditorBase.md#mapitems)

***

### openDropdown()

> **openDropdown**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:853](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L853)

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`openDropdown`](ServiceLookupEditorBase.md#opendropdown)

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

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`render`](ServiceLookupEditorBase.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

#### Returns

`any`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`renderContents`](ServiceLookupEditorBase.md#rendercontents)

***

### set\_cascadeField()

> `protected` **set\_cascadeField**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:622](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L622)

#### Parameters

##### value

`string`

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`set_cascadeField`](ServiceLookupEditorBase.md#set_cascadefield)

***

### set\_cascadeFrom()

> `protected` **set\_cascadeFrom**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:603](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L603)

#### Parameters

##### value

`string`

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`set_cascadeFrom`](ServiceLookupEditorBase.md#set_cascadefrom)

***

### set\_cascadeValue()

> `protected` **set\_cascadeValue**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:638](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L638)

#### Parameters

##### value

`any`

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`set_cascadeValue`](ServiceLookupEditorBase.md#set_cascadevalue)

***

### set\_filterField()

> `protected` **set\_filterField**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:658](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L658)

#### Parameters

##### value

`string`

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`set_filterField`](ServiceLookupEditorBase.md#set_filterfield)

***

### set\_filterValue()

> `protected` **set\_filterValue**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:674](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L674)

#### Parameters

##### value

`any`

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`set_filterValue`](ServiceLookupEditorBase.md#set_filtervalue)

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:563](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L563)

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`set_readOnly`](ServiceLookupEditorBase.md#set_readonly)

***

### set\_value()

> **set\_value**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:480](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L480)

#### Parameters

##### value

`string`

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`set_value`](ServiceLookupEditorBase.md#set_value)

***

### set\_values()

> `protected` **set\_values**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:528](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L528)

#### Parameters

##### value

`string`[]

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`set_values`](ServiceLookupEditorBase.md#set_values)

***

### setCascadeFrom()

> `protected` **setCascadeFrom**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:576](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L576)

#### Parameters

##### value

`string`

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`setCascadeFrom`](ServiceLookupEditorBase.md#setcascadefrom)

***

### setEditDialogReadOnly()

> `protected` **setEditDialogReadOnly**(`dialog`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:761](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L761)

#### Parameters

##### dialog

`any`

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`setEditDialogReadOnly`](ServiceLookupEditorBase.md#seteditdialogreadonly)

***

### setEditValue()

> **setEditValue**(`source`, `property`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:419](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L419)

#### Parameters

##### source

`any`

##### property

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`setEditValue`](ServiceLookupEditorBase.md#seteditvalue)

***

### setTermOnNewEntity()

> `protected` **setTermOnNewEntity**(`entity`, `term`, `dialog`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:773](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L773)

#### Parameters

##### entity

`TItem`

##### term

`string`

##### dialog

`any`

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`setTermOnNewEntity`](ServiceLookupEditorBase.md#settermonnewentity)

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

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`syncOrAsyncThen`](ServiceLookupEditorBase.md#syncorasyncthen)

***

### updateItems()

> `protected` **updateItems**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:724](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L724)

#### Returns

`void`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`updateItems`](ServiceLookupEditorBase.md#updateitems)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L214)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`useIdPrefix`](ServiceLookupEditorBase.md#useidprefix)

***

### useInplaceAdd()

> `protected` **useInplaceAdd**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:362](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L362)

#### Returns

`boolean`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`useInplaceAdd`](ServiceLookupEditorBase.md#useinplaceadd)

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

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`create`](ServiceLookupEditorBase.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLInputElement`

Defined in: [src/ui/editors/comboboxeditor.tsx:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L43)

#### Returns

`HTMLInputElement`

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`createDefaultElement`](ServiceLookupEditorBase.md#createdefaultelement)

***

### filterByText()

> `static` **filterByText**\<`TItem`\>(`items`, `getText`, `term`): `TItem`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:450](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L450)

#### Type Parameters

##### TItem

`TItem`

#### Parameters

##### items

`TItem`[]

##### getText

(`item`) => `string`

##### term

`string`

#### Returns

`TItem`[]

#### Inherited from

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`filterByText`](ServiceLookupEditorBase.md#filterbytext)

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

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`getWidgetName`](ServiceLookupEditorBase.md#getwidgetname)

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

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`registerClass`](ServiceLookupEditorBase.md#registerclass)

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

[`ServiceLookupEditorBase`](ServiceLookupEditorBase.md).[`registerEditor`](ServiceLookupEditorBase.md#registereditor)
