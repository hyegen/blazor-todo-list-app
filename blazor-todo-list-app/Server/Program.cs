using blazor_todo_list_app.Server.Data.Interfaces;
using blazor_todo_list_app.Server.Data.Repositories;
using blazor_todo_list_app.Server.Services.Concrete;
using blazor_todo_list_app.Server.Services.Interfaces;
using Blazored.Modal;
using Context;
using Microsoft.EntityFrameworkCore;
using Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddDbContext<ToDoContext>(options =>
         options.UseSqlServer(builder.Configuration.GetConnectionString("sqlconnection")));
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddScoped<ITodoRepository, TodoRepository>();
builder.Services.AddScoped<ITodoService, TodoService>();
builder.Services.AddScoped<IMailService, MailService>();

builder.Services.AddBlazoredModal();

builder.Services.AddCors(options =>
{
    options.AddPolicy("ToDoPolicy",
        builder =>
        {
            builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()
                .SetIsOriginAllowedToAllowWildcardSubdomains();
        });
});

var app = builder.Build();
app.UseCors("ToDoPolicy");

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
