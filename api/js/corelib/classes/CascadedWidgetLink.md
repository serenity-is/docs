[@serenity-is/corelib](../README.md) / CascadedWidgetLink

# Class: CascadedWidgetLink\<TParent\>

## Type Parameters

• **TParent** *extends* [`Widget`](Widget.md)\<`any`\>

## Constructors

### new CascadedWidgetLink()

> **new CascadedWidgetLink**\<`TParent`\>(`parentType`, `widget`, `parentChange`): [`CascadedWidgetLink`](CascadedWidgetLink.md)\<`TParent`\>

#### Parameters

##### parentType

(...`args`) => `TParent`

##### widget

[`Widget`](Widget.md)\<`any`\>

##### parentChange

(`p1`) => `void`

#### Returns

[`CascadedWidgetLink`](CascadedWidgetLink.md)\<`TParent`\>

#### Defined in

[src/ui/editors/cascadedwidgetlink.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L10)

## Methods

### bind()

> **bind**(): `TParent`

#### Returns

`TParent`

#### Defined in

[src/ui/editors/cascadedwidgetlink.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L23)

***

### get\_parentID()

> **get\_parentID**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/editors/cascadedwidgetlink.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L58)

***

### set\_parentID()

> **set\_parentID**(`value`): `void`

#### Parameters

##### value

`string`

#### Returns

`void`

#### Defined in

[src/ui/editors/cascadedwidgetlink.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L62)

***

### unbind()

> **unbind**(): `TParent`

#### Returns

`TParent`

#### Defined in

[src/ui/editors/cascadedwidgetlink.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L43)
