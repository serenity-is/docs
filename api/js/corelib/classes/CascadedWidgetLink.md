[serenity-is/corelib](../README.md) / CascadedWidgetLink

# Class: CascadedWidgetLink\<TParent\>

Defined in: [src/ui/editors/cascadedwidgetlink.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L7)

## Type Parameters

### TParent

`TParent` *extends* [`Widget`](Widget.md)\<`any`\>

## Constructors

### Constructor

> **new CascadedWidgetLink**\<`TParent`\>(`parentType`, `widget`, `parentChange`): `CascadedWidgetLink`\<`TParent`\>

Defined in: [src/ui/editors/cascadedwidgetlink.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L11)

#### Parameters

##### parentType

(...`args`) => `TParent`

##### widget

[`Widget`](Widget.md)\<`any`\>

##### parentChange

(`p1`) => `void`

#### Returns

`CascadedWidgetLink`\<`TParent`\>

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/editors/cascadedwidgetlink.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L9)

## Methods

### bind()

> **bind**(): `TParent`

Defined in: [src/ui/editors/cascadedwidgetlink.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L24)

#### Returns

`TParent`

***

### get\_parentID()

> **get\_parentID**(): `string`

Defined in: [src/ui/editors/cascadedwidgetlink.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L59)

#### Returns

`string`

***

### set\_parentID()

> **set\_parentID**(`value`): `void`

Defined in: [src/ui/editors/cascadedwidgetlink.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L63)

#### Parameters

##### value

`string`

#### Returns

`void`

***

### unbind()

> **unbind**(): `TParent`

Defined in: [src/ui/editors/cascadedwidgetlink.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L44)

#### Returns

`TParent`
