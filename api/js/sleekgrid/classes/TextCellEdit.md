[@serenity-is/sleekgrid](../README.md) / TextCellEdit

# Class: TextCellEdit

## Extends

- `BaseCellEdit`

## Extended by

- [`IntegerCellEdit`](IntegerCellEdit.md)
- [`FloatCellEdit`](FloatCellEdit.md)
- [`DateCellEdit`](DateCellEdit.md)

## Constructors

### new TextCellEdit()

> **new TextCellEdit**(`args`): [`TextCellEdit`](TextCellEdit.md)

#### Parameters

##### args

[`EditorOptions`](../interfaces/EditorOptions.md)

#### Returns

[`TextCellEdit`](TextCellEdit.md)

#### Inherited from

`BaseCellEdit.constructor`

#### Defined in

[editors/editors.ts:8](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L8)

## Properties

### \_args

> `protected` **\_args**: [`EditorOptions`](../interfaces/EditorOptions.md)

#### Inherited from

`BaseCellEdit._args`

#### Defined in

[editors/editors.ts:6](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L6)

***

### \_defaultValue

> `protected` **\_defaultValue**: `any`

#### Inherited from

`BaseCellEdit._defaultValue`

#### Defined in

[editors/editors.ts:5](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L5)

***

### \_input

> **\_input**: `HTMLInputElement`

#### Overrides

`BaseCellEdit._input`

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

`BaseCellEdit.applyValue`

#### Defined in

[editors/editors.ts:44](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L44)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Inherited from

`BaseCellEdit.destroy`

#### Defined in

[editors/editors.ts:15](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L15)

***

### focus()

> **focus**(): `void`

#### Returns

`void`

#### Inherited from

`BaseCellEdit.focus`

#### Defined in

[editors/editors.ts:19](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L19)

***

### getValue()

> **getValue**(): `string`

#### Returns

`string`

#### Inherited from

`BaseCellEdit.getValue`

#### Defined in

[editors/editors.ts:23](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L23)

***

### init()

> **init**(): `void`

#### Returns

`void`

#### Overrides

`BaseCellEdit.init`

#### Defined in

[editors/editors.ts:71](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L71)

***

### isValueChanged()

> **isValueChanged**(): `boolean`

#### Returns

`boolean`

#### Inherited from

`BaseCellEdit.isValueChanged`

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

`BaseCellEdit.loadValue`

#### Defined in

[editors/editors.ts:31](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L31)

***

### serializeValue()

> **serializeValue**(): `any`

#### Returns

`any`

#### Inherited from

`BaseCellEdit.serializeValue`

#### Defined in

[editors/editors.ts:40](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L40)

***

### setValue()

> **setValue**(`val`): `void`

#### Parameters

##### val

`string`

#### Returns

`void`

#### Inherited from

`BaseCellEdit.setValue`

#### Defined in

[editors/editors.ts:27](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L27)

***

### validate()

> **validate**(): [`ValidationResult`](../interfaces/ValidationResult.md)

#### Returns

[`ValidationResult`](../interfaces/ValidationResult.md)

#### Inherited from

`BaseCellEdit.validate`

#### Defined in

[editors/editors.ts:52](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L52)
