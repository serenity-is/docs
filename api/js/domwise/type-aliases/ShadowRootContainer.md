[@serenity-is/domwise](../README.md) / ShadowRootContainer

# Type Alias: ShadowRootContainer

> **ShadowRootContainer** = `object`

Defined in: [types/components.d.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L60)

A virtual descriptor for a `ShadowRoot` created by `ShadowRootNode`.
Recognized by the JSX factory to create a shadow root on the parent element
via `attachShadow`. See [ShadowRootNode](../functions/ShadowRootNode.md).

## Properties

### attr

> **attr**: `object`

Defined in: [types/components.d.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L64)

`ShadowRootInit` options forwarded to `attachShadow`.

#### clonable?

> `optional` **clonable**: `boolean`

Whether the shadow root should be clonable.

#### customElementRegistry?

> `optional` **customElementRegistry**: `CustomElementRegistry`

Custom element registry for the shadow tree.

#### delegatesFocus?

> `optional` **delegatesFocus**: `boolean`

Whether focus should delegate to the shadow host.

#### mode

> **mode**: `ShadowRootMode`

Shadow root mode (`"open"` or `"closed"`).

#### serializable?

> `optional` **serializable**: `boolean`

Whether the shadow root is serializable.

#### slotAssignment?

> `optional` **slotAssignment**: `SlotAssignmentMode`

Slot assignment mode (`"manual"` or `"named"`).

***

### children

> **children**: [`ComponentChildren`](ComponentChildren.md)

Defined in: [types/components.d.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L79)

Children rendered inside the shadow root.

***

### ref

> **ref**: [`Ref`](Ref.md)\<`ShadowRoot`\>

Defined in: [types/components.d.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L62)

Optional ref that receives the created `ShadowRoot`.
