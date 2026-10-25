[@serenity-is/corelib](../README.md) / LookupEditor

# Class: LookupEditor\<P\>

Defined in: [src/ui/editors/lookupeditor.ts:237](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L237)

An editor that renders a combobox over lookup items.

## Extends

- [`LookupEditorBase`](LookupEditorBase.md)\<`P`, \{ \}\>

## Type Parameters

### P

`P` *extends* [`LookupEditorOptions`](../interfaces/LookupEditorOptions.md) = [`LookupEditorOptions`](../interfaces/LookupEditorOptions.md)

Widget props type.

## Constructors

### Constructor

> **new LookupEditor**\<`P`\>(`props`): `LookupEditor`\<`P`\>

Defined in: [src/ui/editors/lookupeditor.ts:245](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L245)

Creates a lookup editor.

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

Widget props.

#### Returns

`LookupEditor`\<`P`\>

#### Overrides

[`LookupEditorBase`](LookupEditorBase.md).[`constructor`](LookupEditorBase.md#constructor)

## Properties

### cascadeLink

> `protected` **cascadeLink**: [`CascadedWidgetLink`](CascadedWidgetLink.md)\<[`Widget`](Widget.md)\<`any`\>\>

Defined in: [src/ui/editors/comboboxeditor.tsx:867](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L867)

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`cascadeLink`](LookupEditorBase.md#cascadelink)

***

### domNode

> `readonly` **domNode**: `HTMLInputElement`

Defined in: [src/ui/editors/comboboxeditor.tsx:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L77)

The hidden input element that backs the combobox editor.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`domNode`](LookupEditorBase.md#domnode)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L22)

The id prefix used for this widget's child element ids.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`idPrefix`](LookupEditorBase.md#idprefix)

***

### lastCreateTerm

> `protected` **lastCreateTerm**: `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L82)

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`lastCreateTerm`](LookupEditorBase.md#lastcreateterm)

***

### lookup

> `protected` **lookup**: [`Lookup`](Lookup.md)\<\{ \}\>

Defined in: [src/ui/editors/lookupeditor.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L85)

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`lookup`](LookupEditorBase.md#lookup)

***

### onInitNewEntity()

> **onInitNewEntity**: (`entity`) => `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:1146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1146)

Callback invoked to initialize a new entity for in-place add.

#### Parameters

##### entity

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`onInitNewEntity`](LookupEditorBase.md#oninitnewentity)

***

### openDialogAsPanel

> **openDialogAsPanel**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:1281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1281)

Whether the in-place add dialog opens as a panel.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`openDialogAsPanel`](LookupEditorBase.md#opendialogaspanel)

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>\>

Defined in: [src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

The widget's options/props.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`options`](LookupEditorBase.md#options)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L20)

A unique name for this widget instance, used for event namespacing.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`uniqueName`](LookupEditorBase.md#uniquename)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/editors/lookupeditor.ts:239](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L239)

#### Overrides

[`LookupEditorBase`](LookupEditorBase.md).[`[typeInfo]`](LookupEditorBase.md#typeinfo)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:334](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L334)

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`isComponent`](LookupEditorBase.md#iscomponent)

## Accessors

### cascadeField

#### Get Signature

> **get** **cascadeField**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:937](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L937)

Returns the cascade field name.

##### Returns

`string`

The cascade field.

#### Set Signature

> **set** **cascadeField**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:951](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L951)

Sets the cascade field name.

##### Parameters

###### value

`string`

The field name used for cascading.

##### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`cascadeField`](LookupEditorBase.md#cascadefield)

***

### cascadeFrom

#### Get Signature

> **get** **cascadeFrom**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:904](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L904)

Returns the cascade-from parent id.

##### Returns

`string`

The parent id.

#### Set Signature

> **set** **cascadeFrom**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:921](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L921)

Sets the cascade-from parent id.

##### Parameters

###### value

`string`

The parent editor id to cascade from.

##### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`cascadeFrom`](LookupEditorBase.md#cascadefrom)

***

### cascadeValue

#### Get Signature

> **get** **cascadeValue**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:967](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L967)

Returns the cascade value.

##### Returns

`any`

The cascade value.

#### Set Signature

> **set** **cascadeValue**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:985](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L985)

Sets the cascade value.

##### Parameters

###### value

`any`

The cascade value to filter by.

##### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`cascadeValue`](LookupEditorBase.md#cascadevalue)

***

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L82)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`element`](LookupEditorBase.md#element)

***

### filterField

#### Get Signature

> **get** **filterField**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:1001](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1001)

Returns the filter field name.

##### Returns

`string`

The filter field.

#### Set Signature

> **set** **filterField**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:1015](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1015)

Sets the filter field name.

##### Parameters

###### value

`string`

The field name used for filtering.

##### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`filterField`](LookupEditorBase.md#filterfield)

***

### filterValue

#### Get Signature

> **get** **filterValue**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:1031](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1031)

Returns the filter value.

##### Returns

`any`

The filter value.

#### Set Signature

