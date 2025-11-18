[@serenity-is/corelib](../README.md) / AutoNumeric

# Class: AutoNumeric

Defined in: [src/ui/editors/autonumeric.ts:887](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L887)

## Constructors

### Constructor

> **new AutoNumeric**(): `AutoNumeric`

#### Returns

`AutoNumeric`

## Properties

### allowedSettingKeys

> `readonly` `static` **allowedSettingKeys**: `Set`\<`string`\>

Defined in: [src/ui/editors/autonumeric.ts:1281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1281)

## Methods

### destroy()

> `static` **destroy**(`input`): `void`

Defined in: [src/ui/editors/autonumeric.ts:1174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1174)

method to remove settings and stop autoNumeric()

#### Parameters

##### input

`HTMLInputElement`

#### Returns

`void`

***

### getSettings()

> `static` **getSettings**(`input`): [`AutoNumericOptions`](../interfaces/AutoNumericOptions.md)

Defined in: [src/ui/editors/autonumeric.ts:1273](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1273)

returns the settings object for those who need to look under the hood

#### Parameters

##### input

`HTMLInputElement`

#### Returns

[`AutoNumericOptions`](../interfaces/AutoNumericOptions.md)

***

### getValue()

> `static` **getValue**(`input`): `string`

Defined in: [src/ui/editors/autonumeric.ts:1237](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1237)

method to get the unformatted value from a specific input field, returns a numeric value

#### Parameters

##### input

`HTMLInputElement`

#### Returns

`string`

***

### hasInstance()

> `static` **hasInstance**(`input`): `boolean`

Defined in: [src/ui/editors/autonumeric.ts:1277](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1277)

#### Parameters

##### input

`HTMLInputElement`

#### Returns

`boolean`

***

### init()

> `static` **init**(`input`, `options`): `void`

Defined in: [src/ui/editors/autonumeric.ts:889](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L889)

#### Parameters

##### input

`HTMLInputElement`

##### options

[`AutoNumericOptions`](../interfaces/AutoNumericOptions.md)

#### Returns

`void`

***

### setValue()

> `static` **setValue**(`input`, `valueIn`): `string`

Defined in: [src/ui/editors/autonumeric.ts:1199](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1199)

returns a formatted strings for "input:text" fields Uses jQuery's .val() method

#### Parameters

##### input

`HTMLInputElement`

##### valueIn

`string` | `number`

#### Returns

`string`

***

### updateOptions()

> `static` **updateOptions**(`input`, `options`): `void`

Defined in: [src/ui/editors/autonumeric.ts:1180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1180)

method to update settings - can call as many times

#### Parameters

##### input

`HTMLInputElement`

##### options

[`AutoNumericOptions`](../interfaces/AutoNumericOptions.md)

#### Returns

`void`
