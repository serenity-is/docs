[@serenity-is/sleekgrid](../README.md) / PercentCompleteCellEdit

# Class: PercentCompleteCellEdit

## Extends

- [`IntegerCellEdit`](IntegerCellEdit.md)

## Constructors

### new PercentCompleteCellEdit()

> **new PercentCompleteCellEdit**(`args`): [`PercentCompleteCellEdit`](PercentCompleteCellEdit.md)

#### Parameters

##### args

[`EditorOptions`](../interfaces/EditorOptions.md)

#### Returns

[`PercentCompleteCellEdit`](PercentCompleteCellEdit.md)

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`constructor`](IntegerCellEdit.md#constructors)

#### Defined in

[editors/editors.ts:8](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L8)

## Properties

### \_args

> `protected` **\_args**: [`EditorOptions`](../interfaces/EditorOptions.md)

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`_args`](IntegerCellEdit.md#_args)

#### Defined in

[editors/editors.ts:6](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L6)

***

### \_defaultValue

> `protected` **\_defaultValue**: `any`

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`_defaultValue`](IntegerCellEdit.md#_defaultvalue)

#### Defined in

[editors/editors.ts:5](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L5)

***

### \_input

> **\_input**: `HTMLInputElement`

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`_input`](IntegerCellEdit.md#_input)

#### Defined in

[editors/editors.ts:69](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L69)

***

### \_picker

> `protected` **\_picker**: `HTMLDivElement`

#### Defined in

[editors/editors.ts:292](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L292)

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

[`IntegerCellEdit`](IntegerCellEdit.md).[`applyValue`](IntegerCellEdit.md#applyvalue)

#### Defined in

[editors/editors.ts:44](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L44)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Overrides

[`IntegerCellEdit`](IntegerCellEdit.md).[`destroy`](IntegerCellEdit.md#destroy)

#### Defined in

[editors/editors.ts:336](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L336)

***

### focus()

> **focus**(): `void`

#### Returns

`void`

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`focus`](IntegerCellEdit.md#focus)

#### Defined in

[editors/editors.ts:19](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L19)

***

### getValue()

> **getValue**(): `string`

#### Returns

`string`

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`getValue`](IntegerCellEdit.md#getvalue)

#### Defined in

[editors/editors.ts:23](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L23)

***

### init()

> **init**(): `void`

#### Returns

`void`

#### Overrides

[`IntegerCellEdit`](IntegerCellEdit.md).[`init`](IntegerCellEdit.md#init)

#### Defined in

[editors/editors.ts:294](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L294)

***

### isValueChanged()

> **isValueChanged**(): `boolean`

#### Returns

`boolean`

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`isValueChanged`](IntegerCellEdit.md#isvaluechanged)

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

[`IntegerCellEdit`](IntegerCellEdit.md).[`loadValue`](IntegerCellEdit.md#loadvalue)

#### Defined in

[editors/editors.ts:31](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L31)

***

### serializeValue()

> **serializeValue**(): `number`

#### Returns

`number`

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`serializeValue`](IntegerCellEdit.md#serializevalue)

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

[`IntegerCellEdit`](IntegerCellEdit.md).[`setValue`](IntegerCellEdit.md#setvalue)

#### Defined in

[editors/editors.ts:27](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L27)

***

### validate()

> **validate**(): [`ValidationResult`](../interfaces/ValidationResult.md)

#### Returns

[`ValidationResult`](../interfaces/ValidationResult.md)

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`validate`](IntegerCellEdit.md#validate)

#### Defined in

[editors/editors.ts:87](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L87)
