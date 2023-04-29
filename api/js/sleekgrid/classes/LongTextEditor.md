[@serenity-is/sleekgrid](../README.md) / LongTextEditor

# Class: LongTextEditor

## Hierarchy

- `BaseEditor`

  ↳ **`LongTextEditor`**

## Table of contents

### Constructors

- [constructor](LongTextEditor.md#constructor)

### Properties

- [\_args](LongTextEditor.md#_args)
- [\_container](LongTextEditor.md#_container)
- [\_defaultValue](LongTextEditor.md#_defaultvalue)
- [\_input](LongTextEditor.md#_input)
- [\_wrapper](LongTextEditor.md#_wrapper)

### Methods

- [applyValue](LongTextEditor.md#applyvalue)
- [cancel](LongTextEditor.md#cancel)
- [destroy](LongTextEditor.md#destroy)
- [focus](LongTextEditor.md#focus)
- [getValue](LongTextEditor.md#getvalue)
- [handleKeyDown](LongTextEditor.md#handlekeydown)
- [hide](LongTextEditor.md#hide)
- [init](LongTextEditor.md#init)
- [isValueChanged](LongTextEditor.md#isvaluechanged)
- [loadValue](LongTextEditor.md#loadvalue)
- [position](LongTextEditor.md#position)
- [save](LongTextEditor.md#save)
- [serializeValue](LongTextEditor.md#serializevalue)
- [setValue](LongTextEditor.md#setvalue)
- [show](LongTextEditor.md#show)
- [validate](LongTextEditor.md#validate)

## Constructors

### constructor

• **new LongTextEditor**(`args`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `args` | [`EditorOptions`](../interfaces/EditorOptions.md) |

#### Inherited from

BaseEditor.constructor

#### Defined in

[editors/editors.ts:8](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;8)

## Properties

### \_args

• `Protected` **\_args**: [`EditorOptions`](../interfaces/EditorOptions.md)

#### Inherited from

BaseEditor.\_args

#### Defined in

[editors/editors.ts:6](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;6)

___

### \_container

• `Protected` **\_container**: `HTMLElement`

#### Defined in

[editors/editors.ts:349](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;349)

___

### \_defaultValue

• `Protected` **\_defaultValue**: `any`

#### Inherited from

BaseEditor.\_defaultValue

#### Defined in

[editors/editors.ts:5](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;5)

___

### \_input

• **\_input**: `HTMLTextAreaElement`

#### Overrides

BaseEditor.\_input

#### Defined in

[editors/editors.ts:348](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;348)

___

### \_wrapper

• `Protected` **\_wrapper**: `HTMLDivElement`

#### Defined in

[editors/editors.ts:350](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;350)

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

[editors/editors.ts:44](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;44)

___

### cancel

▸ **cancel**(): `void`

#### Returns

`void`

#### Defined in

[editors/editors.ts:407](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;407)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Overrides

BaseEditor.destroy

#### Defined in

[editors/editors.ts:425](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;425)

___

### focus

▸ **focus**(): `void`

#### Returns

`void`

#### Inherited from

BaseEditor.focus

#### Defined in

[editors/editors.ts:19](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;19)

___

### getValue

▸ **getValue**(): `string`

#### Returns

`string`

#### Inherited from

BaseEditor.getValue

#### Defined in

[editors/editors.ts:23](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;23)

___

### handleKeyDown

▸ **handleKeyDown**(`e`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `e` | `KeyboardEvent` |

#### Returns

`void`

#### Defined in

[editors/editors.ts:377](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;377)

___

### hide

▸ **hide**(): `void`

#### Returns

`void`

#### Defined in

[editors/editors.ts:412](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;412)

___

### init

▸ **init**(): `void`

#### Returns

`void`

#### Overrides

BaseEditor.init

#### Defined in

[editors/editors.ts:352](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;352)

___

### isValueChanged

▸ **isValueChanged**(): `boolean`

#### Returns

`boolean`

#### Inherited from

BaseEditor.isValueChanged

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

BaseEditor.loadValue

#### Defined in

[editors/editors.ts:31](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;31)

___

### position

▸ **position**(`position`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `position` | [`Position`](../interfaces/Position.md) |

#### Returns

`void`

#### Defined in

[editors/editors.ts:420](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;420)

___

### save

▸ **save**(): `void`

#### Returns

`void`

#### Defined in

[editors/editors.ts:403](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;403)

___

### serializeValue

▸ **serializeValue**(): `any`

#### Returns

`any`

#### Inherited from

BaseEditor.serializeValue

#### Defined in

[editors/editors.ts:40](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;40)

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

[editors/editors.ts:27](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;27)

___

### show

▸ **show**(): `void`

#### Returns

`void`

#### Defined in

[editors/editors.ts:416](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;416)

___

### validate

▸ **validate**(): [`ValidationResult`](../interfaces/ValidationResult.md)

#### Returns

[`ValidationResult`](../interfaces/ValidationResult.md)

#### Inherited from

BaseEditor.validate

#### Defined in

[editors/editors.ts:52](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#line&#x3D;52)
