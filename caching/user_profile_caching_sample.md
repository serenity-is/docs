# User Profile Caching Sample

Lets assume we have a profile page in our site that is generated using several queries. We might have a model for this page e.g. UserProfile class that contains all profile data for a user, and a GetProfile method that produces this for a particular user id.

```cs
public class UserProfile
{
	public string Name { get; set; }
	public List<CachedFriend> Friends { get; set; }
	public List<CachedAlbum> Albums { get; set; }
	...
}
```

```cs
public UserProfile GetProfile(int userID)
{
	using (var connection = new SqlConnection("..."))
	{
        // load profile by userID from DB
    }
}
```

By making use of LocalCache.Get method, we could cache this information for one hour easily and avoid DB calls every time this information is needed.

```cs
public UserProfile GetProfile(int userID)
{
	return LocalCache.Get<UserProfile>(
		cacheKey: "UserProfile:" + userID,
		expiration: TimeSpan.FromHours(1),
		loader: delegate {
			using (var connection = new SqlConnection("..."))
			{
				// load profile by userID from DB
			}
		}
	);
}
```
