[@serenity-is/corelib](../README.md) / Select2Options

# Interface: Select2Options

Defined in: [src/ui/editors/select2.tsx:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L97)

Options for the [Select2](../classes/Select2.md) widget.

## Properties

### adaptContainerCssClass()?

> `optional` **adaptContainerCssClass**: (`cls`) => `string`

Defined in: [src/ui/editors/select2.tsx:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L185)

Callback that adapts the container CSS class.

#### Parameters

##### cls

`string`

#### Returns

`string`

***

### adaptDropdownCssClass()?

> `optional` **adaptDropdownCssClass**: (`cls`) => `string`

Defined in: [src/ui/editors/select2.tsx:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L187)

Callback that adapts the dropdown CSS class.

#### Parameters

##### cls

`string`

#### Returns

`string`

***

### ajax?

> `optional` **ajax**: [`Select2AjaxOptions`](Select2AjaxOptions.md)

Defined in: [src/ui/editors/select2.tsx:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L167)

Ajax options.

***

### allowClear?

> `optional` **allowClear**: `boolean`

Defined in: [src/ui/editors/select2.tsx:117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L117)

Whether the selection can be cleared.

***

### blurOnChange?

> `optional` **blurOnChange**: `boolean`

Defined in: [src/ui/editors/select2.tsx:195](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L195)

Whether to blur on change.

***

### closeOnSelect?

> `optional` **closeOnSelect**: `boolean`

Defined in: [src/ui/editors/select2.tsx:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L121)

Whether to close the dropdown on select.

***

### containerCss?

> `optional` **containerCss**: `Record`\<`string`, `string`\> \| () => `Record`\<`string`, `string`\>

Defined in: [src/ui/editors/select2.tsx:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L173)

Container CSS.

***

### containerCssClass?

> `optional` **containerCssClass**: `string` \| () => `string`

Defined in: [src/ui/editors/select2.tsx:175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L175)

Container CSS class.

***

### createSearchChoice()?

> `optional` **createSearchChoice**: (`term`) => [`Select2Item`](Select2Item.md)

Defined in: [src/ui/editors/select2.tsx:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L155)

Callback that creates a search choice.

#### Parameters

##### term

`string`

#### Returns

[`Select2Item`](Select2Item.md)

***

### createSearchChoicePosition?

> `optional` **createSearchChoicePosition**: `string` \| (`list`, `item`) => `void`

Defined in: [src/ui/editors/select2.tsx:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L157)

Position of the create-search-choice item.

***

### data?

> `optional` **data**: `any`

Defined in: [src/ui/editors/select2.tsx:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L169)

Static data.

***

### dropdownAutoWidth?

> `optional` **dropdownAutoWidth**: `boolean`

Defined in: [src/ui/editors/select2.tsx:181](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L181)

Whether the dropdown auto-widths.

***

### dropdownCss?

> `optional` **dropdownCss**: `Record`\<`string`, `string`\> \| () => `Record`\<`string`, `string`\>

Defined in: [src/ui/editors/select2.tsx:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L177)

Dropdown CSS.

***

### dropdownCssClass?

> `optional` **dropdownCssClass**: `string` \| () => `string`

Defined in: [src/ui/editors/select2.tsx:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L179)

Dropdown CSS class.

***

### dropdownParent()?

> `optional` **dropdownParent**: (`input`) => `HTMLElement`

Defined in: [src/ui/editors/select2.tsx:183](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L183)

Callback that returns the dropdown parent.

#### Parameters

##### input

`HTMLElement`

#### Returns

`HTMLElement`

***

### element?

> `optional` **element**: [`Select2Element`](../type-aliases/Select2Element.md)

Defined in: [src/ui/editors/select2.tsx:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L99)

The element to attach Select2 to.

***

### escapeMarkup()?

> `optional` **escapeMarkup**: (`markup`) => `string`

Defined in: [src/ui/editors/select2.tsx:189](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L189)

Callback that escapes markup.

#### Parameters

##### markup

`string`

#### Returns

`string`

***

### formatAjaxError()?

> `optional` **formatAjaxError**: (`data`, `info?`) => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.tsx:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L131)

Formatter for ajax errors.

#### Parameters

##### data

[`Select2Result`](Select2Result.md)

##### info?

`any`

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### formatInputTooLong()?