> **set** **filterValue**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:1049](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1049)

Sets the filter value.

##### Parameters

###### value

`any`

The filter value to apply.

##### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`filterValue`](LookupEditorBase.md#filtervalue)

***

### itemById

#### Get Signature

> **get** `protected` **itemById**(): `object`

Defined in: [src/ui/editors/comboboxeditor.tsx:448](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L448)

##### Returns

`object`

#### Set Signature

> **set** `protected` **itemById**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:455](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L455)

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

Defined in: [src/ui/editors/comboboxeditor.tsx:429](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L429)

Returns the items in the editor.

##### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

The items.

#### Set Signature

> **set** **items**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:438](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L438)

Sets the items in the editor.

##### Parameters

###### value

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

The combobox items to set.

##### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`items`](LookupEditorBase.md#items)

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L307)

Returns the widget's props/options.

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`props`](LookupEditorBase.md#props)

***

### readOnly

#### Get Signature

> **get** **readOnly**(): `boolean`

Defined in: [src/ui/editors/editorwidget.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorwidget.ts#L42)

Returns whether the editor is read-only.

##### Returns

`boolean`

True when read-only.

#### Set Signature

> **set** **readOnly**(`value`): `void`

Defined in: [src/ui/editors/editorwidget.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorwidget.ts#L48)

Sets whether the editor is read-only.

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

Defined in: [src/ui/editors/comboboxeditor.tsx:750](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L750)

Returns the currently selected item.

##### Returns

`TItem`

The selected item, or null.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`selectedItem`](LookupEditorBase.md#selecteditem)

***

### selectedItems

#### Get Signature

> **get** **selectedItems**(): `TItem`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:764](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L764)

Returns the currently selected items.

##### Returns

`TItem`[]

The selected items.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`selectedItems`](LookupEditorBase.md#selecteditems)

***

### selectionLoadState

#### Get Signature

> **get** **selectionLoadState**(): `"error"` \| `"loading"` \| `"idle"`

Defined in: [src/ui/editors/comboboxeditor.tsx:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L150)

Returns the current state of the initial selection load.
"idle" means there is no pending or failed load. It does not guarantee
that an item is currently selected.

##### Returns

`"error"` \| `"loading"` \| `"idle"`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`selectionLoadState`](LookupEditorBase.md#selectionloadstate)

***

### text

#### Get Signature

> **get** **text**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:824](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L824)

Returns the display text of the current selection.

##### Returns

`string`

The comma-joined display text of the selected item(s).

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`text`](LookupEditorBase.md#text)

***

### value

#### Get Signature

> **get** **value**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:721](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L721)

Returns the current value.

##### Returns

`string`

The value.

#### Set Signature

> **set** **value**(`v`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:742](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L742)

Sets the current value.

##### Parameters

###### v

`string`

The single value to set.

##### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`value`](LookupEditorBase.md#value)

***

### values

#### Get Signature

> **get** **values**(): `string`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:791](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L791)

Returns the current values.

##### Returns

`string`[]

The values.

#### Set Signature

> **set** **values**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:805](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L805)

Sets the current values.

##### Parameters

###### value

`string`[]

The array of selected values to set.

##### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`values`](LookupEditorBase.md#values)

## Methods

### abortPendingQuery()

> `protected` **abortPendingQuery**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:319](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L319)

Aborts any pending search query.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`abortPendingQuery`](LookupEditorBase.md#abortpendingquery)

***

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/widgets/widget.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L89)

Adds the widget's CSS class to its DOM node.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`addCssClass`](LookupEditorBase.md#addcssclass)

***

### addInplaceCreate()

> `protected` **addInplaceCreate**(`addTitle`, `editTitle`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:506](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L506)

Adds the in-place create button.

#### Parameters

##### addTitle

`string`

Title for the add button.

##### editTitle

`string`

Title for the edit button.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`addInplaceCreate`](LookupEditorBase.md#addinplacecreate)

***

### addItem()

> **addItem**(`item`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:477](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L477)

Adds an item to the editor.

#### Parameters

##### item

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<\{ \}\>

The item to add.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`addItem`](LookupEditorBase.md#additem)

***

### addOption()

> **addOption**(`key`, `text`, `source?`, `disabled?`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:492](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L492)

Adds an option to the editor.

#### Parameters

##### key

`string`

The option id.

##### text

`string`

The display text.

##### source?

`any`

Optional source item.

##### disabled?

`boolean`

Whether the option is disabled.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`addOption`](LookupEditorBase.md#addoption)

***

### addValidationRule()

#### Call Signature

> **addValidationRule**(`rule`, `uniqueName?`): `void`

Defined in: [src/ui/widgets/widget.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L142)

Adds a validation rule to the widget's DOM node.

##### Parameters

###### rule

(`input`) => `string`

The validation rule function, or a unique name when the
  two-argument overload is used.

###### uniqueName?

`string`

A unique name for the rule, or the rule function when
  the two-argument overload is used.

##### Returns

`void`

##### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`addValidationRule`](LookupEditorBase.md#addvalidationrule)

#### Call Signature

> **addValidationRule**(`uniqueName`, `rule`): `void`

Defined in: [src/ui/widgets/widget.ts:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L143)

Adds a validation rule to the widget's DOM node.

##### Parameters

###### uniqueName

`string`

A unique name for the rule, or the rule function when
  the two-argument overload is used.

###### rule

(`input`) => `string`

The validation rule function, or a unique name when the
  two-argument overload is used.

##### Returns

`void`

##### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`addValidationRule`](LookupEditorBase.md#addvalidationrule)

***

### afterRender()

> `protected` **afterRender**(`callback`): `void`

Defined in: [src/ui/widgets/widget.ts:228](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L228)

Queues a callback to run after the widget's contents are rendered.

#### Parameters

##### callback

() => `void`

The callback to run after rendering.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`afterRender`](LookupEditorBase.md#afterrender)

***

### allowClear()

> `protected` **allowClear**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:303](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L303)

