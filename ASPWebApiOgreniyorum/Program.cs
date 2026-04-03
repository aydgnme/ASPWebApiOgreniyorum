var builder = WebApplication.CreateBuilder(args);

// Ek hizmetleri ekleyin
builder.Services.AddControllers();
// Bu satır, uygulamanın API denetleyicilerini (Controllers) kullanarak gelen istekleri yönlendirmesini sağlar. Bu, API'nin çalışması için gereklidir.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Bu satırlar, Swagger'ı etkinleştirir ve API'nizin belgelenmesini sağlar. Swagger, API'nizin nasıl kullanılacağını görsel olarak göstermek için kullanılır.
// dotnet add package Swashbuckle.AspNetCore
// Bu komut, Swashbuckle.AspNetCore paketini projenize ekler. Bu paket, Swagger'ı ASP.NET Core uygulamanızda kullanmanızı sağlar.

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapGet("/", () => "Merhaba, ASP.NET Core Web API'ye hoş geldiniz!");
// Bu satır, uygulamanın kök URL'sine ("/") bir GET isteği yapıldığında "Merhaba, ASP.NET Core Web API'ye hoş geldiniz!" mesajını döndürmesini sağlar.
app.UseHttpsRedirection();
// Bu satır, uygulamanın HTTP isteklerini HTTPS'ye yönlendirmesini sağlar. Bu, güvenliği artırmak için önemlidir.
app.MapControllers();
// Bu satır, uygulamanın API denetleyicilerini (Controllers) kullanarak gelen istekleri yönlendirmesini sağlar. Bu, API'nin çalışması için gereklidir.
app.Run();