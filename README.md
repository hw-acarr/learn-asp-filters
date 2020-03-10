Experiments with using ASP.net Filters
======================================

Nothing fancy, just playing with the Filters.

Use `ctrl-F5` in VS Code to execute the project.
Hit `https://localhost:5001/WeatherForecast` with a GET request to trigger the logic.
See the Debug Conole for the messages.

Lifecycle discovered:

```
Entering AnotherCustomActionFilterAttribute#OnActionExecuted    200
    Entering CustomActionFilterAttribute#OnActionExecuted           200
    Leaving CustomActionFilterAttribute#OnActionExecuted            200
Leaving AnotherCustomActionFilterAttribute#OnActionExecuted     200
Entering CustomResultFilterAttribute#OnResultExecuting          200
    Entering AnotherCustomActionFilterAttribute#OnResultExecuting   200
        Entering CustomActionFilterAttribute#OnResultExecuting          200
        **Actual METHOD CALL here**
        Leaving CustomActionFilterAttribute#OnResultExecuted            400
    Leaving AnotherCustomActionFilterAttribute#OnResultExecuted     400
Leaving CustomResultFilterAttribute#OnResultExecuted            400
```

Notes:

Not sure why the status code doesn't flip until the `OnResultExecuted` methods are starting to be called. I was expecting the result to occur _before_ the `OnResult*` calls were made.