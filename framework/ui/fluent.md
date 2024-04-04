# Introduction to Fluent

Fluent is a core component of the "@serenity-is/corelib" library, designed to streamline DOM manipulation tasks and HTML construction within Serenity applications. It offers a familiar interface inspired by jQuery syntax, making it easy for developers to transition from jQuery while maintaining a lightweight and modern approach to DOM manipulation.

### Key Features:

- **Familiar jQuery Interface:** Fluent provides a syntax reminiscent of jQuery for performing common DOM manipulation tasks, allowing developers to leverage their existing knowledge while embracing a more modern paradigm.

- **Focused Functionality:** Designed to work with a single DOM element at a time, Fluent simplifies code and enhances performance by focusing on targeted element manipulation.

- **HTML Building:** With its fluent interface, Fluent allows for the dynamic creation of HTML elements and attributes, making it ideal for constructing UI components within Serenity applications.

- **Integration with Serenity Widgets:** Fluent seamlessly integrates with Serenity Widgets through the `.element` property, which previously returned a jQuery instance and now returns a Fluent instance for the root element of the widget. This enables developers to perform DOM manipulation and HTML construction directly on widget elements, enhancing the extensibility and customization of Serenity applications.

### Use Cases:

- **DOM Manipulation:** Fluent offers a comprehensive set of methods for manipulating classes, attributes, content, and events associated with DOM elements.

- **Event Handling:** Fluent provides intuitive methods for attaching event listeners, triggering events, and managing event delegation within Serenity applications. If jQuery is loaded on the page, Fluent seamlessly integrates with jQuery for event handling, ensuring compatibility with existing jQuery-based codebases. This behavior is similar to Bootstrap 5's jQuery integration, allowing developers to leverage jQuery functionality while utilizing Fluent's modern DOM manipulation capabilities.

- **HTML Construction:** Fluent's concise syntax enables the creation of HTML elements and their attributes programmatically, facilitating the dynamic generation of UI components.

### Creating a Fluent Instance

Fluent provides multiple ways to create a Fluent instance representing a single HTML element or DOM node. Below are the methods available for creating a Fluent instance:

**Fluent(tagOrElement: string | Element): Fluent<HTMLElement>:**  
  Creates a new Fluent instance with the specified HTML tag name or existing DOM element.

#### Using HTML Tag Name:

```typescript
// Create a Fluent instance representing a <div> element
const divElement = Fluent("div");
```

When providing a string parameter to the `Fluent` function, it interprets it as an HTML tag name and creates a new Fluent instance representing an element with that tag name. This is similar to jQuery's `$("<div/>")` syntax.

#### Using Existing DOM Element:

```typescript
// Create a Fluent instance representing an existing DOM element
const existingElement = document.getElementById("myElement");
const fluentElement = Fluent(existingElement);
```

Passing an existing DOM element to the `Fluent` function creates a new Fluent instance representing that element.

#### Note About Querying by Selector
Unlike jQuery, the Fluent constructor does not directly support querying elements in the document by a selector. For example, `Fluent("div.some-class")` will not work as it does for jQuery. 

Instead, you should either use `Fluent(document.querySelector("div.some-class"))` or `Fluent.findFirst('div.some-class')`, assuming there is only one `div` in the page with the class `some-class`." 

### Working with Serenity Widgets

Serenity classes that derive from the Widget base class provide additional properties for interacting with their root elements.

#### Creating a Fluent Instance for the Root Element

```typescript
class SomeWidget extends Widget<any> {
    //...

    someMethod() {
        // equivalent to Fluent(this.domNode)
        const myFluentElement = this.element;
        myFluentElement.addClass("something");
    }
}
```

This property (`element`) returns a Fluent instance for the root element of the widget, allowing for easy manipulation using the Fluent API.

### Class Manipulation

Fluent provides methods for manipulating the classes of elements, similar to jQuery's `addClass`, `removeClass`, and `toggleClass`

#### Setting the Class Attribute

```typescript
// Create a Fluent instance for a <div> element
const divElement = Fluent("div");

// Sets the class attribute of the element, overriding any other class
divElement.class("my-class");
```

