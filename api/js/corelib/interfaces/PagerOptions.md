[@serenity-is/corelib](../README.md) / PagerOptions

# Interface: PagerOptions

Defined in: [src/slick/slicktypes.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L62)

Options for the slick pager control.

## Properties

### onChangePage()?

> `optional` **onChangePage**: (`newPage`) => `void`

Defined in: [src/slick/slicktypes.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L72)

Callback when page changes.

#### Parameters

##### newPage

`number`

New page index (1-based).

#### Returns

`void`

***

### onRowsPerPageChange()?

> `optional` **onRowsPerPageChange**: (`n`) => `void`

Defined in: [src/slick/slicktypes.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L74)

Callback when rows-per-page changes.

#### Parameters

##### n

`number`

New rows-per-page value.

#### Returns

`void`

***

### rowsPerPage?

> `optional` **rowsPerPage**: `number`

Defined in: [src/slick/slicktypes.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L68)

Current rows per page.

***

### rowsPerPageOptions?

> `optional` **rowsPerPageOptions**: `number`[]

Defined in: [src/slick/slicktypes.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L70)

Choices for rows-per-page selector.

***

### showRowsPerPage?

> `optional` **showRowsPerPage**: `boolean`

Defined in: [src/slick/slicktypes.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L66)

Whether to show rows-per-page selector.

***

### view?

> `optional` **view**: `any`

Defined in: [src/slick/slicktypes.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/slicktypes.ts#L64)

Data view instance.