Whether the selection can be cleared.

#### Returns

`boolean`

True when clear is allowed.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`allowClear`](LookupEditorBase.md#allowclear)

***

### asyncSearch()

> `protected` **asyncSearch**(`query`): `Promise`\<[`ComboboxSearchResult`](../interfaces/ComboboxSearchResult.md)\<\{ \}\>\>

Defined in: [src/ui/editors/lookupeditor.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L186)

Performs an asynchronous search over the lookup items.

#### Parameters

##### query

[`ComboboxSearchQuery`](../interfaces/ComboboxSearchQuery.md)

The search query.

#### Returns

`Promise`\<[`ComboboxSearchResult`](../interfaces/ComboboxSearchResult.md)\<\{ \}\>\>

A promise resolving to the search result.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`asyncSearch`](LookupEditorBase.md#asyncsearch)

***

### byId()

> `protected` **byId**\<`TElement`\>(`id`): [`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

Defined in: [src/ui/widgets/widget.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L154)

Finds a child element by its prefix-relative id.

#### Type Parameters

##### TElement

`TElement` *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

The id relative to the widget's id prefix.

#### Returns

[`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

A [Fluent](../functions/Fluent.md) wrapper for the matching element.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`byId`](LookupEditorBase.md#byid)

***

### cascadeItems()

> `protected` **cascadeItems**(`items`): `object`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:1058](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1058)

Filters items by the cascade value.

#### Parameters

##### items

`object`[]

The items to filter.

#### Returns

`object`[]

The filtered items.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`cascadeItems`](LookupEditorBase.md#cascadeitems)

***

### change()

> **change**(`handler`): `void`

Defined in: [src/ui/widgets/widget.ts:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L179)

Registers a `change` handler on the widget's DOM node.

#### Parameters

##### handler

(`e`) => `void`

The change event handler.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`change`](LookupEditorBase.md#change)

***

### changeSelect2()

> **changeSelect2**(`handler`): `void`

Defined in: [src/ui/widgets/widget.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L188)

Registers a `change` handler that ignores changes originating from
combobox setting values.

#### Parameters

##### handler

(`e`) => `void`

The change event handler.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`changeSelect2`](LookupEditorBase.md#changeselect2)

***

### clearItems()

> **clearItems**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:465](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L465)

Clears all items from the editor.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`clearItems`](LookupEditorBase.md#clearitems)

***

### createEditDialog()

> `protected` **createEditDialog**(`callback`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:1136](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1136)

Creates an edit dialog for in-place add.

#### Parameters

##### callback

(`dlg`) => `void`

Callback invoked with the created dialog.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`createEditDialog`](LookupEditorBase.md#createeditdialog)

***

### deferRender()

> `protected` **deferRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L98)

Determines whether rendering should be deferred until [init](#init) is
called.

#### Returns

`boolean`

True to defer rendering.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`deferRender`](LookupEditorBase.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/editors/lookupeditor.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L53)

Cleans up the lookup change subscription.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`destroy`](LookupEditorBase.md#destroy)

***

### editDialogDataChange()

> `protected` **editDialogDataChange**(): `void`

Defined in: [src/ui/editors/lookupeditor.ts:228](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L228)

Reloads the lookup when the edit dialog data changes.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`editDialogDataChange`](LookupEditorBase.md#editdialogdatachange)

***

### emptyItemText()

> `protected` **emptyItemText**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L194)

Returns the text for the empty item.

#### Returns

`string`

The empty item text.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`emptyItemText`](LookupEditorBase.md#emptyitemtext)

***

### ensureSelectionLoaded()

> **ensureSelectionLoaded**(): `Promise`\<`void`\>

Defined in: [src/ui/editors/comboboxeditor.tsx:160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L160)

Waits for the current initial selection load, if necessary.

#### Returns

`Promise`\<`void`\>

A promise that resolves when the selection is loaded or rejects
if loading fails or is aborted. It resolves immediately when there is no
pending load.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`ensureSelectionLoaded`](LookupEditorBase.md#ensureselectionloaded)

***

### filterItems()

> `protected` **filterItems**(`items`): `object`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:1085](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1085)

