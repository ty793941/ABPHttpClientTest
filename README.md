# Introduction
It's a problem project for httpClientFactory with Middleware .

# Steps
1.Open the Project with sln file which in **5.7.0/aspnet-core/ABPTest.sln**.
2.F5 and deubugger the project.
3.Set the breakpoint in TestClientMiddelware.cs file  at line 12.
4.In the browser or postman input the url:http://localhost:21021/HOME/testhttpclient ,and visit it.
4.You will see the first visit,the project can return correct response,But when the second visit the same url the project will throw an exception with  **Cannot access a disposed object.**

## the exception detail is
```INFO  2020-08-15 20:50:43,076 [12   ] .Mvc.Infrastructure.ObjectResultExecutor - Executing ObjectResult, writing value of type 'Abp.Web.Models.AjaxResponse'.
INFO  2020-08-15 20:50:43,086 [12   ] c.Infrastructure.ControllerActionInvoker - Executed action ABPTest.Web.Host.Controllers.HomeController.TestHttpClient (ABPTest.Web.Host) in 2058.5657ms
INFO  2020-08-15 20:50:43,089 [12   ] ft.AspNetCore.Routing.EndpointMiddleware - Executed endpoint 'ABPTest.Web.Host.Controllers.HomeController.TestHttpClient (ABPTest.Web.Host)'
INFO  2020-08-15 20:50:43,093 [12   ] Microsoft.AspNetCore.Hosting.Diagnostics - Request finished in 2079.4088ms 500 application/json; charset=utf-8
INFO  2020-08-15 20:51:01,396 [17   ] Microsoft.AspNetCore.Hosting.Diagnostics - Request starting HTTP/1.1 GET http://localhost:21021/HOME/testhttpclient  
INFO  2020-08-15 20:51:01,400 [17   ] ft.AspNetCore.Routing.EndpointMiddleware - Executing endpoint 'ABPTest.Web.Host.Controllers.HomeController.TestHttpClient (ABPTest.Web.Host)'
INFO  2020-08-15 20:51:01,404 [17   ] c.Infrastructure.ControllerActionInvoker - Route matched with {action = "TestHttpClient", controller = "Home", area = ""}. Executing controller action with signature System.Threading.Tasks.Task`1[System.String] TestHttpClient() on controller ABPTest.Web.Host.Controllers.HomeController (ABPTest.Web.Host).
INFO  2020-08-15 20:51:01,430 [17   ] c.Infrastructure.ControllerActionInvoker - Executing action method ABPTest.Web.Host.Controllers.HomeController.TestHttpClient (ABPTest.Web.Host) - Validation state: Valid
INFO  2020-08-15 20:51:01,433 [17   ] ttp.HttpClient.TestClient.LogicalHandler - Start processing HTTP request GET https://www.baidu.com/
ERROR 2020-08-15 20:51:03,026 [15   ] Mvc.ExceptionHandling.AbpExceptionFilter - Cannot access a disposed object.
Object name: 'ABPTest.Web.Host.TestClientMiddelware'.
System.ObjectDisposedException: Cannot access a disposed object.
Object name: 'ABPTest.Web.Host.TestClientMiddelware'.
   at System.Net.Http.DelegatingHandler.CheckDisposed()
   at System.Net.Http.DelegatingHandler.SetOperationStarted()
   at System.Net.Http.DelegatingHandler.SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
   at ABPTest.Web.Host.TestClientMiddelware.<>n__0(HttpRequestMessage request, CancellationToken cancellationToken)
   at ABPTest.Web.Host.TestClientMiddelware.SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) in D:\TestProgram\ABPTestGitHub\ABPHttpClientTest\5.7.0\aspnet-core\src\ABPTest.Web.Host\TestClientMiddelware.cs:line 12
   at Microsoft.Extensions.Http.Logging.LoggingScopeHttpMessageHandler.SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
   at System.Net.Http.HttpClient.FinishSendAsyncUnbuffered(Task`1 sendTask, HttpRequestMessage request, CancellationTokenSource cts, Boolean disposeCts)
   at System.Net.Http.HttpClient.GetStringAsyncCore(Task`1 getTask)
   at ABPTest.Web.Host.TestClient.GetTest(String url) in D:\TestProgram\ABPTestGitHub\ABPHttpClientTest\5.7.0\aspnet-core\src\ABPTest.Web.Host\TestClient.cs:line 33
   at ABPTest.Web.Host.Controllers.HomeController.TestHttpClient() in D:\TestProgram\ABPTestGitHub\ABPHttpClientTest\5.7.0\aspnet-core\src\ABPTest.Web.Host\Controllers\HomeController.cs:line 23
   at lambda_method(Closure , Object )
   at Microsoft.Extensions.Internal.ObjectMethodExecutorAwaitable.Awaiter.GetResult()
   at Microsoft.AspNetCore.Mvc.Infrastructure.ActionMethodExecutor.AwaitableObjectResultExecutor.Execute(IActionResultTypeMapper mapper, ObjectMethodExecutor executor, Object controller, Object[] arguments)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeActionMethodAsync>g__Logged|12_1(ControllerActionInvoker invoker)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeNextActionFilterAsync>g__Awaited|10_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Rethrow(ActionExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeInnerFilterAsync>g__Awaited|13_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeNextExceptionFilterAsync>g__Awaited|25_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
INFO  2020-08-15 20:51:03,031 [15   ] .Mvc.Infrastructure.ObjectResultExecutor - Executing ObjectResult, writing value of type 'Abp.Web.Models.AjaxResponse'.
INFO  2020-08-15 20:51:03,034 [15   ] c.Infrastructure.ControllerActionInvoker - Executed action ABPTest.Web.Host.Controllers.HomeController.TestHttpClient (ABPTest.Web.Host) in 1627.9669ms
INFO  2020-08-15 20:51:03,037 [15   ] ft.AspNetCore.Routing.EndpointMiddleware - Executed endpoint 'ABPTest.Web.Host.Controllers.HomeController.TestHttpClient (ABPTest.Web.Host)'
INFO  2020-08-15 20:51:03,039 [15   ] Microsoft.AspNetCore.Hosting.Diagnostics - Request finished in 1642.5265ms 500 application/json; charset=utf-8

```

who can help me ?
