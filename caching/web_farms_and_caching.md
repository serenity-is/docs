# WEB Farms and Caching

Now let's consider we have a social networking site and have millions of user profiles. Profile pages of some famous users might be getting hundreds or thousands of visits per minute.

To generate a users profile, we would need more than one SQL query (friends, album names and picture counts, profile information, last status etc.).

As long as a user didn't update her profile, the information that is shown on her page would be almost stastic. Thus, a snapshot of profile pages could be cached for 5 minutes or 1 hour etc.

But this might not be enough. We are talking about hundres of millions of profiles and users. Users would be doing much more than just looking at some profile pages. We would need more than one server that are distributed in several geographical locations on earth (a WEB Farm).

At a certain time, all these servers might have cached a very important persons (VIP) profile in local cache. When the VIP makes a change in her profile, all these servers should renew their local cached profile, and this would happen in a few seconds. We now have a problem of load per server instead of load per user.

Actually, once one these of servers loaded the VIP profile from SQL database and cached it, other servers could make use of the same information without hitting database. But, as each server stores cached information in its own local memory, it is not trivial to access this information by other servers.

If we had a shared memory that all servers could access:

Information key          |Value
-------------------------|--------------------------------------
Profile:VeryFamousOne    |(Cached information for VeryFamousOne)
Profile:SomeAnother      |...
...                      |...
...                      |...
Profile:JohnDoe          |...

Let's call this memory the distributed cache. If all servers have a look at this common memory before trying DB we would avoid the load per server problem.


```cs
public CachedProfileInformation GetProfile(string profileID)
{
    var profile = HttpRuntime.Cache["Profil:" + profileID]
        as CachedProfileInformation;

    if (profile == null)
    {
        profile = DistributedCache.Get<CachedProfileInformation>(
            "Profil:" + profileID);

        if (profile == null)
        {
            using (var connection = new SqlConnection("......"))
            {
                profile = GetProfileFromDBWithSomeSQLQueries(profileID)
                    profile, TimeSpan.FromMinutes(5));

                DistributedCache.Set("Profil:" + profileID, profile,
	                TimeSpan.FromHours(1));
            }
        }
    }

    return news;
}
```

You can find many variations of distributed cache systems including Memcached, Couchbase and Redis. They are also called NoSQL database. You can think of them simply as a remote dictionary. They store key/value pairs in their memory and let you access them as fast as possible.

> Warning! When it is used properly, distributed cache can improve performance of your application, just like local cache. Otherwise it can have a worse effect than local cache as there is a network transfer and serialization cost involved. Thus "if we keep things in distributed cache our site will run faster" is a myth.

When the cached data becomes too much, one computer memory might be not enough to store all key/value pairs. In this case servers like memcached distribute data by clustering. This could be done by the first letter of keys. One server could hold pairs starting with A, other with B etc. In fact, they use hash of keys for this purpose.
