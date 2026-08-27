# Components and Hooks

DomWise supports two kinds of JSX components — function components and class components — and provides a set of hooks for managing classes, prop bindings, and text nodes reactively. All of these are re-exported by `@serenity-is/corelib`, so application code can import them from either package.

## Function Components

A function component is a plain function that receives props and returns JSX:

```tsx
function Greeting(props: { name: string }) {
    return <div>Hello, {props.name}!</div>;
}

// usage
<Greeting name="World" />
```

Function components can use signals and hooks:

```tsx
import { signal } from "@serenity-is/corelib";

function Counter() {
    const count = signal(0);
    return (
        <div>
            <span>Count: {count}</span>
            <button onClick={() => count.value++}>Increment</button>
        </div>
    );
}
```

## Class Components

A class component extends `Component` and overrides `render()`:

```tsx
import { Component } from "@serenity-is/corelib";

class Greeting extends Component<{ name: string }> {
    render() {
        return <div>Hello, {this.props.name}!</div>;
    }
}

// usage
<Greeting name="World" />
```

Props (including `children` and `ref`) are available via `this.props`. The JSX factory detects class components through the static `isComponent` marker and forwards `ref` to the component instance.

## Hooks

### useClassList

`useClassList` creates a `classList`-like manager that can be bound to the `class` attribute. It mirrors the native `DOMTokenList` API (`add`, `remove`, `toggle`, `contains`, `value`, `size`):

```tsx
import { useClassList } from "@serenity-is/corelib";

const cls = useClassList("foo");
cls.add("bar");

return <div class={cls} />;
```

The binding is cleaned up automatically when the element is disposed.

### usePropBinding

`usePropBinding` creates a two-way binding that synchronizes a value to a single element attribute:

```tsx
import { usePropBinding } from "@serenity-is/corelib";

const value = usePropBinding("hello");

return (
    <>
        <input value={value} />
        <button onClick={() => value("world")}>Set</button>
    </>
);
```

A binding may only be attached to one element and one attribute; reusing it elsewhere throws.

### useText

`useText` creates a `Text` node and a setter to update its content. The node can be interpolated directly as a JSX child:

```tsx
import { useText } from "@serenity-is/corelib";

const [label, setLabel] = useText("hello");

return (
    <>
        <span>{label}</span>
        <button onClick={() => setLabel("world")}>Update</button>
    </>
);
```

### useRef

`useRef` is an alias for `createRef`:

```tsx
import { useRef } from "@serenity-is/corelib";

const inputRef = useRef<HTMLInputElement>();
return <input ref={inputRef} />;
```

### useSignal and useUpdatableComputed

`useSignal` is an alias for `signal`, and `useUpdatableComputed` creates computed signals that are only recalculated when you call `update()`. See [Signals and Reactivity](signals.md).

### useImperativeHandle

`useImperativeHandle` forwards the result of an `init()` function to a ref (a React-compatibility helper):

```tsx
import { useImperativeHandle } from "@serenity-is/corelib";

useImperativeHandle(ref, () => ({ focus: () => inputRef.current?.focus() }));
```

## Conditional Rendering

The domwise source defines a `Show` component for declarative conditional rendering (similar to Solid's `<Show>`), but it is not currently exported from the `@serenity-is/domwise` package entry, so it is not yet available to template users. For conditional rendering, use signals and JSX directly:

```tsx
const loggedIn = signal(false);

{loggedIn.value ? <Dashboard /> : <Login />}
```

## Components or Widgets?

Components and widgets serve different purposes:

- **Components** are lightweight and ideal for presentational UI that composes with signals. They render once into real DOM nodes and have no lifecycle management of their own.
- **Widgets** (from `@serenity-is/corelib`) manage a full lifecycle (`init` / `destroy`), associate themselves with a DOM node, and are used for editors, grids, dialogs, and other framework-integrated pieces. They are the building blocks of Serenity pages and forms.

As a rule of thumb, use **components** for self-contained UI fragments and **widgets** when you need framework integration (type registration, PropertyGrid editors, grid/dialog behavior, or lifecycle management).

## See Also

- [Component](../../api/js/domwise/classes/Component.md) — the class component base.
- [useClassList](../../api/js/domwise/functions/useClassList.md), [usePropBinding](../../api/js/domwise/functions/usePropBinding.md), [useText](../../api/js/domwise/functions/useText.md) — DOM hooks.
- [useImperativeHandle](../../api/js/domwise/functions/useImperativeHandle.md) — ref forwarding helper.
- [useSignal](../../api/js/domwise/functions/useSignal.md), [useUpdatableComputed](../../api/js/domwise/functions/useUpdatableComputed.md) — signal hooks.
- [createRef](../../api/js/domwise/functions/createRef.md) — the ref factory behind `useRef`.
- [JSX with DomWise](jsx.md) — JSX syntax, elements, attributes, events, refs.
- [Signals and Reactivity](signals.md) — reactive state and bindings.
- [Widgets](../../widgets/README.md) — the widget system.
- [Frontend Framework Overview](readme.md) — the three client-side packages and how they fit together.