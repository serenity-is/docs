[@serenity-is/corelib](../README.md) / Tooltip

# Class: Tooltip

## Constructors

### new Tooltip()

> **new Tooltip**(`el`, `opt`?): [`Tooltip`](Tooltip.md)

#### Parameters

##### el

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

##### opt?

[`TooltipOptions`](../interfaces/TooltipOptions.md)

#### Returns

[`Tooltip`](Tooltip.md)

#### Defined in

[src/base/tooltip.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L12)

## Properties

### defaults

> `static` **defaults**: [`TooltipOptions`](../interfaces/TooltipOptions.md)

#### Defined in

[src/base/tooltip.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L36)

## Accessors

### isAvailable

#### Get Signature

> **get** `static` **isAvailable**(): `boolean`

##### Returns

`boolean`

#### Defined in

[src/base/tooltip.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L76)

## Methods

### delayedDispose()

> **delayedDispose**(`delay`): `void`

#### Parameters

##### delay

`number` = `5000`

#### Returns

`void`

#### Defined in

[src/base/tooltip.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L47)

***

### delayedHide()

> **delayedHide**(`delay`): `void`

#### Parameters

##### delay

`number` = `5000`

#### Returns

`void`

#### Defined in

[src/base/tooltip.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L51)

***

### dispose()

> **dispose**(): `void`

#### Returns

`void`

#### Defined in

[src/base/tooltip.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L40)

***

### hide()

> **hide**(): [`Tooltip`](Tooltip.md)

#### Returns

[`Tooltip`](Tooltip.md)

#### Defined in

[src/base/tooltip.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L111)

***

### setTitle()

> **setTitle**(`value`): [`Tooltip`](Tooltip.md)

#### Parameters

##### value

`string`

#### Returns

[`Tooltip`](Tooltip.md)

#### Defined in

[src/base/tooltip.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L81)

***

### show()

> **show**(): [`Tooltip`](Tooltip.md)

#### Returns

[`Tooltip`](Tooltip.md)

#### Defined in

[src/base/tooltip.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L115)

***

### toggle()

> **toggle**(`show`): [`Tooltip`](Tooltip.md)

#### Parameters

##### show

`boolean`

#### Returns

[`Tooltip`](Tooltip.md)

#### Defined in

[src/base/tooltip.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L99)

***

### getInstance()

> `static` **getInstance**(`el`): [`Tooltip`](Tooltip.md)

#### Parameters

##### el

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

#### Returns

[`Tooltip`](Tooltip.md)

#### Defined in

[src/base/tooltip.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/tooltip.ts#L68)
