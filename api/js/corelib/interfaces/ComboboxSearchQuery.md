[@serenity-is/corelib](../README.md) / ComboboxSearchQuery

# Interface: ComboboxSearchQuery

Defined in: [src/ui/editors/combobox.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L27)

Query passed to a combobox search callback.

## Properties

### checkMore?

> `optional` **checkMore**: `boolean`

Defined in: [src/ui/editors/combobox.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L37)

Whether to check for more results.

***

### idList?

> `optional` **idList**: `string`[]

Defined in: [src/ui/editors/combobox.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L31)

List of ids to initialize the selection from.

***

### initSelection?

> `optional` **initSelection**: `boolean`

Defined in: [src/ui/editors/combobox.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L39)

Whether this is an initial selection query.

***

### searchTerm?

> `optional` **searchTerm**: `string`

Defined in: [src/ui/editors/combobox.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L29)

The search term.

***

### signal?

> `optional` **signal**: `AbortSignal`

Defined in: [src/ui/editors/combobox.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L41)

Abort signal for cancelling the query.

***

### skip?

> `optional` **skip**: `number`

Defined in: [src/ui/editors/combobox.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L33)

Number of items to skip.

***

### take?

> `optional` **take**: `number`

Defined in: [src/ui/editors/combobox.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L35)

Number of items to take.
