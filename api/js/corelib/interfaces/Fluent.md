[@serenity-is/corelib](../README.md) / Fluent

# Interface: Fluent\<TElement\>

Represents a Fluent object, which is similar to jQuery but works for only one element.
It implements the `ArrayLike` interface and can have 0 (null) or 1 element.

**`Typeparam`**

TElement The type of the underlying HTML element.

## Type parameters

| Name | Type |
| :------ | :------ |
| `TElement` | extends `HTMLElement` = `HTMLElement` |

## Hierarchy

- `ArrayLike`\<`TElement`\>

  ↳ **`Fluent`**

## Indexable

▪ [n: `number`]: `TElement`

Gets the element at the specified index.

**`Param`**

The index of the element.

## Table of contents

### Constructors

- [constructor](Fluent.md#constructor)

### Properties

- [[iterator]](Fluent.md#[iterator])
- [length](Fluent.md#length)

### Methods

- [addClass](Fluent.md#addclass)
- [after](Fluent.md#after)
- [append](Fluent.md#append)
- [appendTo](Fluent.md#appendto)
- [attr](Fluent.md#attr)
- [before](Fluent.md#before)
- [children](Fluent.md#children)
- [class](Fluent.md#class)
- [click](Fluent.md#click)
- [closest](Fluent.md#closest)
- [data](Fluent.md#data)
- [each](Fluent.md#each)
- [empty](Fluent.md#empty)
- [findAll](Fluent.md#findall)
- [findEach](Fluent.md#findeach)
- [findFirst](Fluent.md#findfirst)
- [focus](Fluent.md#focus)
- [getNode](Fluent.md#getnode)
- [getWidget](Fluent.md#getwidget)
- [hasClass](Fluent.md#hasclass)
- [hide](Fluent.md#hide)
- [insertAfter](Fluent.md#insertafter)
- [insertBefore](Fluent.md#insertbefore)
- [matches](Fluent.md#matches)
- [nextSibling](Fluent.md#nextsibling)
- [off](Fluent.md#off)
- [on](Fluent.md#on)
- [one](Fluent.md#one)
- [parent](Fluent.md#parent)
- [prepend](Fluent.md#prepend)
- [prependTo](Fluent.md#prependto)
- [prevSibling](Fluent.md#prevsibling)
- [remove](Fluent.md#remove)
- [removeAttr](Fluent.md#removeattr)
- [removeClass](Fluent.md#removeclass)
- [show](Fluent.md#show)
- [style](Fluent.md#style)
- [text](Fluent.md#text)
- [toggle](Fluent.md#toggle)
- [toggleClass](Fluent.md#toggleclass)
- [trigger](Fluent.md#trigger)
- [tryGetWidget](Fluent.md#trygetwidget)
- [val](Fluent.md#val)
- [byId](Fluent.md#byid)
- [findAll](Fluent.md#findall-1)
- [findEach](Fluent.md#findeach-1)
- [findFirst](Fluent.md#findfirst-1)
- [ready](Fluent.md#ready)

## Constructors

### constructor

• **constructor**: `Object`

#### Inherited from

ArrayLike\<TElement\>.constructor

## Properties

### [iterator]

• **[iterator]**: `TElement`[]

Gets an iterator for the elements in the Fluent object.

#### Defined in

[src/base/fluent.ts:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L219)

___

### length

• `Readonly` **length**: `number`

Gets the number of elements in the Fluent object. Can only be 1 or 0.

#### Overrides

ArrayLike.length

#### Defined in

[src/base/fluent.ts:232](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L232)

## Methods

### addClass

▸ **addClass**(`value`): `this`

Adds one or more classes to the element. Any falsy value is ignored.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `string` \| `boolean` \| (`string` \| `boolean`)[] | The class or classes to add. It can be a string, boolean, or an array of strings or booleans. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L19)

___

### after

▸ **after**(`content`): `this`

Inserts content after the element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `content` | `string` \| `Node` \| [`Fluent`](Fluent.md)\<`any`\> | The content to insert. It can be a string, a Node object, or another Fluent object. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L35)

___

### append

▸ **append**(`child`): `this`

Appends content to the element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `child` | `string` \| `Node` \| [`Fluent`](Fluent.md)\<`any`\> | The content to append. It can be a string, a Node object, or another Fluent object. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L27)

___

### appendTo

▸ **appendTo**(`parent`): `this`

Appends the element to the specified parent element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `parent` | `Element` \| [`Fluent`](Fluent.md)\<`any`\> | The parent element to append to. It can be an Element object or another Fluent object. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L43)

___

### attr

▸ **attr**(`name`): `string`

Gets the value of the specified attribute.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `name` | `string` | The name of the attribute. |

#### Returns

`string`

The value of the attribute.

#### Defined in

[src/base/fluent.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L51)

▸ **attr**(`name`, `value`): `this`

Sets the value of the specified attribute.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `name` | `string` | The name of the attribute. |
| `value` | `string` \| `number` \| `boolean` | The value of the attribute. If the value is falsy the attribute is removed. |

#### Returns

`this`

The Fluent object itself if a value is provided.

#### Defined in

[src/base/fluent.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L60)

___

### before

▸ **before**(`content`): `this`

Inserts content before the element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `content` | `string` \| `Node` \| [`Fluent`](Fluent.md)\<`any`\> | The content to insert. It can be a string, a Node object, or another Fluent object. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L68)

___

### children

▸ **children**(`selector?`): `HTMLElement`[]

Gets the children of the element as an array (not Fluent)

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selector?` | `string` | Optional. A CSS selector to filter the children. |

#### Returns

`HTMLElement`[]

An array of HTMLElement objects representing the children.

#### Defined in

[src/base/fluent.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L76)

___

### class

▸ **class**(`value`): `this`

Sets (overrides) the class attribute of the element. Any falsy value is ignored.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `string` \| `boolean` \| (`string` \| `boolean`)[] | The class or classes to add. It can be a string, boolean, or an array of strings or booleans. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L84)

___

### click

▸ **click**(): `this`

Triggers a click event on the element.

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L91)

▸ **click**(`listener`): `this`

Adds a click event listener on the element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `listener` | (`e`: `MouseEvent`) => `void` | A callback function to execute when the click event is triggered. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L98)

___

### closest

▸ **closest**(`selector`): [`Fluent`](Fluent.md)\<`HTMLElement`\>

Gets the closest ancestor of the element that matches the specified selector.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selector` | `string` | A CSS selector to match against. |

#### Returns

[`Fluent`](Fluent.md)\<`HTMLElement`\>

A Fluent object representing the closest ancestor element.

#### Defined in

[src/base/fluent.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L106)

___

### data

▸ **data**(`name`): `string`

Gets or sets the value of the specified data attribute.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `name` | `string` | The name of the data attribute. |

#### Returns

`string`

The value of the data attribute if no value is provided, or the Fluent object itself if a value is provided.

#### Defined in

[src/base/fluent.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L114)

▸ **data**(`name`, `value`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |
| `value` | `string` |

#### Returns

`this`

#### Defined in

[src/base/fluent.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L115)

___

### each

▸ **each**(`callback`): `this`

Executes a callback function for the element in the Fluent object if it is not null.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `callback` | (`el`: `TElement`) => `void` | The callback function to execute for each element. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L123)

___

### empty

▸ **empty**(): `this`

Removes all child nodes from the element. It also clears event handlers attached via Fluent, and disposes any attached widgets.

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L137)

___

### findAll

▸ **findAll**\<`TElement`\>(`selector`): `TElement`[]

Finds all elements that match the specified selector within the element.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TElement` | extends `HTMLElement` = `HTMLElement` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selector` | `string` | A CSS selector to match against. |

#### Returns

`TElement`[]

An array of elements that match the selector.

**`Typeparam`**

TElement The type of the found elements.

#### Defined in

[src/base/fluent.ts:146](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L146)

___

### findEach

▸ **findEach**\<`TElement`\>(`selector`, `callback`): [`Fluent`](Fluent.md)\<`HTMLElement`\>

Finds each element that matches the specified selector within the element and executes a callback function for each found element as a Fluent object.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TElement` | extends `HTMLElement` = `HTMLElement` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selector` | `string` | A CSS selector to match against. |
| `callback` | (`el`: [`Fluent`](Fluent.md)\<`TElement`\>) => `void` | The callback function to execute for each found element. It receives a Fluent object for each element. |

#### Returns

[`Fluent`](Fluent.md)\<`HTMLElement`\>

The Fluent object itself.

**`Typeparam`**

TElement The type of the found elements.

#### Defined in

[src/base/fluent.ts:156](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L156)

___

### findFirst

▸ **findFirst**\<`TElement`\>(`selector`): [`Fluent`](Fluent.md)\<`TElement`\>

Finds the first element that matches the specified selector within the element.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TElement` | extends `HTMLElement` = `HTMLElement` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selector` | `string` | A CSS selector to match against. |

#### Returns

[`Fluent`](Fluent.md)\<`TElement`\>

A Fluent object representing the first element that matches the selector.

**`Typeparam`**

TElement The type of the found element.

#### Defined in

[src/base/fluent.ts:165](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L165)

___

### focus

▸ **focus**(): `this`

Sets focus on the element.

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L172)

___

### getNode

▸ **getNode**(): `TElement`

Gets the underlying HTML element.

#### Returns

`TElement`

The underlying HTML element.

#### Defined in

[src/base/fluent.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L130)

___

### getWidget

▸ **getWidget**\<`TWidget`\>(`type?`): `TWidget`

Gets the widget associated with the element.

#### Type parameters

| Name |
| :------ |
| `TWidget` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `type?` | (...`args`: `any`[]) => `TWidget` | Optional. The constructor function of the widget. |

#### Returns

`TWidget`

The widget associated with the element.

**`Typeparam`**

TWidget The type of the widget.

#### Defined in

[src/base/fluent.ts:196](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L196)

___

### hasClass

▸ **hasClass**(`klass`): `boolean`

Checks if the element has the specified class.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `klass` | `string` | The class to check for. |

#### Returns

`boolean`

`true` if the element has the class, `false` otherwise.

#### Defined in

[src/base/fluent.ts:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L180)

___

### hide

▸ **hide**(): `this`

Hides the element by setting its display property to "none".

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L187)

___

### insertAfter

▸ **insertAfter**(`referenceNode`): `this`

Inserts the element after the specified reference element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `referenceNode` | `HTMLElement` \| [`Fluent`](Fluent.md)\<`HTMLElement`\> | The reference element to insert after. It can be an HTMLElement object or another Fluent object. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:204](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L204)

___

### insertBefore

▸ **insertBefore**(`referenceNode`): `this`

Inserts the element before the specified reference element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `referenceNode` | `HTMLElement` \| [`Fluent`](Fluent.md)\<`HTMLElement`\> | The reference element to insert before. It can be an HTMLElement object or another Fluent object. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:212](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L212)

___

### matches

▸ **matches**(`selector`): `boolean`

Checks if the element matches the specified selector.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selector` | `string` | A CSS selector to match against. |

#### Returns

`boolean`

`true` if the element matches the selector, `false` otherwise.

#### Defined in

[src/base/fluent.ts:277](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L277)

___

### nextSibling

▸ **nextSibling**(`selector?`): [`Fluent`](Fluent.md)\<`any`\>

Gets the next sibling element that matches the specified selector, or the first sibling if no selector is provided..

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selector?` | `string` | Optional. A CSS selector to filter the next sibling. |

#### Returns

[`Fluent`](Fluent.md)\<`any`\>

A Fluent object representing the next sibling element.

#### Defined in

[src/base/fluent.ts:285](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L285)

___

### off

▸ **off**\<`K`\>(`type`, `listener`): `this`

Removes an event listener from the element.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `K` | extends keyof `HTMLElementEventMap` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `type` | `K` | The type of the event. It can include a ".namespace" similar to jQuery. |
| `listener` | (`this`: `HTMLElement`, `ev`: `HTMLElementEventMap`[`K`]) => `any` | The event listener to remove. |

#### Returns

`this`

The Fluent object itself.

**`Typeparam`**

K The type of the event.

#### Defined in

[src/base/fluent.ts:242](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L242)

▸ **off**(`type`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `string` |

#### Returns

`this`

#### Defined in

[src/base/fluent.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L243)

▸ **off**(`type`, `listener`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `string` |
| `listener` | `EventListener` |

#### Returns

`this`

#### Defined in

[src/base/fluent.ts:244](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L244)

▸ **off**(`type`, `selector`, `delegationHandler`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `string` |
| `selector` | `string` |
| `delegationHandler` | `Function` |

#### Returns

`this`

#### Defined in

[src/base/fluent.ts:245](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L245)

___

### on

▸ **on**\<`K`\>(`type`, `listener`): `this`

Adds an event listener to the element. It is possible to use delegated events like jQuery.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `K` | extends keyof `HTMLElementEventMap` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `type` | `K` | The type of the event. It can include a ".namespace" similar to jQuery. |
| `listener` | (`this`: `HTMLElement`, `ev`: `HTMLElementEventMap`[`K`]) => `any` | The event listener to add. |

#### Returns

`this`

The Fluent object itself.

**`Typeparam`**

K The type of the event.

#### Defined in

[src/base/fluent.ts:255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L255)

▸ **on**(`type`, `listener`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `string` |
| `listener` | `EventListener` |

#### Returns

`this`

#### Defined in

[src/base/fluent.ts:256](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L256)

▸ **on**(`type`, `selector`, `delegationHandler`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `string` |
| `selector` | `string` |
| `delegationHandler` | `Function` |

#### Returns

`this`

#### Defined in

[src/base/fluent.ts:257](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L257)

___

### one

▸ **one**\<`K`\>(`type`, `listener`): `this`

Adds a one-time event listener to the element. It is possible to use delegated events like jQuery.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `K` | extends keyof `HTMLElementEventMap` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `type` | `K` | The type of the event. It can include a ".namespace" similar to jQuery. |
| `listener` | (`this`: `HTMLElement`, `ev`: `HTMLElementEventMap`[`K`]) => `any` | The event listener to add. |

#### Returns

`this`

The Fluent object itself.

**`Typeparam`**

K The type of the event.

#### Defined in

[src/base/fluent.ts:267](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L267)

▸ **one**(`type`, `listener`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `string` |
| `listener` | `EventListener` |

#### Returns

`this`

#### Defined in

[src/base/fluent.ts:268](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L268)

▸ **one**(`type`, `selector`, `delegationHandler`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `string` |
| `selector` | `string` |
| `delegationHandler` | `Function` |

#### Returns

`this`

#### Defined in

[src/base/fluent.ts:269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L269)

___

### parent

▸ **parent**(): [`Fluent`](Fluent.md)\<`HTMLElement`\>

Gets the parent element of the element.

#### Returns

[`Fluent`](Fluent.md)\<`HTMLElement`\>

A Fluent object representing the parent element.

#### Defined in

[src/base/fluent.ts:292](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L292)

___

### prepend

▸ **prepend**(`child`): `this`

Prepends content to the element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `child` | `string` \| `Node` \| [`Fluent`](Fluent.md)\<`any`\> | The content to prepend. It can be a string, a Node object, or another Fluent object. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:300](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L300)

___

### prependTo

▸ **prependTo**(`parent`): `this`

Prepends the element to the specified parent element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `parent` | `Element` \| [`Fluent`](Fluent.md)\<`any`\> | The parent element to prepend to. It can be an Element object or another Fluent object. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:308](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L308)

___

### prevSibling

▸ **prevSibling**(`selector?`): [`Fluent`](Fluent.md)\<`any`\>

Gets the previous sibling element that matches the specified selector, or the first sibling if no selector is provided.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selector?` | `string` | Optional. A CSS selector to filter the previous sibling. |

#### Returns

[`Fluent`](Fluent.md)\<`any`\>

A Fluent object representing the previous sibling element.

#### Defined in

[src/base/fluent.ts:316](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L316)

___

### remove

▸ **remove**(): `this`

Removes the element from the DOM. It also removes event handlers and disposes widgets by calling "remove" event handlers.

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:323](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L323)

___

### removeAttr

▸ **removeAttr**(`name`): `this`

Removes the specified attribute from the element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `name` | `string` | The name of the attribute to remove. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:331](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L331)

___

### removeClass

▸ **removeClass**(`value`): `this`

Removes one or more classes from the element. Any falsy value is ignored.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `string` \| `boolean` \| (`string` \| `boolean`)[] | The class or classes to remove. It can be a string, boolean, or an array of strings or booleans. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:339](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L339)

___

### show

▸ **show**(): `this`

Shows the element by setting its display property to empty string.

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:346](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L346)

___

### style

▸ **style**(`callback`): `this`

Executes a callback function to modify the inline style of the element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `callback` | (`css`: `CSSStyleDeclaration`) => `void` | The callback function to modify the inline style. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:354](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L354)

___

### text

▸ **text**(): `string`

Gets or sets the text content of the element.

#### Returns

`string`

The text content of the element if no value is provided, or the Fluent object itself if a value is provided.

#### Defined in

[src/base/fluent.ts:361](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L361)

▸ **text**(`value`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`this`

#### Defined in

[src/base/fluent.ts:362](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L362)

___

### toggle

▸ **toggle**(`flag?`): `this`

Toggles the visibility of the element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `flag?` | `boolean` | Optional. A flag indicating whether to show or hide the element. If not provided, the visibility will be toggled. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:370](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L370)

___

### toggleClass

▸ **toggleClass**(`value`, `add?`): `this`

Toggles one or more classes on the element. If the class exists, it is removed; otherwise, it is added.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `string` \| `boolean` \| (`string` \| `boolean`)[] | The class or classes to toggle. It can be a string, boolean, or an array of strings or booleans. |
| `add?` | `boolean` | - |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:378](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L378)

___

### trigger

▸ **trigger**(`type`, `args?`): `this`

Triggers a specified event on the element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `type` | `string` | The type of the event to trigger. |
| `args?` | `any` | Optional. An object that specifies event-specific initialization properties. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[src/base/fluent.ts:387](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L387)

___

### tryGetWidget

▸ **tryGetWidget**\<`TWidget`\>(`type?`): `TWidget`

Tries to get the widget associated with the element.

#### Type parameters

| Name |
| :------ |
| `TWidget` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `type?` | (...`args`: `any`[]) => `TWidget` | Optional. The constructor function of the widget. |

#### Returns

`TWidget`

The widget associated with the element, or `null` if no widget is found.

**`Typeparam`**

TWidget The type of the widget.

#### Defined in

[src/base/fluent.ts:396](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L396)

___

### val

▸ **val**(`value`): `this`

Gets or sets the value of the element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `string` | The value to set. If no value is provided, returns the current value of the element. |

#### Returns

`this`

The value of the element if no value is provided, or the Fluent object itself if a value is provided.

#### Defined in

[src/base/fluent.ts:404](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L404)

▸ **val**(): `string`

#### Returns

`string`

#### Defined in

[src/base/fluent.ts:405](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L405)

___

### byId

▸ **byId**\<`TElement`\>(`id`): [`Fluent`](Fluent.md)\<`TElement`\>

Finds the first element having the specified ID within the document.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TElement` | extends `HTMLElement` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `id` | `string` | The ID |

#### Returns

[`Fluent`](Fluent.md)\<`TElement`\>

A Fluent instance representing the first matching element, or null if no match is found.

#### Defined in

[src/base/fluent.ts:982](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L982)

___

### findAll

▸ **findAll**\<`TElement`\>(`selector`): `TElement`[]

Finds all elements matching the specified selector within the document.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TElement` | extends `HTMLElement` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selector` | `string` | The CSS selector to search for. |

#### Returns

`TElement`[]

An array of HTML elements matching the selector.

#### Defined in

[src/base/fluent.ts:992](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L992)

___

### findEach

▸ **findEach**\<`TElement`\>(`selector`, `callback`): `void`

Iterates over all elements matching the specified selector within the document.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TElement` | extends `HTMLElement` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selector` | `string` | The CSS selector to search for. |
| `callback` | (`el`: [`Fluent`](Fluent.md)\<`TElement`\>) => `void` | A function to execute for each matching element. Receives a Fluent object. |

#### Returns

`void`

#### Defined in

[src/base/fluent.ts:1002](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L1002)

___

### findFirst

▸ **findFirst**\<`TElement`\>(`selector`): [`Fluent`](Fluent.md)\<`TElement`\>

Finds the first element matching the specified selector within the document.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TElement` | extends `HTMLElement` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selector` | `string` | The CSS selector to search for. |

#### Returns

[`Fluent`](Fluent.md)\<`TElement`\>

A Fluent instance representing the first matching element, or null if no match is found.

#### Defined in

[src/base/fluent.ts:1013](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L1013)

___

### ready

▸ **ready**(`callback`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `callback` | () => `void` |

#### Returns

`void`

#### Defined in

[src/base/fluent.ts:955](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/fluent.ts#L955)
