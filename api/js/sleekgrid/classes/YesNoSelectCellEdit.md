[serenity-is/sleekgrid](../README.md) / YesNoSelectCellEdit

# Class: YesNoSelectCellEdit

Defined in: [src/editors/editors.tsx:218](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L218)

## Extends

- `BaseCellEdit`

## Constructors

### Constructor

> **new YesNoSelectCellEdit**(`args`): `YesNoSelectCellEdit`

Defined in: [src/editors/editors.tsx:9](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L9)

#### Parameters

##### args

[`EditorOptions`](../interfaces/EditorOptions.md)

#### Returns

`YesNoSelectCellEdit`

#### Inherited from

`BaseCellEdit.constructor`

## Properties

### \_args

> `protected` **\_args**: [`EditorOptions`](../interfaces/EditorOptions.md)

Defined in: [src/editors/editors.tsx:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L7)

#### Inherited from

`BaseCellEdit._args`

***

### \_defaultValue

> `protected` **\_defaultValue**: `any`

Defined in: [src/editors/editors.tsx:6](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L6)

#### Inherited from

`BaseCellEdit._defaultValue`

***

### \_input

> **\_input**: `HTMLSelectElement`

Defined in: [src/editors/editors.tsx:220](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L220)

#### Overrides

`BaseCellEdit._input`

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

### destroy()

> **destroy**(): `void`

Defined in: [src/editors/editors.tsx:16](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L16)

#### Returns

`void`

#### Inherited from

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

### init()

> **init**(): `void`

Defined in: [src/editors/editors.tsx:222](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L222)

#### Returns

`void`

#### Overrides

`BaseCellEdit.init`

***

### isValueChanged()

> **isValueChanged**(): `boolean`

Defined in: [src/editors/editors.tsx:241](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L241)

#### Returns

`boolean`

#### Overrides

`BaseCellEdit.isValueChanged`

***

### loadValue()

> **loadValue**(`item`): `void`

Defined in: [src/editors/editors.tsx:233](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L233)

#### Parameters

##### item

`any`

#### Returns

`void`

#### Overrides

`BaseCellEdit.loadValue`

***

### serializeValue()

> **serializeValue**(): `boolean`

Defined in: [src/editors/editors.tsx:237](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L237)

#### Returns

`boolean`

#### Overrides

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

### validate()

> **validate**(): `object`

Defined in: [src/editors/editors.tsx:245](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L245)

#### Returns

`object`

##### msg

> **msg**: `string`

##### valid

> **valid**: `boolean` = `true`

#### Overrides

`BaseCellEdit.validate`
