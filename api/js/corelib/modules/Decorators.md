[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / Decorators

# Namespace: Decorators

## Table of contents

### Functions

- [dialogType](Decorators.md#dialogtype)
- [editor](Decorators.md#editor)
- [element](Decorators.md#element)
- [enumKey](Decorators.md#enumkey)
- [filterable](Decorators.md#filterable)
- [flexify](Decorators.md#flexify)
- [itemName](Decorators.md#itemname)
- [maximizable](Decorators.md#maximizable)
- [option](Decorators.md#option)
- [optionsType](Decorators.md#optionstype)
- [panel](Decorators.md#panel)
- [registerClass](Decorators.md#registerclass)
- [registerEditor](Decorators.md#registereditor)
- [registerEnum](Decorators.md#registerenum)
- [registerEnumType](Decorators.md#registerenumtype)
- [registerFormatter](Decorators.md#registerformatter)
- [registerInterface](Decorators.md#registerinterface)
- [resizable](Decorators.md#resizable)
- [responsive](Decorators.md#responsive)
- [service](Decorators.md#service)

## Functions

### dialogType

▸ **dialogType**(`value`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/decorators/index.ts:304](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#L304)

___

### editor

▸ **editor**(): (`target`: `Function`) => `void`

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/decorators/index.ts:310](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#L310)

___

### element

▸ **element**(`value`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/decorators/index.ts:317](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#L317)

___

### enumKey

▸ **enumKey**(`value`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/decorators/index.ts:282](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#L282)

___

### filterable

▸ **filterable**(`value?`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `value` | `boolean` | `true` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/decorators/index.ts:323](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#L323)

___

### flexify

▸ **flexify**(`value?`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `value` | `boolean` | `true` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/decorators/index.ts:329](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#L329)

___

### itemName

▸ **itemName**(`value`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/decorators/index.ts:335](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#L335)

___

### maximizable

▸ **maximizable**(`value?`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `value` | `boolean` | `true` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/decorators/index.ts:341](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#L341)

___

### option

▸ **option**(): (`target`: `Object`, `propertyKey`: `string`) => `void`

#### Returns

`fn`

▸ (`target`, `propertyKey`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Object` |
| `propertyKey` | `string` |

##### Returns

`void`

#### Defined in

[src/decorators/index.ts:288](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#L288)

___

### optionsType

▸ **optionsType**(`value`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `Function` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/decorators/index.ts:347](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#L347)

___

### panel

▸ **panel**(`value?`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `value` | `boolean` | `true` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/decorators/index.ts:353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#L353)

___

### registerClass

▸ **registerClass**(`nameOrIntf?`, `intf2?`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `nameOrIntf?` | `string` \| `any`[] |
| `intf2?` | `any`[] |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/decorators/index.ts:239](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#L239)

___

### registerEditor

▸ **registerEditor**(`nameOrIntf?`, `intf2?`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `nameOrIntf?` | `string` \| `any`[] |
| `intf2?` | `any`[] |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/decorators/index.ts:258](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#L258)

___

### registerEnum

▸ **registerEnum**(`target`, `enumKey?`, `name?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `any` |
| `enumKey?` | `string` |
| `name?` | `string` |

#### Returns

`void`

#### Defined in

[src/decorators/index.ts:267](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#L267)

___

### registerEnumType

▸ **registerEnumType**(`target`, `name?`, `enumKey?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `any` |
| `name?` | `string` |
| `enumKey?` | `string` |

#### Returns

`void`

#### Defined in

[src/decorators/index.ts:273](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#L273)

___

### registerFormatter

▸ **registerFormatter**(`nameOrIntf?`, `intf2?`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `nameOrIntf` | `string` \| `any`[] |
| `intf2` | `any`[] |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/decorators/index.ts:277](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#L277)

___

### registerInterface

▸ **registerInterface**(`nameOrIntf?`, `intf2?`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `nameOrIntf?` | `string` \| `any`[] |
| `intf2?` | `any`[] |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/decorators/index.ts:248](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#L248)

___

### resizable

▸ **resizable**(`value?`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `value` | `boolean` | `true` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/decorators/index.ts:359](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#L359)

___

### responsive

▸ **responsive**(`value?`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type | Default value |
| :------ | :------ | :------ |
| `value` | `boolean` | `true` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/decorators/index.ts:365](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#L365)

___

### service

▸ **service**(`value`): (`target`: `Function`) => `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`fn`

▸ (`target`): `void`

##### Parameters

| Name | Type |
| :------ | :------ |
| `target` | `Function` |

##### Returns

`void`

#### Defined in

[src/decorators/index.ts:371](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#L371)
