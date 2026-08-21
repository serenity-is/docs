[@serenity-is/corelib](../README.md) / useText

# Function: useText()

> **useText**(`initialValue?`): readonly \[`Text`, (`value`) => `void`\]

Defined in: [../domwise/dist/index.d.ts:2663](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2663)

Creates a `Text` node and a setter to update its content.

The node's `toString()` is overridden to return `textContent`, so the
returned `Text` can be interpolated directly as a JSX child and will
render its string value.

## Parameters

### initialValue?

`string`

Optional initial text content. If omitted the node starts empty.

## Returns

readonly \[`Text`, (`value`) => `void`\]

A readonly tuple `[textNode, setText]` where `setText` assigns `textContent`.

## Example

```tsx
const [label, setLabel] = useText("hello");
return <><span>{label}</span><button onClick={() => setLabel("world")} /></>;
```
