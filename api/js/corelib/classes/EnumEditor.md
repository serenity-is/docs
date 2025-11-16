[corelib](../README.md) / EnumEditor

# Class: EnumEditor\<P\>

Defined in: [src/ui/editors/enumeditor.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/enumeditor.ts#L12)

## Extends

- [`ComboboxEditor`](ComboboxEditor.md)\<`P`, [`ComboboxItem`](../interfaces/ComboboxItem.md)\>

## Type Parameters

### P

`P` *extends* [`EnumEditorOptions`](../interfaces/EnumEditorOptions.md) = [`EnumEditorOptions`](../interfaces/EnumEditorOptions.md)

## Constructors

### Constructor

> **new EnumEditor**\<`P`\>(`props`): `EnumEditor`\<`P`\>

Defined in: [src/ui/editors/enumeditor.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/enumeditor.ts#L15)

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

#### Returns

`EnumEditor`\<`P`\>

#### Overrides

[`ComboboxEditor`](ComboboxEditor.md).[`constructor`](ComboboxEditor.md#constructor)

## Properties

### cascadeLink

> `protected` **cascadeLink**: [`CascadedWidgetLink`](CascadedWidgetLink.md)\<[`Widget`](Widget.md)\<`any`\>\>

Defined in: [src/ui/editors/comboboxeditor.tsx:574](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L574)

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`cascadeLink`](ComboboxEditor.md#cascadelink)

***

### domNode

> `readonly` **domNode**: `HTMLInputElement`

Defined in: [src/ui/editors/comboboxeditor.tsx:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L44)

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`domNode`](ComboboxEditor.md#domnode)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L13)

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`idPrefix`](ComboboxEditor.md#idprefix)

***

### lastCreateTerm

> `protected` **lastCreateTerm**: `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L49)

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`lastCreateTerm`](ComboboxEditor.md#lastcreateterm)

***

### onInitNewEntity()

> **onInitNewEntity**: (`entity`) => `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:745](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L745)

#### Parameters

##### entity

[`ComboboxItem`](../interfaces/ComboboxItem.md)

#### Returns

`void`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`onInitNewEntity`](ComboboxEditor.md#oninitnewentity)

***

### openDialogAsPanel

> **openDialogAsPanel**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:857](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L857)

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`openDialogAsPanel`](ComboboxEditor.md#opendialogaspanel)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>\>

Defined in: [src/ui/widgets/widget.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L11)

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`options`](ComboboxEditor.md#options)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L12)

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`uniqueName`](ComboboxEditor.md#uniquename)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/editors/enumeditor.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/enumeditor.ts#L13)

#### Overrides

[`ComboboxEditor`](ComboboxEditor.md).[`[typeInfo]`](ComboboxEditor.md#typeinfo)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L219)

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`isComponent`](ComboboxEditor.md#iscomponent)

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

[`ComboboxEditor`](ComboboxEditor.md).[`cascadeField`](ComboboxEditor.md#cascadefield)

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

[`ComboboxEditor`](ComboboxEditor.md).[`cascadeFrom`](ComboboxEditor.md#cascadefrom)

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

[`ComboboxEditor`](ComboboxEditor.md).[`cascadeValue`](ComboboxEditor.md#cascadevalue)

***

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L59)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`element`](ComboboxEditor.md#element)

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

[`ComboboxEditor`](ComboboxEditor.md).[`filterField`](ComboboxEditor.md#filterfield)

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

[`ComboboxEditor`](ComboboxEditor.md).[`filterValue`](ComboboxEditor.md#filtervalue)

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

[`ComboboxEditor`](ComboboxEditor.md).[`itemById`](ComboboxEditor.md#itembyid)

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

[`ComboboxEditor`](ComboboxEditor.md).[`items`](ComboboxEditor.md#items)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L203)

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`props`](ComboboxEditor.md#props)

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

[`ComboboxEditor`](ComboboxEditor.md).[`readOnly`](ComboboxEditor.md#readonly)

***

### selectedItem

#### Get Signature

> **get** **selectedItem**(): `TItem`

Defined in: [src/ui/editors/comboboxeditor.tsx:495](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L495)

##### Returns

`TItem`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`selectedItem`](ComboboxEditor.md#selecteditem)

***

### selectedItems

#### Get Signature

> **get** **selectedItems**(): `TItem`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:505](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L505)

##### Returns

`TItem`[]

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`selectedItems`](ComboboxEditor.md#selecteditems)

***

### text

#### Get Signature

> **get** **text**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:544](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L544)

##### Returns

`string`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`text`](ComboboxEditor.md#text)

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

[`ComboboxEditor`](ComboboxEditor.md).[`value`](ComboboxEditor.md#value)

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

[`ComboboxEditor`](ComboboxEditor.md).[`values`](ComboboxEditor.md#values)

## Methods

### abortPendingQuery()

> `protected` **abortPendingQuery**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L157)

#### Returns

`void`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`abortPendingQuery`](ComboboxEditor.md#abortpendingquery)

***

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

#### Returns

`void`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`addCssClass`](ComboboxEditor.md#addcssclass)

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

[`ComboboxEditor`](ComboboxEditor.md).[`addInplaceCreate`](ComboboxEditor.md#addinplacecreate)

***

### addItem()

> **addItem**(`item`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:294](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L294)

#### Parameters

##### item

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>\>

#### Returns

`void`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`addItem`](ComboboxEditor.md#additem)

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

[`ComboboxEditor`](ComboboxEditor.md).[`addOption`](ComboboxEditor.md#addoption)

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

[`ComboboxEditor`](ComboboxEditor.md).[`addValidationRule`](ComboboxEditor.md#addvalidationrule)

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

[`ComboboxEditor`](ComboboxEditor.md).[`addValidationRule`](ComboboxEditor.md#addvalidationrule)

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

[`ComboboxEditor`](ComboboxEditor.md).[`afterRender`](ComboboxEditor.md#afterrender)

***

### allowClear()

> `protected` **allowClear**(): `boolean`

Defined in: [src/ui/editors/enumeditor.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/enumeditor.ts#L48)

#### Returns

`boolean`

#### Overrides

[`ComboboxEditor`](ComboboxEditor.md).[`allowClear`](ComboboxEditor.md#allowclear)

***

### asyncSearch()

> `protected` **asyncSearch**(`query`): `PromiseLike`\<[`ComboboxSearchResult`](../interfaces/ComboboxSearchResult.md)\<[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>\>\>

Defined in: [src/ui/editors/comboboxeditor.tsx:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L89)

#### Parameters

##### query

[`ComboboxSearchQuery`](../interfaces/ComboboxSearchQuery.md)

#### Returns

`PromiseLike`\<[`ComboboxSearchResult`](../interfaces/ComboboxSearchResult.md)\<[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>\>\>

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`asyncSearch`](ComboboxEditor.md#asyncsearch)

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

[`ComboboxEditor`](ComboboxEditor.md).[`byId`](ComboboxEditor.md#byid)

***

### cascadeItems()

> `protected` **cascadeItems**(`items`): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

Defined in: [src/ui/editors/comboboxeditor.tsx:686](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L686)

#### Parameters

##### items

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`cascadeItems`](ComboboxEditor.md#cascadeitems)

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

[`ComboboxEditor`](ComboboxEditor.md).[`change`](ComboboxEditor.md#change)

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

[`ComboboxEditor`](ComboboxEditor.md).[`changeSelect2`](ComboboxEditor.md#changeselect2)

***

### clearItems()

> **clearItems**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:286](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L286)

#### Returns

`void`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`clearItems`](ComboboxEditor.md#clearitems)

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

[`ComboboxEditor`](ComboboxEditor.md).[`createEditDialog`](ComboboxEditor.md#createeditdialog)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

#### Returns

`boolean`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`deferRender`](ComboboxEditor.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L79)

#### Returns

`void`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`destroy`](ComboboxEditor.md#destroy)

***

### editDialogDataChange()

> `protected` **editDialogDataChange**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:770](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L770)

#### Returns

`void`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`editDialogDataChange`](ComboboxEditor.md#editdialogdatachange)

***

### emptyItemText()

> `protected` **emptyItemText**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L100)

#### Returns

`string`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`emptyItemText`](ComboboxEditor.md#emptyitemtext)

***

### filterItems()

> `protected` **filterItems**(`items`): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

Defined in: [src/ui/editors/comboboxeditor.tsx:708](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L708)

#### Parameters

##### items

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`filterItems`](ComboboxEditor.md#filteritems)

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

[`ComboboxEditor`](ComboboxEditor.md).[`findById`](ComboboxEditor.md#findbyid)

***

### get\_cascadeField()

> `protected` **get\_cascadeField**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:614](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L614)

#### Returns

`string`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`get_cascadeField`](ComboboxEditor.md#get_cascadefield)

***

### get\_cascadeFrom()

> `protected` **get\_cascadeFrom**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:595](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L595)

#### Returns

`string`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`get_cascadeFrom`](ComboboxEditor.md#get_cascadefrom)

***

### get\_cascadeValue()

> `protected` **get\_cascadeValue**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:630](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L630)

#### Returns

`any`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`get_cascadeValue`](ComboboxEditor.md#get_cascadevalue)

***

### get\_delimited()

> **get\_delimited**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:251](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L251)

#### Returns

`boolean`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`get_delimited`](ComboboxEditor.md#get_delimited)

***

### get\_filterField()

> `protected` **get\_filterField**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:650](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L650)

#### Returns

`string`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`get_filterField`](ComboboxEditor.md#get_filterfield)

***

### get\_filterValue()

> `protected` **get\_filterValue**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:666](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L666)

#### Returns

`any`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`get_filterValue`](ComboboxEditor.md#get_filtervalue)

***

### get\_itemByKey()

> `protected` **get\_itemByKey**(): `object`

Defined in: [src/ui/editors/comboboxeditor.tsx:446](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L446)

#### Returns

`object`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`get_itemByKey`](ComboboxEditor.md#get_itembykey)

***

### get\_items()

> `protected` **get\_items**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>\>[]

Defined in: [src/ui/editors/comboboxeditor.tsx:442](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L442)

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>\>[]

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`get_items`](ComboboxEditor.md#get_items)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:548](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L548)

#### Returns

`boolean`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`get_readOnly`](ComboboxEditor.md#get_readonly)

***

### get\_text()

> `protected` **get\_text**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:536](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L536)

#### Returns

`string`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`get_text`](ComboboxEditor.md#get_text)

***

### get\_value()

> **get\_value**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:472](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L472)

#### Returns

`string`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`get_value`](ComboboxEditor.md#get_value)

***

### get\_values()

> `protected` **get\_values**(): `string`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:520](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L520)

#### Returns

`string`[]

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`get_values`](ComboboxEditor.md#get_values)

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

[`ComboboxEditor`](ComboboxEditor.md).[`getCascadeFromValue`](ComboboxEditor.md#getcascadefromvalue)

***

### getComboboxContainer()

> `protected` **getComboboxContainer**(): `HTMLElement`

Defined in: [src/ui/editors/comboboxeditor.tsx:438](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L438)

#### Returns

`HTMLElement`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`getComboboxContainer`](ComboboxEditor.md#getcomboboxcontainer)

***

### getComboboxOptions()

> `protected` **getComboboxOptions**(): [`ComboboxOptions`](../interfaces/ComboboxOptions.md)

Defined in: [src/ui/editors/comboboxeditor.tsx:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L161)

#### Returns

[`ComboboxOptions`](../interfaces/ComboboxOptions.md)

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`getComboboxOptions`](ComboboxEditor.md#getcomboboxoptions)

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

[`ComboboxEditor`](ComboboxEditor.md).[`getCreateSearchChoice`](ComboboxEditor.md#getcreatesearchchoice)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

#### Returns

`string`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`getCssClass`](ComboboxEditor.md#getcssclass)

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

[`ComboboxEditor`](ComboboxEditor.md).[`getCustomAttribute`](ComboboxEditor.md#getcustomattribute)

***

### getDialogTypeKey()

> `protected` **getDialogTypeKey**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:727](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L727)

#### Returns

`string`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`getDialogTypeKey`](ComboboxEditor.md#getdialogtypekey)

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

[`ComboboxEditor`](ComboboxEditor.md).[`getEditValue`](ComboboxEditor.md#geteditvalue)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

#### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`getGridField`](ComboboxEditor.md#getgridfield)

***

### getIdField()

> `protected` **getIdField**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L109)

#### Returns

`any`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`getIdField`](ComboboxEditor.md#getidfield)

***

### getPageSize()

> `protected` **getPageSize**(): `number`

Defined in: [src/ui/editors/comboboxeditor.tsx:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L105)

#### Returns

`number`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`getPageSize`](ComboboxEditor.md#getpagesize)

***

### getTextField()

> `protected` **getTextField**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L120)

#### Returns

`any`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`getTextField`](ComboboxEditor.md#gettextfield)

***

### getTypeDelay()

> `protected` **getTypeDelay**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L96)

#### Returns

`any`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`getTypeDelay`](ComboboxEditor.md#gettypedelay)

***

### hasAsyncSource()

> `protected` **hasAsyncSource**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L85)

#### Returns

`boolean`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`hasAsyncSource`](ComboboxEditor.md#hasasyncsource)

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L153)

#### Returns

`this`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`init`](ComboboxEditor.md#init)

***

### initNewEntity()

> `protected` **initNewEntity**(`entity`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:747](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L747)

#### Parameters

##### entity

[`ComboboxItem`](../interfaces/ComboboxItem.md)

#### Returns

`void`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`initNewEntity`](ComboboxEditor.md#initnewentity)

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

[`ComboboxEditor`](ComboboxEditor.md).[`inplaceCreateClick`](ComboboxEditor.md#inplacecreateclick)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L173)

#### Returns

`void`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`internalRenderContents`](ComboboxEditor.md#internalrendercontents)

***

### isAutoComplete()

> `protected` **isAutoComplete**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:369](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L369)

#### Returns

`boolean`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`isAutoComplete`](ComboboxEditor.md#isautocomplete)

***

### isMultiple()

> `protected` **isMultiple**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L153)

#### Returns

`boolean`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`isMultiple`](ComboboxEditor.md#ismultiple)

***

### itemDisabled()

> `protected` **itemDisabled**(`item`): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L131)

#### Parameters

##### item

[`ComboboxItem`](../interfaces/ComboboxItem.md)

#### Returns

`boolean`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`itemDisabled`](ComboboxEditor.md#itemdisabled)

***

### itemId()

> `protected` **itemId**(`item`): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L113)

#### Parameters

##### item

[`ComboboxItem`](../interfaces/ComboboxItem.md)

#### Returns

`string`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`itemId`](ComboboxEditor.md#itemid)

***

### itemText()

> `protected` **itemText**(`item`): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L124)

#### Parameters

##### item

[`ComboboxItem`](../interfaces/ComboboxItem.md)

#### Returns

`string`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`itemText`](ComboboxEditor.md#itemtext)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L190)

#### Returns

`boolean`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`legacyTemplateRender`](ComboboxEditor.md#legacytemplaterender)

***

### mapItem()

> `protected` **mapItem**(`item`): [`ComboboxItem`](../interfaces/ComboboxItem.md)

Defined in: [src/ui/editors/comboboxeditor.tsx:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L135)

#### Parameters

##### item

[`ComboboxItem`](../interfaces/ComboboxItem.md)

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`mapItem`](ComboboxEditor.md#mapitem)

***

### mapItems()

> `protected` **mapItems**(`items`): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

Defined in: [src/ui/editors/comboboxeditor.tsx:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L144)

#### Parameters

##### items

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`mapItems`](ComboboxEditor.md#mapitems)

***

### openDropdown()

> **openDropdown**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:853](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L853)

#### Returns

`void`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`openDropdown`](ComboboxEditor.md#opendropdown)

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

[`ComboboxEditor`](ComboboxEditor.md).[`render`](ComboboxEditor.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/widgets/widget.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L184)

#### Returns

`any`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`renderContents`](ComboboxEditor.md#rendercontents)

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

[`ComboboxEditor`](ComboboxEditor.md).[`set_cascadeField`](ComboboxEditor.md#set_cascadefield)

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

[`ComboboxEditor`](ComboboxEditor.md).[`set_cascadeFrom`](ComboboxEditor.md#set_cascadefrom)

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

[`ComboboxEditor`](ComboboxEditor.md).[`set_cascadeValue`](ComboboxEditor.md#set_cascadevalue)

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

[`ComboboxEditor`](ComboboxEditor.md).[`set_filterField`](ComboboxEditor.md#set_filterfield)

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

[`ComboboxEditor`](ComboboxEditor.md).[`set_filterValue`](ComboboxEditor.md#set_filtervalue)

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

[`ComboboxEditor`](ComboboxEditor.md).[`set_readOnly`](ComboboxEditor.md#set_readonly)

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

[`ComboboxEditor`](ComboboxEditor.md).[`set_value`](ComboboxEditor.md#set_value)

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

[`ComboboxEditor`](ComboboxEditor.md).[`set_values`](ComboboxEditor.md#set_values)

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

[`ComboboxEditor`](ComboboxEditor.md).[`setCascadeFrom`](ComboboxEditor.md#setcascadefrom)

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

[`ComboboxEditor`](ComboboxEditor.md).[`setEditDialogReadOnly`](ComboboxEditor.md#seteditdialogreadonly)

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

[`ComboboxEditor`](ComboboxEditor.md).[`setEditValue`](ComboboxEditor.md#seteditvalue)

***

### setTermOnNewEntity()

> `protected` **setTermOnNewEntity**(`entity`, `term`, `dialog`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:773](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L773)

#### Parameters

##### entity

[`ComboboxItem`](../interfaces/ComboboxItem.md)

##### term

`string`

##### dialog

`any`

#### Returns

`void`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`setTermOnNewEntity`](ComboboxEditor.md#settermonnewentity)

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

[`ComboboxEditor`](ComboboxEditor.md).[`syncOrAsyncThen`](ComboboxEditor.md#syncorasyncthen)

***

### updateItems()

> `protected` **updateItems**(): `void` \| `PromiseLike`\<`void`\>

Defined in: [src/ui/editors/enumeditor.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/enumeditor.ts#L21)

#### Returns

`void` \| `PromiseLike`\<`void`\>

#### Overrides

[`ComboboxEditor`](ComboboxEditor.md).[`updateItems`](ComboboxEditor.md#updateitems)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L214)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`useIdPrefix`](ComboboxEditor.md#useidprefix)

***

### useInplaceAdd()

> `protected` **useInplaceAdd**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:362](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L362)

#### Returns

`boolean`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`useInplaceAdd`](ComboboxEditor.md#useinplaceadd)

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

[`ComboboxEditor`](ComboboxEditor.md).[`create`](ComboboxEditor.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLInputElement`

Defined in: [src/ui/editors/comboboxeditor.tsx:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L43)

#### Returns

`HTMLInputElement`

#### Inherited from

[`ComboboxEditor`](ComboboxEditor.md).[`createDefaultElement`](ComboboxEditor.md#createdefaultelement)

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

[`ComboboxEditor`](ComboboxEditor.md).[`filterByText`](ComboboxEditor.md#filterbytext)

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

[`ComboboxEditor`](ComboboxEditor.md).[`getWidgetName`](ComboboxEditor.md#getwidgetname)

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

[`ComboboxEditor`](ComboboxEditor.md).[`registerClass`](ComboboxEditor.md#registerclass)

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

[`ComboboxEditor`](ComboboxEditor.md).[`registerEditor`](ComboboxEditor.md#registereditor)