> `optional` **formatInputTooLong**: (`input`, `max`) => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.tsx:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L149)

Formatter for input-too-long text.

#### Parameters

##### input

`string`

##### max

`number`

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### formatInputTooShort()?

> `optional` **formatInputTooShort**: (`input`, `min`) => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.tsx:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L151)

Formatter for input-too-short text.

#### Parameters

##### input

`string`

##### min

`number`

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### formatLoadMore()?

> `optional` **formatLoadMore**: (`pageNumber`) => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.tsx:145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L145)

Formatter for load-more text.

#### Parameters

##### pageNumber

`number`

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### formatMatches()?

> `optional` **formatMatches**: (`matches`) => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.tsx:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L133)

Formatter for the matches count.

#### Parameters

##### matches

`number`

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### formatNoMatches()?

> `optional` **formatNoMatches**: (`input`) => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.tsx:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L143)

Formatter for no-matches text.

#### Parameters

##### input

`string`

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### formatResult()?

> `optional` **formatResult**: (`result`, `container`, `query`, `escapeMarkup`) => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.tsx:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L137)

Formatter for result items.

#### Parameters

##### result

[`Select2Item`](Select2Item.md)

##### container

`HTMLElement`

##### query

[`Select2QueryOptions`](Select2QueryOptions.md)

##### escapeMarkup

(`markup`) => `string`

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### formatResultCssClass()?

> `optional` **formatResultCssClass**: (`data`) => `string`

Defined in: [src/ui/editors/select2.tsx:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L139)

Formatter for result CSS classes.

#### Parameters

##### data

[`Select2Item`](Select2Item.md)

#### Returns

`string`

***

### formatSearching()?

> `optional` **formatSearching**: () => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.tsx:147](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L147)

Formatter for searching text.

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### formatSelection()?

> `optional` **formatSelection**: (`data`, `container`, `escapeMarkup`) => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.tsx:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L135)

Formatter for selected items.

#### Parameters

##### data

[`Select2Item`](Select2Item.md)

##### container

`HTMLElement`

##### escapeMarkup

(`markup`) => `string`

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### formatSelectionCssClass()?

> `optional` **formatSelectionCssClass**: (`item`, `container`) => `string`

Defined in: [src/ui/editors/select2.tsx:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L141)

Formatter for selection CSS classes.

#### Parameters

##### item

[`Select2Item`](Select2Item.md)

##### container

`HTMLElement`

#### Returns

`string`

***

### formatSelectionTooBig()?

> `optional` **formatSelectionTooBig**: (`limit`) => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.tsx:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L153)

Formatter for selection-too-big text.

#### Parameters

##### limit

`number`

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### id()?

> `optional` **id**: (`item`) => `string`

Defined in: [src/ui/editors/select2.tsx:125](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L125)

Callback that returns the id of an item.

#### Parameters

##### item

`any`

#### Returns

`string`

***

### initSelection()?

> `optional` **initSelection**: (`element`, `callback`) => `void`

Defined in: [src/ui/editors/select2.tsx:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L159)

Callback that initializes the selection.

#### Parameters

##### element

`HTMLElement`

##### callback

(`data`) => `void`

#### Returns

`void`

***

### loadMorePadding?

> `optional` **loadMorePadding**: `number`

Defined in: [src/ui/editors/select2.tsx:197](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L197)

Padding for load-more.

***

### matcher()?

> `optional` **matcher**: (`term`, `text`, `data?`) => `boolean`

Defined in: [src/ui/editors/select2.tsx:127](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L127)

Custom matcher function.

#### Parameters

##### term

`string`

##### text

`string`

##### data?

`any`

#### Returns

`boolean`

***

### maximumInputLength?

> `optional` **maximumInputLength**: `number`

Defined in: [src/ui/editors/select2.tsx:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L105)

Maximum input length.

***

### maximumSelectionSize?

> `optional` **maximumSelectionSize**: `number` \| () => `number`

Defined in: [src/ui/editors/select2.tsx:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L109)

Maximum number of selectable items.

***

### minimumInputLength?

> `optional` **minimumInputLength**: `number`

Defined in: [src/ui/editors/select2.tsx:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L103)

Minimum input length before searching.

***

### minimumResultsForSearch?

> `optional` **minimumResultsForSearch**: `number`

Defined in: [src/ui/editors/select2.tsx:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L107)