Note that `.class` method overrides the class attribute, so it's typically used only when creating a new element.

#### Adding a Class

```typescript
// Create a Fluent instance for a <div> element
const divElement = Fluent("div");

// Add a class to the element
divElement.addClass("my-class");
```

#### Removing a Class

```typescript
// Remove a class from the element
divElement.removeClass("my-class");
```

#### Toggling a Class

```typescript
// Toggle a class on the element
divElement.toggleClass("active");
```

#### Conditional Class Addition

All class manipulation methods accepts the following types of values:

- a string
- an array of values where falsy values are filtered out
- an array of any combination of the above
- Note that false, true, null, undefined will be ignored, and everything else will be used. 

```typescript
// Conditionally add a class based on a boolean value
const condition = a < 0; // some conditional flag
element.addClass(condition && "active");
```

```typescript
// Ignore null, undefined, false, true
element.addClass(null); // Does nothing
element.addClass(undefined); // Does nothing
element.addClass(false); // Does nothing
element.addClass(true); // Does nothing
```

```typescript
// You can also conditionally include classes using arrays
element.addClass([condition && "hidden"]); // Adds "hidden" class if the condition is true
// Adds "hidden" if isHidden is true, "has-item" if the array has length > 0
element.addClass([isHidden && "hidden", array.length && "has-item" }]); 
```

### Attribute Manipulation

```typescript
attr(name: string): string;
attr(name: string, value: string | number | boolean | null | undefined): this;
```

This method sets or retrieves attributes on the element. 

If no value parameter is provided, it returns the value of the specified attribute. 

If value is provided, it sets the attribute to the given value and returns the Fluent instance for chaining. If the value is null, undefined, or false, the attribute will be removed. For strings and numbers, the attribute will be set as is using setAttribute. Otherwise, it will be set to "true". 

To set an attribute to `false`, the value parameter should be passed as `"false"` string.

```typescript
import { Fluent } from "@serenity-is/corelib";

// Get the value of the "href" attribute
const hrefValue = Fluent.findFirst("a").attr("href");

// Set the "title" attribute to "Serenity"
Fluent("div").attr("title", "Serenity");

// Remove the "disabled" attribute
Fluent.byId("myButton").attr("disabled", false);

// Set multiple attributes one by one
Fluent.findFirst("input#username")
    .attr("placeholder", "Enter your username")
    .attr("maxlength", 20)
    .attr("required", true);

// Remove the "disabled" attribute
Fluent.findFirst("input#box").attr("disabled", null);

// Set the "sample" attribute to "false" string
Fluent("div").attr("sample", "false");
```


### Data Attribute Manipulation

This method sets or retrieves the value of a data attribute on the underlying element. It's important to note that `Fluent`'s `data` method does not support rich data objects like jQuery does. Instead, it directly sets "data-" attributes.

```typescript
data(name: string): string;
data(name: string, value: string): Fluent;
```

Sets or retrieves the value of a data attribute on the underlying element.

- **Parameters:**
  - `name` (string): The name of the data attribute (without the "data-" prefix).
  - `value` (optional, string): The value to set for the data attribute.

#### Example

Setting a data attribute:

```typescript
const element = Fluent("div").data("key", "value");
```

Retrieving a data attribute:

```typescript
const value = element.data("key");
```

Got it! Let's document the `empty` method followed by the `text` method. 

Here's the documentation for the `empty` method:

### Element Content Manipulation

```typescript
empty(): Fluent;
```

The `empty` method removes all child nodes from the underlying element. This method also disposes any attached widgets if the element has children. Thus, it should be preferred over setting element's innerHTML/textContent directly.

#### Example

```typescript
const element = Fluent("div").empty();
```

The text method gets or sets the text content of the underlying element. If no `value` is provided, it returns the current text content. If a `value` is provided, it sets the text content after emptying any existing child nodes to dispose attached widgets.


```typescript
text(): string;
text(value: string): Fluent;
```


- **Parameters:**
  - `value?: string`: (Optional) The text content to set.

#### Example

```typescript
const element = Fluent("div").text("Hello, world!");
```
### Value Manipulation

