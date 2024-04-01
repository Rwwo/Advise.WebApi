using advise.webapi.api.Extensions;
using advise.webapi.application;
using advise.webapi.infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder
    .AddSwaggerConfig()
    .Services
        .AddInfrastructureModule(builder.Configuration)
        ;

builder.Services.AddApplicationModule();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("Development");
}
else
{
    app.UseCors("Production");
}

app.ConfigureCustomExceptionHandler();
//app.UseExceptionHandler();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

