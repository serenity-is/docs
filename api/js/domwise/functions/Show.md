[@serenity-is/domwise](../README.md) / Show

# Function: Show()

> **Show**\<`TWhen`\>(`props`): [`JSXElement`](../type-aliases/JSXElement.md)

Defined in: [src/show.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/show.ts#L109)

Conditional rendering helper similar to Solid's `<Show>`.

Renders `children` when `when` is truthy, otherwise renders `fallback`.
Either slot may be a plain `ComponentChildren` value or a function that
receives the resolved `when` value. When `when` is a signal, the output is
a derived signal node so the DOM updates reactively; its lifecycle is
bound to the rendered node so the subscription is disposed with it.

When a slot is a function, its result is considered owned by `Show`: the
previous result is disposed (via its `disposing` listeners) when the branch
changes, since a new result is produced on every evaluation and the old one
can never be reused. Plain (non-function) children are caller-owned and are
never disposed on switch, as the same instance is reused each time. When the
currently shown element is disposed, any branch held by `Show` (including a
hidden plain branch) is disposed as well. Fragments and arrays are disposed
through a snapshot of their rendered nodes, anchored to their first live
node.

## Type Parameters

### TWhen

`TWhen`

Type of the condition value.

## Parameters

### props

Props bag.

#### autoDispose?

`boolean`

When `true` (default), disposes previous function-slot results on switch and disposes held branches when the shown element is disposed. Pass `false` to opt out of all disposal/lifecycle handling.

#### children?

[`ComponentChildren`](../type-aliases/ComponentChildren.md) \| (`when`) => [`ComponentChildren`](../type-aliases/ComponentChildren.md)

Content rendered when `when` is truthy. May be children or a function `(when) => children`.

#### fallback?

[`ComponentChildren`](../type-aliases/ComponentChildren.md) \| (`when`) => [`ComponentChildren`](../type-aliases/ComponentChildren.md)

Content rendered when `when` is falsy. May be children or a function `(when) => children`.

#### when

[`SignalOrValue`](../type-aliases/SignalOrValue.md)\<`TWhen` \| `null` \| `undefined`\>

Condition; truthiness controls which branch is shown. May be a plain value or a signal.

## Returns

[`JSXElement`](../type-aliases/JSXElement.md)

A `JSXElement` (or derived-signal node) representing the active branch.

## Remarks

A `DocumentFragment` is one-shot: appending it moves its children out and
leaves the fragment empty. To switch branches properly, pass fragments from
the function form (`{() => buildFragment()}`) so a fresh fragment is produced
on every switch. A directly passed fragment renders only once and inserts
nothing when the branch is shown again.

Primitive branch values (string, number, boolean) are rendered through a
`Text` node so `Show` still has a node to anchor the branch lifecycle and the
derived signal's subscription to `when`.

## Example

```tsx
const loggedIn = signal(false);
<Show when={loggedIn} fallback="Please sign in">Welcome!</Show>
<Show when={loggedIn}>{() => <Dashboard user={loggedIn.value} />}</Show>
```
