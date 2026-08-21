[@serenity-is/domwise](../README.md) / ShadowRootContainer

# Type Alias: ShadowRootContainer

> **ShadowRootContainer** = `object`

Defined in: [types/components.d.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L48)

A virtual descriptor for a `ShadowRoot` created by `ShadowRootNode`.
Recognized by the JSX factory to create a shadow root on the parent element
via `attachShadow`. See [ShadowRootNode](../functions/ShadowRootNode.md).

## Properties

### attr

> **attr**: `object`

Defined in: [types/components.d.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L52)

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

Defined in: [types/components.d.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L67)

Children rendered inside the shadow root.

***

### ref

> **ref**: [`Ref`](Ref.md)\<`ShadowRoot`\>

Defined in: [types/components.d.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L50)

Optional ref that receives the created `ShadowRoot`.
