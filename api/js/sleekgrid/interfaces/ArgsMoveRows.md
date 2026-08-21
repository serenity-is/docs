[@serenity-is/sleekgrid](../README.md) / ArgsMoveRows

# Interface: ArgsMoveRows

Defined in: [src/plugins/rowmovemanager.ts:23](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowmovemanager.ts#L23)

Payload for row-move events ([RowMoveManager.onBeforeMoveRows](../classes/RowMoveManager.md#onbeforemoverows) / [RowMoveManager.onMoveRows](../classes/RowMoveManager.md#onmoverows)).

## Properties

### insertBefore

> **insertBefore**: `number`

Defined in: [src/plugins/rowmovemanager.ts:27](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowmovemanager.ts#L27)

Insertion index before which the rows should be placed.

***

### rows

> **rows**: `number`[]

Defined in: [src/plugins/rowmovemanager.ts:25](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/plugins/rowmovemanager.ts#L25)

Data rows being moved (view indices, in display order).
