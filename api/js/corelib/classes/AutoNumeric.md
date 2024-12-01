[@serenity-is/corelib](../README.md) / AutoNumeric

# Class: AutoNumeric

## Constructors

### new AutoNumeric()

> **new AutoNumeric**(): [`AutoNumeric`](AutoNumeric.md)

#### Returns

[`AutoNumeric`](AutoNumeric.md)

## Methods

### destroy()

> `static` **destroy**(`input`): `void`

method to remove settings and stop autoNumeric()

#### Parameters

##### input

`HTMLInputElement`

#### Returns

`void`

#### Defined in

[src/ui/editors/autonumeric.ts:1178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1178)

***

### getSettings()

> `static` **getSettings**(`input`): [`AutoNumericOptions`](../interfaces/AutoNumericOptions.md)

returns the settings object for those who need to look under the hood

#### Parameters

##### input

`HTMLInputElement`

#### Returns

[`AutoNumericOptions`](../interfaces/AutoNumericOptions.md)

#### Defined in

[src/ui/editors/autonumeric.ts:1277](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1277)

***

### getValue()

> `static` **getValue**(`input`): `string`

method to get the unformatted value from a specific input field, returns a numeric value

#### Parameters

##### input

`HTMLInputElement`

#### Returns

`string`

#### Defined in

[src/ui/editors/autonumeric.ts:1241](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1241)

***

### hasInstance()

> `static` **hasInstance**(`input`): `boolean`

#### Parameters

##### input

`HTMLInputElement`

#### Returns

`boolean`

#### Defined in

[src/ui/editors/autonumeric.ts:1281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1281)

***

### init()

> `static` **init**(`input`, `options`): `void`

#### Parameters

##### input

`HTMLInputElement`

##### options

[`AutoNumericOptions`](../interfaces/AutoNumericOptions.md)

#### Returns

`void`

#### Defined in

[src/ui/editors/autonumeric.ts:893](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L893)

***

### setValue()

> `static` **setValue**(`input`, `valueIn`): `string`

returns a formatted strings for "input:text" fields Uses jQuery's .val() method

#### Parameters

##### input

`HTMLInputElement`

##### valueIn

`string` | `number`

#### Returns

`string`

#### Defined in

[src/ui/editors/autonumeric.ts:1203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1203)

***

### updateOptions()

> `static` **updateOptions**(`input`, `options`): `void`

method to update settings - can call as many times

#### Parameters

##### input

`HTMLInputElement`

##### options

[`AutoNumericOptions`](../interfaces/AutoNumericOptions.md)

#### Returns

`void`

#### Defined in

[src/ui/editors/autonumeric.ts:1184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1184)
