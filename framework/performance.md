# Performance

This page collects performance guidance for Serenity client-side code: debouncing, lazy loading, lookup caching, and large-grid considerations.

## Debouncing

`debounce(func, wait, immediate?)` delays invoking a function until after `wait` ms have elapsed since the last call. This is useful for expensive operations triggered by frequent events (typing, resizing, scrolling):

```ts
import { debounce } from "@serenity-is/corelib";

const onResize = debounce(() => layout(), 150);
window.addEventListener("resize", onResize);
```

The debounced function exposes helpers:

- `clear()` — cancels a pending invocation.
- `flush()` — runs a pending invocation immediately.

```ts
const save = debounce(() => api.save(data), 500);
save();
save();
save.flush(); // runs now instead of waiting
```

With `immediate: true`, the function runs on the leading edge and subsequent calls within `wait` ms are ignored:

```ts
const track = debounce(() => analytics.send(), 200, true);
```

## Lazy Loading

`LazyLoadHelper` executes callbacks when an element becomes visible:

```ts
import { LazyLoadHelper } from "@serenity-is/corelib";

// Run once when the element becomes visible
LazyLoadHelper.executeOnceWhenShown(element, () => {
    // load expensive content
});

// Run every time the element becomes visible
LazyLoadHelper.executeEverytimeWhenShown(element, () => {
    // refresh content
});
```

This is useful for deferring expensive initialization until the user actually sees the content.

## Lookup Caching

Lookups are cached client-side. Use the async lookup helpers to avoid blocking the UI thread:

```ts
import { getLookupAsync } from "@serenity-is/corelib";

const lookup = await getLookupAsync("MyModule.MyLookup");
```

Lookups reload automatically when the server-side lookup script changes (via `reloadLookup`).

## Large Grids

SleekGrid renders only visible rows (virtual scrolling), so it handles large datasets efficiently. To keep grids fast:

- **Use server-side paging** — the `RemoteView` sends `Skip`/`Take` so only the current page is loaded.
- **Use quick filters and advanced filters** — they push filtering to the server.
- **Avoid expensive formatters** — keep cell formatters cheap; use `asyncPostRender` for expensive cell content.
- **Use `beginUpdate()`/`endUpdate()`** — batch multiple view changes into one refresh:

```ts
this.view.beginUpdate();
// make multiple changes
this.view.endUpdate(); // refreshes once
```

## Async Data Loading

Prefer the async variants of data-loading helpers to avoid blocking the UI thread:

- `getLookupAsync` instead of `getLookup`.
- `getColumnsDataAsync` instead of `getColumnsData`.
- `getFormDataAsync` instead of `getFormData`.
- `getRemoteDataAsync` instead of `getRemoteData`.

## See Also

- [debounce (API reference)](../api/js/corelib/functions/debounce.md) — the debounce helper.
- [LazyLoadHelper (API reference)](../api/js/corelib/@serenity-is/namespaces/LazyLoadHelper/README.md) — lazy loading helpers.
- [executeOnceWhenVisible (API reference)](../api/js/corelib/functions/executeOnceWhenVisible.md), [executeEverytimeWhenVisible (API reference)](../api/js/corelib/functions/executeEverytimeWhenVisible.md) — visibility callbacks.
- [RemoteView and Data Management](../grids/remoteview.md) — server-side paging and filtering.
- [Frontend Framework Overview](ui/readme.md) — the three client-side packages and how they fit together.