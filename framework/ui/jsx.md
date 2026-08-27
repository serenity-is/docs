# JSX with DomWise

DomWise is the JSX runtime used by Serenity. It compiles JSX directly into real DOM nodes — there is no virtual DOM, no diffing, and no reconciliation. This is a deliberate design choice: Serenity widgets manipulate the DOM imperatively (they append, remove, and modify nodes directly), and a virtual DOM would fight those changes.

JSX is the recommended way to build DOM in Serenity. Use it in `.tsx` files; in plain `.ts` files you can still call the JSX factory functions (`jsx` / `jsxs`) directly.

## Configuration

Set the JSX import source in your `tsconfig.json` so the compiler uses DomWise's runtime:

```json
{
  "compilerOptions": {
    "jsx": "react-jsx",
    "jsxImportSource": "@serenity-is/domwise"
  }
}
```

Serene/StartSharp projects already configure this for you.

## Creating Elements

JSX tags compile to real DOM elements:

```tsx
<div>Hello</div>
<span class="label">Name:</span>
<input type="text" value="default" />

// Self-closing
<br />
<hr />
<img src="photo.jpg" />
```

The automatic runtime uses the `jsx` / `jsxs` factory functions, where children are passed through `props.children`. A classic `createElement` / `h` API is also available for non-automatic JSX:

```ts
import { createElement } from "@serenity-is/domwise";

const node = createElement("div", { class: "foo" }, "Hello");
```

## Attributes

### class

The `class` attribute (also `className`) accepts a string, an object of boolean flags, an array, or a signal:

```tsx
<div class="greeting" />
<div class={{ hidden: isHidden, active: true }} />
<div class={[condition && "active", "base"]} />
```

### style

The `style` attribute accepts a string, an object (camelCase properties), an array, or a signal:

```tsx
<div style="color: red;" />
<div style={{ color: "red", fontSize: "14px", opacity: 0.5 }} />
<div style={{ "--my-color": "blue" }} />
```

### dataset

The `dataset` attribute sets `data-*` attributes in bulk:

```tsx
<div dataset={{ user: "guest", theme: "dark" }} />
// <div data-user="guest" data-theme="dark">
```

### Special Attributes

| Attribute | Description |
|-----------|-------------|
| `ref` | Captures the DOM node or component instance |
| `namespaceURI` | Specifies the XML namespace for the element |
| `dangerouslySetInnerHTML` | Sets `innerHTML` from `{ __html: string }` |
| `textContent` | Sets `textContent` directly |
| `innerText` | Alias for `textContent` |
| `value` | Sets `value` on `<input>`, `<textarea>`, `<select>` (with multi-select array support) |
| `dataset` | Sets `dataset` properties in bulk |
| `on` / `onCapture` | Bulk event registration via object maps |

### Attribute Name Mapping

React-style attribute names are mapped to their HTML equivalents: `className` → `class`, `htmlFor` → `for`, `tabIndex` → `tabindex`, `readOnly` → `readonly`, `maxLength` → `maxlength`, and so on. Lowercased HTML attributes (e.g. `tabindex`, `readonly`, `for`) also work directly, making it easy to paste Bootstrap and other HTML snippets.

## Events

Event listeners are attached directly as DOM properties. Standard events use lowercase names; custom events preserve their original casing:

```tsx
<button onClick={e => handleClick(e)}>Click me</button>
<input onChange={e => validate(e.target.value)} />
<div onMouseOver={e => highlight(e)} />

// Custom events
<my-element onMyCustomEvent={e => console.log(e.detail)} />

// Capture phase
<button onClickCapture={e => handleCapture(e)} />

// Bulk registration
<div on={{ click: handleClick, contextmenu: handleContextMenu }} />
```

## Children

Children can be strings, numbers, DOM nodes, arrays, or signals. `false`, `null`, `undefined`, and `true` are ignored:

```tsx
<div>Hello World</div>
<div>Score: {42}</div>
<div>{["Total: ", 20]}</div>
<div>{document.querySelectorAll("span")}</div>
```

Signal children create reactive text nodes that update in place (see [Signals and Reactivity](signals.md)).

## Refs

