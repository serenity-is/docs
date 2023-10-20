[@serenity-is/corelib](../README.md) / ValidationHelper

# Namespace: ValidationHelper

## Table of contents

### Functions

- [asyncSubmit](ValidationHelper.md#asyncsubmit)
- [getValidator](ValidationHelper.md#getvalidator)
- [submit](ValidationHelper.md#submit)

## Functions

### asyncSubmit

▸ **asyncSubmit**(`form`, `validateBeforeSave`, `submitHandler`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `form` | `JQuery` |
| `validateBeforeSave` | () => `boolean` |
| `submitHandler` | () => `void` |

#### Returns

`boolean`

#### Defined in

[src/ui/helpers/validationhelper.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/validationhelper.ts#L5)

___

### getValidator

▸ **getValidator**(`element`): `JQueryValidation.Validator`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |

#### Returns

`JQueryValidation.Validator`

#### Defined in

[src/ui/helpers/validationhelper.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/validationhelper.ts#L43)

___

### submit

▸ **submit**(`form`, `validateBeforeSave`, `submitHandler`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `form` | `JQuery` |
| `validateBeforeSave` | () => `boolean` |
| `submitHandler` | () => `void` |

#### Returns

`boolean`

#### Defined in

[src/ui/helpers/validationhelper.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/validationhelper.ts#L25)
