[@serenity-is/sleekgrid](../README.md) / LongTextCellEdit

# Class: LongTextCellEdit

## Extends

- `BaseCellEdit`

## Constructors

### new LongTextCellEdit()

> **new LongTextCellEdit**(`args`): [`LongTextCellEdit`](LongTextCellEdit.md)

#### Parameters

##### args

[`EditorOptions`](../interfaces/EditorOptions.md)

#### Returns

[`LongTextCellEdit`](LongTextCellEdit.md)

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

### \_container

> `protected` **\_container**: `HTMLElement`

#### Defined in

[editors/editors.ts:350](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L350)

***

### \_defaultValue

> `protected` **\_defaultValue**: `any`

#### Inherited from

`BaseCellEdit._defaultValue`

#### Defined in

[editors/editors.ts:5](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L5)

***

### \_input

> **\_input**: `HTMLTextAreaElement`

#### Overrides

`BaseCellEdit._input`

#### Defined in

[editors/editors.ts:349](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L349)

***

### \_wrapper

> `protected` **\_wrapper**: `HTMLDivElement`

#### Defined in

[editors/editors.ts:351](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L351)

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

### cancel()

> **cancel**(): `void`

#### Returns

`void`

#### Defined in

[editors/editors.ts:408](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L408)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Overrides

`BaseCellEdit.destroy`

#### Defined in

[editors/editors.ts:426](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L426)

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

### handleKeyDown()

> **handleKeyDown**(`e`): `void`

#### Parameters

##### e

`KeyboardEvent`

#### Returns

`void`

#### Defined in

[editors/editors.ts:378](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L378)

***

### hide()

> **hide**(): `void`

#### Returns

`void`

#### Defined in

[editors/editors.ts:413](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L413)

***

### init()

> **init**(): `void`

#### Returns

`void`

#### Overrides

`BaseCellEdit.init`

#### Defined in

[editors/editors.ts:353](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L353)

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

### position()

> **position**(`position`): `void`

#### Parameters

##### position

[`Position`](../interfaces/Position.md)

#### Returns

`void`

#### Defined in

[editors/editors.ts:421](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L421)

***

### save()

> **save**(): `void`

#### Returns

`void`

#### Defined in

[editors/editors.ts:404](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L404)

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

### show()

> **show**(): `void`

#### Returns

`void`

#### Defined in

[editors/editors.ts:417](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L417)

***

### validate()

> **validate**(): [`ValidationResult`](../interfaces/ValidationResult.md)

#### Returns

[`ValidationResult`](../interfaces/ValidationResult.md)

#### Inherited from

`BaseCellEdit.validate`

#### Defined in

[editors/editors.ts:52](https://github.com/serenity-is/sleekgrid/blob/master/src/editors/editors.ts#L52)
