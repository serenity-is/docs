[@serenity-is/sleekgrid](../README.md) / FloatEditor

# Class: FloatEditor

## Hierarchy

- [`TextEditor`](TextEditor.md)

  ↳ **`FloatEditor`**

## Table of contents

### Constructors

- [constructor](FloatEditor.md#constructor)

### Properties

- [\_args](FloatEditor.md#_args)
- [\_defaultValue](FloatEditor.md#_defaultvalue)
- [\_input](FloatEditor.md#_input)
- [AllowEmptyValue](FloatEditor.md#allowemptyvalue)
- [DefaultDecimalPlaces](FloatEditor.md#defaultdecimalplaces)

### Methods

- [applyValue](FloatEditor.md#applyvalue)
- [destroy](FloatEditor.md#destroy)
- [focus](FloatEditor.md#focus)
- [getDecimalPlaces](FloatEditor.md#getdecimalplaces)
- [getValue](FloatEditor.md#getvalue)
- [init](FloatEditor.md#init)
- [isValueChanged](FloatEditor.md#isvaluechanged)
- [loadValue](FloatEditor.md#loadvalue)
- [serializeValue](FloatEditor.md#serializevalue)
- [setValue](FloatEditor.md#setvalue)
- [validate](FloatEditor.md#validate)

## Constructors

### constructor

• **new FloatEditor**(`args`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `args` | [`EditorOptions`](../interfaces/EditorOptions.md) |

#### Inherited from

[TextEditor](TextEditor.md).[constructor](TextEditor.md#constructor)

#### Defined in

[editors/editors.ts:8](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L8)

## Properties

### \_args

• `Protected` **\_args**: [`EditorOptions`](../interfaces/EditorOptions.md)

#### Inherited from

[TextEditor](TextEditor.md).[_args](TextEditor.md#_args)

#### Defined in

[editors/editors.ts:6](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L6)

___

### \_defaultValue

• `Protected` **\_defaultValue**: `any`

#### Inherited from

[TextEditor](TextEditor.md).[_defaultValue](TextEditor.md#_defaultvalue)

#### Defined in

[editors/editors.ts:5](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L5)

___

### \_input

• **\_input**: `HTMLInputElement`

#### Inherited from

[TextEditor](TextEditor.md).[_input](TextEditor.md#_input)

#### Defined in

[editors/editors.ts:69](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L69)

___

### AllowEmptyValue

▪ `Static` **AllowEmptyValue**: `boolean` = `false`

#### Defined in

[editors/editors.ts:101](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L101)

___

### DefaultDecimalPlaces

▪ `Static` **DefaultDecimalPlaces**: `number` = `null`

#### Defined in

[editors/editors.ts:102](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L102)

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

[editors/editors.ts:44](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L44)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[TextEditor](TextEditor.md).[destroy](TextEditor.md#destroy)

#### Defined in

[editors/editors.ts:15](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L15)

___

### focus

▸ **focus**(): `void`

#### Returns

`void`

#### Inherited from

[TextEditor](TextEditor.md).[focus](TextEditor.md#focus)

#### Defined in

[editors/editors.ts:19](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L19)

___

### getDecimalPlaces

▸ **getDecimalPlaces**(): `number`

#### Returns

`number`

#### Defined in

[editors/editors.ts:104](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L104)

___

### getValue

▸ **getValue**(): `string`

#### Returns

`string`

#### Inherited from

[TextEditor](TextEditor.md).[getValue](TextEditor.md#getvalue)

#### Defined in

[editors/editors.ts:23](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L23)

___

### init

▸ **init**(): `void`

#### Returns

`void`

#### Inherited from

[TextEditor](TextEditor.md).[init](TextEditor.md#init)

#### Defined in

[editors/editors.ts:71](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L71)

___

### isValueChanged

▸ **isValueChanged**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[TextEditor](TextEditor.md).[isValueChanged](TextEditor.md#isvaluechanged)

#### Defined in

[editors/editors.ts:48](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L48)

___

### loadValue

▸ **loadValue**(`item`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `any` |

#### Returns

`void`

#### Overrides

[TextEditor](TextEditor.md).[loadValue](TextEditor.md#loadvalue)

#### Defined in

[editors/editors.ts:113](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L113)

___

### serializeValue

▸ **serializeValue**(): `any`

#### Returns

`any`

#### Overrides

[TextEditor](TextEditor.md).[serializeValue](TextEditor.md#serializevalue)

#### Defined in

[editors/editors.ts:128](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L128)

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

[editors/editors.ts:27](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L27)

___

### validate

▸ **validate**(): [`ValidationResult`](../interfaces/ValidationResult.md)

#### Returns

[`ValidationResult`](../interfaces/ValidationResult.md)

#### Overrides

[TextEditor](TextEditor.md).[validate](TextEditor.md#validate)

#### Defined in

[editors/editors.ts:147](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L147)
