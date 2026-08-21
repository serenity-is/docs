[@serenity-is/corelib](../README.md) / Fluent

# Interface: Fluent\<TElement\>

Defined in: [src/base/fluent.ts:491](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L491)

Represents a Fluent object, which is similar to jQuery but works for only one element.
It implements the `ArrayLike` interface and can have 0 (null) or 1 element.

## Extends

- `ArrayLike`\<`TElement`\>

## Type Parameters

### TElement

`TElement` *extends* `HTMLElement` = `HTMLElement`

## Indexable

\[`n`: `number`\]: `TElement`

Gets the element at the specified index.

## Properties

### \[iterator\]

> **\[iterator\]**: `TElement`[]

Defined in: [src/base/fluent.ts:236](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L236)

Gets an iterator for the elements in the Fluent object.

#### Returns

An iterator for the elements in the Fluent object.

***

### length

> `readonly` **length**: `number`

Defined in: [src/base/fluent.ts:249](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L249)

Gets the number of elements in the Fluent object. Can only be 1 or 0.

#### Overrides

`ArrayLike.length`

## Methods

### addClass()

> **addClass**(`value`): `this`

Defined in: [src/base/fluent.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L17)

Adds one or more classes to the element. Any falsy value is ignored.

#### Parameters

##### value

The class or classes to add. It can be a string, boolean, or an array of strings or booleans.

`string` | `boolean` | (`string` \| `boolean`)[]

#### Returns

`this`

The Fluent object itself.

***

### after()

> **after**(`content`): `this`

Defined in: [src/base/fluent.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L33)

Inserts content after the element.

#### Parameters

##### content

The content to insert. It can be a string, a Node object, or another Fluent object.

`string` | `Node` | `Fluent`\<`any`\>

#### Returns

`this`

The Fluent object itself.

***

### append()

> **append**(`child`): `this`

Defined in: [src/base/fluent.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L25)

Appends content to the element.

#### Parameters

##### child

The content to append. It can be a string, a Node object, or another Fluent object.

`string` | `Node` | `Fluent`\<`any`\>

#### Returns

`this`

The Fluent object itself.

***

### appendTo()

> **appendTo**(`parent`): `this`

Defined in: [src/base/fluent.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L41)

Appends the element to the specified parent element.

#### Parameters

##### parent

The parent element to append to. It can be an Element object or another Fluent object.

`Element` | `Fluent`\<`any`\>

#### Returns

`this`

The Fluent object itself.

***

### attr()

#### Call Signature

> **attr**(`name`): `string`

Defined in: [src/base/fluent.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L49)

Gets the value of the specified attribute.

##### Parameters

###### name

`string`

The name of the attribute.

##### Returns

`string`

The value of the attribute.

#### Call Signature

> **attr**(`name`, `value`): `this`

Defined in: [src/base/fluent.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L58)

Sets the value of the specified attribute.

##### Parameters

###### name

`string`

The name of the attribute.

###### value

The value of the attribute. If the value is falsy the attribute is removed.

`string` | `number` | `boolean`

##### Returns

`this`

The Fluent object itself if a value is provided.

***

### before()

> **before**(`content`): `this`

Defined in: [src/base/fluent.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L66)

Inserts content before the element.

#### Parameters

##### content

The content to insert. It can be a string, a Node object, or another Fluent object.

`string` | `Node` | `Fluent`\<`any`\>

#### Returns

`this`

The Fluent object itself.

***

### children()

> **children**\<`TElement`\>(`selector?`): `TElement`[]

Defined in: [src/base/fluent.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L74)

Gets the children of the element as an array (not Fluent)

#### Type Parameters

##### TElement

`TElement` *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### selector?

`string`

Optional. A CSS selector to filter the children.

#### Returns

`TElement`[]

An array of HTMLElement objects representing the children.

***

### class()

> **class**(`value`): `this`

Defined in: [src/base/fluent.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L82)

Sets (overrides) the class attribute of the element. Any falsy value is ignored.

#### Parameters

##### value

The class or classes to add. It can be a string, boolean, or an array of strings or booleans.

`string` | `boolean` | (`string` \| `boolean`)[]

#### Returns

`this`

The Fluent object itself.

***

