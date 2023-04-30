[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](corelib.md) / VX

# Namespace: VX

[corelib](corelib.md).VX

## Table of contents

### Functions

- [addValidationRule](corelib.VX.md#addvalidationrule)
- [removeValidationRule](corelib.VX.md#removevalidationrule)
- [validateElement](corelib.VX.md#validateelement)

## Functions

### addValidationRule

▸ **addValidationRule**(`element`, `eventClass`, `rule`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |
| `eventClass` | `string` |
| `rule` | (`p1`: `JQuery`) => `string` |

#### Returns

`JQuery`

#### Defined in

[src/ui/helpers/validationhelper.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/validationhelper.ts#L53)

___

### removeValidationRule

▸ **removeValidationRule**(`element`, `eventClass`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `JQuery` |
| `eventClass` | `string` |

#### Returns

`JQuery`

#### Defined in

[src/ui/helpers/validationhelper.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/validationhelper.ts#L62)

___

### validateElement

▸ **validateElement**(`validator`, `widget`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `validator` | `Validator` |
| `widget` | [`Widget`](../classes/corelib.Widget.md)<`any`\> |

#### Returns

`boolean`

#### Defined in

[src/ui/helpers/validationhelper.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/validationhelper.ts#L67)
