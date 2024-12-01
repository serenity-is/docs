[@serenity-is/corelib](../README.md) / Fluent

# Interface: Fluent\<TElement\>

Represents a Fluent object, which is similar to jQuery but works for only one element.
It implements the `ArrayLike` interface and can have 0 (null) or 1 element.

## Extends

- `ArrayLike`\<`TElement`\>

## Type Parameters

• **TElement** *extends* `HTMLElement` = `HTMLElement`

## Indexable

 \[`n`: `number`\]: `TElement`

## Constructors

## Properties

### \[iterator\]

> **\[iterator\]**: `TElement`[]

Gets an iterator for the elements in the Fluent object.

#### Returns

An iterator for the elements in the Fluent object.

#### Defined in

[src/base/fluent.ts:213](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L213)

***

### length

> `readonly` **length**: `number`

Gets the number of elements in the Fluent object. Can only be 1 or 0.

#### Overrides

`ArrayLike.length`

#### Defined in

[src/base/fluent.ts:226](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L226)

## Methods

### addClass()

> **addClass**(`value`): `this`

Adds one or more classes to the element. Any falsy value is ignored.

#### Parameters

##### value

`string` | `boolean` | (`string` \| `boolean`)[]

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L17)

***

### after()

> **after**(`content`): `this`

Inserts content after the element.

#### Parameters

##### content

`string` | `Node` | [`Fluent`](Fluent.md)\<`any`\>

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L33)

***

### append()

> **append**(`child`): `this`

Appends content to the element.

#### Parameters

##### child

`string` | `Node` | [`Fluent`](Fluent.md)\<`any`\>

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L25)

***

### appendTo()

> **appendTo**(`parent`): `this`

Appends the element to the specified parent element.

#### Parameters

##### parent

`Element` | [`Fluent`](Fluent.md)\<`any`\>

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L41)

***

### attr()

#### Call Signature

> **attr**(`name`): `string`

Gets the value of the specified attribute.

##### Parameters

###### name

`string`

The name of the attribute.

##### Returns

`string`

The value of the attribute.

##### Defined in

[src/base/fluent.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L49)

#### Call Signature

> **attr**(`name`, `value`): `this`

Sets the value of the specified attribute.

##### Parameters

###### name

`string`

The name of the attribute.

###### value

`string` | `number` | `boolean`

##### Returns

`this`

The Fluent object itself if a value is provided.

##### Defined in

[src/base/fluent.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L58)

***

### before()

> **before**(`content`): `this`

Inserts content before the element.

#### Parameters

##### content

`string` | `Node` | [`Fluent`](Fluent.md)\<`any`\>

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L66)

***

### children()

> **children**\<`TElement`\>(`selector`?): `TElement`[]

Gets the children of the element as an array (not Fluent)

#### Type Parameters

• **TElement** *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### selector?

`string`

Optional. A CSS selector to filter the children.

#### Returns

`TElement`[]

An array of HTMLElement objects representing the children.

#### Defined in

[src/base/fluent.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L74)

***

### class()

> **class**(`value`): `this`

Sets (overrides) the class attribute of the element. Any falsy value is ignored.

#### Parameters

##### value

`string` | `boolean` | (`string` \| `boolean`)[]

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L82)

***

### click()

#### Call Signature

> **click**(): `this`

Triggers a click event on the element.

##### Returns

`this`

The Fluent object itself.

##### Defined in

[src/base/fluent.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L89)

#### Call Signature

> **click**(`listener`): `this`

Adds a click event listener on the element.

##### Parameters

###### listener

(`e`) => `void`

A callback function to execute when the click event is triggered.

##### Returns

`this`

The Fluent object itself.

##### Defined in

[src/base/fluent.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L96)

***

### closest()

> **closest**\<`TElement`\>(`selector`): [`Fluent`](Fluent.md)\<`TElement`\>

Gets the closest ancestor of the element that matches the specified selector.

#### Type Parameters

• **TElement** *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### selector

`string`

A CSS selector to match against.

#### Returns

[`Fluent`](Fluent.md)\<`TElement`\>

A Fluent object representing the closest ancestor element.

#### Defined in

[src/base/fluent.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L104)

***

### data()

#### Call Signature

> **data**(`name`): `string`

Gets or sets the value of the specified data attribute.

##### Parameters

###### name

`string`

The name of the data attribute.

##### Returns

`string`

The value of the data attribute if no value is provided, or the Fluent object itself if a value is provided.

