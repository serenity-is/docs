[@serenity-is/corelib](../README.md) / AbstractSelect2

# Abstract Class: AbstractSelect2

Defined in: [src/ui/editors/select2.tsx:1142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1142)

## Extended by

- [`SingleSelect2`](SingleSelect2.md)
- [`MultiSelect2`](MultiSelect2.md)

## Constructors

### Constructor

> **new AbstractSelect2**(): `AbstractSelect2`

#### Returns

`AbstractSelect2`

## Properties

### autofocus

> `protected` **autofocus**: `boolean`

Defined in: [src/ui/editors/select2.tsx:1149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1149)

***

### container

> **container**: `HTMLElement`

Defined in: [src/ui/editors/select2.tsx:1150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1150)

***

### containerEventName

> `protected` **containerEventName**: `string`

Defined in: [src/ui/editors/select2.tsx:1152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1152)

***

### containerId

> `protected` **containerId**: `string`

Defined in: [src/ui/editors/select2.tsx:1151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1151)

***

### context

> `protected` **context**: `any`

Defined in: [src/ui/editors/select2.tsx:1153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1153)

***

### dropdown

> **dropdown**: `HTMLElement`

Defined in: [src/ui/editors/select2.tsx:1154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1154)

***

### elementTabIndex

> `protected` **elementTabIndex**: `string`

Defined in: [src/ui/editors/select2.tsx:1155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1155)

***

### enabledInterface

> `protected` **enabledInterface**: `boolean`

Defined in: [src/ui/editors/select2.tsx:1156](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1156)

***

### id()

> `protected` **id**: (`item`) => `string`

Defined in: [src/ui/editors/select2.tsx:1157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1157)

#### Parameters

##### item

`any`

#### Returns

`string`

***

### nextSearchTerm

> `protected` **nextSearchTerm**: `string`

Defined in: [src/ui/editors/select2.tsx:1158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1158)

***

### opts

> `protected` **opts**: [`Select2Options`](../interfaces/Select2Options.md)

Defined in: [src/ui/editors/select2.tsx:1159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1159)

***

### propertyObserver

> `protected` **propertyObserver**: `MutationObserver`

Defined in: [src/ui/editors/select2.tsx:1160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1160)

***

### queryCount

> `protected` **queryCount**: `number`

Defined in: [src/ui/editors/select2.tsx:1161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1161)

***

### results

> `protected` **results**: `HTMLElement`

Defined in: [src/ui/editors/select2.tsx:1162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1162)

***

### resultsPage

> `protected` **resultsPage**: `number`

Defined in: [src/ui/editors/select2.tsx:1163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1163)

***

### search

> **search**: `HTMLInputElement`

Defined in: [src/ui/editors/select2.tsx:1164](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1164)

***

### select

> `protected` **select**: `HTMLSelectElement`

Defined in: [src/ui/editors/select2.tsx:1374](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1374)

***

### selection

> `protected` **selection**: `HTMLElement`

Defined in: [src/ui/editors/select2.tsx:1165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1165)

***

### showSearchInput

> `protected` **showSearchInput**: `boolean`

Defined in: [src/ui/editors/select2.tsx:1166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1166)

## Methods

### blur()

> `protected` **blur**(): `void`

Defined in: [src/ui/editors/select2.tsx:2429](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2429)

#### Returns

`void`

***

### cancel()

> `protected` **cancel**(`e?`): `void`

Defined in: [src/ui/editors/select2.tsx:2425](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2425)

#### Parameters

##### e?

`Event`

#### Returns

`void`

***

### clearDropdownAlignmentPreference()

> `protected` **clearDropdownAlignmentPreference**(): `void`

Defined in: [src/ui/editors/select2.tsx:1832](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1832)

#### Returns

`void`

***

### clearSearch()

> `protected` **clearSearch**(): `void`

Defined in: [src/ui/editors/select2.tsx:1996](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1996)

#### Returns

`void`

***

### clearTouchMoved()

> `protected` **clearTouchMoved**(): `void`

Defined in: [src/ui/editors/select2.tsx:2105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2105)

#### Returns

`void`

***

### close()

> **close**(): `void`

Defined in: [src/ui/editors/select2.tsx:1948](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1948)

#### Returns

`void`

***

### countSelectableResults()

> `protected` **countSelectableResults**(): `number`

Defined in: [src/ui/editors/select2.tsx:2109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2109)

#### Returns

`number`

***

### createContainer()

> `abstract` `protected` **createContainer**(): `HTMLElement`

Defined in: [src/ui/editors/select2.tsx:1168](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1168)

#### Returns

`HTMLElement`

***

### data()

> `abstract` **data**(`value?`, `triggerChange?`): `void` \| [`Select2Item`](../interfaces/Select2Item.md) \| [`Select2Item`](../interfaces/Select2Item.md)[]

Defined in: [src/ui/editors/select2.tsx:1169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1169)

#### Parameters

##### value?

