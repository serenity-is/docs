[@serenity-is/corelib](../README.md) / Select2QueryOptions

# Interface: Select2QueryOptions

Defined in: [src/ui/editors/select2.tsx:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L16)

Options passed to a Select2 query callback.

## Properties

### callback()?

> `optional` **callback**: (`p1`) => `void`

Defined in: [src/ui/editors/select2.tsx:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L26)

Callback invoked with the results.

#### Parameters

##### p1

[`Select2Result`](Select2Result.md)

#### Returns

`void`

***

### context?

> `optional` **context**: `any`

Defined in: [src/ui/editors/select2.tsx:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L24)

Additional context.

***

### element?

> `optional` **element**: [`Select2Element`](../type-aliases/Select2Element.md)

Defined in: [src/ui/editors/select2.tsx:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L18)

The element the query is for.

***

### matcher()?

> `optional` **matcher**: (`p1`, `p2`, `p3?`) => `boolean`

Defined in: [src/ui/editors/select2.tsx:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L28)

Custom matcher function.

#### Parameters

##### p1

`any`

##### p2

`any`

##### p3?

`any`

#### Returns

`boolean`

***

### page?

> `optional` **page**: `number`

Defined in: [src/ui/editors/select2.tsx:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L22)

The page number.

***

### term?

> `optional` **term**: `string`

Defined in: [src/ui/editors/select2.tsx:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/select2.tsx#L20)

The search term.
