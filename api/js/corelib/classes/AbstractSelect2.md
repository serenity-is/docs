[@serenity-is/corelib](../README.md) / AbstractSelect2

# Abstract Class: AbstractSelect2

Defined in: [src/ui/editors/select2.tsx:1144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1144)

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

Defined in: [src/ui/editors/select2.tsx:1151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1151)

***

### container

> **container**: `HTMLElement`

Defined in: [src/ui/editors/select2.tsx:1152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1152)

***

### containerEventName

> `protected` **containerEventName**: `string`

Defined in: [src/ui/editors/select2.tsx:1154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1154)

***

### containerId

> `protected` **containerId**: `string`

Defined in: [src/ui/editors/select2.tsx:1153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1153)

***

### context

> `protected` **context**: `any`

Defined in: [src/ui/editors/select2.tsx:1155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1155)

***

### dropdown

> **dropdown**: `HTMLElement`

Defined in: [src/ui/editors/select2.tsx:1156](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1156)

***

### elementTabIndex

> `protected` **elementTabIndex**: `string`

Defined in: [src/ui/editors/select2.tsx:1157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1157)

***

### enabledInterface

> `protected` **enabledInterface**: `boolean`

Defined in: [src/ui/editors/select2.tsx:1158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1158)

***

### id()

> `protected` **id**: (`item`) => `string`

Defined in: [src/ui/editors/select2.tsx:1159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1159)

#### Parameters

##### item

`any`

#### Returns

`string`

***

### nextSearchTerm

> `protected` **nextSearchTerm**: `string`

Defined in: [src/ui/editors/select2.tsx:1160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1160)

***

### opts

> `protected` **opts**: [`Select2Options`](../interfaces/Select2Options.md)

Defined in: [src/ui/editors/select2.tsx:1161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1161)

***

### propertyObserver

> `protected` **propertyObserver**: `MutationObserver`

Defined in: [src/ui/editors/select2.tsx:1162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1162)

***

### queryCount

> `protected` **queryCount**: `number`

Defined in: [src/ui/editors/select2.tsx:1163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1163)

***

### results

> `protected` **results**: `HTMLElement`

Defined in: [src/ui/editors/select2.tsx:1164](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1164)

***

### resultsPage

> `protected` **resultsPage**: `number`

Defined in: [src/ui/editors/select2.tsx:1165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1165)

***

### search

> **search**: `HTMLInputElement`

Defined in: [src/ui/editors/select2.tsx:1166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1166)

***

### select

> `protected` **select**: `HTMLSelectElement`

Defined in: [src/ui/editors/select2.tsx:1376](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1376)

***

### selection

> `protected` **selection**: `HTMLElement`

Defined in: [src/ui/editors/select2.tsx:1167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1167)

***

### showSearchInput

> `protected` **showSearchInput**: `boolean`

Defined in: [src/ui/editors/select2.tsx:1168](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1168)

## Methods

### blur()

> `protected` **blur**(): `void`

Defined in: [src/ui/editors/select2.tsx:2431](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2431)

#### Returns

`void`

***

### cancel()

> `protected` **cancel**(`e?`): `void`

Defined in: [src/ui/editors/select2.tsx:2427](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2427)

#### Parameters

##### e?

`Event`

#### Returns

`void`

***

### clearDropdownAlignmentPreference()

> `protected` **clearDropdownAlignmentPreference**(): `void`

Defined in: [src/ui/editors/select2.tsx:1834](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1834)

#### Returns

`void`

***

### clearSearch()

> `protected` **clearSearch**(): `void`

Defined in: [src/ui/editors/select2.tsx:1998](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1998)

#### Returns

`void`

***

### clearTouchMoved()

> `protected` **clearTouchMoved**(): `void`

Defined in: [src/ui/editors/select2.tsx:2107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2107)

#### Returns

`void`

***

### close()

> **close**(): `void`

Defined in: [src/ui/editors/select2.tsx:1950](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1950)

#### Returns

`void`

***

### countSelectableResults()

> `protected` **countSelectableResults**(): `number`

Defined in: [src/ui/editors/select2.tsx:2111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2111)

#### Returns

`number`

***

### createContainer()

> `abstract` `protected` **createContainer**(): `HTMLElement`

Defined in: [src/ui/editors/select2.tsx:1170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1170)

#### Returns

`HTMLElement`

***

### data()

> `abstract` **data**(`value?`, `triggerChange?`): `void` \| [`Select2Item`](../interfaces/Select2Item.md) \| [`Select2Item`](../interfaces/Select2Item.md)[]

