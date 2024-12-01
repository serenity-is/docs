[@serenity-is/corelib](../README.md) / QuickFilter

# Interface: QuickFilter\<TWidget, P\>

## Type Parameters

• **TWidget** *extends* [`Widget`](../classes/Widget.md)\<`P`\>

• **P**

## Properties

### cssClass?

> `optional` **cssClass**: `string`

#### Defined in

[src/ui/datagrid/quickfilter.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L23)

***

### displayText()?

> `optional` **displayText**: (`w`, `label`) => `string`

#### Parameters

##### w

`TWidget`

##### label

`string`

#### Returns

`string`

#### Defined in

[src/ui/datagrid/quickfilter.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L26)

***

### element()?

> `optional` **element**: (`e`) => `void`

#### Parameters

##### e

[`Fluent`](Fluent.md)\<`HTMLElement`\>

#### Returns

`void`

#### Defined in

[src/ui/datagrid/quickfilter.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L20)

***

### field?

> `optional` **field**: `string`

#### Defined in

[src/ui/datagrid/quickfilter.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L15)

***

### handler()?

> `optional` **handler**: (`h`) => `void`

#### Parameters

##### h

[`QuickFilterArgs`](QuickFilterArgs.md)\<`TWidget`\>

#### Returns

`void`

#### Defined in

[src/ui/datagrid/quickfilter.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L17)

***

### init()?

> `optional` **init**: (`w`) => `void`

#### Parameters

##### w

`TWidget`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/quickfilter.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L21)

***

### loadState()?

> `optional` **loadState**: (`w`, `state`) => `void`

#### Parameters

##### w

`TWidget`

##### state

`any`

#### Returns

`void`

#### Defined in

[src/ui/datagrid/quickfilter.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L24)

***

### options?

> `optional` **options**: `P` & `object`

#### Type declaration

##### class?

> `optional` **class**: `string`

##### element?

> `optional` **element**: `string` \| `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> \| (`el`) => `void`

##### id?

> `optional` **id**: `string`

#### Defined in

[src/ui/datagrid/quickfilter.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L19)

***

### saveState()?

> `optional` **saveState**: (`w`) => `any`

#### Parameters

##### w

`TWidget`

#### Returns

`any`

#### Defined in

[src/ui/datagrid/quickfilter.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L25)

***

### separator?

> `optional` **separator**: `boolean`

#### Defined in

[src/ui/datagrid/quickfilter.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L22)

***

### title?

> `optional` **title**: `string`

#### Defined in

[src/ui/datagrid/quickfilter.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L18)

***

### type()?

> `optional` **type**: (`options`?) => `TWidget`

#### Parameters

##### options?

`P`

#### Returns

`TWidget`

#### prototype

> **prototype**: `TWidget`

#### Defined in

[src/ui/datagrid/quickfilter.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L16)