Minimum results required to show the search box.

***

### multiple?

> `optional` **multiple**: `boolean`

Defined in: [src/ui/editors/select2.tsx:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L119)

Whether multiple items can be selected.

***

### nextSearchTerm()?

> `optional` **nextSearchTerm**: (`selectedObject`, `currentSearchTerm`) => `string`

Defined in: [src/ui/editors/select2.tsx:199](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L199)

Callback that returns the next search term.

#### Parameters

##### selectedObject

[`Select2Item`](Select2Item.md)

##### currentSearchTerm

`string`

#### Returns

`string`

***

### openOnEnter?

> `optional` **openOnEnter**: `boolean`

Defined in: [src/ui/editors/select2.tsx:123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L123)

Whether to open the dropdown on enter.

***

### placeholder?

> `optional` **placeholder**: `string`

Defined in: [src/ui/editors/select2.tsx:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L111)

Placeholder text.

***

### placeholderOption?

> `optional` **placeholderOption**: `"first"` \| (`select`) => `HTMLOptionElement`

Defined in: [src/ui/editors/select2.tsx:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L113)

Placeholder option.

***

### populateResults()?

> `optional` **populateResults**: (`container`, `results`, `query`) => `void`

Defined in: [src/ui/editors/select2.tsx:201](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L201)

Callback that populates results.

#### Parameters

##### container

`HTMLElement`

##### results

[`Select2Item`](Select2Item.md)[]

##### query

[`Select2QueryOptions`](Select2QueryOptions.md)

#### Returns

`void`

***

### query()?

> `optional` **query**: (`query`) => `void`

Defined in: [src/ui/editors/select2.tsx:165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L165)

Query callback.

#### Parameters

##### query

[`Select2QueryOptions`](Select2QueryOptions.md)

#### Returns

`void`

***

### searchInputPlaceholder?

> `optional` **searchInputPlaceholder**: `string`

Defined in: [src/ui/editors/select2.tsx:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L191)

Placeholder for the search input.

***

### selectOnBlur?

> `optional` **selectOnBlur**: `boolean`

Defined in: [src/ui/editors/select2.tsx:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L193)

Whether to select on blur.

***

### separator?

> `optional` **separator**: `string`

Defined in: [src/ui/editors/select2.tsx:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L115)

Separator for multiple values.

***

### shouldFocusInput()?

> `optional` **shouldFocusInput**: (`instance`) => `boolean`

Defined in: [src/ui/editors/select2.tsx:205](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L205)

Callback that determines whether to focus the input. Defaults to not focusing the input
on touch devices, so that the virtual keyboard does not cover the dropdown. Hardware
keyboard input is still routed to the widget.

#### Parameters

##### instance

[`AbstractSelect2`](../classes/AbstractSelect2.md)

#### Returns

`boolean`

***

### sortResults()?

> `optional` **sortResults**: (`results`, `container`, `query`) => [`Select2Item`](Select2Item.md)[]

Defined in: [src/ui/editors/select2.tsx:129](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L129)

Callback that sorts results.

#### Parameters

##### results

[`Select2Item`](Select2Item.md)[]

##### container

`HTMLElement`

##### query

[`Select2QueryOptions`](Select2QueryOptions.md)

#### Returns

[`Select2Item`](Select2Item.md)[]

***

### tags?

> `optional` **tags**: (`string` \| [`Select2Item`](Select2Item.md))[] \| () => (`string` \| [`Select2Item`](Select2Item.md))[]

Defined in: [src/ui/editors/select2.tsx:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L171)

Tags for tag mode.

***

### tokenizer()?

> `optional` **tokenizer**: (`input`, `selection`, `selectCallback`, `opts`) => `string`

Defined in: [src/ui/editors/select2.tsx:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L161)

Tokenizer function.

#### Parameters

##### input

`string`

##### selection

[`Select2Item`](Select2Item.md)[]

##### selectCallback

(`data`) => `void`

##### opts

`Select2Options`

#### Returns

`string`

***

### tokenSeparators?

> `optional` **tokenSeparators**: `string`[]

Defined in: [src/ui/editors/select2.tsx:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L163)

Token separators.

***

### width?

> `optional` **width**: `string` \| () => `string`

Defined in: [src/ui/editors/select2.tsx:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L101)

Width of the widget.
