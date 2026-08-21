[@serenity-is/corelib](../README.md) / Select2Options

# Interface: Select2Options

Defined in: [src/ui/editors/select2.tsx:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L93)

Options for the [Select2](../classes/Select2.md) widget.

## Properties

### adaptContainerCssClass()?

> `optional` **adaptContainerCssClass**: (`p1`) => `string`

Defined in: [src/ui/editors/select2.tsx:181](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L181)

Callback that adapts the container CSS class.

#### Parameters

##### p1

`string`

#### Returns

`string`

***

### adaptDropdownCssClass()?

> `optional` **adaptDropdownCssClass**: (`p1`) => `string`

Defined in: [src/ui/editors/select2.tsx:183](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L183)

Callback that adapts the dropdown CSS class.

#### Parameters

##### p1

`string`

#### Returns

`string`

***

### ajax?

> `optional` **ajax**: [`Select2AjaxOptions`](Select2AjaxOptions.md)

Defined in: [src/ui/editors/select2.tsx:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L163)

Ajax options.

***

### allowClear?

> `optional` **allowClear**: `boolean`

Defined in: [src/ui/editors/select2.tsx:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L113)

Whether the selection can be cleared.

***

### blurOnChange?

> `optional` **blurOnChange**: `boolean`

Defined in: [src/ui/editors/select2.tsx:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L191)

Whether to blur on change.

***

### closeOnSelect?

> `optional` **closeOnSelect**: `boolean`

Defined in: [src/ui/editors/select2.tsx:117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L117)

Whether to close the dropdown on select.

***

### containerCss?

> `optional` **containerCss**: `any`

Defined in: [src/ui/editors/select2.tsx:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L169)

Container CSS.

***

### containerCssClass?

> `optional` **containerCssClass**: `any`

Defined in: [src/ui/editors/select2.tsx:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L171)

Container CSS class.

***

### createSearchChoice()?

> `optional` **createSearchChoice**: (`p1`) => [`Select2Item`](Select2Item.md)

Defined in: [src/ui/editors/select2.tsx:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L151)

Callback that creates a search choice.

#### Parameters

##### p1

`string`

#### Returns

[`Select2Item`](Select2Item.md)

***

### createSearchChoicePosition?

> `optional` **createSearchChoicePosition**: `string` \| (`list`, `item`) => `void`

Defined in: [src/ui/editors/select2.tsx:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L153)

Position of the create-search-choice item.

***

### data?

> `optional` **data**: `any`

Defined in: [src/ui/editors/select2.tsx:165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L165)

Static data.

***

### dropdownAutoWidth?

> `optional` **dropdownAutoWidth**: `boolean`

Defined in: [src/ui/editors/select2.tsx:177](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L177)

Whether the dropdown auto-widths.

***

### dropdownCss?

> `optional` **dropdownCss**: `any`

Defined in: [src/ui/editors/select2.tsx:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L173)

Dropdown CSS.

***

### dropdownCssClass?

> `optional` **dropdownCssClass**: `any`

Defined in: [src/ui/editors/select2.tsx:175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L175)

Dropdown CSS class.

***

### dropdownParent()?

> `optional` **dropdownParent**: (`input`) => `HTMLElement`

Defined in: [src/ui/editors/select2.tsx:179](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L179)

Callback that returns the dropdown parent.

#### Parameters

##### input

`HTMLElement`

#### Returns

`HTMLElement`

***

### element?

> `optional` **element**: [`Select2Element`](../type-aliases/Select2Element.md)

Defined in: [src/ui/editors/select2.tsx:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L95)

The element to attach Select2 to.

***

### escapeMarkup()?

> `optional` **escapeMarkup**: (`p1`) => `string`

Defined in: [src/ui/editors/select2.tsx:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L185)

Callback that escapes markup.

#### Parameters

##### p1

`string`

#### Returns

`string`

***

### formatAjaxError()?

> `optional` **formatAjaxError**: (`p1`, `p2`) => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.tsx:127](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L127)

Formatter for ajax errors.

#### Parameters

##### p1

`any`

##### p2

`any`

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### formatInputTooLong()?

> `optional` **formatInputTooLong**: (`input`, `max`) => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.tsx:145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L145)

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

Defined in: [src/ui/editors/select2.tsx:147](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L147)

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

Defined in: [src/ui/editors/select2.tsx:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L141)

Formatter for load-more text.

#### Parameters

##### pageNumber

`number`

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### formatMatches()?

> `optional` **formatMatches**: (`matches`) => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.tsx:129](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L129)

Formatter for the matches count.

#### Parameters

##### matches

`number`

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### formatNoMatches()?

> `optional` **formatNoMatches**: (`input`) => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.tsx:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L139)

Formatter for no-matches text.

#### Parameters

##### input

`string`

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### formatResult()?

> `optional` **formatResult**: (`p1`, `p2`, `p3`, `p4`) => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.tsx:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L133)

Formatter for result items.

#### Parameters

##### p1

`any`

##### p2

`HTMLElement`

##### p3

`any`

##### p4

(`p1`) => `string`

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### formatResultCssClass()?

> `optional` **formatResultCssClass**: (`p1`) => `string`

Defined in: [src/ui/editors/select2.tsx:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L135)

Formatter for result CSS classes.

#### Parameters

##### p1

`any`

#### Returns

`string`

***

### formatSearching()?

> `optional` **formatSearching**: () => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.tsx:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L143)

Formatter for searching text.

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### formatSelection()?

> `optional` **formatSelection**: (`p1`, `p2`, `p3`) => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.tsx:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L131)

Formatter for selected items.

#### Parameters

