var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddMcpServer()
    // Stateless is the default in SDK 2.x. If older clients that use the
    // initialize handshake need sessions, use this instead:
    //   .WithHttpTransport(options => options.SessionMode =
    //       ModelContextProtocol.AspNetCore.HttpServerSessionMode.StatefulForInitializeClients)
    .WithHttpTransport()
    .WithToolsFromAssembly();

var app = builder.Build();
app.MapMcp();
app.Run();
