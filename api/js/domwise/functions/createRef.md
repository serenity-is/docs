[@serenity-is/domwise](../README.md) / createRef

# Function: createRef()

> **createRef**\<`T`\>(): [`RefObject`](../type-aliases/RefObject.md)\<`T`\>

Defined in: [src/ref.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/ref.ts#L18)

Creates a new sealed `RefObject` whose `current` is initially `null`.

The returned object is `Object.seal`ed so that no new properties can be
added, matching the `React.createRef` contract.

## Type Parameters

### T

`T` = `any`

Type of the value held by the ref.

## Returns

[`RefObject`](../type-aliases/RefObject.md)\<`T`\>

A sealed `RefObject<T>` with `current` set to `null`.

## Example

```tsx
const inputRef = createRef<HTMLInputElement>();
return <input ref={inputRef} />;
// later: inputRef.current?.focus();
```
