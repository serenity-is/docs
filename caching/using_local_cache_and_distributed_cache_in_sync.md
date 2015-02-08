# Using Local Cache and Distributed Cache in Sync

We might enjoy the best of both worlds by following a simple algorithm:

1. Check for key in local cache.
2. If key exists in local cache return its value.
3. If key doesn't exist in local cache, try distributed cache.
4. If key exists in distributed cache return its value and add it to local cache too.
5. If key doesn't exist in distributed cache, produce it from database, add it to both local cache and distributed cache. Return the produced value.

This way, when a server caches some information in local cache, it also caches it in distributed cache, but this time other servers can re-use information in distributed cache if they don't have a local copy in memory.

Once all servers have a local copy, none of them will need to access distributed cache again, thus, avoiding serialization and latency overhead.

## Validating Local Copies

All looks fine. But now we have a cache invalidation problem. What if in one of the servers cached data is changed. How do we notify them of this change, so that they can invalidate their *locally cached copy*?

We would change the value in distributed cache, but as they don't check distributed cache anymore (shortcut from step 2 in last algorithm), they wouldn't be noticed.

One solution to this problem would be to keep local copies for a certain time, e.g. 5 secs. Thus, when a server changes a cached data, other servers would use out-of-date information for 5 seconds mostly.

This method would help with batch operations that needs same cached information repeatedly. But even if nothing changed in distributed cache, we would have to get a copy from distributed cache to local cache every 5 seconds. If cached data is big, this would increase network bandwidth usage and deserialization cost.

We need a way to know if the data in distributed cache is different from the local copy. There are several ways of it that i can imagine:

- Store hash alongside data in local and distributed cache (slight hash calculation cost)
- Store an incrementing version number of data (how to make sure that two servers doesn't generate same version numbers?)
- Store last time data is set in distributed cache (time sync problems)
- Store a random number (generation) alongside data

Serenity uses generation numbers (random int) as version.

So when we store a value in distributed cache, let's say *SomeCachedKey*, we also store a random number with key *SomeCachedKey$GENERATION$*.

Now our prior algorithm becomes this:

1. Check for key in local cache.
2. If key exists in local cache
    - Compare its generation with one in distributed cache
    - If they are equal, return local cached value
    - If they don't match, continue to 4
3. If key doesn't exist in local cache, try distributed cache.
4. If key exists in distributed cache return its value and add it to local cache too, alongside its generation.
5. If key doesn't exist in distributed cache, generate it from database, add it to both local cache and distributed cache with some random generation. Return the produced value.

## Validating Multiple Cached Items In One Shot

You might have cached data produced from some table. There might be more than one key in distributed cache for this table.

Lets say you have a profile table and cached profile items by their User ID values.

When a user's profile information changes, you may try to remove its cached profile from cache. But what if another server or application you don't know about, cached some information that is generated from same user profile data? You may not know what cached information keys exist in distributed cache that depends on some user ID.

Most distributed cache implementations don't provide a way to find all keys that start with some string or it is computationally intensive (as they are dictionary based).

So when you want to expire all items depending on some set of data, it might not be feasible.

While caching items, Serenity allows you to specify a group key, which is used to expire them, when the data that the group depends on changes.

Let's say one application produced *CachedItem17* from a user with ID 17's profile data and we use this ID as a group key (Group17_Generation):

Key                     |Value
------------------------|-----
CachedItem17            |cxyzyxzcasd
CachedItem17_Generation |13579
Group17_Generation      |13579

Here, random generation (version) for the group is 13579. Along with cached data (CachedItem17), we stored whatever was the group generation when we produced this data (CachedItem17_Generation).

Suppose that another server, cached AnotherItem17 from User 17's data:

Key                     |Value
------------------------|-----
CachedItem17            |cxyzyxzcasd
CachedItem17_Generation |13579
AnotherItem17           |uwsdasdas
AnotherItem17_Generation|13579
Group17_Generation      |13579

Here, we reused Group17_Generation, as there was already a group version number in distributed cache, otherwise we would have to generate a new one.

Now, both items in cache (CachedItem17 and AnotherItem17) are valid, because their version numbers matches the group version.

If somebody changed User 17's data and we wanted to expire all cached items related to her, we need to just change the group generation:

Key                     |Value
------------------------|-----
CachedItem17            |cxyzyxzcasd
CachedItem17_Generation |13579
AnotherItem17           |uwsdasdas
AnotherItem17_Generation|13579
Group17_Generation      |54237

Now all cached items are expired. Even though they exist in cache, we see that their generations don't match the group generation, so they are not considered valid.

> Group keys we use are usually name of the table that data is produced from.
