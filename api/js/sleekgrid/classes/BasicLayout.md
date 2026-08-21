[@serenity-is/sleekgrid](../README.md) / BasicLayout

# Class: BasicLayout

Defined in: [src/layouts/basic-layout.tsx:10](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/basic-layout.tsx#L10)

Default single-pane layout. Renders header, header row, top panel, body
viewport and footer row in the main band without pinning or frozen panes.

## Implements

- [`LayoutEngine`](../interfaces/LayoutEngine.md)

## Constructors

### Constructor

> **new BasicLayout**(): `BasicLayout`

#### Returns

`BasicLayout`

## Properties

### host

> `protected` **host**: [`LayoutHost`](../interfaces/LayoutHost.md)

Defined in: [src/layouts/basic-layout.tsx:12](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/basic-layout.tsx#L12)

Host provided during [BasicLayout.init](#init).

***

### layoutName

> `readonly` **layoutName**: `"BasicLayout"` = `"BasicLayout"`

Defined in: [src/layouts/basic-layout.tsx:48](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/basic-layout.tsx#L48)

Layout identifier.

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`layoutName`](../interfaces/LayoutEngine.md#layoutname)

***

### refs

> `protected` **refs**: [`GridLayoutRefs`](../type-aliases/GridLayoutRefs.md)

Defined in: [src/layouts/basic-layout.tsx:14](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/basic-layout.tsx#L14)

Refs snapshot provided during [BasicLayout.init](#init).

## Methods

### afterSetOptions()

> **afterSetOptions**(): `void`

Defined in: [src/layouts/basic-layout.tsx:45](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/basic-layout.tsx#L45)

No-op for the basic layout; options require no layout-specific handling.

#### Returns

`void`

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`afterSetOptions`](../interfaces/LayoutEngine.md#aftersetoptions)

***

### destroy()

> **destroy**(): `void`

Defined in: [src/layouts/basic-layout.tsx:38](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/basic-layout.tsx#L38)

Clears host and refs references.

#### Returns

`void`

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`destroy`](../interfaces/LayoutEngine.md#destroy)

***

### init()

> **init**(`host`): `void`

Defined in: [src/layouts/basic-layout.tsx:20](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/basic-layout.tsx#L20)

Builds the basic layout DOM inside `host.getContainerNode()`.

#### Parameters

##### host

[`LayoutHost`](../interfaces/LayoutHost.md)

Layout host.

#### Returns

`void`

#### Implementation of

[`LayoutEngine`](../interfaces/LayoutEngine.md).[`init`](../interfaces/LayoutEngine.md#init)