Defined in: [src/ui/editors/select2.tsx:1171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1171)

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

Defined in: [src/ui/editors/select2.tsx:1306](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1306)

#### Returns

`void`

***

### disable()

> **disable**(): `void`

Defined in: [src/ui/editors/select2.tsx:1697](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1697)

#### Returns

`void`

***

### enable()

> **enable**(`enabled?`): `void`

Defined in: [src/ui/editors/select2.tsx:1688](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1688)

#### Parameters

##### enabled?

`boolean`

#### Returns

`void`

***

### enableInterface()

> `protected` **enableInterface**(): `boolean`

Defined in: [src/ui/editors/select2.tsx:1675](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1675)

#### Returns

`boolean`

***

### ensureHighlightVisible()

> `protected` **ensureHighlightVisible**(): `void`

Defined in: [src/ui/editors/select2.tsx:2006](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2006)

#### Returns

`void`

***

### externalSearch()

> `protected` **externalSearch**(`term`): `void`

Defined in: [src/ui/editors/select2.tsx:1992](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1992)

Opens control, sets input value, and updates results.

#### Parameters

##### term

`string`

#### Returns

`void`

***

### findHighlightableChoices()

> `protected` **findHighlightableChoices**(): `Element`[]

Defined in: [src/ui/editors/select2.tsx:2053](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2053)

#### Returns

`Element`[]

***

### focus()

> `abstract` **focus**(): `void`

Defined in: [src/ui/editors/select2.tsx:1172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1172)

#### Returns

`void`

***

### focusSearch()

> `protected` **focusSearch**(): `void`

Defined in: [src/ui/editors/select2.tsx:2443](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2443)

#### Returns

`void`

***

### getMaximumSelectionSize()

> `protected` **getMaximumSelectionSize**(): `any`

Defined in: [src/ui/editors/select2.tsx:2002](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2002)

#### Returns

`any`

***

### getPlaceholder()

> `protected` **getPlaceholder**(): `string`

Defined in: [src/ui/editors/select2.tsx:2464](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2464)

#### Returns

`string`

***

### getPlaceholderOption()

> `protected` **getPlaceholderOption**(): `HTMLOptionElement`

Defined in: [src/ui/editors/select2.tsx:2472](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2472)

#### Returns

`HTMLOptionElement`

***

### handleSearchBlur()

> `protected` **handleSearchBlur**(): `void`

Defined in: [src/ui/editors/select2.tsx:2196](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2196)

#### Returns

`void`

***

### handleSearchFocus()

> `protected` **handleSearchFocus**(): `void`

Defined in: [src/ui/editors/select2.tsx:2192](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2192)

#### Returns

`void`

***

### handleSearchInput()

> `protected` **handleSearchInput**(): `void`

Defined in: [src/ui/editors/select2.tsx:2188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2188)

#### Returns

`void`

***

### highlight()

> `protected` **highlight**(`index?`): `number`

Defined in: [src/ui/editors/select2.tsx:2071](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2071)

#### Parameters

##### index?

`number`

#### Returns

`number`

***

### highlightUnderEvent()

> `protected` **highlightUnderEvent**(`event`): `void`

Defined in: [src/ui/editors/select2.tsx:2115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2115)

#### Parameters

##### event

`Event`

#### Returns

`void`

***

### init()

> **init**(`opts`): `void`

Defined in: [src/ui/editors/select2.tsx:1180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1180)

#### Parameters

##### opts

[`Select2Options`](../interfaces/Select2Options.md)

#### Returns

`void`

***

### initContainer()

> `abstract` `protected` **initContainer**(): `void`

Defined in: [src/ui/editors/select2.tsx:1174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1174)

#### Returns

`void`

***

### initContainerWidth()

> `protected` **initContainerWidth**(): `void`

Defined in: [src/ui/editors/select2.tsx:2492](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2492)

Get the desired width for the container element.  This is
derived first from option `width` passed to select2, then
the inline 'style' on the original element, and finally
falls back to the jQuery calculated element width.

#### Returns

`void`

***

### initSelection()

> `abstract` `protected` **initSelection**(): `void`

Defined in: [src/ui/editors/select2.tsx:1175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1175)

#### Returns

`void`

***

### isFocused()

> `abstract` **isFocused**(): `boolean`

Defined in: [src/ui/editors/select2.tsx:1173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1173)

#### Returns

`boolean`

***

### isInterfaceEnabled()

> `protected` **isInterfaceEnabled**(): `boolean`

Defined in: [src/ui/editors/select2.tsx:1671](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1671)

#### Returns

`boolean`

***

### loadMoreIfNeeded()