##### Defined in

[src/base/fluent.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L112)

#### Call Signature

> **data**(`name`, `value`): `this`

##### Parameters

###### name

`string`

###### value

`string`

##### Returns

`this`

##### Defined in

[src/base/fluent.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L113)

***

### each()

> **each**(`callback`): `this`

Executes a callback function for the element in the Fluent object if it is not null.

#### Parameters

##### callback

(`el`) => `void`

The callback function to execute for each element.

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L121)

***

### empty()

> **empty**(): `this`

Removes all child nodes from the element. It also clears event handlers attached via Fluent, and disposes any attached widgets.

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L135)

***

### findAll()

> **findAll**\<`TElement`\>(`selector`): `TElement`[]

Finds all elements that match the specified selector within the element.

#### Type Parameters

• **TElement** *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### selector

`string`

A CSS selector to match against.

#### Returns

`TElement`[]

An array of elements that match the selector.

#### Defined in

[src/base/fluent.ts:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L143)

***

### findEach()

> **findEach**\<`TElement`\>(`selector`, `callback`): `this`

Finds each element that matches the specified selector within the element and executes a callback function for each found element as a Fluent object.

#### Type Parameters

• **TElement** *extends* `HTMLElement` = `HTMLElement`

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

#### Defined in

[src/base/fluent.ts:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L152)

***

### findFirst()

> **findFirst**\<`TElement`\>(`selector`): [`Fluent`](Fluent.md)\<`TElement`\>

Finds the first element that matches the specified selector within the element.

#### Type Parameters

• **TElement** *extends* `HTMLElement` = `HTMLElement`

#### Parameters

##### selector

`string`

A CSS selector to match against.

#### Returns

[`Fluent`](Fluent.md)\<`TElement`\>

A Fluent object representing the first element that matches the selector.

#### Defined in

[src/base/fluent.ts:160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L160)

***

### focus()

> **focus**(): `this`

Sets focus on the element.

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:167](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L167)

***

### getNode()

> **getNode**(): `TElement`

Gets the underlying HTML element.

#### Returns

`TElement`

The underlying HTML element.

#### Defined in

[src/base/fluent.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L128)

***

### getWidget()

> **getWidget**\<`TWidget`\>(`type`?): `TWidget`

Gets the widget associated with the element.

#### Type Parameters

• **TWidget**

#### Parameters

##### type?

(...`args`) => `TWidget`

Optional. The constructor function of the widget.

#### Returns

`TWidget`

The widget associated with the element.

#### Defined in

[src/base/fluent.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L190)

***

### hasClass()

> **hasClass**(`klass`): `boolean`

Checks if the element has the specified class.

#### Parameters

##### klass

`string`

The class to check for.

#### Returns

`boolean`

`true` if the element has the class, `false` otherwise.

#### Defined in

[src/base/fluent.ts:175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L175)

***

### hide()

> **hide**(): `this`

Hides the element by setting its display property to "none".

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L182)

***

### insertAfter()

> **insertAfter**(`referenceNode`): `this`

Inserts the element after the specified reference element.

#### Parameters

##### referenceNode

`HTMLElement` | [`Fluent`](Fluent.md)\<`HTMLElement`\>

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:198](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L198)

***

### insertBefore()

> **insertBefore**(`referenceNode`): `this`

Inserts the element before the specified reference element.

#### Parameters

##### referenceNode

`HTMLElement` | [`Fluent`](Fluent.md)\<`HTMLElement`\>

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:206](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L206)

***

### matches()

> **matches**(`selector`): `boolean`

Checks if the element matches the specified selector.

#### Parameters

##### selector

`string`

A CSS selector to match against.

#### Returns

`boolean`

`true` if the element matches the selector, `false` otherwise.

#### Defined in

[src/base/fluent.ts:268](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L268)

***

### nextSibling()

> **nextSibling**(`selector`?): [`Fluent`](Fluent.md)\<`any`\>

Gets the next sibling element that matches the specified selector, or the first sibling if no selector is provided..

#### Parameters

##### selector?

`string`

Optional. A CSS selector to filter the next sibling.

#### Returns

[`Fluent`](Fluent.md)\<`any`\>

A Fluent object representing the next sibling element.

#### Defined in

[src/base/fluent.ts:276](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L276)

***

### off()

#### Call Signature

> **off**\<`K`\>(`type`, `listener`): `this`

Removes an event listener from the element.

##### Type Parameters

