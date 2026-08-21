[@serenity-is/corelib](../README.md) / Fluent

# Function: Fluent()

Factory / constructor for Fluent wrappers. Also usable with `new`.

## Param

Tag name to create, or an element / `EventTarget` to wrap.

## Call Signature

> **Fluent**\<`K`\>(`tag`): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElementTagNameMap`\[`K`\]\>

Defined in: [src/base/fluent.ts:491](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L491)

Creates a Fluent wrapper from a tag name or an existing element.

### Type Parameters

#### K

`K` *extends* keyof `HTMLElementTagNameMap`

### Parameters

#### tag

`K`

Tag name to create (e.g. `"div"`). Must match `^[a-zA-Z][a-zA-Z0-9\\-]*$`; otherwise an empty wrapper is returned.

### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElementTagNameMap`\[`K`\]\>

A Fluent wrapping the newly created element.

## Call Signature

> **Fluent**\<`TElement`\>(`element`): [`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

Defined in: [src/base/fluent.ts:497](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L497)

Wraps an existing element in a Fluent instance.

### Type Parameters

#### TElement

`TElement` *extends* `HTMLElement`

### Parameters

#### element

`TElement`

Element to wrap; `null` / `undefined` yields an empty wrapper.

### Returns

[`Fluent`](../interfaces/Fluent.md)\<`TElement`\>

A Fluent wrapping `element`.

## Call Signature

> **Fluent**(`element`): [`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

Defined in: [src/base/fluent.ts:503](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L503)

Wraps an `EventTarget` (typically an `HTMLElement`) in a Fluent instance.

### Parameters

#### element

`EventTarget`

Target to wrap.

### Returns

[`Fluent`](../interfaces/Fluent.md)\<`HTMLElement`\>

A Fluent wrapping `element`.
