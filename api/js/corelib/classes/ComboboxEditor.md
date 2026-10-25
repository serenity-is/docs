[@serenity-is/corelib](../README.md) / ComboboxEditor

# Class: ComboboxEditor\<P, TItem\>

Defined in: [src/ui/editors/comboboxeditor.tsx:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L69)

Base editor that renders a searchable combobox over a set of items.

## Extends

- [`EditorWidget`](EditorWidget.md)\<`P`\>

## Extended by

- [`EnumEditor`](EnumEditor.md)
- [`LookupEditorBase`](LookupEditorBase.md)
- [`SelectEditor`](SelectEditor.md)
- [`ServiceLookupEditorBase`](ServiceLookupEditorBase.md)
- [`FilterFieldSelect`](FilterFieldSelect.md)
- [`FilterOperatorSelect`](FilterOperatorSelect.md)

## Type Parameters

### P

`P`

Widget props type.

### TItem

`TItem`

The item type.

## Implements

- [`ISetEditValue`](ISetEditValue.md)
- [`IGetEditValue`](IGetEditValue.md)
- [`IStringValue`](IStringValue.md)
- [`IReadOnly`](IReadOnly.md)

## Constructors

### Constructor

> **new ComboboxEditor**\<`P`, `TItem`\>(`props`): `ComboboxEditor`\<`P`, `TItem`\>

Defined in: [src/ui/editors/comboboxeditor.tsx:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L88)

Creates a combobox editor.

#### Parameters

##### props

[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>

Widget props.

#### Returns

`ComboboxEditor`\<`P`, `TItem`\>

#### Overrides

[`EditorWidget`](EditorWidget.md).[`constructor`](EditorWidget.md#constructor)

## Properties

### cascadeLink

> `protected` **cascadeLink**: [`CascadedWidgetLink`](CascadedWidgetLink.md)\<[`Widget`](Widget.md)\<`any`\>\>

Defined in: [src/ui/editors/comboboxeditor.tsx:867](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L867)

***

### domNode

> `readonly` **domNode**: `HTMLInputElement`

Defined in: [src/ui/editors/comboboxeditor.tsx:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L77)

The hidden input element that backs the combobox editor.

#### Overrides

[`EditorWidget`](EditorWidget.md).[`domNode`](EditorWidget.md#domnode)

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/widget.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L22)

The id prefix used for this widget's child element ids.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`idPrefix`](EditorWidget.md#idprefix)

***

### lastCreateTerm

> `protected` **lastCreateTerm**: `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L82)

***

### onInitNewEntity()

> **onInitNewEntity**: (`entity`) => `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:1146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1146)

Callback invoked to initialize a new entity for in-place add.

#### Parameters

##### entity

`TItem`

#### Returns

`void`

***

### openDialogAsPanel

> **openDialogAsPanel**: `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:1281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1281)

Whether the in-place add dialog opens as a panel.

***

### options

> `protected` `readonly` **options**: [`WidgetProps`](../type-aliases/WidgetProps.md)\<[`EditorProps`](../type-aliases/EditorProps.md)\<`P`\>\>

Defined in: [src/ui/widgets/widget.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L18)

The widget's options/props.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`options`](EditorWidget.md#options)

***

### uniqueName

> `readonly` **uniqueName**: `string`

Defined in: [src/ui/widgets/widget.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L20)

A unique name for this widget instance, used for event namespacing.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`uniqueName`](EditorWidget.md#uniquename)

***

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/editors/comboboxeditor.tsx:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L71)

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`[typeInfo]`](IReadOnly.md#typeinfo)

#### Overrides

[`EditorWidget`](EditorWidget.md).[`[typeInfo]`](EditorWidget.md#typeinfo)

***

### isComponent

> `readonly` `static` **isComponent**: `true` = `true`

Defined in: [src/ui/widgets/widget.ts:334](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L334)

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`isComponent`](EditorWidget.md#iscomponent)

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

***

### element

#### Get Signature

> **get** **element**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L82)

Returns a Fluent(this.domNode) object

##### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`element`](EditorWidget.md#element)

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

***

### props

#### Get Signature

> **get** **props**(): [`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

Defined in: [src/ui/widgets/widget.ts:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L307)

Returns the widget's props/options.

##### Returns

[`WidgetProps`](../type-aliases/WidgetProps.md)\<`P`\>

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`props`](EditorWidget.md#props)

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

[`EditorWidget`](EditorWidget.md).[`readOnly`](EditorWidget.md#readonly)

***

### selectedItem

#### Get Signature

> **get** **selectedItem**(): `TItem`

Defined in: [src/ui/editors/comboboxeditor.tsx:750](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L750)

Returns the currently selected item.

##### Returns

`TItem`

The selected item, or null.

***

### selectedItems

#### Get Signature

> **get** **selectedItems**(): `TItem`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:764](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L764)

Returns the currently selected items.

##### Returns

`TItem`[]

The selected items.

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

***

### text

#### Get Signature

> **get** **text**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:824](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L824)

