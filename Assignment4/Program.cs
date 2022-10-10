using Assignment4.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UserLogginMiddleware();

app.Run();
