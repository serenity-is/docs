[@serenity-is/corelib](../README.md) / Fluent

# Interface: Fluent\<TElement\>

Defined in: [src/base/fluent.ts:416](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L416)

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

Defined in: [src/base/fluent.ts:229](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L229)

Gets an iterator for the elements in the Fluent object.

#### Returns

An iterator for the elements in the Fluent object.

***

### length

> `readonly` **length**: `number`

Defined in: [src/base/fluent.ts:242](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L242)

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

Gets or sets the value of the specified data attribute.

##### Parameters

###### name

`string`

The name of the data attribute.

##### Returns

`string`

The value of the data attribute if no value is provided, or the Fluent object itself if a value is provided.

#### Call Signature

> **data**(`name`, `value`): `this`

Defined in: [src/base/fluent.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L113)

##### Parameters

###### name

`string`

###### value

`string`

##### Returns

`this`

***

### each()

> **each**(`callback`): `this`

Defined in: [src/base/fluent.ts:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L121)

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

Defined in: [src/base/fluent.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L135)

Removes all child nodes from the element. It also clears event handlers attached via Fluent, and disposes any attached widgets.

#### Returns

`this`

The Fluent object itself.

***

### findAll()

> **findAll**\<`TElement`\>(`selector`): `TElement`[]

Defined in: [src/base/fluent.ts:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L143)

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

Defined in: [src/base/fluent.ts:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L152)

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

Defined in: [src/base/fluent.ts:160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L160)

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

Defined in: [src/base/fluent.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L167)

Sets focus on the element.

#### Returns

`this`

The Fluent object itself.

***

### getNode()

> **getNode**(): `TElement`

Defined in: [src/base/fluent.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L128)

Gets the underlying HTML element.

#### Returns

`TElement`

The underlying HTML element.

***

### getWidget()

> **getWidget**\<`TWidget`\>(`type?`): `TWidget`

Defined in: [src/base/fluent.ts:206](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L206)

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

Defined in: [src/base/fluent.ts:175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L175)

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

Defined in: [src/base/fluent.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L182)

Gets the value of the hidden attribute/property.

##### Parameters

###### name

`string`

##### Returns

`boolean`

The value of the hidden attribute/property

#### Call Signature

> **hidden**(`value`): `this`

Defined in: [src/base/fluent.ts:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L191)

Sets the value of the hidden property/attribute.

##### Parameters

###### value

`boolean`

The value of the attribute. If the value is falsy the attribute is removed.

##### Returns

`this`

The Fluent object itself if a value is provided.

***

### hide()

> **hide**(): `this`

Defined in: [src/base/fluent.ts:198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L198)

Hides the element by setting its hidden property to true.

#### Returns

`this`

The Fluent object itself.

***

### insertAfter()

> **insertAfter**(`referenceNode`): `this`

Defined in: [src/base/fluent.ts:214](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L214)

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

Defined in: [src/base/fluent.ts:222](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L222)

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

Defined in: [src/base/fluent.ts:284](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L284)

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

Defined in: [src/base/fluent.ts:292](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L292)

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

Defined in: [src/base/fluent.ts:251](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L251)

Removes an event listener from the element.

##### Type Parameters

###### K

`K` *extends* keyof `HTMLElementEventMap`

##### Parameters

###### type

`K`

The type of the event. It can include a ".namespace" similar to jQuery.

###### listener

(`this`, `ev`) => `any`

The event listener to remove.

##### Returns

`this`

The Fluent object itself.

#### Call Signature

> **off**(`type`): `this`

Defined in: [src/base/fluent.ts:252](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L252)

##### Parameters

###### type

`string`

##### Returns

`this`

#### Call Signature

> **off**(`type`, `listener`): `this`

Defined in: [src/base/fluent.ts:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L253)

##### Parameters

###### type

`string`

###### listener

`EventListener`

##### Returns

`this`

#### Call Signature

> **off**(`type`, `selector`, `delegationHandler`): `this`

Defined in: [src/base/fluent.ts:254](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L254)

##### Parameters

###### type

`string`

###### selector

`string`

###### delegationHandler

`Function`

##### Returns

`this`

***

### on()

#### Call Signature

> **on**\<`K`\>(`type`, `listener`): `this`

Defined in: [src/base/fluent.ts:263](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L263)

Adds an event listener to the element. It is possible to use delegated events like jQuery.

