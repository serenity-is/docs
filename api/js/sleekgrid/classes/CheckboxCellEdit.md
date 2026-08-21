[@serenity-is/sleekgrid](../README.md) / CheckboxCellEdit

# Class: CheckboxCellEdit

Defined in: [src/editors/editors.tsx:318](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L318)

Checkbox editor backed by `<input type="checkbox">`. Supports `preClick` to
toggle on the click that activates the editor.

## Extends

- `BaseCellEdit`

## Constructors

### Constructor

> **new CheckboxCellEdit**(`args`): `CheckboxCellEdit`

Defined in: [src/editors/editors.tsx:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L13)

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

> **\_input**: `HTMLInputElement`

Defined in: [src/editors/editors.tsx:320](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L320)

#### Overrides

`BaseCellEdit._input`

## Methods

### applyValue()

> **applyValue**(`item`, `state`): `void`

Defined in: [src/editors/editors.tsx:342](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L342)

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

#### Overrides

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

Defined in: [src/editors/editors.tsx:322](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L322)

Creates and attaches the editor DOM; called by the constructor.

#### Returns

`void`

#### Overrides

`BaseCellEdit.init`

***

### isValueChanged()

> **isValueChanged**(): `boolean`

Defined in: [src/editors/editors.tsx:346](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L346)

Tests whether the editor content differs from the loaded default.

#### Returns

`boolean`

`true` if the value has changed.

#### Overrides

`BaseCellEdit.isValueChanged`

***

### loadValue()

> **loadValue**(`item`): `void`

Defined in: [src/editors/editors.tsx:329](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L329)

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

### preClick()

> **preClick**(): `void`

Defined in: [src/editors/editors.tsx:334](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L334)

#### Returns

`void`

***

### serializeValue()

> **serializeValue**(): `any`

Defined in: [src/editors/editors.tsx:338](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L338)

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

> **validate**(): `object`

Defined in: [src/editors/editors.tsx:350](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L350)

Validates the current value using the column's `validator`, if any.

#### Returns

`object`

Validation result; always valid when no validator is configured.

##### msg

> **msg**: `string`

##### valid

> **valid**: `boolean` = `true`

#### Overrides

`BaseCellEdit.validate`
