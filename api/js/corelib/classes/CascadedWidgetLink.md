[@serenity-is/corelib](../README.md) / CascadedWidgetLink

# Class: CascadedWidgetLink\<TParent\>

Defined in: [src/ui/editors/cascadedwidgetlink.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L12)

Links a widget to a parent widget so that it reacts to the parent's changes,
typically used for cascading select editors.

## Type Parameters

### TParent

`TParent` *extends* [`Widget`](Widget.md)\<`any`\>

The parent widget type.

## Constructors

### Constructor

> **new CascadedWidgetLink**\<`TParent`\>(`parentType`, `widget`, `parentChange`): `CascadedWidgetLink`\<`TParent`\>

Defined in: [src/ui/editors/cascadedwidgetlink.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L22)

Creates a cascaded widget link.

#### Parameters

##### parentType

(...`args`) => `TParent`

Constructor of the parent widget type.

##### widget

[`Widget`](Widget.md)\<`any`\>

The child widget to link.

##### parentChange

(`p1`) => `void`

Callback invoked when the parent changes.

#### Returns

`CascadedWidgetLink`\<`TParent`\>

## Properties

### \[typeInfo\]

> `static` **\[typeInfo\]**: [`ClassTypeInfo`](../type-aliases/ClassTypeInfo.md)\<`"Serenity."`\>

Defined in: [src/ui/editors/cascadedwidgetlink.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L14)

## Methods

### bind()

> **bind**(): `TParent`

Defined in: [src/ui/editors/cascadedwidgetlink.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L39)

Binds the link to the parent widget and subscribes to its change event.

#### Returns

`TParent`

The parent widget, or null if not found.

***

### get\_parentID()

> **get\_parentID**(): `string`

Defined in: [src/ui/editors/cascadedwidgetlink.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L86)

Returns the parent element id.

#### Returns

`string`

The parent id.

***

### set\_parentID()

> **set\_parentID**(`value`): `void`

Defined in: [src/ui/editors/cascadedwidgetlink.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L94)

Sets the parent element id and rebinds the link.

#### Parameters

##### value

`string`

The parent id.

#### Returns

`void`

***

### unbind()

> **unbind**(): `HTMLElement`

Defined in: [src/ui/editors/cascadedwidgetlink.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/cascadedwidgetlink.ts#L64)

Unbinds the link from the parent widget.

#### Returns

`HTMLElement`

The parent node, or null.