```typescript
val(value?: string): Fluent | void;
```

The `val` method gets or sets the value of the underlying input, textarea, or select element. For input elements such as text inputs, checkboxes, and radio buttons, this method sets or gets the value of the input. For textarea elements, it sets or gets the text content. For select elements, it sets or gets the selected option's value.

- **Parameters:**
  - `value?: string`: (Optional) The value to set.

#### Example

```typescript
const input = Fluent("input").val("Hello, world!");
```

Please note that this method currently does not handle multi-select values properly.

### DOM Insertion Methods

These methods allow you to insert or append elements into the DOM tree at various positions relative to existing elements.

#### `append(child: string | Node | Fluent<any>): Fluent`

Appends the specified content as the last child of each element in the Fluent instance.

- **Parameters:**
  - `child: string | Node | Fluent<any>`: The content to append.
- **Returns:**
  - `Fluent`: The Fluent instance for method chaining.

#### `appendTo(parent: Element | Fluent<any>): Fluent`

Appends the Fluent instance's element as a child to the specified parent element.

- **Parameters:**
  - `parent: Element | Fluent<any>`: The parent element to append to.
- **Returns:**
  - `Fluent`: The Fluent instance for method chaining.

#### `insertAfter(referenceNode: HTMLElement | Fluent<HTMLElement>): Fluent`

Inserts the Fluent instance's element after the specified reference element.

- **Parameters:**
  - `referenceNode: HTMLElement | Fluent<HTMLElement>`: The reference element.
- **Returns:**
  - `Fluent`: The Fluent instance for method chaining.

#### `insertBefore(referenceNode: HTMLElement | Fluent<HTMLElement>): Fluent`

Inserts the Fluent instance's element before the specified reference element.

- **Parameters:**
  - `referenceNode: HTMLElement | Fluent<HTMLElement>`: The reference element.
- **Returns:**
  - `Fluent`: The Fluent instance for method chaining.

#### `after(content: string | Node | Fluent<any>): Fluent`

Inserts content immediately after each element in the Fluent instance.

- **Parameters:**
  - `content: string | Node | Fluent<any>`: The content to insert.
- **Returns:**
  - `Fluent`: The Fluent instance for method chaining.

#### `before(content: string | Node | Fluent<any>): Fluent`

Inserts content immediately before each element in the Fluent instance.

- **Parameters:**
  - `content: string | Node | Fluent<any>`: The content to insert.
- **Returns:**
  - `Fluent`: The Fluent instance for method chaining.

#### `prepend(child: string | Node | Fluent<any>): Fluent`

Inserts the specified content as the first child of each element in the Fluent instance.

- **Parameters:**
  - `child: string | Node | Fluent<any>`: The content to prepend.
- **Returns:**
  - `Fluent`: The Fluent instance for method chaining.

#### `prependTo(parent: Element | Fluent<any>): Fluent`

Prepends the Fluent instance's element as a child to the specified parent element.

- **Parameters:**
  - `parent: Element | Fluent<any>`: The parent element to prepend to.
- **Returns:**
  - `Fluent`: The Fluent instance for method chaining.

These methods provide flexibility in manipulating the DOM structure, allowing you to easily add or insert elements as needed. 

#### Example:

```typescript
// Create a Fluent instance for a div element with the class "container"
const container = Fluent("div").class("container");

// Create a Fluent instance for a paragraph element
const paragraph = Fluent("p").text("Hello, world!");

// Append the paragraph to the container
container.append(paragraph);

// Create a Fluent instance for a button element
const button = Fluent("button").text("Click me");

// Insert the button after the paragraph
button.insertAfter(paragraph);

// Create a Fluent instance for a link element
const link = Fluent("a").text("Learn more").attr("href", "https://example.com");

// Append the link to the container
container.append(link);

// Create a Fluent instance for a span element
const span = Fluent("span").text("This is a span element");

// Prepend the span before the paragraph
span.insertBefore(paragraph);

// Insert a new div element before the button
Fluent("div").class("alert").text("Important message").insertBefore(button);

// Append the container to the document body
container.appendTo(document.body);
```

In this example:

