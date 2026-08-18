var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddOpenApi();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    //Renderiza a interface gráfica
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint(
          "/openapi/v1.json",
          "FIAP API v1"
        );
    });
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();