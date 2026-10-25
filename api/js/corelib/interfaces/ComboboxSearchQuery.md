[@serenity-is/corelib](../README.md) / ComboboxSearchQuery

# Interface: ComboboxSearchQuery

Defined in: [src/ui/editors/combobox.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L30)

Query passed to a combobox search callback.

## Properties

### checkMore?

> `optional` **checkMore**: `boolean`

Defined in: [src/ui/editors/combobox.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L40)

Whether to check for more results.

***

### idList?

> `optional` **idList**: `string`[]

Defined in: [src/ui/editors/combobox.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L34)

List of ids to initialize the selection from.

***

### initSelection?

> `optional` **initSelection**: `boolean`

Defined in: [src/ui/editors/combobox.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L42)

Whether this is an initial selection query.

***

### searchTerm?

> `optional` **searchTerm**: `string`

Defined in: [src/ui/editors/combobox.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L32)

The search term.

***

### signal?

> `optional` **signal**: `AbortSignal`

Defined in: [src/ui/editors/combobox.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L44)

Abort signal for cancelling the query.

***

### skip?

> `optional` **skip**: `number`

Defined in: [src/ui/editors/combobox.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L36)

Number of items to skip.

***

### take?

> `optional` **take**: `number`

Defined in: [src/ui/editors/combobox.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/combobox.ts#L38)

Number of items to take.
