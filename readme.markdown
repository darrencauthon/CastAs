# CastAs

Here's code that I hate:

```c#
var viewName = ((ViewResult)actionResult).ViewName;
```

I have two problems with this code:

1. The code doesn't read left-to-right.  I have to start in the middle, look left to see what it's being cast as, and then further right to access the cast.
2. Awkward parentheses.  

This library contains one thing:  a tiny static extension method on Object that lets me do this:

```c#
var viewName = actionResult.CastAs<ViewResult>().ViewName;
```

It's very minor, I know.  But it helps me, especially when testing.

I also do a lot of MVC work, and this lets me test like this:

```c#
actionResult.CastAs<ViewResult>()
   .Model.CastAs<MyViewModel>()
   .LastName.ShouldEqual("Galt");
```