[corelib](../../../../README.md) / [Fluent](../README.md) / isInputLike

# Function: isInputLike()

> **isInputLike**(`element`): element is HTMLButtonElement \| HTMLInputElement \| HTMLSelectElement \| HTMLTextAreaElement

Defined in: [src/base/fluent.ts:612](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L612)

Returns true if the element is input like. E.g. one of input, textarea, select, button. This is for compatibility with jQuery's :input selector.

## Parameters

### element

`Element`

The target element

## Returns

element is HTMLButtonElement \| HTMLInputElement \| HTMLSelectElement \| HTMLTextAreaElement

true if element is an input like node
