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

Defined in: [src/base/tooltip.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L80)

##### Returns

`boolean`

## Methods

### delayedDispose()

> **delayedDispose**(`delay`): `void`

Defined in: [src/base/tooltip.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L51)

#### Parameters

##### delay

`number` = `5000`

#### Returns

`void`

***

### delayedHide()

> **delayedHide**(`delay`): `void`

Defined in: [src/base/tooltip.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L55)

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

Defined in: [src/base/tooltip.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L115)

#### Returns

`Tooltip`

***

### setTitle()

> **setTitle**(`value`): `Tooltip`

Defined in: [src/base/tooltip.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L85)

#### Parameters

##### value

`string`

#### Returns

`Tooltip`

***

### show()

> **show**(): `Tooltip`

Defined in: [src/base/tooltip.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L119)

#### Returns

`Tooltip`

***

### toggle()

> **toggle**(`show`): `Tooltip`

Defined in: [src/base/tooltip.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L103)

#### Parameters

##### show

`boolean`

#### Returns

`Tooltip`

***

### getInstance()

> `static` **getInstance**(`el`): `Tooltip`

Defined in: [src/base/tooltip.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L72)

#### Parameters

##### el

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

#### Returns

`Tooltip`
