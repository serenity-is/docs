[@serenity-is/sleekgrid](../README.md) / ViewRange

# Interface: ViewRange

Defined in: [src/core/viewrange.ts:5](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/viewrange.ts#L5)

Describes the current view/buffer window that is (or should be) rendered.
Row bounds are view indices; column bounds are pixel offsets into the virtual canvas.

## Properties

### bottom?

> `optional` **bottom**: `number`

Defined in: [src/core/viewrange.ts:9](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/viewrange.ts#L9)

Bottom row index of the range (exclusive or inclusive depending on caller; typically exclusive).

***

### leftPx?

> `optional` **leftPx**: `number`

Defined in: [src/core/viewrange.ts:11](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/viewrange.ts#L11)

Left pixel offset of the visible buffer window.

***

### rightPx?

> `optional` **rightPx**: `number`

Defined in: [src/core/viewrange.ts:13](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/viewrange.ts#L13)

Right pixel offset of the visible buffer window.

***

### top?

> `optional` **top**: `number`

Defined in: [src/core/viewrange.ts:7](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/viewrange.ts#L7)

Top row index of the range (inclusive).
