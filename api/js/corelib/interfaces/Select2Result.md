[@serenity-is/corelib](../README.md) / Select2Result

# Interface: Select2Result

Defined in: [src/ui/editors/select2.tsx:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L52)

Result of a Select2 query.

## Properties

### context?

> `optional` **context**: `any`

Defined in: [src/ui/editors/select2.tsx:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L62)

Additional context.

***

### errorInfo?

> `optional` **errorInfo**: `any`

Defined in: [src/ui/editors/select2.tsx:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L56)

Error information.

***

### hasError?

> `optional` **hasError**: `boolean`

Defined in: [src/ui/editors/select2.tsx:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L54)

Whether the query failed.

***

### more?

> `optional` **more**: `boolean`

Defined in: [src/ui/editors/select2.tsx:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L60)

Whether there are more results.

***

### results

> **results**: [`Select2Item`](Select2Item.md)[]

Defined in: [src/ui/editors/select2.tsx:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L58)

The result items.
