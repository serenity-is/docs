[@serenity-is/corelib](../README.md) / LookupEditor

# Class: LookupEditor\<P\>

Defined in: [src/ui/editors/lookupeditor.ts:145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L145)

## Extends

- [`LookupEditorBase`](LookupEditorBase.md)\<`P`, \{ \}\>

## Type Parameters

### P

`P` *extends* [`LookupEditorOptions`](../interfaces/LookupEditorOptions.md) = [`LookupEditorOptions`](../interfaces/LookupEditorOptions.md)

## Constructors

### Constructor

> **new LookupEditor**\<`P`\>(`props`): `LookupEditor`\<`P`\>

Defined in: [src/ui/editors/lookupeditor.ts:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L149)

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

#### Returns

`LookupEditor`\<`P`\>

#### Overrides

[`LookupEditorBase`](LookupEditorBase.md).[`constructor`](LookupEditorBase.md#constructor)

## Properties

### cascadeLink

> `protected` **cascadeLink**: [`CascadedWidgetLink`](CascadedWidgetLink.md)\<[`Widget`](Widget.md)\<`any`\>\>

Defined in: [src/ui/editors/comboboxeditor.tsx:574](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L574)

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`cascadeLink`](LookupEditorBase.md#cascadelink)

***

### domNode

> `readonly` **domNode**: `HTMLInputElement`

Defined in: [src/ui/editors/comboboxeditor.tsx:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L44)

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`domNode`](LookupEditorBase.md#domnode)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L13)

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`idPrefix`](LookupEditorBase.md#idprefix)

***

### lastCreateTerm

> `protected` **lastCreateTerm**: `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L49)

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`lastCreateTerm`](LookupEditorBase.md#lastcreateterm)

***

### lookup

> `protected` **lookup**: [`Lookup`](Lookup.md)\<\{ \}\>

Defined in: [src/ui/editors/lookupeditor.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L60)

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`lookup`](LookupEditorBase.md#lookup)

***

### onInitNewEntity()

> **onInitNewEntity**: (`entity`) => `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:745](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L745)

#### Parameters

