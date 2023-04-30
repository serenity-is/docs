[@serenity-is/sleekgrid](../README.md) / DateEditor

# Class: DateEditor

## Hierarchy

- [`TextEditor`](TextEditor.md)

  ↳ **`DateEditor`**

## Table of contents

### Constructors

- [constructor](DateEditor.md#constructor)

### Properties

- [\_args](DateEditor.md#_args)
- [\_calendarOpen](DateEditor.md#_calendaropen)
- [\_defaultValue](DateEditor.md#_defaultvalue)
- [\_input](DateEditor.md#_input)

### Methods

- [applyValue](DateEditor.md#applyvalue)
- [destroy](DateEditor.md#destroy)
- [focus](DateEditor.md#focus)
- [getValue](DateEditor.md#getvalue)
- [hide](DateEditor.md#hide)
- [init](DateEditor.md#init)
- [isValueChanged](DateEditor.md#isvaluechanged)
- [loadValue](DateEditor.md#loadvalue)
- [position](DateEditor.md#position)
- [serializeValue](DateEditor.md#serializevalue)
- [setValue](DateEditor.md#setvalue)
- [show](DateEditor.md#show)
- [validate](DateEditor.md#validate)

## Constructors

### constructor

• **new DateEditor**(`args`)

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

### \_calendarOpen

• `Private` **\_calendarOpen**: `boolean` = `false`

#### Defined in

[editors/editors.ts:160](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L160)

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

#### Overrides

[TextEditor](TextEditor.md).[destroy](TextEditor.md#destroy)

#### Defined in

[editors/editors.ts:183](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L183)

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

### getValue

▸ **getValue**(): `string`

#### Returns

`string`

#### Inherited from

[TextEditor](TextEditor.md).[getValue](TextEditor.md#getvalue)

#### Defined in

[editors/editors.ts:23](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L23)

___

### hide

▸ **hide**(): `void`

#### Returns

`void`

#### Defined in

[editors/editors.ts:198](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L198)

___

### init

▸ **init**(): `void`

#### Returns

`void`

#### Overrides

[TextEditor](TextEditor.md).[init](TextEditor.md#init)

#### Defined in

[editors/editors.ts:162](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L162)

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

#### Inherited from

[TextEditor](TextEditor.md).[loadValue](TextEditor.md#loadvalue)

#### Defined in

[editors/editors.ts:31](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L31)

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

[editors/editors.ts:205](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L205)

___

### serializeValue

▸ **serializeValue**(): `any`

#### Returns

`any`

#### Inherited from

[TextEditor](TextEditor.md).[serializeValue](TextEditor.md#serializevalue)

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

[TextEditor](TextEditor.md).[setValue](TextEditor.md#setvalue)

#### Defined in

[editors/editors.ts:27](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L27)

___

### show

▸ **show**(): `void`

#### Returns

`void`

#### Defined in

[editors/editors.ts:191](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L191)

___

### validate

▸ **validate**(): [`ValidationResult`](../interfaces/ValidationResult.md)

#### Returns

[`ValidationResult`](../interfaces/ValidationResult.md)

#### Inherited from

[TextEditor](TextEditor.md).[validate](TextEditor.md#validate)

#### Defined in

[editors/editors.ts:52](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L52)
