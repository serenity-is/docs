[@serenity-is/corelib](../README.md) / Fluent

# Namespace: Fluent

## Table of contents

### Variables

- [inputLikeSelector](Fluent.md#inputlikeselector)

### Functions

- [addClass](Fluent.md#addclass)
- [byId](Fluent.md#byid)
- [empty](Fluent.md#empty)
- [eventProp](Fluent.md#eventprop)
- [findAll](Fluent.md#findall)
- [findEach](Fluent.md#findeach)
- [findFirst](Fluent.md#findfirst)
- [isDefaultPrevented](Fluent.md#isdefaultprevented)
- [isInputLike](Fluent.md#isinputlike)
- [isInputTag](Fluent.md#isinputtag)
- [isVisibleLike](Fluent.md#isvisiblelike)
- [off](Fluent.md#off)
- [on](Fluent.md#on)
- [one](Fluent.md#one)
- [ready](Fluent.md#ready)
- [remove](Fluent.md#remove)
- [removeClass](Fluent.md#removeclass)
- [toClassName](Fluent.md#toclassname)
- [toggle](Fluent.md#toggle)
- [toggleClass](Fluent.md#toggleclass)
- [trigger](Fluent.md#trigger)

## Variables

### inputLikeSelector

• `Const` **inputLikeSelector**: ``"input,select,textarea,button"``

A CSS selector for input like tags

#### Defined in

[../base/dist/index.d.ts:1051](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1051)

## Functions

### addClass

▸ **addClass**(`element`, `value`): `void`

Adds one or more classes to the element. Any falsy value is ignored.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `element` | `Element` | The target element |
| `value` | `string` \| `boolean` \| (`string` \| `boolean`)[] | The class or classes to add. It can be a string, boolean, or an array of strings or booleans. |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1002](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1002)

___

### byId

▸ **byId**\<`TElement`\>(`id`): [`Fluent`](../interfaces/Fluent-1.md)\<`TElement`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TElement` | extends `HTMLElement` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `string` |

#### Returns

[`Fluent`](../interfaces/Fluent-1.md)\<`TElement`\>

#### Defined in

[../base/dist/index.d.ts:946](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L946)

___

### empty

▸ **empty**(`element`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `Element` |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1003](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1003)

___

### eventProp

▸ **eventProp**(`event`, `prop`): `any`

Tries to read a property from the event, or event.originalEvent, or event.detail. It is designed
for compatibility with the way jQuery wraps original event under originalEvent property, that
causes custom properties to be not available in the event object.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `event` | `any` | The event object |
| `prop` | `string` | The property name |

#### Returns

`any`

The property value

#### Defined in

[../base/dist/index.d.ts:1077](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1077)

___

### findAll

▸ **findAll**\<`TElement`\>(`selector`): `TElement`[]

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TElement` | extends `HTMLElement` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `selector` | `string` |

#### Returns

`TElement`[]

#### Defined in

[../base/dist/index.d.ts:947](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L947)

___

### findEach

▸ **findEach**\<`TElement`\>(`selector`, `callback`): `void`

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TElement` | extends `HTMLElement` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `selector` | `string` |
| `callback` | (`el`: [`Fluent`](../interfaces/Fluent-1.md)\<`TElement`\>) => `void` |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:948](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L948)

___

### findFirst

▸ **findFirst**\<`TElement`\>(`selector`): [`Fluent`](../interfaces/Fluent-1.md)\<`TElement`\>

#### Type parameters

| Name | Type |
| :------ | :------ |
| `TElement` | extends `HTMLElement` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `selector` | `string` |

#### Returns

[`Fluent`](../interfaces/Fluent-1.md)\<`TElement`\>

#### Defined in

[../base/dist/index.d.ts:949](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L949)

___

### isDefaultPrevented

▸ **isDefaultPrevented**(`event`): `boolean`

Checks if the event's preventDefault method is called. This is for compatibility with jQuery which
has a non-standard isDefaultPrevented method.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `event` | `Object` | The event object |
| `event.defaultPrevented?` | `boolean` | - |
| `event.isDefaultPrevented?` | () => `boolean` | - |

#### Returns

`boolean`

True if preventDefault is called.

#### Defined in

[../base/dist/index.d.ts:1064](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1064)

___

### isInputLike

▸ **isInputLike**(`element`): element is HTMLSelectElement \| HTMLInputElement \| HTMLButtonElement \| HTMLTextAreaElement

Returns true if the element is input like. E.g. one of input, textarea, select, button. This is for compatibility with jQuery's :input selector.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `element` | `Element` | The target element |

#### Returns

element is HTMLSelectElement \| HTMLInputElement \| HTMLButtonElement \| HTMLTextAreaElement

true if element is an input like node

#### Defined in

[../base/dist/index.d.ts:1049](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1049)

___

### isInputTag

▸ **isInputTag**(`tag`): `boolean`

Returns true if the tag is one of input, textarea, select, button.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `tag` | `string` | The tag |

#### Returns

`boolean`

true if the element has offsetWidth or offsetHeight or any getClientRects().length > 0

#### Defined in

[../base/dist/index.d.ts:1057](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1057)

___

### isVisibleLike

▸ **isVisibleLike**(`element`): `boolean`

Returns true if the element is visible like. This is for compatibility with jQuery's :visible selector.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `element` | `Element` | The target element |

#### Returns

`boolean`

true if the element has offsetWidth or offsetHeight or any getClientRects().length > 0

#### Defined in

[../base/dist/index.d.ts:1009](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1009)

___

### off

▸ **off**\<`K`\>(`element`, `type`, `listener?`): `void`

Removes an event listener from the element.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `K` | extends keyof `HTMLElementEventMap` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `element` | `EventTarget` | The target element |
| `type` | `K` | The type of the event. It can include a ".namespace" similar to jQuery. |
| `listener?` | (`this`: `HTMLElement`, `ev`: `HTMLElementEventMap`[`K`]) => `any` | The event listener to remove. |

#### Returns

`void`

**`Typeparam`**

K The type of the event.

#### Defined in

[../base/dist/index.d.ts:982](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L982)

▸ **off**(`element`, `type`, `listener?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `EventTarget` |
| `type` | `string` |
| `listener?` | `EventListener` |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:983](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L983)

▸ **off**(`element`, `type`, `selector?`, `delegationHandler?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `EventTarget` |
| `type` | `string` |
| `selector?` | `string` |
| `delegationHandler?` | `Function` |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:984](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L984)

___

### on

▸ **on**\<`K`\>(`element`, `type`, `listener`): `void`

Adds an event listener to the element. It is possible to use delegated events like jQuery.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `K` | extends keyof `HTMLElementEventMap` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `element` | `EventTarget` | The target element |
| `type` | `K` | The type of the event. It can include a ".namespace" similar to jQuery. |
| `listener` | (`this`: `HTMLElement`, `ev`: `HTMLElementEventMap`[`K`]) => `any` | The event listener to add. |

#### Returns

`void`

**`Typeparam`**

K The type of the event.

#### Defined in

[../base/dist/index.d.ts:960](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L960)

▸ **on**(`element`, `type`, `listener`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `EventTarget` |
| `type` | `string` |
| `listener` | `EventListener` |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:961](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L961)

▸ **on**(`element`, `type`, `selector`, `delegationHandler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `EventTarget` |
| `type` | `string` |
| `selector` | `string` |
| `delegationHandler` | `Function` |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:962](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L962)

___

### one

▸ **one**\<`K`\>(`element`, `type`, `listener`): `void`

Adds a one-time event listener to the element. It is possible to use delegated events like jQuery.

#### Type parameters

| Name | Type |
| :------ | :------ |
| `K` | extends keyof `HTMLElementEventMap` |

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `element` | `EventTarget` | The target element |
| `type` | `K` | The type of the event. It can include a ".namespace" similar to jQuery. |
| `listener` | (`this`: `HTMLElement`, `ev`: `HTMLElementEventMap`[`K`]) => `any` | The event listener to add. |

#### Returns

`void`

**`Typeparam`**

K The type of the event.

#### Defined in

[../base/dist/index.d.ts:971](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L971)

▸ **one**(`element`, `type`, `listener`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `EventTarget` |
| `type` | `string` |
| `listener` | `EventListener` |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:972](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L972)

▸ **one**(`element`, `type`, `selector`, `delegationHandler`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `element` | `EventTarget` |
| `type` | `string` |
| `selector` | `string` |
| `delegationHandler` | `Function` |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:973](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L973)

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

[../base/dist/index.d.ts:945](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L945)

___

### remove

▸ **remove**(`element`): `void`

Removes the element from the DOM. It also removes event handlers and disposes widgets by calling "remove" event handlers.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `element` | `Element` | The element to remove |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1015](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1015)

___

### removeClass

▸ **removeClass**(`element`, `value`): `void`

Removes one or more classes from the element. Any falsy value is ignored.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `element` | `Element` | The target element |
| `value` | `string` \| `boolean` \| (`string` \| `boolean`)[] | The class or classes to remove. It can be a string, boolean, or an array of strings or booleans. |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1022](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1022)

___

### toClassName

▸ **toClassName**(`value`): `string`

Converts the given class value or an array of class values to a CSS class name. Any falsy value is ignored.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `value` | `string` \| `boolean` \| (`string` \| `boolean`)[] | The class or classes. It can be a string, boolean, or an array of strings or booleans. |

#### Returns

`string`

Class name string

#### Defined in

[../base/dist/index.d.ts:1043](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1043)

___

### toggle

▸ **toggle**(`element`, `flag?`): `void`

Toggles the visibility of the element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `element` | `Element` | The target element |
| `flag?` | `boolean` | Optional. A flag indicating whether to show or hide the element. If not provided, the visibility will be toggled. |

#### Returns

`void`

The Fluent object itself.

#### Defined in

[../base/dist/index.d.ts:1030](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1030)

___

### toggleClass

▸ **toggleClass**(`element`, `value`, `add?`): `void`

Toggles one or more classes on the element. If the class exists, it is removed; otherwise, it is added. Falsy values are ignored.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `element` | `Element` | The target element |
| `value` | `string` \| `boolean` \| (`string` \| `boolean`)[] | The class or classes to toggle. It can be a string, boolean, or an array of strings or booleans. |
| `add?` | `boolean` | - |

#### Returns

`void`

#### Defined in

[../base/dist/index.d.ts:1037](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1037)

___

### trigger

▸ **trigger**(`element`, `type`, `args?`): `Event` & \{ `isDefaultPrevented?`: () => `boolean`  }

Triggers a specified event on the element.

#### Parameters

| Name | Type | Description |
| :------ | :------ | :------ |
| `element` | `EventTarget` | The target element |
| `type` | `string` | The type of the event to trigger. |
| `args?` | `any` | Optional. An object that specifies event-specific initialization properties. |

#### Returns

`Event` & \{ `isDefaultPrevented?`: () => `boolean`  }

The event object. Use Fluent.isDefaultPrevented the check if preventDefault is called.

#### Defined in

[../base/dist/index.d.ts:993](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L993)
