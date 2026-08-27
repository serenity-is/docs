# Signals and Reactivity

Signals are the reactive state primitives used throughout Serenity's client-side framework. They come from `@serenity-is/domwise` (which re-exports `@preact/signals-core`) and are re-exported by `@serenity-is/corelib`, so application code can import them from either package.

A signal is a container for a value that can be read and written, and that notifies its subscribers when the value changes. When a signal is used in JSX — as an attribute, a class, a style, or a child — the DOM updates automatically when the signal changes, without a virtual DOM or a diffing step.

## Creating a Signal

Use `signal` to create a writable signal with an initial value:

```ts
import { signal } from "@serenity-is/corelib";

const count = signal(0);
const name = signal("World");
```

`useSignal` is a convenience alias for `signal`:

```ts
import { useSignal } from "@serenity-is/corelib";

const count = useSignal(0);
```

## Reading and Writing Values

A signal's value is accessed through its `value` property:

```ts
const count = signal(0);

count.value = 5;          // write
console.log(count.value); // read -> 5
```

## Computed Signals

`computed` derives a read-only signal from other signals. It re-computes only when one of its dependencies changes:

```ts
import { computed, signal } from "@serenity-is/corelib";

const count = signal(2);
const doubled = computed(() => count.value * 2);

console.log(doubled.value); // 4
count.value = 3;
console.log(doubled.value); // 6
```

## Effects

`effect` runs a function immediately and re-runs it whenever any signal it reads changes. It returns a disposer function that stops the effect:

```ts
import { effect, signal } from "@serenity-is/corelib";

const count = signal(0);
const dispose = effect(() => {
    console.log("Count:", count.value);
});

count.value = 1; // logs "Count: 1"

dispose(); // stops the effect
```

## Batching Updates

`batch` groups multiple signal writes into a single notification, so subscribers are notified only once:

```ts
import { batch, signal } from "@serenity-is/corelib";

const count = signal(0);

batch(() => {
    count.value = 1;
    count.value = 2; // subscribers notified once, with value 2
});
```

## Reading Without Tracking

`untracked` reads signal values without creating a dependency on them. This is useful inside `computed` or `effect` when you want to read a signal without subscribing to it:

```ts
import { computed, signal, untracked } from "@serenity-is/corelib";

const count = signal(0);
const other = signal(10);

const total = computed(() => count.value + untracked(() => other.value));
// `total` re-computes when `count` changes, but not when `other` changes
```

## Reactive Bindings in JSX

When a signal is used in JSX, the DOM updates reactively.

### Attribute Bindings

```tsx
const title = signal("Hello");

<div title={title} />
// <div title="Hello">

title.value = "Updated";
// <div title="Updated">
```

### Class Bindings

```tsx
const active = signal(true);

<div class={{ active }} />
<div class={[active, "base"]} />
```

When a signal class value changes, only the affected classes are toggled — classes added manually via `classList.add()` are preserved.

### Style Bindings

```tsx
const color = signal("red");

<div style={{ color }} />
```

When a signal style value changes, only the affected properties are updated.

### Content Bindings

```tsx
const name = signal("World");

<div>Hello {name}!</div>
// <div>Hello World!</div>

name.value = "DomWise";
// <div>Hello DomWise!</div>
```

## Signal Utilities

### Type Guards

`isSignalLike`, `isWritableSignal`, and `isReadonlySignal` let you check whether a value is a signal, and whether it is writable or read-only (computed):

```ts
import { isSignalLike, isWritableSignal, isReadonlySignal } from "@serenity-is/corelib";

isSignalLike(obj);     // true if obj has subscribe(), peek(), and value
isWritableSignal(obj); // true if the signal's value is writable
isReadonlySignal(obj); // true if the signal is read-only (computed)
```

### observeSignal

`observeSignal` subscribes to a signal and invokes a callback immediately and on every change. The subscription is automatically tied to a DOM node's disposal, so it is cleaned up when the node is removed:

```ts
import { observeSignal } from "@serenity-is/corelib";

const dispose = observeSignal(mySignal, (args) => {
    console.log(args.newValue, args.prevValue, args.isInitial);
    args.lifecycleNode = someElement; // ties the subscription to the element's disposal
});
```

### derivedSignal

`derivedSignal` creates a computed signal from a source signal and a transform function:

```ts
import { derivedSignal } from "@serenity-is/corelib";

const derived = derivedSignal(source, value => transform(value));
```

### useUpdatableComputed

`useUpdatableComputed` creates computed signals that are only recalculated when you call `update()`, rather than automatically when dependencies change:

```ts
import { useUpdatableComputed } from "@serenity-is/corelib";

const { computed: cmp, update } = useUpdatableComputed();
const derived = cmp(() => expensiveCalculation(data));

update(); // forces recalculation
```

## Lifecycle and Disposal

Signal subscriptions created through JSX bindings and `observeSignal` are registered as disposing listeners on the DOM node that owns them. When the node is removed (for example via `Fluent.remove()` or `empty()`), the subscriptions are disposed automatically. This is the same disposal mechanism that Serenity widgets use, so reactive UI and widgets clean up together.

## Reactive or Imperative?

Signals are the recommended way to manage state that drives the DOM. They give you fine-grained updates without a virtual DOM, and they compose well with Serenity widgets.

Fluent (and direct DOM manipulation) remains useful for one-off imperative changes, porting jQuery code, and interacting with widgets. As a rule of thumb:

- Use **signals** for state that multiple parts of the UI read, or that changes over time.
- Use **Fluent / direct DOM** for one-off changes and for interacting with existing widgets.

## See Also

- [signal](../../api/js/domwise/variables/signal.md), [computed](../../api/js/domwise/variables/computed.md), [effect](../../api/js/domwise/variables/effect.md), [batch](../../api/js/domwise/variables/batch.md), [untracked](../../api/js/domwise/variables/untracked.md) — signal API reference.
- [useSignal](../../api/js/domwise/functions/useSignal.md), [useUpdatableComputed](../../api/js/domwise/functions/useUpdatableComputed.md) — signal helpers.
- [observeSignal](../../api/js/domwise/functions/observeSignal.md), [derivedSignal](../../api/js/domwise/functions/derivedSignal.md) — signal utilities.
- [Signal](../../api/js/domwise/interfaces/Signal.md), [Computed](../../api/js/domwise/interfaces/Computed.md), [SignalLike](../../api/js/domwise/interfaces/SignalLike.md) — signal types.
- [Fluent](fluent.md) — imperative DOM manipulation.
- [Frontend Framework Overview](readme.md) — the three client-side packages and how they fit together.