### click()

#### Call Signature

> **click**(): `this`

Defined in: [src/base/fluent.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L89)

Triggers a click event on the element.

##### Returns

`this`

The Fluent object itself.

#### Call Signature

> **click**(`listener`): `this`

Defined in: [src/base/fluent.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L96)

Adds a click event listener on the element.

##### Parameters

###### listener

(`e`) => `void`

A callback function to execute when the click event is triggered.

##### Returns

`this`

The Fluent object itself.

***

### closest()

> **closest**\<`TElement`\>(`selector`): `Fluent`\<`TElement`\>

Defined in: [src/base/fluent.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L104)

Gets the closest ancestor of the element that matches the specified selector.

#### Type Parameters

##### TElement

`TElement` *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### selector

`string`

A CSS selector to match against.

#### Returns

`Fluent`\<`TElement`\>

A Fluent object representing the closest ancestor element.

***

### data()

#### Call Signature

> **data**(`name`): `string`

Defined in: [src/base/fluent.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L112)

Gets the value of the specified `data-*` attribute.

##### Parameters

###### name

`string`

Name of the data attribute without the `data-` prefix.

##### Returns

`string`

The attribute value, or `null`/`undefined` when not present.

#### Call Signature

> **data**(`name`, `value`): `this`

Defined in: [src/base/fluent.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L120)

Sets the value of the specified `data-*` attribute.

##### Parameters

###### name

`string`

Name of the data attribute without the `data-` prefix.

###### value

`string`

