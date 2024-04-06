[@serenity-is/sleekgrid](../README.md) / TextEditor

# Class: TextEditor

## Hierarchy

- `BaseEditor`

  ↳ **`TextEditor`**

  ↳↳ [`IntegerEditor`](IntegerEditor.md)

  ↳↳ [`FloatEditor`](FloatEditor.md)

  ↳↳ [`DateEditor`](DateEditor.md)

## Table of contents

### Constructors

- [constructor](TextEditor.md#constructor)

### Properties

- [\_args](TextEditor.md#_args)
- [\_defaultValue](TextEditor.md#_defaultvalue)
- [\_input](TextEditor.md#_input)

### Methods

- [applyValue](TextEditor.md#applyvalue)
- [destroy](TextEditor.md#destroy)
- [focus](TextEditor.md#focus)
- [getValue](TextEditor.md#getvalue)
- [init](TextEditor.md#init)
- [isValueChanged](TextEditor.md#isvaluechanged)
- [loadValue](TextEditor.md#loadvalue)
- [serializeValue](TextEditor.md#serializevalue)
- [setValue](TextEditor.md#setvalue)
- [validate](TextEditor.md#validate)

## Constructors

### constructor

• **new TextEditor**(`args`): [`TextEditor`](TextEditor.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `args` | [`EditorOptions`](../interfaces/EditorOptions.md) |

#### Returns

[`TextEditor`](TextEditor.md)

#### Inherited from

BaseEditor.constructor

#### Defined in

[editors/editors.ts:8](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L8)

## Properties

### \_args

• `Protected` **\_args**: [`EditorOptions`](../interfaces/EditorOptions.md)

#### Inherited from

BaseEditor.\_args

#### Defined in

[editors/editors.ts:6](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L6)

___

### \_defaultValue

• `Protected` **\_defaultValue**: `any`

#### Inherited from

BaseEditor.\_defaultValue

#### Defined in

[editors/editors.ts:5](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L5)

___

### \_input

• **\_input**: `HTMLInputElement`

#### Overrides

BaseEditor.\_input

#### Defined in

[editors/editors.ts:69](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L69)

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

BaseEditor.applyValue

#### Defined in

[editors/editors.ts:44](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L44)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Inherited from

BaseEditor.destroy

#### Defined in

[editors/editors.ts:15](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L15)

___

### focus

▸ **focus**(): `void`

#### Returns

`void`

#### Inherited from

BaseEditor.focus

#### Defined in

[editors/editors.ts:19](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L19)

___

### getValue

▸ **getValue**(): `string`

#### Returns

`string`

#### Inherited from

BaseEditor.getValue

#### Defined in

[editors/editors.ts:23](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L23)

___

### init

▸ **init**(): `void`

#### Returns

`void`

#### Overrides

BaseEditor.init

#### Defined in

[editors/editors.ts:71](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L71)

___

### isValueChanged

▸ **isValueChanged**(): `boolean`

#### Returns

`boolean`

#### Inherited from

BaseEditor.isValueChanged

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

#### Inherited from

BaseEditor.loadValue

#### Defined in

[editors/editors.ts:31](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L31)

___

### serializeValue

▸ **serializeValue**(): `any`

#### Returns

`any`

#### Inherited from

BaseEditor.serializeValue

#### Defined in

[editors/editors.ts:40](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L40)

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

BaseEditor.setValue

#### Defined in

[editors/editors.ts:27](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L27)

___

### validate

▸ **validate**(): [`ValidationResult`](../interfaces/ValidationResult.md)

#### Returns

[`ValidationResult`](../interfaces/ValidationResult.md)

#### Inherited from

BaseEditor.validate

#### Defined in

[editors/editors.ts:52](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L52)
