[@serenity-is/corelib](../README.md) / AutoNumeric

# Class: AutoNumeric

## Table of contents

### Constructors

- [constructor](AutoNumeric.md#constructor)

### Methods

- [destroy](AutoNumeric.md#destroy)
- [getSettings](AutoNumeric.md#getsettings)
- [getValue](AutoNumeric.md#getvalue)
- [hasInstance](AutoNumeric.md#hasinstance)
- [init](AutoNumeric.md#init)
- [setValue](AutoNumeric.md#setvalue)
- [updateOptions](AutoNumeric.md#updateoptions)

## Constructors

### constructor

• **new AutoNumeric**(): [`AutoNumeric`](AutoNumeric.md)

#### Returns

[`AutoNumeric`](AutoNumeric.md)

## Methods

### destroy

▸ **destroy**(`input`): `void`

method to remove settings and stop autoNumeric()

#### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `HTMLInputElement` |

#### Returns

`void`

#### Defined in

[src/ui/editors/autonumeric.ts:1178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1178)

___

### getSettings

▸ **getSettings**(`input`): [`AutoNumericOptions`](../interfaces/AutoNumericOptions.md)

returns the settings object for those who need to look under the hood

#### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `HTMLInputElement` |

#### Returns

[`AutoNumericOptions`](../interfaces/AutoNumericOptions.md)

#### Defined in

[src/ui/editors/autonumeric.ts:1277](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1277)

___

### getValue

▸ **getValue**(`input`): `string`

method to get the unformatted value from a specific input field, returns a numeric value

#### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `HTMLInputElement` |

#### Returns

`string`

#### Defined in

[src/ui/editors/autonumeric.ts:1241](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1241)

___

### hasInstance

▸ **hasInstance**(`input`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `HTMLInputElement` |

#### Returns

`boolean`

#### Defined in

[src/ui/editors/autonumeric.ts:1281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1281)

___

### init

▸ **init**(`input`, `options`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `HTMLInputElement` |
| `options` | [`AutoNumericOptions`](../interfaces/AutoNumericOptions.md) |

#### Returns

`void`

#### Defined in

[src/ui/editors/autonumeric.ts:893](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L893)

___

### setValue

▸ **setValue**(`input`, `valueIn`): `string`

returns a formatted strings for "input:text" fields Uses jQuery's .val() method

#### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `HTMLInputElement` |
| `valueIn` | `string` \| `number` |

#### Returns

`string`

#### Defined in

[src/ui/editors/autonumeric.ts:1203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1203)

___

### updateOptions

▸ **updateOptions**(`input`, `options`): `void`

method to update settings - can call as many times

#### Parameters

| Name | Type |
| :------ | :------ |
| `input` | `HTMLInputElement` |
| `options` | [`AutoNumericOptions`](../interfaces/AutoNumericOptions.md) |

#### Returns

`void`

#### Defined in

[src/ui/editors/autonumeric.ts:1184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/autonumeric.ts#L1184)
