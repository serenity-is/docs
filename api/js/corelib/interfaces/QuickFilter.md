[serenity-is/corelib](../README.md) / QuickFilter

# Interface: QuickFilter\<TWidget, P\>

Defined in: [src/ui/datagrid/quickfilter.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L14)

## Type Parameters

### TWidget

`TWidget` *extends* [`Widget`](../classes/Widget.md)\<`P`\>

### P

`P`

## Properties

### cssClass?

> `optional` **cssClass**: `string`

Defined in: [src/ui/datagrid/quickfilter.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L23)

***

### displayText()?

> `optional` **displayText**: (`w`, `label`) => `string`

Defined in: [src/ui/datagrid/quickfilter.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L26)

#### Parameters

##### w

`TWidget`

##### label

`string`

#### Returns

`string`

***

### element()?

> `optional` **element**: (`e`) => `void`

Defined in: [src/ui/datagrid/quickfilter.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L20)

#### Parameters

##### e

[`Fluent`](Fluent.md)

#### Returns

`void`

***

### field?

> `optional` **field**: `string`

Defined in: [src/ui/datagrid/quickfilter.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L15)

***

### handler()?

> `optional` **handler**: (`h`) => `void`

Defined in: [src/ui/datagrid/quickfilter.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L17)

#### Parameters

##### h

[`QuickFilterArgs`](QuickFilterArgs.md)\<`TWidget`\>

#### Returns

`void`

***

### init()?

> `optional` **init**: (`w`) => `void`

Defined in: [src/ui/datagrid/quickfilter.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L21)

#### Parameters

##### w

`TWidget`

#### Returns

`void`

***

### loadState()?

> `optional` **loadState**: (`w`, `state`) => `void`

Defined in: [src/ui/datagrid/quickfilter.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L24)

#### Parameters

##### w

`TWidget`

##### state

`any`

#### Returns

`void`

***

### options?

> `optional` **options**: `P` & `object`

Defined in: [src/ui/datagrid/quickfilter.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L19)

#### Type Declaration

##### class?

> `optional` **class**: `string`

##### element?

> `optional` **element**: `string` \| `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> \| (`el`) => `void`

##### id?

> `optional` **id**: `string`

***

### saveState()?

> `optional` **saveState**: (`w`) => `any`

Defined in: [src/ui/datagrid/quickfilter.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L25)

#### Parameters

##### w

`TWidget`

#### Returns

`any`

***

### separator?

> `optional` **separator**: `boolean`

Defined in: [src/ui/datagrid/quickfilter.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L22)

***

### title?

> `optional` **title**: `string`

Defined in: [src/ui/datagrid/quickfilter.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L18)

***

### type?

> `optional` **type**: \{(`options?`): `TWidget`; `prototype`: `TWidget`; \}

Defined in: [src/ui/datagrid/quickfilter.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/quickfilter.ts#L16)

#### Parameters

##### options?

`P`

#### Returns

`TWidget`

#### prototype

> **prototype**: `TWidget`
