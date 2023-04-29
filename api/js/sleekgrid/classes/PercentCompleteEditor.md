[@serenity-is/sleekgrid](../README.md) / PercentCompleteEditor

# Class: PercentCompleteEditor

## Hierarchy

- [`IntegerEditor`](IntegerEditor.md)

  ↳ **`PercentCompleteEditor`**

## Table of contents

### Constructors

- [constructor](PercentCompleteEditor.md#constructor)

### Properties

- [\_args](PercentCompleteEditor.md#_args)
- [\_defaultValue](PercentCompleteEditor.md#_defaultvalue)
- [\_input](PercentCompleteEditor.md#_input)
- [\_picker](PercentCompleteEditor.md#_picker)

### Methods

- [applyValue](PercentCompleteEditor.md#applyvalue)
- [destroy](PercentCompleteEditor.md#destroy)
- [focus](PercentCompleteEditor.md#focus)
- [getValue](PercentCompleteEditor.md#getvalue)
- [init](PercentCompleteEditor.md#init)
- [isValueChanged](PercentCompleteEditor.md#isvaluechanged)
- [loadValue](PercentCompleteEditor.md#loadvalue)
- [serializeValue](PercentCompleteEditor.md#serializevalue)
- [setValue](PercentCompleteEditor.md#setvalue)
- [validate](PercentCompleteEditor.md#validate)

## Constructors

### constructor

• **new PercentCompleteEditor**(`args`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `args` | [`EditorOptions`](../interfaces/EditorOptions.md) |

#### Inherited from

[IntegerEditor](IntegerEditor.md).[constructor](IntegerEditor.md#constructor)

#### Defined in

[editors/editors.ts:8](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;8)

## Properties

### \_args

• `Protected` **\_args**: [`EditorOptions`](../interfaces/EditorOptions.md)

#### Inherited from

[IntegerEditor](IntegerEditor.md).[_args](IntegerEditor.md#_args)

#### Defined in

[editors/editors.ts:6](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;6)

___

### \_defaultValue

• `Protected` **\_defaultValue**: `any`

#### Inherited from

[IntegerEditor](IntegerEditor.md).[_defaultValue](IntegerEditor.md#_defaultvalue)

#### Defined in

[editors/editors.ts:5](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;5)

___

### \_input

• **\_input**: `HTMLInputElement`

#### Inherited from

[IntegerEditor](IntegerEditor.md).[_input](IntegerEditor.md#_input)

#### Defined in

[editors/editors.ts:69](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;69)

___

### \_picker

• `Protected` **\_picker**: `HTMLDivElement`

#### Defined in

[editors/editors.ts:291](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;291)

## Methods

### applyValue

▸ **applyValue**(`item`, `state`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `any` |
| `state` | `any` |

#### Returns

`void`

#### Inherited from

[IntegerEditor](IntegerEditor.md).[applyValue](IntegerEditor.md#applyvalue)

#### Defined in

[editors/editors.ts:44](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;44)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

[IntegerEditor](IntegerEditor.md).[destroy](IntegerEditor.md#destroy)

#### Defined in

[editors/editors.ts:335](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;335)

___

### focus

▸ **focus**(): `void`

#### Returns

`void`

#### Inherited from

[IntegerEditor](IntegerEditor.md).[focus](IntegerEditor.md#focus)

#### Defined in

[editors/editors.ts:19](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;19)

___

### getValue

▸ **getValue**(): `string`

#### Returns

`string`

#### Inherited from

[IntegerEditor](IntegerEditor.md).[getValue](IntegerEditor.md#getvalue)

#### Defined in

[editors/editors.ts:23](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;23)

___

### init

▸ **init**(): `void`

#### Returns

`void`

#### Overrides

[IntegerEditor](IntegerEditor.md).[init](IntegerEditor.md#init)

#### Defined in

[editors/editors.ts:293](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;293)

___

### isValueChanged

▸ **isValueChanged**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[IntegerEditor](IntegerEditor.md).[isValueChanged](IntegerEditor.md#isvaluechanged)

#### Defined in

[editors/editors.ts:48](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;48)

___

### loadValue

▸ **loadValue**(`item`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `any` |

#### Returns

`void`

#### Inherited from

[IntegerEditor](IntegerEditor.md).[loadValue](IntegerEditor.md#loadvalue)

#### Defined in

[editors/editors.ts:31](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;31)

___

### serializeValue

▸ **serializeValue**(): `number`

#### Returns

`number`

#### Inherited from

[IntegerEditor](IntegerEditor.md).[serializeValue](IntegerEditor.md#serializevalue)

#### Defined in

[editors/editors.ts:83](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;83)

___

### setValue

▸ **setValue**(`val`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `val` | `string` |

#### Returns

`void`

#### Inherited from

[IntegerEditor](IntegerEditor.md).[setValue](IntegerEditor.md#setvalue)

#### Defined in

[editors/editors.ts:27](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;27)

___

### validate

▸ **validate**(): [`ValidationResult`](../interfaces/ValidationResult.md)

#### Returns

[`ValidationResult`](../interfaces/ValidationResult.md)

#### Inherited from

[IntegerEditor](IntegerEditor.md).[validate](IntegerEditor.md#validate)

#### Defined in

[editors/editors.ts:87](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;87)
