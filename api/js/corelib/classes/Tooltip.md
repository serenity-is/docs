[@serenity-is/corelib](../README.md) / Tooltip

# Class: Tooltip

Defined in: [src/base/tooltip.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L19)

Thin wrapper around Bootstrap / jQuery tooltip plugins with a fallback to the native
`title` attribute. Handles instance reuse, cleanup, and title updates.

## Constructors

### Constructor

> **new Tooltip**(`el`, `opt?`): `Tooltip`

Defined in: [src/base/tooltip.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L29)

Creates or wraps a tooltip for an element.

#### Parameters

##### el

Target element or array-like collection (first element is used).

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

##### opt?

[`TooltipOptions`](../interfaces/TooltipOptions.md)

Tooltip options; if omitted defaults are applied.

#### Returns

`Tooltip`

A `Tooltip` wrapper instance.

## Properties

### defaults

> `static` **defaults**: [`TooltipOptions`](../interfaces/TooltipOptions.md)

Defined in: [src/base/tooltip.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L60)

Default options applied when none are supplied.

## Accessors

### isAvailable

#### Get Signature

> **get** `static` **isAvailable**(): `boolean`

Defined in: [src/base/tooltip.ts:123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L123)

Whether a tooltip implementation (Bootstrap or jQuery) is available in the current environment.

##### Returns

`boolean`

`true` if Bootstrap Tooltip or jQuery tooltip is available, otherwise `false`.

## Methods

### delayedDispose()

> **delayedDispose**(`delay`): `void`

Defined in: [src/base/tooltip.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L81)

Disposes the tooltip after a delay.

#### Parameters

##### delay

`number` = `5000`

Delay in milliseconds before disposing. Defaults to `5000`.

#### Returns

`void`

***

### delayedHide()

> **delayedHide**(`delay`): `void`

Defined in: [src/base/tooltip.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L89)

Hides the tooltip after a delay.

#### Parameters

##### delay

`number` = `5000`

Delay in milliseconds before hiding. Defaults to `5000`.

#### Returns

`void`

***

### dispose()

> **dispose**(): `void`

Defined in: [src/base/tooltip.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L67)

Disposes the underlying tooltip instance and clears internal Bootstrap state.

#### Returns

`void`

***

### hide()

> **hide**(): `Tooltip`

Defined in: [src/base/tooltip.ts:172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L172)

Hides the tooltip.

#### Returns

`Tooltip`

This instance for chaining.

***

### setTitle()

> **setTitle**(`value`): `Tooltip`

Defined in: [src/base/tooltip.ts:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L133)

Updates the tooltip title text and synchronizes it with the underlying implementation.

#### Parameters

##### value

`string`

New title text.

#### Returns

`Tooltip`

This instance for chaining.

***

### show()

> **show**(): `Tooltip`

Defined in: [src/base/tooltip.ts:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L180)

Shows the tooltip.

#### Returns

`Tooltip`

This instance for chaining.

***

### toggle()

> **toggle**(`show`): `Tooltip`

Defined in: [src/base/tooltip.ts:156](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L156)

Shows or hides the tooltip.

#### Parameters

##### show

`boolean`

`true` to show, `false` to hide.

#### Returns

`Tooltip`

This instance for chaining.

***

### getInstance()

> `static` **getInstance**(`el`): `Tooltip`

Defined in: [src/base/tooltip.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L111)

Gets the existing tooltip wrapper for an element, if any.

#### Parameters

##### el

Target element or array-like collection.

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

#### Returns

`Tooltip`

A `Tooltip` wrapper around the existing instance, or `null` if none exists.