- We create a container div and append a paragraph, a button, and a link to it.
- We also prepend a span element before the paragraph.
- Additionally, we insert a new div element with an important message before the button.
- Finally, we append the container to the document body.

After the manipulations described in the previous example, the final HTML structure would look something like this:

```html
<body>
    <div class="container">
        <span>This is a span element</span>
        <p>Hello, world!</p>
        <a href="https://example.com">Learn more</a>
        <div class="alert">Important message</div>
        <button>Click me</button>
    </div>
</body>
```

We could also build this markup via Fluent chaining:

```typescript
Fluent("div").class("container")
    .append(Fluent("span").text("This is a span element"))
    .append(Fluent("p").text("Hello, world!"))
    .append(Fluent("a").attr("href", "https://example.com").text("Learn more"))
    .append(Fluent("div").class("alert").text("Important message"))
    .append(Fluent("button").text("Click me"))
    .appendTo(document.body);
```
### Selector Methods

#### children(selector?: string): HTMLElement[]

Returns an array of child elements that match the specified selector, or all children if no selector is provided.

```typescript
const children = Fluent("div.container").children();
```

#### closest(selector: string): Fluent<HTMLElement>

Returns the closest ancestor element that matches the specified selector.

```typescript
const closestElement = Fluent("button").closest(".container");
```

#### parent(): Fluent<HTMLElement>

Returns the parent element of the current element.

```typescript
const parentElement = Fluent("span").parent();
```

#### findAll(selector: string): HTMLElement[]

Returns an array of all descendant elements that match the specified selector.

```typescript
const foundElements = Fluent(document.querySelector("div.container")).findAll("span").forEach((x: HTMLElement) => {});
```

#### findEach(selector: string, callback: (el: Fluent) => void): Fluent

Executes a callback function for each descendant element that matches the specified selector. The element passed to the callback is a `Fluent` instance.

```typescript
Fluent.findFirst("div.container").findEach("span", (el) => {
    el.addClass('something');
});
```

#### findFirst(selector: string): Fluent<HTMLElement>

Returns the first descendant element that matches the specified selector.

```typescript
const firstElement = Fluent.findFirst("div.container").findFirst("span");
```

#### nextSibling(selector?: string): Fluent<any>

Returns the next sibling element that matches the specified selector, or the first sibling if no selector is provided.

```typescript
const nextSiblingElement = Fluent.findFirst("span").nextSibling("p");
```

#### prevSibling(selector?: string): Fluent<any>

Returns the previous sibling element that matches the specified selector, or the first sibling if no selector is provided.

```typescript
const prevSiblingElement = Fluent.findFirst("p").prevSibling("span");
```

### Static Selectors

To select elements in the document without having to create a Fluent instance first (e.g., `Fluent(document)`), you may use static Fluent methods:

#### `Fluent.byId(id)`

Finds the first element having the specified ID within the document.

- **Parameters:**
  - `id` (string): The ID selector to search for.
- **Returns:**
  - `Fluent | null`: A Fluent instance representing the first matching element, or null if no match is found.
```typescript
// Find the first element with ID "example"
const exampleElement = Fluent.byId('example');
if (exampleElement) {
    console.log(exampleElement.getNode());
}
```

#### `Fluent.findFirst(selector)`

Finds the first element matching the specified selector within the document.

- **Parameters:**
  - `selector` (string): The CSS selector to search for.
- **Returns:**
  - `Fluent | null`: A Fluent instance representing the first matching element, or null if no match is found.

#### `Fluent.findAll(selector)`

Finds all elements matching the specified selector within the document.

- **Parameters:**
  - `selector` (string): The CSS selector to search for.
- **Returns:**
  - `HTMLElement[]`: An array of HTML elements matching the selector.

#### `Fluent.findEach(selector, callback)`

Iterates over all elements matching the specified selector within the document.

- **Parameters:**
  - `selector` (string): The CSS selector to search for.
  - `callback` (Function): A function to execute for each matching element.

```typescript
// Find the first element with id "example"
const exampleElement = Fluent.byId('example');
if (exampleElement) {
    console.log(firstElement.getNode());
}

// Find the first element with class "example"
const firstElement = Fluent.findFirst('.example');
if (firstElement) {
    console.log(firstElement.getNode());
}
```

