[@serenity-is/corelib](../README.md) / Dictionary

# ~~Type Alias: Dictionary\<TItem\>~~

> **Dictionary**\<`TItem`\> = `object`

Defined in: [src/compat/system-compat.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/system-compat.ts#L8)

A plain-object dictionary mapping string keys to values of type `TItem`.

## Type Parameters

### TItem

`TItem`

The type of each dictionary value.

## Index Signature

\[`key`: `string`\]: `TItem`

## Deprecated

Prefer Record`<string, TItem>` or Map`<string, TItem>` over this legacy alias.
