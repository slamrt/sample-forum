var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    //при возникновении исключения/ошибки перенаправляет на "/error", чтобы сообщить 
    //об этом пользователю
    app.UseExceptionHandler("/Error");
    //для безопасности, чтобы использовался ssl сертификат
    //каждый раз когда сайт будет открываться через http, браузер будет перенаправлен 
    //на https
    app.UseHsts();
}

//настройка параметров переадресации
app.UseHttpsRedirection();

//компонент для отправки статических файлов клиенту
app.UseStaticFiles();

//проверяет соответствие маршрута и
//подбирает наиболее подходящие ответ на запрос по конкретному маршруту н-р: /profile
app.UseRouting();

//встроенный компонент для определения прав пользователя
app.UseAuthorization();

app.MapRazorPages();

app.Run();
