[@serenity-is/sleekgrid](../README.md) / PercentCompleteCellEdit

# Class: PercentCompleteCellEdit

Defined in: [src/editors/editors.tsx:362](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L362)

Percent-complete editor combining [IntegerCellEdit](IntegerCellEdit.md) with a vertical
jQuery UI slider and preset buttons (0/50/100%).

## Extends

- [`IntegerCellEdit`](IntegerCellEdit.md)

## Constructors

### Constructor

> **new PercentCompleteCellEdit**(`args`): `PercentCompleteCellEdit`

Defined in: [src/editors/editors.tsx:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L13)

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

Defined in: [src/editors/editors.tsx:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L11)

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`_args`](IntegerCellEdit.md#_args)

***

### \_defaultValue

> `protected` **\_defaultValue**: `any`

Defined in: [src/editors/editors.tsx:10](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L10)

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`_defaultValue`](IntegerCellEdit.md#_defaultvalue)

***

### \_input

> **\_input**: `HTMLInputElement`

Defined in: [src/editors/editors.tsx:110](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L110)

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`_input`](IntegerCellEdit.md#_input)

***

### \_picker

> `protected` **\_picker**: `HTMLDivElement`

Defined in: [src/editors/editors.tsx:363](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L363)

***

### \_slider

> `protected` **\_slider**: `HTMLDivElement`

Defined in: [src/editors/editors.tsx:364](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L364)

## Methods

### applyValue()

> **applyValue**(`item`, `state`): `void`

Defined in: [src/editors/editors.tsx:73](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L73)

Writes the serialized value back to the data item's field.

#### Parameters

##### item

`any`

Row data item to mutate.

##### state

`any`

Value returned by [BaseCellEdit.serializeValue](TextCellEdit.md#serializevalue).

#### Returns

`void`

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`applyValue`](IntegerCellEdit.md#applyvalue)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/editors/editors.tsx:418](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L418)

Removes the editor input from the DOM.

#### Returns

`void`

#### Overrides

[`IntegerCellEdit`](IntegerCellEdit.md).[`destroy`](IntegerCellEdit.md#destroy)

***

### focus()

> **focus**(): `void`

Defined in: [src/editors/editors.tsx:27](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L27)

Focuses the editor's input element.

#### Returns

`void`

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`focus`](IntegerCellEdit.md#focus)

***

### getValue()

> **getValue**(): `string`

Defined in: [src/editors/editors.tsx:35](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L35)

Reads the current input value as a string.

#### Returns

`string`

Raw string value from the input.

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`getValue`](IntegerCellEdit.md#getvalue)

***

### init()

> **init**(): `void`

Defined in: [src/editors/editors.tsx:366](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L366)

Creates and attaches the editor DOM; called by the constructor.

#### Returns

`void`

#### Overrides

[`IntegerCellEdit`](IntegerCellEdit.md).[`init`](IntegerCellEdit.md#init)

***

### isValueChanged()

> **isValueChanged**(): `boolean`

Defined in: [src/editors/editors.tsx:81](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L81)

Tests whether the editor content differs from the loaded default.

#### Returns

`boolean`

`true` if the value has changed.

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`isValueChanged`](IntegerCellEdit.md#isvaluechanged)

***

### loadValue()

> **loadValue**(`item`): `void`

Defined in: [src/editors/editors.tsx:411](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L411)

Loads the item's field value into the editor and selects it.

#### Parameters

##### item

`any`

Row data item whose field is being edited.

#### Returns

`void`

#### Overrides

[`IntegerCellEdit`](IntegerCellEdit.md).[`loadValue`](IntegerCellEdit.md#loadvalue)

***

### serializeValue()

> **serializeValue**(): `any`

Defined in: [src/editors/editors.tsx:128](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L128)

Serializes the current input value for commit.

#### Returns

`any`

String content of the input.

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`serializeValue`](IntegerCellEdit.md#serializevalue)

***

### setValue()

> **setValue**(`val`): `void`

Defined in: [src/editors/editors.tsx:43](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L43)

Writes a string value into the input.

#### Parameters

##### val

`string`

Value to set; `null`/`undefined` becomes empty string.

#### Returns

`void`

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`setValue`](IntegerCellEdit.md#setvalue)

***

### validate()

> **validate**(): [`ValidationResult`](../interfaces/ValidationResult.md)

Defined in: [src/editors/editors.tsx:132](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L132)

Validates the current value using the column's `validator`, if any.

#### Returns

[`ValidationResult`](../interfaces/ValidationResult.md)

Validation result; always valid when no validator is configured.

#### Inherited from

[`IntegerCellEdit`](IntegerCellEdit.md).[`validate`](IntegerCellEdit.md#validate)
