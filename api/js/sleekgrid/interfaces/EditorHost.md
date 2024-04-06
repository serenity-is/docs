[@serenity-is/sleekgrid](../README.md) / EditorHost

# Interface: EditorHost

## Implemented by

- [`Grid`](../classes/Grid.md)

## Table of contents

### Properties

- [onCompositeEditorChange](EditorHost.md#oncompositeeditorchange)

### Methods

- [getActiveCell](EditorHost.md#getactivecell)
- [navigateNext](EditorHost.md#navigatenext)
- [navigatePrev](EditorHost.md#navigateprev)

## Properties

### onCompositeEditorChange

• **onCompositeEditorChange**: [`EventEmitter`](../classes/EventEmitter.md)\<`any`, [`IEventData`](IEventData.md)\>

#### Defined in

[core/editing.ts:28](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#L28)

## Methods

### getActiveCell

▸ **getActiveCell**(): [`RowCell`](RowCell.md)

#### Returns

[`RowCell`](RowCell.md)

#### Defined in

[core/editing.ts:25](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#L25)

___

### navigateNext

▸ **navigateNext**(): `boolean`

#### Returns

`boolean`

#### Defined in

[core/editing.ts:26](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#L26)

___

### navigatePrev

▸ **navigatePrev**(): `boolean`

#### Returns

`boolean`

#### Defined in

[core/editing.ts:27](https://github.com/serenity-is/sleekgrid/blob/master/src/core/editing.ts#L27)
