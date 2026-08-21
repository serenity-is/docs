[@serenity-is/corelib](../../../../README.md) / [Fluent](../README.md) / isInputLike

# Function: isInputLike()

> **isInputLike**(`element`): element is HTMLButtonElement \| HTMLInputElement \| HTMLSelectElement \| HTMLTextAreaElement

Defined in: [src/base/fluent.ts:779](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L779)

Tests whether the element is an input-like control (`input`, `select`, `textarea`, or `button`).

## Parameters

### element

`Element`

Element to test.

## Returns

element is HTMLButtonElement \| HTMLInputElement \| HTMLSelectElement \| HTMLTextAreaElement

`true` when the element's tag name matches an input-like tag.
