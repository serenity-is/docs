[@serenity-is/sleekgrid](../README.md) / PercentCompleteCellEdit

# Class: PercentCompleteCellEdit

Defined in: [src/editors/editors.tsx:293](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L293)

## Extends

- [`IntegerCellEdit`](IntegerCellEdit.md)

## Constructors

### Constructor

> **new PercentCompleteCellEdit**(`args`): `PercentCompleteCellEdit`

Defined in: [src/editors/editors.tsx:9](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L9)

#### Parameters

##### args

[`EditorOptions`](../interfaces/EditorOptions.md)

#### Returns

`PercentCompleteCellEdit`

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`constructor`](IntegerCellEdit.md#constructor)

## Properties

### \_args

> `protected` **\_args**: [`EditorOptions`](../interfaces/EditorOptions.md)

Defined in: [src/editors/editors.tsx:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L7)

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`_args`](IntegerCellEdit.md#_args)

***

### \_defaultValue

> `protected` **\_defaultValue**: `any`

Defined in: [src/editors/editors.tsx:6](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L6)

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`_defaultValue`](IntegerCellEdit.md#_defaultvalue)

***

### \_input

> **\_input**: `HTMLInputElement`

Defined in: [src/editors/editors.tsx:70](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L70)

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`_input`](IntegerCellEdit.md#_input)

***

### \_picker

> `protected` **\_picker**: `HTMLDivElement`

Defined in: [src/editors/editors.tsx:294](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L294)

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

[`IntegerCellEdit`](IntegerCellEdit.md).[`applyValue`](IntegerCellEdit.md#applyvalue)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/editors/editors.tsx:342](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L342)

#### Returns

`void`

#### Overrides

[`IntegerCellEdit`](IntegerCellEdit.md).[`destroy`](IntegerCellEdit.md#destroy)

***

### focus()

> **focus**(): `void`

Defined in: [src/editors/editors.tsx:20](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L20)

#### Returns

`void`

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`focus`](IntegerCellEdit.md#focus)

***

### getValue()

> **getValue**(): `string`

Defined in: [src/editors/editors.tsx:24](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L24)

#### Returns

`string`

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`getValue`](IntegerCellEdit.md#getvalue)

***

### init()

> **init**(): `void`

Defined in: [src/editors/editors.tsx:296](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L296)

#### Returns

`void`

#### Overrides

[`IntegerCellEdit`](IntegerCellEdit.md).[`init`](IntegerCellEdit.md#init)

***

### isValueChanged()

> **isValueChanged**(): `boolean`

Defined in: [src/editors/editors.tsx:49](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L49)

#### Returns

`boolean`

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`isValueChanged`](IntegerCellEdit.md#isvaluechanged)

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

[`IntegerCellEdit`](IntegerCellEdit.md).[`loadValue`](IntegerCellEdit.md#loadvalue)

***

### serializeValue()

> **serializeValue**(): `number`

Defined in: [src/editors/editors.tsx:84](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L84)

#### Returns

`number`

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`serializeValue`](IntegerCellEdit.md#serializevalue)

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

[`IntegerCellEdit`](IntegerCellEdit.md).[`setValue`](IntegerCellEdit.md#setvalue)

***

### validate()

> **validate**(): [`ValidationResult`](../interfaces/ValidationResult.md)

Defined in: [src/editors/editors.tsx:88](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L88)

#### Returns

[`ValidationResult`](../interfaces/ValidationResult.md)

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`validate`](IntegerCellEdit.md#validate)
