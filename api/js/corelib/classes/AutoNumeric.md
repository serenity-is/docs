[@serenity-is/corelib](../README.md) / AutoNumeric

# Class: AutoNumeric

Defined in: [src/ui/editors/autonumeric.ts:966](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L966)

A jQuery-independent port of the autoNumeric library for formatting numeric inputs.

## Constructors

### Constructor

> **new AutoNumeric**(): `AutoNumeric`

#### Returns

`AutoNumeric`

## Properties

### allowedSettingKeys

> `readonly` `static` **allowedSettingKeys**: `Set`\<`string`\>

Defined in: [src/ui/editors/autonumeric.ts:1315](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1315)

Setting keys that can be passed through from editor options.

***

### defaults

> `static` **defaults**: [`AutoNumericOptions`](../interfaces/AutoNumericOptions.md)

Defined in: [src/ui/editors/autonumeric.ts:969](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L969)

Default autoNumeric options.

## Methods

### destroy()

> `static` **destroy**(`input`): `void`

Defined in: [src/ui/editors/autonumeric.ts:1185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1185)

Removes autoNumeric settings and event handlers from an input.

#### Parameters

##### input

`HTMLInputElement`

The input element.

#### Returns

`void`

***

### getSettings()

> `static` **getSettings**(`input`): [`AutoNumericOptions`](../interfaces/AutoNumericOptions.md)

Defined in: [src/ui/editors/autonumeric.ts:1301](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1301)

Returns the autoNumeric settings for an input.

#### Parameters

##### input

`HTMLInputElement`

The input element.

#### Returns

[`AutoNumericOptions`](../interfaces/AutoNumericOptions.md)

The settings.

***

### getValue()

> `static` **getValue**(`input`): `string`

Defined in: [src/ui/editors/autonumeric.ts:1261](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1261)

Returns the unformatted numeric value of an input.

#### Parameters

##### input

`HTMLInputElement`

The input element.

#### Returns

`string`

The numeric value as a string.

***

### hasInstance()

> `static` **hasInstance**(`input`): `boolean`

Defined in: [src/ui/editors/autonumeric.ts:1310](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1310)

Whether an input has an autoNumeric instance.

#### Parameters

##### input

`HTMLInputElement`

The input element.

#### Returns

`boolean`

True when initialized.

***

### init()

> `static` **init**(`input`, `options`): `void`

Defined in: [src/ui/editors/autonumeric.ts:993](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L993)

Initializes autoNumeric on an input element.

#### Parameters

##### input

`HTMLInputElement`

The input element.

##### options

[`AutoNumericOptions`](../interfaces/AutoNumericOptions.md)

AutoNumeric options.

#### Returns

`void`

***

### setValue()

> `static` **setValue**(`input`, `valueIn`): `string`

Defined in: [src/ui/editors/autonumeric.ts:1219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1219)

Sets the formatted value of an input.

#### Parameters

##### input

`HTMLInputElement`

The input element.

##### valueIn

The value to set.

`string` | `number`

#### Returns

`string`

The formatted value.

***

### updateOptions()

> `static` **updateOptions**(`input`, `options`): `void`

Defined in: [src/ui/editors/autonumeric.ts:1195](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1195)

Updates autoNumeric settings on an input.

#### Parameters

##### input

`HTMLInputElement`

The input element.

##### options

[`AutoNumericOptions`](../interfaces/AutoNumericOptions.md)

The options to update.

#### Returns

`void`