Filters items by the filter value.

#### Parameters

##### items

`object`[]

The items to filter.

#### Returns

`object`[]

The filtered items.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`filterItems`](LookupEditorBase.md#filteritems)

***

### findById()

> `protected` **findById**\<`TElement`\>(`id`): `TElement`

Defined in: [src/ui/widgets/widget.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L163)

Finds a child element by its prefix-relative id.

#### Type Parameters

##### TElement

`TElement` *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### id

`string`

The id relative to the widget's id prefix.

#### Returns

`TElement`

The matching element, or null if not found.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`findById`](LookupEditorBase.md#findbyid)

***

### get\_cascadeField()

> `protected` **get\_cascadeField**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:929](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L929)

Returns the cascade field name.

#### Returns

`string`

The cascade field.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_cascadeField`](LookupEditorBase.md#get_cascadefield)

***

### get\_cascadeFrom()

> `protected` **get\_cascadeFrom**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:896](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L896)

Returns the cascade-from parent id.

#### Returns

`string`

The parent id.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_cascadeFrom`](LookupEditorBase.md#get_cascadefrom)

***

### get\_cascadeValue()

> `protected` **get\_cascadeValue**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:959](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L959)

Returns the cascade value.

#### Returns

`any`

The cascade value.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_cascadeValue`](LookupEditorBase.md#get_cascadevalue)

***

### get\_delimited()

> **get\_delimited**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:421](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L421)

Returns whether the value is delimited.

#### Returns

`boolean`

True when delimited.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_delimited`](LookupEditorBase.md#get_delimited)

***

### get\_filterField()

> `protected` **get\_filterField**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:993](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L993)

Returns the filter field name.

#### Returns

`string`

The filter field.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_filterField`](LookupEditorBase.md#get_filterfield)

***

### get\_filterValue()

> `protected` **get\_filterValue**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:1023](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1023)

Returns the filter value.

#### Returns

`any`

The filter value.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_filterValue`](LookupEditorBase.md#get_filtervalue)

***

### get\_itemByKey()

> `protected` **get\_itemByKey**(): `object`

Defined in: [src/ui/editors/comboboxeditor.tsx:676](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L676)

Returns the item-by-id map.

#### Returns

`object`

The item map.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_itemByKey`](LookupEditorBase.md#get_itembykey)

***

### get\_items()

> `protected` **get\_items**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<\{ \}\>[]

Defined in: [src/ui/editors/comboboxeditor.tsx:668](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L668)

Returns the items in the editor.

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<\{ \}\>[]

The items.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_items`](LookupEditorBase.md#get_items)

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:832](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L832)

Returns whether the editor is read-only.

#### Returns

`boolean`

True when read-only.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_readOnly`](LookupEditorBase.md#get_readonly)

***

### get\_text()

> `protected` **get\_text**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:813](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L813)

Returns the display text of the current selection.

#### Returns

`string`

The text.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_text`](LookupEditorBase.md#get_text)

***

### get\_value()

> **get\_value**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:713](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L713)

Returns the current value.

#### Returns

`string`

