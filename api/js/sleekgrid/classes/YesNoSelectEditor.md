[@serenity-is/sleekgrid](../README.md) / YesNoSelectEditor

# Class: YesNoSelectEditor

## Hierarchy

- `BaseEditor`

  ↳ **`YesNoSelectEditor`**

## Table of contents

### Constructors

- [constructor](YesNoSelectEditor.md#constructor)

### Properties

- [\_args](YesNoSelectEditor.md#_args)
- [\_defaultValue](YesNoSelectEditor.md#_defaultvalue)
- [\_input](YesNoSelectEditor.md#_input)

### Methods

- [applyValue](YesNoSelectEditor.md#applyvalue)
- [destroy](YesNoSelectEditor.md#destroy)
- [focus](YesNoSelectEditor.md#focus)
- [getValue](YesNoSelectEditor.md#getvalue)
- [init](YesNoSelectEditor.md#init)
- [isValueChanged](YesNoSelectEditor.md#isvaluechanged)
- [loadValue](YesNoSelectEditor.md#loadvalue)
- [serializeValue](YesNoSelectEditor.md#serializevalue)
- [setValue](YesNoSelectEditor.md#setvalue)
- [validate](YesNoSelectEditor.md#validate)

## Constructors

### constructor

• **new YesNoSelectEditor**(`args`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `args` | [`EditorOptions`](../interfaces/EditorOptions.md) |

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

• **\_input**: `HTMLSelectElement`

#### Overrides

BaseEditor.\_input

#### Defined in

[editors/editors.ts:218](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L218)

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

[editors/editors.ts:220](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L220)

___

### isValueChanged

▸ **isValueChanged**(): `boolean`

#### Returns

`boolean`

#### Overrides

BaseEditor.isValueChanged

#### Defined in

[editors/editors.ts:238](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L238)

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

BaseEditor.loadValue

#### Defined in

[editors/editors.ts:230](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L230)

___

### serializeValue

▸ **serializeValue**(): `boolean`

#### Returns

`boolean`

#### Overrides

BaseEditor.serializeValue

#### Defined in

[editors/editors.ts:234](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L234)

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

▸ **validate**(): `Object`

#### Returns

`Object`

| Name | Type |
| :------ | :------ |
| `msg` | `string` |
| `valid` | `boolean` |

#### Overrides

BaseEditor.validate

#### Defined in

[editors/editors.ts:242](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L242)
