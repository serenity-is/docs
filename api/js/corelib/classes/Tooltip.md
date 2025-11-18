[@serenity-is/corelib](../README.md) / Tooltip

# Class: Tooltip

Defined in: [src/base/tooltip.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L10)

## Constructors

### Constructor

> **new Tooltip**(`el`, `opt?`): `Tooltip`

Defined in: [src/base/tooltip.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L13)

#### Parameters

##### el

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

##### opt?

[`TooltipOptions`](../interfaces/TooltipOptions.md)

#### Returns

`Tooltip`

## Properties

### defaults

> `static` **defaults**: [`TooltipOptions`](../interfaces/TooltipOptions.md)

Defined in: [src/base/tooltip.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L37)

## Accessors

### isAvailable

#### Get Signature

> **get** `static` **isAvailable**(): `boolean`

Defined in: [src/base/tooltip.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L77)

##### Returns

`boolean`

## Methods

### delayedDispose()

> **delayedDispose**(`delay`): `void`

Defined in: [src/base/tooltip.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L48)

#### Parameters

##### delay

`number` = `5000`

#### Returns

`void`

***

### delayedHide()

> **delayedHide**(`delay`): `void`

Defined in: [src/base/tooltip.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L52)

#### Parameters

##### delay

`number` = `5000`

#### Returns

`void`

***

### dispose()

> **dispose**(): `void`

Defined in: [src/base/tooltip.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L41)

#### Returns

`void`

***

### hide()

> **hide**(): `Tooltip`

Defined in: [src/base/tooltip.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L112)

#### Returns

`Tooltip`

***

### setTitle()

> **setTitle**(`value`): `Tooltip`

Defined in: [src/base/tooltip.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L82)

#### Parameters

##### value

`string`

#### Returns

`Tooltip`

***

### show()

> **show**(): `Tooltip`

Defined in: [src/base/tooltip.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L116)

#### Returns

`Tooltip`

***

### toggle()

> **toggle**(`show`): `Tooltip`

Defined in: [src/base/tooltip.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L100)

#### Parameters

##### show

`boolean`

#### Returns

`Tooltip`

***

### getInstance()

> `static` **getInstance**(`el`): `Tooltip`

Defined in: [src/base/tooltip.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L69)

#### Parameters

##### el

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

#### Returns

`Tooltip`