The value.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_value`](LookupEditorBase.md#get_value)

***

### get\_values()

> `protected` **get\_values**(): `string`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:783](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L783)

Returns the current values.

#### Returns

`string`[]

The values.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`get_values`](LookupEditorBase.md#get_values)

***

### getCascadeFromValue()

> `protected` **getCascadeFromValue**(`parent`): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:863](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L863)

Returns the cascade value from a parent widget.

#### Parameters

##### parent

[`Widget`](Widget.md)\<`any`\>

The parent widget.

#### Returns

`any`

The cascade value.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getCascadeFromValue`](LookupEditorBase.md#getcascadefromvalue)

***

### getComboboxContainer()

> `protected` **getComboboxContainer**(): `HTMLElement`

Defined in: [src/ui/editors/comboboxeditor.tsx:660](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L660)

Returns the combobox container element.

#### Returns

`HTMLElement`

The container element.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getComboboxContainer`](LookupEditorBase.md#getcomboboxcontainer)

***

### getComboboxOptions()

> `protected` **getComboboxOptions**(): [`ComboboxOptions`](../interfaces/ComboboxOptions.md)

Defined in: [src/ui/editors/comboboxeditor.tsx:327](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L327)

Returns the combobox options for this editor.

#### Returns

[`ComboboxOptions`](../interfaces/ComboboxOptions.md)

Combobox options.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getComboboxOptions`](LookupEditorBase.md#getcomboboxoptions)

***

### getCreateSearchChoice()

> **getCreateSearchChoice**(`getName`): (`s`) => `object`

Defined in: [src/ui/editors/comboboxeditor.tsx:581](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L581)

Returns a callback that creates a search choice for a term.

#### Parameters

##### getName

(`z`) => `string`

Optional callback to get the name of an item.

#### Returns

The search choice callback.

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

Defined in: [src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

Returns the CSS class(es) applied to the widget's DOM node.

#### Returns

`string`

The space-separated CSS class string.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getCssClass`](LookupEditorBase.md#getcssclass)

***

### getCustomAttribute()

> `protected` **getCustomAttribute**\<`TAttr`\>(`attrType`, `inherit`): `TAttr`

Defined in: [src/ui/widgets/widget.ts:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L220)

Returns a custom attribute applied to the widget's type.

#### Type Parameters

##### TAttr

`TAttr` *extends* [`CustomAttribute`](CustomAttribute.md)

#### Parameters

##### attrType

(...`args`) => `TAttr`

The attribute type to look up.

##### inherit

`boolean` = `true`

Whether to search inherited types; defaults to true.

#### Returns

`TAttr`

The matching attribute, or null.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getCustomAttribute`](LookupEditorBase.md#getcustomattribute)

***

### getDialogType()

> `protected` **getDialogType**(): [`DialogType`](../type-aliases/DialogType.md) \| `PromiseLike`\<[`DialogType`](../type-aliases/DialogType.md)\>

Defined in: [src/ui/editors/comboboxeditor.tsx:1111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1111)

Returns the dialog type used for in-place add.

#### Returns

[`DialogType`](../type-aliases/DialogType.md) \| `PromiseLike`\<[`DialogType`](../type-aliases/DialogType.md)\>

The dialog type.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getDialogType`](LookupEditorBase.md#getdialogtype)

***

### getDialogTypeKey()

> `protected` **getDialogTypeKey**(): `string`

Defined in: [src/ui/editors/lookupeditor.ts:208](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L208)

Returns the dialog type key for in-place add.

#### Returns

`string`

The dialog type key.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getDialogTypeKey`](LookupEditorBase.md#getdialogtypekey)

***

### getEditValue()

> **getEditValue**(`property`, `target`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:647](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L647)

Gets the edit value into a target object.

#### Parameters

##### property

[`PropertyItem`](../interfaces/PropertyItem.md)

The property item.

##### target

`any`

The target object.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getEditValue`](LookupEditorBase.md#geteditvalue)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L171)

Returns the closest `.field` element containing the widget's DOM node.

#### Returns

[`Fluent`](../interfaces/Fluent.md)

A [Fluent](../functions/Fluent.md) wrapper for the grid field.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getGridField`](LookupEditorBase.md#getgridfield)

***

### getIconField()

> `protected` **getIconField**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L260)

Gets the name of the icon field.

#### Returns

`any`

The name of the icon field.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getIconField`](LookupEditorBase.md#geticonfield)

***

### getIdField()

> `protected` **getIdField**(): `any`

Defined in: [src/ui/editors/lookupeditor.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L116)

Returns the id field name.

#### Returns

`any`

The id field.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getIdField`](LookupEditorBase.md#getidfield)

***

### getItemDisabled()

> `protected` **getItemDisabled**(`item`, `lookup`): `boolean`

Defined in: [src/ui/editors/lookupeditor.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L163)

Whether an item is disabled.

#### Parameters

##### item

The item.

##### lookup

[`Lookup`](Lookup.md)\<\{ \}\>

The lookup.

#### Returns

`boolean`

True when disabled.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getItemDisabled`](LookupEditorBase.md#getitemdisabled)

***

### getItemIcon()

> `protected` **getItemIcon**(`item`, `lookup`): [`IconClassName`](../type-aliases/IconClassName.md)

Defined in: [src/ui/editors/lookupeditor.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L134)

#### Parameters

##### item

##### lookup

[`Lookup`](Lookup.md)\<\{ \}\>

#### Returns

[`IconClassName`](../type-aliases/IconClassName.md)

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getItemIcon`](LookupEditorBase.md#getitemicon)

***

### getItems()

> `protected` **getItems**(`lookup`): `object`[]

Defined in: [src/ui/editors/lookupeditor.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L108)

Returns the items for the given lookup, filtered by cascade/filter values.

#### Parameters

##### lookup

[`Lookup`](Lookup.md)\<\{ \}\>

The lookup.

#### Returns

`object`[]

The items.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getItems`](LookupEditorBase.md#getitems)

***

### getItemText()

> `protected` **getItemText**(`item`, `lookup`): `any`

Defined in: [src/ui/editors/lookupeditor.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L126)

Returns the display text of an item.

#### Parameters

##### item

The item.

##### lookup

[`Lookup`](Lookup.md)\<\{ \}\>

The lookup.

#### Returns

`any`

The item text.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getItemText`](LookupEditorBase.md#getitemtext)

***

### getLookup()

> `protected` **getLookup**(): [`Lookup`](Lookup.md)\<\{ \}\>

Defined in: [src/ui/editors/lookupeditor.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L99)

Returns the lookup synchronously.

#### Returns

[`Lookup`](Lookup.md)\<\{ \}\>

The lookup.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getLookup`](LookupEditorBase.md#getlookup)

***

### getLookupAsync()

> `protected` **getLookupAsync**(): `PromiseLike`\<[`Lookup`](Lookup.md)\<\{ \}\>\>

Defined in: [src/ui/editors/lookupeditor.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L91)

Asynchronously loads the lookup.

#### Returns

`PromiseLike`\<[`Lookup`](Lookup.md)\<\{ \}\>\>

A promise resolving to the lookup.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getLookupAsync`](LookupEditorBase.md#getlookupasync)

***

### getLookupKey()

> `protected` **getLookupKey**(): `string`

Defined in: [src/ui/editors/lookupeditor.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L66)

Returns the lookup key for this editor.

#### Returns

`string`

The lookup key.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getLookupKey`](LookupEditorBase.md#getlookupkey)

***

### getPageSize()

> `protected` **getPageSize**(): `number`

Defined in: [src/ui/editors/comboboxeditor.tsx:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L203)

Returns the page size for paged searches.

#### Returns

`number`

The page size.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getPageSize`](LookupEditorBase.md#getpagesize)

***

### getSelectedItemAsync()

> **getSelectedItemAsync**(): `Promise`\<\{ \}\>

Defined in: [src/ui/editors/comboboxeditor.tsx:168](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L168)

Waits for the current initial selection load and returns the selected item.

#### Returns

`Promise`\<\{ \}\>

The selected item, or null when nothing is selected.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getSelectedItemAsync`](LookupEditorBase.md#getselecteditemasync)

***

### getSelectedItemsAsync()

> **getSelectedItemsAsync**(): `Promise`\<`object`[]\>

Defined in: [src/ui/editors/comboboxeditor.tsx:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L177)

Waits for the current initial selection load and returns the selected items.

#### Returns

`Promise`\<`object`[]\>

The selected items.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getSelectedItemsAsync`](LookupEditorBase.md#getselecteditemsasync)

***

### getTextField()

> `protected` **getTextField**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:231](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L231)

