[@serenity-is/sleekgrid](../README.md) / CheckboxEditor

# Class: CheckboxEditor

## Hierarchy

- `BaseEditor`

  ↳ **`CheckboxEditor`**

## Table of contents

### Constructors

- [constructor](CheckboxEditor.md#constructor)

### Properties

- [\_args](CheckboxEditor.md#_args)
- [\_defaultValue](CheckboxEditor.md#_defaultvalue)
- [\_input](CheckboxEditor.md#_input)

### Methods

- [applyValue](CheckboxEditor.md#applyvalue)
- [destroy](CheckboxEditor.md#destroy)
- [focus](CheckboxEditor.md#focus)
- [getValue](CheckboxEditor.md#getvalue)
- [init](CheckboxEditor.md#init)
- [isValueChanged](CheckboxEditor.md#isvaluechanged)
- [loadValue](CheckboxEditor.md#loadvalue)
- [preClick](CheckboxEditor.md#preclick)
- [serializeValue](CheckboxEditor.md#serializevalue)
- [setValue](CheckboxEditor.md#setvalue)
- [validate](CheckboxEditor.md#validate)

## Constructors

### constructor

• **new CheckboxEditor**(`args`)

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

• **\_input**: `HTMLInputElement`

#### Overrides

BaseEditor.\_input

#### Defined in

[editors/editors.ts:252](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L252)

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

#### Overrides

BaseEditor.applyValue

#### Defined in

[editors/editors.ts:274](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L274)

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

[editors/editors.ts:254](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L254)

___

### isValueChanged

▸ **isValueChanged**(): `boolean`

#### Returns

`boolean`

#### Overrides

BaseEditor.isValueChanged

#### Defined in

[editors/editors.ts:278](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L278)

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

[editors/editors.ts:261](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L261)

___

### preClick

▸ **preClick**(): `void`

#### Returns

`void`

#### Defined in

[editors/editors.ts:266](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L266)

___

### serializeValue

▸ **serializeValue**(): `boolean`

#### Returns

`boolean`

#### Overrides

BaseEditor.serializeValue

#### Defined in

[editors/editors.ts:270](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L270)

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

[editors/editors.ts:282](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L282)
