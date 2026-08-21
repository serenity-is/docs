[@serenity-is/domwise](../README.md) / useUpdatableComputed

# Function: useUpdatableComputed()

> **useUpdatableComputed**(): `object`

Defined in: [src/signals.ts:117](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/signals.ts#L117)

Creates a factory for computed signals that can be manually invalidated in batch.

Computed signals produced by the returned `computed` wrapper depend on an
internal `updater` signal; calling `update()` bumps that signal so every
derived computed re-evaluates on its next read, without wiring each one to
a separate source.

## Returns

`object`

An object with:
 - `computed` — factory that wraps a computation so it tracks the shared updater.
 - `update` — bumps the updater, invalidating all computeds created from this factory.

### computed()

> **computed**: \<`T`\>(`fn`) => [`Computed`](../interfaces/Computed.md)\<`T`\>

#### Type Parameters

##### T

`T`

#### Parameters

##### fn

() => `T`

#### Returns

[`Computed`](../interfaces/Computed.md)\<`T`\>

### update()

> **update**: () => `void`

#### Returns

`void`

## Example

```ts
const { computed: uc, update } = useUpdatableComputed();
const derived = uc(() => expensiveRead());
// later: after external state changes
update();
```
