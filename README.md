Unleashed Api Bindings
============

API bindings for creating and reading resources in [Unleashed Inventory](http://www.unleashedsoftware.com/)

Authentication is made by signing requests with HMACSHA256 API key/secret available once signed in.

```cs
var client = new UnleashedClient("[ApiId]", "[ApiKey]");
foreach (var product in await client.Products.List())
{
    Console.WriteLine(product.ProductDescription);
}
```

[![Build status](https://ci.appveyor.com/api/projects/status/q2gba09neuqohprd)]
(https://ci.appveyor.com/project/ElijahGlover/unleashedapi)

```PowerShell
Add-Package UnleashedApi
```
https://www.nuget.org/packages/UnleashedApi/
