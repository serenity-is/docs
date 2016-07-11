# 用户简介（User Profile）缓存示例

假设我们网站有一个使用多个查询生成的简介页面。我们有此页的模型，如 UserProfile 类，它包含用户所有简介数据，及一个获取指定用户 id 简介的 GetProfile 方法。

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

通过使用 LocalCache.Get 方法，我们可以轻松地缓存此信息一小时，并避免每次请求该信息时对数据库进行调用。

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