Returns the text field name.

#### Returns

`any`

The text field.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getTextField`](LookupEditorBase.md#gettextfield)

***

### getTypeDelay()

> `protected` **getTypeDelay**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L186)

Returns the type delay for searching.

#### Returns

`any`

The delay in milliseconds.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getTypeDelay`](LookupEditorBase.md#gettypedelay)

***

### hasAsyncSource()

> **hasAsyncSource**(): `boolean`

Defined in: [src/ui/editors/lookupeditor.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L46)

Whether the editor has an asynchronous item source.

#### Returns

`boolean`

True when async.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`hasAsyncSource`](LookupEditorBase.md#hasasyncsource)

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L243)

Initializes the widget, rendering its contents if rendering was deferred.

#### Returns

`this`

This widget instance.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`init`](LookupEditorBase.md#init)

***

### initNewEntity()

> `protected` **initNewEntity**(`entity`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:1152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1152)

Initializes a new entity with cascade/filter values.

#### Parameters

##### entity

The new entity.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`initNewEntity`](LookupEditorBase.md#initnewentity)

***

### inplaceCreateClick()

> `protected` **inplaceCreateClick**(`e`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:1204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1204)

Handles the in-place create button click.

#### Parameters

##### e

`Event`

The click event.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`inplaceCreateClick`](LookupEditorBase.md#inplacecreateclick)

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L266)

Renders the widget's contents and runs any queued after-render callbacks.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`internalRenderContents`](LookupEditorBase.md#internalrendercontents)

***

### isAutoComplete()

> `protected` **isAutoComplete**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:572](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L572)

Whether arbitrary values are allowed.

#### Returns

`boolean`

True when auto-complete is enabled.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`isAutoComplete`](LookupEditorBase.md#isautocomplete)

***

### isMultiple()

> `protected` **isMultiple**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:312](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L312)

Whether multiple items can be selected.

#### Returns

`boolean`

True when multiple.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`isMultiple`](LookupEditorBase.md#ismultiple)

***

### itemDisabled()

> `protected` **itemDisabled**(`item`): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:252](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L252)

Whether an item is disabled.

#### Parameters

##### item

The item.

#### Returns

`boolean`

True when disabled.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`itemDisabled`](LookupEditorBase.md#itemdisabled)

***

### itemIcon()

> `protected` **itemIcon**(`item`): [`IconClassName`](../type-aliases/IconClassName.md)

Defined in: [src/ui/editors/comboboxeditor.tsx:269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L269)

Returns the icon of an item.

#### Parameters

##### item

The item.

#### Returns

[`IconClassName`](../type-aliases/IconClassName.md)

The item icon.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`itemIcon`](LookupEditorBase.md#itemicon)

***

### itemId()

> `protected` **itemId**(`item`): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L220)

Returns the id of an item.

#### Parameters

##### item

The item.

#### Returns

`string`

The item id.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`itemId`](LookupEditorBase.md#itemid)

***

### itemText()

> `protected` **itemText**(`item`): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:240](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L240)

Returns the display text of an item.

#### Parameters

##### item

The item.

#### Returns

