[@serenity-is/corelib](../README.md) / Lookup

# Class: Lookup\<TItem\>

Defined in: [src/base/lookup.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L19)

Concrete implementation of the Lookup interface for client-side use.
Maintains `items` and a `itemById` index synchronized via [Lookup.update](#update).

## Example

```ts
const lookup = new Lookup<{ id: number; name: string }>({ idField: "id", textField: "name" }, items);
lookup.itemById["5"] // item with id 5
```

## Type Parameters

### TItem

`TItem`

Type of the lookup items.

## Constructors

### Constructor

> **new Lookup**\<`TItem`\>(`options`, `items?`): `Lookup`\<`TItem`\>

Defined in: [src/base/lookup.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L59)

Creates a new lookup instance.

#### Parameters

##### options

[`LookupOptions`](../interfaces/LookupOptions.md)\<`TItem`\>

Field mapping for id/parent/text. Pass `null`/`undefined` for an empty configuration (fields remain `undefined`).

##### items?

`TItem`[]

Optional initial item array. If provided, [update](#update) is called immediately to populate `items` and `itemById`.

#### Returns

`Lookup`\<`TItem`\>

## Properties

### idField

> **idField**: `string`

Defined in: [src/base/lookup.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L25)

Name of the ID field (copied from [LookupOptions.idField](../interfaces/LookupOptions.md#idfield)).

***

### itemById

> **itemById**: `object`

Defined in: [src/base/lookup.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L23)

Dictionary mapping stringified [LookupOptions.idField](../interfaces/LookupOptions.md#idfield) values to their corresponding items.

#### Index Signature

\[`key`: `string`\]: `TItem`

***

### items

> **items**: `TItem`[]

Defined in: [src/base/lookup.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L21)

Flat array of all lookup items.

***

### parentIdField

> **parentIdField**: `string`

Defined in: [src/base/lookup.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L27)

Name of the parent-ID field for hierarchical lookups (copied from [LookupOptions.parentIdField](../interfaces/LookupOptions.md#parentidfield)).

***

### textField

> **textField**: `string`

Defined in: [src/base/lookup.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L29)

Name of the display-text field (copied from [LookupOptions.textField](../interfaces/LookupOptions.md#textfield)).

## Methods

### update()?

> `optional` **update**(`value`): `void`

Defined in: [src/base/lookup.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L76)

Replaces the lookup contents and rebuilds the `itemById` index.

#### Parameters

##### value

`TItem`[]

New item array. `null`/`undefined` clears the lookup. Primitive values (e.g. `string` numbers from a distinct query) are auto-wrapped as `{ [idField]: value, [textField]: value }`.

#### Returns

`void`

#### Remarks

Re-initializes both [Lookup.items](#items) and [Lookup.itemById](#itembyid). The method is declared optional (`update?`) on the interface for compatibility with plain-object lookups, but is always present on this class.
