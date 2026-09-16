[@serenity-is/sleekgrid](../README.md) / createGridSignalsAndRefs

# Type Alias: createGridSignalsAndRefs()

> **createGridSignalsAndRefs** = () => `object`

Defined in: [src/layouts/layout-refs.tsx:210](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/layouts/layout-refs.tsx#L210)

Factory for the reactive signals and derived layout refs that drive pinning and frozen rows.
Generates computed visibility signals, bounded pinning/frozen counters and live getters/setters on `refs.config`.

## Returns

`object`

Object containing `signals` and `refs` wired for mutual recalculation.

### refs

> **refs**: [`GridLayoutRefs`](GridLayoutRefs.md)

### signals

> **signals**: [`GridSignals`](../interfaces/GridSignals.md)