Refs provide access to the underlying DOM node after creation. Use `createRef` for a ref object, or pass a callback:

```tsx
import { createRef } from "@serenity-is/domwise";

const inputRef = createRef<HTMLInputElement>();
render(<input ref={inputRef} />);
inputRef.current?.focus();

// Callback ref
<input ref={node => node?.focus()} />
```

Refs also work with class components — they receive the component instance rather than a DOM node.

## Fragments

Use fragments to group children without an extra wrapper element:

```tsx
<>
  <span>before</span>
  <span>after</span>
</>
```

## Components

JSX can invoke function components and class components. A function component is a plain function that returns JSX; a class component extends `Component` and implements `render()`. See the Components and Hooks page for details.

## SVG and MathML

SVG and MathML tags are detected automatically and created in the correct namespace:

```tsx
<svg viewBox="0 0 100 100">
  <circle cx="50" cy="50" r="40" />
</svg>
```

You can also scope a subtree to a namespace with `inSVGNamespace`, `inMathMLNamespace`, or `inHTMLNamespace`.

## Shadow DOM

`ShadowRootNode` lets you attach a shadow root and render children inside it:

```tsx
import { ShadowRootNode } from "@serenity-is/domwise";

<div>
  <ShadowRootNode>
    <span>inside shadow root</span>
  </ShadowRootNode>
</div>
```

## A Real Example

The StartSharp dashboard's orders card (`Modules/Common/Dashboard/orders/orders-card.tsx`) shows a typical function component using JSX, `class`, `style`, and callback refs:

```tsx
export function OrdersCard({ }) {
    var byQuarterChart: Chart<"line">;
    return (
        <div class="card s-dashboard-card s-order-charts">
            <div class="card-body">
                <ul class="nav nav-tabs" role="tablist" ref={el => Fluent(el).on("shown.bs.tab", "a", function () {
                    byQuarterChart?.update();
                    byTypeChart?.update();
                })}>
                    <li class="header"><h3 class="card-title">Orders</h3></li>
                    <li class="nav-item ms-auto"><a class="nav-link active" href="#orders-by-quarter-pane" data-bs-toggle="tab">By Quarter</a></li>
                    <li class="nav-item"><a class="nav-link" href="#orders-by-type-pane" data-bs-toggle="tab">By Type</a></li>
                </ul>
                <div class="tab-content no-padding">
                    <div class="tab-pane fade show active" id="orders-by-quarter-pane">
                        <canvas style={{height: "280px"}} ref={canvas => setTimeout(() => {
                            byQuarterChart = ordersByQuarterChart(canvas)
                        }, 0)} />
                    </div>
                    <div class="tab-pane fade" id="orders-by-type-pane">
                        <canvas style={{height: "280px", width: "300px", margin: "0 auto"}} ref={canvas => setTimeout(() => {
                            byTypeChart = ordersByTypeChart(canvas)
                        }, 0)} />
                    </div>
                </div>
            </div>
        </div>
    )
}
```

## Using JSX in Non-TSX Files

In plain `.ts` files (where JSX syntax is not available), you can still build DOM with the JSX factory functions:

```ts
import { jsx } from "@serenity-is/domwise";

const node = jsx("div", { class: "foo", children: "Hello" });
```

## See Also

- [jsx](../../api/js/domwise/functions/jsx.md), [createElement](../../api/js/domwise/functions/createElement.md) — element creation functions.
- [createRef](../../api/js/domwise/functions/createRef.md), [setRef](../../api/js/domwise/functions/setRef.md) — refs.
- [Fragment](../../api/js/domwise/functions/Fragment.md), [ShadowRootNode](../../api/js/domwise/functions/ShadowRootNode.md) — fragments and shadow DOM.
- [Component](../../api/js/domwise/classes/Component.md) — the class component base.
- [JSX namespace](../../api/js/domwise/@serenity-is/namespaces/JSX/README.md) — JSX types (`IntrinsicElements`, etc.).
- [Signals and Reactivity](signals.md) — reactive bindings in JSX.
- [Fluent](fluent.md) — imperative DOM manipulation.
- [Frontend Framework Overview](readme.md) — the three client-side packages and how they fit together.