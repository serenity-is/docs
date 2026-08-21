[@serenity-is/sleekgrid](../README.md) / LongTextCellEdit

# Class: LongTextCellEdit

Defined in: [src/editors/editors.tsx:434](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L434)

Detached multi-line text editor using a floating `<textarea>` overlay.
Renders attached to `document.body` (or inline for composite editors) and
implements `show`/`hide`/`position` for the overlay lifecycle.

## Extends

- `BaseCellEdit`

## Constructors

### Constructor

> **new LongTextCellEdit**(`args`): `LongTextCellEdit`

Defined in: [src/editors/editors.tsx:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L13)

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

Defined in: [src/editors/editors.tsx:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L11)

#### Inherited from

`BaseCellEdit._args`

***

### \_container

> `protected` **\_container**: `HTMLElement`

Defined in: [src/editors/editors.tsx:437](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L437)

***

### \_defaultValue

> `protected` **\_defaultValue**: `any`

Defined in: [src/editors/editors.tsx:10](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L10)

#### Inherited from

`BaseCellEdit._defaultValue`

***

### \_input

> **\_input**: `HTMLTextAreaElement`

Defined in: [src/editors/editors.tsx:436](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L436)

#### Overrides

`BaseCellEdit._input`

***

### \_wrapper

> `protected` **\_wrapper**: `HTMLDivElement`

Defined in: [src/editors/editors.tsx:438](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L438)

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

### cancel()

> **cancel**(): `void`

Defined in: [src/editors/editors.tsx:505](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L505)

Cancels editing, restoring the default value and notifying the grid.

#### Returns

`void`

***

### destroy()

> **destroy**(): `void`

Defined in: [src/editors/editors.tsx:529](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L529)

Removes the editor input from the DOM.

#### Returns

`void`

#### Overrides

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

### handleKeyDown()

> **handleKeyDown**(`e`): `void`

Defined in: [src/editors/editors.tsx:471](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L471)

Handles overlay-specific keys: Ctrl+Enter to save, Esc to cancel, Tab/Shift+Tab
to navigate cells, and optionally Left/Right to navigate when at string bounds.

#### Parameters

##### e

`KeyboardEvent`

Keyboard event from the textarea.

#### Returns

`void`

***

### hide()

> **hide**(): `void`

Defined in: [src/editors/editors.tsx:511](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L511)

Hides the detached overlay wrapper.

#### Returns

`void`

***

### init()

> **init**(): `void`

Defined in: [src/editors/editors.tsx:440](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L440)

Creates and attaches the editor DOM; called by the constructor.

#### Returns

`void`

#### Overrides

`BaseCellEdit.init`

***

### isValueChanged()

> **isValueChanged**(): `boolean`

Defined in: [src/editors/editors.tsx:81](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L81)

Tests whether the editor content differs from the loaded default.

#### Returns

`boolean`

`true` if the value has changed.

#### Inherited from

`BaseCellEdit.isValueChanged`

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

`BaseCellEdit.loadValue`

***

### position()

> **position**(`position`): `void`

Defined in: [src/editors/editors.tsx:524](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L524)

Positions the detached overlay relative to the cell bounds.

#### Parameters

##### position

[`Position`](../interfaces/Position.md)

Pixel bounds of the target cell.

#### Returns

`void`

***

### save()

> **save**(): `void`

Defined in: [src/editors/editors.tsx:498](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L498)

Commits the current textarea value via the grid.

#### Returns

`void`

***

### serializeValue()

> **serializeValue**(): `any`

Defined in: [src/editors/editors.tsx:64](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L64)

Serializes the current input value for commit.

#### Returns

`any`

String content of the input.

#### Inherited from

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

### show()

> **show**(): `void`

Defined in: [src/editors/editors.tsx:516](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L516)

Shows the detached overlay wrapper.

#### Returns

`void`

***

### validate()

> **validate**(): [`ValidationResult`](../interfaces/ValidationResult.md)

Defined in: [src/editors/editors.tsx:89](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L89)

Validates the current value using the column's `validator`, if any.

#### Returns

[`ValidationResult`](../interfaces/ValidationResult.md)

Validation result; always valid when no validator is configured.

#### Inherited from

`BaseCellEdit.validate`
