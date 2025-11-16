[sleekgrid](../README.md) / LongTextCellEdit

# Class: LongTextCellEdit

Defined in: [src/editors/editors.tsx:353](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L353)

## Extends

- `BaseCellEdit`

## Constructors

### Constructor

> **new LongTextCellEdit**(`args`): `LongTextCellEdit`

Defined in: [src/editors/editors.tsx:9](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L9)

#### Parameters

##### args

[`EditorOptions`](../interfaces/EditorOptions.md)

#### Returns

`LongTextCellEdit`

#### Inherited from

`BaseCellEdit.constructor`

## Properties

### \_args

> `protected` **\_args**: [`EditorOptions`](../interfaces/EditorOptions.md)

Defined in: [src/editors/editors.tsx:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L7)

#### Inherited from

`BaseCellEdit._args`

***

### \_container

> `protected` **\_container**: `HTMLElement`

Defined in: [src/editors/editors.tsx:356](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L356)

***

### \_defaultValue

> `protected` **\_defaultValue**: `any`

Defined in: [src/editors/editors.tsx:6](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L6)

#### Inherited from

`BaseCellEdit._defaultValue`

***

### \_input

> **\_input**: `HTMLTextAreaElement`

Defined in: [src/editors/editors.tsx:355](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L355)

#### Overrides

`BaseCellEdit._input`

***

### \_wrapper

> `protected` **\_wrapper**: `HTMLDivElement`

Defined in: [src/editors/editors.tsx:357](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L357)

## Methods

### applyValue()

> **applyValue**(`item`, `state`): `void`

Defined in: [src/editors/editors.tsx:45](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L45)

#### Parameters

##### item

`any`

##### state

`any`

#### Returns

`void`

#### Inherited from

`BaseCellEdit.applyValue`

***

### cancel()

> **cancel**(): `void`

Defined in: [src/editors/editors.tsx:415](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L415)

#### Returns

`void`

***

### destroy()

> **destroy**(): `void`

Defined in: [src/editors/editors.tsx:433](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L433)

#### Returns

`void`

#### Overrides

`BaseCellEdit.destroy`

***

### focus()

> **focus**(): `void`

Defined in: [src/editors/editors.tsx:20](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L20)

#### Returns

`void`

#### Inherited from

`BaseCellEdit.focus`

***

### getValue()

> **getValue**(): `string`

Defined in: [src/editors/editors.tsx:24](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L24)

#### Returns

`string`

#### Inherited from

`BaseCellEdit.getValue`

***

### handleKeyDown()

> **handleKeyDown**(`e`): `void`

Defined in: [src/editors/editors.tsx:385](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L385)

#### Parameters

##### e

`KeyboardEvent`

#### Returns

`void`

***

### hide()

> **hide**(): `void`

Defined in: [src/editors/editors.tsx:420](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L420)

#### Returns

`void`

***

### init()

> **init**(): `void`

Defined in: [src/editors/editors.tsx:359](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L359)

#### Returns

`void`

#### Overrides

`BaseCellEdit.init`

***

### isValueChanged()

> **isValueChanged**(): `boolean`

Defined in: [src/editors/editors.tsx:49](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L49)

#### Returns

`boolean`

#### Inherited from

`BaseCellEdit.isValueChanged`

***

### loadValue()

> **loadValue**(`item`): `void`

Defined in: [src/editors/editors.tsx:32](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L32)

#### Parameters

##### item

`any`

#### Returns

`void`

#### Inherited from

`BaseCellEdit.loadValue`

***

### position()

> **position**(`position`): `void`

Defined in: [src/editors/editors.tsx:428](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L428)

#### Parameters

##### position

[`Position`](../interfaces/Position.md)

#### Returns

`void`

***

### save()

> **save**(): `void`

Defined in: [src/editors/editors.tsx:411](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L411)

#### Returns

`void`

***

### serializeValue()

> **serializeValue**(): `any`

Defined in: [src/editors/editors.tsx:41](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L41)

#### Returns

`any`

#### Inherited from

`BaseCellEdit.serializeValue`

***

### setValue()

> **setValue**(`val`): `void`

Defined in: [src/editors/editors.tsx:28](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L28)

#### Parameters

##### val

`string`

#### Returns

`void`

#### Inherited from

`BaseCellEdit.setValue`

***

### show()

> **show**(): `void`

Defined in: [src/editors/editors.tsx:424](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L424)

#### Returns

`void`

***

### validate()

> **validate**(): [`ValidationResult`](../interfaces/ValidationResult.md)

Defined in: [src/editors/editors.tsx:53](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L53)

#### Returns

[`ValidationResult`](../interfaces/ValidationResult.md)

#### Inherited from

`BaseCellEdit.validate`