> `protected` **loadMoreIfNeeded**(): `void`

Defined in: [src/ui/editors/select2.tsx:2126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2126)

#### Returns

`void`

***

### monitorSource()

> `protected` **monitorSource**(): `void`

Defined in: [src/ui/editors/select2.tsx:1620](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1620)

Monitor the original element for changes and update select2 accordingly

#### Returns

`void`

***

### moveHighlight()

> `protected` **moveHighlight**(`delta`): `void`

Defined in: [src/ui/editors/select2.tsx:2057](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2057)

#### Parameters

##### delta

`number`

#### Returns

`void`

***

### onSelect()

> `abstract` `protected` **onSelect**(`item`, `options?`): `void`

Defined in: [src/ui/editors/select2.tsx:1176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1176)

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

Defined in: [src/ui/editors/select2.tsx:1846](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1846)

Opens the dropdown

#### Returns

`boolean`

whether or not dropdown was opened. This method will return false if, for example,
the dropdown is already open, or if the 'open' event listener on the element called preventDefault().

***

### opened()

> **opened**(): `boolean`

Defined in: [src/ui/editors/select2.tsx:1710](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1710)

#### Returns

`boolean`

***

### opening()

> `protected` **opening**(): `void`

Defined in: [src/ui/editors/select2.tsx:1868](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1868)

Performs the opening of the dropdown

#### Returns

`void`

***

### optionToData()

> **optionToData**(`element`): [`Select2Item`](../interfaces/Select2Item.md)

Defined in: [src/ui/editors/select2.tsx:1356](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1356)

#### Parameters

##### element

`HTMLOptGroupElement` | `HTMLOptionElement`

#### Returns

[`Select2Item`](../interfaces/Select2Item.md)

***

### positionDropdown()

> **positionDropdown**(): `void`

Defined in: [src/ui/editors/select2.tsx:1714](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1714)

#### Returns

`void`

***

### postprocessResults()

> `abstract` `protected` **postprocessResults**(`data`, `initial`, `noHighlightUpdate?`): `void`

Defined in: [src/ui/editors/select2.tsx:1177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1177)

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

Defined in: [src/ui/editors/select2.tsx:1406](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1406)

#### Parameters

##### opts

[`Select2Options`](../interfaces/Select2Options.md)

#### Returns

[`Select2Options`](../interfaces/Select2Options.md)

***

### readonly()

> **readonly**(`enabled?`): `void`

Defined in: [src/ui/editors/select2.tsx:1701](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1701)

#### Parameters

##### enabled?

`boolean`

#### Returns

`void`

***

### removeHighlight()

> `protected` **removeHighlight**(): `void`

Defined in: [src/ui/editors/select2.tsx:2099](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2099)

#### Returns

`void`

***

### selectHighlighted()

> `protected` **selectHighlighted**(`options?`): `void`

Defined in: [src/ui/editors/select2.tsx:2447](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2447)

#### Parameters

##### options?

`any`

#### Returns

`void`

***

### shouldOpen()

> `protected` **shouldOpen**(): `boolean`

Defined in: [src/ui/editors/select2.tsx:1824](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1824)

#### Returns

`boolean`

***

### tokenize()

> `protected` **tokenize**(): `string`

Defined in: [src/ui/editors/select2.tsx:2184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2184)

Default tokenizer function which does nothing

#### Returns

`string`

***

### touchMoved()

> `protected` **touchMoved**(): `void`

Defined in: [src/ui/editors/select2.tsx:2103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2103)

#### Returns

`void`

***

### triggerChange()

> `protected` **triggerChange**(`details?`): `void`

Defined in: [src/ui/editors/select2.tsx:1652](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1652)

Triggers the change event on the source element

#### Parameters

##### details?

`any`

#### Returns

`void`

***

### triggerSelect()

> `protected` **triggerSelect**(`data`): `boolean`

Defined in: [src/ui/editors/select2.tsx:1643](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1643)

#### Parameters

##### data

[`Select2Item`](../interfaces/Select2Item.md)

#### Returns

`boolean`

***

### updateResults()

> `protected` **updateResults**(`initial?`): `void`

Defined in: [src/ui/editors/select2.tsx:2257](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L2257)

#### Parameters

##### initial?

`boolean`

whether or not this is the call to this method right after the dropdown has been opened

#### Returns

`void`

***

### val()

> `abstract` **val**(`value?`): `string` \| `string`[]

Defined in: [src/ui/editors/select2.tsx:1178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L1178)

#### Parameters

##### value?

`string` | `string`[]

#### Returns

`string` \| `string`[]