##### p1

`any`

##### p2

`HTMLElement`

##### p3

(`p1`) => `string`

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### formatSelectionCssClass()?

> `optional` **formatSelectionCssClass**: (`item`, `container`) => `string`

Defined in: [src/ui/editors/select2.tsx:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L137)

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

> `optional` **formatSelectionTooBig**: (`p1`) => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.tsx:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L149)

Formatter for selection-too-big text.

#### Parameters

##### p1

`number`

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### id()?

> `optional` **id**: (`p1`) => `string`

Defined in: [src/ui/editors/select2.tsx:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L121)

Callback that returns the id of an item.

#### Parameters

##### p1

`any`

#### Returns

`string`

***

### initSelection()?

> `optional` **initSelection**: (`p1`, `p2`) => `void`

Defined in: [src/ui/editors/select2.tsx:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L155)

Callback that initializes the selection.

#### Parameters

##### p1

`HTMLElement`

##### p2

(`p1`) => `void`

#### Returns

`void`

***

### loadMorePadding?

> `optional` **loadMorePadding**: `number`

Defined in: [src/ui/editors/select2.tsx:193](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L193)

Padding for load-more.

***

### matcher()?

> `optional` **matcher**: (`p1`, `p2`, `p3`) => `boolean`

Defined in: [src/ui/editors/select2.tsx:123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L123)

Custom matcher function.

#### Parameters

##### p1

`string`

##### p2

`string`

##### p3

`HTMLElement`

#### Returns

`boolean`

***

### maximumInputLength?

> `optional` **maximumInputLength**: `number`

Defined in: [src/ui/editors/select2.tsx:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L101)

Maximum input length.

***

### maximumSelectionSize?

> `optional` **maximumSelectionSize**: `any`

Defined in: [src/ui/editors/select2.tsx:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L105)

Maximum number of selectable items.

***

### minimumInputLength?

> `optional` **minimumInputLength**: `number`

Defined in: [src/ui/editors/select2.tsx:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L99)

Minimum input length before searching.

***

### minimumResultsForSearch?

> `optional` **minimumResultsForSearch**: `number`

Defined in: [src/ui/editors/select2.tsx:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L103)

Minimum results required to show the search box.

***

### multiple?

> `optional` **multiple**: `boolean`

Defined in: [src/ui/editors/select2.tsx:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L115)

Whether multiple items can be selected.

***

### nextSearchTerm()?

> `optional` **nextSearchTerm**: (`p1`, `p2`) => `string`

Defined in: [src/ui/editors/select2.tsx:195](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L195)

Callback that returns the next search term.

#### Parameters

##### p1

`any`

##### p2

`string`

#### Returns

`string`

***

### openOnEnter?

> `optional` **openOnEnter**: `boolean`

Defined in: [src/ui/editors/select2.tsx:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L119)

Whether to open the dropdown on enter.

***

### placeholder?

> `optional` **placeholder**: `string`

Defined in: [src/ui/editors/select2.tsx:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L107)

Placeholder text.

***

### placeholderOption?

> `optional` **placeholderOption**: `any`

Defined in: [src/ui/editors/select2.tsx:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L109)

Placeholder option.

***

### populateResults()?

> `optional` **populateResults**: (`container`, `results`, `query`) => `void`

Defined in: [src/ui/editors/select2.tsx:197](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L197)

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

> `optional` **query**: (`p1`) => `void`

Defined in: [src/ui/editors/select2.tsx:161](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L161)

Query callback.

#### Parameters

##### p1

[`Select2QueryOptions`](Select2QueryOptions.md)

#### Returns

`void`

***

### searchInputPlaceholder?

> `optional` **searchInputPlaceholder**: `string`

Defined in: [src/ui/editors/select2.tsx:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L187)

Placeholder for the search input.

***

### selectOnBlur?

> `optional` **selectOnBlur**: `boolean`

Defined in: [src/ui/editors/select2.tsx:189](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L189)

Whether to select on blur.

***

### separator?

> `optional` **separator**: `string`

Defined in: [src/ui/editors/select2.tsx:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L111)

Separator for multiple values.

***

### shouldFocusInput()?

> `optional` **shouldFocusInput**: (`p1`) => `boolean`

Defined in: [src/ui/editors/select2.tsx:199](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L199)

Callback that determines whether to focus the input.

#### Parameters

##### p1

`any`

#### Returns

`boolean`

***

### sortResults()?

> `optional` **sortResults**: (`p1`, `p2`, `p3`) => `any`

Defined in: [src/ui/editors/select2.tsx:125](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L125)

Callback that sorts results.

#### Parameters

##### p1

`any`

##### p2

`HTMLElement`

##### p3

`any`

#### Returns

`any`

***

### tags?

> `optional` **tags**: (`string` \| [`Select2Item`](Select2Item.md))[] \| () => (`string` \| [`Select2Item`](Select2Item.md))[]

Defined in: [src/ui/editors/select2.tsx:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L167)

Tags for tag mode.

***

### tokenizer()?

> `optional` **tokenizer**: (`p1`, `p2`, `p3`, `p4`) => `string`

Defined in: [src/ui/editors/select2.tsx:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L157)

Tokenizer function.

#### Parameters

##### p1

`string`

##### p2

`any`

##### p3

(`p1`) => `any`

##### p4

`any`

#### Returns

`string`

***

### tokenSeparators?

> `optional` **tokenSeparators**: `any`

Defined in: [src/ui/editors/select2.tsx:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L159)

Token separators.

***

### width?

> `optional` **width**: `any`

Defined in: [src/ui/editors/select2.tsx:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L97)

Width of the widget.