`string`

The item text.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`itemText`](LookupEditorBase.md#itemtext)

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L291)

Renders the widget from a legacy `getTemplate` string, if defined.

#### Returns

`boolean`

True if a legacy template was rendered.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`legacyTemplateRender`](LookupEditorBase.md#legacytemplaterender)

***

### mapItem()

> `protected` **mapItem**(`item`): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<\{ \}\>

Defined in: [src/ui/editors/lookupeditor.ts:147](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L147)

Maps an item to a combobox item.

#### Parameters

##### item

The item.

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<\{ \}\>

The combobox item.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`mapItem`](LookupEditorBase.md#mapitem)

***

### mapItems()

> `protected` **mapItems**(`items`): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

Defined in: [src/ui/editors/comboboxeditor.tsx:295](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L295)

Maps a list of items to combobox items.

#### Parameters

##### items

`object`[]

The items.

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

The combobox items.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`mapItems`](LookupEditorBase.md#mapitems)

***

### openDropdown()

> **openDropdown**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:1276](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1276)

Opens the combobox dropdown.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`openDropdown`](LookupEditorBase.md#opendropdown)

***

### render()

> **render**(): `any`

Defined in: [src/ui/widgets/widget.ts:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L253)

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

Defined in: [src/ui/widgets/widget.ts:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L281)

Renders the widget's contents. Override this to provide custom content.

#### Returns

`any`

The rendered contents.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`renderContents`](LookupEditorBase.md#rendercontents)

***

### set\_cascadeField()

> `protected` **set\_cascadeField**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:945](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L945)

Sets the cascade field name.

#### Parameters

##### value

`string`

The cascade field.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`set_cascadeField`](LookupEditorBase.md#set_cascadefield)

***

### set\_cascadeFrom()

> `protected` **set\_cascadeFrom**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:912](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L912)

Sets the cascade-from parent id.

#### Parameters

##### value

`string`

The parent id.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`set_cascadeFrom`](LookupEditorBase.md#set_cascadefrom)

***

### set\_cascadeValue()

> `protected` **set\_cascadeValue**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:975](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L975)

Sets the cascade value and refreshes items.

#### Parameters

##### value

`any`

The cascade value.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`set_cascadeValue`](LookupEditorBase.md#set_cascadevalue)

***

### set\_filterField()

> `protected` **set\_filterField**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:1009](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1009)

Sets the filter field name.

#### Parameters

##### value

`string`

The filter field.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`set_filterField`](LookupEditorBase.md#set_filterfield)

***

### set\_filterValue()

> `protected` **set\_filterValue**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:1039](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1039)

Sets the filter value and refreshes items.

#### Parameters

##### value

`any`

The filter value.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`set_filterValue`](LookupEditorBase.md#set_filtervalue)

***

### set\_readOnly()

> **set\_readOnly**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:851](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L851)

Sets whether the editor is read-only.

#### Parameters

##### value

`boolean`

True to enable read-only mode.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`set_readOnly`](LookupEditorBase.md#set_readonly)

***

### set\_value()

> **set\_value**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:729](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L729)

Sets the current value.

#### Parameters

##### value

`string`

The value to set.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`set_value`](LookupEditorBase.md#set_value)

***

### set\_values()

> `protected` **set\_values**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:799](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L799)

Sets the current values.

#### Parameters

##### value

`string`[]

The values to set.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`set_values`](LookupEditorBase.md#set_values)

***

### setCascadeFrom()

> `protected` **setCascadeFrom**(`value`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:873](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L873)

Sets the cascade-from parent id.

#### Parameters

##### value

`string`

The parent id.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`setCascadeFrom`](LookupEditorBase.md#setcascadefrom)

***

### setCreateTermOnNewEntity()

> `protected` **setCreateTermOnNewEntity**(`entity`, `term`): `void`

Defined in: [src/ui/editors/lookupeditor.ts:221](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L221)

Sets the search term on a new entity.

#### Parameters

##### entity

The new entity.

##### term

`string`

The search term.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`setCreateTermOnNewEntity`](LookupEditorBase.md#setcreatetermonnewentity)

***

### setEditDialogReadOnly()

> `protected` **setEditDialogReadOnly**(`dialog`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:1170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1170)

Sets the edit dialog to read-only.

#### Parameters

##### dialog

`any`

The dialog.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`setEditDialogReadOnly`](LookupEditorBase.md#seteditdialogreadonly)

***

### setEditValue()

> **setEditValue**(`source`, `property`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:632](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L632)

Sets the edit value from a source object.

#### Parameters

##### source

`any`

The source object.

##### property

[`PropertyItem`](../interfaces/PropertyItem.md)

The property item.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`setEditValue`](LookupEditorBase.md#seteditvalue)

***

### setTermOnNewEntity()

> `protected` **setTermOnNewEntity**(`entity`, `term`, `dialog`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:1191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1191)

Sets the search term on a new entity.

#### Parameters

##### entity

The new entity.

##### term

`string`

The search term.

##### dialog

`any`

The edit dialog.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`setTermOnNewEntity`](LookupEditorBase.md#settermonnewentity)

***

### syncOrAsyncThen()

> `protected` **syncOrAsyncThen**\<`T`\>(`syncMethod`, `asyncMethod`, `then`): `void`

Defined in: [src/ui/widgets/widget.ts:318](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L318)

Runs a method synchronously or asynchronously depending on the widget's
`useAsync` flag, then invokes a continuation.

#### Type Parameters

##### T

`T`

#### Parameters

##### syncMethod

() => `T`

The synchronous method to run.

##### asyncMethod

() => `PromiseLike`\<`T`\>

The asynchronous method to run.

##### then

(`v`) => `void`

The continuation invoked with the result.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`syncOrAsyncThen`](LookupEditorBase.md#syncorasyncthen)

***

### updateItems()

> **updateItems**(): `void`

Defined in: [src/ui/editors/lookupeditor.ts:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/lookupeditor.ts#L170)

Loads the lookup items into the editor.

#### Returns

`void`

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`updateItems`](LookupEditorBase.md#updateitems)

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:329](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L329)

Returns an id prefix helper for resolving child element ids.

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

An [IdPrefixType](../type-aliases/IdPrefixType.md) proxy for this widget's id prefix.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`useIdPrefix`](LookupEditorBase.md#useidprefix)

***

### useInplaceAdd()

> `protected` **useInplaceAdd**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:561](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L561)

