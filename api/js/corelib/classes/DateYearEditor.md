[@serenity-is/corelib](../README.md) / DateYearEditor

# Class: DateYearEditor\<P\>

## Extends

- [`SelectEditor`](SelectEditor.md)\<`P`\>

## Type Parameters

• **P** *extends* [`DateYearEditorOptions`](../interfaces/DateYearEditorOptions.md) = [`DateYearEditorOptions`](../interfaces/DateYearEditorOptions.md)

## Constructors

### new DateYearEditor()

> **new DateYearEditor**\<`P`\>(`props`): [`DateYearEditor`](DateYearEditor.md)\<`P`\>

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

#### Returns

[`DateYearEditor`](DateYearEditor.md)\<`P`\>

#### Overrides

[`SelectEditor`](SelectEditor.md).[`constructor`](SelectEditor.md#constructors)

#### Defined in

[src/ui/editors/dateyeareditor.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateyeareditor.ts#L8)

## Properties

### cascadeLink

> `protected` **cascadeLink**: [`CascadedWidgetLink`](CascadedWidgetLink.md)\<[`Widget`](Widget.md)\<`any`\>\>

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`cascadeLink`](SelectEditor.md#cascadelink)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:576](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L576)

***

### domNode

> `readonly` **domNode**: `HTMLInputElement`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`domNode`](SelectEditor.md#domnode)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L46)

***

### idPrefix

> `readonly` **idPrefix**: `string`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`idPrefix`](SelectEditor.md#idprefix)

#### Defined in

[src/ui/widgets/widget.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L16)

***

### lastCreateTerm

> `protected` **lastCreateTerm**: `string`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`lastCreateTerm`](SelectEditor.md#lastcreateterm)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L51)

***

### onInitNewEntity()

> **onInitNewEntity**: (`entity`) => `void`

#### Parameters

##### entity

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`onInitNewEntity`](SelectEditor.md#oninitnewentity)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:747](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L747)

***

### openDialogAsPanel

> **openDialogAsPanel**: `boolean`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`openDialogAsPanel`](SelectEditor.md#opendialogaspanel)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:859](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L859)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>\>

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`options`](SelectEditor.md#options)

#### Defined in

[src/ui/widgets/widget.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L14)

***

### uniqueName

> `readonly` **uniqueName**: `string`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`uniqueName`](SelectEditor.md#uniquename)

#### Defined in

[src/ui/widgets/widget.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L15)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`isComponent`](SelectEditor.md#iscomponent)

#### Defined in

[src/ui/widgets/widget.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L223)

***

### typeInfo

> `static` **typeInfo**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity.EditorWidget"`\>

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`typeInfo`](SelectEditor.md#typeinfo)

#### Defined in

[src/ui/editors/editorwidget.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorwidget.ts#L17)

## Accessors

### cascadeField

#### Get Signature

> **get** **cascadeField**(): `string`

##### Returns

`string`

#### Set Signature

> **set** **cascadeField**(`value`): `void`

##### Parameters

###### value

`string`

##### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`cascadeField`](SelectEditor.md#cascadefield)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:620](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L620)

***

### cascadeFrom

#### Get Signature

> **get** **cascadeFrom**(): `string`

##### Returns

`string`

#### Set Signature

> **set** **cascadeFrom**(`value`): `void`

##### Parameters

###### value

`string`

##### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`cascadeFrom`](SelectEditor.md#cascadefrom)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:601](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L601)

***

### cascadeValue

#### Get Signature

> **get** **cascadeValue**(): `any`

##### Returns

`any`

#### Set Signature

> **set** **cascadeValue**(`value`): `void`

##### Parameters

###### value

`any`

##### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`cascadeValue`](SelectEditor.md#cascadevalue)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:636](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L636)

***

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`element`](SelectEditor.md#element)

#### Defined in

[src/ui/widgets/widget.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L63)

***

### filterField

#### Get Signature

> **get** **filterField**(): `string`

##### Returns

`string`

#### Set Signature

> **set** **filterField**(`value`): `void`

##### Parameters

###### value

`string`

##### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`filterField`](SelectEditor.md#filterfield)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:656](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L656)

***

### filterValue

#### Get Signature

> **get** **filterValue**(): `any`

##### Returns

`any`

#### Set Signature

> **set** **filterValue**(`value`): `void`

##### Parameters

###### value

`any`

##### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`filterValue`](SelectEditor.md#filtervalue)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:672](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L672)

***

### itemById

#### Get Signature

> **get** `protected` **itemById**(): `object`

##### Returns

`object`

#### Set Signature

> **set** `protected` **itemById**(`value`): `void`

##### Parameters

###### value

##### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`itemById`](SelectEditor.md#itembyid)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:274](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L274)

***

### items

#### Get Signature

> **get** **items**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

##### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

#### Set Signature

> **set** **items**(`value`): `void`

##### Parameters

###### value

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

##### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`items`](SelectEditor.md#items)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:257](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L257)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`props`](SelectEditor.md#props)

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

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`readOnly`](SelectEditor.md#readonly)

#### Defined in

[src/ui/editors/editorwidget.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorwidget.ts#L23)

***

### selectedItem

#### Get Signature

> **get** **selectedItem**(): `TItem`

##### Returns

`TItem`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`selectedItem`](SelectEditor.md#selecteditem)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:497](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L497)

***

### selectedItems

#### Get Signature

> **get** **selectedItems**(): `TItem`[]

##### Returns

`TItem`[]

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`selectedItems`](SelectEditor.md#selecteditems)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:507](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L507)

***

### text

#### Get Signature

> **get** **text**(): `string`

##### Returns

`string`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`text`](SelectEditor.md#text)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:546](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L546)

***

### value

#### Get Signature

> **get** **value**(): `string`

##### Returns

`string`

#### Set Signature

> **set** **value**(`v`): `void`

##### Parameters

###### v

`string`

##### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`value`](SelectEditor.md#value)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:478](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L478)

***

### values

#### Get Signature

> **get** **values**(): `string`[]

##### Returns

`string`[]

#### Set Signature

> **set** **values**(`value`): `void`

##### Parameters

###### value

`string`[]

##### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`values`](SelectEditor.md#values)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:526](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L526)

## Methods

### abortPendingQuery()

> `protected` **abortPendingQuery**(): `void`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`abortPendingQuery`](SelectEditor.md#abortpendingquery)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L159)

***

### addCssClass()

> `protected` **addCssClass**(): `void`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`addCssClass`](SelectEditor.md#addcssclass)

#### Defined in

[src/ui/widgets/widget.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L67)

***

### addInplaceCreate()

> `protected` **addInplaceCreate**(`addTitle`, `editTitle`): `void`

#### Parameters

##### addTitle

`string`

##### editTitle

`string`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`addInplaceCreate`](SelectEditor.md#addinplacecreate)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:313](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L313)

***

### addItem()

> **addItem**(`item`): `void`

#### Parameters

##### item

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>\>

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`addItem`](SelectEditor.md#additem)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:296](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L296)

***

### addOption()

> **addOption**(`key`, `text`, `source`?, `disabled`?): `void`

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

[`SelectEditor`](SelectEditor.md).[`addOption`](SelectEditor.md#addoption)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:304](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L304)

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

[`SelectEditor`](SelectEditor.md).[`addValidationRule`](SelectEditor.md#addvalidationrule)

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

[`SelectEditor`](SelectEditor.md).[`addValidationRule`](SelectEditor.md#addvalidationrule)

##### Defined in

[src/ui/widgets/widget.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L100)

***

### afterRender()

> `protected` **afterRender**(`callback`): `void`

#### Parameters

##### callback

() => `void`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`afterRender`](SelectEditor.md#afterrender)

#### Defined in

[src/ui/widgets/widget.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L146)

***

### allowClear()

> `protected` **allowClear**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`allowClear`](SelectEditor.md#allowclear)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L150)

***

### asyncSearch()

> `protected` **asyncSearch**(`query`): `PromiseLike`\<[`ComboboxSearchResult`](../interfaces/ComboboxSearchResult.md)\<[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>\>\>

#### Parameters

##### query

[`ComboboxSearchQuery`](../interfaces/ComboboxSearchQuery.md)

#### Returns

`PromiseLike`\<[`ComboboxSearchResult`](../interfaces/ComboboxSearchResult.md)\<[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>\>\>

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`asyncSearch`](SelectEditor.md#asyncsearch)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L91)

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

[`SelectEditor`](SelectEditor.md).[`byId`](SelectEditor.md#byid)

#### Defined in

[src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

***

### cascadeItems()

> `protected` **cascadeItems**(`items`): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Parameters

##### items

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`cascadeItems`](SelectEditor.md#cascadeitems)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:688](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L688)

***

### change()

> **change**(`handler`): `void`

#### Parameters

##### handler

(`e`) => `void`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`change`](SelectEditor.md#change)

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

[`SelectEditor`](SelectEditor.md).[`changeSelect2`](SelectEditor.md#changeselect2)

#### Defined in

[src/ui/widgets/widget.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L122)

***

### clearItems()

> **clearItems**(): `void`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`clearItems`](SelectEditor.md#clearitems)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:288](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L288)

***

### createEditDialog()

> `protected` **createEditDialog**(`callback`): `void`

#### Parameters

##### callback

(`dlg`) => `void`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`createEditDialog`](SelectEditor.md#createeditdialog)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:737](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L737)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`deferRender`](SelectEditor.md#deferrender)

#### Defined in

[src/ui/widgets/widget.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L71)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`destroy`](SelectEditor.md#destroy)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L81)

***

### editDialogDataChange()

> `protected` **editDialogDataChange**(): `void`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`editDialogDataChange`](SelectEditor.md#editdialogdatachange)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:772](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L772)

***

### emptyItemText()

> `protected` **emptyItemText**(): `string`

#### Returns

`string`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`emptyItemText`](SelectEditor.md#emptyitemtext)

#### Defined in

[src/ui/editors/selecteditor.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/selecteditor.ts#L18)

***

### filterItems()

> `protected` **filterItems**(`items`): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Parameters

##### items

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`filterItems`](SelectEditor.md#filteritems)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:710](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L710)

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

[`SelectEditor`](SelectEditor.md).[`findById`](SelectEditor.md#findbyid)

#### Defined in

[src/ui/widgets/widget.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L110)

***

### get\_cascadeField()

> `protected` **get\_cascadeField**(): `string`

#### Returns

`string`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`get_cascadeField`](SelectEditor.md#get_cascadefield)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:616](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L616)

***

### get\_cascadeFrom()

> `protected` **get\_cascadeFrom**(): `string`

#### Returns

`string`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`get_cascadeFrom`](SelectEditor.md#get_cascadefrom)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:597](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L597)

***

### get\_cascadeValue()

> `protected` **get\_cascadeValue**(): `any`

#### Returns

`any`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`get_cascadeValue`](SelectEditor.md#get_cascadevalue)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:632](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L632)

***

### get\_delimited()

> **get\_delimited**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`get_delimited`](SelectEditor.md#get_delimited)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L253)

***

### get\_filterField()

> `protected` **get\_filterField**(): `string`

#### Returns

`string`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`get_filterField`](SelectEditor.md#get_filterfield)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:652](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L652)

***

### get\_filterValue()

> `protected` **get\_filterValue**(): `any`

#### Returns

`any`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`get_filterValue`](SelectEditor.md#get_filtervalue)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:668](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L668)

***

### get\_itemByKey()

> `protected` **get\_itemByKey**(): `object`

#### Returns

`object`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`get_itemByKey`](SelectEditor.md#get_itembykey)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:448](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L448)

***

### get\_items()

> `protected` **get\_items**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>\>[]

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>\>[]

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`get_items`](SelectEditor.md#get_items)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:444](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L444)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`get_readOnly`](SelectEditor.md#get_readonly)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:550](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L550)

***

### get\_text()

> `protected` **get\_text**(): `string`

#### Returns

`string`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`get_text`](SelectEditor.md#get_text)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:538](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L538)

***

### get\_value()

> **get\_value**(): `string`

#### Returns

`string`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`get_value`](SelectEditor.md#get_value)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:474](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L474)

***

### get\_values()

> `protected` **get\_values**(): `string`[]

#### Returns

`string`[]

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`get_values`](SelectEditor.md#get_values)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:522](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L522)

***

### getCascadeFromValue()

> `protected` **getCascadeFromValue**(`parent`): `any`

#### Parameters

##### parent

[`Widget`](Widget.md)\<`any`\>

#### Returns

`any`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`getCascadeFromValue`](SelectEditor.md#getcascadefromvalue)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:572](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L572)

***

### getComboboxContainer()

> `protected` **getComboboxContainer**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`getComboboxContainer`](SelectEditor.md#getcomboboxcontainer)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:440](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L440)

***

### getComboboxOptions()

> `protected` **getComboboxOptions**(): [`ComboboxOptions`](../interfaces/ComboboxOptions.md)\<`any`\>

#### Returns

[`ComboboxOptions`](../interfaces/ComboboxOptions.md)\<`any`\>

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`getComboboxOptions`](SelectEditor.md#getcomboboxoptions)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L163)

***

### getCreateSearchChoice()

> **getCreateSearchChoice**(`getName`): (`s`) => `object`

#### Parameters

##### getName

(`z`) => `string`

#### Returns

`Function`

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

[`SelectEditor`](SelectEditor.md).[`getCreateSearchChoice`](SelectEditor.md#getcreatesearchchoice)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:375](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L375)

***

### getCssClass()

> `protected` **getCssClass**(): `string`

#### Returns

`string`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`getCssClass`](SelectEditor.md#getcssclass)

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

[`SelectEditor`](SelectEditor.md).[`getCustomAttribute`](SelectEditor.md#getcustomattribute)

#### Defined in

[src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

***

### getDialogTypeKey()

> `protected` **getDialogTypeKey**(): `string`

#### Returns

`string`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`getDialogTypeKey`](SelectEditor.md#getdialogtypekey)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:729](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L729)

***

### getEditValue()

> **getEditValue**(`property`, `target`): `void`

#### Parameters

##### property

[`PropertyItem`](../interfaces/PropertyItem.md)

##### target

`any`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`getEditValue`](SelectEditor.md#geteditvalue)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:431](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L431)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`getGridField`](SelectEditor.md#getgridfield)

#### Defined in

[src/ui/widgets/widget.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L114)

***

### getIdField()

> `protected` **getIdField**(): `any`

#### Returns

`any`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`getIdField`](SelectEditor.md#getidfield)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L111)

***

### getItems()

> **getItems**(): `any`[]

#### Returns

`any`[]

#### Overrides

[`SelectEditor`](SelectEditor.md).[`getItems`](SelectEditor.md#getitems)

#### Defined in

[src/ui/editors/dateyeareditor.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/dateyeareditor.ts#L14)

***

### getPageSize()

> `protected` **getPageSize**(): `number`

#### Returns

`number`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`getPageSize`](SelectEditor.md#getpagesize)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L107)

***

### getTextField()

> `protected` **getTextField**(): `any`

#### Returns

`any`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`getTextField`](SelectEditor.md#gettextfield)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L122)

***

### getTypeDelay()

> `protected` **getTypeDelay**(): `any`

#### Returns

`any`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`getTypeDelay`](SelectEditor.md#gettypedelay)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L98)

***

### hasAsyncSource()

> `protected` **hasAsyncSource**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`hasAsyncSource`](SelectEditor.md#hasasyncsource)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L87)

***

### init()

> **init**(): `this`

#### Returns

`this`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`init`](SelectEditor.md#init)

#### Defined in

[src/ui/widgets/widget.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L157)

***

### initNewEntity()

> `protected` **initNewEntity**(`entity`): `void`

#### Parameters

##### entity

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`initNewEntity`](SelectEditor.md#initnewentity)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:749](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L749)

***

### inplaceCreateClick()

> `protected` **inplaceCreateClick**(`e`): `void`

#### Parameters

##### e

`Event`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`inplaceCreateClick`](SelectEditor.md#inplacecreateclick)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:784](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L784)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`internalRenderContents`](SelectEditor.md#internalrendercontents)

#### Defined in

[src/ui/widgets/widget.ts:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L177)

***

### isAutoComplete()

> `protected` **isAutoComplete**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`isAutoComplete`](SelectEditor.md#isautocomplete)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:371](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L371)

***

### isMultiple()

> `protected` **isMultiple**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`isMultiple`](SelectEditor.md#ismultiple)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L155)

***

### itemDisabled()

> `protected` **itemDisabled**(`item`): `boolean`

#### Parameters

##### item

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>

#### Returns

`boolean`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`itemDisabled`](SelectEditor.md#itemdisabled)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L133)

***

### itemId()

> `protected` **itemId**(`item`): `string`

#### Parameters

##### item

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>

#### Returns

`string`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`itemId`](SelectEditor.md#itemid)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L115)

***

### itemText()

> `protected` **itemText**(`item`): `string`

#### Parameters

##### item

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>

#### Returns

`string`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`itemText`](SelectEditor.md#itemtext)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L126)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`legacyTemplateRender`](SelectEditor.md#legacytemplaterender)

#### Defined in

[src/ui/widgets/widget.ts:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L194)

***

### mapItem()

> `protected` **mapItem**(`item`): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>

#### Parameters

##### item

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`mapItem`](SelectEditor.md#mapitem)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L137)

***

### mapItems()

> `protected` **mapItems**(`items`): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Parameters

##### items

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`mapItems`](SelectEditor.md#mapitems)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L146)

***

### openDropdown()

> **openDropdown**(): `void`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`openDropdown`](SelectEditor.md#opendropdown)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:855](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L855)

***

### render()

> **render**(): `any`

Returns the main element for this widget or the document fragment.
As widgets may get their elements from props unlike regular JSX widgets, 
this method should not be overridden. Override renderContents() instead.

#### Returns

`any`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`render`](SelectEditor.md#render)

#### Defined in

[src/ui/widgets/widget.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L167)

***

### renderContents()

> `protected` **renderContents**(): `any`

#### Returns

`any`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`renderContents`](SelectEditor.md#rendercontents)

#### Defined in

[src/ui/widgets/widget.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L188)

***

### set\_cascadeField()

> `protected` **set\_cascadeField**(`value`): `void`

#### Parameters

##### value

`string`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`set_cascadeField`](SelectEditor.md#set_cascadefield)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:624](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L624)

***

### set\_cascadeFrom()

> `protected` **set\_cascadeFrom**(`value`): `void`

#### Parameters

##### value

`string`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`set_cascadeFrom`](SelectEditor.md#set_cascadefrom)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:605](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L605)

***

### set\_cascadeValue()

> `protected` **set\_cascadeValue**(`value`): `void`

#### Parameters

##### value

`any`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`set_cascadeValue`](SelectEditor.md#set_cascadevalue)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:640](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L640)

***

### set\_filterField()

> `protected` **set\_filterField**(`value`): `void`

#### Parameters

##### value

`string`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`set_filterField`](SelectEditor.md#set_filterfield)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:660](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L660)

***

### set\_filterValue()

> `protected` **set\_filterValue**(`value`): `void`

#### Parameters

##### value

`any`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`set_filterValue`](SelectEditor.md#set_filtervalue)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:676](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L676)

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`set_readOnly`](SelectEditor.md#set_readonly)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:565](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L565)

***

### set\_value()

> **set\_value**(`value`): `void`

#### Parameters

##### value

`string`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`set_value`](SelectEditor.md#set_value)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:482](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L482)

***

### set\_values()

> `protected` **set\_values**(`value`): `void`

#### Parameters

##### value

`string`[]

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`set_values`](SelectEditor.md#set_values)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:530](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L530)

***

### setCascadeFrom()

> `protected` **setCascadeFrom**(`value`): `void`

#### Parameters

##### value

`string`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`setCascadeFrom`](SelectEditor.md#setcascadefrom)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:578](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L578)

***

### setEditDialogReadOnly()

> `protected` **setEditDialogReadOnly**(`dialog`): `void`

#### Parameters

##### dialog

`any`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`setEditDialogReadOnly`](SelectEditor.md#seteditdialogreadonly)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:763](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L763)

***

### setEditValue()

> **setEditValue**(`source`, `property`): `void`

#### Parameters

##### source

`any`

##### property

[`PropertyItem`](../interfaces/PropertyItem.md)

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`setEditValue`](SelectEditor.md#seteditvalue)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:421](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L421)

***

### setTermOnNewEntity()

> `protected` **setTermOnNewEntity**(`entity`, `term`, `dialog`): `void`

#### Parameters

##### entity

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>

##### term

`string`

##### dialog

`any`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`setTermOnNewEntity`](SelectEditor.md#settermonnewentity)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:775](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L775)

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

[`SelectEditor`](SelectEditor.md).[`syncOrAsyncThen`](SelectEditor.md#syncorasyncthen)

#### Defined in

[src/ui/widgets/widget.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L211)

***

### updateItems()

> **updateItems**(): `void`

#### Returns

`void`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`updateItems`](SelectEditor.md#updateitems)

#### Defined in

[src/ui/editors/selecteditor.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/selecteditor.ts#L25)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`useIdPrefix`](SelectEditor.md#useidprefix)

#### Defined in

[src/ui/widgets/widget.ts:218](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L218)

***

### useInplaceAdd()

> `protected` **useInplaceAdd**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`useInplaceAdd`](SelectEditor.md#useinplaceadd)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:364](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L364)

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

[`SelectEditor`](SelectEditor.md).[`create`](SelectEditor.md#create)

#### Defined in

[src/ui/widgets/widget.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L130)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLInputElement`

#### Returns

`HTMLInputElement`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`createDefaultElement`](SelectEditor.md#createdefaultelement)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L45)

***

### filterByText()

> `static` **filterByText**\<`TItem`\>(`items`, `getText`, `term`): `TItem`[]

#### Type Parameters

• **TItem**

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

[`SelectEditor`](SelectEditor.md).[`filterByText`](SelectEditor.md#filterbytext)

#### Defined in

[src/ui/editors/comboboxeditor.tsx:452](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L452)

***

### getWidgetName()

> `static` **getWidgetName**(`type`): `string`

#### Parameters

##### type

`Function`

#### Returns

`string`

#### Inherited from

[`SelectEditor`](SelectEditor.md).[`getWidgetName`](SelectEditor.md#getwidgetname)

#### Defined in

[src/ui/widgets/widget.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L95)
