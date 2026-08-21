[@serenity-is/sleekgrid](../README.md) / Editor

# Interface: Editor

Defined in: [src/core/editing.ts:148](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L148)

Contract that all cell editors must implement.

## Properties

### keyCaptureList?

> `optional` **keyCaptureList**: `number`[]

Defined in: [src/core/editing.ts:166](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L166)

Key codes the editor captures even when the grid also handles them.

## Methods

### applyValue()

> **applyValue**(`item`, `value`): `void`

Defined in: [src/core/editing.ts:156](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L156)

Writes the edited value back to the data item.

#### Parameters

##### item

`any`

Row item to mutate.

##### value

`any`

Serialized value from [Editor.serializeValue](#serializevalue).

#### Returns

`void`

***

### destroy()

> **destroy**(): `void`

Defined in: [src/core/editing.ts:150](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L150)

Tears down DOM and listeners created by the editor.

#### Returns

`void`

***

### focus()

> **focus**(): `void`

Defined in: [src/core/editing.ts:158](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L158)

Focuses the editor's input element.

#### Returns

`void`

***

### hide()?

> `optional` **hide**(): `void`

Defined in: [src/core/editing.ts:182](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L182)

Hides the editor without destroying it.

#### Returns

`void`

***

### isValueChanged()

> **isValueChanged**(`args`): `boolean`

Defined in: [src/core/editing.ts:164](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L164)

Checks whether the current editor value differs from the original.

#### Parameters

##### args

Flags influencing the check (e.g. whether a commit is in progress).

###### commitEdit?

`boolean`

#### Returns

`boolean`

`true` if the value has changed.

***

### loadValue()

> **loadValue**(`value`): `void`

Defined in: [src/core/editing.ts:171](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L171)

Loads an existing cell value into the editor.

#### Parameters

##### value

`any`

The value to load.

#### Returns

`void`

***

### position()?

> `optional` **position**(`pos`): `void`

Defined in: [src/core/editing.ts:178](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L178)

Repositions the editor overlay.

#### Parameters

##### pos

[`Position`](Position.md)

New pixel bounds.

#### Returns

`void`

***

### preClick()?

> `optional` **preClick**(): `void`

Defined in: [src/core/editing.ts:180](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L180)

Hook invoked when the cell received a pre-click; editors may skip selection.

#### Returns

`void`

***

### serializeValue()

> **serializeValue**(): `any`

Defined in: [src/core/editing.ts:173](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L173)

Serializes the current editor value for commit.

#### Returns

`any`

***

### show()?

> `optional` **show**(): `void`

Defined in: [src/core/editing.ts:184](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L184)

Shows a previously hidden editor.

#### Returns

`void`

***

### validate()?

> `optional` **validate**(): [`ValidationResult`](ValidationResult.md)

Defined in: [src/core/editing.ts:186](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L186)

Validates the current value.

#### Returns

[`ValidationResult`](ValidationResult.md)

Validation result.
