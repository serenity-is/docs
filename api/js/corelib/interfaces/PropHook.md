[@serenity-is/corelib](../README.md) / PropHook

# Interface: PropHook\<TNode\>

Defined in: [../domwise/dist/index.d.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L6)

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

Defined in: [../domwise/dist/index.d.ts:2759](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2759)

#### Parameters

##### node

`TNode`

##### propName

`string`

#### Returns

`void`
