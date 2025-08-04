using WebServiceLivros.Services;

var builder = WebApplication.CreateBuilder(args);

// Serviços
builder.Services.AddSingleton<LivroService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuração do CORS (mover para antes do Build)
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirSPA", policy =>
    {
        policy.WithOrigins("http://localhost:5173") // Porta padrão do Vite
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// Middleware
app.UseCors("PermitirSPA");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
