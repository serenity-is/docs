[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](corelib.md) / ValidationHelper

# Namespace: ValidationHelper

[corelib](corelib.md).ValidationHelper

## Table of contents

### Functions

- [asyncSubmit](corelib.ValidationHelper.md#asyncsubmit)
- [getValidator](corelib.ValidationHelper.md#getvalidator)
- [submit](corelib.ValidationHelper.md#submit)

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
