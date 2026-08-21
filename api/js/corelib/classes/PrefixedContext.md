[@serenity-is/corelib](../README.md) / PrefixedContext

# Class: PrefixedContext

Defined in: [src/ui/widgets/prefixedcontext.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L9)

Provides a scoped context for resolving elements and widgets by an id prefix
within a given DOM node. Useful for panels and dialogs that need to look up
their child elements and widgets by short, prefix-relative ids.

## Constructors

### Constructor

> **new PrefixedContext**(`prefixOrWidget`, `context?`): `PrefixedContext`

Defined in: [src/ui/widgets/prefixedcontext.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L23)

Creates a new prefixed context.

#### Parameters

##### prefixOrWidget

Either a string id prefix, or an object exposing
  `idPrefix` and `domNode` (such as a widget) from which the prefix and
  context are derived.

`string` | \{ `domNode`: `HTMLElement`; `idPrefix`: `string`; \}

##### context?

`HTMLElement`

Optional DOM node to scope lookups to; defaults to the
  `domNode` of `prefixOrWidget` when an object is provided.

#### Returns

`PrefixedContext`

## Properties

### context

> `readonly` **context**: `HTMLElement`

Defined in: [src/ui/widgets/prefixedcontext.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L13)

The DOM node that acts as the scope for lookups.

***

### idPrefix

> `readonly` **idPrefix**: `string`

Defined in: [src/ui/widgets/prefixedcontext.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L11)

The id prefix used to resolve child element ids.

## Methods

### byId()

> **byId**(`id`): [`Fluent`](../interfaces/Fluent.md)

Defined in: [src/ui/widgets/prefixedcontext.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L45)

Resolves an element by its prefix-relative id.

#### Parameters

##### id

`string`

The id relative to the context's id prefix.

#### Returns

[`Fluent`](../interfaces/Fluent.md)

A [Fluent](../functions/Fluent.md) wrapper for the matching element, or an empty
  Fluent object if no element matches.

***

### initialize()

> `protected` **initialize**(): `void`

Defined in: [src/ui/widgets/prefixedcontext.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L36)

Hook for subclasses to perform additional initialization.

#### Returns

`void`

***

### w()

> **w**\<`TWidget`\>(`id`, `type`): `TWidget`

Defined in: [src/ui/widgets/prefixedcontext.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/widgets/prefixedcontext.ts#L55)

Resolves a widget by its prefix-relative id and expected type.

#### Type Parameters

##### TWidget

`TWidget`

#### Parameters

##### id

`string`

The id relative to the context's id prefix.

##### type

(...`args`) => `TWidget`

The widget type to look up.

#### Returns

`TWidget`

The matching widget instance.