Returns the display text of the current selection.

##### Returns

`string`

The comma-joined display text of the selected item(s).

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

## Methods

### abortPendingQuery()

> `protected` **abortPendingQuery**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:319](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L319)

Aborts any pending search query.

#### Returns

`void`

***

### addCssClass()

> `protected` **addCssClass**(): `void`

Defined in: [src/ui/widgets/widget.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L89)

Adds the widget's CSS class to its DOM node.

#### Returns

`void`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`addCssClass`](EditorWidget.md#addcssclass)

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

***

### addItem()

> **addItem**(`item`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:477](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L477)

Adds an item to the editor.

#### Parameters

##### item

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>

The item to add.

#### Returns

`void`

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

[`EditorWidget`](EditorWidget.md).[`addValidationRule`](EditorWidget.md#addvalidationrule)

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

[`EditorWidget`](EditorWidget.md).[`addValidationRule`](EditorWidget.md#addvalidationrule)

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

[`EditorWidget`](EditorWidget.md).[`afterRender`](EditorWidget.md#afterrender)

***

### allowClear()

> `protected` **allowClear**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:303](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L303)

Whether the selection can be cleared.

#### Returns

`boolean`

True when clear is allowed.

***

### asyncSearch()

> `protected` **asyncSearch**(`query`): `PromiseLike`\<[`ComboboxSearchResult`](../interfaces/ComboboxSearchResult.md)\<`TItem`\>\>

Defined in: [src/ui/editors/comboboxeditor.tsx:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L138)

Performs an asynchronous search.

#### Parameters

##### query

[`ComboboxSearchQuery`](../interfaces/ComboboxSearchQuery.md)

The search query.

#### Returns

`PromiseLike`\<[`ComboboxSearchResult`](../interfaces/ComboboxSearchResult.md)\<`TItem`\>\>

A promise resolving to the search result.

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

[`EditorWidget`](EditorWidget.md).[`byId`](EditorWidget.md#byid)

***

### cascadeItems()

> `protected` **cascadeItems**(`items`): `TItem`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:1058](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1058)

Filters items by the cascade value.

#### Parameters

##### items

`TItem`[]

The items to filter.

#### Returns

`TItem`[]

The filtered items.

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

[`EditorWidget`](EditorWidget.md).[`change`](EditorWidget.md#change)

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

[`EditorWidget`](EditorWidget.md).[`changeSelect2`](EditorWidget.md#changeselect2)

***

### clearItems()

> **clearItems**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:465](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L465)

Clears all items from the editor.

#### Returns

`void`

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

[`EditorWidget`](EditorWidget.md).[`deferRender`](EditorWidget.md#deferrender)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L119)

Disposes the combobox and delegates to the base destroy.

#### Returns

`void`

#### Overrides

[`EditorWidget`](EditorWidget.md).[`destroy`](EditorWidget.md#destroy)

***

### editDialogDataChange()

> `protected` **editDialogDataChange**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:1182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1182)

Hook invoked when the edit dialog data changes.

#### Returns

`void`

***

### emptyItemText()

> `protected` **emptyItemText**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L194)

Returns the text for the empty item.

#### Returns

`string`

The empty item text.

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

***

### filterItems()

> `protected` **filterItems**(`items`): `TItem`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:1085](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1085)

Filters items by the filter value.

#### Parameters

##### items

`TItem`[]

The items to filter.

#### Returns

`TItem`[]

The filtered items.

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

[`EditorWidget`](EditorWidget.md).[`findById`](EditorWidget.md#findbyid)

***

### get\_cascadeField()

> `protected` **get\_cascadeField**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:929](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L929)

Returns the cascade field name.

#### Returns

`string`

The cascade field.

***

### get\_cascadeFrom()

> `protected` **get\_cascadeFrom**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:896](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L896)

Returns the cascade-from parent id.

#### Returns

`string`

The parent id.

***

### get\_cascadeValue()

> `protected` **get\_cascadeValue**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:959](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L959)

Returns the cascade value.

#### Returns

`any`

The cascade value.

***

### get\_delimited()

> **get\_delimited**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:421](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L421)

