[@serenity-is/sleekgrid](../README.md) / CheckboxCellEdit

# Class: CheckboxCellEdit

## Extends

- `BaseCellEdit`

## Constructors

### new CheckboxCellEdit()

> **new CheckboxCellEdit**(`args`): [`CheckboxCellEdit`](CheckboxCellEdit.md)

#### Parameters

##### args

[`EditorOptions`](../interfaces/EditorOptions.md)

#### Returns

[`CheckboxCellEdit`](CheckboxCellEdit.md)

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

[editors/editors.ts:253](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L253)

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

#### Overrides

`BaseCellEdit.applyValue`

#### Defined in

[editors/editors.ts:275](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L275)

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

[editors/editors.ts:255](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L255)

***

### isValueChanged()

> **isValueChanged**(): `boolean`

#### Returns

`boolean`

#### Overrides

`BaseCellEdit.isValueChanged`

#### Defined in

[editors/editors.ts:279](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L279)

***

### loadValue()

> **loadValue**(`item`): `void`

#### Parameters

##### item

`any`

#### Returns

`void`

#### Overrides

`BaseCellEdit.loadValue`

#### Defined in

[editors/editors.ts:262](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L262)

***

### preClick()

> **preClick**(): `void`

#### Returns

`void`

#### Defined in

[editors/editors.ts:267](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L267)

***

### serializeValue()

> **serializeValue**(): `boolean`

#### Returns

`boolean`

#### Overrides

`BaseCellEdit.serializeValue`

#### Defined in

[editors/editors.ts:271](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L271)

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

> **validate**(): `object`

#### Returns

`object`

##### msg

> **msg**: `string`

##### valid

> **valid**: `boolean` = `true`

#### Overrides

`BaseCellEdit.validate`

#### Defined in

[editors/editors.ts:283](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L283)
