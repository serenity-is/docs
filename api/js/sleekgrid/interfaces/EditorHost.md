[serenity-is/sleekgrid](../README.md) / EditorHost

# Interface: EditorHost

Defined in: [src/core/editing.ts:24](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L24)

## Extended by

- [`ISleekGrid`](ISleekGrid.md)

## Properties

### onCompositeEditorChange

> **onCompositeEditorChange**: [`EventEmitter`](../classes/EventEmitter.md)\<`any`\>

Defined in: [src/core/editing.ts:28](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L28)

## Methods

### getActiveCell()

> **getActiveCell**(): [`RowCell`](RowCell.md)

Defined in: [src/core/editing.ts:25](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L25)

#### Returns

[`RowCell`](RowCell.md)

***

### getEditorFactory()

> **getEditorFactory**(): [`EditorFactory`](EditorFactory.md)

Defined in: [src/core/editing.ts:29](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L29)

#### Returns

[`EditorFactory`](EditorFactory.md)

***

### navigateNext()

> **navigateNext**(): `boolean`

Defined in: [src/core/editing.ts:26](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L26)

#### Returns

`boolean`

***

### navigatePrev()

> **navigatePrev**(): `boolean`

Defined in: [src/core/editing.ts:27](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L27)

#### Returns

`boolean`