Returns whether the value is delimited.

#### Returns

`boolean`

True when delimited.

***

### get\_filterField()

> `protected` **get\_filterField**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:993](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L993)

Returns the filter field name.

#### Returns

`string`

The filter field.

***

### get\_filterValue()

> `protected` **get\_filterValue**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:1023](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1023)

Returns the filter value.

#### Returns

`any`

The filter value.

***

### get\_itemByKey()

> `protected` **get\_itemByKey**(): `object`

Defined in: [src/ui/editors/comboboxeditor.tsx:676](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L676)

Returns the item-by-id map.

#### Returns

`object`

The item map.

***

### get\_items()

> `protected` **get\_items**(): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

Defined in: [src/ui/editors/comboboxeditor.tsx:668](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L668)

Returns the items in the editor.

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`TItem`\>[]

The items.

***

### get\_readOnly()

> **get\_readOnly**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:832](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L832)

Returns whether the editor is read-only.

#### Returns

`boolean`

True when read-only.

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`get_readOnly`](IReadOnly.md#get_readonly)

***

### get\_text()

> `protected` **get\_text**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:813](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L813)

Returns the display text of the current selection.

#### Returns

`string`

The text.

***

### get\_value()

> **get\_value**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:713](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L713)

Returns the current value.

#### Returns

`string`

The value.

#### Implementation of

[`IStringValue`](IStringValue.md).[`get_value`](IStringValue.md#get_value)

***

### get\_values()

> `protected` **get\_values**(): `string`[]

Defined in: [src/ui/editors/comboboxeditor.tsx:783](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L783)

Returns the current values.

#### Returns

`string`[]

The values.

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

***

### getComboboxContainer()

> `protected` **getComboboxContainer**(): `HTMLElement`

Defined in: [src/ui/editors/comboboxeditor.tsx:660](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L660)

Returns the combobox container element.

#### Returns

`HTMLElement`

The container element.

***

### getComboboxOptions()

> `protected` **getComboboxOptions**(): [`ComboboxOptions`](../interfaces/ComboboxOptions.md)

Defined in: [src/ui/editors/comboboxeditor.tsx:327](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L327)

Returns the combobox options for this editor.

#### Returns

[`ComboboxOptions`](../interfaces/ComboboxOptions.md)

Combobox options.

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

***

### getCssClass()

> `protected` **getCssClass**(): `string`

Defined in: [src/ui/widgets/widget.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L106)

Returns the CSS class(es) applied to the widget's DOM node.

#### Returns

`string`

The space-separated CSS class string.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`getCssClass`](EditorWidget.md#getcssclass)

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

[`EditorWidget`](EditorWidget.md).[`getCustomAttribute`](EditorWidget.md#getcustomattribute)

***

### getDialogType()

> `protected` **getDialogType**(): [`DialogType`](../type-aliases/DialogType.md) \| `PromiseLike`\<[`DialogType`](../type-aliases/DialogType.md)\>

Defined in: [src/ui/editors/comboboxeditor.tsx:1111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1111)

Returns the dialog type used for in-place add.

#### Returns

[`DialogType`](../type-aliases/DialogType.md) \| `PromiseLike`\<[`DialogType`](../type-aliases/DialogType.md)\>

The dialog type.

***

### getDialogTypeKey()

> `protected` **getDialogTypeKey**(): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:1124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1124)

[DEPRECATED] Override getDialogType() instead

#### Returns

`string`

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

#### Implementation of

[`IGetEditValue`](IGetEditValue.md).[`getEditValue`](IGetEditValue.md#geteditvalue)

***

### getGridField()

> **getGridField**(): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/widget.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L171)

Returns the closest `.field` element containing the widget's DOM node.

#### Returns

[`Fluent`](../interfaces/Fluent.md)

A [Fluent](../functions/Fluent.md) wrapper for the grid field.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`getGridField`](EditorWidget.md#getgridfield)

***

### getIconField()

> `protected` **getIconField**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L260)