##### Type Parameters

###### K

`K` *extends* keyof `HTMLElementEventMap`

##### Parameters

###### type

`K`

The type of the event. It can include a ".namespace" similar to jQuery.

###### listener

(`this`, `ev`) => `any`

The event listener to add.

##### Returns

`this`

The Fluent object itself.

#### Call Signature

> **on**(`type`, `listener`): `this`

Defined in: [src/base/fluent.ts:264](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L264)

##### Parameters

###### type

`string`

###### listener

`EventListener`

##### Returns

`this`

#### Call Signature

> **on**(`type`, `selector`, `delegationHandler`): `this`

Defined in: [src/base/fluent.ts:265](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L265)

##### Parameters

###### type

`string`

###### selector

`string`

###### delegationHandler

`Function`

##### Returns

`this`

***

### one()

#### Call Signature

> **one**\<`K`\>(`type`, `listener`): `this`

Defined in: [src/base/fluent.ts:274](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L274)

Adds a one-time event listener to the element. It is possible to use delegated events like jQuery.

##### Type Parameters

###### K

`K` *extends* keyof `HTMLElementEventMap`

##### Parameters

###### type

`K`

The type of the event. It can include a ".namespace" similar to jQuery.

###### listener

(`this`, `ev`) => `any`

The event listener to add.

##### Returns

`this`

The Fluent object itself.

#### Call Signature

> **one**(`type`, `listener`): `this`

Defined in: [src/base/fluent.ts:275](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L275)

##### Parameters

###### type

`string`

###### listener

`EventListener`

##### Returns

`this`

#### Call Signature

> **one**(`type`, `selector`, `delegationHandler`): `this`

Defined in: [src/base/fluent.ts:276](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L276)

##### Parameters

###### type

`string`

###### selector

`string`

###### delegationHandler

`Function`

##### Returns

`this`

***

### parent()

> **parent**\<`TElement`\>(): `Fluent`\<`TElement`\>

Defined in: [src/base/fluent.ts:299](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L299)

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

Defined in: [src/base/fluent.ts:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L307)

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

Defined in: [src/base/fluent.ts:315](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L315)

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

Defined in: [src/base/fluent.ts:323](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L323)

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

Defined in: [src/base/fluent.ts:330](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L330)

Removes the element from the DOM. It also removes event handlers and disposes widgets by calling "disposing" event handlers.

#### Returns

`this`

The Fluent object itself.

***

### removeAttr()

> **removeAttr**(`name`): `this`

Defined in: [src/base/fluent.ts:338](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L338)

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

Defined in: [src/base/fluent.ts:346](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L346)

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

Defined in: [src/base/fluent.ts:353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L353)

Shows the element by setting its hidden property to false.

#### Returns

`this`

The Fluent object itself.

***

### style()

> **style**(`callback`): `this`

Defined in: [src/base/fluent.ts:361](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L361)

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

Defined in: [src/base/fluent.ts:368](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L368)

Gets or sets the text content of the element.

##### Returns

`string`

The text content of the element if no value is provided, or the Fluent object itself if a value is provided.

#### Call Signature

> **text**(`value`): `this`

Defined in: [src/base/fluent.ts:369](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L369)

##### Parameters

###### value

`string`

##### Returns

`this`

***

### toggle()

> **toggle**(`flag?`): `this`

Defined in: [src/base/fluent.ts:377](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L377)

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

Defined in: [src/base/fluent.ts:385](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L385)

Toggles one or more classes on the element. If the class exists, it is removed; otherwise, it is added.

#### Parameters

##### value

The class or classes to toggle. It can be a string, boolean, or an array of strings or booleans.

`string` | `boolean` | (`string` \| `boolean`)[]

##### add?

`boolean`

#### Returns

`this`

The Fluent object itself.

***

### trigger()

> **trigger**(`type`, `args?`): `this`

Defined in: [src/base/fluent.ts:394](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L394)

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

Defined in: [src/base/fluent.ts:402](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L402)

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

Defined in: [src/base/fluent.ts:410](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L410)

Gets or sets the value of the element.

##### Parameters

###### value

`string`

The value to set. If no value is provided, returns the current value of the element.

##### Returns

`this`

The value of the element if no value is provided, or the Fluent object itself if a value is provided.

#### Call Signature

> **val**(): `string`

Defined in: [src/base/fluent.ts:411](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L411)

##### Returns

`string`
