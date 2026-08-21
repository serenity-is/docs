[@serenity-is/corelib](../README.md) / appendToNode

# Function: appendToNode()

> **appendToNode**(`parent`, `child`): `void`

Defined in: [src/base/html.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L94)

Appends heterogeneous content to a parent node.
Handles strings (as text nodes), `Node` instances, array-like collections (recursively),
promise-like values (async placeholder replaced on resolve/reject), and primitive values via `Node.append`.
Falsy values `null`, `undefined`, and `false` are ignored.

## Parameters

### parent

`ParentNode`

Target parent node to append into.

### child

`any`

Content to append: a single value, array-like collection, `Node`, string, or `PromiseLike`.

## Returns

`void`

## Remarks

Promise children insert a comment placeholder synchronously and replace it with the resolved fragment when settled.
