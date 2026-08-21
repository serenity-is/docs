[@serenity-is/corelib](../README.md) / LookupOptions

# Interface: LookupOptions\<TItem\>

Defined in: [src/base/lookup.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L5)

Options used to construct a [Lookup](../classes/Lookup.md).

## Type Parameters

### TItem

`TItem`

Type of the lookup items.

## Properties

### idField?

> `optional` **idField**: `string`

Defined in: [src/base/lookup.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L7)

Name of the field that holds the unique identifier for an item. Used as the key in [Lookup.itemById](../classes/Lookup.md#itembyid).

***

### parentIdField?

> `optional` **parentIdField**: `string`

Defined in: [src/base/lookup.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L9)

Name of the field that holds the parent identifier (for hierarchical lookups).

***

### textField?

> `optional` **textField**: `string`

Defined in: [src/base/lookup.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L11)

Name of the field that holds the human-readable display text for an item.