[`Select2Item`](../interfaces/Select2Item.md) | [`Select2Item`](../interfaces/Select2Item.md)[]

##### triggerChange?

`boolean`

#### Returns

`void` \| [`Select2Item`](../interfaces/Select2Item.md) \| [`Select2Item`](../interfaces/Select2Item.md)[]

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/editors/select2.tsx:1304](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1304)

#### Returns

`void`

***

### disable()

> **disable**(): `void`

Defined in: [src/ui/editors/select2.tsx:1695](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1695)

#### Returns

`void`

***

### enable()

> **enable**(`enabled?`): `void`

Defined in: [src/ui/editors/select2.tsx:1686](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1686)

#### Parameters

##### enabled?

`boolean`

#### Returns

`void`

***

### enableInterface()

> `protected` **enableInterface**(): `boolean`

Defined in: [src/ui/editors/select2.tsx:1673](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1673)

#### Returns

`boolean`

***

### ensureHighlightVisible()

> `protected` **ensureHighlightVisible**(): `void`

Defined in: [src/ui/editors/select2.tsx:2004](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2004)

#### Returns

`void`

***

### externalSearch()

> `protected` **externalSearch**(`term`): `void`

Defined in: [src/ui/editors/select2.tsx:1990](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1990)

Opens control, sets input value, and updates results.

#### Parameters

##### term

`string`

#### Returns

`void`

***

### findHighlightableChoices()

> `protected` **findHighlightableChoices**(): `Element`[]

Defined in: [src/ui/editors/select2.tsx:2051](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2051)

#### Returns

`Element`[]

***

### focus()

> `abstract` **focus**(): `void`

Defined in: [src/ui/editors/select2.tsx:1170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1170)

#### Returns

`void`

***

### focusSearch()

> `protected` **focusSearch**(): `void`

Defined in: [src/ui/editors/select2.tsx:2441](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2441)

#### Returns

`void`

***

### getMaximumSelectionSize()

> `protected` **getMaximumSelectionSize**(): `any`

Defined in: [src/ui/editors/select2.tsx:2000](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2000)

#### Returns

`any`

***

### getPlaceholder()

> `protected` **getPlaceholder**(): `string`

Defined in: [src/ui/editors/select2.tsx:2462](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2462)

#### Returns

`string`

***

### getPlaceholderOption()

> `protected` **getPlaceholderOption**(): `HTMLOptionElement`

Defined in: [src/ui/editors/select2.tsx:2470](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2470)

#### Returns

`HTMLOptionElement`

***

### handleSearchBlur()

> `protected` **handleSearchBlur**(): `void`

Defined in: [src/ui/editors/select2.tsx:2194](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2194)

#### Returns

`void`

***

### handleSearchFocus()

> `protected` **handleSearchFocus**(): `void`

Defined in: [src/ui/editors/select2.tsx:2190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2190)

#### Returns

`void`

***

### handleSearchInput()

> `protected` **handleSearchInput**(): `void`

Defined in: [src/ui/editors/select2.tsx:2186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2186)

#### Returns

`void`

***

### highlight()

> `protected` **highlight**(`index?`): `number`

Defined in: [src/ui/editors/select2.tsx:2069](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2069)

#### Parameters

##### index?

`number`

#### Returns

`number`

***

### highlightUnderEvent()

> `protected` **highlightUnderEvent**(`event`): `void`

Defined in: [src/ui/editors/select2.tsx:2113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2113)

#### Parameters

##### event

`Event`

#### Returns

`void`

***

### init()

> **init**(`opts`): `void`

Defined in: [src/ui/editors/select2.tsx:1178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1178)

#### Parameters

##### opts

[`Select2Options`](../interfaces/Select2Options.md)

#### Returns

`void`

***

### initContainer()

> `abstract` `protected` **initContainer**(): `void`

Defined in: [src/ui/editors/select2.tsx:1172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1172)

#### Returns

`void`

***

### initContainerWidth()

> `protected` **initContainerWidth**(): `void`

Defined in: [src/ui/editors/select2.tsx:2490](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2490)

Get the desired width for the container element.  This is
derived first from option `width` passed to select2, then
the inline 'style' on the original element, and finally
falls back to the jQuery calculated element width.

#### Returns

`void`

***

### initSelection()

> `abstract` `protected` **initSelection**(): `void`

Defined in: [src/ui/editors/select2.tsx:1173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1173)

#### Returns

`void`

***

### isFocused()

> `abstract` **isFocused**(): `boolean`

Defined in: [src/ui/editors/select2.tsx:1171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1171)

#### Returns

`boolean`

***

### isInterfaceEnabled()

> `protected` **isInterfaceEnabled**(): `boolean`

Defined in: [src/ui/editors/select2.tsx:1669](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1669)

#### Returns

`boolean`

***

### loadMoreIfNeeded()

> `protected` **loadMoreIfNeeded**(): `void`

Defined in: [src/ui/editors/select2.tsx:2124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2124)

