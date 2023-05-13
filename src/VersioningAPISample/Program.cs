using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    var title = "My Versioned API";
    var description = "This is a versioning API sample.";
    var terms = new Uri("https://localhost:7259/terms");
    var license = new OpenApiLicense()
    {
        Name = "This sample !is licensed."
    };
    var contact = new OpenApiContact()
    {
        Name = "MH Rastegari",
        Email = "MH.Rastegari@outlook.com",
        Url = new Uri("https://mhrastegari.github.io")
    };

    options.SwaggerDoc("v1", new OpenApiInfo()
    {
        Version = "v1",
        Title = $"{title} v1",
        Description = description,
        TermsOfService = terms,
        License = license,
        Contact = contact,
    });

    options.SwaggerDoc("v2", new OpenApiInfo()
    {
        Version = "v2",
        Title = $"{title} v2",
        Description = description,
        TermsOfService = terms,
        License = license,
        Contact = contact,
    });
});

builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new(1, 0);
    options.ReportApiVersions = true;
});

builder.Services.AddVersionedApiExplorer(options =>
{
    options.GroupNameFormat = "'v'VVV";
    options.SubstituteApiVersionInUrl = true;
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v2/swagger.json", "v2");
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
