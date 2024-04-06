[@serenity-is/corelib](../README.md) / Select2Options

# Interface: Select2Options

## Table of contents

### Properties

- [adaptContainerCssClass](Select2Options.md#adaptcontainercssclass)
- [adaptDropdownCssClass](Select2Options.md#adaptdropdowncssclass)
- [ajax](Select2Options.md#ajax)
- [allowClear](Select2Options.md#allowclear)
- [blurOnChange](Select2Options.md#bluronchange)
- [closeOnSelect](Select2Options.md#closeonselect)
- [containerCss](Select2Options.md#containercss)
- [containerCssClass](Select2Options.md#containercssclass)
- [createSearchChoice](Select2Options.md#createsearchchoice)
- [createSearchChoicePosition](Select2Options.md#createsearchchoiceposition)
- [data](Select2Options.md#data)
- [dropdownAutoWidth](Select2Options.md#dropdownautowidth)
- [dropdownCss](Select2Options.md#dropdowncss)
- [dropdownCssClass](Select2Options.md#dropdowncssclass)
- [dropdownParent](Select2Options.md#dropdownparent)
- [element](Select2Options.md#element)
- [escapeMarkup](Select2Options.md#escapemarkup)
- [formatAjaxError](Select2Options.md#formatajaxerror)
- [formatInputTooLong](Select2Options.md#formatinputtoolong)
- [formatInputTooShort](Select2Options.md#formatinputtooshort)
- [formatLoadMore](Select2Options.md#formatloadmore)
- [formatMatches](Select2Options.md#formatmatches)
- [formatNoMatches](Select2Options.md#formatnomatches)
- [formatResult](Select2Options.md#formatresult)
- [formatResultCssClass](Select2Options.md#formatresultcssclass)
- [formatSearching](Select2Options.md#formatsearching)
- [formatSelection](Select2Options.md#formatselection)
- [formatSelectionCssClass](Select2Options.md#formatselectioncssclass)
- [formatSelectionTooBig](Select2Options.md#formatselectiontoobig)
- [id](Select2Options.md#id)
- [initSelection](Select2Options.md#initselection)
- [loadMorePadding](Select2Options.md#loadmorepadding)
- [matcher](Select2Options.md#matcher)
- [maximumInputLength](Select2Options.md#maximuminputlength)
- [maximumSelectionSize](Select2Options.md#maximumselectionsize)
- [minimumInputLength](Select2Options.md#minimuminputlength)
- [minimumResultsForSearch](Select2Options.md#minimumresultsforsearch)
- [multiple](Select2Options.md#multiple)
- [nextSearchTerm](Select2Options.md#nextsearchterm)
- [openOnEnter](Select2Options.md#openonenter)
- [placeholder](Select2Options.md#placeholder)
- [placeholderOption](Select2Options.md#placeholderoption)
- [populateResults](Select2Options.md#populateresults)
- [query](Select2Options.md#query)
- [searchInputPlaceholder](Select2Options.md#searchinputplaceholder)
- [selectOnBlur](Select2Options.md#selectonblur)
- [separator](Select2Options.md#separator)
- [shouldFocusInput](Select2Options.md#shouldfocusinput)
- [sortResults](Select2Options.md#sortresults)
- [tags](Select2Options.md#tags)
- [tokenSeparators](Select2Options.md#tokenseparators)
- [tokenizer](Select2Options.md#tokenizer)
- [width](Select2Options.md#width)

## Properties

### adaptContainerCssClass

• `Optional` **adaptContainerCssClass**: (`p1`: `string`) => `string`

#### Type declaration

▸ (`p1`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `string` |

##### Returns

`string`

#### Defined in

[src/ui/editors/select2.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L91)

___

### adaptDropdownCssClass

• `Optional` **adaptDropdownCssClass**: (`p1`: `string`) => `string`

#### Type declaration

▸ (`p1`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `string` |

##### Returns

`string`

#### Defined in

[src/ui/editors/select2.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L92)

___

### ajax

• `Optional` **ajax**: [`Select2AjaxOptions`](Select2AjaxOptions.md)

#### Defined in

[src/ui/editors/select2.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L82)

___

### allowClear

• `Optional` **allowClear**: `boolean`

#### Defined in

[src/ui/editors/select2.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L57)

___

### blurOnChange

• `Optional` **blurOnChange**: `boolean`

#### Defined in

[src/ui/editors/select2.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L96)

___

### closeOnSelect

• `Optional` **closeOnSelect**: `boolean`

#### Defined in

[src/ui/editors/select2.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L59)

___

### containerCss

• `Optional` **containerCss**: `any`

#### Defined in

[src/ui/editors/select2.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L85)

___

### containerCssClass

• `Optional` **containerCssClass**: `any`

#### Defined in

[src/ui/editors/select2.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L86)

___

### createSearchChoice

• `Optional` **createSearchChoice**: (`p1`: `string`) => [`Select2Item`](Select2Item.md)

#### Type declaration

▸ (`p1`): [`Select2Item`](Select2Item.md)

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `string` |

##### Returns

[`Select2Item`](Select2Item.md)

#### Defined in

[src/ui/editors/select2.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L76)

___

### createSearchChoicePosition

• `Optional` **createSearchChoicePosition**: `string` \| (`list`: [`Select2Item`](Select2Item.md)[], `item`: [`Select2Item`](Select2Item.md)) => `void`

#### Defined in

[src/ui/editors/select2.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L77)

___

### data

• `Optional` **data**: `any`

#### Defined in

[src/ui/editors/select2.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L83)

___

### dropdownAutoWidth

• `Optional` **dropdownAutoWidth**: `boolean`

#### Defined in

[src/ui/editors/select2.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L89)

___

### dropdownCss

• `Optional` **dropdownCss**: `any`

#### Defined in

[src/ui/editors/select2.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L87)

___

### dropdownCssClass

• `Optional` **dropdownCssClass**: `any`

#### Defined in

[src/ui/editors/select2.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L88)

___

### dropdownParent

• `Optional` **dropdownParent**: (`input`: `HTMLElement`) => `HTMLElement`

#### Type declaration

▸ (`input`): `HTMLElement`

##### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `HTMLElement` |

##### Returns

`HTMLElement`

#### Defined in

[src/ui/editors/select2.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L90)

___

### element

• `Optional` **element**: [`Select2Element`](../README.md#select2element)

#### Defined in

[src/ui/editors/select2.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L48)

___

### escapeMarkup

• `Optional` **escapeMarkup**: (`p1`: `string`) => `string`

#### Type declaration

▸ (`p1`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `string` |

##### Returns

`string`

#### Defined in

[src/ui/editors/select2.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L93)

___

### formatAjaxError

• `Optional` **formatAjaxError**: (`p1`: `any`, `p2`: `any`) => [`Select2FormatResult`](../README.md#select2formatresult)

#### Type declaration

▸ (`p1`, `p2`): [`Select2FormatResult`](../README.md#select2formatresult)

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `any` |
| `p2` | `any` |

##### Returns

[`Select2FormatResult`](../README.md#select2formatresult)

#### Defined in

[src/ui/editors/select2.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L64)

___

### formatInputTooLong

• `Optional` **formatInputTooLong**: (`input`: `string`, `max`: `number`) => [`Select2FormatResult`](../README.md#select2formatresult)

#### Type declaration

▸ (`input`, `max`): [`Select2FormatResult`](../README.md#select2formatresult)

##### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `string` |
| `max` | `number` |

##### Returns

[`Select2FormatResult`](../README.md#select2formatresult)

#### Defined in

[src/ui/editors/select2.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L73)

___

### formatInputTooShort

• `Optional` **formatInputTooShort**: (`input`: `string`, `min`: `number`) => [`Select2FormatResult`](../README.md#select2formatresult)

#### Type declaration

▸ (`input`, `min`): [`Select2FormatResult`](../README.md#select2formatresult)

##### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `string` |
| `min` | `number` |

##### Returns

[`Select2FormatResult`](../README.md#select2formatresult)

#### Defined in

[src/ui/editors/select2.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L74)

___

### formatLoadMore

• `Optional` **formatLoadMore**: (`pageNumber`: `number`) => [`Select2FormatResult`](../README.md#select2formatresult)

#### Type declaration

▸ (`pageNumber`): [`Select2FormatResult`](../README.md#select2formatresult)

##### Parameters

| Name | Type |
| :------ | :------ |
| `pageNumber` | `number` |

##### Returns

[`Select2FormatResult`](../README.md#select2formatresult)

#### Defined in

[src/ui/editors/select2.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L71)

___

### formatMatches

• `Optional` **formatMatches**: (`matches`: `number`) => [`Select2FormatResult`](../README.md#select2formatresult)

#### Type declaration

▸ (`matches`): [`Select2FormatResult`](../README.md#select2formatresult)

##### Parameters

| Name | Type |
| :------ | :------ |
| `matches` | `number` |

##### Returns

[`Select2FormatResult`](../README.md#select2formatresult)

#### Defined in

[src/ui/editors/select2.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L65)

___

### formatNoMatches

• `Optional` **formatNoMatches**: (`input`: `string`) => [`Select2FormatResult`](../README.md#select2formatresult)

#### Type declaration

▸ (`input`): [`Select2FormatResult`](../README.md#select2formatresult)

##### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `string` |

##### Returns

[`Select2FormatResult`](../README.md#select2formatresult)

#### Defined in

[src/ui/editors/select2.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L70)

___

### formatResult

• `Optional` **formatResult**: (`p1`: `any`, `p2`: `HTMLElement`, `p3`: `any`, `p4`: (`p1`: `string`) => `string`) => [`Select2FormatResult`](../README.md#select2formatresult)

#### Type declaration

▸ (`p1`, `p2`, `p3`, `p4`): [`Select2FormatResult`](../README.md#select2formatresult)

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `any` |
| `p2` | `HTMLElement` |
| `p3` | `any` |
| `p4` | (`p1`: `string`) => `string` |

##### Returns

[`Select2FormatResult`](../README.md#select2formatresult)

#### Defined in

[src/ui/editors/select2.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L67)

___

### formatResultCssClass

• `Optional` **formatResultCssClass**: (`p1`: `any`) => `string`

#### Type declaration

▸ (`p1`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `any` |

##### Returns

`string`

#### Defined in

[src/ui/editors/select2.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L68)

___

### formatSearching

• `Optional` **formatSearching**: () => [`Select2FormatResult`](../README.md#select2formatresult)

#### Type declaration

▸ (): [`Select2FormatResult`](../README.md#select2formatresult)

##### Returns

[`Select2FormatResult`](../README.md#select2formatresult)

#### Defined in

[src/ui/editors/select2.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L72)

___

### formatSelection

• `Optional` **formatSelection**: (`p1`: `any`, `p2`: `HTMLElement`, `p3`: (`p1`: `string`) => `string`) => [`Select2FormatResult`](../README.md#select2formatresult)

#### Type declaration

▸ (`p1`, `p2`, `p3`): [`Select2FormatResult`](../README.md#select2formatresult)

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `any` |
| `p2` | `HTMLElement` |
| `p3` | (`p1`: `string`) => `string` |

##### Returns

[`Select2FormatResult`](../README.md#select2formatresult)

#### Defined in

[src/ui/editors/select2.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L66)

___

### formatSelectionCssClass

• `Optional` **formatSelectionCssClass**: (`item`: [`Select2Item`](Select2Item.md), `container`: `HTMLElement`) => `string`

#### Type declaration

▸ (`item`, `container`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `item` | [`Select2Item`](Select2Item.md) |
| `container` | `HTMLElement` |

##### Returns

`string`

#### Defined in

[src/ui/editors/select2.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L69)

___

### formatSelectionTooBig

• `Optional` **formatSelectionTooBig**: (`p1`: `number`) => [`Select2FormatResult`](../README.md#select2formatresult)

#### Type declaration

▸ (`p1`): [`Select2FormatResult`](../README.md#select2formatresult)

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `number` |

##### Returns

[`Select2FormatResult`](../README.md#select2formatresult)

#### Defined in

[src/ui/editors/select2.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L75)

___

### id

• `Optional` **id**: (`p1`: `any`) => `string`

#### Type declaration

▸ (`p1`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `any` |

##### Returns

`string`

#### Defined in

[src/ui/editors/select2.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L61)

___

### initSelection

• `Optional` **initSelection**: (`p1`: `HTMLElement`, `p2`: (`p1`: `any`) => `void`) => `void`

#### Type declaration

▸ (`p1`, `p2`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `HTMLElement` |
| `p2` | (`p1`: `any`) => `void` |

##### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L78)

___

### loadMorePadding

• `Optional` **loadMorePadding**: `number`

#### Defined in

[src/ui/editors/select2.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L97)

___

### matcher

• `Optional` **matcher**: (`p1`: `string`, `p2`: `string`, `p3`: `HTMLElement`) => `boolean`

#### Type declaration

▸ (`p1`, `p2`, `p3`): `boolean`

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `string` |
| `p2` | `string` |
| `p3` | `HTMLElement` |

##### Returns

`boolean`

#### Defined in

[src/ui/editors/select2.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L62)

___

### maximumInputLength

• `Optional` **maximumInputLength**: `number`

#### Defined in

[src/ui/editors/select2.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L51)

___

### maximumSelectionSize

• `Optional` **maximumSelectionSize**: `any`

#### Defined in

[src/ui/editors/select2.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L53)

___

### minimumInputLength

• `Optional` **minimumInputLength**: `number`

#### Defined in

[src/ui/editors/select2.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L50)

___

### minimumResultsForSearch

• `Optional` **minimumResultsForSearch**: `number`

#### Defined in

[src/ui/editors/select2.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L52)

___

### multiple

• `Optional` **multiple**: `boolean`

#### Defined in

[src/ui/editors/select2.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L58)

___

### nextSearchTerm

• `Optional` **nextSearchTerm**: (`p1`: `any`, `p2`: `string`) => `string`

#### Type declaration

▸ (`p1`, `p2`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `any` |
| `p2` | `string` |

##### Returns

`string`

#### Defined in

[src/ui/editors/select2.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L98)

___

### openOnEnter

• `Optional` **openOnEnter**: `boolean`

#### Defined in

[src/ui/editors/select2.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L60)

___

### placeholder

• `Optional` **placeholder**: `string`

#### Defined in

[src/ui/editors/select2.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L54)

___

### placeholderOption

• `Optional` **placeholderOption**: `any`

#### Defined in

[src/ui/editors/select2.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L55)

___

### populateResults

• `Optional` **populateResults**: (`container`: `HTMLElement`, `results`: [`Select2Item`](Select2Item.md)[], `query`: [`Select2QueryOptions`](Select2QueryOptions.md)) => `void`

#### Type declaration

▸ (`container`, `results`, `query`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `container` | `HTMLElement` |
| `results` | [`Select2Item`](Select2Item.md)[] |
| `query` | [`Select2QueryOptions`](Select2QueryOptions.md) |

##### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L99)

___

### query

• `Optional` **query**: (`p1`: [`Select2QueryOptions`](Select2QueryOptions.md)) => `void`

#### Type declaration

▸ (`p1`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | [`Select2QueryOptions`](Select2QueryOptions.md) |

##### Returns

`void`

#### Defined in

[src/ui/editors/select2.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L81)

___

### searchInputPlaceholder

• `Optional` **searchInputPlaceholder**: `string`

#### Defined in

[src/ui/editors/select2.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L94)

___

### selectOnBlur

• `Optional` **selectOnBlur**: `boolean`

#### Defined in

[src/ui/editors/select2.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L95)

___

### separator

• `Optional` **separator**: `string`

#### Defined in

[src/ui/editors/select2.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L56)

___

### shouldFocusInput

• `Optional` **shouldFocusInput**: (`p1`: `any`) => `boolean`

#### Type declaration

▸ (`p1`): `boolean`

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `any` |

##### Returns

`boolean`

#### Defined in

[src/ui/editors/select2.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L100)

___

### sortResults

• `Optional` **sortResults**: (`p1`: `any`, `p2`: `HTMLElement`, `p3`: `any`) => `any`

#### Type declaration

▸ (`p1`, `p2`, `p3`): `any`

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `any` |
| `p2` | `HTMLElement` |
| `p3` | `any` |

##### Returns

`any`

#### Defined in

[src/ui/editors/select2.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L63)

___

### tags

• `Optional` **tags**: (`string` \| [`Select2Item`](Select2Item.md))[] \| () => (`string` \| [`Select2Item`](Select2Item.md))[]

#### Defined in

[src/ui/editors/select2.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L84)

___

### tokenSeparators

• `Optional` **tokenSeparators**: `any`

#### Defined in

[src/ui/editors/select2.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L80)

___

### tokenizer

• `Optional` **tokenizer**: (`p1`: `string`, `p2`: `any`, `p3`: (`p1`: `any`) => `any`, `p4`: `any`) => `string`

#### Type declaration

▸ (`p1`, `p2`, `p3`, `p4`): `string`

##### Parameters

| Name | Type |
| :------ | :------ |
| `p1` | `string` |
| `p2` | `any` |
| `p3` | (`p1`: `any`) => `any` |
| `p4` | `any` |

##### Returns

`string`

#### Defined in

[src/ui/editors/select2.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L79)

___

### width

• `Optional` **width**: `any`

#### Defined in

[src/ui/editors/select2.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.ts#L49)