#### Returns

`void`

***

### monitorSource()

> `protected` **monitorSource**(): `void`

Defined in: [src/ui/editors/select2.tsx:1618](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1618)

Monitor the original element for changes and update select2 accordingly

#### Returns

`void`

***

### moveHighlight()

> `protected` **moveHighlight**(`delta`): `void`

Defined in: [src/ui/editors/select2.tsx:2055](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2055)

#### Parameters

##### delta

`number`

#### Returns

`void`

***

### onSelect()

> `abstract` `protected` **onSelect**(`item`, `options?`): `void`

Defined in: [src/ui/editors/select2.tsx:1174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1174)

#### Parameters

##### item

[`Select2Item`](../interfaces/Select2Item.md)

##### options?

###### noFocus

`boolean`

#### Returns

`void`

***

### open()

> **open**(): `boolean`

Defined in: [src/ui/editors/select2.tsx:1844](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1844)

Opens the dropdown

#### Returns

`boolean`

whether or not dropdown was opened. This method will return false if, for example,
the dropdown is already open, or if the 'open' event listener on the element called preventDefault().

***

### opened()

> **opened**(): `boolean`

Defined in: [src/ui/editors/select2.tsx:1708](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1708)

#### Returns

`boolean`

***

### opening()

> `protected` **opening**(): `void`

Defined in: [src/ui/editors/select2.tsx:1866](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1866)

Performs the opening of the dropdown

#### Returns

`void`

***

### optionToData()

> **optionToData**(`element`): [`Select2Item`](../interfaces/Select2Item.md)

Defined in: [src/ui/editors/select2.tsx:1354](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1354)

#### Parameters

##### element

`HTMLOptGroupElement` | `HTMLOptionElement`

#### Returns

[`Select2Item`](../interfaces/Select2Item.md)

***

### positionDropdown()

> **positionDropdown**(): `void`

Defined in: [src/ui/editors/select2.tsx:1712](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1712)

#### Returns

`void`

***

### postprocessResults()

> `abstract` `protected` **postprocessResults**(`data`, `initial`, `noHighlightUpdate?`): `void`

Defined in: [src/ui/editors/select2.tsx:1175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1175)

#### Parameters

##### data

[`Select2Result`](../interfaces/Select2Result.md)

##### initial

`boolean`

##### noHighlightUpdate?

`boolean`

#### Returns

`void`

***

### prepareOpts()

> `protected` **prepareOpts**(`opts`): [`Select2Options`](../interfaces/Select2Options.md)

Defined in: [src/ui/editors/select2.tsx:1404](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1404)

#### Parameters

##### opts

[`Select2Options`](../interfaces/Select2Options.md)

#### Returns

[`Select2Options`](../interfaces/Select2Options.md)

***

### readonly()

> **readonly**(`enabled?`): `void`

Defined in: [src/ui/editors/select2.tsx:1699](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1699)

#### Parameters

##### enabled?

`boolean`

#### Returns

`void`

***

### removeHighlight()

> `protected` **removeHighlight**(): `void`

Defined in: [src/ui/editors/select2.tsx:2097](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2097)

#### Returns

`void`

***

### selectHighlighted()

> `protected` **selectHighlighted**(`options?`): `void`

Defined in: [src/ui/editors/select2.tsx:2445](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2445)

#### Parameters

##### options?

`any`

#### Returns

`void`

***

### shouldOpen()

> `protected` **shouldOpen**(): `boolean`

Defined in: [src/ui/editors/select2.tsx:1822](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1822)

#### Returns

`boolean`

***

### tokenize()

> `protected` **tokenize**(): `string`

Defined in: [src/ui/editors/select2.tsx:2182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2182)

Default tokenizer function which does nothing

#### Returns

`string`

***

### touchMoved()

> `protected` **touchMoved**(): `void`

Defined in: [src/ui/editors/select2.tsx:2101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2101)

#### Returns

`void`

***

### triggerChange()

> `protected` **triggerChange**(`details?`): `void`

Defined in: [src/ui/editors/select2.tsx:1650](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1650)

Triggers the change event on the source element

#### Parameters

##### details?

`any`

#### Returns

`void`

***

### triggerSelect()

> `protected` **triggerSelect**(`data`): `boolean`

Defined in: [src/ui/editors/select2.tsx:1641](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1641)

#### Parameters

##### data

[`Select2Item`](../interfaces/Select2Item.md)

#### Returns

`boolean`

***

### updateResults()

> `protected` **updateResults**(`initial?`): `void`

Defined in: [src/ui/editors/select2.tsx:2255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2255)

#### Parameters

##### initial?

`boolean`

whether or not this is the call to this method right after the dropdown has been opened

#### Returns

`void`

***

### val()

> `abstract` **val**(`value?`): `string` \| `string`[]

Defined in: [src/ui/editors/select2.tsx:1176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1176)

#### Parameters

##### value?

`string` | `string`[]

#### Returns

`string` \| `string`[]
