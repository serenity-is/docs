[@serenity-is/corelib](../README.md) / ShadowRootContainer

# Type Alias: ShadowRootContainer

> **ShadowRootContainer** = `object`

Defined in: [../domwise/dist/index.d.ts:2681](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2681)

A virtual descriptor for a `ShadowRoot` created by `ShadowRootNode`.
Recognized by the JSX factory to create a shadow root on the parent element
via `attachShadow`. See [ShadowRootNode](../functions/ShadowRootNode.md).

## Properties

### attr

> **attr**: `object`

Defined in: [../domwise/dist/index.d.ts:2685](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2685)

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

Defined in: [../domwise/dist/index.d.ts:2700](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2700)

Children rendered inside the shadow root.

***

### ref

> **ref**: [`Ref`](Ref.md)\<`ShadowRoot`\>

Defined in: [../domwise/dist/index.d.ts:2683](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2683)

Optional ref that receives the created `ShadowRoot`.
