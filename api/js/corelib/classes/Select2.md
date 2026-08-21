[@serenity-is/corelib](../README.md) / Select2

# Class: Select2

Defined in: [src/ui/editors/select2.tsx:568](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L568)

A searchable select widget ported from Select2.

## Constructors

### Constructor

> **new Select2**(`opts?`): `Select2`

Defined in: [src/ui/editors/select2.tsx:576](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L576)

Creates a Select2 widget.

#### Parameters

##### opts?

[`Select2Options`](../interfaces/Select2Options.md)

Select2 options.

#### Returns

`Select2`

## Properties

### ajaxDefaults

> `readonly` `static` **ajaxDefaults**: [`Select2AjaxOptions`](../interfaces/Select2AjaxOptions.md)

Defined in: [src/ui/editors/select2.tsx:756](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L756)

Default ajax options.

***

### defaults

> `readonly` `static` **defaults**: [`Select2Options`](../interfaces/Select2Options.md)

Defined in: [src/ui/editors/select2.tsx:765](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L765)

Default options for the Select2 widget.

## Accessors

### container

#### Get Signature

> **get** **container**(): `HTMLElement`

Defined in: [src/ui/editors/select2.tsx:620](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L620)

Returns the container element.

##### Returns

`HTMLElement`

The container element.

***

### data

#### Get Signature

> **get** **data**(): [`Select2Item`](../interfaces/Select2Item.md) \| [`Select2Item`](../interfaces/Select2Item.md)[]

Defined in: [src/ui/editors/select2.tsx:643](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L643)

Returns the current data.

##### Returns

[`Select2Item`](../interfaces/Select2Item.md) \| [`Select2Item`](../interfaces/Select2Item.md)[]

The selected item(s).

#### Set Signature

> **set** **data**(`value`): `void`

Defined in: [src/ui/editors/select2.tsx:649](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L649)

Sets the current data.

##### Parameters

###### value

The data to set.

[`Select2Item`](../interfaces/Select2Item.md) | [`Select2Item`](../interfaces/Select2Item.md)[]

##### Returns

`void`

***

### dropdown

#### Get Signature

> **get** **dropdown**(): `HTMLElement`

Defined in: [src/ui/editors/select2.tsx:628](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L628)

Returns the dropdown element.

##### Returns

`HTMLElement`

The dropdown element.

***

### isFocused

#### Get Signature

> **get** **isFocused**(): `boolean`

Defined in: [src/ui/editors/select2.tsx:679](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L679)

Whether the widget is focused.

##### Returns

`boolean`

True when focused.

***

### isMultiple

#### Get Signature

> **get** **isMultiple**(): `boolean`

Defined in: [src/ui/editors/select2.tsx:687](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L687)

Whether the widget allows multiple selection.

##### Returns

`boolean`

True when multiple.

***

### opened

#### Get Signature

> **get** **opened**(): `boolean`

Defined in: [src/ui/editors/select2.tsx:695](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L695)

Whether the dropdown is open.

##### Returns

`boolean`

True when open.

***

### search

#### Get Signature

> **get** **search**(): `HTMLInputElement`

Defined in: [src/ui/editors/select2.tsx:726](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L726)

Returns the search input element.

##### Returns

`HTMLInputElement`

The search input.

***

### val

#### Get Signature

> **get** **val**(): `string` \| `string`[]

Defined in: [src/ui/editors/select2.tsx:734](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L734)

Returns the current value.

##### Returns

`string` \| `string`[]

The value.

#### Set Signature

> **set** **val**(`value`): `void`

Defined in: [src/ui/editors/select2.tsx:740](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L740)

Sets the current value.

##### Parameters

###### value

The value to set.

`string` | `string`[]

##### Returns

`void`

## Methods

### close()

> **close**(): `void`

Defined in: [src/ui/editors/select2.tsx:612](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L612)

Closes the dropdown.

#### Returns

`void`

***

### destroy()

> **destroy**(): `void`

Defined in: [src/ui/editors/select2.tsx:635](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L635)

Destroys the Select2 instance.

#### Returns

`void`

***

### disable()

> **disable**(): `void`

Defined in: [src/ui/editors/select2.tsx:656](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L656)

Disables the Select2 widget.

#### Returns

`void`

***

### enable()

> **enable**(`enabled?`): `void`

Defined in: [src/ui/editors/select2.tsx:664](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L664)

Enables or disables the Select2 widget.

#### Parameters

##### enabled?

`boolean`

Whether to enable.

#### Returns

`void`

***

### focus()

> **focus**(): `void`

Defined in: [src/ui/editors/select2.tsx:671](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L671)

Focuses the search input.

#### Returns

`void`

***

### open()

> **open**(): `boolean`

Defined in: [src/ui/editors/select2.tsx:703](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L703)

Opens the dropdown.

#### Returns

`boolean`

True when opened.

***

### positionDropdown()

> **positionDropdown**(): `void`

Defined in: [src/ui/editors/select2.tsx:710](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L710)

Repositions the dropdown.

#### Returns

`void`

***

### readonly()

> **readonly**(`value?`): `void`

Defined in: [src/ui/editors/select2.tsx:718](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L718)

Sets the read-only state.

#### Parameters

##### value?

`boolean`

Whether to enable read-only mode.

#### Returns

`void`

***

### getInstance()

> `static` **getInstance**(`el`): `Select2`

Defined in: [src/ui/editors/select2.tsx:749](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L749)

Returns the Select2 instance attached to an element, or null.

#### Parameters

##### el

[`Select2Element`](../type-aliases/Select2Element.md)

The element.

#### Returns

`Select2`

The Select2 instance, or null.

***

### highlightMatch()

> `static` **highlightMatch**(`text`, `term`): [`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

Defined in: [src/ui/editors/select2.tsx:831](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L831)

Highlights the matching portion of text for a search term.

#### Parameters

##### text

`string`

The text to highlight.

##### term

`string`

The search term.

#### Returns

[`Select2FormatResult`](../type-aliases/Select2FormatResult.md)

The highlighted result.

***

### stripDiacritics()

> `static` **stripDiacritics**(`str`): `string`

Defined in: [src/ui/editors/select2.tsx:849](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L849)

Strips diacritics from a string for accent-insensitive matching.

#### Parameters

##### str

`string`

The string to process.

#### Returns

`string`

The string with diacritics removed.