Gets the name of the icon field.

#### Returns

`any`

The name of the icon field.

***

### getIdField()

> `protected` **getIdField**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L211)

Returns the id field name.

#### Returns

`any`

The id field.

***

### getPageSize()

> `protected` **getPageSize**(): `number`

Defined in: [src/ui/editors/comboboxeditor.tsx:203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L203)

Returns the page size for paged searches.

#### Returns

`number`

The page size.

***

### getSelectedItemAsync()

> **getSelectedItemAsync**(): `Promise`\<`TItem`\>

Defined in: [src/ui/editors/comboboxeditor.tsx:168](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L168)

Waits for the current initial selection load and returns the selected item.

#### Returns

`Promise`\<`TItem`\>

The selected item, or null when nothing is selected.

***

### getSelectedItemsAsync()

> **getSelectedItemsAsync**(): `Promise`\<`TItem`[]\>

Defined in: [src/ui/editors/comboboxeditor.tsx:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L177)

Waits for the current initial selection load and returns the selected items.

#### Returns

`Promise`\<`TItem`[]\>

The selected items.

***

### getTextField()

> `protected` **getTextField**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:231](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L231)

Returns the text field name.

#### Returns

`any`

The text field.

***

### getTypeDelay()

> `protected` **getTypeDelay**(): `any`

Defined in: [src/ui/editors/comboboxeditor.tsx:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L186)

Returns the type delay for searching.

#### Returns

`any`

The delay in milliseconds.

***

### hasAsyncSource()

> `protected` **hasAsyncSource**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:129](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L129)

Whether the editor has an asynchronous item source.

#### Returns

`boolean`

True when async.

***

### init()

> **init**(): `this`

Defined in: [src/ui/widgets/widget.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L243)

Initializes the widget, rendering its contents if rendering was deferred.

#### Returns

`this`

This widget instance.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`init`](EditorWidget.md#init)

***

### initNewEntity()

> `protected` **initNewEntity**(`entity`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:1152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1152)

Initializes a new entity with cascade/filter values.

#### Parameters

##### entity

`TItem`

The new entity.

#### Returns

`void`

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

***

### internalRenderContents()

> **internalRenderContents**(): `void`

Defined in: [src/ui/widgets/widget.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L266)

Renders the widget's contents and runs any queued after-render callbacks.

#### Returns

`void`

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`internalRenderContents`](EditorWidget.md#internalrendercontents)

***

### isAutoComplete()

> `protected` **isAutoComplete**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:572](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L572)

Whether arbitrary values are allowed.

#### Returns

`boolean`

True when auto-complete is enabled.

***

### isMultiple()

> `protected` **isMultiple**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:312](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L312)

Whether multiple items can be selected.

#### Returns

`boolean`

True when multiple.

***

### itemDisabled()

> `protected` **itemDisabled**(`item`): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:252](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L252)

Whether an item is disabled.

#### Parameters

##### item

`TItem`

The item.

#### Returns

`boolean`

True when disabled.

***

### itemIcon()

> `protected` **itemIcon**(`item`): [`IconClassName`](../type-aliases/IconClassName.md)

Defined in: [src/ui/editors/comboboxeditor.tsx:269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L269)

Returns the icon of an item.

#### Parameters

##### item

`TItem`

The item.

#### Returns

[`IconClassName`](../type-aliases/IconClassName.md)

The item icon.

***

### itemId()

> `protected` **itemId**(`item`): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:220](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L220)

Returns the id of an item.

#### Parameters

##### item

`TItem`

The item.

#### Returns

`string`

The item id.

***

### itemText()

> `protected` **itemText**(`item`): `string`

Defined in: [src/ui/editors/comboboxeditor.tsx:240](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L240)

Returns the display text of an item.

#### Parameters

##### item

`TItem`

The item.

#### Returns

`string`

The item text.

***

### legacyTemplateRender()

> `protected` **legacyTemplateRender**(): `boolean`

Defined in: [src/ui/widgets/widget.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L291)