##### entity

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`onInitNewEntity`](LookupEditorBase.md#oninitnewentity)

***

### openDialogAsPanel

> **openDialogAsPanel**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:857](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L857)

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`openDialogAsPanel`](LookupEditorBase.md#opendialogaspanel)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>\>

Defined in: [src/ui/widgets/widget.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L11)

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`options`](LookupEditorBase.md#options)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`uniqueName`](LookupEditorBase.md#uniquename)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/editors/lookupeditor.ts:147](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L147)

#### Overrides

[`LookupEditorBase`](LookupEditorBase.md).[`[typeInfo]`](LookupEditorBase.md#typeinfo)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L219)

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`isComponent`](LookupEditorBase.md#iscomponent)

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

[`LookupEditorBase`](LookupEditorBase.md).[`cascadeField`](LookupEditorBase.md#cascadefield)

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

[`LookupEditorBase`](LookupEditorBase.md).[`cascadeFrom`](LookupEditorBase.md#cascadefrom)

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

[`LookupEditorBase`](LookupEditorBase.md).[`cascadeValue`](LookupEditorBase.md#cascadevalue)

***

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L59)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`element`](LookupEditorBase.md#element)

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

[`LookupEditorBase`](LookupEditorBase.md).[`filterField`](LookupEditorBase.md#filterfield)

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

[`LookupEditorBase`](LookupEditorBase.md).[`filterValue`](LookupEditorBase.md#filtervalue)

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

[`LookupEditorBase`](LookupEditorBase.md).[`itemById`](LookupEditorBase.md#itembyid)

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

[`LookupEditorBase`](LookupEditorBase.md).[`items`](LookupEditorBase.md#items)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L203)

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`props`](LookupEditorBase.md#props)

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

[`LookupEditorBase`](LookupEditorBase.md).[`readOnly`](LookupEditorBase.md#readonly)

***

### selectedItem

#### Get Signature

> **get** **selectedItem**(): `TItem`

Defined in: [src/ui/editors/comboboxeditor.tsx:495](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L495)

##### Returns

`TItem`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`selectedItem`](LookupEditorBase.md#selecteditem)

***

### selectedItems

#### Get Signature

> **get** **selectedItems**(): `TItem`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:505](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L505)

##### Returns

`TItem`[]

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`selectedItems`](LookupEditorBase.md#selecteditems)

***

### text

#### Get Signature

> **get** **text**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:544](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L544)

##### Returns

`string`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`text`](LookupEditorBase.md#text)

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

[`LookupEditorBase`](LookupEditorBase.md).[`value`](LookupEditorBase.md#value)

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

[`LookupEditorBase`](LookupEditorBase.md).[`values`](LookupEditorBase.md#values)

## Methods

### abortPendingQuery()

> `protected` **abortPendingQuery**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L157)

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`abortPendingQuery`](LookupEditorBase.md#abortpendingquery)

***

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`addCssClass`](LookupEditorBase.md#addcssclass)

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

[`LookupEditorBase`](LookupEditorBase.md).[`addInplaceCreate`](LookupEditorBase.md#addinplacecreate)

***

### addItem()

> **addItem**(`item`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:294](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L294)

#### Parameters

##### item

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<\{ \}\>

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`addItem`](LookupEditorBase.md#additem)

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

[`LookupEditorBase`](LookupEditorBase.md).[`addOption`](LookupEditorBase.md#addoption)

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

[`LookupEditorBase`](LookupEditorBase.md).[`addValidationRule`](LookupEditorBase.md#addvalidationrule)

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

[`LookupEditorBase`](LookupEditorBase.md).[`addValidationRule`](LookupEditorBase.md#addvalidationrule)

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

[`LookupEditorBase`](LookupEditorBase.md).[`afterRender`](LookupEditorBase.md#afterrender)

***

### allowClear()

> `protected` **allowClear**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L148)

#### Returns

`boolean`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`allowClear`](LookupEditorBase.md#allowclear)

***

### asyncSearch()

> `protected` **asyncSearch**(`query`): `Promise`\<[`ComboboxSearchResult`](../interfaces/ComboboxSearchResult.md)\<\{ \}\>\>

Defined in: [src/ui/editors/lookupeditor.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L110)

#### Parameters

##### query

[`ComboboxSearchQuery`](../interfaces/ComboboxSearchQuery.md)

#### Returns

`Promise`\<[`ComboboxSearchResult`](../interfaces/ComboboxSearchResult.md)\<\{ \}\>\>

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`asyncSearch`](LookupEditorBase.md#asyncsearch)

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

[`LookupEditorBase`](LookupEditorBase.md).[`byId`](LookupEditorBase.md#byid)

***

### cascadeItems()

> `protected` **cascadeItems**(`items`): `object`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:686](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L686)

#### Parameters

##### items

`object`[]

#### Returns

`object`[]

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`cascadeItems`](LookupEditorBase.md#cascadeitems)

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

[`LookupEditorBase`](LookupEditorBase.md).[`change`](LookupEditorBase.md#change)

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

[`LookupEditorBase`](LookupEditorBase.md).[`changeSelect2`](LookupEditorBase.md#changeselect2)

***

### clearItems()

> **clearItems**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:286](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L286)

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`clearItems`](LookupEditorBase.md#clearitems)

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

[`LookupEditorBase`](LookupEditorBase.md).[`createEditDialog`](LookupEditorBase.md#createeditdialog)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

#### Returns

`boolean`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`deferRender`](LookupEditorBase.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/editors/lookupeditor.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L32)

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`destroy`](LookupEditorBase.md#destroy)

***

### editDialogDataChange()

> `protected` **editDialogDataChange**(): `void`

Defined in: [src/ui/editors/lookupeditor.ts:140](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L140)

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`editDialogDataChange`](LookupEditorBase.md#editdialogdatachange)

***

### emptyItemText()

> `protected` **emptyItemText**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L100)

#### Returns

`string`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`emptyItemText`](LookupEditorBase.md#emptyitemtext)

***

### filterItems()

> `protected` **filterItems**(`items`): `object`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:708](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L708)

#### Parameters

##### items

`object`[]

#### Returns

`object`[]

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`filterItems`](LookupEditorBase.md#filteritems)

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

[`LookupEditorBase`](LookupEditorBase.md).[`findById`](LookupEditorBase.md#findbyid)

***

### get\_cascadeField()

> `protected` **get\_cascadeField**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:614](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L614)

#### Returns

`string`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_cascadeField`](LookupEditorBase.md#get_cascadefield)

***

### get\_cascadeFrom()

> `protected` **get\_cascadeFrom**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:595](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L595)

#### Returns

`string`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_cascadeFrom`](LookupEditorBase.md#get_cascadefrom)

***

### get\_cascadeValue()

> `protected` **get\_cascadeValue**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:630](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L630)

#### Returns

`any`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_cascadeValue`](LookupEditorBase.md#get_cascadevalue)

***

### get\_delimited()

> **get\_delimited**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:251](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L251)

#### Returns

`boolean`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_delimited`](LookupEditorBase.md#get_delimited)

***

### get\_filterField()

> `protected` **get\_filterField**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:650](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L650)

#### Returns

`string`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_filterField`](LookupEditorBase.md#get_filterfield)

***

### get\_filterValue()

> `protected` **get\_filterValue**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:666](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L666)

#### Returns

`any`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_filterValue`](LookupEditorBase.md#get_filtervalue)

***

### get\_itemByKey()

> `protected` **get\_itemByKey**(): `object`

Defined in: [src/ui/editors/comboboxeditor.tsx:446](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L446)

#### Returns

`object`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_itemByKey`](LookupEditorBase.md#get_itembykey)

***

### get\_items()

> `protected` **get\_items**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<\{ \}\>[]

Defined in: [src/ui/editors/comboboxeditor.tsx:442](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L442)

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<\{ \}\>[]

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_items`](LookupEditorBase.md#get_items)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:548](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L548)

#### Returns

`boolean`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_readOnly`](LookupEditorBase.md#get_readonly)

***

### get\_text()

> `protected` **get\_text**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:536](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L536)

#### Returns

`string`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_text`](LookupEditorBase.md#get_text)

***

### get\_value()

> **get\_value**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:472](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L472)

#### Returns

`string`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_value`](LookupEditorBase.md#get_value)

***

### get\_values()

> `protected` **get\_values**(): `string`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:520](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L520)

#### Returns

`string`[]

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_values`](LookupEditorBase.md#get_values)

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

[`LookupEditorBase`](LookupEditorBase.md).[`getCascadeFromValue`](LookupEditorBase.md#getcascadefromvalue)

***

### getComboboxContainer()

> `protected` **getComboboxContainer**(): `HTMLElement`

Defined in: [src/ui/editors/comboboxeditor.tsx:438](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L438)

#### Returns

`HTMLElement`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getComboboxContainer`](LookupEditorBase.md#getcomboboxcontainer)

***

### getComboboxOptions()

> `protected` **getComboboxOptions**(): [`ComboboxOptions`](../interfaces/ComboboxOptions.md)

Defined in: [src/ui/editors/comboboxeditor.tsx:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L161)

#### Returns

[`ComboboxOptions`](../interfaces/ComboboxOptions.md)

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getComboboxOptions`](LookupEditorBase.md#getcomboboxoptions)

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

[`LookupEditorBase`](LookupEditorBase.md).[`getCreateSearchChoice`](LookupEditorBase.md#getcreatesearchchoice)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

#### Returns

`string`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getCssClass`](LookupEditorBase.md#getcssclass)

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

[`LookupEditorBase`](LookupEditorBase.md).[`getCustomAttribute`](LookupEditorBase.md#getcustomattribute)

***

### getDialogTypeKey()

> `protected` **getDialogTypeKey**(): `string`

Defined in: [src/ui/editors/lookupeditor.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L128)

#### Returns

`string`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getDialogTypeKey`](LookupEditorBase.md#getdialogtypekey)

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

[`LookupEditorBase`](LookupEditorBase.md).[`getEditValue`](LookupEditorBase.md#geteditvalue)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

#### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getGridField`](LookupEditorBase.md#getgridfield)

***

### getIdField()

> `protected` **getIdField**(): `any`

Defined in: [src/ui/editors/lookupeditor.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L74)

#### Returns

`any`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getIdField`](LookupEditorBase.md#getidfield)

***

### getItemDisabled()

> `protected` **getItemDisabled**(`item`, `lookup`): `boolean`

Defined in: [src/ui/editors/lookupeditor.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L95)

#### Parameters

##### item

##### lookup

[`Lookup`](Lookup.md)\<\{ \}\>

#### Returns

`boolean`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getItemDisabled`](LookupEditorBase.md#getitemdisabled)

***

### getItems()

> `protected` **getItems**(`lookup`): `object`[]

Defined in: [src/ui/editors/lookupeditor.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L70)

#### Parameters

##### lookup

[`Lookup`](Lookup.md)\<\{ \}\>

#### Returns

`object`[]

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getItems`](LookupEditorBase.md#getitems)

***

### getItemText()

> `protected` **getItemText**(`item`, `lookup`): `any`

Defined in: [src/ui/editors/lookupeditor.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L78)

#### Parameters

##### item

##### lookup

[`Lookup`](Lookup.md)\<\{ \}\>

#### Returns

`any`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getItemText`](LookupEditorBase.md#getitemtext)

***

### getLookup()

> `protected` **getLookup**(): [`Lookup`](Lookup.md)\<\{ \}\>

Defined in: [src/ui/editors/lookupeditor.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L66)

#### Returns

[`Lookup`](Lookup.md)\<\{ \}\>

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getLookup`](LookupEditorBase.md#getlookup)

***

### getLookupAsync()

> `protected` **getLookupAsync**(): `PromiseLike`\<[`Lookup`](Lookup.md)\<\{ \}\>\>

Defined in: [src/ui/editors/lookupeditor.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L62)

#### Returns

`PromiseLike`\<[`Lookup`](Lookup.md)\<\{ \}\>\>

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getLookupAsync`](LookupEditorBase.md#getlookupasync)

***

### getLookupKey()

> `protected` **getLookupKey**(): `string`

Defined in: [src/ui/editors/lookupeditor.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L41)

#### Returns

`string`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getLookupKey`](LookupEditorBase.md#getlookupkey)

***

### getPageSize()

> `protected` **getPageSize**(): `number`

Defined in: [src/ui/editors/comboboxeditor.tsx:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L105)

#### Returns

`number`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getPageSize`](LookupEditorBase.md#getpagesize)

***

### getTextField()

> `protected` **getTextField**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L120)

#### Returns

`any`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getTextField`](LookupEditorBase.md#gettextfield)

***

### getTypeDelay()

> `protected` **getTypeDelay**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L96)

#### Returns

`any`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getTypeDelay`](LookupEditorBase.md#gettypedelay)

***

### hasAsyncSource()

> **hasAsyncSource**(): `boolean`

Defined in: [src/ui/editors/lookupeditor.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L28)

#### Returns

`boolean`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`hasAsyncSource`](LookupEditorBase.md#hasasyncsource)

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

#### Returns

`this`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`init`](LookupEditorBase.md#init)

***

### initNewEntity()

> `protected` **initNewEntity**(`entity`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:747](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L747)

#### Parameters

##### entity

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`initNewEntity`](LookupEditorBase.md#initnewentity)

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

[`LookupEditorBase`](LookupEditorBase.md).[`inplaceCreateClick`](LookupEditorBase.md#inplacecreateclick)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L173)

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`internalRenderContents`](LookupEditorBase.md#internalrendercontents)

***

### isAutoComplete()

> `protected` **isAutoComplete**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:369](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L369)

#### Returns

`boolean`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`isAutoComplete`](LookupEditorBase.md#isautocomplete)

***

### isMultiple()

> `protected` **isMultiple**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L153)

#### Returns

`boolean`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`isMultiple`](LookupEditorBase.md#ismultiple)

***

### itemDisabled()

> `protected` **itemDisabled**(`item`): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L131)

#### Parameters

##### item

#### Returns

`boolean`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`itemDisabled`](LookupEditorBase.md#itemdisabled)

***

### itemId()

> `protected` **itemId**(`item`): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L113)

#### Parameters

##### item

#### Returns

`string`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`itemId`](LookupEditorBase.md#itemid)

***

### itemText()

> `protected` **itemText**(`item`): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L124)

#### Parameters

##### item

#### Returns

`string`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`itemText`](LookupEditorBase.md#itemtext)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L190)

#### Returns

`boolean`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`legacyTemplateRender`](LookupEditorBase.md#legacytemplaterender)

***

### mapItem()

> `protected` **mapItem**(`item`): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<\{ \}\>

Defined in: [src/ui/editors/lookupeditor.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L86)

#### Parameters

##### item

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<\{ \}\>

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`mapItem`](LookupEditorBase.md#mapitem)

***

### mapItems()

> `protected` **mapItems**(`items`): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

Defined in: [src/ui/editors/comboboxeditor.tsx:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L144)

#### Parameters

##### items

`object`[]

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`mapItems`](LookupEditorBase.md#mapitems)

***

### openDropdown()

> **openDropdown**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:853](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L853)

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`openDropdown`](LookupEditorBase.md#opendropdown)

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

[`LookupEditorBase`](LookupEditorBase.md).[`render`](LookupEditorBase.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

#### Returns

`any`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`renderContents`](LookupEditorBase.md#rendercontents)

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

[`LookupEditorBase`](LookupEditorBase.md).[`set_cascadeField`](LookupEditorBase.md#set_cascadefield)

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

[`LookupEditorBase`](LookupEditorBase.md).[`set_cascadeFrom`](LookupEditorBase.md#set_cascadefrom)

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

[`LookupEditorBase`](LookupEditorBase.md).[`set_cascadeValue`](LookupEditorBase.md#set_cascadevalue)

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

[`LookupEditorBase`](LookupEditorBase.md).[`set_filterField`](LookupEditorBase.md#set_filterfield)

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

[`LookupEditorBase`](LookupEditorBase.md).[`set_filterValue`](LookupEditorBase.md#set_filtervalue)

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

[`LookupEditorBase`](LookupEditorBase.md).[`set_readOnly`](LookupEditorBase.md#set_readonly)

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

[`LookupEditorBase`](LookupEditorBase.md).[`set_value`](LookupEditorBase.md#set_value)

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

[`LookupEditorBase`](LookupEditorBase.md).[`set_values`](LookupEditorBase.md#set_values)

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

[`LookupEditorBase`](LookupEditorBase.md).[`setCascadeFrom`](LookupEditorBase.md#setcascadefrom)

***

### setCreateTermOnNewEntity()

> `protected` **setCreateTermOnNewEntity**(`entity`, `term`): `void`

Defined in: [src/ui/editors/lookupeditor.ts:136](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L136)

#### Parameters

##### entity

##### term

`string`

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`setCreateTermOnNewEntity`](LookupEditorBase.md#setcreatetermonnewentity)

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

[`LookupEditorBase`](LookupEditorBase.md).[`setEditDialogReadOnly`](LookupEditorBase.md#seteditdialogreadonly)

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

[`LookupEditorBase`](LookupEditorBase.md).[`setEditValue`](LookupEditorBase.md#seteditvalue)

***

### setTermOnNewEntity()

> `protected` **setTermOnNewEntity**(`entity`, `term`, `dialog`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:773](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L773)

#### Parameters

##### entity

##### term

`string`

##### dialog

`any`

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`setTermOnNewEntity`](LookupEditorBase.md#settermonnewentity)

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

[`LookupEditorBase`](LookupEditorBase.md).[`syncOrAsyncThen`](LookupEditorBase.md#syncorasyncthen)

***

### updateItems()

> **updateItems**(): `void`

Defined in: [src/ui/editors/lookupeditor.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L99)

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`updateItems`](LookupEditorBase.md#updateitems)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L214)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`useIdPrefix`](LookupEditorBase.md#useidprefix)

***

### useInplaceAdd()

> `protected` **useInplaceAdd**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:362](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L362)

#### Returns

`boolean`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`useInplaceAdd`](LookupEditorBase.md#useinplaceadd)

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

[`LookupEditorBase`](LookupEditorBase.md).[`create`](LookupEditorBase.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLInputElement`

Defined in: [src/ui/editors/comboboxeditor.tsx:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L43)

#### Returns

`HTMLInputElement`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`createDefaultElement`](LookupEditorBase.md#createdefaultelement)

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

[`LookupEditorBase`](LookupEditorBase.md).[`filterByText`](LookupEditorBase.md#filterbytext)

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

[`LookupEditorBase`](LookupEditorBase.md).[`getWidgetName`](LookupEditorBase.md#getwidgetname)

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

[`LookupEditorBase`](LookupEditorBase.md).[`registerClass`](LookupEditorBase.md#registerclass)

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

[`LookupEditorBase`](LookupEditorBase.md).[`registerEditor`](LookupEditorBase.md#registereditor)
