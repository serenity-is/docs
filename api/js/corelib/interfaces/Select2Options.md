[serenity-is/corelib](../README.md) / Select2Options

# Interface: Select2Options

Defined in: [src/ui/editors/select2.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L48)

## Properties

### adaptContainerCssClass()?

> `optional` **adaptContainerCssClass**: (`p1`) => `string`

Defined in: [src/ui/editors/select2.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L92)

#### Parameters

##### p1

`string`

#### Returns

`string`

***

### adaptDropdownCssClass()?

> `optional` **adaptDropdownCssClass**: (`p1`) => `string`

Defined in: [src/ui/editors/select2.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L93)

#### Parameters

##### p1

`string`

#### Returns

`string`

***

### ajax?

> `optional` **ajax**: [`Select2AjaxOptions`](Select2AjaxOptions.md)

Defined in: [src/ui/editors/select2.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L83)

***

### allowClear?

> `optional` **allowClear**: `boolean`

Defined in: [src/ui/editors/select2.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L58)

***

### blurOnChange?

> `optional` **blurOnChange**: `boolean`

Defined in: [src/ui/editors/select2.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L97)

***

### closeOnSelect?

> `optional` **closeOnSelect**: `boolean`

Defined in: [src/ui/editors/select2.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L60)

***

### containerCss?

> `optional` **containerCss**: `any`

Defined in: [src/ui/editors/select2.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L86)

***

### containerCssClass?

> `optional` **containerCssClass**: `any`

Defined in: [src/ui/editors/select2.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L87)

***

### createSearchChoice()?

> `optional` **createSearchChoice**: (`p1`) => [`Select2Item`](Select2Item.md)

Defined in: [src/ui/editors/select2.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L77)

#### Parameters

##### p1

`string`

#### Returns

[`Select2Item`](Select2Item.md)

***

### createSearchChoicePosition?

> `optional` **createSearchChoicePosition**: `string` \| (`list`, `item`) => `void`

Defined in: [src/ui/editors/select2.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L78)

***

### data?

> `optional` **data**: `any`

Defined in: [src/ui/editors/select2.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L84)

***

### dropdownAutoWidth?

> `optional` **dropdownAutoWidth**: `boolean`

Defined in: [src/ui/editors/select2.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L90)

***

### dropdownCss?

> `optional` **dropdownCss**: `any`

Defined in: [src/ui/editors/select2.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L88)

***

### dropdownCssClass?

> `optional` **dropdownCssClass**: `any`

Defined in: [src/ui/editors/select2.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L89)

***

### dropdownParent()?

> `optional` **dropdownParent**: (`input`) => `HTMLElement`

Defined in: [src/ui/editors/select2.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L91)

#### Parameters

##### input

`HTMLElement`

#### Returns

`HTMLElement`

***

### element?

> `optional` **element**: [`Select2Element`](../type-aliases/Select2Element.md)

Defined in: [src/ui/editors/select2.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L49)

***

### escapeMarkup()?

> `optional` **escapeMarkup**: (`p1`) => `string`

Defined in: [src/ui/editors/select2.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L94)

#### Parameters

##### p1

`string`

#### Returns

`string`

***

### formatAjaxError()?

> `optional` **formatAjaxError**: (`p1`, `p2`) => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L65)

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

Defined in: [src/ui/editors/select2.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L74)

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

Defined in: [src/ui/editors/select2.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L75)

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

Defined in: [src/ui/editors/select2.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L72)

#### Parameters

##### pageNumber

`number`

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### formatMatches()?

> `optional` **formatMatches**: (`matches`) => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L66)

#### Parameters

##### matches

`number`

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### formatNoMatches()?

> `optional` **formatNoMatches**: (`input`) => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L71)

#### Parameters

##### input

`string`

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### formatResult()?

> `optional` **formatResult**: (`p1`, `p2`, `p3`, `p4`) => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L68)

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

Defined in: [src/ui/editors/select2.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L69)

#### Parameters

##### p1

`any`

#### Returns

`string`

***

### formatSearching()?

> `optional` **formatSearching**: () => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L73)

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### formatSelection()?

> `optional` **formatSelection**: (`p1`, `p2`, `p3`) => [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L67)

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

Defined in: [src/ui/editors/select2.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L70)

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

Defined in: [src/ui/editors/select2.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L76)

#### Parameters

##### p1

`number`

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

***

### id()?

> `optional` **id**: (`p1`) => `string`

Defined in: [src/ui/editors/select2.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L62)

#### Parameters

##### p1

`any`

#### Returns

`string`

***

### initSelection()?

> `optional` **initSelection**: (`p1`, `p2`) => `void`

Defined in: [src/ui/editors/select2.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L79)

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

Defined in: [src/ui/editors/select2.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L98)

***

### matcher()?

> `optional` **matcher**: (`p1`, `p2`, `p3`) => `boolean`

Defined in: [src/ui/editors/select2.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L63)

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

Defined in: [src/ui/editors/select2.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L52)

***

### maximumSelectionSize?

> `optional` **maximumSelectionSize**: `any`

Defined in: [src/ui/editors/select2.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L54)

***

### minimumInputLength?

> `optional` **minimumInputLength**: `number`

Defined in: [src/ui/editors/select2.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L51)

***

### minimumResultsForSearch?

> `optional` **minimumResultsForSearch**: `number`

Defined in: [src/ui/editors/select2.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L53)

***

### multiple?

> `optional` **multiple**: `boolean`

Defined in: [src/ui/editors/select2.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L59)

***

### nextSearchTerm()?

> `optional` **nextSearchTerm**: (`p1`, `p2`) => `string`

Defined in: [src/ui/editors/select2.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L99)

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

Defined in: [src/ui/editors/select2.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L61)

***

### placeholder?

> `optional` **placeholder**: `string`

Defined in: [src/ui/editors/select2.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L55)

***

### placeholderOption?

> `optional` **placeholderOption**: `any`

Defined in: [src/ui/editors/select2.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L56)

***

### populateResults()?

> `optional` **populateResults**: (`container`, `results`, `query`) => `void`

Defined in: [src/ui/editors/select2.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L100)

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

Defined in: [src/ui/editors/select2.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L82)

#### Parameters

##### p1

[`Select2QueryOptions`](Select2QueryOptions.md)

#### Returns

`void`

***

### searchInputPlaceholder?

> `optional` **searchInputPlaceholder**: `string`

Defined in: [src/ui/editors/select2.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L95)

***

### selectOnBlur?

> `optional` **selectOnBlur**: `boolean`

Defined in: [src/ui/editors/select2.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L96)

***

### separator?

> `optional` **separator**: `string`

Defined in: [src/ui/editors/select2.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L57)

***

### shouldFocusInput()?

> `optional` **shouldFocusInput**: (`p1`) => `boolean`

Defined in: [src/ui/editors/select2.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L101)

#### Parameters

##### p1

`any`

#### Returns

`boolean`

***

### sortResults()?

> `optional` **sortResults**: (`p1`, `p2`, `p3`) => `any`

Defined in: [src/ui/editors/select2.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L64)

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

Defined in: [src/ui/editors/select2.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L85)

***

### tokenizer()?

> `optional` **tokenizer**: (`p1`, `p2`, `p3`, `p4`) => `string`

Defined in: [src/ui/editors/select2.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L80)

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

Defined in: [src/ui/editors/select2.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L81)

***

### width?

> `optional` **width**: `any`

Defined in: [src/ui/editors/select2.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L50)