Renders the widget from a legacy `getTemplate` string, if defined.

#### Returns

`boolean`

True if a legacy template was rendered.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`legacyTemplateRender`](EditorWidget.md#legacytemplaterender)

***

### mapItem()

> `protected` **mapItem**(`item`): [`ComboboxItem`](../interfaces/ComboboxItem.md)

Defined in: [src/ui/editors/comboboxeditor.tsx:280](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L280)

Maps an item to a combobox item.

#### Parameters

##### item

`TItem`

The item.

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)

The combobox item.

***

### mapItems()

> `protected` **mapItems**(`items`): [`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

Defined in: [src/ui/editors/comboboxeditor.tsx:295](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L295)

Maps a list of items to combobox items.

#### Parameters

##### items

`TItem`[]

The items.

#### Returns

[`ComboboxItem`](../interfaces/ComboboxItem.md)\<`any`\>[]

The combobox items.

***

### openDropdown()

> **openDropdown**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:1276](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1276)

Opens the combobox dropdown.

#### Returns

`void`

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

[`EditorWidget`](EditorWidget.md).[`render`](EditorWidget.md#render)

***

### renderContents()

> `protected` **renderContents**(): `any`

Defined in: [src/ui/widgets/widget.ts:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L281)

Renders the widget's contents. Override this to provide custom content.

#### Returns

`any`

The rendered contents.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`renderContents`](EditorWidget.md#rendercontents)

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

#### Implementation of

[`IReadOnly`](IReadOnly.md).[`set_readOnly`](IReadOnly.md#set_readonly)

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

#### Implementation of

[`IStringValue`](IStringValue.md).[`set_value`](IStringValue.md#set_value)

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

#### Implementation of

[`ISetEditValue`](ISetEditValue.md).[`setEditValue`](ISetEditValue.md#seteditvalue)

***

### setTermOnNewEntity()

> `protected` **setTermOnNewEntity**(`entity`, `term`, `dialog`): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:1191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1191)

Sets the search term on a new entity.

#### Parameters

##### entity

`TItem`

The new entity.

##### term

`string`

The search term.

##### dialog

`any`

The edit dialog.

#### Returns

`void`

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

[`EditorWidget`](EditorWidget.md).[`syncOrAsyncThen`](EditorWidget.md#syncorasyncthen)

***

### updateItems()

> `protected` **updateItems**(): `void`

Defined in: [src/ui/editors/comboboxeditor.tsx:1104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L1104)

Refreshes the items in the editor.

#### Returns

`void`

***

### useIdPrefix()

> `protected` **useIdPrefix**(): [`IdPrefixType`](../type-aliases/IdPrefixType.md)

Defined in: [src/ui/widgets/widget.ts:329](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/widget.ts#L329)

Returns an id prefix helper for resolving child element ids.

#### Returns

[`IdPrefixType`](../type-aliases/IdPrefixType.md)

An [IdPrefixType](../type-aliases/IdPrefixType.md) proxy for this widget's id prefix.

#### Inherited from

[`EditorWidget`](EditorWidget.md).[`useIdPrefix`](EditorWidget.md#useidprefix)

***

### useInplaceAdd()

> `protected` **useInplaceAdd**(): `boolean`

Defined in: [src/ui/editors/comboboxeditor.tsx:561](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L561)

Whether in-place add is enabled.

#### Returns

`boolean`

True when enabled.

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

[`EditorWidget`](EditorWidget.md).[`create`](EditorWidget.md#create)

***

### createDefaultElement()

> `static` **createDefaultElement**(): `HTMLInputElement`

Defined in: [src/ui/editors/comboboxeditor.tsx:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/comboboxeditor.tsx#L75)

Creates the default hidden input element for the combobox.

#### Returns

`HTMLInputElement`

The hidden input element.

#### Overrides

[`EditorWidget`](EditorWidget.md).[`createDefaultElement`](EditorWidget.md#createdefaultelement)

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

[`EditorWidget`](EditorWidget.md).[`getWidgetName`](EditorWidget.md#getwidgetname)

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

[`EditorWidget`](EditorWidget.md).[`registerClass`](EditorWidget.md#registerclass)

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

[`EditorWidget`](EditorWidget.md).[`registerEditor`](EditorWidget.md#registereditor)
