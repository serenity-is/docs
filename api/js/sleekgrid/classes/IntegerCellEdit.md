[@serenity-is/sleekgrid](../README.md) / IntegerCellEdit

# Class: IntegerCellEdit

Defined in: [src/editors/editors.tsx:126](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L126)

Integer editor extending [TextCellEdit](TextCellEdit.md). Serializes to `number` and
validates that the input is a valid integer.

## Extends

- [`TextCellEdit`](TextCellEdit.md)

## Extended by

- [`PercentCompleteCellEdit`](PercentCompleteCellEdit.md)

## Constructors

### Constructor

> **new IntegerCellEdit**(`args`): `IntegerCellEdit`

Defined in: [src/editors/editors.tsx:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L13)

#### Parameters

##### args

[`EditorOptions`](../interfaces/EditorOptions.md)

#### Returns

`IntegerCellEdit`

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`constructor`](TextCellEdit.md#constructor)

## Properties

### \_args

> `protected` **\_args**: [`EditorOptions`](../interfaces/EditorOptions.md)

Defined in: [src/editors/editors.tsx:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L11)

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`_args`](TextCellEdit.md#_args)

***

### \_defaultValue

> `protected` **\_defaultValue**: `any`

Defined in: [src/editors/editors.tsx:10](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L10)

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`_defaultValue`](TextCellEdit.md#_defaultvalue)

***

### \_input

> **\_input**: `HTMLInputElement`

Defined in: [src/editors/editors.tsx:110](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L110)

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`_input`](TextCellEdit.md#_input)

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

[`TextCellEdit`](TextCellEdit.md).[`applyValue`](TextCellEdit.md#applyvalue)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/editors/editors.tsx:22](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L22)

Removes the editor input from the DOM.

#### Returns

`void`

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`destroy`](TextCellEdit.md#destroy)

***

### focus()

> **focus**(): `void`

Defined in: [src/editors/editors.tsx:27](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L27)

Focuses the editor's input element.

#### Returns

`void`

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`focus`](TextCellEdit.md#focus)

***

### getValue()

> **getValue**(): `string`

Defined in: [src/editors/editors.tsx:35](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L35)

Reads the current input value as a string.

#### Returns

`string`

Raw string value from the input.

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`getValue`](TextCellEdit.md#getvalue)

***

### init()

> **init**(): `void`

Defined in: [src/editors/editors.tsx:112](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L112)

Creates and attaches the editor DOM; called by the constructor.

#### Returns

`void`

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`init`](TextCellEdit.md#init)

***

### isValueChanged()

> **isValueChanged**(): `boolean`

Defined in: [src/editors/editors.tsx:81](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L81)

Tests whether the editor content differs from the loaded default.

#### Returns

`boolean`

`true` if the value has changed.

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`isValueChanged`](TextCellEdit.md#isvaluechanged)

***

### loadValue()

> **loadValue**(`item`): `void`

Defined in: [src/editors/editors.tsx:51](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L51)

Loads the item's field value into the editor and selects it.

#### Parameters

##### item

`any`

Row data item whose field is being edited.

#### Returns

`void`

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`loadValue`](TextCellEdit.md#loadvalue)

***

### serializeValue()

> **serializeValue**(): `any`

Defined in: [src/editors/editors.tsx:128](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L128)

Serializes the current input value for commit.

#### Returns

`any`

String content of the input.

#### Overrides

[`TextCellEdit`](TextCellEdit.md).[`serializeValue`](TextCellEdit.md#serializevalue)

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

[`TextCellEdit`](TextCellEdit.md).[`setValue`](TextCellEdit.md#setvalue)

***

### validate()

> **validate**(): [`ValidationResult`](../interfaces/ValidationResult.md)

Defined in: [src/editors/editors.tsx:132](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L132)

Validates the current value using the column's `validator`, if any.

#### Returns

[`ValidationResult`](../interfaces/ValidationResult.md)

Validation result; always valid when no validator is configured.

#### Overrides

[`TextCellEdit`](TextCellEdit.md).[`validate`](TextCellEdit.md#validate)
