[@serenity-is/corelib](../README.md) / useText

# Function: useText()

> **useText**(`initialValue?`): readonly \[`Text`, (`value`) => `void`\]

Defined in: [../domwise/dist/index.d.ts:2362](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2362)

Creates a `Text` node and a setter function to update its content.
The text node's `toString` is overridden to return its `textContent`,
making it suitable for use as a child in JSX.

## Parameters

### initialValue?

`string`

Optional initial text content.

## Returns

readonly \[`Text`, (`value`) => `void`\]

A tuple of the `Text` node and a setter to update its content.
