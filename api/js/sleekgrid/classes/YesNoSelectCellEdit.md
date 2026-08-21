[@serenity-is/sleekgrid](../README.md) / YesNoSelectCellEdit

# Class: YesNoSelectCellEdit

Defined in: [src/editors/editors.tsx:279](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L279)

Two-option select editor mapping `"yes"`/`"no"` to boolean `true`/`false`.

## Extends

- `BaseCellEdit`

## Constructors

### Constructor

> **new YesNoSelectCellEdit**(`args`): `YesNoSelectCellEdit`

Defined in: [src/editors/editors.tsx:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L13)

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

Defined in: [src/editors/editors.tsx:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L11)

#### Inherited from

`BaseCellEdit._args`

***

### \_defaultValue

> `protected` **\_defaultValue**: `any`

Defined in: [src/editors/editors.tsx:10](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L10)

#### Inherited from

`BaseCellEdit._defaultValue`

***

### \_input

> **\_input**: `HTMLSelectElement`

Defined in: [src/editors/editors.tsx:281](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L281)

#### Overrides

`BaseCellEdit._input`

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

`BaseCellEdit.applyValue`

***

### destroy()

> **destroy**(): `void`

Defined in: [src/editors/editors.tsx:22](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L22)

Removes the editor input from the DOM.

#### Returns

`void`

#### Inherited from

`BaseCellEdit.destroy`

***

### focus()

> **focus**(): `void`

Defined in: [src/editors/editors.tsx:27](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L27)

Focuses the editor's input element.

#### Returns

`void`

#### Inherited from

`BaseCellEdit.focus`

***

### getValue()

> **getValue**(): `string`

Defined in: [src/editors/editors.tsx:35](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L35)

Reads the current input value as a string.

#### Returns

`string`

Raw string value from the input.

#### Inherited from

`BaseCellEdit.getValue`

***

### init()

> **init**(): `void`

Defined in: [src/editors/editors.tsx:283](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L283)

Creates and attaches the editor DOM; called by the constructor.

#### Returns

`void`

#### Overrides

`BaseCellEdit.init`

***

### isValueChanged()

> **isValueChanged**(): `boolean`

Defined in: [src/editors/editors.tsx:302](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L302)

Tests whether the editor content differs from the loaded default.

#### Returns

`boolean`

`true` if the value has changed.

#### Overrides

`BaseCellEdit.isValueChanged`

***

### loadValue()

> **loadValue**(`item`): `void`

Defined in: [src/editors/editors.tsx:294](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L294)

Loads the item's field value into the editor and selects it.

#### Parameters

##### item

`any`

Row data item whose field is being edited.

#### Returns

`void`

#### Overrides

`BaseCellEdit.loadValue`

***

### serializeValue()

> **serializeValue**(): `any`

Defined in: [src/editors/editors.tsx:298](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L298)

Serializes the current input value for commit.

#### Returns

`any`

String content of the input.

#### Overrides

`BaseCellEdit.serializeValue`

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

`BaseCellEdit.setValue`

***

### validate()

> **validate**(): [`ValidationResult`](../interfaces/ValidationResult.md)

Defined in: [src/editors/editors.tsx:306](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L306)

Validates the current value using the column's `validator`, if any.

#### Returns

[`ValidationResult`](../interfaces/ValidationResult.md)

Validation result; always valid when no validator is configured.

#### Overrides

`BaseCellEdit.validate`
