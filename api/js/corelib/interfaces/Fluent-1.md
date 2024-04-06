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

- [constructor](Fluent-1.md#constructor)

### Properties

- [[iterator]](Fluent-1.md#[iterator])
- [length](Fluent-1.md#length)

### Methods

- [addClass](Fluent-1.md#addclass)
- [after](Fluent-1.md#after)
- [append](Fluent-1.md#append)
- [appendTo](Fluent-1.md#appendto)
- [attr](Fluent-1.md#attr)
- [before](Fluent-1.md#before)
- [children](Fluent-1.md#children)
- [class](Fluent-1.md#class)
- [click](Fluent-1.md#click)
- [closest](Fluent-1.md#closest)
- [data](Fluent-1.md#data)
- [each](Fluent-1.md#each)
- [empty](Fluent-1.md#empty)
- [findAll](Fluent-1.md#findall)
- [findEach](Fluent-1.md#findeach)
- [findFirst](Fluent-1.md#findfirst)
- [focus](Fluent-1.md#focus)
- [getNode](Fluent-1.md#getnode)
- [getWidget](Fluent-1.md#getwidget)
- [hasClass](Fluent-1.md#hasclass)
- [hide](Fluent-1.md#hide)
- [insertAfter](Fluent-1.md#insertafter)
- [insertBefore](Fluent-1.md#insertbefore)
- [matches](Fluent-1.md#matches)
- [nextSibling](Fluent-1.md#nextsibling)
- [off](Fluent-1.md#off)
- [on](Fluent-1.md#on)
- [one](Fluent-1.md#one)
- [parent](Fluent-1.md#parent)
- [prepend](Fluent-1.md#prepend)
- [prependTo](Fluent-1.md#prependto)
- [prevSibling](Fluent-1.md#prevsibling)
- [remove](Fluent-1.md#remove)
- [removeAttr](Fluent-1.md#removeattr)
- [removeClass](Fluent-1.md#removeclass)
- [show](Fluent-1.md#show)
- [style](Fluent-1.md#style)
- [text](Fluent-1.md#text)
- [toggle](Fluent-1.md#toggle)
- [toggleClass](Fluent-1.md#toggleclass)
- [trigger](Fluent-1.md#trigger)
- [tryGetWidget](Fluent-1.md#trygetwidget)
- [val](Fluent-1.md#val)

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

[../base/dist/index.d.ts:773](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L773)

___

### length

• `Readonly` **length**: `number`

Gets the number of elements in the Fluent object. Can only be 1 or 0.

#### Overrides

ArrayLike.length

#### Defined in

[../base/dist/index.d.ts:784](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L784)

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

[../base/dist/index.d.ts:606](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L606)

___

### after

▸ **after**(`content`): `this`

Inserts content after the element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `content` | `string` \| `Node` \| [`Fluent`](Fluent-1.md)\<`any`\> | The content to insert. It can be a string, a Node object, or another Fluent object. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[../base/dist/index.d.ts:620](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L620)

___

### append

▸ **append**(`child`): `this`

Appends content to the element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `child` | `string` \| `Node` \| [`Fluent`](Fluent-1.md)\<`any`\> | The content to append. It can be a string, a Node object, or another Fluent object. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[../base/dist/index.d.ts:613](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L613)

___

### appendTo

▸ **appendTo**(`parent`): `this`

Appends the element to the specified parent element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `parent` | `Element` \| [`Fluent`](Fluent-1.md)\<`any`\> | The parent element to append to. It can be an Element object or another Fluent object. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[../base/dist/index.d.ts:627](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L627)

___

### attr

▸ **attr**(`name`): `string`

Gets or sets the value of the specified attribute.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `name` | `string` | The name of the attribute. |

#### Returns

`string`

The value of the attribute if no value is provided, or the Fluent object itself if a value is provided.

#### Defined in

[../base/dist/index.d.ts:635](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L635)

▸ **attr**(`name`, `value`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |
| `value` | `string` \| `number` \| `boolean` |

#### Returns

`this`

#### Defined in

[../base/dist/index.d.ts:636](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L636)

___

### before

▸ **before**(`content`): `this`

Inserts content before the element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `content` | `string` \| `Node` \| [`Fluent`](Fluent-1.md)\<`any`\> | The content to insert. It can be a string, a Node object, or another Fluent object. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[../base/dist/index.d.ts:643](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L643)

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

[../base/dist/index.d.ts:650](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L650)

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

[../base/dist/index.d.ts:657](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L657)

___

### click

▸ **click**(): `this`

Triggers a click event on the element.

#### Returns

`this`

The Fluent object itself.

#### Defined in

[../base/dist/index.d.ts:664](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L664)

▸ **click**(`listener`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `listener` | (`e`: `MouseEvent`) => `void` |

#### Returns

`this`

#### Defined in

[../base/dist/index.d.ts:665](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L665)

___

### closest

▸ **closest**(`selector`): [`Fluent`](Fluent-1.md)\<`HTMLElement`\>

Gets the closest ancestor of the element that matches the specified selector.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selector` | `string` | A CSS selector to match against. |

#### Returns

[`Fluent`](Fluent-1.md)\<`HTMLElement`\>

A Fluent object representing the closest ancestor element.

#### Defined in

[../base/dist/index.d.ts:672](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L672)

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

[../base/dist/index.d.ts:679](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L679)

▸ **data**(`name`, `value`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |
| `value` | `string` |

#### Returns

`this`

#### Defined in

[../base/dist/index.d.ts:680](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L680)

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

[../base/dist/index.d.ts:687](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L687)

___

### empty

▸ **empty**(): `this`

Removes all child nodes from the element. It also clears event handlers attached via Fluent, and disposes any attached widgets.

#### Returns

`this`

The Fluent object itself.

#### Defined in

[../base/dist/index.d.ts:699](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L699)

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

[../base/dist/index.d.ts:707](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L707)

___

### findEach

▸ **findEach**\<`TElement`\>(`selector`, `callback`): [`Fluent`](Fluent-1.md)\<`HTMLElement`\>

Finds each element that matches the specified selector within the element and executes a callback function for each found element as a Fluent object.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TElement` | extends `HTMLElement` = `HTMLElement` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selector` | `string` | A CSS selector to match against. |
| `callback` | (`el`: [`Fluent`](Fluent-1.md)\<`TElement`\>) => `void` | The callback function to execute for each found element. It receives a Fluent object for each element. |

#### Returns

[`Fluent`](Fluent-1.md)\<`HTMLElement`\>

The Fluent object itself.

**`Typeparam`**

TElement The type of the found elements.

#### Defined in

[../base/dist/index.d.ts:716](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L716)

___

### findFirst

▸ **findFirst**\<`TElement`\>(`selector`): [`Fluent`](Fluent-1.md)\<`TElement`\>

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

[`Fluent`](Fluent-1.md)\<`TElement`\>

A Fluent object representing the first element that matches the selector.

**`Typeparam`**

TElement The type of the found element.

#### Defined in

[../base/dist/index.d.ts:724](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L724)

___

### focus

▸ **focus**(): `this`

Sets focus on the element.

#### Returns

`this`

The Fluent object itself.

#### Defined in

[../base/dist/index.d.ts:730](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L730)

___

### getNode

▸ **getNode**(): `TElement`

Gets the underlying HTML element.

#### Returns

`TElement`

The underlying HTML element.

#### Defined in

[../base/dist/index.d.ts:693](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L693)

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

[../base/dist/index.d.ts:751](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L751)

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

[../base/dist/index.d.ts:737](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L737)

___

### hide

▸ **hide**(): `this`

Hides the element by setting its display property to "none".

#### Returns

`this`

The Fluent object itself.

#### Defined in

[../base/dist/index.d.ts:743](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L743)

___

### insertAfter

▸ **insertAfter**(`referenceNode`): `this`

Inserts the element after the specified reference element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `referenceNode` | `HTMLElement` \| [`Fluent`](Fluent-1.md)\<`HTMLElement`\> | The reference element to insert after. It can be an HTMLElement object or another Fluent object. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[../base/dist/index.d.ts:760](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L760)

___

### insertBefore

▸ **insertBefore**(`referenceNode`): `this`

Inserts the element before the specified reference element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `referenceNode` | `HTMLElement` \| [`Fluent`](Fluent-1.md)\<`HTMLElement`\> | The reference element to insert before. It can be an HTMLElement object or another Fluent object. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[../base/dist/index.d.ts:767](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L767)

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

[../base/dist/index.d.ts:825](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L825)

___

### nextSibling

▸ **nextSibling**(`selector?`): [`Fluent`](Fluent-1.md)\<`any`\>

Gets the next sibling element that matches the specified selector, or the first sibling if no selector is provided..

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selector?` | `string` | Optional. A CSS selector to filter the next sibling. |

#### Returns

[`Fluent`](Fluent-1.md)\<`any`\>

A Fluent object representing the next sibling element.

#### Defined in

[../base/dist/index.d.ts:832](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L832)

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

[../base/dist/index.d.ts:793](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L793)

▸ **off**(`type`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `string` |

#### Returns

`this`

#### Defined in

[../base/dist/index.d.ts:794](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L794)

▸ **off**(`type`, `listener`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `string` |
| `listener` | `EventListener` |

#### Returns

`this`

#### Defined in

[../base/dist/index.d.ts:795](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L795)

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

[../base/dist/index.d.ts:796](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L796)

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

[../base/dist/index.d.ts:805](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L805)

▸ **on**(`type`, `listener`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `string` |
| `listener` | `EventListener` |

#### Returns

`this`

#### Defined in

[../base/dist/index.d.ts:806](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L806)

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

[../base/dist/index.d.ts:807](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L807)

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

[../base/dist/index.d.ts:816](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L816)

▸ **one**(`type`, `listener`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `type` | `string` |
| `listener` | `EventListener` |

#### Returns

`this`

#### Defined in

[../base/dist/index.d.ts:817](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L817)

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

[../base/dist/index.d.ts:818](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L818)

___

### parent

▸ **parent**(): [`Fluent`](Fluent-1.md)\<`HTMLElement`\>

Gets the parent element of the element.

#### Returns

[`Fluent`](Fluent-1.md)\<`HTMLElement`\>

A Fluent object representing the parent element.

#### Defined in

[../base/dist/index.d.ts:838](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L838)

___

### prepend

▸ **prepend**(`child`): `this`

Prepends content to the element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `child` | `string` \| `Node` \| [`Fluent`](Fluent-1.md)\<`any`\> | The content to prepend. It can be a string, a Node object, or another Fluent object. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[../base/dist/index.d.ts:845](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L845)

___

### prependTo

▸ **prependTo**(`parent`): `this`

Prepends the element to the specified parent element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `parent` | `Element` \| [`Fluent`](Fluent-1.md)\<`any`\> | The parent element to prepend to. It can be an Element object or another Fluent object. |

#### Returns

`this`

The Fluent object itself.

#### Defined in

[../base/dist/index.d.ts:852](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L852)

___

### prevSibling

▸ **prevSibling**(`selector?`): [`Fluent`](Fluent-1.md)\<`any`\>

Gets the previous sibling element that matches the specified selector, or the first sibling if no selector is provided.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `selector?` | `string` | Optional. A CSS selector to filter the previous sibling. |

#### Returns

[`Fluent`](Fluent-1.md)\<`any`\>

A Fluent object representing the previous sibling element.

#### Defined in

[../base/dist/index.d.ts:859](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L859)

___

### remove

▸ **remove**(): `this`

Removes the element from the DOM. It also removes event handlers and disposes widgets by calling "remove" event handlers.

#### Returns

`this`

The Fluent object itself.

#### Defined in

[../base/dist/index.d.ts:865](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L865)

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

[../base/dist/index.d.ts:872](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L872)

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

[../base/dist/index.d.ts:879](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L879)

___

### show

▸ **show**(): `this`

Shows the element by setting its display property to empty string.

#### Returns

`this`

The Fluent object itself.

#### Defined in

[../base/dist/index.d.ts:885](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L885)

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

[../base/dist/index.d.ts:892](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L892)

___

### text

▸ **text**(): `string`

Gets or sets the text content of the element.

#### Returns

`string`

The text content of the element if no value is provided, or the Fluent object itself if a value is provided.

#### Defined in

[../base/dist/index.d.ts:898](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L898)

▸ **text**(`value`): `this`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `string` |

#### Returns

`this`

#### Defined in

[../base/dist/index.d.ts:899](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L899)

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

[../base/dist/index.d.ts:906](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L906)

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

[../base/dist/index.d.ts:913](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L913)

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

[../base/dist/index.d.ts:921](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L921)

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

[../base/dist/index.d.ts:929](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L929)

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

[../base/dist/index.d.ts:938](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L938)

▸ **val**(): `string`

#### Returns

`string`

#### Defined in

[../base/dist/index.d.ts:939](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L939)
