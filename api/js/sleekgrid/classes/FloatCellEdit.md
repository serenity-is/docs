[serenity-is/sleekgrid](../README.md) / FloatCellEdit

# Class: FloatCellEdit

Defined in: [src/editors/editors.tsx:100](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L100)

## Extends

- [`TextCellEdit`](TextCellEdit.md)

## Constructors

### Constructor

> **new FloatCellEdit**(`args`): `FloatCellEdit`

Defined in: [src/editors/editors.tsx:9](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L9)

#### Parameters

##### args

[`EditorOptions`](../interfaces/EditorOptions.md)

#### Returns

`FloatCellEdit`

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`constructor`](TextCellEdit.md#constructor)

## Properties

### \_args

> `protected` **\_args**: [`EditorOptions`](../interfaces/EditorOptions.md)

Defined in: [src/editors/editors.tsx:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L7)

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`_args`](TextCellEdit.md#_args)

***

### \_defaultValue

> `protected` **\_defaultValue**: `any`

Defined in: [src/editors/editors.tsx:6](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L6)

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`_defaultValue`](TextCellEdit.md#_defaultvalue)

***

### \_input

> **\_input**: `HTMLInputElement`

Defined in: [src/editors/editors.tsx:70](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L70)

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`_input`](TextCellEdit.md#_input)

***

### AllowEmptyValue

> `static` **AllowEmptyValue**: `boolean` = `false`

Defined in: [src/editors/editors.tsx:102](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L102)

***

### DefaultDecimalPlaces

> `static` **DefaultDecimalPlaces**: `number` = `null`

Defined in: [src/editors/editors.tsx:103](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L103)

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

[`TextCellEdit`](TextCellEdit.md).[`applyValue`](TextCellEdit.md#applyvalue)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/editors/editors.tsx:16](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L16)

#### Returns

`void`

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`destroy`](TextCellEdit.md#destroy)

***

### focus()

> **focus**(): `void`

Defined in: [src/editors/editors.tsx:20](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L20)

#### Returns

`void`

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`focus`](TextCellEdit.md#focus)

***

### getDecimalPlaces()

> **getDecimalPlaces**(): `number`

Defined in: [src/editors/editors.tsx:105](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L105)

#### Returns

`number`

***

### getValue()

> **getValue**(): `string`

Defined in: [src/editors/editors.tsx:24](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L24)

#### Returns

`string`

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`getValue`](TextCellEdit.md#getvalue)

***

### init()

> **init**(): `void`

Defined in: [src/editors/editors.tsx:72](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L72)

#### Returns

`void`

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`init`](TextCellEdit.md#init)

***

### isValueChanged()

> **isValueChanged**(): `boolean`

Defined in: [src/editors/editors.tsx:49](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L49)

#### Returns

`boolean`

#### Inherited from

[`TextCellEdit`](TextCellEdit.md).[`isValueChanged`](TextCellEdit.md#isvaluechanged)

***

### loadValue()

> **loadValue**(`item`): `void`

Defined in: [src/editors/editors.tsx:114](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L114)

#### Parameters

##### item

`any`

#### Returns

`void`

#### Overrides

[`TextCellEdit`](TextCellEdit.md).[`loadValue`](TextCellEdit.md#loadvalue)

***

### serializeValue()

> **serializeValue**(): `any`

Defined in: [src/editors/editors.tsx:129](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L129)

#### Returns

`any`

#### Overrides

[`TextCellEdit`](TextCellEdit.md).[`serializeValue`](TextCellEdit.md#serializevalue)

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

[`TextCellEdit`](TextCellEdit.md).[`setValue`](TextCellEdit.md#setvalue)

***

### validate()

> **validate**(): [`ValidationResult`](../interfaces/ValidationResult.md)

Defined in: [src/editors/editors.tsx:148](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/editors/editors.tsx#L148)

#### Returns

[`ValidationResult`](../interfaces/ValidationResult.md)

#### Overrides

[`TextCellEdit`](TextCellEdit.md).[`validate`](TextCellEdit.md#validate)
