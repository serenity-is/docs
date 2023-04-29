[@serenity-is/sleekgrid](../README.md) / IntegerEditor

# Class: IntegerEditor

## Hierarchy

- [`TextEditor`](TextEditor.md)

  ↳ **`IntegerEditor`**

  ↳↳ [`PercentCompleteEditor`](PercentCompleteEditor.md)

## Table of contents

### Constructors

- [constructor](IntegerEditor.md#constructor)

### Properties

- [\_args](IntegerEditor.md#_args)
- [\_defaultValue](IntegerEditor.md#_defaultvalue)
- [\_input](IntegerEditor.md#_input)

### Methods

- [applyValue](IntegerEditor.md#applyvalue)
- [destroy](IntegerEditor.md#destroy)
- [focus](IntegerEditor.md#focus)
- [getValue](IntegerEditor.md#getvalue)
- [init](IntegerEditor.md#init)
- [isValueChanged](IntegerEditor.md#isvaluechanged)
- [loadValue](IntegerEditor.md#loadvalue)
- [serializeValue](IntegerEditor.md#serializevalue)
- [setValue](IntegerEditor.md#setvalue)
- [validate](IntegerEditor.md#validate)

## Constructors

### constructor

• **new IntegerEditor**(`args`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `args` | [`EditorOptions`](../interfaces/EditorOptions.md) |

#### Inherited from

[TextEditor](TextEditor.md).[constructor](TextEditor.md#constructor)

#### Defined in

[editors/editors.ts:8](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;8)

## Properties

### \_args

• `Protected` **\_args**: [`EditorOptions`](../interfaces/EditorOptions.md)

#### Inherited from

[TextEditor](TextEditor.md).[_args](TextEditor.md#_args)

#### Defined in

[editors/editors.ts:6](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;6)

___

### \_defaultValue

• `Protected` **\_defaultValue**: `any`

#### Inherited from

[TextEditor](TextEditor.md).[_defaultValue](TextEditor.md#_defaultvalue)

#### Defined in

[editors/editors.ts:5](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;5)

___

### \_input

• **\_input**: `HTMLInputElement`

#### Inherited from

[TextEditor](TextEditor.md).[_input](TextEditor.md#_input)

#### Defined in

[editors/editors.ts:69](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;69)

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

[TextEditor](TextEditor.md).[applyValue](TextEditor.md#applyvalue)

#### Defined in

[editors/editors.ts:44](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;44)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[TextEditor](TextEditor.md).[destroy](TextEditor.md#destroy)

#### Defined in

[editors/editors.ts:15](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;15)

___

### focus

▸ **focus**(): `void`

#### Returns

`void`

#### Inherited from

[TextEditor](TextEditor.md).[focus](TextEditor.md#focus)

#### Defined in

[editors/editors.ts:19](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;19)

___

### getValue

▸ **getValue**(): `string`

#### Returns

`string`

#### Inherited from

[TextEditor](TextEditor.md).[getValue](TextEditor.md#getvalue)

#### Defined in

[editors/editors.ts:23](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;23)

___

### init

▸ **init**(): `void`

#### Returns

`void`

#### Inherited from

[TextEditor](TextEditor.md).[init](TextEditor.md#init)

#### Defined in

[editors/editors.ts:71](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;71)

___

### isValueChanged

▸ **isValueChanged**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[TextEditor](TextEditor.md).[isValueChanged](TextEditor.md#isvaluechanged)

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

[TextEditor](TextEditor.md).[loadValue](TextEditor.md#loadvalue)

#### Defined in

[editors/editors.ts:31](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;31)

___

### serializeValue

▸ **serializeValue**(): `number`

#### Returns

`number`

#### Overrides

[TextEditor](TextEditor.md).[serializeValue](TextEditor.md#serializevalue)

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

[TextEditor](TextEditor.md).[setValue](TextEditor.md#setvalue)

#### Defined in

[editors/editors.ts:27](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;27)

___

### validate

▸ **validate**(): [`ValidationResult`](../interfaces/ValidationResult.md)

#### Returns

[`ValidationResult`](../interfaces/ValidationResult.md)

#### Overrides

[TextEditor](TextEditor.md).[validate](TextEditor.md#validate)

#### Defined in

[editors/editors.ts:87](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;87)
