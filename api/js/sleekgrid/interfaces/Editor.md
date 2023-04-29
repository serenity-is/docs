[@serenity-is/sleekgrid](../README.md) / Editor

# Interface: Editor

## Table of contents

### Properties

- [keyCaptureList](Editor.md#keycapturelist)

### Methods

- [applyValue](Editor.md#applyvalue)
- [destroy](Editor.md#destroy)
- [focus](Editor.md#focus)
- [hide](Editor.md#hide)
- [isValueChanged](Editor.md#isvaluechanged)
- [loadValue](Editor.md#loadvalue)
- [position](Editor.md#position)
- [preClick](Editor.md#preclick)
- [serializeValue](Editor.md#serializevalue)
- [show](Editor.md#show)
- [validate](Editor.md#validate)

## Properties

### keyCaptureList

• `Optional` **keyCaptureList**: `number`[]

#### Defined in

[core/editing.ts:74](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#line&#x3D;74)

## Methods

### applyValue

▸ **applyValue**(`item`, `value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `any` |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[core/editing.ts:71](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#line&#x3D;71)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Defined in

[core/editing.ts:70](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#line&#x3D;70)

___

### focus

▸ **focus**(): `void`

#### Returns

`void`

#### Defined in

[core/editing.ts:72](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#line&#x3D;72)

___

### hide

▸ `Optional` **hide**(): `void`

#### Returns

`void`

#### Defined in

[core/editing.ts:79](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#line&#x3D;79)

___

### isValueChanged

▸ **isValueChanged**(): `boolean`

#### Returns

`boolean`

#### Defined in

[core/editing.ts:73](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#line&#x3D;73)

___

### loadValue

▸ **loadValue**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `any` |

#### Returns

`void`

#### Defined in

[core/editing.ts:75](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#line&#x3D;75)

___

### position

▸ `Optional` **position**(`pos`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `pos` | [`Position`](Position.md) |

#### Returns

`void`

#### Defined in

[core/editing.ts:77](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#line&#x3D;77)

___

### preClick

▸ `Optional` **preClick**(): `void`

#### Returns

`void`

#### Defined in

[core/editing.ts:78](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#line&#x3D;78)

___

### serializeValue

▸ **serializeValue**(): `any`

#### Returns

`any`

#### Defined in

[core/editing.ts:76](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#line&#x3D;76)

___

### show

▸ `Optional` **show**(): `void`

#### Returns

`void`

#### Defined in

[core/editing.ts:80](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#line&#x3D;80)

___

### validate

▸ `Optional` **validate**(): [`ValidationResult`](ValidationResult.md)

#### Returns

[`ValidationResult`](ValidationResult.md)

#### Defined in

[core/editing.ts:81](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#line&#x3D;81)
