[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](corelib.md) / Decorators

# Namespace: Decorators

[corelib](corelib.md).Decorators

## Table of contents

### Functions

- [dialogType](corelib.Decorators.md#dialogtype)
- [editor](corelib.Decorators.md#editor)
- [element](corelib.Decorators.md#element)
- [enumKey](corelib.Decorators.md#enumkey)
- [filterable](corelib.Decorators.md#filterable)
- [flexify](corelib.Decorators.md#flexify)
- [itemName](corelib.Decorators.md#itemname)
- [maximizable](corelib.Decorators.md#maximizable)
- [option](corelib.Decorators.md#option)
- [optionsType](corelib.Decorators.md#optionstype)
- [panel](corelib.Decorators.md#panel)
- [registerClass](corelib.Decorators.md#registerclass)
- [registerEditor](corelib.Decorators.md#registereditor)
- [registerEnum](corelib.Decorators.md#registerenum)
- [registerEnumType](corelib.Decorators.md#registerenumtype)
- [registerFormatter](corelib.Decorators.md#registerformatter)
- [registerInterface](corelib.Decorators.md#registerinterface)
- [resizable](corelib.Decorators.md#resizable)
- [responsive](corelib.Decorators.md#responsive)
- [service](corelib.Decorators.md#service)

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

[src/decorators/index.ts:304](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#line&#x3D;304)

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

[src/decorators/index.ts:310](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#line&#x3D;310)

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

[src/decorators/index.ts:317](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#line&#x3D;317)

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

[src/decorators/index.ts:282](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#line&#x3D;282)

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

[src/decorators/index.ts:323](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#line&#x3D;323)

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

[src/decorators/index.ts:329](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#line&#x3D;329)

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

[src/decorators/index.ts:335](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#line&#x3D;335)

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

[src/decorators/index.ts:341](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#line&#x3D;341)

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

[src/decorators/index.ts:288](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#line&#x3D;288)

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

[src/decorators/index.ts:347](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#line&#x3D;347)

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

[src/decorators/index.ts:353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#line&#x3D;353)

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

[src/decorators/index.ts:239](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#line&#x3D;239)

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

[src/decorators/index.ts:258](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#line&#x3D;258)

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

[src/decorators/index.ts:267](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#line&#x3D;267)

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

[src/decorators/index.ts:273](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#line&#x3D;273)

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

[src/decorators/index.ts:277](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#line&#x3D;277)

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

[src/decorators/index.ts:248](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#line&#x3D;248)

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

[src/decorators/index.ts:359](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#line&#x3D;359)

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

[src/decorators/index.ts:365](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#line&#x3D;365)

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

[src/decorators/index.ts:371](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/decorators/index.ts#line&#x3D;371)