#### `Fluent.findAll(selector)`

Finds all elements matching the specified selector within the document.

```typescript
// Find all elements with class "item"
const allItems = Fluent.findAll('.item');
allItems.forEach(item => {
    console.log('Found item:', item);
});
```

#### `Fluent.findEach(selector, callback)`

Iterates over all elements matching the specified selector within the document.

```typescript
// Find each div with class "item" and add a click event listener via Fluent
Fluent.findEach('div.item', item => {
    item.on('click', () => {
        console.log('Clicked item:', item);
    });
});
```

These examples demonstrate how you can use the static methods to find elements, iterate over them, and perform actions based on the results.

### Event Handling

#### `on(eventType, listener, options)`

Attaches an event listener to the element.

```javascript
// Attach a click event listener to a button element
Fluent("button").on("click", () => {
    console.log("Button clicked");
});
```

#### `one(eventType, listener, options)`

Attaches an event listener to the element that will be automatically removed after being triggered once.

```javascript
// Attach a click event listener that triggers only once
Fluent("button").one("click", () => {
    console.log("Button clicked once");
});
```

#### `off(eventType, listener)`

Removes an event listener from the element.

```javascript
// Remove a specific click event listener from a button element
const clickHandler = () => {
    console.log("Button clicked");
};
Fluent("button").on("click", clickHandler);

// Later...
Fluent("button").off("click", clickHandler);
```

#### `trigger(eventType, eventData)`

Triggers an event of the specified type on the element.

```javascript
// Trigger a custom event on a button element
Fluent("button").trigger("customEvent", { detail: "Additional data" });
```

#### Event Delegation:

```typescript
// Event delegation example
// Attach a single click event listener to a parent element
// Handle clicks on child elements dynamically

Fluent.byId("parentElement").on("click", "li>a", event => {
    const target = Fluent(event.target).closest('a');
    
    if (target.matches(".childElement")) {
        // Do something specific for child elements
        console.log("Child element clicked");
    } else if (target.matches(".anotherChildElement")) {
        // Do something else for another child element
        console.log("Another child element clicked");
    }
});
```

This example demonstrates event delegation, where a single event listener is attached to a parent element to handle clicks on dynamically generated child elements. A single event listener is attached to the parent element but is only triggered for child elements that match the selector `li>a`.

When a click occurs, the event is captured at the parent level, and then specific actions are taken based on which child element was clicked. This approach minimizes the number of event listeners and enhances performance, especially in applications with many dynamically generated child elements.

### Static Event Handling Methods

Fluent also has static versions of event handling methods (on, one, off, trigger), requiring you to pass an element as the first argument:

```typescript
const element = document.querySelector("#sample");
Fluent.on(element, "click", (e) => {
    e.preventDefault();
});
```

### Fluent.isDefaultPrevented Static Method

If jQuery is available on the page, Fluent passes event handling methods to jQuery. This provides compatibility with jQuery's event system. Otherwise, event handlers attached via jQuery might not be triggered by dispatching native custom events, or vice versa:

