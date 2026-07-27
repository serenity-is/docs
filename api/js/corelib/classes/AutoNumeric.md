[@serenity-is/corelib](../README.md) / AutoNumeric

# Class: AutoNumeric

Defined in: [src/ui/editors/autonumeric.ts:997](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L997)

## Constructors

### Constructor

> **new AutoNumeric**(): `AutoNumeric`

#### Returns

`AutoNumeric`

## Properties

### allowedSettingKeys

> `readonly` `static` **allowedSettingKeys**: `Set`\<`string`\>

Defined in: [src/ui/editors/autonumeric.ts:1314](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1314)

***

### defaults

> `static` **defaults**: [`AutoNumericOptions`](../interfaces/AutoNumericOptions.md)

Defined in: [src/ui/editors/autonumeric.ts:999](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L999)

## Methods

### destroy()

> `static` **destroy**(`input`): `void`

Defined in: [src/ui/editors/autonumeric.ts:1207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1207)

method to remove settings and stop autoNumeric()

#### Parameters

##### input

`HTMLInputElement`

#### Returns

`void`

***

### getSettings()

> `static` **getSettings**(`input`): [`AutoNumericOptions`](../interfaces/AutoNumericOptions.md)

Defined in: [src/ui/editors/autonumeric.ts:1306](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1306)

returns the settings object for those who need to look under the hood

#### Parameters

##### input

`HTMLInputElement`

#### Returns

[`AutoNumericOptions`](../interfaces/AutoNumericOptions.md)

***

### getValue()

> `static` **getValue**(`input`): `string`

Defined in: [src/ui/editors/autonumeric.ts:1270](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1270)

method to get the unformatted value from a specific input field, returns a numeric value

#### Parameters

##### input

`HTMLInputElement`

#### Returns

`string`

***

### hasInstance()

> `static` **hasInstance**(`input`): `boolean`

Defined in: [src/ui/editors/autonumeric.ts:1310](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1310)

#### Parameters

##### input

`HTMLInputElement`

#### Returns

`boolean`

***

### init()

> `static` **init**(`input`, `options`): `void`

Defined in: [src/ui/editors/autonumeric.ts:1018](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1018)

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

Defined in: [src/ui/editors/autonumeric.ts:1232](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1232)

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

Defined in: [src/ui/editors/autonumeric.ts:1213](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1213)

method to update settings - can call as many times

#### Parameters

##### input

`HTMLInputElement`

##### options

[`AutoNumericOptions`](../interfaces/AutoNumericOptions.md)

#### Returns

`void`
