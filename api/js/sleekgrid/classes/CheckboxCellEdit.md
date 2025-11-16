[sleekgrid](../README.md) / CheckboxCellEdit

# Class: CheckboxCellEdit

Defined in: [src/editors/editors.tsx:253](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L253)

## Extends

- `BaseCellEdit`

## Constructors

### Constructor

> **new CheckboxCellEdit**(`args`): `CheckboxCellEdit`

Defined in: [src/editors/editors.tsx:9](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L9)

#### Parameters

##### args

[`EditorOptions`](../interfaces/EditorOptions.md)

#### Returns

`CheckboxCellEdit`

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

> **\_input**: `HTMLInputElement`

Defined in: [src/editors/editors.tsx:255](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L255)

#### Overrides

`BaseCellEdit._input`

## Methods

### applyValue()

> **applyValue**(`item`, `state`): `void`

Defined in: [src/editors/editors.tsx:277](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L277)

#### Parameters

##### item

`any`

##### state

`any`

#### Returns

`void`

#### Overrides

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

Defined in: [src/editors/editors.tsx:257](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L257)

#### Returns

`void`

#### Overrides

`BaseCellEdit.init`

***

### isValueChanged()

> **isValueChanged**(): `boolean`

Defined in: [src/editors/editors.tsx:281](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L281)

#### Returns

`boolean`

#### Overrides

`BaseCellEdit.isValueChanged`

***

### loadValue()

> **loadValue**(`item`): `void`

Defined in: [src/editors/editors.tsx:264](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L264)

#### Parameters

##### item

`any`

#### Returns

`void`

#### Overrides

`BaseCellEdit.loadValue`

***

### preClick()

> **preClick**(): `void`

Defined in: [src/editors/editors.tsx:269](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L269)

#### Returns

`void`

***

### serializeValue()

> **serializeValue**(): `boolean`

Defined in: [src/editors/editors.tsx:273](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L273)

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

Defined in: [src/editors/editors.tsx:285](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L285)

#### Returns

`object`

##### msg

> **msg**: `string`

##### valid

> **valid**: `boolean` = `true`

#### Overrides

`BaseCellEdit.validate`