Whether in-place add is enabled.

#### Returns

`boolean`

True when enabled.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`useInplaceAdd`](LookupEditorBase.md#useinplaceadd)

***

### create()

> `static` **create**\<`TWidget`, `P`\>(`params`): `TWidget`

Defined in: [src/ui/widgets/widget.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L202)

Creates a widget instance from the given params, appending its element to
the container and invoking the init/init callbacks.

#### Type Parameters

##### TWidget

`TWidget` *extends* [`Widget`](Widget.md)\<`P`\>

##### P

`P`

#### Parameters

##### params

[`CreateWidgetParams`](../interfaces/CreateWidgetParams.md)\<`TWidget`, `P`\>

The widget creation params.

#### Returns

`TWidget`

The created widget instance.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`create`](LookupEditorBase.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLInputElement`

Defined in: [src/ui/editors/comboboxeditor.tsx:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L75)

Creates the default hidden input element for the combobox.

#### Returns

`HTMLInputElement`

The hidden input element.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`createDefaultElement`](LookupEditorBase.md#createdefaultelement)

***

### filterByText()

> `static` **filterByText**\<`TItem`\>(`items`, `getText`, `term`): `TItem`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:687](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L687)

Filters items by text, matching the term against the item text.

#### Type Parameters

##### TItem

`TItem`

#### Parameters

##### items

`TItem`[]

The items to filter.

##### getText

(`item`) => `string`

Callback that returns the text of an item.

##### term

`string`

The search term.

#### Returns

`TItem`[]

The filtered items.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`filterByText`](LookupEditorBase.md#filterbytext)

***

### getWidgetName()

> `static` **getWidgetName**(`type`): `string`

Defined in: [src/ui/widgets/widget.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L131)

Returns the widget name for a type, used for association and unique names.

#### Parameters

##### type

`Function`

The widget type.

#### Returns

`string`

The widget name.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`getWidgetName`](LookupEditorBase.md#getwidgetname)

***

### registerClass()

> `protected` `static` **registerClass**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

Defined in: [src/ui/widgets/widget.ts:342](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L342)

Registers this type as a class with the given type name.

#### Type Parameters

##### TypeName

`TypeName`

#### Parameters

##### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

The type name to register.

##### intfAndAttr?

([`InterfaceType`](../type-aliases/InterfaceType.md) \| [`AttributeSpecifier`](../type-aliases/AttributeSpecifier.md))[]

Optional interfaces and attributes.

#### Returns

[`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`TypeName`\>

The class type info.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`registerClass`](LookupEditorBase.md#registerclass)

***

### registerEditor()

> `protected` `static` **registerEditor**\<`TypeName`\>(`typeName`, `intfAndAttr?`): [`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`TypeName`\>

Defined in: [src/ui/widgets/widget.ts:357](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L357)

Registers this type as an editor with the given type name.

#### Type Parameters

##### TypeName

`TypeName`

#### Parameters

##### typeName

[`StringLiteral`](../type-aliases/StringLiteral.md)\<`TypeName`\>

The type name to register.

##### intfAndAttr?

([`InterfaceType`](../type-aliases/InterfaceType.md) \| [`AttributeSpecifier`](../type-aliases/AttributeSpecifier.md))[]

Optional interfaces and attributes.

#### Returns

[`EditorTypeInfo`](../type-aliases/EditorTypeInfo.md)\<`TypeName`\>

The editor type info.

#### Inherited from

[`LookupEditorBase`](LookupEditorBase.md).[`registerEditor`](LookupEditorBase.md#registereditor)