Value to set; `null`/`undefined` removes the attribute via [Fluent.attr](#attr).

##### Returns

`this`

The Fluent object itself.

***

### each()

> **each**(`callback`): `this`

Defined in: [src/base/fluent.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L128)

Executes a callback function for the element in the Fluent object if it is not null.

#### Parameters

##### callback

(`el`) => `void`

The callback function to execute for each element.

#### Returns

`this`

The Fluent object itself.

***

### empty()

> **empty**(): `this`

Defined in: [src/base/fluent.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L142)

Removes all child nodes from the element. It also clears event handlers attached via Fluent, and disposes any attached widgets.

#### Returns

`this`

The Fluent object itself.

***

### findAll()

> **findAll**\<`TElement`\>(`selector`): `TElement`[]

Defined in: [src/base/fluent.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L150)

Finds all elements that match the specified selector within the element.

#### Type Parameters

##### TElement

`TElement` *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### selector

`string`

A CSS selector to match against.

#### Returns

`TElement`[]

An array of elements that match the selector.

***

### findEach()

> **findEach**\<`TElement`\>(`selector`, `callback`): `this`

Defined in: [src/base/fluent.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L159)

Finds each element that matches the specified selector within the element and executes a callback function for each found element as a Fluent object.

#### Type Parameters

##### TElement

`TElement` *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### selector

`string`

A CSS selector to match against.

##### callback

(`el`, `index`) => `void`

The callback function to execute for each found element. It receives a Fluent object for each element.

#### Returns

`this`

The Fluent object itself.

***

### findFirst()

> **findFirst**\<`TElement`\>(`selector`): `Fluent`\<`TElement`\>

Defined in: [src/base/fluent.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L167)

Finds the first element that matches the specified selector within the element.

#### Type Parameters

##### TElement

`TElement` *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### selector

`string`

A CSS selector to match against.

#### Returns

`Fluent`\<`TElement`\>

A Fluent object representing the first element that matches the selector.

***

### focus()

> **focus**(): `this`

Defined in: [src/base/fluent.ts:174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L174)

Sets focus on the element.

#### Returns

`this`

The Fluent object itself.

***

### getNode()

> **getNode**(): `TElement`

Defined in: [src/base/fluent.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L135)

Gets the underlying HTML element.

#### Returns

`TElement`

The underlying HTML element.

***

### getWidget()

> **getWidget**\<`TWidget`\>(`type?`): `TWidget`

Defined in: [src/base/fluent.ts:213](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L213)

Gets the widget associated with the element.

#### Type Parameters

##### TWidget

`TWidget`

#### Parameters

##### type?

(...`args`) => `TWidget`

Optional. The constructor function of the widget.

#### Returns

`TWidget`

The widget associated with the element.

***

### hasClass()

> **hasClass**(`klass`): `boolean`

Defined in: [src/base/fluent.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L182)

Checks if the element has the specified class.

#### Parameters

##### klass

`string`

The class to check for.

#### Returns

`boolean`

`true` if the element has the class, `false` otherwise.

***

### hidden()

#### Call Signature

> **hidden**(`name`): `boolean`

Defined in: [src/base/fluent.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L190)

Gets whether the element is hidden (`hidden` property).

##### Parameters

###### name

`string`

Reserved attribute name parameter for compatibility; not used for the `hidden` property check.

##### Returns

`boolean`

`true` if the element is hidden, otherwise `false`.

#### Call Signature

> **hidden**(`value`): `this`

Defined in: [src/base/fluent.ts:198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L198)

Sets whether the element is hidden.

##### Parameters

###### value

`boolean`

When `true` sets `element.hidden = true`, otherwise `false`.

##### Returns

`this`

The Fluent object itself.

***

### hide()

> **hide**(): `this`

Defined in: [src/base/fluent.ts:205](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L205)

Hides the element by setting its hidden property to true.

#### Returns

`this`

The Fluent object itself.

***

### insertAfter()

> **insertAfter**(`referenceNode`): `this`

Defined in: [src/base/fluent.ts:221](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L221)

Inserts the element after the specified reference element.

#### Parameters

##### referenceNode

The reference element to insert after. It can be an HTMLElement object or another Fluent object.

`HTMLElement` | `Fluent`\<`HTMLElement`\>

#### Returns

`this`

The Fluent object itself.

***

### insertBefore()

> **insertBefore**(`referenceNode`): `this`

Defined in: [src/base/fluent.ts:229](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L229)

Inserts the element before the specified reference element.

#### Parameters

##### referenceNode

The reference element to insert before. It can be an HTMLElement object or another Fluent object.

`HTMLElement` | `Fluent`\<`HTMLElement`\>

#### Returns

`this`

The Fluent object itself.

***

### matches()

> **matches**(`selector`): `boolean`

Defined in: [src/base/fluent.ts:342](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L342)

Checks if the element matches the specified selector.

#### Parameters

##### selector

`string`

A CSS selector to match against.

#### Returns

`boolean`

`true` if the element matches the selector, `false` otherwise.

***

### nextSibling()

> **nextSibling**(`selector?`): `Fluent`\<`any`\>

Defined in: [src/base/fluent.ts:350](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L350)

Gets the next sibling element that matches the specified selector, or the first sibling if no selector is provided..

#### Parameters

##### selector?

`string`

Optional. A CSS selector to filter the next sibling.

#### Returns

`Fluent`\<`any`\>

A Fluent object representing the next sibling element.

***

### off()

#### Call Signature

> **off**\<`K`\>(`type`, `listener`): `this`

Defined in: [src/base/fluent.ts:258](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L258)

Removes an event listener from the element.

##### Type Parameters

###### K

`K` *extends* keyof `HTMLElementEventMap`

##### Parameters

###### type

`K`

Event type, may include a `.namespace` suffix (e.g. `"click.myNs"`).

###### listener

(`this`, `ev`) => `any`

Event listener to remove.

##### Returns

`this`

The Fluent object itself.

#### Call Signature

> **off**(`type`): `this`

Defined in: [src/base/fluent.ts:265](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L265)

Removes event listener(s) for the given type / namespace.

##### Parameters

###### type

`string`

Event type or `.namespace`; when only a namespace is handled all matching listeners are removed.

##### Returns

`this`

The Fluent object itself.

#### Call Signature

> **off**(`type`, `listener`): `this`

Defined in: [src/base/fluent.ts:273](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L273)

Removes an event listener from the element.

##### Parameters

###### type

`string`

Event type, may include a `.namespace`.

###### listener

`EventListener`

Event listener to remove.

##### Returns

`this`

The Fluent object itself.

#### Call Signature

> **off**(`type`, `selector`, `delegationHandler`): `this`

Defined in: [src/base/fluent.ts:282](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L282)

Removes a delegated event listener.

##### Parameters

###### type

`string`

Event type, may include a `.namespace`.

###### selector

`string`

Delegation selector used when the listener was added.

###### delegationHandler

`Function`

Delegated handler to remove.

##### Returns

`this`

The Fluent object itself.

***

### on()

#### Call Signature

> **on**\<`K`\>(`type`, `listener`): `this`

Defined in: [src/base/fluent.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L291)

Adds an event listener to the element. Supports namespaced and delegated events via the shared `fluent-events` module.

##### Type Parameters

###### K

`K` *extends* keyof `HTMLElementEventMap`

##### Parameters

###### type

`K`

Event type, may include a `.namespace` suffix.

###### listener

(`this`, `ev`) => `any`

Event listener to add.

##### Returns

`this`

The Fluent object itself.

#### Call Signature

> **on**(`type`, `listener`): `this`

Defined in: [src/base/fluent.ts:299](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L299)

Adds an event listener to the element.

##### Parameters

###### type

`string`

Event type, may include a `.namespace`.

###### listener

`EventListener`

Event listener to add.

##### Returns

`this`

The Fluent object itself.

#### Call Signature

> **on**(`type`, `selector`, `delegationHandler`): `this`

Defined in: [src/base/fluent.ts:308](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L308)

Adds a delegated event listener to the element.

##### Parameters

###### type

`string`

Event type, may include a `.namespace`.

###### selector

`string`

CSS selector to delegate to.

###### delegationHandler

`Function`

Handler invoked when the delegated target matches.

##### Returns

`this`

The Fluent object itself.

***

### one()

#### Call Signature

> **one**\<`K`\>(`type`, `listener`): `this`

Defined in: [src/base/fluent.ts:317](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L317)

Adds a one-time event listener that is automatically removed after the first invocation.

##### Type Parameters

###### K

`K` *extends* keyof `HTMLElementEventMap`

##### Parameters

###### type

`K`

Event type, may include a `.namespace` suffix.

###### listener

(`this`, `ev`) => `any`

Event listener to add.

##### Returns

`this`

The Fluent object itself.

#### Call Signature

> **one**(`type`, `listener`): `this`

Defined in: [src/base/fluent.ts:325](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L325)

Adds a one-time event listener to the element.

##### Parameters

###### type

`string`

Event type, may include a `.namespace`.

###### listener

`EventListener`

Event listener to add.

##### Returns

`this`

The Fluent object itself.

#### Call Signature

> **one**(`type`, `selector`, `delegationHandler`): `this`

Defined in: [src/base/fluent.ts:334](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L334)

Adds a one-time delegated event listener to the element.

##### Parameters

###### type

`string`

Event type, may include a `.namespace`.

###### selector

`string`

CSS selector to delegate to.

###### delegationHandler

`Function`

Handler invoked once when the delegated target matches.

##### Returns

`this`

The Fluent object itself.

***

### parent()

> **parent**\<`TElement`\>(): `Fluent`\<`TElement`\>

Defined in: [src/base/fluent.ts:357](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L357)

Gets the parent element of the element.

#### Type Parameters

##### TElement

`TElement` *extends* `HTMLElement` = `HTMLElement`

#### Returns

`Fluent`\<`TElement`\>

A Fluent object representing the parent element.

***

### prepend()

> **prepend**(`child`): `this`

Defined in: [src/base/fluent.ts:365](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L365)

Prepends content to the element.

#### Parameters

##### child

The content to prepend. It can be a string, a Node object, or another Fluent object.

`string` | `Node` | `Fluent`\<`any`\>

#### Returns

`this`

The Fluent object itself.

***

### prependTo()

> **prependTo**(`parent`): `this`

Defined in: [src/base/fluent.ts:373](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L373)

Prepends the element to the specified parent element.

#### Parameters

##### parent

The parent element to prepend to. It can be an Element object or another Fluent object.

`Element` | `Fluent`\<`any`\>

#### Returns

`this`

The Fluent object itself.

***

### prevSibling()

> **prevSibling**(`selector?`): `Fluent`\<`any`\>

Defined in: [src/base/fluent.ts:381](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L381)

Gets the previous sibling element that matches the specified selector, or the first sibling if no selector is provided.

#### Parameters

##### selector?

`string`

Optional. A CSS selector to filter the previous sibling.

#### Returns

`Fluent`\<`any`\>

A Fluent object representing the previous sibling element.

***

### remove()

> **remove**(): `this`

Defined in: [src/base/fluent.ts:388](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L388)

Removes the element from the DOM. It also removes event handlers and disposes widgets by calling "disposing" event handlers.

#### Returns

`this`

The Fluent object itself.

***

### removeAttr()

> **removeAttr**(`name`): `this`

Defined in: [src/base/fluent.ts:396](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L396)

Removes the specified attribute from the element.

#### Parameters

##### name

`string`

The name of the attribute to remove.

#### Returns

`this`

The Fluent object itself.

***

### removeClass()

> **removeClass**(`value`): `this`

Defined in: [src/base/fluent.ts:404](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L404)

Removes one or more classes from the element. Any falsy value is ignored.

#### Parameters

##### value

The class or classes to remove. It can be a string, boolean, or an array of strings or booleans.

`string` | `boolean` | (`string` \| `boolean`)[]

#### Returns

`this`

The Fluent object itself.

***

### show()

> **show**(): `this`

Defined in: [src/base/fluent.ts:411](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L411)

Shows the element by setting its hidden property to false.

#### Returns

`this`

The Fluent object itself.

***

### style()

> **style**(`callback`): `this`

Defined in: [src/base/fluent.ts:419](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L419)

Executes a callback function to modify the inline style of the element.

#### Parameters

##### callback

(`css`) => `void`

The callback function to modify the inline style.

#### Returns

`this`

The Fluent object itself.

***

### text()

#### Call Signature

> **text**(): `string`

Defined in: [src/base/fluent.ts:426](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L426)

Gets the text content of the element.

##### Returns

`string`

The current `textContent` of the element.

#### Call Signature

> **text**(`value`): `this`

Defined in: [src/base/fluent.ts:433](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L433)

Sets the text content of the element.

##### Parameters

###### value

`string`

Text to set as `textContent`.

##### Returns

`this`

The Fluent object itself.

***

### toggle()

> **toggle**(`flag?`): `this`

Defined in: [src/base/fluent.ts:441](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L441)

Toggles the visibility of the element.

#### Parameters

##### flag?

`boolean`

Optional. A flag indicating whether to show or hide the element. If not provided, the visibility will be toggled.

#### Returns

`this`

The Fluent object itself.

***

### toggleClass()

> **toggleClass**(`value`, `add?`): `this`

Defined in: [src/base/fluent.ts:450](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L450)

Toggles one or more classes on the element. If the class exists, it is removed; otherwise, it is added.

#### Parameters

##### value

Class or classes to toggle. Strings are split on whitespace; arrays are flattened; falsy entries are ignored.

`string` | `boolean` | (`string` \| `boolean`)[]

##### add?

`boolean`

When `true` forces addition, when `false` forces removal, when omitted toggles.

#### Returns

`this`

The Fluent object itself.

***

### trigger()

> **trigger**(`type`, `args?`): `this`

Defined in: [src/base/fluent.ts:459](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L459)

Triggers a specified event on the element.

#### Parameters

##### type

`string`

The type of the event to trigger.

##### args?

`any`

Optional. An object that specifies event-specific initialization properties.

#### Returns

`this`

The Fluent object itself.

***

### tryGetWidget()

> **tryGetWidget**\<`TWidget`\>(`type?`): `TWidget`

Defined in: [src/base/fluent.ts:467](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L467)

Tries to get the widget associated with the element.

#### Type Parameters

##### TWidget

`TWidget`

#### Parameters

##### type?

(...`args`) => `TWidget`

Optional. The constructor function of the widget.

#### Returns

`TWidget`

The widget associated with the element, or `null` if no widget is found.

***

### val()

#### Call Signature

> **val**(`value`): `this`

Defined in: [src/base/fluent.ts:475](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L475)

Sets the value of the element (input / select / textarea).

##### Parameters

###### value

`string`

Value to set.

##### Returns

`this`

The Fluent object itself.

#### Call Signature

> **val**(): `string`

Defined in: [src/base/fluent.ts:481](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L481)

Gets the value of the element (input / select / textarea).

##### Returns

`string`

The current value of the element.
