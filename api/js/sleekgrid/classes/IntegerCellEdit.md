[@serenity-is/sleekgrid](../README.md) / IntegerCellEdit

# Class: IntegerCellEdit

## Extends

- [`TextCellEdit`](TextCellEdit.md)

## Extended by

- [`PercentCompleteCellEdit`](PercentCompleteCellEdit.md)

## Constructors

### new IntegerCellEdit()

> **new IntegerCellEdit**(`args`): [`IntegerCellEdit`](IntegerCellEdit.md)

#### Parameters

##### args

[`EditorOptions`](../interfaces/EditorOptions.md)

#### Returns

[`IntegerCellEdit`](IntegerCellEdit.md)

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`constructor`](TextCellEdit.md#constructors)

#### Defined in

[editors/editors.ts:8](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L8)

## Properties

### \_args

> `protected` **\_args**: [`EditorOptions`](../interfaces/EditorOptions.md)

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`_args`](TextCellEdit.md#_args)

#### Defined in

[editors/editors.ts:6](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L6)

***

### \_defaultValue

> `protected` **\_defaultValue**: `any`

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`_defaultValue`](TextCellEdit.md#_defaultvalue)

#### Defined in

[editors/editors.ts:5](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L5)

***

### \_input

> **\_input**: `HTMLInputElement`

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`_input`](TextCellEdit.md#_input)

#### Defined in

[editors/editors.ts:69](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L69)

## Methods

### applyValue()

> **applyValue**(`item`, `state`): `void`

#### Parameters

##### item

`any`

##### state

`any`

#### Returns

`void`

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`applyValue`](TextCellEdit.md#applyvalue)

#### Defined in

[editors/editors.ts:44](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L44)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`destroy`](TextCellEdit.md#destroy)

#### Defined in

[editors/editors.ts:15](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L15)

***

### focus()

> **focus**(): `void`

#### Returns

`void`

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`focus`](TextCellEdit.md#focus)

#### Defined in

[editors/editors.ts:19](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L19)

***

### getValue()

> **getValue**(): `string`

#### Returns

`string`

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`getValue`](TextCellEdit.md#getvalue)

#### Defined in

[editors/editors.ts:23](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L23)

***

### init()

> **init**(): `void`

#### Returns

`void`

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`init`](TextCellEdit.md#init)

#### Defined in

[editors/editors.ts:71](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L71)

***

### isValueChanged()

> **isValueChanged**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`isValueChanged`](TextCellEdit.md#isvaluechanged)

#### Defined in

[editors/editors.ts:48](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L48)

***

### loadValue()

> **loadValue**(`item`): `void`

#### Parameters

##### item

`any`

#### Returns

`void`

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`loadValue`](TextCellEdit.md#loadvalue)

#### Defined in

[editors/editors.ts:31](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L31)

***

### serializeValue()

> **serializeValue**(): `number`

#### Returns

`number`

#### Overrides

[`TextCellEdit`](TextCellEdit.md).[`serializeValue`](TextCellEdit.md#serializevalue)

#### Defined in

[editors/editors.ts:83](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L83)

***

### setValue()

> **setValue**(`val`): `void`

#### Parameters

##### val

`string`

#### Returns

`void`

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`setValue`](TextCellEdit.md#setvalue)

#### Defined in

[editors/editors.ts:27](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L27)

***

### validate()

> **validate**(): [`ValidationResult`](../interfaces/ValidationResult.md)

#### Returns

[`ValidationResult`](../interfaces/ValidationResult.md)

#### Overrides

[`TextCellEdit`](TextCellEdit.md).[`validate`](TextCellEdit.md#validate)

#### Defined in

[editors/editors.ts:87](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L87)