• **K** *extends* keyof `HTMLElementEventMap`

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

##### Defined in

[src/base/fluent.ts:235](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L235)

#### Call Signature

> **off**(`type`): `this`

##### Parameters

###### type

`string`

##### Returns

`this`

##### Defined in

[src/base/fluent.ts:236](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L236)

#### Call Signature

> **off**(`type`, `listener`): `this`

##### Parameters

###### type

`string`

###### listener

`EventListener`

##### Returns

`this`

##### Defined in

[src/base/fluent.ts:237](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L237)

#### Call Signature

> **off**(`type`, `selector`, `delegationHandler`): `this`

##### Parameters

###### type

`string`

###### selector

`string`

###### delegationHandler

`Function`

##### Returns

`this`

##### Defined in

[src/base/fluent.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L238)

***

### on()

#### Call Signature

> **on**\<`K`\>(`type`, `listener`): `this`

Adds an event listener to the element. It is possible to use delegated events like jQuery.

##### Type Parameters

• **K** *extends* keyof `HTMLElementEventMap`

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

##### Defined in

[src/base/fluent.ts:247](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L247)

#### Call Signature

> **on**(`type`, `listener`): `this`

##### Parameters

###### type

`string`

###### listener

`EventListener`

##### Returns

`this`

##### Defined in

[src/base/fluent.ts:248](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L248)

#### Call Signature

> **on**(`type`, `selector`, `delegationHandler`): `this`

##### Parameters

###### type

`string`

###### selector

`string`

###### delegationHandler

`Function`

##### Returns

`this`

##### Defined in

[src/base/fluent.ts:249](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L249)

***

### one()

#### Call Signature

> **one**\<`K`\>(`type`, `listener`): `this`

Adds a one-time event listener to the element. It is possible to use delegated events like jQuery.

##### Type Parameters

• **K** *extends* keyof `HTMLElementEventMap`

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

##### Defined in

[src/base/fluent.ts:258](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L258)

#### Call Signature

> **one**(`type`, `listener`): `this`

##### Parameters

###### type

`string`

###### listener

`EventListener`

##### Returns

`this`

##### Defined in

[src/base/fluent.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L259)

#### Call Signature

> **one**(`type`, `selector`, `delegationHandler`): `this`

##### Parameters

###### type

`string`

###### selector

`string`

###### delegationHandler

`Function`

##### Returns

`this`

##### Defined in

[src/base/fluent.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L260)

***

### parent()

> **parent**\<`TElement`\>(): [`Fluent`](Fluent.md)\<`TElement`\>

Gets the parent element of the element.

#### Type Parameters

• **TElement** *extends* `HTMLElement` = `HTMLElement`

#### Returns

[`Fluent`](Fluent.md)\<`TElement`\>

A Fluent object representing the parent element.

#### Defined in

[src/base/fluent.ts:283](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L283)

***

### prepend()

> **prepend**(`child`): `this`

Prepends content to the element.

#### Parameters

##### child

`string` | `Node` | [`Fluent`](Fluent.md)\<`any`\>

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:291](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L291)

***

### prependTo()

> **prependTo**(`parent`): `this`

Prepends the element to the specified parent element.

#### Parameters

##### parent

`Element` | [`Fluent`](Fluent.md)\<`any`\>

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:299](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L299)

***

### prevSibling()

> **prevSibling**(`selector`?): [`Fluent`](Fluent.md)\<`any`\>

Gets the previous sibling element that matches the specified selector, or the first sibling if no selector is provided.

#### Parameters

##### selector?

`string`

Optional. A CSS selector to filter the previous sibling.

#### Returns

[`Fluent`](Fluent.md)\<`any`\>

A Fluent object representing the previous sibling element.

#### Defined in

[src/base/fluent.ts:307](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L307)

***

### remove()

> **remove**(): `this`

Removes the element from the DOM. It also removes event handlers and disposes widgets by calling "disposing" event handlers.

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:314](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L314)

***

### removeAttr()

> **removeAttr**(`name`): `this`

Removes the specified attribute from the element.

#### Parameters

##### name

`string`

The name of the attribute to remove.

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:322](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L322)

***

### removeClass()

> **removeClass**(`value`): `this`

Removes one or more classes from the element. Any falsy value is ignored.

#### Parameters

##### value

`string` | `boolean` | (`string` \| `boolean`)[]

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:330](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L330)

***

### show()

> **show**(): `this`

Shows the element by setting its display property to empty string.

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:337](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L337)

