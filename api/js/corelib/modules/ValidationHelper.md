[@serenity-is/corelib](../README.md) / ValidationHelper

# Namespace: ValidationHelper

## Table of contents

### Functions

- [asyncSubmit](ValidationHelper.md#asyncsubmit)
- [getValidator](ValidationHelper.md#getvalidator)
- [submit](ValidationHelper.md#submit)
- [validateElement](ValidationHelper.md#validateelement)

## Functions

### asyncSubmit

▸ **asyncSubmit**(`form`, `validateBeforeSave`, `submitHandler`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `form` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |
| `validateBeforeSave` | () => `boolean` |
| `submitHandler` | () => `void` |

#### Returns

`boolean`

#### Defined in

[src/q/validation.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/validation.ts#L78)

___

### getValidator

▸ **getValidator**(`elem`): [`Validator`](../classes/Validator.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `elem` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |

#### Returns

[`Validator`](../classes/Validator.md)

#### Defined in

[src/q/validation.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/validation.ts#L112)

___

### submit

▸ **submit**(`form`, `validateBeforeSave`, `submitHandler`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `form` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |
| `validateBeforeSave` | () => `boolean` |
| `submitHandler` | () => `void` |

#### Returns

`boolean`

#### Defined in

[src/q/validation.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/validation.ts#L96)

___

### validateElement

▸ **validateElement**(`elem`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `elem` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |

#### Returns

`void`

#### Defined in

[src/q/validation.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/q/validation.ts#L116)
