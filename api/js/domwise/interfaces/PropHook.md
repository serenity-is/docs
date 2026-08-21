[@serenity-is/domwise](../README.md) / PropHook

# Interface: PropHook\<TNode\>

Defined in: [types/basic-types.d.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L7)

Base interface for JSX prop hooks. A prop hook is a callable object that can
be assigned as a value to a JSX attribute to reactively bind to an element.

## Extended by

- [`BasicClassList`](BasicClassList.md)
- [`PropBinding`](PropBinding.md)

## Type Parameters

### TNode

`TNode` *extends* `Element` = `Element`

The type of the DOM node the hook binds to.

## Methods

### \[initPropHookSymbol\]()

> **\[initPropHookSymbol\]**(`node`, `propName`): `void`

Defined in: [src/prop-hook.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/prop-hook.ts#L14)

#### Parameters

##### node

`TNode`

##### propName

`string`

#### Returns

`void`