***

### style()

> **style**(`callback`): `this`

Executes a callback function to modify the inline style of the element.

#### Parameters

##### callback

(`css`) => `void`

The callback function to modify the inline style.

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:345](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L345)

***

### text()

#### Call Signature

> **text**(): `string`

Gets or sets the text content of the element.

##### Returns

`string`

The text content of the element if no value is provided, or the Fluent object itself if a value is provided.

##### Defined in

[src/base/fluent.ts:352](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L352)

#### Call Signature

> **text**(`value`): `this`

##### Parameters

###### value

`string`

##### Returns

`this`

##### Defined in

[src/base/fluent.ts:353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L353)

***

### toggle()

> **toggle**(`flag`?): `this`

Toggles the visibility of the element.

#### Parameters

##### flag?

`boolean`

Optional. A flag indicating whether to show or hide the element. If not provided, the visibility will be toggled.

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:361](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L361)

***

### toggleClass()

> **toggleClass**(`value`, `add`?): `this`

Toggles one or more classes on the element. If the class exists, it is removed; otherwise, it is added.

#### Parameters

##### value

`string` | `boolean` | (`string` \| `boolean`)[]

##### add?

`boolean`

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:369](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L369)

***

### trigger()

> **trigger**(`type`, `args`?): `this`

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

#### Defined in

[src/base/fluent.ts:378](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L378)

***

### tryGetWidget()

> **tryGetWidget**\<`TWidget`\>(`type`?): `TWidget`

Tries to get the widget associated with the element.

#### Type Parameters

• **TWidget**

#### Parameters

##### type?

(...`args`) => `TWidget`

Optional. The constructor function of the widget.

#### Returns

`TWidget`

The widget associated with the element, or `null` if no widget is found.

#### Defined in

[src/base/fluent.ts:386](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L386)

***

### val()

#### Call Signature

> **val**(`value`): `this`

Gets or sets the value of the element.

##### Parameters

###### value

`string`

The value to set. If no value is provided, returns the current value of the element.

##### Returns

`this`

The value of the element if no value is provided, or the Fluent object itself if a value is provided.

##### Defined in

[src/base/fluent.ts:394](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L394)

#### Call Signature

> **val**(): `string`

##### Returns

`string`

##### Defined in

[src/base/fluent.ts:395](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L395)

***

### byId()

> `static` **byId**\<`TElement`\>(`id`): [`Fluent`](Fluent.md)\<`TElement`\>

Finds the first element having the specified ID within the document.

#### Type Parameters

• **TElement** *extends* `HTMLElement`

#### Parameters

##### id

`string`

The ID

#### Returns

[`Fluent`](Fluent.md)\<`TElement`\>

A Fluent instance representing the first matching element, or null if no match is found.

#### Defined in

[src/base/fluent.ts:969](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L969)

***

### findAll()

> `static` **findAll**\<`TElement`\>(`selector`): `TElement`[]

Finds all elements matching the specified selector within the document.

#### Type Parameters

• **TElement** *extends* `HTMLElement`

#### Parameters

##### selector

`string`

The CSS selector to search for.

#### Returns

`TElement`[]

An array of HTML elements matching the selector.

#### Defined in

[src/base/fluent.ts:979](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L979)

***

### findEach()

> `static` **findEach**\<`TElement`\>(`selector`, `callback`): `void`

Iterates over all elements matching the specified selector within the document.

#### Type Parameters

• **TElement** *extends* `HTMLElement`

#### Parameters

##### selector

`string`

The CSS selector to search for.

##### callback

(`el`) => `void`

A function to execute for each matching element. Receives a Fluent object.

#### Returns

`void`

#### Defined in

[src/base/fluent.ts:989](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L989)

***

### findFirst()

> `static` **findFirst**\<`TElement`\>(`selector`): [`Fluent`](Fluent.md)\<`TElement`\>

Finds the first element matching the specified selector within the document.

#### Type Parameters

• **TElement** *extends* `HTMLElement`

#### Parameters

##### selector

`string`

The CSS selector to search for.

#### Returns

[`Fluent`](Fluent.md)\<`TElement`\>

A Fluent instance representing the first matching element, or null if no match is found.

#### Defined in

[src/base/fluent.ts:1000](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L1000)

***

### ready()

> `static` **ready**(`callback`): `void`

#### Parameters

##### callback

() => `void`

#### Returns

`void`

#### Defined in

[src/base/fluent.ts:942](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L942)