[jQuery Issue 4815](https://github.com/jquery/jquery/issues/4815)

This is the reason we attach and trigger events via jQuery if it is loaded on the page. It is implemented by Bootstrap 5 in the same way.

While native event objects have a `defaultPrevented` property, jQuery has an `isDefaultPrevented()` method. This means you have to check both of them in event handlers if there is a possibility that your code might work in an environment with/without jQuery:

```typescript
Fluent.on(someElement, "click", e => {
    if (e.defaultPrevented || e.isDefaultPrevented?.()) {
        return;
    }

    // continue if default not prevented
});
```

Luckily, Fluent provides an `isDefaultPrevented` method that similarly handles both cases:

```typescript
Fluent.on(someElement, "click", e => {
    if (Fluent.isDefaultPrevented(e)) {
        return;
    }

    // continue if default not prevented
});
```

Another issue is jQuery does not pass any custom event properties/data to the received `Event` object. Such properties have to be accessed via the event's `originalEvent` property:

```typescript
Fluent.on(someElement, "someCustomEvent", e => {
    const someProp = (e as any).someProp ?? (e as any).originalEvent?.someProp;
});
```

Fluent provides an `eventProp` helper to work around such problems:

```typescript
Fluent.on(someElement, "someCustomEvent", e => {
    const someProp = Fluent.eventProp(e, "someProp");
});
```

It can read `someProp` from `e.someProp`, `e.originalEvent.someProp`, or `e.detail.someProp`, whichever is available first.

### Event Namespaces

Fluent, similar to jQuery, provides event namespaces and the ability to remove listeners attached via a namespace:

```typescript
Fluent.on(element, "click.test", someFunction1);
Fluent.on(element, "mousedown.test", someFunction2);
Fluent.on(element, "anotherevent.test", someFunction2);
// removes all three event listeners
Fluent.off(element, ".test");
```

Please note that namespace support is very basic. For instance, it supports only a single namespace, unlike jQuery, which supports multiple namespaces. Fluent's event mechanism is modeled after Bootstrap 5's jQuery event integration.

### Fluent.matches Method

The `matches` method in Fluent is an instance method that directly calls the underlying element's `matches` function. It is used to check if the element matches a specified CSS selector.

#### Syntax

```typescript
fluentInstance.matches(selector: string): boolean
```

- `selector`: A string representing the CSS selector to test the element against.

#### Return Value

A boolean value indicating whether the element matches the specified selector.

#### Example

```typescript
const element = document.getElementById("myElement");
const fluentInstance = Fluent(element);
if (fluentInstance.matches("div.some-class")) {
    console.log("Element matches the selector");
} else {
    console.log("Element does not match the selector");
}
```

### Fluent.style Method

The `style` method in Fluent is an instance method that accepts a callback function that receives a reference to the element's `style` property. It allows you to directly manipulate the inline CSS styles of the element.

#### Syntax

```typescript
fluentInstance.style(callback: (style: CSSStyleDeclaration) => void): void
```

- `callback`: A function that receives a reference to the `CSSStyleDeclaration` object representing the inline styles of the element.

#### Example

```typescript
const fluentInstance = Fluent("div");
fluentInstance.style(style => {
    style.backgroundColor = "red";
    style.color = "white";
});
```

This example sets the background color of the `div` element created by Fluent to red and the text color to white.

### Fluent.getNode Method

The `getNode` method in Fluent is an instance method used to access the underlying DOM element of the Fluent instance.

#### Syntax

```typescript
fluentInstance.getNode(): HTMLElement | null
```

#### Return Value

- An `HTMLElement` representing the underlying DOM element if it exists.
- `null` if the Fluent instance does not reference any element.

#### Example

```typescript
const fluentInstance = Fluent.byId("someID");
const element = fluentInstance.getNode();
if (element) {
    console.log("Found element:", element);
} else {
    console.log("No element found");
}
```

This example retrieves the underlying DOM element of a Fluent instance and logs it to the console if it exists.

### Fluent.ready Method

The `ready` method in Fluent is a static method used to execute a callback function when the DOM is fully loaded.

#### Syntax

```typescript
Fluent.ready(callback: () => void): void
```

- `callback`: A function to be executed when the DOM is fully loaded.

#### Example

```typescript
Fluent.ready(() => {
    console.log("DOM is ready");
    // Perform actions on the DOM
});
```

This example logs "DOM is ready" to the console when the DOM is fully loaded.

For code using ES modules (script type="module"), the ready event is generally not necessary, as the code execution waits for the DOM to be fully loaded before running. Therefore, using Fluent.ready in such cases is redundant.


### Other Static Utility Methods

#### Checking Visibility

```typescript
const isVisible = Fluent.isVisibleLike(element);
```

This method checks if the given element is considered visible, based on criteria such as offset dimensions or client rects. It works similarly to jQuery's `:visible` selector.

#### Checking Input Tags

```typescript
const isInputLike = Fluent.isInputLike(element);
```

This method checks if the given element is one of the input tags, e.g., input/textarea/select/button, which is similar to jQuery's `:input` selector.